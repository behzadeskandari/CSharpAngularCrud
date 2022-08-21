using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

        public List<Supplier> GetAll()
        {
            var t = _dbContext.Supplier.ToList();
            return t;
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
