using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
   
    public class SupplierController : BaseController
    {
    
        private readonly ISupplier _supplierService;

        public SupplierController(ISupplier supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpGet]
        public ActionResult<List<Supplier>> GetAll()
        {
            var item =_supplierService.GetAll();
            return Ok(item);
        }


        [HttpGet("{id}", Name = "GetSupplier")]
        public IActionResult GetById(int id)
        {
            var item = _supplierService.GetById(id);

            if (item == null)
            {
                return NotFound();
            }

            return new ObjectResult(item);
        }


        [HttpPost]
        public IActionResult Create(Supplier supplier)
        {
            if (supplier == null)
            {
                return BadRequest();
            }
            _supplierService.Create(supplier);

            return GetById(supplier.Id);
        }


        [HttpPut("{id}")]
        public IActionResult Update(int id,Supplier supplier) 
        {
            if (supplier == null || supplier.Id != id)
            {
                return BadRequest();
            }

            var supplierHolder =  _supplierService.GetById(id);

            if (supplier == null)
            {
                return NotFound();
            }

            supplierHolder.FirstName = supplier.FirstName;
            supplierHolder.LastName = supplier.LastName;

            _supplierService.Update(supplier);

            return new NoContentResult();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var supplier = _supplierService.GetById(id);

            if (supplier == null)
            {
                return NotFound();
            }
            _supplierService.Delete(supplier);
            return new NoContentResult();
        }

    }


}
