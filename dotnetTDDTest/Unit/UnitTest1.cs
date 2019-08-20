using System;
using Xunit;
using dotnetTDDApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using dotnetTDDApi.DAO;
using dotnetTDDApi.models;

namespace coreTDDUnit
{
    public class ControllerTest : IDisposable
    {
        [Fact]
        public void Test_GetLastName_Controller()
        {
            var testctrlr = new InfoController();
            Assert.NotNull(testctrlr.getLastName("Test"));
        }
        public void Dispose()
        {
        }
    }


    public class DaoTest : IDisposable
    {
        [Fact]
        public void Test_GetLastName_dao()
        {
            var testctrlr = new LastNameDAO();
            Assert.NotNull(testctrlr);
        }
        [Fact]
        public void Test_GetLastName_method_dao()
        {
            var testctrlr = new LastNameDAO();
            Assert.NotNull(testctrlr.GetLastName("test"));
        }
        [Fact]
        public void Test_GetLastName_method_returntype_dao()
        {
            var testctrlr = new LastNameDAO();
            Assert.IsType<InfoName>(testctrlr.GetLastName("test"));
        }
        [Fact]
        public void Test_GetLastName_method_returnnotempty_dao()
        {
            var testctrlr = new LastNameDAO();
            Assert.IsType<InfoName>(testctrlr.GetLastName("test"));
            Assert.NotNull(testctrlr.GetLastName("test").FirstName);
            Assert.NotNull(testctrlr.GetLastName("test").LastName);
            Assert.Equal("test", testctrlr.GetLastName("test").FirstName);
        }

        [Fact]
        public void Test_DAO_Interface()
        {
            ILastNameDAO test = new LastNameDAO();
            Assert.NotNull(test);
            Assert.IsType<InfoName>(test.GetLastName("test"));
            Assert.NotNull(test.GetLastName("test").FirstName);
            Assert.NotNull(test.GetLastName("test").LastName);
            Assert.Equal("test", test.GetLastName("test").FirstName);
        }
        public void Dispose()
        {
        }
    }
}
