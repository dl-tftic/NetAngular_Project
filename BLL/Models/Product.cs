using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Revision { get; set; }
        public List<ProductCategory> Categories { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateBy { get; set; }
    }
}
