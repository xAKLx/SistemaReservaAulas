using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 

/// Grupo de clases encargadas de acceder a la base de datos
namespace DataAccessLayer
{
    /// <summary>
    /// Interfaz de una Data access layer para SQL.
    /// </summary>
    public interface DALSQL
    {
        /// <summary>
        /// Obtiene todos los usuarios del tipo estudiante.
        /// </summary>
        /// <returns>DataTable con todos usuarios de los estudiantes.
        /// Sus columnas son:
        /// *MatriculaEstudiante
        /// *PassUsuario</returns>
        DataTable getUsuariosEstudiante();

        /// <summary>
        /// Obtiene todos los usuarios del tipo profesor
        /// </summary>
        /// <returns>DataTable con todos usuarios de los profesores.
        /// Sus columnas son:
        /// *CedulaProfesor
        /// *PassUsuario</returns>
        DataTable getUsuariosProfesor();

        /// <summary>
        /// Obtiene todos los usuarios del tipo Administrador
        /// </summary>
        /// <returns>DataTable con todos usuarios de los profesores.
        /// Sus columnas son:
        /// *NombreUsuario
        /// *PassUsuario</returns>
        DataTable getUsuariosAdministrador();

        /// <summary>
        /// Agrega un usuario del tipo administrador
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="pass"></param>
        /// <returns>True si se pudo agregar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el nombreUsuario ya existe.</exception>
        /// <exception cref="System.ArgumentNullException">Si nombreUsuario o passUsuario son null.</exception>
        bool AddUsuarioAdministrador(String nombreUsuario, String passUsuario);

        /// <summary>
        /// Edita un usuario del tipo administrador
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="pass"></param>
        /// <returns>True si se pudo editar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el nombreUsuario no existe.</exception>
        /// <exception cref="System.ArgumentNullException">Si nombreUsuario o passUsuario son null.</exception>
        bool editarUsuarioAdministrador(String nombreUsuario, String passUsuario);

        /// <summary>
        /// Elimina un usuario del tipo administrador
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="pass"></param>
        /// <returns>True si se pudo eliminar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el nombreUsuario no existe.</exception>
        /// <exception cref="System.ArgumentNullException">Si nombreUsuario es null.</exception>
        bool eliminarUsuarioAdministrador(String nombreUsuario);


        /// <summary>
        /// Metodo encargado de obtener todas las aulas
        /// </summary>
        /// <returns>Lista de todas las aulas.
        /// Sus columnas son:
        /// *IDAula
        /// *CaracteristicasAula</returns>
        DataTable getAulas();

        /// <summary>
        /// Agrega un aula a la base de datos.
        /// </summary>
        /// <param name="id">Identificador del aula.</param>
        /// <param name="Caracteristicas">Caracteristica del aula</param>
        /// <returns>True si se pudo agregar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el aula ya existe.</exception>
        bool AddAula(int id, String Caracteristicas);

        /// <summary>
        /// Elimina un aula.
        /// </summary>
        /// <param name="id">Identificador del aula a eliminar</param>
        /// <returns>True si se pudo eliminar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el aula no existe en la base de datos.</exception>
        bool EliminarAula(int id);

        /// <summary>
        /// Se encarga de editar un aula.
        /// </summary>
        /// <param name="id">Identificador del aula.</param>
        /// <param name="Caracteristicas">Nueva caracteristica.</param>
        /// <returns>True si se pudo editar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el aula no existe en la base de datos.</exception>
        bool EditarAula(int id, String Caracteristicas);

        /// <summary>
        /// Metodo encargado de obtener los grupos
        /// </summary>
        /// <returns>DataTable de grupos.
        /// Sus columnas son:
        /// *CodigoAsignatura
        /// *NumeroGrupo
        /// *CedulaProfesor</returns>
        DataTable GetGrupos();

        /// <summary>
        /// Metodo encargado de obtener las relaciones EstudianteGrupo
        /// </summary>
        /// <returns>DataTable de grupos.
        /// Sus columnas son:
        /// *MatriculaEstudiante
        /// *CodigoAsignatura
        /// *NumeroGrupo</returns>
        DataTable GetEstudiantesGrupos();

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
        DataTable getHorarioGrupo();

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
        bool asignarAula(int idAula, String codigoAsignatura, byte numeroGrupo, int horario_no);

        /// <summary>
        /// Quita el aula de un grupo.
        /// </summary>
        /// <param name="codigoAsignatura"></param>
        /// <param name="numeroGrupo"></param>
        /// <param name="horario_no"></param>
        /// <returns>True si se pudo quitar el aula, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el Horario del grupo no existe en la base de datos.</exception>
        /// <exception cref="System.ArgumentNullException">Si CodigoAsignatura es null.</exception>
        bool revocarAula(String codigoAsignatura, byte numeroGrupo, int horario_no);
        
    }
}
