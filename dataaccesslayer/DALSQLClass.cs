using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer
{
    /// <summary>
    /// Implementacion de la interfaz DALSQL
    /// </summary>
    public class DALSQLClass: DALSQL
    {
        /// <summary>
        /// Instancia unica de la clase.
        /// </summary>
        private static DALSQLClass uniqueInstance = null;

        private dbModel7 model;

        /// <summary>
        /// Instancia la clase.
        /// </summary>
        DALSQLClass()
        {
            model = new dbModel7();
        }

        /// <summary>
        /// Implementacion del patron singelton.
        /// </summary>
        /// <returns>Instancia unica de la clase.</returns>
        public static DALSQLClass getUniqueInstance()
        {
            if (uniqueInstance == null)
                    uniqueInstance = new DALSQLClass();
            return uniqueInstance;
        }


        /// <summary>
        /// Obtiene todos los usuarios del tipo estudiante.
        /// </summary>
        /// <returns>DataTable con todos usuarios de los estudiantes.
        /// Sus columnas son:
        /// *MatriculaEstudiante
        /// *PassUsuario</returns>
        public DataTable getUsuariosEstudiante()
        {
            var table = new DataTable("UsuarioEstudiante");
            table.Columns.Add("MatriculaEstudiante", typeof(int));
            table.Columns.Add("PassUsuario", typeof(String));


            foreach(var usuario in model.UsuarioEstudiantes)
            {
                table.Rows.Add(usuario.MatriculaEstudiante, usuario.PassUsuario);
            }

            return table;
        }

        /// <summary>
        /// Obtiene todos los usuarios del tipo profesor
        /// </summary>
        /// <returns>DataTable con todos usuarios de los profesores.
        /// Sus columnas son:
        /// *CedulaProfesor
        /// *PassUsuario</returns>
        public DataTable getUsuariosProfesor()
        {
            var table = new DataTable("UsuarioProfesor");
            table.Columns.Add("CedulaProfesor", typeof(String));
            table.Columns.Add("PassUsuario", typeof(String));

            foreach (var usuario in model.UsuarioProfesors)
            {
                table.Rows.Add(usuario.CedulaProfesor, usuario.PassUsuario);
            }

            return table;
        }

        /// <summary>
        /// Obtiene todos los usuarios del tipo Administrador
        /// </summary>
        /// <returns>DataTable con todos usuarios de los profesores.
        /// Sus columnas son:
        /// *NombreUsuario
        /// *PassUsuario</returns>
        public DataTable getUsuariosAdministrador()
        {
            var table = new DataTable("UsuarioAdministrador");
            table.Columns.Add("NombreUsuario", typeof(String));
            table.Columns.Add("PassUsuario", typeof(String));

            foreach (var usuario in model.UsuarioAdministradors)
            {
                table.Rows.Add(usuario.NombreUsuario, usuario.PassUsuario);
            }

            return table;
        }

        /// <summary>
        /// Agrega un usuario del tipo administrador
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="pass"></param>
        /// <returns>True si se pudo agregar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el nombreUsuario ya existe.</exception>
        /// <exception cref="System.ArgumentNullException">Si nombreUsuario o passUsuario son null.</exception>
        public bool AddUsuarioAdministrador(String nombreUsuario, String passUsuario)
        {
            if (null == nombreUsuario)
                throw new ArgumentNullException("nombreUsuario");
            if (null == passUsuario)
                throw new ArgumentNullException("passUsuario");

            try
            {
                if (model.UsuarioAdministradors.Find(nombreUsuario) != null)
                    throw new InvalidOperationException("El nombreUsuario ya existe.");
            }
            catch (Exception) { return false; }

            try
            {
                model.UsuarioAdministradors.Add(new UsuarioAdministrador() { NombreUsuario = nombreUsuario, PassUsuario = passUsuario });
                model.SaveChanges();
                if (null != model.Aulas.Find(nombreUsuario))
                    return true;
            }
            catch (Exception) { }
            return false;
            
        }

        /// <summary>
        /// Edita un usuario del tipo administrador
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="pass"></param>
        /// <returns>True si se pudo editar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el nombreUsuario no existe.</exception>
        /// <exception cref="System.ArgumentNullException">Si nombreUsuario o passUsuario son null.</exception>
        public bool editarUsuarioAdministrador(String nombreUsuario, String passUsuario)
        {
            if (null == nombreUsuario)
                throw new ArgumentNullException("nombreUsuario");
            if (null == passUsuario)
                throw new ArgumentNullException("passUsuario");

            UsuarioAdministrador admin = null;
            try
            {
                admin = model.UsuarioAdministradors.Find(nombreUsuario);
            }
            catch (Exception) { return false; }

            if (model.UsuarioAdministradors.Find(nombreUsuario) == null)
                throw new InvalidOperationException("El administrador no existe.");
            else
                try
                {
                    admin.PassUsuario = passUsuario;
                    model.SaveChanges();
                    return true;
                }
                catch (Exception) { return false; }
        }

        /// <summary>
        /// Elimina un usuario del tipo administrador
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="pass"></param>
        /// <returns>True si se pudo eliminar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el nombreUsuario no existe.</exception>
        /// <exception cref="System.ArgumentNullException">Si nombreUsuario es null.</exception>
        public bool eliminarUsuarioAdministrador(String nombreUsuario)
        {
            if (null == nombreUsuario)
                throw new ArgumentNullException("nombreUsuario");

            UsuarioAdministrador admin = null;
            try
            {
                admin = model.UsuarioAdministradors.Find(nombreUsuario);
            }
            catch (Exception) { return false; }

            if (model.UsuarioAdministradors.Find(nombreUsuario) == null)
                throw new InvalidOperationException("El administrador no existe.");
            else
                try
                {
                    model.UsuarioAdministradors.Remove(admin);
                    model.SaveChanges();
                    return true;
                }
                catch (Exception) { return false; }
        }

        /// <summary>
        /// Metodo encargado de obtener todas las aulas
        /// </summary>
        /// <returns>Lista de todas las aulas.
        /// Sus columnas son:
        /// *IDAula
        /// *CaracteristicasAula</returns>
        public DataTable getAulas()
        {
            DataTable table = new DataTable("Aula");
            table.Columns.Add("IDAula", typeof(int));
            table.Columns.Add("CaracteristicasAula", typeof(String));

            foreach(var aula in model.Aulas)
            {
                table.Rows.Add(aula.IDAula, aula.CaracteristicasAula);
            }

            return table;
        }

        /// <summary>
        /// Agrega un aula a la base de datos.
        /// </summary>
        /// <param name="id">Identificador del aula.</param>
        /// <param name="Caracteristicas">Caracteristica del aula</param>
        /// <returns>True si se pudo agregar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el aula ya existe.</exception>
        public bool AddAula(int id, String Caracteristicas)
        {
            Aula aula = null;
            try
            {
                aula = model.Aulas.Find(id);
            }
            catch (Exception) { return false; }

            if (aula == null)
            {
                try
                {
                    model.Aulas.Add(new Aula() { IDAula = id, CaracteristicasAula = Caracteristicas });
                    model.SaveChanges();
                    if (null != model.Aulas.Find(id))
                        return true;
                }
                catch (Exception) { }
            }
            else
            {
                throw new InvalidOperationException("El id del aula ya se encuentra en la base de datos");
            }

            return false;
        }

        /// <summary>
        /// Elimina un aula.
        /// </summary>
        /// <param name="id">Identificador del aula a eliminar</param>
        /// <returns>True si se pudo eliminar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el aula no existe en la base de datos.</exception>
        public bool EliminarAula(int id)
        {
            Aula aula = null;

            try
            {
                aula = model.Aulas.Find(id);
            }
            catch (Exception) { return false; }
            

            if (null != aula)
            {
                try
                {
                    model.Aulas.Remove(aula);
                    model.SaveChanges();
                    return true;
                }
                catch (Exception) { return false; }
            }
            else
                throw new InvalidOperationException("El aula a eliminar no existe.");

            
        }

        /// <summary>
        /// Se encarga de editar un aula.
        /// </summary>
        /// <param name="id">Identificador del aula.</param>
        /// <param name="Caracteristicas">Nueva caracteristica.</param>
        /// <returns>True si se pudo editar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el aula no existe en la base de datos.</exception>
        public bool EditarAula(int id, String Caracteristicas)
        {
            Aula aula = null;

            try
            {
                aula = model.Aulas.Find(id);
            }
            catch (Exception) { return false; }

            if(aula ==null)
            {
                throw new InvalidOperationException("El aula a editar no existe.");
            }
            else
            {
                try
                {
                    aula.CaracteristicasAula = Caracteristicas;
                    model.SaveChanges();
                    return true;
                }
                catch (Exception) { return false; }
            }
        }

        /// <summary>
        /// Metodo encargado de obtener los grupos
        /// </summary>
        /// <returns>DataTable de grupos.
        /// Sus columnas son:
        /// *CodigoAsignatura
        /// *NumeroGrupo
        /// *CedulaProfesor</returns>
        public DataTable GetGrupos()
        {
            var table = new DataTable("Grupo");
            table.Columns.Add("CodigoAsignatura", typeof(String));
            table.Columns.Add("NumeroGrupo", typeof(byte));
            table.Columns.Add("CedulaProfesor", typeof(String));

            foreach(var grupo in model.Grupoes)
            {
                table.Rows.Add(grupo.CodigoAsignatura, grupo.NumeroGrupo, grupo.CedulaProfesor);
            }

            return table;
        }

        /// <summary>
        /// Metodo encargado de obtener una lista de los HorarioGrupo
        /// </summary>
        /// <returns>DataTable de HorarioGrupo
        /// Sus columnas son:
        /// *CodigoAsignatura
        /// *NumeroGrupo
        /// *NumeroHorario
        /// *DiaHorario
        /// *InicioHorario
        /// *FinHorario
        /// *IDAula</returns>
        public DataTable getHorarioGrupo()
        {
            var table = new DataTable("HorarioGrupo");
            table.Columns.Add("CodigoAsignatura", typeof(String));
            table.Columns.Add("NumeroGrupo", typeof(byte));
            table.Columns.Add("NumeroHorario", typeof(byte));
            table.Columns.Add("DiaHorario", typeof(byte));
            table.Columns.Add("InicioHorario", typeof(TimeSpan));
            table.Columns.Add("FinHorario", typeof(TimeSpan));
            table.Columns.Add("IDAula", typeof(int));

            foreach (var horarioGrupo in model.HorarioGrupoes)
            {
                table.Rows.Add(horarioGrupo.CodigoAsignatura, horarioGrupo.NumeroGrupo, horarioGrupo.NumeroHorario, horarioGrupo.DiaHorario, horarioGrupo.InicioHorario, horarioGrupo.FinHorario, horarioGrupo.IDAula);
            }

            return table;
        }

        /// <summary>
        /// Asigna un aula a un grupo en un horario.
        /// </summary>
        /// <param name="idAula">Id del aula a asignar.</param>
        /// <param name="CodigoAsignatura">Codigo del la asignatura.</param>
        /// <param name="NumeroGrupo">Numero del grupo.</param>
        /// <param name="Horario_no">Horario del grupo.</param>
        /// <returns>true si se pudo asignar, false de otra manera.</returns>
        /// <exception cref="System.InvalidOperationException">Si el idAula no existe en la base de datos.</exception>
        /// <exception cref="System.InvalidOperationException">Si el Horario del grupo no existe en la base de datos.</exception>
        /// <exception cref="System.ArgumentNullException">Si CodigoAsignatura es null.</exception>
        public bool asignarAula(int idAula, String codigoAsignatura, byte numeroGrupo, int horario_no)
        {
            if (null == codigoAsignatura)
                throw new ArgumentNullException("codigoAsignatura");

            Aula aula = null;

            try
            {
                aula = model.Aulas.Find(idAula);
            }
            catch (Exception) { return false; }

            if (null == aula)
                throw new InvalidOperationException("El aula " + idAula.ToString() + " no existe en la base de datos");

            HorarioGrupo horario = null;

            try
            {
                horario = model.HorarioGrupoes.Find(codigoAsignatura, numeroGrupo, horario_no);
            }
            catch (Exception) { return false; }

            if (null == horario)
                throw new InvalidOperationException("El horario " + horario_no.ToString() + " del grupo " + codigoAsignatura.ToString() + "-" + numeroGrupo.ToString() + " no existe en la base de datos");

            try
            {
                horario.IDAula = aula.IDAula;
                model.SaveChanges();
                return true;
            }
            catch (Exception) { return false; }
        }

        /// <summary>
        /// Metodo encargado de obtener las relaciones EstudianteGrupo
        /// </summary>
        /// <returns>DataTable de grupos.
        /// Sus columnas son:
        /// *MatriculaEstudiante
        /// *CodigoAsignatura
        /// *NumeroGrupo</returns>
        public DataTable GetEstudiantesGrupos()
        {
            var table = new DataTable("EstudianteGrupo");
            table.Columns.Add("MatriculaEstudiante", typeof(int));
            table.Columns.Add("CodigoAsignatura", typeof(String));
            table.Columns.Add("NumeroGrupo", typeof(byte));
            

            foreach (var estudiante in model.Estudiantes)
                foreach(var grupo in estudiante.Grupoes)
                {
                    table.Rows.Add(estudiante.MatriculaEstudiante, grupo.CodigoAsignatura, grupo.NumeroGrupo);
                }
            return table;
        }

        /// <summary>
        /// Quita el aula de un grupo.
        /// </summary>
        /// <param name="codigoAsignatura"></param>
        /// <param name="numeroGrupo"></param>
        /// <param name="horario_no"></param>
        /// <returns>True si se pudo quitar el aula, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el Horario del grupo no existe en la base de datos.</exception>
        /// <exception cref="System.ArgumentNullException">Si CodigoAsignatura es null.</exception>
        public bool revocarAula(String codigoAsignatura, byte numeroGrupo, int horario_no)
        {
            if (null == codigoAsignatura)
                throw new ArgumentNullException("codigoAsignatura");

            HorarioGrupo horario = null;

            try
            {
                horario = model.HorarioGrupoes.Find(codigoAsignatura, numeroGrupo, horario_no);
            }
            catch (Exception) { return false; }

            if (null == horario)
                throw new InvalidOperationException("El horario " + horario_no.ToString() + " del grupo " + codigoAsignatura.ToString() + "-" + numeroGrupo.ToString() + " no existe en la base de datos");

            try
            {
                horario.IDAula = null;
                model.SaveChanges();
                return true;
            }
            catch (Exception) { return false; }
        }
    }
}
