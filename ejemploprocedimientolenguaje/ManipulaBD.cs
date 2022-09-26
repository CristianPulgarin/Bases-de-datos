using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ejemploprocedimientolenguaje
{
    public class ManipulaBD
    {
        public SqlConnection cn;
        SqlCommand cm;
        SqlDataAdapter da;
        public DataSet dt;
        string cadena;
        string sql;

        /*Método para conectarse con la Base de Datos SQL SERVER*/
        public void ConectarBD()
        {
            cadena = @"Data Source=DESKTOP-N7TM1CP;Initial Catalog=AdministrarUsuario;Integrated Security=True";
            cn = new SqlConnection(cadena);
            cn.Open();

        }
        /*Mëtodo para manipular la Base de Datos, es decir poder Insertar, Modificar, y Eliminar*/
        public void ManipularBD(string proc, string param)
        {
            ConectarBD();
            sql="" + proc + " " + param + "";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
        }
        /*Metodo para permtir consultar a la Base de Datos, en este caso validacion de usuarios*/
        public void ConsultarBD(string proc, string param)
        {
            ConectarBD();
            sql = "" + proc + " " + param + "";
            dt = new DataSet();
            da = new SqlDataAdapter(sql, cn);
            da.Fill(dt,"objeto1");
        }
    }
}
