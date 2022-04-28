namespace FAF.ReplayParser.Core.Models.RawReplay
{
    // TODO: Figure out what the OP is
    internal class OP
    {
        public OP()
        {

        }

        public OP(ReplayContentCommand replayContentCommand, byte[] data)
        {
            _replayContentCommand = replayContentCommand;
        }

        private ReplayContentCommand _replayContentCommand;

        public byte[] Data { get; set; }
    }
}
