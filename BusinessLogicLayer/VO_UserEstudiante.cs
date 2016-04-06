using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Clase representativa de un usuario de tipo estudiante
    /// </summary>
    public class VO_UserEstudiante : VO_User
    {
        #region Constructores
        /// <summary>
        /// Instancia la clase
        /// </summary>
        /// <param name="matricula"></param>
        /// <param name="pass"></param>
        /// <exception cref="System.ArgumentNullException">Si pass es null.</exception>
        public VO_UserEstudiante(int matricula, String pass): base(pass)
        {
            Matricula = matricula;
        }
        #endregion

        #region Property
        /// <summary>
        /// Acceso a la matricula.
        /// </summary>
        public int Matricula
        {
            set;
            get;
        }
        #endregion
    }
}
