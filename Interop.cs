using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace GetIPlayerUI
{
    /// <summary>
    /// This class provides methods that abstract the get-iplayer CLI. It is necessarily somewhat brittle
    /// because it is scraping the output rather than accessing a formal API. Most methods depend on the 
    /// underlying Call() method, which spins up a process and returns the result. This method is marked 
    /// public so it can be called directly for the many functions provided by get-iplayer that are not
    /// cleanly wrapped. 
    /// </summary>
    public partial class Interop
    {
        // Specific command that we call. In the future might change this to call the Perl script directly.
        private const string APP_NAME = "get_iplayer.cmd";

        /// <summary>
        /// This method is a low-level wrapper around the get_iplayer command line interface. It creates
        /// an instance of the shell, passes the supplied parameters to get_iplayer and returns the result.
        /// <param name="parameters">Commands that should be supplied to get_iplayer. For example "--get 250" 
        /// would be passed here to download the TV / radio programme with ID 250.</param>
        /// <param name="useProxy">Use a proxy server if supplied. In general, this should be true where 
        /// program content is being downloaded, but can be false when the call is a request for metadata.</param>
        /// <param name="showWindow">Determines whether the command line window is hidden or shown to the user.</param>
        /// <returns>A string containing the output of get_iplayer.</returns>
        public string CallIPlayer(string parameters, bool useProxy = true, bool showWindow = true)
        {
            string proxy = "--proxy http://" + Properties.Settings.Default.ProxyUsername +
                ":" + Properties.Settings.Default.ProxyPassword + 
                "@" + Properties.Settings.Default.ProxyServerName +
                ":" + Properties.Settings.Default.ProxyPort;

            try
            {
                parameters = APP_NAME + " " + parameters;

                if (useProxy)
                {
                    parameters += " " + proxy;
                }

                System.Diagnostics.Debug.WriteLine(parameters);

                var procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd ", "/c " + parameters);

                procStartInfo.WorkingDirectory = Properties.Settings.Default.GetIPlayerPath;
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = !showWindow;

                var proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                return proc.StandardOutput.ReadToEnd();
            }
            catch (Exception ex)
            {
                // need to catch these for now so we can trace and surface in UI
                System.Diagnostics.Debug.Fail(ex.ToString());
                return String.Empty;
            }
        }

        public async Task<string> CallIPlayerAsync(string parameters, bool useProxy = true, bool showWindow = true)
        {
            var output = await Task<string>.Run(() =>
            {
                return CallIPlayer(parameters, useProxy, showWindow);
            });

            return output;

        }

        /// <summary>
        /// Returns a strongly-typed ProgramSet dataset filled with metadata on programmes available for download with
        /// a specified filter.
        /// </summary>
        /// <param name="filter">A filter to apply to the dataset. For example:
        ///     --channel "BBC One": returns all TV programmes shown on BBC One</param>
        ///     --search Weather: returns all programmes that match the keyword "weather"
        ///     --type radio: returns all radio programmes
        /// <returns>A ProgramSet dataset</returns>
        public ProgramSet ProgramsAvailable(string filter = "")
        {
            var ps = new ProgramSet();
            string callParams = "--listformat \"<index>,<name>,<episode>,<seriesnum>,<episodenum>,<channel>,<type>,<duration>,<desc>\" " + filter;

            string progs = this.CallIPlayer(callParams, false, false);
            var reader = new StringReader(progs);

            // ignore header
            string line;
            do
            {
                line = reader.ReadLine();
            } while (!line.StartsWith("Matches:"));

            line = reader.ReadLine();
            while (line != String.Empty)
            {
                var fields = line.Split(',');
                if (fields.Length >= 9)
                {
                    ps.Programs.AddProgramsRow(fields[0], fields[1], fields[2], fields[3], fields[4], 
                        fields[5], fields[6], fields[7], line.Substring(line.IndexOf(fields[8])), false);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Wrong number of fields: " + line);
                }
                line = reader.ReadLine();
            }

            return ps;
        }

        /// <summary>
        /// Records the programs specified by ID to the default directory.
        /// </summary>
        /// <param name="programIDs">An array of integers representing individual programmes.</param>
        public void RecordPrograms(int[] programIDs)
        {
            string progs = "";
            foreach(var progID in programIDs)
            {
                progs += progID.ToString() + " ";
            }
            this.CallIPlayer("--get " + progs + " --modes=best", true, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        public async Task RefreshCacheAsync(string filter="tv")
        {
            await CallIPlayerAsync("--refresh --type " + filter, false, false);
        }

        /// <summary>
        /// Retrieves supplemental program metadata for the specified program ID.
        /// </summary>
        /// <param name="progId">An integer representing the program ID for which metadata is to be retrieved.</param>
        /// <returns>Returns a dictionary of key, value pairs representing the various metadata attributes
        /// associated with a specific program ID.</returns>
        public Dictionary<string, string> GetProgramInfo(int progId)
        {
            Dictionary<string, string> programInfo = new Dictionary<string, string>();

            string progInfoRaw = this.CallIPlayer("get_iplayer.cmd --info " + progId, false, false);

            StringReader reader = new StringReader(progInfoRaw);

            // ignore initial spew from the program. First useful metadata is "available:"
            string header;
            do
            {
                header = reader.ReadLine();
            } while (!header.StartsWith("available"));

            string metadataItem, key, value; 

            metadataItem = header; // reuse 'available' field
            while (metadataItem != "")
            {

                key = metadataItem.Substring(0, metadataItem.IndexOf(':'));
                value = metadataItem.Substring(metadataItem.IndexOf(':')+1).TrimStart(' ');
                if (!programInfo.ContainsKey(key))
                {
                    programInfo.Add(key, value);
                }
                metadataItem = reader.ReadLine();
            }

            return programInfo;
        }

        /// <summary>
        /// Gets the age of the cache for the specified type.
        /// </summary>
        /// <param name="type">Type of media, e.g. "tv", "radio", "livetv"</param>
        /// <returns>An English string containing the length of time spanned since cache was 
        /// refreshed, or an empty string if the cache has not yet been created.</returns>
        public string GetCacheAge(string type="tv")
        {
            string output = CallIPlayer("--show-cache-age --type " + type, false, false);

            StringReader reader = new StringReader(output);

            string header;
            do
            {
                header = reader.ReadLine();
            } while (!header.Contains("cache age: ") && (header != null));

            if (header != null)
            {
                header = header.Substring(header.LastIndexOf(':') + 2);
                return header;
            }
            else
            {
                return String.Empty;
            }
        }

    }
}
