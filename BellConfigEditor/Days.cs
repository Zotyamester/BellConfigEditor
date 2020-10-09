using System;

namespace BellConfigEditor
{
    public class Days : IComparable<Days>
    {

        public bool mo { get; set; } = false;
        public bool tu { get; set; } = false;
        public bool we { get; set; } = false;
        public bool th { get; set; } = false;
        public bool fr { get; set; } = false;
        public bool sa { get; set; } = false;
        public bool su { get; set; } = false;

        private int Sum()
        {
            return Convert.ToInt32(mo) + Convert.ToInt32(tu) + Convert.ToInt32(we) + Convert.ToInt32(th) + Convert.ToInt32(fr) + Convert.ToInt32(sa) + Convert.ToInt32(su);
        }

        public int CompareTo(Days other)
        {
            return Sum().CompareTo(other.Sum());
        }

        public override string ToString()
        {
            return $"{Convert.ToInt32(mo)}{Convert.ToInt32(tu)}{Convert.ToInt32(we)}{Convert.ToInt32(th)}{Convert.ToInt32(fr)}{Convert.ToInt32(sa)}{Convert.ToInt32(su)}";
        }

    }
}
