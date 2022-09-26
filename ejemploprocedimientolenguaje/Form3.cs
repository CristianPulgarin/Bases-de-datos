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
    public partial class Form3 : Form
    {
        ManipulaBD obj2 = new ManipulaBD();
        string proc, param;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proc = "SP_CONSULTAUSUARIOESPECIFICO";
            param = "" + textBox2.Text + "," + textBox1.Text + "";
            obj2.ConsultarBD(proc, param);

            if (obj2.dt.Tables["objeto1"].Rows.Count==0)
            {
                MessageBox.Show("Usuario no válido");
            }
             else
            {
                MessageBox.Show("Usuario válido");
                Form1 f1 = new Form1();
                f1.Show();
 
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
