//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OCM.Core.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserCommentType
    {
        public UserCommentType()
        {
            this.UserComments = new HashSet<UserComment>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
    
        public virtual ICollection<UserComment> UserComments { get; set; }
    }
}
