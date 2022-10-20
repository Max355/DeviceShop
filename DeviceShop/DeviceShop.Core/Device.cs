using System.ComponentModel.DataAnnotations;

namespace DeviceShop.Models
{
    public class Device
    {
        [Key]

        public int DeviceId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Rating { get; set; }
    }
}
