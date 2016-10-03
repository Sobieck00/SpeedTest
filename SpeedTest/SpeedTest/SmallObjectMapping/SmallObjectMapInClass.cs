﻿using SpeedTest.Interfaces;
using SpeedTest.TestObjects.DTO;

namespace SpeedTest.SmallObjectMapping
{
    public class SmallObjectMapInClass : SmallObjectMappingBase
    {
        public override IEmployee TestableAct()
        {
            return new EmployeeDto
            {
                EmployeeNumber = testObject.EmployeeNumber,
                Name = testObject.Name,
                PayPerHour = testObject.PayPerHour,
                Position = testObject.Position
            };
        }
    }
}