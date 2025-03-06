public class TakimUye
{
    public TakimUye(int id, string isim, string soyisim)
    {
        Id = id;
        Isım = isim;
        SoyIsım = soyisim;
        takimlistesi.Add(this);
    }
    public TakimUye()
    {

    }
    public static List<TakimUye> takimlistesi = new List<TakimUye>();
    private int id;
    private string isim;
    private string soyisim;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public string Isım
    {
        get => isim;
        set => isim = value;
    }
    public string SoyIsım
    {
        get => soyisim;
        set => soyisim = value;
    }

}