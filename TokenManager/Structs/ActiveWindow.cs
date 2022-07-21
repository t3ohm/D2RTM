using TokenManager.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TokenManager.Helpers.AudioHelper;

namespace TokenManager.Structs
{
    public class ActiveWindow
    {
        public Process Process;
        public Profile Profile;
        public ISimpleAudioVolume VolumeControl;
    }
}
