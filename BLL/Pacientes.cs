using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Pacientes : ClaseMaestra
    {

        public int Id { get; set; }
        public int PersonaId { get; set; }
        public bool EsNuevo { get; set; }
        public bool EsAsegurado { get; set; }

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb cnx = new ConexionDb();
            string sql = string.Format("SELECT * FROM Pacientes WHERE (PacienteId = {0}) ", IdBuscado);
            return cnx.EjecutarDB(sql);
        }

        public override bool Editar()
        {
            ConexionDb cnx = new ConexionDb();
            string sql = string.Format("UPDATE Pacientes SET EsNuevo = '{0}', EsAsegurado = '{1}' WHERE PacienteId = {2}", EsNuevo, EsAsegurado, Id);
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
            string sql = string.Format("INSERT INTO Pacientes(PersonaId, EsNuevo, EsAsegurado)VALUES({0},'{1}','{2}') ", PersonaId, EsNuevo, EsAsegurado);
            Id = Convert.ToInt32(cnx.ObtenerValorDb(sql));
            return Id > 1;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }

        public DataTable Listado2() {
            ConexionDb cnx = new ConexionDb();
            string sql = string.Format("SELECT pe.Nombres, pe.Apellidos, pe.Cedula, pe.Telefono, pa.EsNuevo, pa.EsASegurado FROM Personas pe JOIN Pacientes pa ON pa.PersonaId = pe.PersonaId WHERE (pe.Activo = 1)");
            return cnx.BuscarDb(sql);
        }

        public DataTable ListadoBusqueda(string consulta){
            ConexionDb cnx = new ConexionDb();
            string sql = string.Format("SELECT pe.Nombres, pe.Apellidos, pe.Cedula, pe.Telefono, pa.EsNuevo, pa.EsASegurado FROM Personas pe JOIN Pacientes pa ON pa.PersonaId = pe.PersonaId WHERE (pe.Activo = 1) AND ( pe.Nombres LIKE '%{0}%' OR pe.Apellidos LIKE '%{0}%' OR pe.Cedula LIKE '%{0}%' OR pe.Telefono LIKE '%{0}%' )",consulta);
            return cnx.BuscarDb(sql);
        }
    }
}
