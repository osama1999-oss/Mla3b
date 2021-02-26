using System;
using System.Collections.Generic;
using System.Text;

namespace Zoom.Platform.Core.Model
{
  public class BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
