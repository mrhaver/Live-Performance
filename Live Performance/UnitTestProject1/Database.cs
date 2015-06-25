using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Live_Performance;

namespace UnitTestProject1
{
    [TestClass]
    public class Database
    {
        // Fields
        private DatabaseKoppeling databaseKoppeling;

        // Methods

        [TestMethod]
        public void TestConnectie()
        {
            databaseKoppeling = new DatabaseKoppeling();

            bool expected = true;
            bool actual = databaseKoppeling.TestConnectie();

            Assert.AreEqual(expected, actual, "Geen Connectie");
        }
    }
}
