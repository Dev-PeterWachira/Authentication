using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class UserResponseDto
    {
        public Guid Id {get; set;}

        public string Username {get; set;} = string.Empty;
    }
}