namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table(" CustomerContactDetails")]
    public partial class C_CustomerContactDetails
    {
        [Key]
        [StringLength(50)]
        public string CustID { get; set; }

        [Required]
        [StringLength(50)]
        public string CustName { get; set; }

        public long CustPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string CustEmail { get; set; }

        [StringLength(50)]
        public string CustAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string CustCity { get; set; }

        [StringLength(50)]
        public string PostalCode { get; set; }
    }
}
