using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Grupo de clases encargadas de controlar la capa logica del sistema.
namespace BusinessLogicLayer
{
    /// <summary>
    /// Clase base representativa de una BLL.
    /// </summary>
    public interface BLL
    {
        #region Metodos

        /// <summary>
        /// Logea a un estudiante en el sistema, si no hay otro usuario logeado.
        /// </summary>
        /// <param name="matricula"></param>
        /// <param name="pass"></param>
        /// <returns>El usuario logeado o null si no se pudo.</returns>
        VO_User loginEstudiante(int matricula, String pass);

        /// <summary>
        /// Logea a un profesor en el sistema, si no hay otro usuario logeado.
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="pass"></param>
        /// <returns>El usuario logeado o null si no se pudo.</returns>
        VO_User loginProfesor(String cedula, String pass);

        /// <summary>
        /// Obtiene todos los administradores de la base de datos.
        /// </summary>
        /// <returns>Lista de todos los administradores.</returns>
        List<VO_UserAdministrador> getAdministrador();

        /// <summary>
        /// logea a un administraor en el sistema, si no hay otro usuario logeado.
        /// </summary>
        /// <param name="NombreUsuario"></param>
        /// <param name="pass"></param>
        /// <returns>El usuario logeado o null si no se pudo.</returns>
        VO_User loginAdministrador(String nombreUsuario, String pass);

        /// <summary>
        /// Agrega un usuario del tipo administrador a la base de datos, solo si el usuario
        /// logeado es administrador.
        /// </summary>
        /// <param name="admin"></param>
        /// <returns>True si pudo ser agregado, de otra manera false</returns>
        /// <exception cref="System.InvalidOperationException">Si el nombreUsuario ya existe.</exception>
        /// <exception cref="System.ArgumentNullException">Si admin es null.</exception>
        bool agregarAdministrador(VO_UserAdministrador admin);

        /// <summary>
        /// Edita un usuario del tipo administrador
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="pass"></param>
        /// <param name="newPass"></param>
        /// <returns>True si se pudo editar, false de otra manera</returns>
        /// <exception cref="System.InvalidOperationException">Si el nombreUsuario no existe.</exception>
        /// <exception cref="System.ArgumentNullException">Si nombreUsuario, newPass o pass son null.</exception>
        bool editarAdministrador(String nombreUsuario, String pass, String newPass);

        /// <summary>
        /// elimina un usuario del tipo administrador
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="pass"></param>
        /// <returns>True si se pudo eliminar, false de otra manera</returns>
        /// <exception cref="System.InvalidOperationException">Si el nombreUsuario no existe.</exception>
        /// <exception cref="System.ArgumentNullException">Si nombreUsuario o pass son null.</exception>
        bool eliminarAdministrador(String nombreUsuario, String pass);

        /// <summary>
        /// Agrega un administrador en el caso de que no exista ninguno.
        /// NombreUsuario: Admin
        /// Pass: Admin
        /// </summary>
        void instanciarAdministrador();

        /// <summary>
        /// Quita el usuario.
        /// </summary>
        void logout();

        /// <summary>
        /// Metodo encargado de solicitar una listas de las aulas 
        /// en la base de datos.
        /// </summary>
        /// <returns> Lista de aulas. </returns>
        List<VO_Aula> getAulas();

        /// <summary>
        /// Obtiene un aula de la base de datos.
        /// </summary>
        /// <param name="id">Identificador del aula.</param>
        /// <returns>El aula correspondiente al id o null en caso de que no exista.</returns>
        VO_Aula getAula(int id);

        /// <summary>
        /// Metodo encargado de solicitar el agregado de un aula a la base de datos.
        /// </summary>
        /// <param name="id">Identificador del aula.</param>
        /// <param name="Caracteristicas">Caracteristica del aula.</param>
        /// <returns>True si se pudo agregar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el aula ya existe en la base de datos.</exception>
        /// <exception cref="System.ArgumentNullException">Si el aula es null.</exception>
        bool addAula(VO_Aula aula);

        /// <summary>
        /// Metodo encargado de eliminar un aula
        /// </summary>
        /// <param name="id">Identificador del aula a eliminar.</param>
        ///  /// <returns>True si se pudo eliminar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el aula no existe en la base de datos.</exception>
        bool eliminarAula(VO_Aula aula);

        /// <summary>
        /// Metodo encargado de editar un aula
        /// </summary>
        /// <param name="aula"></param>
        /// <returns>True si se pudo editar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el aula no existe en la base de datos.</exception>
        bool editarAula(VO_Aula aula);

        /// <summary>
        /// Metodo encargado de obtener todos los grupos de la base de datos.
        /// </summary>
        /// <returns>Retorna una lista de todos los grupos de la base de datos.</returns>
        List<VO_Grupo> getGrupos();

        /// <summary>
        /// Obtiene un grupo en especifico
        /// </summary>
        /// <param name="codigoAsignatura"></param>
        /// <param name="numeroGrupo"></param>
        /// <returns>Grupo cargado o null si no existe.</returns>
        VO_Grupo getGrupoById(String codigoAsignatura, byte numeroGrupo);

        /// <summary>
        /// Obtiene los grupos de un estudiante.
        /// </summary>
        /// <param name="matricula"></param>
        /// <returns>Lista de los grupos de un estudiante.</returns>
        List<VO_Grupo> getGrupos(int matricula);

        /// <summary>
        /// Obtiene los grupos de un profesor.
        /// </summary>
        /// <param name="cedulaProfesor"></param>
        /// <returns>Lista de Grupos del profesor</returns>
        List<VO_Grupo> getGrupos(String cedulaProfesor);

        /// <summary>
        /// Obtiene todos los horarios de todos los grupos.
        /// </summary>
        /// <returns>Lista de los horarios de los grupos.</returns>
        List<VO_HorarioGrupo> getHorariosGrupos();

        /// <summary>
        /// Obtiene los horarios de un grupo
        /// </summary>
        /// <param name="grupo">Grupo el cual son los horarios</param>
        /// <returns>Lista de los horarios del grupo.</returns>
        /// <exception cref="System.ArgumentNullException">Si grupo es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si el grupo no existe en la base de datos.</exception>
        List<VO_HorarioGrupo> getHorariosGrupos(VO_Grupo grupo);

        /// <summary>
        /// Metodo encargado de obtener una lista de HorarioGrupo dado el id de un aula.
        /// </summary>
        /// <param name="aula">aula</param>
        /// <returns>Lista de los horarios con dicha aula asignada.</returns>
        /// <exception cref="System.ArgumentNullException">Si aula es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si el aula no existe en la base de datos.</exception>
        List<VO_HorarioGrupo> getHorarioGrupoOfAula(VO_Aula aula);

        /// <summary>
        /// Metodo encargado de obtener los grupos del usuario.
        /// </summary>
        /// <returns>Lista de grupos del usuario</returns>
        /// <exception cref="System.InvalidOperationException">Si no hay usuario activo.</exception>
        List<VO_Grupo> getUserGroups();

        /// <summary>
        /// Metodo encargado de asignar un aula a un grupo en un horario.
        /// </summary>
        /// <param name="aula">Aula a asignar</param>
        /// <param name="horarioGrupo">Horario grupo al que sera asignada</param>
        /// <returns>True si se pudo editar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el aula no existe en la base de datos.</exception>
        /// <exception cref="System.InvalidOperationException">Si el Horario grupo no existe en la base de datos.</exception>
        /// <exception cref="System.ArgumentNullException">Si horarioGrupo o aula son null.</exception>
        bool asignarAula(VO_Aula aula, VO_HorarioGrupo horarioGrupo);

        /// <summary>
        /// Metodo encargado de obtener aulas disponibles en un horario.
        /// </summary>
        /// <param name="horaI">Hora de Inicio.</param>
        /// <param name="horaF">Hora de fin.</param>
        /// <param name="dia">Dia.(1-6)</param>
        /// <returns>Lista de aulas.</returns>
        List<VO_Aula> getAulaDisponible(TimeSpan horaI, TimeSpan horaF, byte dia);

        /// <summary>
        /// Quita el aula de un grupo.
        /// </summary>
        /// <param name="horarioGrupo"></param>
        /// <returns>True si se pudo quitar el aula, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el Horario grupo no existe en la base de datos.</exception>
        /// <exception cref="System.ArgumentNullException">Si horarioGrupo es null.</exception>
        bool RevocarAula(VO_HorarioGrupo horarioGrupo);
#endregion

        #region Property
        /// <summary>
        /// Retorna el usuario logeado.
        /// </summary>
        VO_User User
        {
            get;
        }
        #endregion
    }
}
