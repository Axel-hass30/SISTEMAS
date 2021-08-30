
namespace Sistema
{
    partial class Verificacion
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
            this.ctSkinetTitleBar1 = new CTSkinet.CTSkinetTitleBar();
            this.user1 = new CTSkinet.CTSkinetTextBoxRound();
            this.contra = new CTSkinet.CTSkinetTextBoxRound();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ctSkinetButtonRound1 = new CTSkinet.CTSkinetButtonRound();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ctSkinetTitleBar1
            // 
            this.ctSkinetTitleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ctSkinetTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctSkinetTitleBar1.FormMaximize = true;
            this.ctSkinetTitleBar1.FormMinimize = true;
            this.ctSkinetTitleBar1.FormMoveable = false;
            this.ctSkinetTitleBar1.FormResize = false;
            this.ctSkinetTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.ctSkinetTitleBar1.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ctSkinetTitleBar1.MaximumSize = new System.Drawing.Size(0, 40);
            this.ctSkinetTitleBar1.MinimumSize = new System.Drawing.Size(200, 40);
            this.ctSkinetTitleBar1.Name = "ctSkinetTitleBar1";
            this.ctSkinetTitleBar1.Size = new System.Drawing.Size(332, 40);
            this.ctSkinetTitleBar1.TabIndex = 0;
            this.ctSkinetTitleBar1.Text = "Confirmacion de cuenta";
            // 
            // user1
            // 
            this.user1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.user1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.user1.Location = new System.Drawing.Point(109, 106);
            this.user1.MainColor = System.Drawing.Color.White;
            this.user1.MaxLength = 32767;
            this.user1.Multiline = false;
            this.user1.Name = "user1";
            this.user1.PlaceHolder = "User Name";
            this.user1.PlaceHolderColor = System.Drawing.SystemColors.GrayText;
            this.user1.ReadOnly = false;
            this.user1.SelectionLength = 0;
            this.user1.SelectionStart = 0;
            this.user1.Size = new System.Drawing.Size(150, 30);
            this.user1.TabIndex = 1;
            this.user1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.user1.UseSystemPasswordChar = false;
            // 
            // contra
            // 
            this.contra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.contra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contra.Location = new System.Drawing.Point(109, 173);
            this.contra.MainColor = System.Drawing.Color.White;
            this.contra.MaxLength = 32767;
            this.contra.Multiline = false;
            this.contra.Name = "contra";
            this.contra.PlaceHolder = "Password";
            this.contra.PlaceHolderColor = System.Drawing.SystemColors.GrayText;
            this.contra.ReadOnly = false;
            this.contra.SelectionLength = 0;
            this.contra.SelectionStart = 0;
            this.contra.Size = new System.Drawing.Size(150, 30);
            this.contra.TabIndex = 2;
            this.contra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contra.UseSystemPasswordChar = true;
            this.contra.TextChanged += new System.EventHandler(this.contra_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sistema.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(61, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sistema.Properties.Resources.candado;
            this.pictureBox3.Location = new System.Drawing.Point(61, 172);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // ctSkinetButtonRound1
            // 
            this.ctSkinetButtonRound1.BackColor = System.Drawing.Color.RoyalBlue;
            this.ctSkinetButtonRound1.FlatAppearance.BorderSize = 0;
            this.ctSkinetButtonRound1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctSkinetButtonRound1.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctSkinetButtonRound1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ctSkinetButtonRound1.Location = new System.Drawing.Point(109, 242);
            this.ctSkinetButtonRound1.MainColor = System.Drawing.Color.Blue;
            this.ctSkinetButtonRound1.Name = "ctSkinetButtonRound1";
            this.ctSkinetButtonRound1.Size = new System.Drawing.Size(115, 35);
            this.ctSkinetButtonRound1.TabIndex = 5;
            this.ctSkinetButtonRound1.Text = "OK";
            this.ctSkinetButtonRound1.UseVisualStyleBackColor = false;
            this.ctSkinetButtonRound1.Click += new System.EventHandler(this.ctSkinetButtonRound1_Click);
            // 
            // Verificacion
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(332, 317);
            this.Controls.Add(this.ctSkinetButtonRound1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.ctSkinetTitleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 728);
            this.Name = "Verificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Verificacion_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CTSkinet.CTSkinetButtonRound iniciar;
        private CTSkinet.CTSkinetTextBoxRound password;
        private CTSkinet.CTSkinetTextBoxRound user;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTSkinet.CTSkinetTitleBar ctSkinetTitleBar1;
        private CTSkinet.CTSkinetTextBoxRound user1;
        private CTSkinet.CTSkinetTextBoxRound contra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CTSkinet.CTSkinetButtonRound ctSkinetButtonRound1;
    }
}