using System;
using System.Collections.Generic;
using System.Text;

namespace Zoom.Platform.Core.Model
{
  public  class Comment
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Text { get; set; }
        public Guid PlayGroundId { get; set; }
        public Guid UserId { get; set; }
        public List<Replay> Replays { get; set; }
    }
}
