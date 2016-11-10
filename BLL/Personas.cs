using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Personas : ClaseMaestra
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }


        public override bool Buscar(int IdBuscado)
        {
            ConexionDb cnx = new ConexionDb();
            string sql = string.Format("SELECT * FROM Personas WHERE (Activo = 1) AND (PersonaId = {0}) ",IdBuscado);
            return cnx.EjecutarDB(sql);
        }

        public override bool Editar()
        {
            ConexionDb cnx = new ConexionDb();
            string sql = string.Format("UPDATE Personas SET Nombres = '{0}', Apellidos = '{1}', Cedula = '{2}', Telefono = '{3}' WHERE PersonaId = {4}", Nombres, Apellidos, Cedula, Telefono, Id);
            return cnx.EjecutarDB(sql);
        }

        public override bool Eliminar()
        {
            ConexionDb cnx = new ConexionDb();
            string sql = string.Format("UPDATE Personas SET Activo = 0 WHERE PersonaId = {0}", Id);
            return cnx.EjecutarDB(sql);
        }

        public override bool Insertar()
        {
            ConexionDb cnx = new ConexionDb();
            string sql = string.Format("INSERT INTO Personas(Nombres, Apellidos, Cedula, Telefono)VALUES('{0}','{1}','{2}','{3}') SELECT scope_identity()", Nombres, Apellidos, Cedula, Telefono);
            Id = Convert.ToInt32(cnx.ObtenerValorDb(sql));
            return Id > 1;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb cnx = new ConexionDb();
            string sql = string.Format("SELECT {0} FROM Personas WHERE {1} {2}",Campos,Condicion, Orden);
            return cnx.BuscarDb(sql);
        }
    }
}
