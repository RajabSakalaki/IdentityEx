using System.ComponentModel.DataAnnotations;

namespace identityEx.Core.Dtos
{
    public class UpdatePermissionDTO
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }
    }
}
