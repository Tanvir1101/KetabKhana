//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public Nullable<int> OrderId { get; set; }
        public string ShopName { get; set; }
        public Nullable<int> BookId { get; set; }
        public string BookName { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Status { get; set; }
    
        public virtual Shop Shop { get; set; }
        public virtual Order Order { get; set; }
        public virtual Shop Shop1 { get; set; }
    }
}
