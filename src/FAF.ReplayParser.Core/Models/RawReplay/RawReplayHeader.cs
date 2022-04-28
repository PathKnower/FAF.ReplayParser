namespace FAF.ReplayParser.Core.Models.RawReplay
{
    public class RawReplayHeader
    {
        public long uid { get; set; }
        public bool complete { get; set; }
        public string state { get; set; }
        public string featured_mod { get; set; }
        public string game_type { get; set; }
        public string recorder { get; set; }
        public string host { get; set; }
        public double launched_at { get; set; }
        public double game_end { get; set; }
        public string title { get; set; }
        public string mapname { get; set; }
        public int num_players { get; set; }
        public int version { get; set; }
        public string compression { get; set; }
        public IEnumerable<Dictionary<string, string[]>> teams { get; set; }
        public Dictionary<string, int> featured_mod_versions { get; set; }
    }
}
