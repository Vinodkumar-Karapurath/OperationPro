//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OperationPro
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_JOB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_JOB()
        {
            this.TBL_MainMaster = new HashSet<TBL_MainMaster>();
        }
    
        public int ID { get; set; }
        public string JobTitle { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_MainMaster> TBL_MainMaster { get; set; }
    }
}
