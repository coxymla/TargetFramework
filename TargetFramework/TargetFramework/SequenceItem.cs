namespace TargetFramework
{
    public class SequenceItem
    {
        public string Description { get; set; }
        public SequenceItemType Type { get; set; }
    }

    public enum SequenceItemType
    {
        Array,
        Delay,
    }
}