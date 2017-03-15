using Abp.Application.Services;
using Abp.Application.Services.Dto;
using rentcar.Cars.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rentcar.Cars
{
    public interface ICarAppService : IAsyncCrudAppService<CarDto>, IApplicationService
    {
        Task UpdateRentCar(EntityDto<int> input);
    }
}
