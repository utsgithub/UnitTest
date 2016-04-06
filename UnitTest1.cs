using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        User siteEn;
        User manager;
        User account;
        Intervention inter;
        public TestContext TextContext { get; set; }
        [TestInitialize]
        public void Setup()
        {
            siteEn = new User(1);
            manager = new User(2);
            account = new User(3);
            inter = new Intervention();
        }
        [TestMethod]
        public void validateProposed_to_Approved()
        {
            Assert.AreEqual("Successful", inter.validate(2));
        }
        [TestMethod]
        public void validateProposed_to_Completed()
        {
            Assert.AreEqual("Fail", inter.validate(0));
        }
        [TestMethod]
        public void validateApproved_to_Cancelled()
        {
            inter.stageTransition(2);
            Assert.AreEqual("Successful", inter.validate(0));
        }
        [TestMethod]
        public void validateApproved_to_Completed()
        {
            inter.stageTransition(2);
            Assert.AreEqual("Successful", inter.validate(0));
        }
        [TestMethod]
        public void validateCancelled_to_Approved()
        {
            inter.stageTransition(1);
            Assert.AreEqual("Successful", inter.validate(2));
        }
    }
}
