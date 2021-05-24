using System;
using System.Collections.Generic;
using System.Text;
using NetCore.API.Proj.DBServices;
using NetCore.API.Proj.Services;
using NSubstitute;
using NUnit.Framework;

namespace Test.App.NUnit3
{
    public class VehicleServiceShould
    {

        private IVehicleService _service;

        private IDatabaseService _mockDbService;

        [SetUp]
        public void Setup()
        {
            this._service = Substitute.For<IVehicleService>();
            this._mockDbService = Substitute.For<IDatabaseService>();

            _mockDbService.Save().Returns("Save is Mocked");


        }

        [Test]
        public void TestDBSave_WithMock()
        {
            VehicleService vehicleSvc = new VehicleService(_mockDbService);
            string result = vehicleSvc.SaveService();

            TestContext.Progress.WriteLine(result);

            Assert.AreEqual("Save is Mocked", result);
        }

        [Test]
        public void Test_Save_SqlDB()
        {
            IDatabaseService dbService = new SqlDbService();
            VehicleService vehicleSvc = new VehicleService(dbService);
            string result = vehicleSvc.SaveService();

            TestContext.Progress.WriteLine(result);


            Assert.AreEqual("Saved to SQL Database", result);
        }

        [Test]
        public void Test_Save_OracleDB()
        {
            IDatabaseService dbService = new OracleDbService();
            VehicleService vehicleSvc = new VehicleService(dbService);
            string result = vehicleSvc.SaveService();

            TestContext.Progress.WriteLine(result);


            Assert.AreEqual("Saved to Oracle database", result);
        }

    }
}
