public interface IItem
{
    string name
    {
        get;
        set;
    }

    string lore
    {
        get;
        set;
    }

    public void onItemGet();
}