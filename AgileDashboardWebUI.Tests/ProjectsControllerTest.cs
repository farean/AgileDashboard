using AgileDashboardWebUI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using Moq;
using System.Web.Mvc;
namespace AgileDashboardWebUI.Tests
{
    
    
    /// <summary>
    ///This is a test class for ProjectsControllerTest and is intended
    ///to contain all ProjectsControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProjectsControllerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for ProjectsController Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.

        [TestMethod]
        public void CallProjectsController_GetAllProjects_ReturnsJsonResult()
        {
            ProjectsController controller = new ProjectsController();
            var resultcontroller = controller.GetProjects();
            Assert.IsNotNull(resultcontroller);
            Assert.IsInstanceOfType(resultcontroller, typeof(JsonResult));
            Assert.IsNotNull(resultcontroller.Data);
        }
    }
}
