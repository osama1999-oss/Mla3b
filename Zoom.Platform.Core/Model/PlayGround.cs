using System;
using System.Collections.Generic;
using System.Text;
using Zoom.Platform.Core.Model.Enums;

namespace Zoom.Platform.Core.Model
{
   public class PlayGround:BaseEntity
    {
        public string From { get; set; }
        public string To { get; set; }
        public decimal PriceEvening { get; set; }
        public decimal PriceMorning { get; set; }
        public bool HasBall { get; set; }
        public bool HasWater { get; set; }
        public bool HasGarag { get; set; }
        public bool HasLoacker { get; set; }
        public bool HasShower { get; set; }
        public bool HasToilet { get; set; }
        public int Rating { get; set; }
        public PlaygroundStatus PlaygroundStatus { get; set; }


        public Guid OwnerId { get; set; }
    //    public List<Academy> Academies { get; set; }
    //    public List<League> Leagues { get; set; }
        public List<Comment> Comments { get; set; }
      public List<PreferredPlayGround> PreferredPlayGrounds { get; set; }
        public List<PlayGroundBooking> PlayGroundBookings { get; set; }


    }
}
