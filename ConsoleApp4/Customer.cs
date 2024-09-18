namespace ConsoleApp4
{
    internal class Customer
    {
        int _Cid;
        string _Cname, _State;
        bool _Status;
        double _Balance;
        Cities _City;
        public Customer(int Cid, string Cname, bool Status, double Balance, Cities City, string State,string Country)
        {
            _Cid = Cid;
            _Cname = Cname;
            _Status = Status;
            _Balance = Balance;
            _City = City;
            _State = State;
            this.Country = Country;

        }
        public int Cid
        {
            get { return _Cid; }
            set { _Cid = value; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string Cname
        {
            get { return _Cname; }
            set
            {
                if (_Status == true)
                    _Cname = value;
            }
        }
        public double Balance
        {
            get { return _Balance; }
            set
            {
                if (_Status == true)
                    _Balance = value;
            }
        }
        public Cities City
        {
            get { return _City; }
            set
            {
                if (_Status == true)
                {
                    _City = value;
                }
            }
        }
        public string State
        {
            get { return _State; }
            protected set
            {
                    if (_Status == true)
                    _State = value;
            }
        }
        public string Country//Auto-implemented
        {
            get;
            set;
        }
       // public string Country{get;}="india";


    }
}
