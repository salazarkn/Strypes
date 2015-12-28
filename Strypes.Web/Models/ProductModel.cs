using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strypes.Web.Models
{
    public class ProductModel
    {
       
        public string _id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public string Category { get; set; }

        public string CategoryId { get; set; }
    }
}