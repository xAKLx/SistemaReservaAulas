using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Clase representativa de un usuario del tipo administrador.
    /// </summary>
    public class VO_UserAdministrador: VO_User
    {
        #region Atributos
        /// <summary>
        /// Nombre de usuario
        /// </summary>
        String nombreUsuario;
        #endregion

        #region Constructores
        /// <summary>
        /// Instancia la clase
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="pass"></param>
        /// <exception cref="System.ArgumentNullException">Si nombreUsuario o pass son null.</exception>
        public VO_UserAdministrador(String nombreUsuario, String pass):base(pass)
        {
            NombreUsuario = nombreUsuario;
        }
        #endregion

        #region Property
        /// <summary>
        /// Acceso a la cedula.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Si value a asignar es null.</exception>
        public String NombreUsuario
        {
            set
            {
                if (null == value)
                    throw new ArgumentNullException("value");
                nombreUsuario = value;
            }
            get { return nombreUsuario; }
        }
        #endregion
    }
}
