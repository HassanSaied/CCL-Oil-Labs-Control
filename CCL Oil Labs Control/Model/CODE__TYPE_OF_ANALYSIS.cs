//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CCL_Oil_Labs_Control.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CODE__TYPE_OF_ANALYSIS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CODE__TYPE_OF_ANALYSIS()
        {
            this.CODE__ANALYSIS = new HashSet<CODE__ANALYSIS>();
        }
    
        public int COD_TYPE_ANALYSIS { get; set; }
        public string TYPE_ANALYSIS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CODE__ANALYSIS> CODE__ANALYSIS { get; set; }
    }
}
