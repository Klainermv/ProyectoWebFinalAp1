using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    class Usuarios : ClaseMaestra
    {
        public int UsuarioId { get; set; }
        public int PersonaId { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public bool EsActivo { get; set; }

        public Usuarios(){
            UsuarioId = 0;
            PersonaId = 0;
            NombreUsuario = "";
            Contrasena = "";
            EsActivo = false;
        }

        public Usuarios(int usuariosid, int personaid, string nombreusuario, string contrasena,bool esactivo){
            UsuarioId = usuariosid;
            PersonaId = personaid;
            NombreUsuario = nombreusuario;
            Contrasena = contrasena;
            EsActivo = esactivo;
        }

        public override bool Insertar()
        {
            ConexionDb cnx = new ConexionDb();
            UsuarioId = Convert.ToInt32(cnx.ObtenerValorDb(string.Format("INSERT INTO Usuarios(PersonaId, NombreUsuario, Contrasena, EsActivo)VALUES({0},'{1}', '{2}', {3}) SELECT scope_identity()")));

            return UsuarioId > 0;
        }

        public override bool Editar()
        {
            ConexionDb cnx = new ConexionDb();
            return cnx.EjecutarDB(string.Format("UPDATE Usuarios SET PersonaId = {0}, NombreUsuario = '{1}', Contrasena = '{2}', EsActivo = {3} WHERE UsuarioId = {4} ",PersonaId, NombreUsuario, Contrasena, EsActivo, UsuarioId));
        }

        public override bool Eliminar()
        {
            ConexionDb cnx = new ConexionDb();
            return cnx.EjecutarDB(string.Format("UPDATE Usuarios SET EsActivo = false WHERE UsuarioId = {1}", UsuarioId));
        }

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb cnx = new ConexionDb();
            DataTable dt = cnx.BuscarDb(string.Format("SELECT * FROM Usuarios WHERE UsuarioId = {0}",IdBuscado));

            UsuarioId = Convert.ToInt32(dt.Rows[0]["UsuarioId"]);
            PersonaId = Convert.ToInt32(dt.Rows[0]["PersonaId"]);
            NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
            Contrasena = dt.Rows[0]["Contrasena"].ToString();
            EsActivo = Convert.ToBoolean(dt.Rows[0]["EsActivo"]);

            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos = "*", string Condicion = "1=1", string Orden = "UsuarioId DESC")
        {
            ConexionDb cnx = new ConexionDb();
            return cnx.BuscarDb(string.Format("SELECT {0} FROM Usuarios WHERE {1} ORDER BY {2} ", Campos, Condicion, Orden));
        }
    }
}
