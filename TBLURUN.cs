//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntitiyFreamwork
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLURUN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLURUN()
        {
            this.TBLSATIS = new HashSet<TBLSATIS>();
        }
    
        public int URUNID { get; set; }
        public string URUNAD { get; set; }
        public string URUNMARKA { get; set; }
        public Nullable<short> STOK { get; set; }
        public Nullable<decimal> FİYAT { get; set; }
        public Nullable<bool> DURUM { get; set; }
        public Nullable<int> KATEGORİ { get; set; }
    
        public virtual TBLKATEGORİ TBLKATEGORİ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSATIS> TBLSATIS { get; set; }
    }
}
