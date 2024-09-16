using System;
using System.Windows.Forms;

namespace Almacen_Presentacion
{
    partial class frm_articulos
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
            this.Dgv_articulos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_descripcion_ar = new System.Windows.Forms.TextBox();
            this.Txt_marca_ar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_descripcion_um = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_lupa_um = new System.Windows.Forms.Button();
            this.Btn_lupa_ca = new System.Windows.Forms.Button();
            this.Txt_descripcion_ca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_stock_actual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_articulos
            // 
            this.Dgv_articulos.AllowUserToAddRows = false;
            this.Dgv_articulos.AllowUserToDeleteRows = false;
            this.Dgv_articulos.AllowUserToOrderColumns = true;
            this.Dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_articulos.Location = new System.Drawing.Point(60, 189);
            this.Dgv_articulos.Name = "Dgv_articulos";
            this.Dgv_articulos.ReadOnly = true;
            this.Dgv_articulos.Size = new System.Drawing.Size(910, 318);
            this.Dgv_articulos.TabIndex = 0;
            this.Dgv_articulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_articulos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Tag = "";
            this.label1.Text = "Articulo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_descripcion_ar
            // 
            this.Txt_descripcion_ar.Location = new System.Drawing.Point(228, 26);
            this.Txt_descripcion_ar.Name = "Txt_descripcion_ar";
            this.Txt_descripcion_ar.ReadOnly = true;
            this.Txt_descripcion_ar.Size = new System.Drawing.Size(264, 20);
            this.Txt_descripcion_ar.TabIndex = 2;
            this.Txt_descripcion_ar.TextChanged += new System.EventHandler(this.Txt_descripcion_ar_TextChanged);
            // 
            // Txt_marca_ar
            // 
            this.Txt_marca_ar.Location = new System.Drawing.Point(569, 26);
            this.Txt_marca_ar.Name = "Txt_marca_ar";
            this.Txt_marca_ar.ReadOnly = true;
            this.Txt_marca_ar.Size = new System.Drawing.Size(264, 20);
            this.Txt_marca_ar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Tag = "";
            this.label2.Text = "Marca";
            // 
            // Txt_descripcion_um
            // 
            this.Txt_descripcion_um.Location = new System.Drawing.Point(228, 64);
            this.Txt_descripcion_um.Name = "Txt_descripcion_um";
            this.Txt_descripcion_um.ReadOnly = true;
            this.Txt_descripcion_um.Size = new System.Drawing.Size(218, 20);
            this.Txt_descripcion_um.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Tag = "";
            this.label3.Text = "Medida";
            // 
            // Btn_lupa_um
            // 
            this.Btn_lupa_um.Enabled = false;
            this.Btn_lupa_um.Location = new System.Drawing.Point(452, 64);
            this.Btn_lupa_um.Name = "Btn_lupa_um";
            this.Btn_lupa_um.Size = new System.Drawing.Size(40, 20);
            this.Btn_lupa_um.TabIndex = 7;
            this.Btn_lupa_um.Text = "...";
            this.Btn_lupa_um.UseVisualStyleBackColor = true;
            // 
            // Btn_lupa_ca
            // 
            this.Btn_lupa_ca.Enabled = false;
            this.Btn_lupa_ca.Location = new System.Drawing.Point(793, 67);
            this.Btn_lupa_ca.Name = "Btn_lupa_ca";
            this.Btn_lupa_ca.Size = new System.Drawing.Size(40, 20);
            this.Btn_lupa_ca.TabIndex = 10;
            this.Btn_lupa_ca.Text = "...";
            this.Btn_lupa_ca.UseVisualStyleBackColor = true;
            // 
            // Txt_descripcion_ca
            // 
            this.Txt_descripcion_ca.Location = new System.Drawing.Point(569, 67);
            this.Txt_descripcion_ca.Name = "Txt_descripcion_ca";
            this.Txt_descripcion_ca.ReadOnly = true;
            this.Txt_descripcion_ca.Size = new System.Drawing.Size(218, 20);
            this.Txt_descripcion_ca.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Tag = "";
            this.label4.Text = "Categoria";
            // 
            // Txt_stock_actual
            // 
            this.Txt_stock_actual.Location = new System.Drawing.Point(228, 102);
            this.Txt_stock_actual.Name = "Txt_stock_actual";
            this.Txt_stock_actual.ReadOnly = true;
            this.Txt_stock_actual.Size = new System.Drawing.Size(105, 20);
            this.Txt_stock_actual.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Tag = "";
            this.label5.Text = "Stock actual";
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Location = new System.Drawing.Point(446, 102);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelar.TabIndex = 13;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Visible = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(542, 102);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_guardar.TabIndex = 14;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Visible = false;
            this.Btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.Location = new System.Drawing.Point(1010, 40);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(85, 73);
            this.Btn_nuevo.TabIndex = 15;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.UseVisualStyleBackColor = true;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Location = new System.Drawing.Point(1010, 135);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(85, 73);
            this.Btn_actualizar.TabIndex = 16;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Location = new System.Drawing.Point(1010, 235);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(85, 73);
            this.Btn_eliminar.TabIndex = 17;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.Location = new System.Drawing.Point(1010, 331);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(85, 73);
            this.Btn_reporte.TabIndex = 18;
            this.Btn_reporte.Text = "Reporte";
            this.Btn_reporte.UseVisualStyleBackColor = true;
            // 
            // Btn_salir
            // 
            this.Btn_salir.Location = new System.Drawing.Point(1010, 433);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(85, 73);
            this.Btn_salir.TabIndex = 19;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = true;
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(228, 152);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(218, 20);
            this.Txt_buscar.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 20;
            this.label6.Tag = "";
            this.label6.Text = "Buscar";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(452, 152);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(40, 20);
            this.Btn_buscar.TabIndex = 22;
            this.Btn_buscar.Text = "...";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // frm_articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 519);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_buscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Txt_stock_actual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_lupa_ca);
            this.Controls.Add(this.Txt_descripcion_ca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_lupa_um);
            this.Controls.Add(this.Txt_descripcion_um);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_marca_ar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_descripcion_ar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_articulos);
            this.Name = "frm_articulos";
            this.Text = "frm_articulos";
            this.Load += new System.EventHandler(this.frm_articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Txt_descripcion_ar_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void frm_articulos_Load(object sender, EventArgs e)
        {
            this.Listado_ar("%");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Dgv_articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_articulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_descripcion_ar;
        private System.Windows.Forms.TextBox Txt_marca_ar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_descripcion_um;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_lupa_um;
        private System.Windows.Forms.Button Btn_lupa_ca;
        private System.Windows.Forms.TextBox Txt_descripcion_ca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_stock_actual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Button Btn_salir;
        private TextBox Txt_buscar;
        private Label label6;
        private Button Btn_buscar;
    }
}