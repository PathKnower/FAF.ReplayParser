namespace FAF.ReplayParser.Core.Models.RawReplay.GameInfo
{
    internal class Position
    {
        private readonly float[] _pos;

        public Position(params float[] position)
        {
            _pos = position;
        }

        public float X_Coordinate => _pos[0];
        public float Y_Coordinate => _pos[1];
        public float Z_Coordinate => _pos[2];
    }
}
