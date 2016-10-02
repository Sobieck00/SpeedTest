﻿using SpeedTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SpeedTest.TestObjects
{
    public class TestObject : ILargeObject
    {
        public int RInt { get; set; }
        public string RString { get; set; }
        public decimal RDecimal { get; set; }
        public double RDouble { get; set; }
        public int RInt2 { get; set; }
        public string RString2 { get; set; }
        public decimal RDecimal2 { get; set; }
        public double RDouble2 { get; set; }
        public TestEnum REnum { get; set; }
        public ICollection<TestEnum> REnumCollection { get; set; }
        public IList<TestEnum> REnumList { get; set; }
        public Guid RGuid { get; set; }
        public Employee TestObject2 { get; set; }
        public Employee TestObject3 { get; set; }
        public List<double> RList { get; set; }
        public IList<string> RList2 { get; set; }
        public Collection<int> RCollection { get; set; }
        public ICollection<bool> RCollection2 { get; set; }
        public List<Employee> RTestObject2List { get; set; }
        public ICollection<Employee> RTestObject2Collection { get; set; }
        public DateTime RDateTime { get; set; }
        public ICollection<short> LazyShorts { get; set; }
        public ICollection<List<Collection<bool>>> CrazyBools { get; set; }
        public string[] Strings { get; set; }
        public Employee[] RTestObject2Array { get; set; }
    }
}
