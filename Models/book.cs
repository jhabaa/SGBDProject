//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGBDProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class book
    {
        public string book_id { get; set; }
        public int pageNber { get; set; }
        public string title { get; set; }
        public string autor { get; set; }
        public decimal caution { get; set; }
        public string type { get; set; }
        public int quantity { get; set; }
    
        public virtual exemplar exemplar { get; set; }
    }
}
