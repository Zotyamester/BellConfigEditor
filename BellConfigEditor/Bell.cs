using System;
using System.Collections.Generic;

namespace BellConfigEditor
{
    public class Bell : IComparable<Bell>
    {
        public string soundfile { get; set; }
        public Days days { get; set; }
        public List<Timestamp> timestamps;

        public int CompareTo(Bell other)
        {
            int cmp;
            cmp = soundfile.CompareTo(other.soundfile);
            if (cmp != 0)
                return cmp;
            cmp = -days.CompareTo(other.days);
            if (cmp != 0)
                return cmp;
            return -timestamps.Count.CompareTo(other.timestamps.Count);
        }

        public override string ToString()
        {
            return $"{soundfile}{days}";
        }
    }
}
