namespace futbolTorneo;

    public class Federation
    {
        private string strID;
        private string strName;
        private string strDate;
        private string strHomeTown;

        public Federation(string _strName, string _strDate, string _strHomeTown){
            this.strID = Guid.NewGuid().ToString();
            this.strName= _strName;
            this.strDate= _strDate;
            this.strHomeTown=_strHomeTown;
        }
    }   
