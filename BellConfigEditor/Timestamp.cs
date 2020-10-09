using System;

namespace BellConfigEditor
{
    public class Timestamp : IComparable<Timestamp>
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }

        private int GetTimeInSeconds()
        {
            return hour * 3600 + minute * 60 + second;
        }

        public int CompareTo(Timestamp other)
        {
            return GetTimeInSeconds().CompareTo(other.GetTimeInSeconds());
        }

        public override string ToString()
        {
            return $"{hour}:{minute}:{second}";
        }
    }
}
