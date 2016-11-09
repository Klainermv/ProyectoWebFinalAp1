using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Citas : ClaseMaestra
    {

        public int CitaId { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override bool Editar()
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Insertar()
        {
            ConexionDb  c = new ConexionDb();
            CitaId = Convert.ToInt32(c.ObtenerValorDb(string.Format("INSERT INTO Citas(Descripcion, Fecha)VALUES('{0}',{1}) select scope_identity()", Descripcion, Fecha)));

            return CitaId > 1;                       
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb c = new ConexionDb();
            return c.BuscarDb(string.Format("SELECT {0} FROM Citas WHERE {1} ORDER BY {2}",Campos,Condicion,Orden));             
        }
    }
}
