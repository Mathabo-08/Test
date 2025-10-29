using System.ComponentModel.DataAnnotations;

namespace Test.Data
{
    public class UserData
    {
        public int Id { get; set; } // Primary key

        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(100, ErrorMessage = "Full name cannot exceed 100 characters.")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Bank balance is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Bank balance must be a positive number.")]
        [DataType(DataType.Currency)]
        public decimal BankBalance { get; set; }
    }
}