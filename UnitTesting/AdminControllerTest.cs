using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcInAction.Models;
using MvcInAction.Repositories;
using MvcInAction.Controllers;

namespace UnitTesting
{
    /// <summary>
    /// Summary description for AdminControllerTest
    /// </summary>
    [TestClass]
    public class AdminControllerTest
    {
        //public AdminControllerTest()
        //{
        //    //
        //    // TODO: Add constructor logic here
        //    //
        //}

        //private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        //public TestContext TestContext
        //{
        //    get
        //    {
        //        return testContextInstance;
        //    }
        //    set
        //    {
        //        testContextInstance = value;
        //    }
        //}

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void CanChangeLoginName()
        {
            Member bob = new Member{LoginName="Bob"};
            FakeMembersRepository repository = new FakeMembersRepository();
            repository.Members.Add(bob);
            AdminController target = new AdminController(repository);
            string oldLogin = bob.LoginName;
            string newLogin = "Anastasia";

            target.ChangeLoginName(oldLogin, newLogin);

            Assert.AreEqual(newLogin, bob.LoginName);
            Assert.IsTrue(repository.DidSubmitChanges);
        }
    }
}
