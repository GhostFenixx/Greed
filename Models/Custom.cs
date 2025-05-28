namespace Greed.Models
{
    public class Custom
    {
        public bool EnableCustom { get; set; }
        public bool LoggerIntoServer { get; set; }
        public bool DisableSPTFriend { get; set; }
        public bool DisableCommando { get; set; }

        public bool DisablePMCMessages { get; set; }

        public bool CustomCheck1 { get; set; }
        public bool CustomCheck2 { get; set; }
        public bool CustomCheck3 { get; set; }
        public bool CustomCheck4 { get; set; }

        public int CustomNumber1 { get; set; } = 12345;
        public int CustomNumber2 { get; set; } = 12345;
        public int CustomNumber3 { get; set; } = 12345;
        public int CustomNumber4 { get; set; } = 12345;
    }
}
