namespace Lol.Database.Entites.Schema
{
    public class History
    {
        public int Seq { get; set; }
        public string GameType { get; set; }
        public string Champion { get; set; }
        public string MapType { get; set; }
        public string Spell { get; set; }
        public string Item { get; set; }
        public string Result { get; set; }
        public DateTime Created { get; set; }
        public string GameTime { get; set; }
        public string GameDate { get; set; }
        public int Money { get; set; }
        public int Cs { get; set; }
        public int K { get; set; }
        public int D { get; set; }
        public int A { get; set; }
        public int Level { get; set; }
        public string Spell1 { get; set; }
        public string Spell2 { get; set; }
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string Item4 { get; set; }
        public string Item5 { get; set; }
        public string Item6 { get; set; }
        public string Item7 { get; set; }
        public string Percent { get; set; }
        public double ActivePercent { get; set; }
        public string Concept { get; set; }
        public string ConceptName { get; set; }

        public string KDA => string.Format("{0} / {1} / {2}", K, D, A);
    }

}
