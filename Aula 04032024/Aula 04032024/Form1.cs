using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_04032024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoImagem1_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.Image = Properties.Resources.Baixo;
        }

        private void rdoImagem2_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.Image = Properties.Resources.Guitarra;
        }

        private void rdoSemImagem_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.Image = null;
        }

        private void rdoSemBordas_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle = BorderStyle.None;
        }

        private void rdoFixaSimples_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle = BorderStyle.FixedSingle;
        }

        private void rdo3d_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle = BorderStyle.Fixed3D;
        }

        private void checkVisivelInvisivel_CheckedChanged(object sender, EventArgs e)
        {
            if(checkVisivelInvisivel.Checked)
            {
                pcbFoto.Visible = true;
            }
            else
            {
                pcbFoto.Visible=false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
