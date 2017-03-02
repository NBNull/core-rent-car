using Abp.Application.Services;
using rentcar.Cars.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;

namespace rentcar.Cars
{
    public class CarAppService : AsyncCrudAppService<Car, CarDto>, ICarAppService
    {
        private readonly IRepository<Car> _repository;
        public CarAppService(IRepository<Car> repository) 
            : base(repository)
        {
            _repository = repository;
        }
    }
}
