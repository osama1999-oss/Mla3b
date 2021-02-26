using System;
using System.Collections.Generic;
using System.Text;
using Zoom.Platform.Core.Model.Enums;

namespace Zoom.Platform.Core.Model
{
   public class PlayGroundBooking
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime PlayIn { get; set; }
        public BookinStatus BookinStatus { get; set; }
        public Guid UserId { get; set; }
        public Guid PlayGroundId { get; set; }
    }
}
