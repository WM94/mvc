//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ET
{
    using System;
    using System.Collections.Generic;
    
    public partial class Atrybut_Wartosc
    {
        public int Id { get; set; }
        public string Wartosc { get; set; }
        public int ID_PK { get; set; }
    
        public virtual Atrybut Atrybut { get; set; }
    }
}
