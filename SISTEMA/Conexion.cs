using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using CTSkinet;

namespace Sistema
{
    class Conexion
    {

        public void conectar()
        {

            
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-PU8PAM3; DATABASE=Ventas; integrated security=true");

            try
            {
                cn.Open();

                ctMessage.Show("Conexion exitosa", true);

            }catch(Exception)
            {
                ctMessage.Show("Error al conectar con la base de datos", false);
            }

        }

        


    }
}
