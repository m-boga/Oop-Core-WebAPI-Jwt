using System.ComponentModel.DataAnnotations;

namespace Hotel.UI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Hizmet Icon Giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Title Giriniz")]
        [StringLength(150, ErrorMessage = "Hizmet başlığı max 150 karakter olabilir.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet Des Giriniz")]
        [StringLength(1500, ErrorMessage = "Hizmet başlığı max 1500 karakter olabilir.")]
        public string Description { get; set; }
    }
}
