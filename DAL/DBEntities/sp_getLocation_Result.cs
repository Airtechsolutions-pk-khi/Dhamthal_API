//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.DBEntities
{
    using System;
    
    public partial class sp_getLocation_Result
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public int LicenseID { get; set; }
        public Nullable<bool> DeliveryServices { get; set; }
        public Nullable<double> DeliveryCharges { get; set; }
        public string DeliveryTime { get; set; }
        public Nullable<double> MinOrderAmount { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string ImageURL { get; set; }
        public Nullable<int> BrandID { get; set; }
        public string Opentime { get; set; }
        public string Closetime { get; set; }
        public string Passcode { get; set; }
        public string Currency { get; set; }
        public Nullable<double> Discounts { get; set; }
        public Nullable<double> Tax { get; set; }
    }
}
