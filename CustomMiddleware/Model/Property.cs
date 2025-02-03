using System.ComponentModel.DataAnnotations;

namespace CustomMiddleware.Model
{
    public class Property
    {
        [Required(ErrorMessage = "Id is required")]
        public int id { get; set; }

        [Required(ErrorMessage = "Property Name is required")]
        public string name { get; set; }


        [Required(ErrorMessage = "Property Address is required")]
        public string Address { get; set; }


        [Range(1, 99999999, ErrorMessage = "Price must be between 1 and 99,999,999.")]
        public int price { get; set; }

    }
}
