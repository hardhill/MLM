using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyLandmark.Models
{
    public class MLMDbInitializer:DropCreateDatabaseAlways<MLMContext>
    {
        protected override void Seed(MLMContext context)
        {
            base.Seed(context);
        }

    }
}