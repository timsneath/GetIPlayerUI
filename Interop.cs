using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            string progs = this.Call("get_iplayer.cmd --listformat \"<index>,<name>,<episode>,<seriesnum>,<episodenum>,<version>,<channel>,<type>,<duration>\" " + filter, false);
            System.IO.StringReader sr = new System.IO.StringReader(progs);

            // ugly brute force. Where's Python when you need it? 
            var tfp = new Microsoft.VisualBasic.FileIO.TextFieldParser(sr);

            tfp.Delimiters = new string[] { "," };
            while (!tfp.EndOfData)
            {
                try
                {
                    string[] s = tfp.ReadFields();
                    if (s.Length == 9)
                    {
                        ps.Programs.AddProgramsRow(s[0], s[1], s[2], s[3], s[4], s[5], s[6], s[7], s[8], false);
                    }
                }
                catch (Microsoft.VisualBasic.FileIO.MalformedLineException)
                {
                    // whatever
                }
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
    }
}
