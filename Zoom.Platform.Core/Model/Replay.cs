using System;
using System.Collections.Generic;
using System.Text;

namespace Zoom.Platform.Core.Model
{
   public class Replay
    {
        public Guid Id { get; set; }
        public string Text { get; set; }

        public Guid CommentId { get; set; }
        public Guid UserId { get; set; }
    }
}
