using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyLandmark.Models
{
    public class MLMContext:DbContext
    {
        public DbSet<Landmark> Landmarks { get; set;}
    }
}