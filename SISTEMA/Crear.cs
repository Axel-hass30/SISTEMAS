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
    public partial class Crear : Form
    {
        Conexion cn = new Conexion();
        public Crear()
        {
            InitializeComponent();
        }

        private void Crear_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            String nom, apellidos, genero, fecha, nacionalidad, correo, contra, tel,user;

            nom = Nom.Text;
            apellidos = Apepa.Text + Apema.Text;
            
            
            genero = " ";

            if (Femenino.Checked == true)
            {
                genero = genero + "Femenino";

            }
            else 
            {
                genero = genero+"Masculino";
            }

            nacionalidad = Nacionalidad.Text;
            correo = Correo.Text;

            contra = " ";
            if(Contraseña.Text == Contraseña1.Text)
            {
                contra = contra + Contraseña1.Text;

                tel = Telefono.Text;

                fecha = Fecha.Text;

                Random r = new Random();
                int num = r.Next(100, 1000);
                Console.WriteLine(r.Next(100, 1000));
                Console.ReadLine();

                user = nom + num;

                // guardas datos en sql


                SqlConnection cn = new SqlConnection("SERVER=DESKTOP-PU8PAM3; DATABASE=Ventas; integrated security=true");
                cn.Open();
                try
                {
                    String cadena = "INSERT into Asociados(IdSocio,Nombre,Apellidos,Genero,[Fecha de Nacimiento],Nacionalidad,Correo,Contraseña,Telefono) VALUES ('" + user + "','" + nom + "','"+apellidos+"','" + genero + "','" + fecha + "','" + nacionalidad + "','" + correo + "','" + contra + "','" + tel + "')";
                    SqlCommand cmd = new SqlCommand(cadena, cn);
                    cmd.ExecuteNonQuery();

                    ctMessage.Show("Datos guardados", true);

                }catch(Exception)
                {
                    ctMessage.Show("Error al guardar los datos", false);
                }


                


            }
            else
            {
                ctMessage.Show("Las contraseñas no coinciden", false);
            }

            


            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Femenino_CheckedChanged(object sender)
        {
            
        }

        private void Masculino_CheckedChanged(object sender)
        {
            
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Nom.Clear();
            Apepa.Clear();
            Apema.Clear();
            Correo.Clear();
            Contraseña.Clear();
            Contraseña1.Clear();
            Telefono.Clear();

            Femenino.Checked = false;
            Masculino.Checked = false;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Visible = true;
            Visible = false;
        }
    }
}
