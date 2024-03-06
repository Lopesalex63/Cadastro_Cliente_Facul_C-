namespace Aula_04032024
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSemImagem = new System.Windows.Forms.RadioButton();
            this.rdoImagem2 = new System.Windows.Forms.RadioButton();
            this.rdoImagem1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoFixaSimples = new System.Windows.Forms.RadioButton();
            this.rdo3d = new System.Windows.Forms.RadioButton();
            this.rdoSemBordas = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.checkVisivelInvisivel = new System.Windows.Forms.CheckBox();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSemImagem);
            this.groupBox1.Controls.Add(this.rdoImagem2);
            this.groupBox1.Controls.Add(this.rdoImagem1);
            this.groupBox1.Location = new System.Drawing.Point(22, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Imagens";
            // 
            // rdoSemImagem
            // 
            this.rdoSemImagem.AutoSize = true;
            this.rdoSemImagem.Location = new System.Drawing.Point(16, 87);
            this.rdoSemImagem.Name = "rdoSemImagem";
            this.rdoSemImagem.Size = new System.Drawing.Size(108, 20);
            this.rdoSemImagem.TabIndex = 2;
            this.rdoSemImagem.TabStop = true;
            this.rdoSemImagem.Text = "Sem Imagem";
            this.rdoSemImagem.UseVisualStyleBackColor = true;
            this.rdoSemImagem.CheckedChanged += new System.EventHandler(this.rdoSemImagem_CheckedChanged);
            // 
            // rdoImagem2
            // 
            this.rdoImagem2.AutoSize = true;
            this.rdoImagem2.Location = new System.Drawing.Point(16, 61);
            this.rdoImagem2.Name = "rdoImagem2";
            this.rdoImagem2.Size = new System.Drawing.Size(87, 20);
            this.rdoImagem2.TabIndex = 1;
            this.rdoImagem2.TabStop = true;
            this.rdoImagem2.Text = "Imagem 2";
            this.rdoImagem2.UseVisualStyleBackColor = true;
            this.rdoImagem2.CheckedChanged += new System.EventHandler(this.rdoImagem2_CheckedChanged);
            // 
            // rdoImagem1
            // 
            this.rdoImagem1.AutoSize = true;
            this.rdoImagem1.Location = new System.Drawing.Point(16, 33);
            this.rdoImagem1.Name = "rdoImagem1";
            this.rdoImagem1.Size = new System.Drawing.Size(87, 20);
            this.rdoImagem1.TabIndex = 0;
            this.rdoImagem1.TabStop = true;
            this.rdoImagem1.Text = "Imagem 1";
            this.rdoImagem1.UseVisualStyleBackColor = true;
            this.rdoImagem1.CheckedChanged += new System.EventHandler(this.rdoImagem1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoFixaSimples);
            this.groupBox2.Controls.Add(this.rdo3d);
            this.groupBox2.Controls.Add(this.rdoSemBordas);
            this.groupBox2.Location = new System.Drawing.Point(205, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bordas";
            // 
            // rdoFixaSimples
            // 
            this.rdoFixaSimples.AutoSize = true;
            this.rdoFixaSimples.Location = new System.Drawing.Point(17, 61);
            this.rdoFixaSimples.Name = "rdoFixaSimples";
            this.rdoFixaSimples.Size = new System.Drawing.Size(105, 20);
            this.rdoFixaSimples.TabIndex = 3;
            this.rdoFixaSimples.TabStop = true;
            this.rdoFixaSimples.Text = "Fixa Simples";
            this.rdoFixaSimples.UseVisualStyleBackColor = true;
            this.rdoFixaSimples.CheckedChanged += new System.EventHandler(this.rdoFixaSimples_CheckedChanged);
            // 
            // rdo3d
            // 
            this.rdo3d.AutoSize = true;
            this.rdo3d.Location = new System.Drawing.Point(17, 87);
            this.rdo3d.Name = "rdo3d";
            this.rdo3d.Size = new System.Drawing.Size(45, 20);
            this.rdo3d.TabIndex = 2;
            this.rdo3d.TabStop = true;
            this.rdo3d.Text = "3D";
            this.rdo3d.UseVisualStyleBackColor = true;
            this.rdo3d.CheckedChanged += new System.EventHandler(this.rdo3d_CheckedChanged);
            // 
            // rdoSemBordas
            // 
            this.rdoSemBordas.AutoSize = true;
            this.rdoSemBordas.Location = new System.Drawing.Point(17, 33);
            this.rdoSemBordas.Name = "rdoSemBordas";
            this.rdoSemBordas.Size = new System.Drawing.Size(103, 20);
            this.rdoSemBordas.TabIndex = 1;
            this.rdoSemBordas.TabStop = true;
            this.rdoSemBordas.Text = "Sem Bordas";
            this.rdoSemBordas.UseVisualStyleBackColor = true;
            this.rdoSemBordas.CheckedChanged += new System.EventHandler(this.rdoSemBordas_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 96);
            this.button1.TabIndex = 2;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkVisivelInvisivel
            // 
            this.checkVisivelInvisivel.AutoSize = true;
            this.checkVisivelInvisivel.Location = new System.Drawing.Point(511, 318);
            this.checkVisivelInvisivel.Name = "checkVisivelInvisivel";
            this.checkVisivelInvisivel.Size = new System.Drawing.Size(179, 20);
            this.checkVisivelInvisivel.TabIndex = 3;
            this.checkVisivelInvisivel.Text = "Imagem Visível / Invisível";
            this.checkVisivelInvisivel.UseVisualStyleBackColor = true;
            this.checkVisivelInvisivel.CheckedChanged += new System.EventHandler(this.checkVisivelInvisivel_CheckedChanged);
            // 
            // pcbFoto
            // 
            this.pcbFoto.Location = new System.Drawing.Point(22, 12);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(740, 277);
            this.pcbFoto.TabIndex = 4;
            this.pcbFoto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.checkVisivelInvisivel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSemImagem;
        private System.Windows.Forms.RadioButton rdoImagem2;
        private System.Windows.Forms.RadioButton rdoImagem1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoFixaSimples;
        private System.Windows.Forms.RadioButton rdo3d;
        private System.Windows.Forms.RadioButton rdoSemBordas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkVisivelInvisivel;
        private System.Windows.Forms.PictureBox pcbFoto;
    }
}

