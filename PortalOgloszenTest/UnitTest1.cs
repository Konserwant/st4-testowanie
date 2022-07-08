using Microsoft.AspNetCore.Mvc;
using PortalOgloszen.Controllers;
using PortalOgloszen.Models;

namespace PortalOgloszenTest
{
    //[TestClass]
    //public class UnitTest1
    //{
    //    //private readonly OgloszenieController _context;

    //    //public UnitTest1(OgloszenieController context)
    //    //{
    //    //    _context = context;
    //    //}

    //    //[TestMethod]
    //    //public async Task TestPortalCreateLoad_Succes()
    //    //{
    //    //    //Arrange
    //    //    var client = _context.Index();
    //    //    //Act
    //    //    var response = await client.("/Ogloszenie/Index");
    //    //    //Assert
    //    //}
    //}

    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public async Task TestDetailsViewAsync()
        {
            var controller = new OgloszenieController(context: null);
            var result = await controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);

        }
    }


}