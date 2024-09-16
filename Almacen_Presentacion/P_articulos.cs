using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen_Presentacion
{
    public class P_articulos
    {
        public int Codigo_ar {  get; set; }
        public string Descripcion_ar { get; set; }
        public string Marca_ar { get; set; }
        public int Codigo_um { get; set; }
        public int Codigo_ca { get; set; }
        public decimal Stock_actual {  get; set; }
        public string Fecha_crea { get; set; }
        public string Fecha_modifica { get; set; }
    }
}
