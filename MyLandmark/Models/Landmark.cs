using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLandmark.Models
{
    public class Landmark
    {
        public Landmark()
        {
            this.Longitude = 0D;
            this.IsPrivate = false;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public bool IsPrivate { get; set; }
        public System.DateTime CreatedDate { get; set; }
    }
}