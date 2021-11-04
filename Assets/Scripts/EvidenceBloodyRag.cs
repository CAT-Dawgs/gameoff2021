public class EvidenceBloodRag : IEvidence
{
    public string Name { get; set; }
    public int ID { get; set; }
    public string Lore { get; set; }
    public void OnEvidenceRetrieve()
    {
        throw new System.NotImplementedException();
    }
}