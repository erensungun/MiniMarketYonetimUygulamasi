//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mini_Market_Veritabanı
{
    using System;
    using System.Collections.Generic;
    
    public partial class Elemanlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Elemanlar()
        {
            this.Fatura = new HashSet<Fatura>();
        }
    
        public int EleId { get; set; }
        public string EleAdi { get; set; }
        public int EleYasi { get; set; }
        public string EleTel { get; set; }
        public string EleSifre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fatura> Fatura { get; set; }
    }
}
