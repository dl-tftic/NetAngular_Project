using System;
using System.Collections.Generic;
using System.Text;
using BLL.Models;

namespace BLL.Interface
{
    public interface IRolesService
    {
        Roles Get(int id);
    }
}
