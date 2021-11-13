using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_API.IRepository;
using Hotel_API.Model;
using Hotel_API.Repository.IRepository;

namespace Hotel_API.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;

        private IGenericRepository<CountryModel> _countries;
        private IGenericRepository<HotelModel> _hotels;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IGenericRepository<CountryModel> Countries => _countries ??= new GenericRepository<CountryModel>(_context);

        public IGenericRepository<HotelModel> Hotels => _hotels ??= new GenericRepository<HotelModel>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}