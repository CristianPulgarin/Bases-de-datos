using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploprocedimientolenguaje
{
    public partial class Form1 : Form
    {
        /*Crear una Instancia de la clase ManipulaBD*/
        ManipulaBD obj1M = new ManipulaBD();
        string param,proc;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proc = "SP_CREARUSUARIO";
            param = "" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "";
            obj1M.ManipularBD(proc, param);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
