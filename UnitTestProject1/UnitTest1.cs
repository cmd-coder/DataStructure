using DataStructureDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(30,true)]
        [DataRow(45,false)]
        public void Search_PassANodeValue_ReturnTrueOrFalse(int data, bool flag)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            bool flagReturned = list.Search(data);
            Assert.AreEqual(flag, flagReturned);
        }
    }
}
