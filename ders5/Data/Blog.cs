//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ders5.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public System.DateTime Published_at { get; set; }
        public int UserId { get; set; }
    
        public virtual User User { get; set; }
    }
}
