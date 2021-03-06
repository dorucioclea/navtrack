using System;
using System.Collections.Generic;
using System.Linq;
using Navtrack.Common.Util;

namespace Navtrack.Api.Model.Assets
{
    public class TripModel
    {
        public TripModel()
        {
            Locations = new List<LocationModel>();
        }

        public int Number { get; set; }
        public DateTime? StartDate => Locations?.FirstOrDefault()?.DateTime;
        public DateTime? EndDate => Locations?.LastOrDefault()?.DateTime;
        public List<LocationModel> Locations { get; }
        public double Distance =>
            DistanceCalculator.GetDistance(Locations.Select(x => (x.Latitude, x.Longitude)).ToList());
    }
}