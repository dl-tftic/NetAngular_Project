﻿using System.Collections.Generic;
using BLL.Models;

namespace BLL.Interface
{
    public interface IContactInfoService
    {
        public ContactInfo Get(int id);
        public List<ContactInfo> GetByAccountId(int id);

    }
}