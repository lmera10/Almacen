using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen_Presentacion
{
    public partial class frm_articulos : Form
    {
        public frm_articulos()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int nCodigo_ar = 0;
        int nEstadoguarda = 0;

        public object P_Articulos { get; private set; }
        #endregion
        #region "Mis Metodos"
        private void Formato_ar()
        {
            Dgv_articulos.Columns[0].Width = 80;
            Dgv_articulos.Columns[0].HeaderText = "CODIGO";
            Dgv_articulos.Columns[1].Width = 250;
            Dgv_articulos.Columns[1].HeaderText = "ARTICULO";
            Dgv_articulos.Columns[2].Width = 150;
            Dgv_articulos.Columns[2].HeaderText = "MARCA";
            Dgv_articulos.Columns[3].Width = 80;
            Dgv_articulos.Columns[3].HeaderText = "MEDIDA";
            Dgv_articulos.Columns[4].Width = 150;
            Dgv_articulos.Columns[4].HeaderText = "CATEGORIA";
            Dgv_articulos.Columns[5].Width = 150;
            Dgv_articulos.Columns[5].HeaderText = "STOCK ACTUAL";
            Dgv_articulos.Columns[6].Visible = false;
            Dgv_articulos.Columns[7].Visible = false;
        }
        private void Listado_ar(string cTexto)
        {
            D_Articulos Datos = new D_Articulos();
            Dgv_articulos.DataSource = Datos.listado_ar(cTexto);
            this.Formato_ar();
        }
        private void Estado_texto(bool lEstado)
        {
            Txt_descripcion_ar.ReadOnly = !lEstado;
            Txt_marca_ar.ReadOnly = !lEstado;
            Txt_stock_actual.ReadOnly = !lEstado;
        }
        private void Estado_botones_procesos(bool lEstado)
        {
            Btn_lupa_um.Enabled = lEstado;
            Btn_lupa_ca.Enabled = lEstado;

            Btn_cancelar.Visible = lEstado;
            Btn_guardar.Visible = lEstado;

            //otros detalles
            Txt_buscar.ReadOnly = lEstado;
            Btn_buscar.Enabled = !lEstado;
            Dgv_articulos.Enabled = !lEstado;
        }
        private void Estado_botones_principales(bool lEstado)
        {
            Btn_nuevo.Enabled = lEstado;
            Btn_actualizar.Enabled = lEstado;
            Btn_eliminar.Enabled = lEstado;
            Btn_reporte.Enabled = lEstado;
            Btn_salir.Enabled = lEstado;
        }
        private void Limpia_texto()
        {
            Txt_descripcion_ar.Text = "";
            Txt_marca_ar.Text = "";
            Txt_descripcion_um.Text = "";
            Txt_descripcion_ca.Text = "";
            Txt_stock_actual.Text = "";

        }
        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty (Convert.ToString(Dgv_articulos.CurrentRow.Cells["codigo_ar"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigo_ar = Convert.ToInt32(Dgv_articulos.CurrentRow.Cells["codigo_ar"].Value);
                Txt_descripcion_ar.Text= Convert.ToString(Dgv_articulos.CurrentRow.Cells["descripcion_ar"].Value);
                Txt_marca_ar.Text = Convert.ToString(Dgv_articulos.CurrentRow.Cells["marca_ar"].Value);
                Txt_descripcion_um.Text = Convert.ToString(Dgv_articulos.CurrentRow.Cells["descripcion_um"].Value);
                Txt_descripcion_ca.Text = Convert.ToString(Dgv_articulos.CurrentRow.Cells["descripcion_ca"].Value);
                Txt_stock_actual.Text = Convert.ToString(Dgv_articulos.CurrentRow.Cells["stock_actual"].Value);
                Txt_stock_actual.Text = Convert.ToString(Dgv_articulos.CurrentRow.Cells["stock_actual"].Value);

            }
        }
        #endregion

        private void Frm_articulos_Load(object sender, EventArgs e)
        {
            this.Listado_ar("%");
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_ar("%"+Txt_buscar.Text.Trim()+"%");
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nEstadoguarda = 1; //nuevo registro
            this.Limpia_texto();
            this.Estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estado_botones_principales(false);
            Txt_descripcion_ar.Focus();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            nCodigo_ar = 0;
            nEstadoguarda = 0;
            this.Limpia_texto();
            this.Estado_texto(false);
            this.Estado_botones_procesos(false);
            this.Estado_botones_principales(true);
            Txt_buscar.Focus();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            P_articulos oAr=new P_articulos();
            oAr.Codigo_ar = nCodigo_ar;
            oAr.Descripcion_ar = Txt_descripcion_ar.Text.Trim();
            oAr.Marca_ar = Txt_marca_ar.Text.Trim();
            oAr.Codigo_um = 1;
            oAr.Codigo_ca = 1;
            oAr.Stock_actual = Convert.ToDecimal(Txt_stock_actual.Text);
            oAr.Fecha_crea = DateTime.Now.ToString("yyyy-MM-dd");
            oAr.Fecha_modifica = DateTime.Now.ToString("yyyy-MM-dd");

            D_Articulos Datos = new D_Articulos();
            Rpta = Datos.Guardar_ar(nEstadoguarda,oAr);
            if (Rpta.Equals("OK")) 
            {
                this.Estado_texto(false);
                this.Estado_botones_procesos(false);
                this.Estado_botones_principales(true);
                this.Listado_ar("%");
                nCodigo_ar = 0;
                nEstadoguarda = 0;
                MessageBox.Show("Los datos han sido guardados correctamente",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show(Rpta,
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            nEstadoguarda = 2; //actualizar registro
            this.Estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estado_botones_principales(false);
            Txt_descripcion_ar.Focus();
        }

        private void Dgv_articulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (nCodigo_ar > 0) 
            {
                string Rpta = "";
                D_Articulos Datos = new D_Articulos();
                Rpta = Datos.Eliminar_ar(nCodigo_ar);
                if (Rpta.Equals("OK")) 
                {
                    this.Limpia_texto();
                    this.Listado_ar("&");
                    nCodigo_ar = 0;
                    MessageBox.Show("Registro eliminado correctamente",
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No se tiene seleccionado ningun registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Frm_Rpt_Articulos oRpt = new Frm_Rpt_Articulos();
            oRpt.ShowDialog();
        }
    }
    
}
