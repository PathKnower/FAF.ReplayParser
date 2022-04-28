namespace FAF.ReplayParser.Core.Models.RawReplay.GameInfo
{
    internal class Formation
    {
        private readonly float[] _formationCoordinates;

        public Formation(params float[] formationCoordinates)
        {
            _formationCoordinates = formationCoordinates;
        }

        public float w => _formationCoordinates[0]; // ??????
        public float X_Coordinate => _formationCoordinates[1];
        public float Y_Coordinate => _formationCoordinates[2];
        public float Z_Coordinate => _formationCoordinates[3];
        public float Scale => _formationCoordinates[4];
    }
}
