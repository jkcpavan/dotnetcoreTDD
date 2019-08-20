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
            var testctrlr=new InfoController();
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
            var testctrlr=new LastNameDAO();
            Assert.NotNull(testctrlr);
        }
        [Fact]
        public void Test_GetLastName_method_dao()
        {
            var testctrlr=new LastNameDAO();
            Assert.NotNull(testctrlr.getLastName("test"));
        }
        [Fact]
        public void Test_GetLastName_method_returntype_dao()
        {
            var testctrlr=new LastNameDAO();
            Assert.IsType<InfoName>(testctrlr.getLastName("test"));
        }
        [Fact]
        public void Test_GetLastName_method_returnnotempty_dao()
        {
            var testctrlr=new LastNameDAO();
            Assert.IsType<InfoName>(testctrlr.getLastName("test"));
            Assert.NotNull(testctrlr.getLastName("test").FirstName);
            Assert.NotNull(testctrlr.getLastName("test").LastName);
            Assert.Equal("test",testctrlr.getLastName("test").FirstName);
        }
        public void Dispose()
        {
        }
    }
}
