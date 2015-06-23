using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BussinesLayer;

namespace UnitTest
{
    [TestFixture]
    class DataUnitTests
    {
        [Test]

        public void Exception()  // TEST DE EXCEPCION CON Nunit 
        {
            FuncionesBL fun = new FuncionesBL();
            Assert.Throws<ExceptionBL>(() => fun.Exception_divide(5, 0));
        }

    }
}
