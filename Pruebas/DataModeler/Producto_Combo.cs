//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModeler
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto_Combo
    {
        public string C_Combo { get; set; }
        public string C_Producto { get; set; }
        public int Q_ProductoenCombo { get; set; }
    
        public virtual Combo Combo { get; set; }
        public virtual Producto Producto { get; set; }
    }
}