//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mercuryshop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ADMIN
    {
        public int Id { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
    
        public virtual InfAdmin InfAdmin { get; set; }
    }
}
