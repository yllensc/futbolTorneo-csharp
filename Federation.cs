namespace futbolTorneo;

public class Federation
{
    private string _strID;
    private string _strName;
    private string _strDate;
    private string _strHomeTown;

    public Federation(string strName, string strDate, string strHomeTown)
    {
        this._strID = Guid.NewGuid().ToString();
        this._strName = strName;
        this._strDate = strDate;
        this._strHomeTown = strHomeTown;
    }
    public string strID
    {
        get
        {
            return _strID;
        }
        set
        {
            _strID = value;
        }
    }
    public string strName{
        get{
            return _strName;
        }
        set{
            _strName = value;
        }
    }
    public string strHomeTown{
        get{
            return _strHomeTown;
        }
        set {
            _strHomeTown = value;
        }
    }

     public string StrDate
    {
        get
        {
            return _strDate;
        }
        set
        {
            if (IsValidDate(value, out string formattedDate))
            {
                _strDate = formattedDate;
            }
            else
            {
                throw new ArgumentException("Invalid date format. Please provide a valid date in the format 'YYYY-MM-DD'.");
            }
        }
    }

    private bool IsValidDate(string inputDate, out string formattedDate)
    {
        if (DateTime.TryParseExact(inputDate, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime result))
        {
            formattedDate = result.ToString("yyyy-MM-dd");
            return true;
        }

        formattedDate = null;
        return false;
    }
}
