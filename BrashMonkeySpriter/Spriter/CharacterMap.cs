using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrashMonkeySpriter.Spriter {
    public class CharacterMap {
        public int Id { get; set; }
        public String Name { get; set; }
        public MapInstruction[] Maps { get; set; }
    }

    public class MapInstruction {
        public int Folder;
        public int File;

        public int TargetFolder;
        public int TargetFile;
    }
}