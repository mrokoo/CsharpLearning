namespace UserC
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        private string? _Coke;
        public string Coke
        {
            get
            {

                return _Coke ?? "nothing";
            }
            set
            {
                _Coke = value;
            }
        }
    }
}
