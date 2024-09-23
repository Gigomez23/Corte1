namespace Corte1
{
    partial class RegistroDeEdadesGG
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.dtpBirtthDate = new System.Windows.Forms.DateTimePicker();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLegalAge = new System.Windows.Forms.Button();
            this.btnViewRegistry = new System.Windows.Forms.Button();
            this.lbRegistro = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(271, 55);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(47, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Nombre:";
            this.lblFirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(274, 96);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(47, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Apellido:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(207, 136);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(111, 13);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "Fecha de Nacimiento:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(278, 175);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "Ciudad:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(352, 55);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 4;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(352, 96);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 5;
            // 
            // dtpBirtthDate
            // 
            this.dtpBirtthDate.Location = new System.Drawing.Point(352, 136);
            this.dtpBirtthDate.Name = "dtpBirtthDate";
            this.dtpBirtthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirtthDate.TabIndex = 6;
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "Managua",
            "Leon",
            "Jinotega",
            "Boaco"});
            this.cbCity.Location = new System.Drawing.Point(352, 175);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 21);
            this.cbCity.TabIndex = 7;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(210, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLegalAge
            // 
            this.btnLegalAge.Enabled = false;
            this.btnLegalAge.Location = new System.Drawing.Point(323, 223);
            this.btnLegalAge.Name = "btnLegalAge";
            this.btnLegalAge.Size = new System.Drawing.Size(119, 23);
            this.btnLegalAge.TabIndex = 9;
            this.btnLegalAge.Text = "Es Mayor de Edad";
            this.btnLegalAge.UseVisualStyleBackColor = true;
            this.btnLegalAge.Click += new System.EventHandler(this.btnLegalAge_Click);
            // 
            // btnViewRegistry
            // 
            this.btnViewRegistry.Location = new System.Drawing.Point(477, 223);
            this.btnViewRegistry.Name = "btnViewRegistry";
            this.btnViewRegistry.Size = new System.Drawing.Size(86, 23);
            this.btnViewRegistry.TabIndex = 10;
            this.btnViewRegistry.Text = "Ver Registro";
            this.btnViewRegistry.UseVisualStyleBackColor = true;
            this.btnViewRegistry.Click += new System.EventHandler(this.btnViewRegistry_Click);
            // 
            // lbRegistro
            // 
            this.lbRegistro.FormattingEnabled = true;
            this.lbRegistro.Location = new System.Drawing.Point(244, 262);
            this.lbRegistro.Name = "lbRegistro";
            this.lbRegistro.Size = new System.Drawing.Size(263, 147);
            this.lbRegistro.TabIndex = 11;
            this.lbRegistro.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // RegistroDeEdadesGG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbRegistro);
            this.Controls.Add(this.btnViewRegistry);
            this.Controls.Add(this.btnLegalAge);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.dtpBirtthDate);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "RegistroDeEdadesGG";
            this.Text = "Registro de Edades - GG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.DateTimePicker dtpBirtthDate;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLegalAge;
        private System.Windows.Forms.Button btnViewRegistry;
        private System.Windows.Forms.ListBox lbRegistro;
    }
}

