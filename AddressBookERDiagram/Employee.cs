//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddressBookERDiagram
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int emp_Id { get; set; }
        public string emp_name { get; set; }
        public Nullable<int> company_id { get; set; }
        public Nullable<long> phoneNumber { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public string gender { get; set; }
        public bool isActive { get; set; }
    }
}
