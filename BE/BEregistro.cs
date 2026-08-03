using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEregistro
    {
        public string nombre { get; set; }
        public string accion { get; set; }
        public int? cantidad_ropa_vendida { get; set; }
        public DateTime fecha { get; set; }
        public BEregistro() { }
        public BEregistro(string nombr,string accio)
        {
            nombre = nombr;
            accion = accio;
            fecha = DateTime.Now;
        }
        public BEregistro(string nombr, string accio,int cantidad_ropa)
        {
            nombre = nombr;
            accion = accio;
            fecha = DateTime.Now;
            cantidad_ropa_vendida = cantidad_ropa;
        }

    }
}
