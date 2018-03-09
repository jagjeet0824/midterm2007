namespace DotNetMidtermA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Province
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Province()
        {
            Flights = new HashSet<Flight>();
        }

        public int ProvinceId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Province")]

        public string Name { get; set; }

        public decimal TaxRate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight> Flights { get; set; }

        internal static object OrderBy(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
