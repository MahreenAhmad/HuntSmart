//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HuntSmart.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmailVerificationCode
    {
        public int EmailVerifiationCode_Id { get; set; }
        public string EmailVerificationCode_Value { get; set; }
        public System.DateTime EmailVerificationCode_CreationTime { get; set; }
        public int EmailVerificationCode_UserId { get; set; }
    
        public virtual User User { get; set; }
    }
}