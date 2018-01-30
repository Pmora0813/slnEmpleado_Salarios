namespace slnEmpleado_Salarios
{
    partial class FrmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSalPorMes = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rbtnmasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cmbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.mskSalPorMes = new System.Windows.Forms.MaskedTextBox();
            this.mskCedula = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.mskPorcComision = new System.Windows.Forms.MaskedTextBox();
            this.mskVentasporMes = new System.Windows.Forms.MaskedTextBox();
            this.lblPorcComicion = new System.Windows.Forms.Label();
            this.lblVentasPorMes = new System.Windows.Forms.Label();
            this.lblHorasPormes = new System.Windows.Forms.Label();
            this.lblPrecioPorHora = new System.Windows.Forms.Label();
            this.mskHorasPorMes = new System.Windows.Forms.MaskedTextBox();
            this.mskPrecioPorHora = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indentificaión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Género";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado Civil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de Empleado";
            // 
            // lblSalPorMes
            // 
            this.lblSalPorMes.AutoSize = true;
            this.lblSalPorMes.Location = new System.Drawing.Point(388, 111);
            this.lblSalPorMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalPorMes.Name = "lblSalPorMes";
            this.lblSalPorMes.Size = new System.Drawing.Size(100, 16);
            this.lblSalPorMes.TabIndex = 6;
            this.lblSalPorMes.Text = "Salaro por Mes";
            this.lblSalPorMes.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 57);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // rbtnmasculino
            // 
            this.rbtnmasculino.AutoSize = true;
            this.rbtnmasculino.Location = new System.Drawing.Point(116, 110);
            this.rbtnmasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnmasculino.Name = "rbtnmasculino";
            this.rbtnmasculino.Size = new System.Drawing.Size(87, 20);
            this.rbtnmasculino.TabIndex = 9;
            this.rbtnmasculino.TabStop = true;
            this.rbtnmasculino.Text = "Masculino";
            this.rbtnmasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Location = new System.Drawing.Point(233, 110);
            this.rbtnFemenino.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(86, 20);
            this.rbtnFemenino.TabIndex = 10;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(116, 166);
            this.cmbEstadoCivil.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(211, 24);
            this.cmbEstadoCivil.TabIndex = 11;
            // 
            // cmbTipoEmpleado
            // 
            this.cmbTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEmpleado.FormattingEnabled = true;
            this.cmbTipoEmpleado.Location = new System.Drawing.Point(537, 72);
            this.cmbTipoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            this.cmbTipoEmpleado.Size = new System.Drawing.Size(211, 24);
            this.cmbTipoEmpleado.TabIndex = 12;
            this.cmbTipoEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEmpleado_SelectedIndexChanged);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(481, 34);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaNacimiento.TabIndex = 13;
            // 
            // mskSalPorMes
            // 
            this.mskSalPorMes.Location = new System.Drawing.Point(392, 135);
            this.mskSalPorMes.Margin = new System.Windows.Forms.Padding(4);
            this.mskSalPorMes.Mask = "99999999999";
            this.mskSalPorMes.Name = "mskSalPorMes";
            this.mskSalPorMes.Size = new System.Drawing.Size(93, 22);
            this.mskSalPorMes.TabIndex = 14;
            this.mskSalPorMes.Visible = false;
            // 
            // mskCedula
            // 
            this.mskCedula.Location = new System.Drawing.Point(119, 14);
            this.mskCedula.Margin = new System.Windows.Forms.Padding(4);
            this.mskCedula.Mask = "0-0000-0000";
            this.mskCedula.Name = "mskCedula";
            this.mskCedula.Size = new System.Drawing.Size(175, 22);
            this.mskCedula.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(115, 198);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(212, 60);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(13, 292);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(758, 210);
            this.dgvEmpleados.TabIndex = 17;
            // 
            // mskPorcComision
            // 
            this.mskPorcComision.Location = new System.Drawing.Point(395, 186);
            this.mskPorcComision.Margin = new System.Windows.Forms.Padding(4);
            this.mskPorcComision.Mask = "99999999999";
            this.mskPorcComision.Name = "mskPorcComision";
            this.mskPorcComision.Size = new System.Drawing.Size(93, 22);
            this.mskPorcComision.TabIndex = 18;
            this.mskPorcComision.Visible = false;
            // 
            // mskVentasporMes
            // 
            this.mskVentasporMes.Location = new System.Drawing.Point(395, 135);
            this.mskVentasporMes.Margin = new System.Windows.Forms.Padding(4);
            this.mskVentasporMes.Mask = "99999999999";
            this.mskVentasporMes.Name = "mskVentasporMes";
            this.mskVentasporMes.Size = new System.Drawing.Size(93, 22);
            this.mskVentasporMes.TabIndex = 19;
            this.mskVentasporMes.Visible = false;
            // 
            // lblPorcComicion
            // 
            this.lblPorcComicion.AutoSize = true;
            this.lblPorcComicion.Location = new System.Drawing.Point(391, 167);
            this.lblPorcComicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcComicion.Name = "lblPorcComicion";
            this.lblPorcComicion.Size = new System.Drawing.Size(132, 16);
            this.lblPorcComicion.TabIndex = 20;
            this.lblPorcComicion.Text = "Porcentaje Comision";
            this.lblPorcComicion.Visible = false;
            // 
            // lblVentasPorMes
            // 
            this.lblVentasPorMes.AutoSize = true;
            this.lblVentasPorMes.Location = new System.Drawing.Point(391, 115);
            this.lblVentasPorMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentasPorMes.Name = "lblVentasPorMes";
            this.lblVentasPorMes.Size = new System.Drawing.Size(102, 16);
            this.lblVentasPorMes.TabIndex = 21;
            this.lblVentasPorMes.Text = "Ventas por Mes";
            this.lblVentasPorMes.Visible = false;
            // 
            // lblHorasPormes
            // 
            this.lblHorasPormes.AutoSize = true;
            this.lblHorasPormes.Location = new System.Drawing.Point(389, 110);
            this.lblHorasPormes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorasPormes.Name = "lblHorasPormes";
            this.lblHorasPormes.Size = new System.Drawing.Size(100, 16);
            this.lblHorasPormes.TabIndex = 25;
            this.lblHorasPormes.Text = "Horas  por Mes";
            this.lblHorasPormes.Visible = false;
            // 
            // lblPrecioPorHora
            // 
            this.lblPrecioPorHora.AutoSize = true;
            this.lblPrecioPorHora.Location = new System.Drawing.Point(387, 168);
            this.lblPrecioPorHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioPorHora.Name = "lblPrecioPorHora";
            this.lblPrecioPorHora.Size = new System.Drawing.Size(103, 16);
            this.lblPrecioPorHora.TabIndex = 24;
            this.lblPrecioPorHora.Text = "Precio por Hora";
            this.lblPrecioPorHora.Visible = false;
            // 
            // mskHorasPorMes
            // 
            this.mskHorasPorMes.Location = new System.Drawing.Point(391, 135);
            this.mskHorasPorMes.Margin = new System.Windows.Forms.Padding(4);
            this.mskHorasPorMes.Mask = "99999999999";
            this.mskHorasPorMes.Name = "mskHorasPorMes";
            this.mskHorasPorMes.Size = new System.Drawing.Size(104, 22);
            this.mskHorasPorMes.TabIndex = 23;
            this.mskHorasPorMes.Visible = false;
            // 
            // mskPrecioPorHora
            // 
            this.mskPrecioPorHora.Location = new System.Drawing.Point(392, 188);
            this.mskPrecioPorHora.Margin = new System.Windows.Forms.Padding(4);
            this.mskPrecioPorHora.Mask = "99999999999";
            this.mskPrecioPorHora.Name = "mskPrecioPorHora";
            this.mskPrecioPorHora.Size = new System.Drawing.Size(104, 22);
            this.mskPrecioPorHora.TabIndex = 22;
            this.mskPrecioPorHora.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 515);
            this.Controls.Add(this.lblHorasPormes);
            this.Controls.Add(this.lblPrecioPorHora);
            this.Controls.Add(this.mskHorasPorMes);
            this.Controls.Add(this.mskPrecioPorHora);
            this.Controls.Add(this.lblVentasPorMes);
            this.Controls.Add(this.lblPorcComicion);
            this.Controls.Add(this.mskVentasporMes);
            this.Controls.Add(this.mskPorcComision);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.mskCedula);
            this.Controls.Add(this.mskSalPorMes);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.cmbTipoEmpleado);
            this.Controls.Add(this.cmbEstadoCivil);
            this.Controls.Add(this.rbtnFemenino);
            this.Controls.Add(this.rbtnmasculino);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSalPorMes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
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
        private System.Windows.Forms.Label lblSalPorMes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton rbtnmasculino;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.ComboBox cmbTipoEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.MaskedTextBox mskSalPorMes;
        private System.Windows.Forms.MaskedTextBox mskCedula;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.MaskedTextBox mskPorcComision;
        private System.Windows.Forms.MaskedTextBox mskVentasporMes;
        private System.Windows.Forms.Label lblPorcComicion;
        private System.Windows.Forms.Label lblVentasPorMes;
        private System.Windows.Forms.Label lblHorasPormes;
        private System.Windows.Forms.Label lblPrecioPorHora;
        private System.Windows.Forms.MaskedTextBox mskHorasPorMes;
        private System.Windows.Forms.MaskedTextBox mskPrecioPorHora;
    }
}

