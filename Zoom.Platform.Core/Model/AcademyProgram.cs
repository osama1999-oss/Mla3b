using System;
using System.Collections.Generic;
using System.Text;

namespace Zoom.Platform.Core.Model
{
  public  class AcademyProgram
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public string Description { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }


        public Guid AcademyId { get; set; }
    }
}
