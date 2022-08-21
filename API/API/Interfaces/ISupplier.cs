using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace API.Interfaces
{
    public interface ISupplier
    {
        List<Supplier> GetAll();
        Supplier GetById(int id);
        void Create(Supplier supplier);

        void Update(Supplier supplier);

        void Delete(Supplier supplier);
    }
}
