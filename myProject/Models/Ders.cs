//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ders()
        {
            this.Kayit = new HashSet<Kayit>();
        }
    
        public int dersId { get; set; }
        public int dersKatId { get; set; }
        public string dersAdi { get; set; }
        public int dersKredi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kayit> Kayit { get; set; }
    }
}
