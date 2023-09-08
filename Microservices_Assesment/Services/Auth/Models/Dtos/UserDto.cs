using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.Models.Dtos
{
    public class UserDto
    {
        public string Id { get; set; }=string.Empty;
        public string Name { get; set; }=string.Empty;
        public string Email { get; set; }=string.Empty;
        public string PhoneNumber { get; set; }=string.Empty;
    }
}
