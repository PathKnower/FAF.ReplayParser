namespace FAF.ReplayParser.Core.Models.RawReplay
{
    internal class RawReplayInfo
    {
        public RawReplayHeader Header { get; set; }
        public CommandsStream CommandsStream { get; set; }
        public Dictionary<byte, RawPlayer> Players { get; set; }
    }
}
