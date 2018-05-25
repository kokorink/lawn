using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainModelTests
{
    [TestClass]
    public class ClientRepositoryTests
    {
        [TestMethod]
        public void GetAllTestClient()
        {
            Client TestClient = new Client { clientName = "GetAllName", clientPhone = "GetAllPhone" };
            GenericRepository<Client> RepС = new GenericRepository<Client>();
            int GetAllClientCount = RepС.GetAll().Count();
            RepС.Add(TestClient);
            RepС.Save();
            var test = RepС.GetAll();
            Assert.AreEqual(test.Count(), GetAllClientCount + 1);
            Assert.IsInstanceOfType(test, typeof(DbSet<Client>));
            RepС.Delete(TestClient);
            RepС.Save();
        }

        [TestMethod]
        public void FindByTestClient()
        {
            Client TestClient = new Client { clientName = "FindByName", clientPhone = "FindByPhone" };
            GenericRepository<Client> RepС = new GenericRepository<Client>();
            RepС.Add(TestClient);
            RepС.Save();
            Client findByClient = RepС.FindBy(item => item.clientName == "FindByName").First();
            Assert.AreEqual(findByClient.clientPhone, "FindByPhone");
            RepС.Delete(TestClient);
            RepС.Save();
        }

        [TestMethod]
        public void AddTestClient()
        {
            //Arange 
            GenericRepository<Client> RepC = new GenericRepository<Client>();
            Client TestClient = new Client { clientName = "AddTestName", clientPhone = "AddTestPhone" };
            int count = RepC.GetAll().Where(item => item.clientPhone == "AddTestPhone").Count();
            //Act 
            RepC.Add(TestClient);
            RepC.Save();
            //Assert
            Assert.AreEqual(count + 1, RepC.FindBy(item => item.clientPhone == "AddTestPhone").Count());
            RepC.Delete(TestClient);
            RepC.Save();
        }

        [TestMethod]
        public void DeleteTestClient()
        {
            GenericRepository<Client> RepC = new GenericRepository<Client>();
            Client TestClient = new Client { clientName = "DeleteTestClient", clientPhone = "DeleteTestPhone" };
            RepC.Add(TestClient);
            RepC.Save();
            int count = RepC.GetAll().Where(item => item.clientName == "DeleteTestClient").Count();
            RepC.Delete(TestClient);
            RepC.Save();
            Assert.AreEqual(count - 1, RepC.FindBy(item => item.clientName == "DeleteTestClient").Count());

        }

        [TestMethod]
        public void EditTestClient()
        {
            GenericRepository<Client> RepC = new GenericRepository<Client>();
            Client TestClient = new Client { clientName = "EditTestName", clientPhone = "EditTestPhone" };
            RepC.Add(TestClient);
            RepC.Save();
            TestClient = RepC.FindBy(item => item.clientPhone == "EditTestPhone").FirstOrDefault();
            TestClient.clientPhone = "EditTestPhone_new";
            RepC.Edit(TestClient);
            RepC.Save();
            Assert.AreNotEqual(RepC.FindBy(item => item.clientPhone == "EditTestPhone").Count(), 1);
            Assert.AreEqual(RepC.FindBy(item => item.clientPhone == "EditTestPhone_new").Count(), 1);
            RepC.Delete(TestClient);
            RepC.Save();
        }
        
        [TestMethod]
        public void SaveTestClient()
        {
            GenericRepository<Client> RepC = new GenericRepository<Client>();
            Client TestClient = new Client { clientPhone = "SaveTestPhone", clientName = "SaveTestName" };
            RepC.Add(TestClient);
            int count = RepC.GetAll().Where(item => item.clientName == "SaveTestName").Count();
            RepC.Save();
            Assert.AreEqual(count+1, RepC.GetAll().Where(item => item.clientName == "SaveTestName").Count());
            RepC.Delete(TestClient);
            RepC.Save();     
        }

    }
}
