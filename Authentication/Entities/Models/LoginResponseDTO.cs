using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class LoginResponseDTO
    {
        public string Token {get; set;} = string.Empty;
    }
}