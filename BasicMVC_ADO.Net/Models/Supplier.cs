using System.ComponentModel.DataAnnotations;

namespace BasicMVC_ADO.Net.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Supplier name")]
        [Display(Name = "Supplier Name")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "Please enter Contact No.")]
        [Display(Name = "Contact No.")]

        public int ContactNo { get; set; }

        [Required(ErrorMessage = "Please enter Email")]
        public string Email { get; set; }
        public string Address { get; set; }


    }
}