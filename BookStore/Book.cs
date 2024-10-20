//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.Sales = new HashSet<Sale>();
        }
    
        public int BookID { get; set; }
        public string Name { get; set; }
        public int AuthorID { get; set; }
        public int PublishingHouseID { get; set; }
        public int Pages { get; set; }
        public int GenreID { get; set; }
        public System.DateTime PublishingDate { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public bool IsSequel { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Updated { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual PublishingHous PublishingHous { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
