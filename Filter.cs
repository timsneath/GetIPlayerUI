using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetIPlayerUI
{
    public partial class Interop
    {
        public Dictionary<string, string> ProgramFilter = new Dictionary<string, string> 
        {
            {"TVAllEpisodes", "--type=tv"},
            {"ChildrensTV", "--category=child --type=tv"},
            {"AdultOrientated", "--exclude-category=child --type=tv"},
            {"BBC1", "--channel=\"BBC One"},
            {"BBC2", "--channel=\"BBC Two"},
            {"BBC3", "--channel=\"BBC Three"},
            {"BBC4", "--channel=\"BBC Four"},
            {"BBCSport", "--channel=\"BBC Sport"},
            
            {"RadioAllEpisodes", "--type=radio"},
            {"RadioNewInLast24Hours", "--since=24 --type=radio"},
            {"Radio1", "--channel=\"BBC Radio 1\" --type=radio"},
            {"Radio2", "--channel=\"BBC Radio 2\" --type=radio"},
            {"Radio3", "--channel=\"BBC Radio 3\" --type=radio"},
            {"Radio4", "--channel=\"BBC Radio 4\" --type=radio"},
            {"Radio4X", "--channel=\"BBC Radio 4 extra\" --type=radio"},
            {"Radio5", "--channel=\"BBC Radio 5 live\" --type=radio"},
            {"Radio6", "--channel=\"BBC 6 music\" --type=radio"},
            {"RadioWS", "--channel=\"BBC World Service\" --type=radio"}
        };
    }
}
