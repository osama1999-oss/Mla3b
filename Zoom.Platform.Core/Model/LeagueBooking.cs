using System;
using System.Collections.Generic;
using System.Text;
using Zoom.Platform.Core.Model.Enums;

namespace Zoom.Platform.Core.Model
{
   public class LeagueBooking
    {
        public Guid UserId { get; set; }
        public Guid LeagueId { get; set; }
        public BookinStatus BookinStatus { get; set; }
    }
}
