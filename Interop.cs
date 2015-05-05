using System;
using System.Collections.Generic;
using System.IO;

namespace GetIPlayerUI
{
    public partial class Interop
    {
        public string Call(string command, bool showWindow)
        {
            string retVal = "";

            try
            {
                System.Diagnostics.Debug.WriteLine(command);
                var procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd ", "/c " + command);

                procStartInfo.WorkingDirectory = @"C:\Program Files (x86)\get_iplayer";
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

        public ProgramSet ProgramsAvailable(string filter = "")
        {
            var ps = new ProgramSet();

            string progs = this.Call("get_iplayer.cmd --listformat \"<index>,<name>,<episode>,<seriesnum>,<episodenum>,<channel>,<type>,<duration>,<desc>\" " + filter, false);
            System.IO.StringReader sr = new System.IO.StringReader(progs);

            // ignore header
            string line;
            do
            {
                line = sr.ReadLine();
            } while (!line.StartsWith("Matches:"));

            line = sr.ReadLine();
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
                line = sr.ReadLine();
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
            this.Call("get_iplayer.cmd --get " + progs + " --modes=flashvhigh", true);
        }

        public Dictionary<string, string> GetProgramInfo(int progId)
        {
            Dictionary<string, string> programInfo = new Dictionary<string, string>();

            string progInfoRaw = this.Call("get_iplayer.cmd --info " + progId, false);

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
    }
}
