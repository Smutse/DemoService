using System.ComponentModel.DataAnnotations;

namespace MeterReadingsService
{
    /// <summary>
    /// Object to hold account table data
    /// </summary>
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
