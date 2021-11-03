public interface IEvidence
{
    string name
    {
        get;
        set;
    }

    int id
    {
        get;
        set;
    }

    string lore
    {
        get;
        set;
    }

    public void OnEvidenceRetrieve();
}
