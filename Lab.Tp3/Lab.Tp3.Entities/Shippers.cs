namespace Lab.Tp3.Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Shippers
    {
        [Key]
        public int ShipperID { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }
    }
}
