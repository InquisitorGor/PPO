//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class visa_rates
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public visa_rates()
        {
            this.visas = new HashSet<visa>();
        }
    
        public int id { get; set; }
        public int validaty { get; set; }
        public Nullable<int> visa_type_id { get; set; }
        public Nullable<int> country_id { get; set; }
        public decimal payment { get; set; }
    
        public virtual country country { get; set; }
        public virtual visa_types visa_types { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<visa> visas { get; set; }
    }
}