using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_API.IRepository;
using Hotel_API.Model;

namespace Hotel_API.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<CountryModel> Countries { get; }
        IGenericRepository<HotelModel> Hotels { get; }

        Task Save();
    }
}