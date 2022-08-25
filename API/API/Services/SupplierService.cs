using API.Data;
using API.Entities;
using API.Filter;
using API.Interfaces;
using API.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class SupplierService : ISupplier
    {
        private readonly AppDbContext _dbContext;

        public SupplierService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(Supplier supplier)
        {
            _dbContext.Supplier.Add(supplier);
            saveChanges();
        }

        public void Delete(Supplier supplier)
        {
            _dbContext.Supplier.Remove(supplier);
            saveChanges();
        }

        public PagedResponse<List<Supplier>> GetAll(PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var pagedData =  _dbContext.Supplier.Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                .Take(validFilter.PageSize).ToList();
            var totalRecords =  _dbContext.Supplier.Count();

            var item = new PagedResponse<List<Supplier>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
            //var t = _dbContext.Supplier.ToList();
            
            return item;
        }

        public Supplier GetById(int id)
        {
            var item = _dbContext.Supplier.AsNoTracking().FirstOrDefault(t => t.Id == id);

            return item;
        }

        public void Update(Supplier supplier)
        {
            _dbContext.Entry(supplier).State = EntityState.Modified;
            _dbContext.Supplier.Update(supplier);
            saveChanges();
        }

        public int saveChanges()
        {
            int intReturendValue = _dbContext.SaveChanges();
            return intReturendValue;
        }
    }
}
