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

        private IContactInfoService _contactInfoService;

        public SupplierService(IAddressService addressService, IContactInfoService contactInfoService)
        {
            this._addressService = addressService;

            this._contactInfoService = contactInfoService;
        }

        private Supplier IncludeAddress(Supplier supplier)
        {
            supplier.Address = _addressService.Get(supplier.GetAddressId());
            return supplier;
        }

        private Supplier IncludeContactInfor(Supplier supplier)
        {
            supplier.ContactInfos = _contactInfoService.GetBySupplierId(supplier.Id);
            return supplier;
        }

        private Supplier IncludeAll(Supplier supplier)
        {
            return IncludeAddress(IncludeContactInfor(supplier));
        }

        public Supplier Get(int id)
        {
            return IncludeAll(_supplierRepository.Get(id).ToBLL());
        }
    }
}
