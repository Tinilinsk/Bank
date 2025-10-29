namespace Bank
{
    public class Konto
    {
        private string _id { get; set; }
        private string _name { get; set; }
        private int _balance { get; set; }

        public Konto(string id, string name, int balance)
        {
            _id = id;
            _name = name;
            _balance = balance;
        }
        public string getName()
        {
            return _name;
        }
        public void setName(string name)
        {
            _name = name;
        }
        public int getBalance()
        {
            return _balance;
        }
        public void setBalance(int balance)
        {
            _balance = balance;
        }
        public string getId()
        {
            return _id;
        }


    }
}
