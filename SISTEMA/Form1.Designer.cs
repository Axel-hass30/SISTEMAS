
namespace Sistema
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctSkinetTitleBar1 = new CTSkinet.CTSkinetTitleBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.User = new CTSkinet.CTSkinetTextBoxRound();
            this.Password = new CTSkinet.CTSkinetTextBoxRound();
            this.iniciar = new CTSkinet.CTSkinetButtonRound();
            this.crear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ctSkinetTitleBar1
            // 
            this.ctSkinetTitleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ctSkinetTitleBar1.BackgroundImage = global::Sistema.Properties.Resources.fondo;
            this.ctSkinetTitleBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ctSkinetTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctSkinetTitleBar1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctSkinetTitleBar1.FormMaximize = true;
            this.ctSkinetTitleBar1.FormMinimize = true;
            this.ctSkinetTitleBar1.FormMoveable = false;
            this.ctSkinetTitleBar1.FormResize = false;
            this.ctSkinetTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.ctSkinetTitleBar1.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ctSkinetTitleBar1.MaximumSize = new System.Drawing.Size(0, 40);
            this.ctSkinetTitleBar1.MinimumSize = new System.Drawing.Size(200, 40);
            this.ctSkinetTitleBar1.Name = "ctSkinetTitleBar1";
            this.ctSkinetTitleBar1.Size = new System.Drawing.Size(371, 40);
            this.ctSkinetTitleBar1.TabIndex = 0;
            this.ctSkinetTitleBar1.Text = "MyTect";
            this.ctSkinetTitleBar1.Click += new System.EventHandler(this.ctSkinetTitleBar1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Sistema.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(79, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Sistema.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(156, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Sistema.Properties.Resources.letralogo;
            this.pictureBox3.Location = new System.Drawing.Point(129, 106);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Sistema.Properties.Resources.candado;
            this.pictureBox4.Location = new System.Drawing.Point(79, 234);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // User
            // 
            this.User.BorderColor = System.Drawing.Color.Transparent;
            this.User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.User.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.User.Location = new System.Drawing.Point(119, 181);
            this.User.MainColor = System.Drawing.Color.White;
            this.User.MaxLength = 32767;
            this.User.Multiline = false;
            this.User.Name = "User";
            this.User.PlaceHolder = "User Name";
            this.User.PlaceHolderColor = System.Drawing.SystemColors.GrayText;
            this.User.ReadOnly = false;
            this.User.SelectionLength = 0;
            this.User.SelectionStart = 0;
            this.User.Size = new System.Drawing.Size(173, 25);
            this.User.TabIndex = 5;
            this.User.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.User.UseSystemPasswordChar = false;
            // 
            // Password
            // 
            this.Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password.Location = new System.Drawing.Point(119, 239);
            this.Password.MainColor = System.Drawing.Color.White;
            this.Password.MaxLength = 32767;
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            this.Password.PlaceHolder = "Password";
            this.Password.PlaceHolderColor = System.Drawing.SystemColors.GrayText;
            this.Password.ReadOnly = false;
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.Size = new System.Drawing.Size(173, 25);
            this.Password.TabIndex = 6;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // iniciar
            // 
            this.iniciar.BackColor = System.Drawing.Color.Transparent;
            this.iniciar.FlatAppearance.BorderSize = 0;
            this.iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.iniciar.Location = new System.Drawing.Point(119, 321);
            this.iniciar.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(204)))));
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(150, 35);
            this.iniciar.TabIndex = 7;
            this.iniciar.Text = "LOGIN";
            this.iniciar.UseVisualStyleBackColor = false;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // crear
            // 
            this.crear.AutoSize = true;
            this.crear.BackColor = System.Drawing.Color.Transparent;
            this.crear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crear.Location = new System.Drawing.Point(223, 277);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(69, 13);
            this.crear.TabIndex = 8;
            this.crear.Text = "Crear usuario";
            this.crear.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(371, 398);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctSkinetTitleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 728);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTSkinet.CTSkinetTitleBar ctSkinetTitleBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private CTSkinet.CTSkinetTextBoxRound User;
        private CTSkinet.CTSkinetTextBoxRound Password;
        private CTSkinet.CTSkinetButtonRound iniciar;
        private System.Windows.Forms.Label crear;
    }
}

