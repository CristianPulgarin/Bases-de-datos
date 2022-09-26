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
    public partial class Form2 : Form
    {
        ManipulaBD obj1M = new ManipulaBD();
        string param, proc;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proc = "SP_CREARROL";
            param = "" + textBox1.Text + "," + textBox2.Text + "";
            obj1M.ManipularBD(proc, param);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
