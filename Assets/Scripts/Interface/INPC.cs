public interface INPC
{
    string name
    {
        get;
        set;
    }

    public void OnInteractStart();

    public void OnInteractFinish();
}