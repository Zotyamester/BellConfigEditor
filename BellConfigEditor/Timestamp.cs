namespace BellConfigEditor
{
    public class Timestamp
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
        public Timestamp timestamp { get; set; }

        public string Repr()
        {
            return $"{hour}:{minute}:{second}";
        }
    }
}
