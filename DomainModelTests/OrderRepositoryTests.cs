using System;
using System.Data.Entity;
using System.Linq;
using DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainModelTests
{
    [TestClass]
    public class OrderRepositoryTests
    {
        [TestMethod]
        public void GetAllTestOrder()
        {
            ServiceType testServiceType = new ServiceType() {nameService = "GetAllServiceName", priceService = 100 };
            GenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            RepST.Add(testServiceType);
            RepST.Save();
            Client testClient = new Client { clientName = "GetAllClientName", clientPhone = "GetAllClientPhone" };
            GenericRepository<Client> RepС = new GenericRepository<Client>();
            RepС.Add(testClient);
            RepС.Save();
            Order testOrder = new Order(testServiceType.nameService, 80) {lawnAdress = "GetAllAdress", idClient = testClient.idClient};
            GenericRepository<Order> RepO = new GenericRepository<Order>();
            int startOrderCount = RepO.GetAll().Count();
            RepO.Add(testOrder);
            RepO.Save();
            var test = RepO.GetAll();
            int getAllOrderCount = test.Count();
            Assert.AreEqual(getAllOrderCount, startOrderCount + 1);
            Assert.IsInstanceOfType(test, typeof(DbSet<Order>));
            RepO.Delete(testOrder);
            RepO.Save();
            RepС.Delete(testClient);
            RepС.Save();
            RepST.Delete(testServiceType);
            RepST.Save();


        }

        [TestMethod]
        public void FindByTestOrder()
        {
            ServiceType testServiceType = new ServiceType() { nameService = "FindByServiceName", priceService = 100 };
            GenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            RepST.Add(testServiceType);
            RepST.Save();
            Client testClient = new Client { clientName = "FindByClientName", clientPhone = "FindByClientPhone" };
            GenericRepository<Client> RepС = new GenericRepository<Client>();
            RepС.Add(testClient);
            RepС.Save();
            Order testOrder = new Order(testServiceType.nameService, 80) { lawnAdress = "FindByAdress", idClient = testClient.idClient };
            GenericRepository<Order> RepO = new GenericRepository<Order>();
            RepO.Add(testOrder);
            RepO.Save();

            Order findByOrder = RepO.FindBy(item => item.lawnAdress == "FindByAdress").FirstOrDefault();
            Assert.AreEqual(findByOrder.totalCost, 8000);

            RepO.Delete(testOrder);
            RepO.Save();
            RepST.Delete(testServiceType);
            RepST.Save();
            RepС.Delete(testClient);
            RepС.Save();
        }

        [TestMethod]
        public void AddTestOrder()
        {
            ServiceType testServiceType = new ServiceType() { nameService = "AddServiceName", priceService = 100 };
            GenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            RepST.Add(testServiceType);
            RepST.Save();
            Client testClient = new Client { clientName = "AddClientName", clientPhone = "AddClientPhone" };
            GenericRepository<Client> RepС = new GenericRepository<Client>();
            RepС.Add(testClient);
            RepС.Save();
            Order testOrder = new Order(testServiceType.nameService, 80) { lawnAdress = "AddAdress", idClient = testClient.idClient };
            GenericRepository<Order> RepO = new GenericRepository<Order>();
            int count = RepO.GetAll().Where(item => item.lawnAdress == "AddAdress").Count();
            RepO.Add(testOrder);
            RepO.Save();

            int clientId = RepС.GetAll().Where(itm => itm.clientName == "AddClientName").FirstOrDefault().idClient;
            int countNew = RepO.GetAll().Where(item => item.idClient == clientId).Count();

            Assert.AreEqual(count + 1, countNew);

            RepO.Delete(testOrder);
            RepO.Save();
            RepST.Delete(testServiceType);
            RepST.Save();
            RepС.Delete(testClient);
            RepС.Save();

        }

        [TestMethod]
        public void DeleteTestOrder()
        {
            ServiceType testServiceType = new ServiceType() { nameService = "DeleteServiceName", priceService = 100 };
            GenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            RepST.Add(testServiceType);
            RepST.Save();
            Client testClient = new Client { clientName = "DeleteClientName", clientPhone = "DeleteClientPhone" };
            GenericRepository<Client> RepС = new GenericRepository<Client>();
            RepС.Add(testClient);
            RepС.Save();
            Order testOrder = new Order(testServiceType.nameService, 80) { lawnAdress = "DeleteAdress", idClient = testClient.idClient };
            GenericRepository<Order> RepO = new GenericRepository<Order>();
            RepO.Add(testOrder);
            RepO.Save();

            int clientId = RepС.GetAll().Where(itm => itm.clientName == "DeleteClientName").FirstOrDefault().idClient;
            int count = RepO.GetAll().Where(item => item.idClient == clientId).Count();

            RepO.Delete(testOrder);
            RepO.Save();
            int countNew = RepO.GetAll().Where(item => item.lawnAdress == "DeleteAdress").Count();
            Assert.AreEqual(count, countNew+1);

            RepST.Delete(testServiceType);
            RepST.Save();
            RepС.Delete(testClient);
            RepС.Save();
        }

        [TestMethod]
        public void EditTestOrder()
        {
            ServiceType testServiceType = new ServiceType() { nameService = "EditServiceName", priceService = 100 };
            GenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            RepST.Add(testServiceType);
            RepST.Save();
            Client testClient = new Client { clientName = "EditClientName", clientPhone = "EditClientPhone" };
            GenericRepository<Client> RepС = new GenericRepository<Client>();
            RepС.Add(testClient);
            RepС.Save();
            Order testOrder = new Order(testServiceType.nameService, 80) { lawnAdress = "EditAdress", idClient = testClient.idClient };
            GenericRepository<Order> RepO = new GenericRepository<Order>();
            RepO.Add(testOrder);
            RepO.Save();

            int idClient = RepС.FindBy(item => item.clientName == "EditClientName").FirstOrDefault().idClient;

            Order newTestOrder = RepO.FindBy(item => item.idClient == idClient).FirstOrDefault();
            newTestOrder.lawnAdress = "NewEditAdress";
            RepO.Edit(newTestOrder);
            RepO.Save();
            Assert.AreNotEqual(RepO.FindBy(item => item.idClient == idClient).FirstOrDefault().lawnAdress, "EditAdress");
            Assert.AreEqual(RepO.FindBy(item => item.idClient == idClient).FirstOrDefault().lawnAdress, "NewEditAdress");

            RepO.Delete(testOrder);
            RepO.Save();
            RepST.Delete(testServiceType);
            RepST.Save();
            RepС.Delete(testClient);
            RepС.Save();
        }

        [TestMethod]
        public void SaveTestOrder()
        {
            ServiceType testServiceType = new ServiceType() { nameService = "SaveServiceName", priceService = 100 };
            GenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            RepST.Add(testServiceType);
            RepST.Save();
            Client testClient = new Client { clientName = "SaveClientName", clientPhone = "SaveClientPhone" };
            GenericRepository<Client> RepС = new GenericRepository<Client>();
            RepС.Add(testClient);
            RepС.Save();
            Order testOrder = new Order(testServiceType.nameService, 80) { lawnAdress = "SaveAdress", idClient = testClient.idClient };
            GenericRepository<Order> RepO = new GenericRepository<Order>();
            RepO.Add(testOrder);
            int count = RepO.GetAll().Where(item => item.lawnAdress == "SaveAdress").Count();
            RepO.Save();

            int idClient = RepС.FindBy(item => item.clientName == "SaveClientName").FirstOrDefault().idClient;

            Assert.AreEqual(count + 1, RepO.GetAll().Where(item => item.idClient == idClient).Count());

            RepO.Delete(testOrder);
            RepO.Save();
            RepST.Delete(testServiceType);
            RepST.Save();
            RepС.Delete(testClient);
            RepС.Save();

        }
    }
}
