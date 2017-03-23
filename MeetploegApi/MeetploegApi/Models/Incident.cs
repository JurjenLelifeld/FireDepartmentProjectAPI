//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeetploegApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Incident
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Incident()
        {
            this.Assignments = new HashSet<Assignment>();
            this.Messages = new HashSet<Message>();
            this.GpsLocation = new HashSet<GpsLocation>();
        }
    
        public int Id { get; set; }
        public string Address { get; set; }
        public int GasMoldCode { get; set; }
        public string GasMoldColor { get; set; }
        public int WindDirection { get; set; }
        public System.DateTime Time { get; set; }
        public string Type { get; set; }
        public string Details { get; set; }
        public bool Active { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assignment> Assignments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GpsLocation> GpsLocation { get; set; }
    }
}