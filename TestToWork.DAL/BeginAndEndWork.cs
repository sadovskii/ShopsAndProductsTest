//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestToWork.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class BeginAndEndWork
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BeginAndEndWork()
        {
            this.ModeOfOperation = new HashSet<ModeOfOperation>();
            this.ModeOfOperation1 = new HashSet<ModeOfOperation>();
            this.ModeOfOperation2 = new HashSet<ModeOfOperation>();
            this.ModeOfOperation3 = new HashSet<ModeOfOperation>();
            this.ModeOfOperation4 = new HashSet<ModeOfOperation>();
            this.ModeOfOperation5 = new HashSet<ModeOfOperation>();
            this.ModeOfOperation6 = new HashSet<ModeOfOperation>();
        }
    
        public int IdWork { get; set; }
        public int Begin { get; set; }
        public int End { get; set; }
    
        public virtual Times Times { get; set; }
        public virtual Times Times1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModeOfOperation> ModeOfOperation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModeOfOperation> ModeOfOperation1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModeOfOperation> ModeOfOperation2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModeOfOperation> ModeOfOperation3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModeOfOperation> ModeOfOperation4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModeOfOperation> ModeOfOperation5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModeOfOperation> ModeOfOperation6 { get; set; }
    }
}