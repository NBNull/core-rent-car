using Abp.Application.Services.Dto;
using rentcar.Cars;
using rentcar.Cars.Dto;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace rentcar.Tests.Cars
{
    public class CarAppService_Tests : rentcarTestBase
    {
        private readonly ICarAppService _carAppService;

        public CarAppService_Tests()
        {
            _carAppService = Resolve<ICarAppService>();
        }
        [Fact]
        public async Task GetCars_Test()
        {
            var dto = new PagedAndSortedResultRequestDto();
            var output = await _carAppService.GetAll(dto);

            output.Items.Count.ShouldBe(0);
        }

        [Fact]
        public async Task CreateCar_Test()
        {
            await _carAppService.Create(
                 new CarDto
                 {
                     Model = "206",
                     Status = 0,
                     Year = "2017"
                 });

            await UsingDbContextAsync(async context =>
            {
                var carro = await context.Cars.FirstOrDefaultAsync(c => c.Model == "206");
                carro.ShouldNotBeNull();
            });
        }

        [Fact]
        public async Task RentCar_Test()
        {
            CarDto carDto;
            carDto = await _carAppService.Create(
                 new CarDto
                 {
                     Model = "206",
                     Status = 0,
                     Year = "2017"
                 });


            carDto.Status = 1;
            await _carAppService.Update(carDto);

            await UsingDbContextAsync(async context =>
            {
                var carro = await context.Cars.FirstOrDefaultAsync(c => c.Id == carDto.Id);
                carro.ShouldNotBeNull();
                carro.Status.ShouldBe(carDto.Status);
            });
        }
    }
}
