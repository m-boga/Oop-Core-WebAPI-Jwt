using System.ComponentModel.DataAnnotations;

namespace Hotel.UI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Hizmet Icon Giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Title Giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet Des Giriniz")]
        [StringLength(150,ErrorMessage ="Hizmet başlığı max 150 karakter olabilir.")]
        public string Description { get; set; }
    }
}
