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
    
    public partial class visa
    {
        public int id { get; set; }
        public string number { get; set; }
        public System.DateTime date_of_issue { get; set; }
        public System.DateTime expirition_date { get; set; }
        public Nullable<int> client_id { get; set; }
        public Nullable<int> visa_rate_id { get; set; }
    
        public virtual client client { get; set; }
        public virtual visa_rates visa_rates { get; set; }
    }
}
