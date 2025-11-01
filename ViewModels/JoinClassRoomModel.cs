using System.ComponentModel.DataAnnotations;

namespace EduHub.ViewModels
{
    public class JoinClassRoomModel
    {
        [Required]
        public string? ClassRoomUnicCode { get; set; }
    }
}
