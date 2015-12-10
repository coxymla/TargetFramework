using System;

namespace TargetFramework
{
    public class SequenceItem
    {
        public string Description { get; set; }
        public SequenceItemType Type { get; set; }
        public bool[] Relays { get; set; }
        public int Delay { get; set; }
    }

    public enum SequenceItemType
    {
        Array,
        Delay,
    }

    [Flags]
    enum Relays : byte
    {
        None = 0,
        Relay1 = 128,
        Relay2 = 64,
        Relay3 = 32,
        Relay4 = 16,
        Relay5 = 8,
        Relay6 = 4,
        Relay7 = 2,
        Relay8 = 1,
    };
}