namespace FAF.ReplayParser.Core.Models.RawReplay
{
    internal class CommandsStream
    {
        public byte CurrentSource { get; set; }

        public uint CurrentTick { get; set; }

        public List<OP> Ops { get; set; }
    }
}
