//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConAppAssignment8
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderId { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<short> Quantity { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<bool> isShipped { get; set; }
    }
}
