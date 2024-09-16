using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Almacen_Presentacion
{
    public class D_Articulos
    {
        public DataTable listado_ar(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "select a.codigo_ar," +
                                   " a.descripcion_ar," +
                                   " a.marca_ar," +
                                   " b.descripcion_um," +
                                   " c.descripcion_ca," +
                                   " a.stock_actual," +
                                   " a.codigo_um," +
                                   " a.codigo_ca" +
                                   " from tb_articulos a " +
                                   " inner join tb_unidades_medidas b on a.codigo_um=b.codigo_um " +
                                   " inner join tb_categorias c on a.codigo_ca=c.codigo_ca "+
                                   "where a.descripcion_ar like '"+cTexto+"' "+
                                   "order by a.codigo_ar";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon)
                {
                    CommandTimeout = 60
                };
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            { 
                if(SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string Guardar_ar(int nOpcion, P_articulos oAr)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                if (nOpcion == 1) //Nuevo Registro
                {
                    Sqltarea = "insert into tb_articulos(descripcion_ar, " +
                                                        "marca_ar, " +
                                                        "codigo_um, " +
                                                        "codigo_ca, " +
                                                        "stock_actual," +
                                                        "fecha_crea," +
                                                        "fecha_modifica) " +
                                                "values('" + oAr.Descripcion_ar + "', " +
                                                        "'" + oAr.Marca_ar + "', " +
                                                        "'" + oAr.Codigo_um + "', " +
                                                        "'" + oAr.Codigo_ca + "', " +
                                                        "'" + oAr.Stock_actual + "', " +
                                                        "'" + oAr.Fecha_crea + "', " +
                                                        "'" + oAr.Fecha_modifica + "')";
                }
                else //Actualizar Registro
                {

                }
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
