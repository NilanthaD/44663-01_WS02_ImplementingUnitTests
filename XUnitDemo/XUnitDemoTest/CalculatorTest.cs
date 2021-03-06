﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using XUnitDemo;

namespace XUnitDemoTest
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_Test()
        {
            double expected = 5;
            double actual = Calculator.Add(3, 2.0);
            Assert.Equal(expected, actual);
        }       

        [Theory]
        [InlineData(5, 3, 2)] // Pass test
        [InlineData(4, 7, -3)] // pass test
        [InlineData(-6, -3, -3)] // pass test
        [InlineData(5.25, 2.75, 2.5)]// pass test
        [InlineData(Double.MaxValue, Double.MaxValue, 20)] // passs test - Edge test
        public void Add_PassTestMultipleParameterSets(double a, double b, double c)
        {
            double expected = a;
            double actual = Calculator.Add(b, c);
            Assert.Equal(expected, actual);          
        }

        [Theory]
        [InlineData(6,2,3)]
        [InlineData(-4,3,-6)]
        

        public void Add_FailTestMultipleParameterSets(double a, double b, double c)
        {
            double expected = a;
            double actual = Calculator.Add(b, c);
            Assert.Equal(expected, actual);
        }
    }
}
