using System;
using System.Collections.Generic;
using System.Text;
using Zoom.Platform.Core.Model.Enums;

namespace Zoom.Platform.Core.Model
{
   public class Member:BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Iamge { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
      //  public Roles Role { get; set; }

     
    
    }
}
