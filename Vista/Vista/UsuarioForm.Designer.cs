namespace Vista
{
    partial class UsuarioForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CodigoUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.NombreUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.CorreoUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ContrasenaUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.RolComboBox = new System.Windows.Forms.ComboBox();
            this.EstaActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.UsuariosDataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contrasena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rol:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Esta Activo:";
            // 
            // CodigoUsuarioTextBox
            // 
            this.CodigoUsuarioTextBox.Location = new System.Drawing.Point(130, 25);
            this.CodigoUsuarioTextBox.Name = "CodigoUsuarioTextBox";
            this.CodigoUsuarioTextBox.Size = new System.Drawing.Size(224, 22);
            this.CodigoUsuarioTextBox.TabIndex = 6;
            // 
            // NombreUsuarioTextBox
            // 
            this.NombreUsuarioTextBox.Location = new System.Drawing.Point(130, 58);
            this.NombreUsuarioTextBox.Name = "NombreUsuarioTextBox";
            this.NombreUsuarioTextBox.Size = new System.Drawing.Size(224, 22);
            this.NombreUsuarioTextBox.TabIndex = 7;
            // 
            // CorreoUsuarioTextBox
            // 
            this.CorreoUsuarioTextBox.Location = new System.Drawing.Point(130, 94);
            this.CorreoUsuarioTextBox.Name = "CorreoUsuarioTextBox";
            this.CorreoUsuarioTextBox.Size = new System.Drawing.Size(224, 22);
            this.CorreoUsuarioTextBox.TabIndex = 8;
            // 
            // ContrasenaUsuarioTextBox
            // 
            this.ContrasenaUsuarioTextBox.Location = new System.Drawing.Point(130, 128);
            this.ContrasenaUsuarioTextBox.Name = "ContrasenaUsuarioTextBox";
            this.ContrasenaUsuarioTextBox.PasswordChar = '*';
            this.ContrasenaUsuarioTextBox.Size = new System.Drawing.Size(224, 22);
            this.ContrasenaUsuarioTextBox.TabIndex = 9;
            // 
            // RolComboBox
            // 
            this.RolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolComboBox.FormattingEnabled = true;
            this.RolComboBox.Items.AddRange(new object[] {
            "Gerente General",
            "Servicio al cliente",
            "Soporte Tecnico",
            "Analista financiero"});
            this.RolComboBox.Location = new System.Drawing.Point(130, 168);
            this.RolComboBox.Name = "RolComboBox";
            this.RolComboBox.Size = new System.Drawing.Size(224, 24);
            this.RolComboBox.TabIndex = 12;
            // 
            // EstaActivoCheckBox
            // 
            this.EstaActivoCheckBox.AutoSize = true;
            this.EstaActivoCheckBox.Location = new System.Drawing.Point(130, 202);
            this.EstaActivoCheckBox.Name = "EstaActivoCheckBox";
            this.EstaActivoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.EstaActivoCheckBox.TabIndex = 13;
            this.EstaActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // ModificarButton
            // 
            this.ModificarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModificarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModificarButton.Image = global::Vista.Properties.Resources.componer;
            this.ModificarButton.Location = new System.Drawing.Point(172, 241);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(45, 34);
            this.ModificarButton.TabIndex = 38;
            this.ModificarButton.UseVisualStyleBackColor = false;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CancelarButton.Image = global::Vista.Properties.Resources.cancelar__1_;
            this.CancelarButton.Location = new System.Drawing.Point(321, 241);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(45, 34);
            this.CancelarButton.TabIndex = 37;
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EliminarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EliminarButton.Image = global::Vista.Properties.Resources.borrar_usuario;
            this.EliminarButton.Location = new System.Drawing.Point(273, 241);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(42, 34);
            this.EliminarButton.TabIndex = 36;
            this.EliminarButton.UseVisualStyleBackColor = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GuardarButton.Enabled = false;
            this.GuardarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GuardarButton.Image = global::Vista.Properties.Resources.ahorrar__1_;
            this.GuardarButton.Location = new System.Drawing.Point(223, 241);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(44, 34);
            this.GuardarButton.TabIndex = 35;
            this.GuardarButton.UseVisualStyleBackColor = false;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NuevoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NuevoButton.Image = global::Vista.Properties.Resources.nueva_capa;
            this.NuevoButton.Location = new System.Drawing.Point(121, 241);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(45, 34);
            this.NuevoButton.TabIndex = 34;
            this.NuevoButton.UseVisualStyleBackColor = false;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // UsuariosDataGridView1
            // 
            this.UsuariosDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuariosDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosDataGridView1.Location = new System.Drawing.Point(0, 281);
            this.UsuariosDataGridView1.Name = "UsuariosDataGridView1";
            this.UsuariosDataGridView1.Size = new System.Drawing.Size(652, 174);
            this.UsuariosDataGridView1.TabIndex = 39;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 457);
            this.Controls.Add(this.UsuariosDataGridView1);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.EstaActivoCheckBox);
            this.Controls.Add(this.RolComboBox);
            this.Controls.Add(this.ContrasenaUsuarioTextBox);
            this.Controls.Add(this.CorreoUsuarioTextBox);
            this.Controls.Add(this.NombreUsuarioTextBox);
            this.Controls.Add(this.CodigoUsuarioTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsuarioForm";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.UsuarioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CodigoUsuarioTextBox;
        private System.Windows.Forms.TextBox NombreUsuarioTextBox;
        private System.Windows.Forms.TextBox CorreoUsuarioTextBox;
        private System.Windows.Forms.TextBox ContrasenaUsuarioTextBox;
        private System.Windows.Forms.ComboBox RolComboBox;
        private System.Windows.Forms.CheckBox EstaActivoCheckBox;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.DataGridView UsuariosDataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}