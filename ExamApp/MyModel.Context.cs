﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EgorEntities : DbContext
    {
        public EgorEntities()
            : base("name=EgorEntities")
        {
        }

        public EgorEntities(String connection)
            : this()
        {
            this.Database.Connection.ConnectionString = connection;
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<international_passports> international_passports { get; set; }
        public virtual DbSet<visa_rates> visa_rates { get; set; }
        public virtual DbSet<visa_types> visa_types { get; set; }
        public virtual DbSet<visa> visas { get; set; }
    
        public virtual ObjectResult<full_info_about_client_documents_Result> full_info_about_client_documents(Nullable<int> client_id)
        {
            var client_idParameter = client_id.HasValue ?
                new ObjectParameter("client_id", client_id) :
                new ObjectParameter("client_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<full_info_about_client_documents_Result>("full_info_about_client_documents", client_idParameter);
        }
       
    }
}
