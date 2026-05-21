namespace Entities
{
    public class User
    {
        public string Username {get; set;} = string.Empty;

        public Guid Id {get; set;}

        public string PasswordHash {get; set;} = string.Empty;
    }
}