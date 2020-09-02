namespace WpfApp1
{
    class myuser
    {
        public myuser(string name,string user, string email,string pass)
        {
            NAME = name;
            USER = user;
            EMAIL = email;
            PASSWORD = pass;
        }
           
        public string NAME { get; set; }
        public string USER { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
    }
}