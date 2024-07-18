using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestWebApp.Models
{
    public class Transaction
    {

        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Type")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characters only")]
        public string BeneficiaryTypeName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characters only")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only")]
        public string SWIFTCode { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public int Amount { get; set; }

        [DisplayName("Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime createdDate { get; set; }

    }
}
