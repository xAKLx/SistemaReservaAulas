using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Clase representativa de un grupo.
    /// </summary>
    public class VO_Grupo
    {
        #region Atributos
        /// <summary>
        /// Identificador del grupo.
        /// </summary>
        String codigoAsignatura;
        #endregion

        #region Constructores
        /// <summary>
        /// Instancia la clase grupo, necesita un id.
        /// </summary>
        /// <param name="codigoAsignatura"></param>
        /// <param name="numeroGrupo"></param>
        /// <param name="cedulaProfesor"></param>
        public VO_Grupo(String codigoAsignatura, byte numeroGrupo, String cedulaProfesor = null): this()
        {
            CodigoAsignatura = codigoAsignatura;
            NumeroGrupo = numeroGrupo;
            CedulaProfesor = cedulaProfesor;
        }

        /// <summary>
        /// Constructor que instancia la clase.
        /// </summary>
        private VO_Grupo()
        {

        }
        #endregion

        #region Property
        /// <summary>
        /// Asigna y devuelve el id del grupo.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Cuando value a asignar es null.</exception>
        public String CodigoAsignatura
        {
            set 
            {
                if (null == value)
                    throw new ArgumentNullException("value");
                codigoAsignatura = value; 
            }
            get { return codigoAsignatura; }
        }

        /// <summary>
        /// Acceso a el numero del grupo.
        /// </summary>
        public byte NumeroGrupo
        {
            set;
            get;
        }

        /// <summary>
        /// Acceso a la cedula del profesor.
        /// </summary>
        public String CedulaProfesor
        {
            set;
            get;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Retorna los horarios del grupo.
        /// </summary>
        /// <param name="logic">BLL</param>
        /// <returns>Lista de los horarios del grupo. Si no tiene horarios, retorna una lista vacia.</returns>
        /// <exception cref="System.ArgumentNullException">Si logic es null.</exception>
        public List<VO_HorarioGrupo> getHorarios(BLL logic)
        {
            if (null == logic)
                throw new ArgumentNullException("logic");
            return logic.getHorariosGrupos(this);
        }

        /// <summary>
        /// Obtiene un grupo de la base de datos.
        /// </summary>
        /// <param name="codigoAsignatura"></param>
        /// <param name="numeroGrupo"></param>
        /// <param name="logic">BLL</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">Si logic o codigoAsignatura son null.</exception>
        public static VO_Grupo getGrupo(String codigoAsignatura, byte numeroGrupo, BLL logic)
        {
            if (null == logic)
                throw new ArgumentNullException("logic");
            if (null == codigoAsignatura)
                throw new ArgumentNullException("codigoAsignatura");
            return logic.getGrupoById(codigoAsignatura, numeroGrupo);
        }
        #endregion
    }
}
