using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;

namespace Pruebas
{
    public partial class Form1 : Form
    {
        FuncionesBL Funcion = new FuncionesBL();
        UsuarioBL user = new UsuarioBL();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int numero = Convert.ToInt32(textBox1.Text);
            //textBox2.Text = Funcion.Factorial(numero).ToString();
            //textBox2.Text = Funcion.DivideTexto(textBox1.Text);
            //textBox2.Text = Funcion.Pregunta(textBox1.Text).ToString();
            string pass = user.DamePassword_Usuario(textBox1.Text);
            textBox2.Text = pass;
        }
    }
}
