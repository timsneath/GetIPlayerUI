using System;
using System.Collections.Generic;
using System.IO;

namespace GetIPlayerUI
{
    /// <summary>
    /// This class provides methods that abstract the get-iplayer CLI. It is necessarily somewhat brittle
    /// because it is scraping the output rather than accessing a formal API. Most methods call the 
    /// underlying Call() method, which spins up a process and returns the result. This method is marked 
    /// public so it can be called directly for the many functions provided by get-iplayer that are not
    /// cleanly wrapped. 
    /// </summary>
    public partial class Interop
    {
        private const string APP_NAME = "get_iplayer.cmd";

        public string Call(string command, bool useProxy = true, bool showWindow = true)
        {
            string retVal = "";
            string proxy = "--proxy \"http://" + Properties.Settings.Default.ProxyUsername +
                ":" + Properties.Settings.Default.ProxyPassword + 
                "@" + Properties.Settings.Default.ProxyServerName +
                ":" + Properties.Settings.Default.ProxyPassword;

            try
            {
                command = APP_NAME + " " + command;

                if (useProxy)
                {
                    command += " " + proxy;
                }

                System.Diagnostics.Debug.WriteLine(command);

                var procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd ", "/c " + command);

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
            }
            
            return retVal;
        }

        public ProgramSet ProgramsAvailable(string filter = "", bool forceRefresh = false)
        {
            var ps = new ProgramSet();
            string callParams = "--listformat \"<index>,<name>,<episode>,<seriesnum>,<episodenum>,<channel>,<type>,<duration>,<desc>\" " + filter;

            if (forceRefresh)
            {
                callParams += " --force";
            }

            string progs = this.Call(callParams, false, false);
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

        public void RecordPrograms(int[] programIDs)
        {
            string progs = "";
            foreach(var progID in programIDs)
            {
                progs += progID.ToString() + " ";
            }
            this.Call("get_iplayer.cmd --get " + progs + " --modes=flashvhigh", true, true);
        }

        public Dictionary<string, string> GetProgramInfo(int progId)
        {
            Dictionary<string, string> programInfo = new Dictionary<string, string>();

            string progInfoRaw = this.Call("get_iplayer.cmd --info " + progId, false, false);

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
            string output = Call("get_iplayer.cmd --show-cache-age --type " + type, false, false);

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
