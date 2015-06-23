using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BussinesLayer
{
    public class FuncionesBL
    {
        public List<ClaseObjetoBL> lista = new List<ClaseObjetoBL>();

        public long Factorial(long numero)
        {
            if (numero == 1 || numero == 0) return (1);
            return numero * Factorial(numero - 1);
        }


        public long FactorialError(long numero)
        {
            if (numero == 1 || numero == 0) return (1);
            return numero + Factorial(numero - 1);
        }



        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        public string DivideTexto(string texto)
        {
            string[] primera_palabara = texto.Split(new char[] { ' ' });
            int i = 0;
            foreach (string s in primera_palabara)
            {
                if (i == 0) return s;
                i++;
            }
            return "";
        }

        public string DivideTextoError(string texto)
        {
            string[] primera_palabara = texto.Split(new char[] { ' ' });
            int i = 0;
            foreach (string s in primera_palabara)
            {
                if (i == 3) return s;
                i++;
            }
            return "";
        }


        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        public bool Pregunta(string question)
        {
            Random rand = new Random();
            int resultado = rand.Next(0, 2);
            if (resultado == 0) return false;
            return true;
        }


        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        public ClaseObjetoBL CrearObjeto(int indice)
        {
            if (indice > lista.Count()) return null;
            return lista[indice];
        }


        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        public List<ClaseObjetoBL> Dame_Lista()
        {
            return lista;
        }


        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        public double Exception_divide(double x, double y)
        {
            {
                if (y == 0)
                {

                    //throw new System.DivideByZeroException();
                    ExceptionBL ex = new ExceptionBL("Anderson intento dividir entre cero");  //este es creando un objeto de clase exception q tiene atributos como un mensaje
                    throw ex;
                    
                }
                return x / y;
            }
        }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        public double Exception_raizcuad(double x)
        {
            {
                if (x < 0)
                {

                    throw new System.ArgumentOutOfRangeException();
                    //ExceptionBL ex = new ExceptionBL("Anderson intento obtener raiz cuadrada de un numero negativo");
                    //throw ex;

                }
                return Math.Sqrt(x);
            }
        }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~



    }
}
