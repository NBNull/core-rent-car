using Abp.Application.Services;
using rentcar.Cars.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;

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

       
        public async Task UpdateRentCar(EntityDto<int> input)
        {
            var car = await _repository.GetAsync(input.Id);
            car.Status = 1;
            await _repository.UpdateAsync(car);
        }
    }
}
