using BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface ISubCategory
    {
        public Category SubCategory { get; set; }

        public Files Files { get; set; }
    }
}
