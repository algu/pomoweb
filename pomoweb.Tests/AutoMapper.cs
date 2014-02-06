using System;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using pomoweb.Models;


namespace pomoweb.Tests
{
    [TestFixture]
    public class AutoMapperConfigurationTester
    {
        [Test]
        public void Should_map_everything()
        {
            AutoMapperConfiguration.Configure();
            Mapper.AssertConfigurationIsValid();
        }
    }
}
