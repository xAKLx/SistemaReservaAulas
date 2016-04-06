using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

using System.Data;


namespace BusinessLogicLayer
{
    /// <summary>
    /// Implementacion de la interfaz BLL para el manejo de una base de 
    /// datos con SQL.
    /// </summary>
    public class BLLClassForSql : BLL
    {
        /// <summary>
        /// Base de datos
        /// </summary>
        DALSQL database;

        /// <summary>
        /// Usuario actual del sistema
        /// </summary>
        VO_User user;

        /// <summary>
        /// Instancia unica de la clase
        /// </summary>
        static BLLClassForSql uniqueInstance;

        /// <summary>
        /// Instancia la clase.
        /// </summary>
        BLLClassForSql()
        {
            user = null;
            database = DALSQLClass.getUniqueInstance();
            instanciarAdministrador();
        }

        /// <summary>
        /// Implementacion del patro singelton.
        /// </summary>
        /// <returns>Instancia unica de la clase</returns>
        public static BLLClassForSql getUniqueInstance()
        {
            if(null == uniqueInstance)
                uniqueInstance = new BLLClassForSql();
            return uniqueInstance;
        }
        

        #region MetodosSobreescritos

        /// <summary>
        /// Logea a un estudiante en el sistema, si no hay otro usuario logeado.
        /// </summary>
        /// <param name="matricula"></param>
        /// <param name="pass"></param>
        /// <returns>El usuario logeado o null si no se pudo.</returns>
        public VO_User loginEstudiante(int matricula, String pass)
        {
            if(null == user)
            {
                DataTable table = database.getUsuariosEstudiante();

                if (null != table && table.Columns.Contains("MatriculaEstudiante") &&
                    table.Columns.Contains("PassUsuario"))
                    foreach(DataRow row in table.Rows)
                    {
                        try
                        {
                            int matriculaEstudiante = int.Parse(row["MatriculaEstudiante"].ToString());

                            var userEstudiante = new VO_UserEstudiante(matriculaEstudiante, row["PassUsuario"].ToString());

                            if(userEstudiante.Matricula == matricula)
                            {
                                if (userEstudiante.Pass.CompareTo(pass) == 0)
                                {
                                    user = userEstudiante;
                                    return user;
                                }
                                else
                                    return null;
                            }
                        }
                        catch (Exception) { }
                    }
            }

            return null;
        }

        /// <summary>
        /// Logea a un profesor en el sistema, si no hay otro usuario logeado.
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="pass"></param>
        /// <returns>El usuario logeado o null si no se pudo.</returns>
        public VO_User loginProfesor(String cedula, String pass)
        {
            if (null == user)
            {
                DataTable table = database.getUsuariosProfesor();

                if (null != table && table.Columns.Contains("CedulaProfesor") &&
                    table.Columns.Contains("PassUsuario"))
                    foreach (DataRow row in table.Rows)
                    {
                        try
                        {
                            var userProfesor = new VO_UserProfesor(row["CedulaProfesor"].ToString(), row["PassUsuario"].ToString());

                            if (userProfesor.Cedula.CompareTo(cedula) == 0)
                            {
                                if (userProfesor.Pass.CompareTo(pass) == 0)
                                {
                                    user = userProfesor;
                                    return user;
                                }
                                else
                                    return null;
                            }
                        }
                        catch (Exception) { }
                    }
            }

            return null;
        }

        /// <summary>
        /// Obtiene todos los administradores de la base de datos.
        /// </summary>
        /// <returns>Lista de todos los administradores.</returns>
        public List<VO_UserAdministrador> getAdministrador()
        {
            DataTable table = database.getUsuariosAdministrador();
            var lista = new List<VO_UserAdministrador>();
            if (null != table && table.Columns.Contains("NombreUsuario") &&
                table.Columns.Contains("PassUsuario"))
                foreach (DataRow row in table.Rows)
                {
                    try
                    {
                        var userAdmin = new VO_UserAdministrador(row["NombreUsuario"].ToString(), row["PassUsuario"].ToString());

                        lista.Add(userAdmin);
                    }
                    catch (Exception) { }
                }
            return lista;
        }

        /// <summary>
        /// logea a un administraor en el sistema, si no hay otro usuario logeado.
        /// </summary>
        /// <param name="NombreUsuario"></param>
        /// <param name="pass"></param>
        /// <returns>El usuario logeado o null si no se pudo.</returns>
        public VO_User loginAdministrador(String NombreUsuario, String pass)
        {
            if (null == user)
            {
                foreach (var admin in getAdministrador())
                {
                    if(admin.NombreUsuario.CompareTo(NombreUsuario) == 0)
                    {
                        if (admin.Pass.CompareTo(pass) == 0)
                        {
                            user = admin;
                            return user;
                        }
                        else
                            return null;
                    }
                }     
            }

            return null;
        }

        /// <summary>
        /// Agrega un usuario del tipo administrador a la base de datos, solo si el usuario
        /// logeado es administrador.
        /// </summary>
        /// <param name="admin"></param>
        /// <returns>True si pudo ser agregado, de otra manera false</returns>
        /// <exception cref="System.InvalidOperationException">Si el nombreUsuario ya existe.</exception>
        /// <exception cref="System.ArgumentNullException">Si admin es null.</exception>
        public bool agregarAdministrador(VO_UserAdministrador admin)
        {
            if (null == admin)
                throw new ArgumentNullException("admin");
            if (null != user && typeof(VO_UserAdministrador) == user.GetType())
                return database.AddUsuarioAdministrador(admin.NombreUsuario, admin.Pass);
            else
                return false;
        }

        /// <summary>
        /// Edita un usuario del tipo administrador
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="pass"></param>
        /// <param name="newPass"></param>
        /// <returns>True si se pudo editar, false de otra manera</returns>
        /// <exception cref="System.InvalidOperationException">Si el nombreUsuario no existe.</exception>
        /// <exception cref="System.ArgumentNullException">Si nombreUsuario, newPass o pass son null.</exception>
        public bool editarAdministrador(String nombreUsuario, String pass, String newPass)
        {
            VO_UserAdministrador admin = null;

            if(null == nombreUsuario)
                throw new ArgumentNullException("nombreUsuario");
            if(null == pass)
                throw new ArgumentNullException("pass");
            if(null == newPass)
                throw new ArgumentNullException("newPass");

            foreach(var user in getAdministrador())
            {
                if(user.NombreUsuario.CompareTo(nombreUsuario) == 0 && user.Pass.CompareTo(pass) == 0)
                {
                    admin = user;
                    break;
                }
            }

            if (null == admin)
                throw new InvalidOperationException();
            else
                return database.editarUsuarioAdministrador(nombreUsuario, newPass);
        }

        /// <summary>
        /// elimina un usuario del tipo administrador
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="pass"></param>
        /// <returns>True si se pudo eliminar, false de otra manera</returns>
        /// <exception cref="System.InvalidOperationException">Si el nombreUsuario no existe.</exception>
        /// <exception cref="System.ArgumentNullException">Si nombreUsuario o pass son null.</exception>
        public bool eliminarAdministrador(String nombreUsuario, String pass)
        {
            VO_UserAdministrador admin = null;

            if (null == nombreUsuario)
                throw new ArgumentNullException("nombreUsuario");
            if (null == pass)
                throw new ArgumentNullException("pass");

            foreach (var user in getAdministrador())
            {
                if (user.NombreUsuario.CompareTo(nombreUsuario) == 0 && user.Pass.CompareTo(pass) == 0)
                {
                    admin = user;
                    break;
                }
            }

            if (null == admin)
                return false;
            else
                return database.eliminarUsuarioAdministrador(nombreUsuario);
        }

        /// <summary>
        /// Agrega un administrador en el caso de que no exista ninguno.
        /// NombreUsuario: Admin
        /// Pass: Admin
        /// </summary>
        public void instanciarAdministrador()
        {
            if(getAdministrador().Count == 0)
                try
                {
                    database.AddUsuarioAdministrador("Admin", "Admin");
                }
                catch (Exception) { }
                
        }

        /// <summary>
        /// Quita el usuario.
        /// </summary>
        public void logout()
        {
            user = null;
        }

        /// <summary>
        /// Metodo encargado de solicitar una listas de las aulas 
        /// en la base de datos.
        /// </summary>
        /// <returns> Lista de aulas. </returns>
        public List<VO_Aula> getAulas()
        {
            DataTable table = database.getAulas();

            var aulas = new List<VO_Aula>();

            if (null != table && table.Columns.Contains("IDAula") && table.Columns.Contains("CaracteristicasAula"))
                foreach (DataRow row in table.Rows)
                {
                    try
                    {
                        int id = int.Parse(row["IDAula"].ToString());

                        if (null == row["CaracteristicasAula"])
                            aulas.Add(new VO_Aula(id));
                        else
                            aulas.Add(new VO_Aula(id, row["CaracteristicasAula"].ToString()));
                        
                    }
                    catch (Exception) { }
                }

            return aulas;
        }

        /// <summary>
        /// Obtiene un aula de la base de datos.
        /// </summary>
        /// <param name="id">Identificador del aula.</param>
        /// <returns>El aula correspondiente al id o null en caso de que no exista.</returns>
        public VO_Aula getAula(int id)
        {
            foreach (var aula in getAulas())
                if (aula.ID == id)
                    return aula;
            return null;
        }

        /// <summary>
        /// Metodo encargado de solicitar el agregado de un aula a la base de datos.
        /// </summary>
        /// <param name="id">Identificador del aula.</param>
        /// <param name="Caracteristicas">Caracteristica del aula.</param>
        /// <returns>True si se pudo agregar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el aula ya existe en la base de datos.</exception>
        /// <exception cref="System.ArgumentNullException">Si el aula es null.</exception>
        public bool addAula(VO_Aula aula)
        {
            if (null == aula)
                throw new ArgumentNullException("aula");
            return database.AddAula(aula.ID, aula.Caracteristicas);
        }

        /// <summary>
        /// Metodo encargado de eliminar un aula
        /// </summary>
        /// <param name="id">Identificador del aula a eliminar.</param>
        ///  /// <returns>True si se pudo eliminar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el aula no existe en la base de datos.</exception>
        public bool eliminarAula(VO_Aula aula)
        {
            return database.EliminarAula(aula.ID);
        }

        /// <summary>
        /// Metodo encargado de editar un aula
        /// </summary>
        /// <param name="aula"></param>
        /// <returns>True si se pudo editar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el aula no existe en la base de datos.</exception>
        public bool editarAula(VO_Aula aula)
        {
            return database.EditarAula(aula.ID, aula.Caracteristicas);
        }

        /// <summary>
        /// Metodo encargado de obtener todos los grupos de la base de datos.
        /// </summary>
        /// <returns>Retorna una lista de todos los grupos de la base de datos.</returns>
        public List<VO_Grupo> getGrupos()
        {
            var table = database.GetGrupos();

            var grupos = new List<VO_Grupo>();

            if (null != table && table.Columns.Contains("CodigoAsignatura") && table.Columns.Contains("NumeroGrupo") && table.Columns.Contains("CedulaProfesor"))
                foreach (DataRow row in table.Rows)
                {
                    try
                    {
                        byte no = byte.Parse(row["NumeroGrupo"].ToString());

                        if (row["CedulaProfesor"].ToString().Length == 0)
                            grupos.Add(new VO_Grupo(row["CodigoAsignatura"].ToString(), no));
                        else
                            grupos.Add(new VO_Grupo(row["CodigoAsignatura"].ToString(), no, row["CedulaProfesor"].ToString()));

                    }
                    catch (Exception) { }
                }
            return grupos;
        }

        /// <summary>
        /// Obtiene un grupo en especifico
        /// </summary>
        /// <param name="codigoAsignatura"></param>
        /// <param name="numeroGrupo"></param>
        /// <returns>Grupo cargado o null si no existe.</returns>
        /// <exception cref="System.ArgumentNullException">Si codigoAsignatura es null.</exception>
        public VO_Grupo getGrupoById(String codigoAsignatura, byte numeroGrupo)
        {
            if (null == codigoAsignatura)
                throw new ArgumentNullException("codigoAsignatura");

            foreach(var grupo in getGrupos())
            {
                if (codigoAsignatura.CompareTo(grupo.CodigoAsignatura) == 0 && numeroGrupo == grupo.NumeroGrupo)
                    return grupo;
            }
            return null;
        }

        /// <summary>
        /// Obtiene los grupos de un estudiante.
        /// </summary>
        /// <param name="matricula"></param>
        /// <returns>Lista de los grupos de un estudiante.</returns>
        public List<VO_Grupo> getGrupos(int matricula)
        {
            var lista = new List<VO_Grupo>();
            var table = database.GetEstudiantesGrupos();

            if (null != table && table.Columns.Contains("CodigoAsignatura") && table.Columns.Contains("NumeroGrupo") && table.Columns.Contains("MatriculaEstudiante"))
                foreach (DataRow row in table.Rows)
                {
                    try
                    {
                        if(matricula.ToString().CompareTo(row["MatriculaEstudiante"].ToString()) == 0)
                            lista.Add( 
                                getGrupoById(
                                row["CodigoAsignatura"].ToString(), 
                                byte.Parse(row["NumeroGrupo"].ToString())
                                ));
                    }
                    catch (Exception) { }
                }

            return lista;
        }

        /// <summary>
        /// Obtiene los grupos de un profesor.
        /// </summary>
        /// <param name="cedulaProfesor"></param>
        /// <returns>Lista de Grupos del profesor</returns>
        public List<VO_Grupo> getGrupos(String cedulaProfesor)
        {
            var lista = new List<VO_Grupo>();

            foreach(var grupo in getGrupos())
            {
                if (grupo.CedulaProfesor != null && grupo.CedulaProfesor.CompareTo(cedulaProfesor) == 0)
                    lista.Add(grupo);
            }

            return lista;
        }

        /// <summary>
        /// Obtiene todos los horarios de todos los grupos.
        /// </summary>
        /// <returns>Lista de los horarios de los grupos.</returns>
        public List<VO_HorarioGrupo> getHorariosGrupos()
        {
            var horarios = new List<VO_HorarioGrupo>();
            var table = database.getHorarioGrupo();

            if(table != null && 
                table.Columns.Contains("CodigoAsignatura") &&
                table.Columns.Contains("NumeroGrupo") &&
                table.Columns.Contains("NumeroHorario") &&
                table.Columns.Contains("DiaHorario") &&
                table.Columns.Contains("InicioHorario") &&
                table.Columns.Contains("FinHorario") &&
                table.Columns.Contains("IDAula"))
                foreach(DataRow row in table.Rows)
                {
                    try
                    {
                        byte numeroGrupo = byte.Parse(row["NumeroGrupo"].ToString()),
                            numeroHorario = byte.Parse(row["NumeroHorario"].ToString()),
                            diaHorario = byte.Parse(row["DiaHorario"].ToString());
                        TimeSpan inicio = (TimeSpan) row["InicioHorario"],
                            fin = (TimeSpan) row["FinHorario"];

                        if (row["IDAula"].ToString().Length == 0)
                            horarios.Add(new VO_HorarioGrupo(row["CodigoAsignatura"].ToString(), numeroGrupo, numeroHorario, inicio, fin, diaHorario));
                        else
                        {
                            int idAula = int.Parse(row["IDAula"].ToString());
                            horarios.Add(new VO_HorarioGrupo(row["CodigoAsignatura"].ToString(), numeroGrupo, numeroHorario, inicio, fin, diaHorario, idAula));
                        }
                    }
                    catch (Exception) { }
                }
            return horarios;
        }

        /// <summary>
        /// Obtiene los horarios de un grupo
        /// </summary>
        /// <param name="grupo">Grupo el cual son los horarios</param>
        /// <returns>Lista de los horarios del grupo.</returns>
        /// <exception cref="System.ArgumentNullException">Si grupo es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si el grupo no existe en la base de datos.</exception>
        public List<VO_HorarioGrupo> getHorariosGrupos(VO_Grupo grupo)
        {
            if (null == grupo)
                throw new ArgumentNullException("grupo");

            if (null == getGrupoById(grupo.CodigoAsignatura, grupo.NumeroGrupo))
                throw new InvalidOperationException("El grupo no existe en la base de datos.");

            var lista  = new List<VO_HorarioGrupo>();
            foreach(var horario in getHorariosGrupos())
            {
                if (horario.CodigoAsignatura.CompareTo(grupo.CodigoAsignatura) == 0 &&
                    horario.NumeroGrupo == grupo.NumeroGrupo)
                    lista.Add(horario);
            }

            return lista;
        }

        /// <summary>
        /// Metodo encargado de obtener los grupos del usuario.
        /// </summary>
        /// <returns>Lista de grupos del usuario</returns>
        /// <exception cref="System.InvalidOperationException">Si no hay usuario activo.</exception>
        public List<VO_Grupo> getUserGroups()
        {
            if (null == user)
                throw new InvalidOperationException("No hay un usuario logeado en el sistema.");
            if (typeof(VO_UserEstudiante) == user.GetType())
            {
                return getGrupos(((VO_UserEstudiante)user).Matricula);
            }
            else if (typeof(VO_UserProfesor) == user.GetType())
            {
                return getGrupos(((VO_UserProfesor)user).Cedula);
            }

            return new List<VO_Grupo>();
        }

        /// <summary>
        /// Metodo encargado de obtener una lista de HorarioGrupo dado el id de un aula.
        /// </summary>
        /// <param name="aula">aula</param>
        /// <returns>Lista de los horarios con dicha aula asignada.</returns>
        /// <exception cref="System.ArgumentNullException">Si aula es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si el aula no existe en la base de datos.</exception>
        public List<VO_HorarioGrupo> getHorarioGrupoOfAula(VO_Aula aula)
        {
            if (null == aula)
                throw new ArgumentNullException("aula");

            if (null == getAula(aula.ID))
                throw new InvalidOperationException("El aula no existe en la base de datos.");

            var lista = new List<VO_HorarioGrupo>();
            foreach (var horario in getHorariosGrupos())
            {
                if (horario.IdAula == aula.ID)
                    lista.Add(horario);
            }

            return lista;
        }


        /// <summary>
        /// Metodo encargado de asignar un aula a un grupo en un horario.
        /// </summary>
        /// <param name="aula">Aula a asignar</param>
        /// <param name="horarioGrupo">Horario grupo al que sera asignada</param>
        /// <returns>True si se pudo editar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el aula no existe en la base de datos.</exception>
        /// <exception cref="System.InvalidOperationException">Si el Horario grupo no existe en la base de datos.</exception>
        /// <exception cref="System.ArgumentNullException">Si horarioGrupo o aula son null.</exception>
        public bool asignarAula(VO_Aula aula, VO_HorarioGrupo horarioGrupo)
        {
            if (null == aula)
                throw new ArgumentNullException("aula");
            if (null == horarioGrupo)
                throw new ArgumentNullException("horarioGrupo");

            try
            {
                return database.asignarAula(aula.ID, horarioGrupo.CodigoAsignatura, horarioGrupo.NumeroGrupo, horarioGrupo.HorarioNo);
            }
            catch (ArgumentNullException) { }
            return false;
        }

        /// <summary>
        /// Metodo encargado de obtener aulas disponibles en un horario.
        /// </summary>
        /// <param name="horaI">Hora de Inicio.</param>
        /// <param name="horaF">Hora de fin.</param>
        /// <param name="dia">Dia.(1-6)</param>
        /// <returns>Lista de aulas.</returns>
        public List<VO_Aula> getAulaDisponible(TimeSpan horaI, TimeSpan horaF, byte dia)
        {
            var lista = new List<VO_Aula>();

            foreach(var aula in getAulas())
            {
                bool disponible = true;
                foreach(var horarioGrupo in getHorarioGrupoOfAula(aula))
                {
                    if (dia == horarioGrupo.Dia && (
                        (horaI.CompareTo(horarioGrupo.HoraInicio) <= 0 && horaF.CompareTo(horarioGrupo.HoraInicio) > 0) ||
                        (horaI.CompareTo(horarioGrupo.HoraFin) < 0 && horaF.CompareTo(horarioGrupo.HoraFin) >= 0)))
                    {
                        disponible = false;
                    }
                }

                if(disponible)
                {
                    lista.Add(aula);
                }
            }

            return lista;
        }

        /// <summary>
        /// Quita el aula de un grupo.
        /// </summary>
        /// <param name="horarioGrupo"></param>
        /// <returns>True si se pudo quitar el aula, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el Horario grupo no existe en la base de datos.</exception>
        /// <exception cref="System.ArgumentNullException">Si horarioGrupo es null.</exception>
        public bool RevocarAula(VO_HorarioGrupo horarioGrupo)
        {
            if (null == horarioGrupo)
                throw new ArgumentException("horarioGrupo");
            return database.revocarAula(horarioGrupo.CodigoAsignatura, horarioGrupo.NumeroGrupo, horarioGrupo.HorarioNo);
        }
        #endregion

        #region Property
        /// <summary>
        /// Retorna el usuario.
        /// </summary>
        public VO_User User
        {
            get { return user; }
        }
        #endregion


    }

}
