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

        public void FactorialTestError()
        {
            long numero = 3;
            long esperado = 6;
            FuncionesBL fun = new FuncionesBL();
            long actual = fun.FactorialError(numero);
            Assert.AreEqual(esperado, actual);
        }


        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        [Test]

        public void DivideTextoTest()
        {
            string in_put = "HOLA PROFE SOY ANDERSON";
            string esperado = "HOLA";
            FuncionesBL fun = new FuncionesBL();
            string actual = fun.DivideTexto(in_put);
            Assert.AreEqual(esperado, actual);
        }

        [Test]

        public void DivideTextoTestError()
        {
            string in_put = "HOLA PROFE SOY ANDERSON";
            string esperado = "HOLA";
            FuncionesBL fun = new FuncionesBL();
            string actual = fun.DivideTextoError(in_put);
            Assert.AreEqual(esperado, actual);
        }



        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        [Test]

        public void PreguntaTest()
        {
            string in_put = "ANDERSON JALARÁ EVO?";
            bool esperado = true;
            FuncionesBL fun = new FuncionesBL();
            bool actual = fun.Pregunta(in_put);
            Assert.AreEqual(esperado, actual);
            //Assert.IsFalse(actual);

        }


        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        [Test]

        public void ExisteObjTest()
        {
            int indice_del_objeto = 0;
            ClaseObjetoBL obj_esperado = new ClaseObjetoBL(5, 5);
            ClaseObjetoBL obj_esperado2 = new ClaseObjetoBL(6, 6);
            FuncionesBL func = new FuncionesBL();
            func.lista.Add(obj_esperado);
            func.lista.Add(obj_esperado2);
            ClaseObjetoBL obj_actual = func.CrearObjeto(indice_del_objeto);
            Assert.AreEqual(obj_esperado, obj_actual);
        }


        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        [Test]

        public void ExisteObjTest_Error()
        {
            int indice_del_objeto = 1;
            ClaseObjetoBL obj_esperado = new ClaseObjetoBL(5, 5);
            ClaseObjetoBL obj_esperado2 = new ClaseObjetoBL(5, 5);
            FuncionesBL func = new FuncionesBL();
            func.lista.Add(obj_esperado);
            func.lista.Add(obj_esperado2);
            ClaseObjetoBL obj_actual = func.CrearObjeto(indice_del_objeto);
            Assert.AreEqual(obj_esperado, obj_actual);
        }



        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        [Test]

        public void IsNULLTest()
        {
            FuncionesBL Func = new FuncionesBL();
            ClaseObjetoBL Obj = Func.CrearObjeto(1);
            Assert.IsNull(Obj);
        }


        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        [Test]

        public void ListaTest()
        {
            FuncionesBL Func = new FuncionesBL();
            List<ClaseObjetoBL> lista_esperada = Func.lista;
            List<ClaseObjetoBL> lista_actual = Func.Dame_Lista();
            Assert.AreEqual(lista_esperada, lista_actual);
        }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        [Test]

        public void ListaTest2_Error()
        {
            FuncionesBL Func = new FuncionesBL();
            List<ClaseObjetoBL> lista_esperada = Func.lista;
            List<ClaseObjetoBL> lista_actual = new List<ClaseObjetoBL>();
            Assert.AreEqual(lista_esperada, lista_actual);
        }


        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ // profe el test de excepciones q verifica si se genero una excepcion esta la otra clase "DataUnitTest" pues utilize otro framework para eso

        [Test]

        public void ExceptionTest_Error1()
        {
            FuncionesBL Func = new FuncionesBL();
            try
            {
                Func.Exception_divide(5, 0); // dividido entro un numero dif de cero
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }

        }


        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        [Test]

        public void ExceptionTest_Error2()  // devuelve el mensaje del objeto de clase ExceptioBL
        {
            FuncionesBL Func = new FuncionesBL();
            try
            {
                Func.Exception_divide(5, 0); // divido entre 0
            }
            catch (ExceptionBL ex)
            {
                Assert.Fail(ex.messag);
            }

        }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        [Test]

        public void ExceptionTest_ErrorEjemplo2()
        {
            FuncionesBL Func = new FuncionesBL();
            try
            {
                Func.Exception_raizcuad(-2);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw ex;
            }

        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        [Test]

        public void Existen_Usuarios_en_tabla()
        {
            UsuarioBL usuario = new UsuarioBL();
            bool actual = usuario.Existen_Usuarios_en_tabla();
            Assert.AreEqual(esperado, actual);
        }


    }
}
