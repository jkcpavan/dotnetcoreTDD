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

        //private readonly Mock<IConfiguration> _mockConfiguration;
        //private readonly Mock<IDbContainer> _mockDbContainer;

        //private readonly LastNameDAO dao;

        //public LastNameDaoTest()
        //{
        //    _mockConfiguration = new Mock<IConfiguration>();
        //    _mockDbContainer = new Mock<IDbContainer>();

        //    IDbContainer mockFunc(string connString) { connString = ""; return _mockDbContainer.Object; }

        //    dao = new LastNameDao(mockFunc, _mockConfiguration.Object);
        //}

        //[Fact]
        //public void CheckLastName_Response_Test()
        //{
        //    var request = 1;

        //    _mockDbContainer.Setup(dao => dao.ExecuteQueryProcedure(It.IsAny<string>(), It.IsAny<SqlParameter[]>())).Returns(new DataSet());

        //    var response = dao.CheckUserGroup(request);

        //    Assert.NotNull(response);
        //    Assert.IsType<DataSet>(response);
        //}
        //[Fact]
        //public void SaveLastName_Response_Test()
        //{
        //    string storedProcedure = null;
        //    SqlParameter[] parameters = null;

        //    var request = new SaveLastNameRequest()
        //    {
        //            FirstName = "test",
        //            LastName = 1
        //    };

        //    _mockDbContainer.Setup(dao => dao.ExecuteProcedure(It.IsAny<string>(), It.IsAny<SqlParameter[]>())).Returns(1).Callback<string, SqlParameter[]>((s, sp) => {
        //        storedProcedure = s;
        //        parameters = sp;
        //    });

        //    var response = dao.SaveNotification(request);

        //    Assert.Equal("[RWD].[usp_SaveNotification]", storedProcedure);
        //    Assert.Equal(11, parameters.Length);
        //}
        public void Dispose()
        {
        }
    }
}
