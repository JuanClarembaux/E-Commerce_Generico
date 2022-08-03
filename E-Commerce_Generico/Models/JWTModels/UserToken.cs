namespace E_Commerce_Generico.Models.JWTModels
{
    public class UserToken
    {
        public string Username { get; set; } = string.Empty;
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; }
    }
}
