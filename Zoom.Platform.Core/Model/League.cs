using System;
using System.Collections.Generic;
using System.Text;

namespace Zoom.Platform.Core.Model
{
   public class League : BaseEntity
    {
        public string Iamge { get; set; }
        public string PhoneNumber { get; set; }
        public string Details { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public Guid OwnerId { get; set; }
        public Guid PlayGroundId { get; set; }


    }
}
