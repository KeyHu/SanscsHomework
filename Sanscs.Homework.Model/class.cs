//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sanscs.Homework.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class @class
    {
        public @class()
        {
            this.students = new HashSet<student>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<student> students { get; set; }
    }
}
