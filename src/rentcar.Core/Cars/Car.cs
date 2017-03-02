using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;

namespace rentcar.Cars
{
    public class Car : FullAuditedEntity, ISoftDelete
    {
        public string Model { get; set; }
        public string Year { get; set; }
        public int Status { get; set; }
    }
}
