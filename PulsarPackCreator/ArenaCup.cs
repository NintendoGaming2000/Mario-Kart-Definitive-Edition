public class ArenaCup
{
    public int CupIndex { get; set; }        // 0-based cup index
    public string CupName { get; set; }      // optional cup display name
    public List<Arena> Arenas { get; set; } = new List<Arena>(); // expected 4 per cup (configurable)
}
