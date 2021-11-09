public interface IEvidence
{
    string Name
    {
        get;
        set;
    }

    int ID
    {
        get;
        set;
    }

    string Lore
    {
        get;
        set;
    }

    public void OnEvidenceRetrieve();
}
