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
            try
            {
                supplier.Address = _addressService.Get(supplier.GetAddressId());
                return supplier;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Supplier IncludeContactInfor(Supplier supplier)
        {
            try
            {
                supplier.ContactInfos = _contactInfoService.GetBySupplierId(supplier.Id);
                return supplier;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Supplier IncludeAll(Supplier supplier)
        {
            try
            {
                return IncludeAddress(IncludeContactInfor(supplier));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Supplier Get(int id)
        {
            try
            {
                return IncludeAll(_supplierRepository.Get(id).ToBLL());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Delete(int id)
        {
            try
            {
                return _supplierRepository.DeleteById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
