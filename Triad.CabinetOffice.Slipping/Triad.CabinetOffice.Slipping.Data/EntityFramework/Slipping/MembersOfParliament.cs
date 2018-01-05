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
    
    public partial class MembersOfParliament
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MembersOfParliament()
        {
            this.AbsenceRequests = new HashSet<AbsenceRequest>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string Forenames { get; set; }
        public string Surname { get; set; }
        public string ListAs { get; set; }
        public string FullName { get; set; }
        public System.DateTime FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string EmailAddress { get; set; }
        public string Mobile { get; set; }
        public string GovernmentPosition { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<int> ConstituencyID { get; set; }
        public int PartyID { get; set; }
        public string MemberID { get; set; }
        public string DodsID { get; set; }
        public string PimsID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> LastChangedBy { get; set; }
        public Nullable<System.DateTime> LastChangedDate { get; set; }
        public Nullable<int> FlockID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbsenceRequest> AbsenceRequests { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
