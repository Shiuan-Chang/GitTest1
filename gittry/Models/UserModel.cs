namespace gittry.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }

        public UserModel(string Name, string Email, string Address, string Password)
        {
            this.Name = Name;
            this.Email = Email;
            this.Address = Address;
            this.Password = Password;
        }
    }
}