using API.Entities;
using API.Filter;
using API.Wrapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface ISupplier
    {
        PagedResponse<List<Supplier>> GetAll(PaginationFilter filter);
        Supplier GetById(int id);
        void Create(Supplier supplier);

        void Update(Supplier supplier);

        void Delete(Supplier supplier);
    }
}
