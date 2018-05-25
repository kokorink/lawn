using System;
using System.Data.Entity;
using System.Linq;
using DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainModelTests
{
    [TestClass]
    public class ServiceTypeRepositoryTests
    {
        [TestMethod]
        public void GetAllTestServiceType()
        {
            ServiceType TestServiceType = new ServiceType { nameService = "GetAllName", priceService = 100 };
            GenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            int startCount = RepST.GetAll().Count();
            RepST.Add(TestServiceType);
            RepST.Save();
            var test = RepST.GetAll();
            int findByClientCount = RepST.GetAll().Count();
            Assert.AreEqual(findByClientCount, startCount+1);
            Assert.IsInstanceOfType(test, typeof(DbSet<ServiceType>));
            RepST.Delete(TestServiceType);
            RepST.Save();
        }

        [TestMethod]
        public void FindByTestServiceType()
        {
            ServiceType TestServiceType = new ServiceType { nameService = "FindByName", priceService = 100 };
            GenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            RepST.Add(TestServiceType);
            RepST.Save();
            ServiceType findByClient = RepST.FindBy(item => item.nameService == "FindByName").First();
            Assert.AreEqual(findByClient.priceService, 100);
            RepST.Delete(TestServiceType);
            RepST.Save();
        }

        [TestMethod]
        public void AddTestServiceType()
        {
            GenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            ServiceType TestServiceType = new ServiceType { nameService = "AddTestName", priceService = 100 };
            int count = RepST.GetAll().Where(item => item.priceService == 100).Count();
            RepST.Add(TestServiceType);
            RepST.Save();
            Assert.AreEqual(count + 1, RepST.FindBy(item => item.priceService == 100).Count());
            RepST.Delete(TestServiceType);
            RepST.Save();
        }

        [TestMethod]
        public void DeleteTestServiceType()
        {
            GenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            ServiceType TestServiceType = new ServiceType { nameService = "DeleteTestClient", priceService = 100 };
            RepST.Add(TestServiceType);
            RepST.Save();
            int count = RepST.GetAll().Where(item => item.nameService == "DeleteTestClient").Count();
            RepST.Delete(TestServiceType);
            RepST.Save();
            Assert.AreEqual(count - 1, RepST.FindBy(item => item.nameService == "DeleteTestClient").Count());

        }

        [TestMethod]
        public void EditTestServiceType()
        {
            GenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            ServiceType TestServiceType = new ServiceType { nameService = "EditTestName", priceService = 100 };
            RepST.Add(TestServiceType);
            RepST.Save();
            TestServiceType = RepST.FindBy(item => item.nameService == "EditTestName").FirstOrDefault();
            TestServiceType.priceService = 150;
            RepST.Edit(TestServiceType);
            RepST.Save();
            Assert.AreNotEqual(RepST.FindBy(item => item.nameService == "EditTestName").FirstOrDefault().priceService, 100);
            Assert.AreEqual(RepST.FindBy(item => item.nameService == "EditTestName").FirstOrDefault().priceService, 150);
            RepST.Delete(TestServiceType);
            RepST.Save();
        }

        [TestMethod]
        public void SaveTestServiceType()
        {
            GenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            ServiceType TestServiceType = new ServiceType { priceService = 100, nameService = "SaveTestName" };
            RepST.Add(TestServiceType);
            int count = RepST.GetAll().Where(item => item.nameService == "SaveTestName").Count();
            RepST.Save();
            Assert.AreEqual(count + 1, RepST.GetAll().Where(item => item.nameService == "SaveTestName").Count());
            RepST.Delete(TestServiceType);
            RepST.Save();
        }
    }
}
