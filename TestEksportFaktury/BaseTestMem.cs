using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Xpo;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEksportFaktury
{
    [TestFixture]
    public class BaseTestMem
    {
        #region setup
        private IObjectSpace objectSpace;
        private XPObjectSpaceProvider directProvider;
        private string connectionString;
        //  private DataGenerator generator;

        [OneTimeSetUp]
        public void OneTimeSetUp() { XpoDefault.Session = null; }

        [SetUp]
        public void SetUp()
        {
            connectionString = InMemoryDataStoreProvider.ConnectionString;
            directProvider = new XPObjectSpaceProvider(connectionString, null);
            objectSpace = directProvider.CreateObjectSpace();
            // generator = new DataGenerator(objectSpace);


            //objectSpace.CommitChanges();
        }

        [TearDown]
        public void TearDown()
        {
            directProvider.Dispose();
            objectSpace.Dispose();
            //  generator.Dispose();
        }
        #endregion
    }

}
