﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbemsEntities : DbContext
    {
        public dbemsEntities()
            : base("name=dbemsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<dbContact> dbContacts { get; set; }
        public virtual DbSet<dbEquipment> dbEquipments { get; set; }
        public virtual DbSet<dbLocation> dbLocations { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dbContacts_Insert(ObjectParameter contactID, string fullName, Nullable<bool> type, string email, string address, string imageUrl, string birthday, string phone, string position, string company)
        {
            var fullNameParameter = fullName != null ?
                new ObjectParameter("FullName", fullName) :
                new ObjectParameter("FullName", typeof(string));
    
            var typeParameter = type.HasValue ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(bool));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var imageUrlParameter = imageUrl != null ?
                new ObjectParameter("ImageUrl", imageUrl) :
                new ObjectParameter("ImageUrl", typeof(string));
    
            var birthdayParameter = birthday != null ?
                new ObjectParameter("Birthday", birthday) :
                new ObjectParameter("Birthday", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var positionParameter = position != null ?
                new ObjectParameter("Position", position) :
                new ObjectParameter("Position", typeof(string));
    
            var companyParameter = company != null ?
                new ObjectParameter("Company", company) :
                new ObjectParameter("Company", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dbContacts_Insert", contactID, fullNameParameter, typeParameter, emailParameter, addressParameter, imageUrlParameter, birthdayParameter, phoneParameter, positionParameter, companyParameter);
        }
    
        public virtual int sp_dbContacts_Update(ObjectParameter contactID, string fullName, Nullable<bool> type, string email, string address, string imageUrl, string birthday, string phone, string position, string company)
        {
            var fullNameParameter = fullName != null ?
                new ObjectParameter("FullName", fullName) :
                new ObjectParameter("FullName", typeof(string));
    
            var typeParameter = type.HasValue ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(bool));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var imageUrlParameter = imageUrl != null ?
                new ObjectParameter("ImageUrl", imageUrl) :
                new ObjectParameter("ImageUrl", typeof(string));
    
            var birthdayParameter = birthday != null ?
                new ObjectParameter("Birthday", birthday) :
                new ObjectParameter("Birthday", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var positionParameter = position != null ?
                new ObjectParameter("Position", position) :
                new ObjectParameter("Position", typeof(string));
    
            var companyParameter = company != null ?
                new ObjectParameter("Company", company) :
                new ObjectParameter("Company", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dbContacts_Update", contactID, fullNameParameter, typeParameter, emailParameter, addressParameter, imageUrlParameter, birthdayParameter, phoneParameter, positionParameter, companyParameter);
        }
    
        public virtual int sp_dbLocations_Insert(ObjectParameter locationID, string locationName, string contactPerson, string contactEmail, string contactPhone, string locationAddress, string imageUrl)
        {
            var locationNameParameter = locationName != null ?
                new ObjectParameter("LocationName", locationName) :
                new ObjectParameter("LocationName", typeof(string));
    
            var contactPersonParameter = contactPerson != null ?
                new ObjectParameter("ContactPerson", contactPerson) :
                new ObjectParameter("ContactPerson", typeof(string));
    
            var contactEmailParameter = contactEmail != null ?
                new ObjectParameter("ContactEmail", contactEmail) :
                new ObjectParameter("ContactEmail", typeof(string));
    
            var contactPhoneParameter = contactPhone != null ?
                new ObjectParameter("ContactPhone", contactPhone) :
                new ObjectParameter("ContactPhone", typeof(string));
    
            var locationAddressParameter = locationAddress != null ?
                new ObjectParameter("LocationAddress", locationAddress) :
                new ObjectParameter("LocationAddress", typeof(string));
    
            var imageUrlParameter = imageUrl != null ?
                new ObjectParameter("ImageUrl", imageUrl) :
                new ObjectParameter("ImageUrl", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dbLocations_Insert", locationID, locationNameParameter, contactPersonParameter, contactEmailParameter, contactPhoneParameter, locationAddressParameter, imageUrlParameter);
        }
    
        public virtual int sp_dbLocations_Update(ObjectParameter locationID, string locationName, string contactPerson, string contactEmail, string contactPhone, string locationAddress, string imageUrl)
        {
            var locationNameParameter = locationName != null ?
                new ObjectParameter("LocationName", locationName) :
                new ObjectParameter("LocationName", typeof(string));
    
            var contactPersonParameter = contactPerson != null ?
                new ObjectParameter("ContactPerson", contactPerson) :
                new ObjectParameter("ContactPerson", typeof(string));
    
            var contactEmailParameter = contactEmail != null ?
                new ObjectParameter("ContactEmail", contactEmail) :
                new ObjectParameter("ContactEmail", typeof(string));
    
            var contactPhoneParameter = contactPhone != null ?
                new ObjectParameter("ContactPhone", contactPhone) :
                new ObjectParameter("ContactPhone", typeof(string));
    
            var locationAddressParameter = locationAddress != null ?
                new ObjectParameter("LocationAddress", locationAddress) :
                new ObjectParameter("LocationAddress", typeof(string));
    
            var imageUrlParameter = imageUrl != null ?
                new ObjectParameter("ImageUrl", imageUrl) :
                new ObjectParameter("ImageUrl", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dbLocations_Update", locationID, locationNameParameter, contactPersonParameter, contactEmailParameter, contactPhoneParameter, locationAddressParameter, imageUrlParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
