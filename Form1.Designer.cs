namespace Control_Registro_de_ventas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            lblPrecio = new Label();
            label3 = new Label();
            btnRegistrar = new Button();
            txtCantidad = new TextBox();
            btnCancelar = new Button();
            cboTipo = new ComboBox();
            cboProductos = new ComboBox();
            lvVenta = new ListView();
            btnSalir = new Button();
            lblFeha = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(965, 100);
            label1.TabIndex = 0;
            label1.Text = "CONTROL DE REGISTRO DE VENTAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(857, 99);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Maiandra GD", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(682, 100);
            label4.Name = "label4";
            label4.Size = new Size(93, 18);
            label4.TabIndex = 3;
            label4.Text = "Fecha Actual:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(cboTipo);
            groupBox1.Controls.Add(cboProductos);
            groupBox1.Location = new Point(12, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(883, 203);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Area de Ventas";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Maiandra GD", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 26);
            label9.Name = "label9";
            label9.Size = new Size(140, 18);
            label9.TabIndex = 16;
            label9.Text = "Seleccione Producto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Maiandra GD", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 87);
            label8.Name = "label8";
            label8.Size = new Size(165, 18);
            label8.TabIndex = 15;
            label8.Text = "Seleccione tipo de pago:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Maiandra GD", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(614, 47);
            label6.Name = "label6";
            label6.Size = new Size(140, 18);
            label6.TabIndex = 13;
            label6.Text = "Precio del producto:";
            // 
            // lblPrecio
            // 
            lblPrecio.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(593, 67);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(170, 38);
            lblPrecio.TabIndex = 14;
            lblPrecio.Text = "lblPrecio";
            lblPrecio.TextAlign = ContentAlignment.MiddleCenter;
            lblPrecio.Click += label7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Maiandra GD", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(325, 26);
            label3.Name = "label3";
            label3.Size = new Size(72, 18);
            label3.TabIndex = 12;
            label3.Text = "Cantidad:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Orange;
            btnRegistrar.Location = new Point(453, 162);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(137, 41);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(325, 47);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(137, 26);
            txtCantidad.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Orange;
            btnCancelar.ForeColor = SystemColors.InactiveCaptionText;
            btnCancelar.Location = new Point(306, 162);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 41);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += button2_Click;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Contacto", "Tarjeta" });
            cboTipo.Location = new Point(20, 108);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(287, 27);
            cboTipo.TabIndex = 7;
            // 
            // cboProductos
            // 
            cboProductos.FormattingEnabled = true;
            cboProductos.Items.AddRange(new object[] { "Coleccion Escolar ", "Coleccion Preuniversitaria", "Coleccion Profesional" });
            cboProductos.Location = new Point(6, 43);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(287, 27);
            cboProductos.TabIndex = 5;
            cboProductos.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lvVenta
            // 
            lvVenta.GridLines = true;
            lvVenta.Location = new Point(12, 372);
            lvVenta.Name = "lvVenta";
            lvVenta.Size = new Size(915, 177);
            lvVenta.TabIndex = 9;
            lvVenta.UseCompatibleStateImageBehavior = false;
            lvVenta.View = View.Details;
            lvVenta.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Orange;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Location = new Point(852, 555);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 38);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblFeha
            // 
            lblFeha.AutoSize = true;
            lblFeha.Font = new Font("Maiandra GD", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFeha.Location = new Point(815, 100);
            lblFeha.Name = "lblFeha";
            lblFeha.Size = new Size(60, 18);
            lblFeha.TabIndex = 12;
            lblFeha.Text = "lblFecha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 678);
            Controls.Add(lblFeha);
            Controls.Add(btnSalir);
            Controls.Add(lvVenta);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de registro de ventas";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private GroupBox groupBox1;
        private ComboBox cboProductos;
        private ComboBox cboTipo;
        private TextBox txtCantidad;
        private ListView lvVenta;
        private Button btnCancelar;
        private Button btnSalir;
        private Button btnRegistrar;
        private Label label3;
        private Label lblFeha;
        private Label label6;
        private Label lblPrecio;
        private Label label9;
        private Label label8;
    }
}
