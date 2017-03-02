using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rentcar.Cars.Dto
{
    [AutoMap(typeof(Car))]
    public class CarDto : FullAuditedEntityDto
    {
        public string Model { get; set; }
        public string Year { get; set; }
        public int Status { get; set; }
    }
}
