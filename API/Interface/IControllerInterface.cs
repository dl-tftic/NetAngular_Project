using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Interface
{
    public interface IControllerInterface<T>
    {
        //    GetAll = '/getAll',
        //GetById = '/getbyid',
        //GetByName = '/getByName',
        //Delete = '/delete',
        //Insert = '/insert'

        public IActionResult GetById(int id);

        public IActionResult GetAll();

        public IActionResult Insert(T t);

        public IActionResult Delete(int id);

        public IActionResult Update(T t);

    }
}
