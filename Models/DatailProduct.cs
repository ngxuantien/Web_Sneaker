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
    
    public partial class DatailProduct
    {
        public string Name { get; set; }
        public int Product_Id { get; set; }
        public Nullable<double> Price { get; set; }
        public string Describe { get; set; }
        public string Img { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
