using System;
using System.Collections.Generic;
using System.Text;

namespace Zoom.Platform.Core.Model
{
   public class Academy:BaseEntity
    {
        
        public string PhoneNumber { get; set; }
        public string Iamge { get; set; }
        public string Details { get; set; }


        public Guid OwnerId { get; set; }
        public Guid PlayGroundId { get; set; }
        public List<AcademyProgram> AcademyPrograms { get; set; }

    }
}
