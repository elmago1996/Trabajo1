using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BussinesLayer;
using DataModeler;

namespace UnitTest
{

    [TestFixture]
    class DataUnitTests
    {

        string ok;
        string username = "elmago1996";
        string password = "993800340";
        string producto_ID = "dffd23";
        string nombre_producto = "dfgdf";

        bool esperado = true;
        int stock_esperado = 325;

        [Test]

        public void Exception()  // TEST DE EXCEPCION CON Nunit 
        {
            FuncionesBL fun = new FuncionesBL();
            Assert.Throws<ExceptionBL>(() => fun.Exception_divide(5, 0));
        }

        [Test]

        public void DamePassword_UsuarioTest_Nunit()
        {
            string user_input = username;
            string esperado = password;
            UsuarioBL usuario = new UsuarioBL();
            string actual = usuario.DamePassword_Usuario(user_input);
            Assert.AreEqual(esperado, actual);
        }
    }
}
