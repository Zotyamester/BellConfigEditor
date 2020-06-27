using System.Collections.Generic;

namespace BellConfigEditor
{
    public class Rule
    {
        public string soundfile { get; set; }
        public Days days { get; set; }
        public List<Timestamp> timestamps;

        public string Repr()
        {
            return $"{soundfile}{days}";
        }
    }
}
