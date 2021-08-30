
namespace Sistema
{
    partial class Crear
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
            this.components = new System.ComponentModel.Container();
            this.ctSkinetTitleBar1 = new CTSkinet.CTSkinetTitleBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Nom = new CTSkinet.CTSkinetTextBoxRound();
            this.Apepa = new CTSkinet.CTSkinetTextBoxRound();
            this.Apema = new CTSkinet.CTSkinetTextBoxRound();
            this.Femenino = new CTSkinet.CTSkinetCheckBox();
            this.Masculino = new CTSkinet.CTSkinetCheckBox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.Nacionalidad = new CTSkinet.CTSkinetComboFill();
            this.Correo = new CTSkinet.CTSkinetTextBoxRound();
            this.Contraseña = new CTSkinet.CTSkinetTextBoxRound();
            this.Contraseña1 = new CTSkinet.CTSkinetTextBoxRound();
            this.Telefono = new CTSkinet.CTSkinetTextBoxRound();
            this.Limpiar = new CTSkinet.CTSkinetButtonRound();
            this.Cancelar = new CTSkinet.CTSkinetButtonRound();
            this.Aceptar = new CTSkinet.CTSkinetButtonRound();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ctSkinetTitleBar1
            // 
            this.ctSkinetTitleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ctSkinetTitleBar1.BackgroundImage = global::Sistema.Properties.Resources.fondo;
            this.ctSkinetTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctSkinetTitleBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctSkinetTitleBar1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctSkinetTitleBar1.FormMaximize = true;
            this.ctSkinetTitleBar1.FormMinimize = true;
            this.ctSkinetTitleBar1.FormMoveable = true;
            this.ctSkinetTitleBar1.FormResize = false;
            this.ctSkinetTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.ctSkinetTitleBar1.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ctSkinetTitleBar1.MaximumSize = new System.Drawing.Size(0, 40);
            this.ctSkinetTitleBar1.MinimumSize = new System.Drawing.Size(200, 40);
            this.ctSkinetTitleBar1.Name = "ctSkinetTitleBar1";
            this.ctSkinetTitleBar1.Size = new System.Drawing.Size(593, 40);
            this.ctSkinetTitleBar1.TabIndex = 0;
            this.ctSkinetTitleBar1.Text = "Nuevo Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(384, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(210, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido Paterno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(239, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fecha de Nacimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(210, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Contraseña";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(40, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Correo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(406, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Nacionalidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(384, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Confirmar Contraseña";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(40, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Telefono";
            // 
            // Nom
            // 
            this.Nom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.Nom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Nom.Location = new System.Drawing.Point(43, 86);
            this.Nom.MainColor = System.Drawing.Color.White;
            this.Nom.MaxLength = 32767;
            this.Nom.Multiline = false;
            this.Nom.Name = "Nom";
            this.Nom.PlaceHolder = "";
            this.Nom.PlaceHolderColor = System.Drawing.SystemColors.GrayText;
            this.Nom.ReadOnly = false;
            this.Nom.SelectionLength = 0;
            this.Nom.SelectionStart = 0;
            this.Nom.Size = new System.Drawing.Size(150, 30);
            this.Nom.TabIndex = 14;
            this.Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Nom.UseSystemPasswordChar = false;
            // 
            // Apepa
            // 
            this.Apepa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.Apepa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Apepa.Location = new System.Drawing.Point(213, 86);
            this.Apepa.MainColor = System.Drawing.Color.White;
            this.Apepa.MaxLength = 32767;
            this.Apepa.Multiline = false;
            this.Apepa.Name = "Apepa";
            this.Apepa.PlaceHolder = "";
            this.Apepa.PlaceHolderColor = System.Drawing.SystemColors.GrayText;
            this.Apepa.ReadOnly = false;
            this.Apepa.SelectionLength = 0;
            this.Apepa.SelectionStart = 0;
            this.Apepa.Size = new System.Drawing.Size(150, 30);
            this.Apepa.TabIndex = 15;
            this.Apepa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Apepa.UseSystemPasswordChar = false;
            // 
            // Apema
            // 
            this.Apema.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.Apema.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Apema.Location = new System.Drawing.Point(387, 86);
            this.Apema.MainColor = System.Drawing.Color.White;
            this.Apema.MaxLength = 32767;
            this.Apema.Multiline = false;
            this.Apema.Name = "Apema";
            this.Apema.PlaceHolder = "";
            this.Apema.PlaceHolderColor = System.Drawing.SystemColors.GrayText;
            this.Apema.ReadOnly = false;
            this.Apema.SelectionLength = 0;
            this.Apema.SelectionStart = 0;
            this.Apema.Size = new System.Drawing.Size(150, 30);
            this.Apema.TabIndex = 16;
            this.Apema.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Apema.UseSystemPasswordChar = false;
            // 
            // Femenino
            // 
            this.Femenino.BackColor = System.Drawing.Color.Transparent;
            this.Femenino.Checked = false;
            this.Femenino.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Femenino.ForeColor = System.Drawing.Color.White;
            this.Femenino.Location = new System.Drawing.Point(41, 146);
            this.Femenino.MainColor = System.Drawing.Color.DarkGray;
            this.Femenino.Name = "Femenino";
            this.Femenino.Size = new System.Drawing.Size(90, 21);
            this.Femenino.SliderLocation = CTSkinet.CTSkinetCheckBox.SliderLocations.Right;
            this.Femenino.TabIndex = 17;
            this.Femenino.Text = "Femenino";
            this.Femenino.CheckedChanged += new CTSkinet.CTSkinetCheckBox.CheckedChangedEventHandler(this.Femenino_CheckedChanged);
            // 
            // Masculino
            // 
            this.Masculino.BackColor = System.Drawing.Color.Transparent;
            this.Masculino.Checked = false;
            this.Masculino.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Masculino.ForeColor = System.Drawing.Color.White;
            this.Masculino.Location = new System.Drawing.Point(137, 146);
            this.Masculino.MainColor = System.Drawing.Color.DarkGray;
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(101, 21);
            this.Masculino.SliderLocation = CTSkinet.CTSkinetCheckBox.SliderLocations.Right;
            this.Masculino.TabIndex = 18;
            this.Masculino.Text = "Masculino";
            this.Masculino.CheckedChanged += new CTSkinet.CTSkinetCheckBox.CheckedChangedEventHandler(this.Masculino_CheckedChanged);
            // 
            // Fecha
            // 
            this.Fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.CalendarForeColor = System.Drawing.Color.Transparent;
            this.Fecha.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.Fecha.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.Fecha.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.Fecha.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha.Location = new System.Drawing.Point(244, 147);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(129, 21);
            this.Fecha.TabIndex = 20;
            this.Fecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.BackColor = System.Drawing.Color.Transparent;
            this.Nacionalidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Nacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nacionalidad.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nacionalidad.ForeColor = System.Drawing.Color.Black;
            this.Nacionalidad.FormattingEnabled = true;
            this.Nacionalidad.ItemHeight = 24;
            this.Nacionalidad.Items.AddRange(new object[] {
            "Mexicano",
            "Brasileño",
            "Colonbiano"});
            this.Nacionalidad.Location = new System.Drawing.Point(402, 146);
            this.Nacionalidad.MainColor = System.Drawing.Color.Transparent;
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Nacionalidad.Size = new System.Drawing.Size(133, 30);
            this.Nacionalidad.StartIndex = 0;
            this.Nacionalidad.TabIndex = 21;
            // 
            // Correo
            // 
            this.Correo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.Correo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Correo.Location = new System.Drawing.Point(43, 195);
            this.Correo.MainColor = System.Drawing.Color.White;
            this.Correo.MaxLength = 32767;
            this.Correo.Multiline = false;
            this.Correo.Name = "Correo";
            this.Correo.PlaceHolder = "";
            this.Correo.PlaceHolderColor = System.Drawing.SystemColors.GrayText;
            this.Correo.ReadOnly = false;
            this.Correo.SelectionLength = 0;
            this.Correo.SelectionStart = 0;
            this.Correo.Size = new System.Drawing.Size(150, 30);
            this.Correo.TabIndex = 22;
            this.Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Correo.UseSystemPasswordChar = false;
            // 
            // Contraseña
            // 
            this.Contraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.Contraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Contraseña.Location = new System.Drawing.Point(213, 195);
            this.Contraseña.MainColor = System.Drawing.Color.White;
            this.Contraseña.MaxLength = 32767;
            this.Contraseña.Multiline = false;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PlaceHolder = "";
            this.Contraseña.PlaceHolderColor = System.Drawing.SystemColors.GrayText;
            this.Contraseña.ReadOnly = false;
            this.Contraseña.SelectionLength = 0;
            this.Contraseña.SelectionStart = 0;
            this.Contraseña.Size = new System.Drawing.Size(150, 30);
            this.Contraseña.TabIndex = 23;
            this.Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Contraseña.UseSystemPasswordChar = false;
            // 
            // Contraseña1
            // 
            this.Contraseña1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.Contraseña1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Contraseña1.Location = new System.Drawing.Point(387, 195);
            this.Contraseña1.MainColor = System.Drawing.Color.White;
            this.Contraseña1.MaxLength = 32767;
            this.Contraseña1.Multiline = false;
            this.Contraseña1.Name = "Contraseña1";
            this.Contraseña1.PlaceHolder = "";
            this.Contraseña1.PlaceHolderColor = System.Drawing.SystemColors.GrayText;
            this.Contraseña1.ReadOnly = false;
            this.Contraseña1.SelectionLength = 0;
            this.Contraseña1.SelectionStart = 0;
            this.Contraseña1.Size = new System.Drawing.Size(150, 30);
            this.Contraseña1.TabIndex = 24;
            this.Contraseña1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Contraseña1.UseSystemPasswordChar = false;
            // 
            // Telefono
            // 
            this.Telefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.Telefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Telefono.Location = new System.Drawing.Point(41, 255);
            this.Telefono.MainColor = System.Drawing.Color.White;
            this.Telefono.MaxLength = 32767;
            this.Telefono.Multiline = false;
            this.Telefono.Name = "Telefono";
            this.Telefono.PlaceHolder = "";
            this.Telefono.PlaceHolderColor = System.Drawing.SystemColors.GrayText;
            this.Telefono.ReadOnly = false;
            this.Telefono.SelectionLength = 0;
            this.Telefono.SelectionStart = 0;
            this.Telefono.Size = new System.Drawing.Size(150, 30);
            this.Telefono.TabIndex = 25;
            this.Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Telefono.UseSystemPasswordChar = false;
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.Transparent;
            this.Limpiar.FlatAppearance.BorderSize = 0;
            this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.ForeColor = System.Drawing.SystemColors.Window;
            this.Limpiar.Location = new System.Drawing.Point(350, 255);
            this.Limpiar.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(98, 35);
            this.Limpiar.TabIndex = 27;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.Cancelar.FlatAppearance.BorderSize = 0;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.Info;
            this.Cancelar.Location = new System.Drawing.Point(244, 255);
            this.Cancelar.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(100, 35);
            this.Cancelar.TabIndex = 28;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.Color.Transparent;
            this.Aceptar.FlatAppearance.BorderSize = 0;
            this.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.Window;
            this.Aceptar.Location = new System.Drawing.Point(454, 255);
            this.Aceptar.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(98, 35);
            this.Aceptar.TabIndex = 29;
            this.Aceptar.Text = "Crear";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Crear
            // 
            this.BackgroundImage = global::Sistema.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(593, 323);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Contraseña1);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Nacionalidad);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Masculino);
            this.Controls.Add(this.Femenino);
            this.Controls.Add(this.Apema);
            this.Controls.Add(this.Apepa);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctSkinetTitleBar1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 728);
            this.Name = "Crear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTSkinet.CTSkinetTitleBar ctSkinetTitleBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private CTSkinet.CTSkinetTextBoxRound Nom;
        private CTSkinet.CTSkinetTextBoxRound Apepa;
        private CTSkinet.CTSkinetTextBoxRound Apema;
        private CTSkinet.CTSkinetCheckBox Femenino;
        private CTSkinet.CTSkinetCheckBox Masculino;
        private System.Windows.Forms.DateTimePicker Fecha;
        private CTSkinet.CTSkinetComboFill Nacionalidad;
        private CTSkinet.CTSkinetTextBoxRound Correo;
        private CTSkinet.CTSkinetTextBoxRound Contraseña;
        private CTSkinet.CTSkinetTextBoxRound Contraseña1;
        private CTSkinet.CTSkinetTextBoxRound Telefono;
        private CTSkinet.CTSkinetButtonRound Limpiar;
        private CTSkinet.CTSkinetButtonRound Cancelar;
        private CTSkinet.CTSkinetButtonRound Aceptar;
        private System.Windows.Forms.Timer timer1;
    }
}