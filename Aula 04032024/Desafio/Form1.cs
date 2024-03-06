using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdoMasculino.Checked = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {

            pcbFoto.Image = Properties.Resources.sherek;
            //OpenFileDialog openfiledialog = new OpenFileDialog();

            ////filtros de arquivo para mostrar apenas imagens
            //openfiledialog.Filter = "arquivos de imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|todos os arquivos|*.*";
            //openfiledialog.Title = "selecione uma imagem";

            //// se o usuário selecionar uma imagem e clicar em ok
            //if (openfiledialog.ShowDialog() == DialogResult.OK)
            //{
            //    //carregar a imagem no controle picture box
            //    pcbFoto.Image = new System.Drawing.Bitmap(openfiledialog.FileName);
            //}
            //else
            //{
            //    MessageBox.Show("erro ao carregar a imagem");
            //}
        }
             
        private void btnLimparImagem_Click(object sender, EventArgs e)
        {
            pcbFoto.Image = null;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtRg.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtFacebook.Text = string.Empty;
            txtTwitter.Text = string.Empty;
            chkEmail.Checked = false;
            chkFacebook.Checked = false;
            chkTwitter.Checked = false;
            chkEmail.Enabled = true;
            chkFacebook.Enabled = true;
            chkTwitter.Enabled = true;
            txtEmail.Enabled = true;
            txtFacebook.Enabled = true;
            txtTwitter.Enabled = true;
            rdoFeminino.Checked = false;
            rdoMasculino.Checked = false;
            pcbFoto.Image = null;
        }

        private void chkEmail_CheckedChanged(object sender, EventArgs e)
        {
            txtFacebook.Enabled = false;
            txtTwitter.Enabled = false;
            chkFacebook.Enabled = false;
            chkTwitter.Enabled = false;
        }

        private void chkFacebook_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.Enabled = false;
            txtTwitter.Enabled = false;
            chkEmail .Enabled = false;
            chkTwitter .Enabled = false;
        }

        private void chkTwitter_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.Enabled=false;
            txtFacebook.Enabled=false;
            chkEmail.Enabled=false;
            chkFacebook .Enabled=false;
        }

        private void RdoMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            
            txtCodigo.Text = "1";
            txtNome.Text = "Alex Sandro Lopes da Silva Junior";
            txtRg.Text = "42.626.527-0";
            txtCpf.Text = "444.703.588.00";
            txtTelefone.Text = "4595-7320";
            txtCelular.Text = "(11) 99174-4117";
            rdoMasculino.Checked = true;
            txtCep.Text = "13219-351";
            txtLogradouro.Text = "Av. Dr. Gilberto Luiz Pereira da Silva";
            txtNumero.Text = "16";
            txtBairro.Text = "Cidade Nova";
            txtCidade.Text = "Jundiai";
            txtEstado.Text = "SP";
            chkEmail.Checked = true;
            txtEmail.Text = "lopesalex63@gmail.com";

            if(rdoMasculino.Checked == false)
            {
                rdoMasculino.Checked = true;
                return;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string Mensagem =
                lblCodigo.Text + " " + txtCodigo.Text + "\n" +
                lblNome.Text + " " + txtNome.Text + "\n" +
                lblRg.Text + " " + txtRg.Text + "\n" +
                lblCpf.Text + " " + txtCpf.Text + "\n" +
                lblTelefone.Text + " " + txtTelefone.Text + "\n" +
                lblCelular.Text + " " + txtCelular.Text + "\n" +
                "Sexo: " + rdoMasculino.Text + "\n" +
                lblCep.Text + " " + txtCep.Text + "\n" +
                lblLogradouro.Text + " " + txtLogradouro.Text + "\n" +
                lblNumero.Text + " " + txtNumero.Text + "\n" +
                lblBairro.Text + " " + txtBairro.Text + "\n" +
                lblCidade.Text + " " + txtCidade.Text + "\n" +
                lblEstado.Text + " " + txtEstado.Text + "\n" +
                lblEmail.Text + " " + txtEmail.Text;

            MessageBox.Show(Mensagem);
            
            //MessageBox.Show(lblCodigo.Text + " " + txtCodigo.Text);
            //MessageBox.Show(lblNome.Text + " " + txtNome.Text);
            //MessageBox.Show(lblRg.Text +  " " + txtRg.Text);
            //MessageBox.Show(lblCpf.Text + " " + txtCpf.Text);
            //MessageBox.Show(lblTelefone.Text +  " " + txtTelefone.Text);
            //MessageBox.Show(lblCelular.Text +  " " + txtCelular.Text);
            //MessageBox.Show(rdoMasculino.Text);
            //MessageBox.Show(lblCep.Text + " " + txtCep.Text);
            //MessageBox.Show(lblLogradouro.Text + " " + txtLogradouro.Text);
            //MessageBox.Show(lblNumero.Text + " " + txtNumero.Text);
            //MessageBox.Show(lblBairro.Text +  " " + txtBairro.Text);
            //MessageBox.Show(lblCidade.Text + " " + txtCidade.Text);
            //MessageBox.Show(lblEstado.Text + " " + txtEstado.Text);
            //MessageBox.Show(lblEmail.Text + " " + txtEmail.Text);
        }
    }
}
