using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Clase representativa de un usuario.
    /// </summary>
    public abstract class VO_User
    {
        /// <summary>
        /// Pass del usuario.
        /// </summary>
        protected String pass;

        /// <summary>
        /// Instancia.
        /// </summary>
        /// <param name="pass"></param>
        /// <exception cref="System.ArgumentNullException">Si pass es null.</exception>
        protected VO_User(String pass)
        {
            try
            {
                Pass = pass;
            }catch(ArgumentNullException)
            {
                throw new ArgumentNullException("pass");
            }
        }

        /// <summary>
        /// Obtiene el tipo de la instancia.
        /// </summary>
        /// <returns>Tipo de la instancia.</returns>
        public Type getTipo()
        {
            return this.GetType();
        } 
        
        /// <summary>
        /// Acceso al pass del usuario.
        /// </summary>
        public String Pass
        {
            set
            {
                if (null == value)
                    throw new ArgumentNullException("value");
                pass = value;
            }
            get { return pass; }
        }
    }
}
