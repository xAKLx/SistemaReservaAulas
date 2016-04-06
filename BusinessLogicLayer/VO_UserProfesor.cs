using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Clase representativa de un usuario de tipo profesor
    /// </summary>
    class VO_UserProfesor : VO_User
    {
        #region Atributos
        /// <summary>
        /// Cedula del profesor (id).
        /// </summary>
        String cedula;
        #endregion

        #region Constructores
        /// <summary>
        /// Instancia la clase
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="pass"></param>
        /// <exception cref="System.ArgumentNullException">Si cedula o pass son null.</exception>
        public VO_UserProfesor(String cedula, String pass):base(pass)
        {
            Cedula = cedula;
        }
        #endregion

        #region Property
        /// <summary>
        /// Acceso a la cedula.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Si value a asignar es null.</exception>
        public String Cedula
        {
            set
            {
                if (null == value)
                    throw new ArgumentNullException("value");
                cedula = value;
            }
            get { return cedula; }
        }
        #endregion
    }
}
