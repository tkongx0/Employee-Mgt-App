//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmpMgtApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Addresses { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public string Supervisor { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime HireDate { get; set; }
    }
}
