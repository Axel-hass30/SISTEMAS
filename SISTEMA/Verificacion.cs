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

namespace Sistema
{
    public partial class Verificacion : Form
    {
        public Verificacion()
        {
            InitializeComponent();
        }

        private void Verificacion_Load(object sender, EventArgs e)
        {

        }

        private void Verificacion_Load_1(object sender, EventArgs e)
        {

        }

        private void ctSkinetButtonRound1_Click(object sender, EventArgs e)
        {
            
            if(user1.Text == "axel" && contra.Text == "axel")
            {
                Crear cr = new Crear();
                cr.Visible = true;
                Visible = false;
                
            }else
            {
                ctMessage.Show("Usuario incorrecto", false);
            }
        }

        private void contra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
