using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XieChengAPI.Models
{
    public class TouristRoutePicture
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public Guid TouristRouteId { get; set; }
        public TouristRoute tourist1;
        
    }
}
