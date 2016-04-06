using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Clase representativa de un aula.
    /// </summary>
    public class VO_Aula
    {
        #region Atributos
        /// <summary>
        /// Identificador del aula.
        /// </summary>
        private int id;

        /// <summary>
        /// Caracteristicas del aula.
        /// </summary>
        private String caracteristicas;
        #endregion

        #region Constructores
        /// <summary>
        /// Instancia la clase aula, necesita el Identificador de esta.
        /// </summary>
        /// <param name="id">Identificador del aula.</param>
        /// <param name="caracteristicas">Caracteristicas del aula.</param>
        public VO_Aula(int id, String caracteristicas = null): this()
        {
            ID = id;
            Caracteristicas = caracteristicas;
        }

        /// <summary>
        /// Instancia la clase aula.
        /// </summary>
        protected VO_Aula()
        {

        }
        #endregion

        #region Property
        /// <summary>
        /// Acceso al identificador del aula.
        /// </summary>
        public int ID
        {
            set{ id = value;}
            get { return id; }
        }

        /// <summary>
        /// Acceso a las caracteristicas del aula.
        /// </summary>
        public String Caracteristicas
        {
            set{ caracteristicas = value;}
            get { return caracteristicas; }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Obtiene un aula de la capa logica.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="logic"></param>
        /// <returns>Aula correspondiente al id.</returns>
        /// <exception cref="System.ArgumentNullException">Cuando logic es null.</exception>
        public static VO_Aula getAula(int id, BLL logic)
        {
            if (null == logic)
                throw new ArgumentNullException();
            return logic.getAula(id);
        }

        /// <summary>
        /// Obtiene los Horarios a los cuales el aula esta asignada.
        /// </summary>
        /// <param name="logic"></param>
        /// <returns>Horarios obtenidos.</returns>
        /// <exception cref="System.ArgumentNullException">Cuando logic es null.</exception>
        public List<VO_HorarioGrupo> getHorariosGrupos(BLL logic)
        {
            if (null == logic)
                throw new ArgumentNullException();
            return logic.getHorarioGrupoOfAula(this);
        }
        #endregion
    }
}
