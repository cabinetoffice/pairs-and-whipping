//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Triad.CabinetOffice.Slipping.Data.EntityFramework.Slipping
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.AbsenceRequests = new HashSet<AbsenceRequest>();
            this.AbsenceRequests1 = new HashSet<AbsenceRequest>();
            this.AbsenceRequestOppositionMPs = new HashSet<AbsenceRequestOppositionMP>();
            this.AbsenceRequestOppositionMPs1 = new HashSet<AbsenceRequestOppositionMP>();
            this.AbsenceRequestReasons = new HashSet<AbsenceRequestReason>();
            this.AbsenceRequestStatus = new HashSet<AbsenceRequestStatus>();
            this.MembersOfParliaments = new HashSet<MembersOfParliament>();
            this.MembersOfParliaments1 = new HashSet<MembersOfParliament>();
            this.User1 = new HashSet<User>();
            this.UserMPs1 = new HashSet<UserMP>();
            this.UserMPs = new HashSet<UserMP>();
        }
    
        public int ID { get; set; }
        public string Username { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Forenames { get; set; }
        public string Surname { get; set; }
        public bool IsMP { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<bool> IsPawsUser { get; set; }
        public Nullable<bool> IsSlippingUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbsenceRequest> AbsenceRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbsenceRequest> AbsenceRequests1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbsenceRequestOppositionMP> AbsenceRequestOppositionMPs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbsenceRequestOppositionMP> AbsenceRequestOppositionMPs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbsenceRequestReason> AbsenceRequestReasons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbsenceRequestStatus> AbsenceRequestStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MembersOfParliament> MembersOfParliaments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MembersOfParliament> MembersOfParliaments1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User1 { get; set; }
        public virtual User User2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserMP> UserMPs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserMP> UserMPs { get; set; }
    }
}
