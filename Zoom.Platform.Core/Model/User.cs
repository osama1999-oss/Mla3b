using System;
using System.Collections.Generic;
using System.Text;

namespace Zoom.Platform.Core.Model
{
  public  class User:Member
    {
        
           public List<Comment> Comments { get; set; }
          public List<Replay> Replays { get; set; }
        public List<PreferredPlayGround> PreferredPlayGrounds { get; set; }
        public List<PlayGroundBooking> PlayGroundBookings { get; set; }
       //   public List<LeagueBooking> LeagueBookings { get; set; }
       //  public List<AcademyBooking> AcademyBookings { get; set; }
    }
}
