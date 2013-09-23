/*==========================================================================
 * Project: BrashMonkeySpriter
 * File: Timeline.cs
 *
 *==========================================================================
 * Author:
 * Geoff "NowSayPillow" Lodder
 *==========================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Xna.Framework;

namespace BrashMonkeySpriter.Spriter {
    public class TimelineList : List<Timeline> {
        public Timeline this[string p_name] {
            get { return this.FirstOrDefault(x => x.Name.ToLower() == p_name.ToLower()); }
        }
    }

    public class Timeline {
        public String Name;
        public List<TimelineKey> Keys;
        
        public int KeyAtOrBefore(int p_elapsedTime) {
            // Binary search correct key
            int l_lo = 0, l_hi = Keys.Count - 1;
            while ( l_hi - l_lo > 1) {
                int m = (l_hi + l_lo) / 2;
                if (Keys[m].Time > p_elapsedTime) l_hi = m - 1;
                else l_lo = m;
            }

            if (Keys[l_hi].Time < p_elapsedTime) {
                return l_hi;
            }

            return l_lo;            
        }
    }

    public struct TimelineKey {
        public TimelineType Type;
        public SpinDirection Spin;
        public Int32 Time;

        public Int32 Folder;
        public Int32 File;
        public Vector2 Location;
        public Vector2 Pivot;
        public float Rotation;
        public Vector2 Scale;
        public float Alpha;
    }
}
