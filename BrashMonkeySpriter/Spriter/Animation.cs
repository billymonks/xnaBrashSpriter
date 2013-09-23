/*==========================================================================
 * Project: BrashMonkeySpriter
 * File: Animation.cs
 *
 *==========================================================================
 * Author:
 * Geoff "NowSayPillow" Lodder
 *==========================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrashMonkeySpriter.Spriter {
    public class AnimationList : List<Animation> {
        public Animation this[string p_name] {
            get { return this.FirstOrDefault(x => x.Name.ToLower() == p_name.ToLower()); }
        }
    }

    public struct Animation {
        public String Name;
        public Int32 Length;
        public List<MainlineKey> MainLine;
        public TimelineList TimeLines;
        public bool Looping;
    }
}
