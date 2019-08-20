using System;
using Xunit;
using poi.Models;

namespace UnitTests
{
    public class HealthCheckUnitTests
    {
        [Fact]
        public void HealthCheckTestModel()
        {
            Assert.Equal("POI Service Healthcheck FAIL", new Healthcheck().Message);
            Assert.Equal("Healthy", new Healthcheck().Status);

        }
    }
}
