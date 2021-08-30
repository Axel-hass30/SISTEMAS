using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTSkinet;
using System.Data.SqlClient;

namespace Sistema
{
    
    public partial class Form1 : Form
    {
        Conexion cn = new Conexion();
        public Form1()
        {
            InitializeComponent();

            cn.conectar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ctSkinetTitleBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            Verificacion vr = new Verificacion();
            vr.Visible = true;
            Visible = false;
            
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            

            string user = User.Text;
            string pass = Password.Text;

            SqlConnection cn = new SqlConnection("server=DESKTOP-PU8PAM3 ; database=Sistema ; integrated security = true");
            cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText=( "SELECT * FROM User WHERE Usuario='" + user + "' AND Contraseña='" + pass + "'");
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Principal pr = new Principal();
                    pr.Visible = true;
                    Visible = false;
                }else
                {
                    ctMessage.Show("Datos incorrectos", false);
                }
            }catch(Exception ex)
            {
               
            }

    

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
