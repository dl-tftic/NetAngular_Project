using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAO.Repository;
using dto = DTO.Models;
using BLL.Models;
using BLL.Mappers;
using BLL.Interface;

namespace BLL.Services
{
    public class SupplierService : ISupplierService
    {
        SupplierRepository _supplierRepository = new SupplierRepository();

        private IAddressService _addressService;

        public SupplierService(IAddressService addressService)
        {
            this._addressService = addressService;
        }

        public Supplier Get(int id)
        {
            return _supplierRepository.Get(id).ToBLL();
        }
    }
}
