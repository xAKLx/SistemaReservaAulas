using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogicLayer
{
    /// <summary>
    /// Clase representativa de la relacion HorarioGrupo
    /// </summary>
    public class VO_HorarioGrupo
    {
        #region Atributos
        /// <summary>
        /// Asignatura del grupo.
        /// </summary>
        String codigoAsignatura;
        
        /// <summary>
        /// Hora de inicio.
        /// </summary>
        TimeSpan horaInicio;

        /// <summary>
        /// Hora de fin.
        /// </summary>
        TimeSpan horaFin;

        #endregion

        #region Constructores
        /// <summary>
        /// Instancia la clase, necesita idGrupo, horario_no, horarioInicio, horaFin y dia,
        /// estos parametros no pueden ser null.
        /// </summary>
        /// <param name="idGrupo">id del Grupo al cual pertenece.</param>
        /// <param name="horario_no">Numero del horario respecto al grupo.</param>
        /// <param name="horaInicio">Hora en la que inicia, no puede ser null.</param>
        /// <param name="horaFin">Hora en la que finaliza, no puede ser null</param>
        /// <param name="dia">Dia del evento.</param>
        /// <param name="idAula">id del Aula asignada al grupo.</param>
        /// <exception cref="System.ArgumentNullException">Cuando idGrupo, horaInicio o horaFin son null,
        /// el nombre del parametro que lo disparo aparecera en el paramName.</exception>
        public VO_HorarioGrupo(String codigoAsignatura, byte numeroGrupo, byte horario_no, TimeSpan horaInicio, TimeSpan horaFin, byte dia, int? idAula = null): this()
        {
            try
            {
                CodigoAsignatura = codigoAsignatura;
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("codigoAsignatura");
            }

            try
            {
                HoraInicio = horaInicio;
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("horaInicio");
            }

            try
            {
                HoraFin = horaFin;
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("horaFin");
            }

            NumeroGrupo = numeroGrupo;
            HorarioNo = horario_no;
            Dia = dia;
            IdAula = idAula;

        }

        /// <summary>
        /// Instancia la clase.
        /// </summary>
        protected VO_HorarioGrupo() { }
        #endregion

        #region Property
        /// <summary>
        /// Acceso al codigo de la asignatura.
        /// </summary>
        /// <exception cref="ArgumentNullException">Si el valor a asignar es null.</exception>
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
        /// Acceso al numero del grupo.
        /// </summary>
        public byte NumeroGrupo
        {
            get;
            set;
        }

        /// <summary>
        /// Acceso al numero del horario.
        /// </summary>
        public byte HorarioNo
        {
            set;
            get;
        }

        /// <summary>
        /// Acceso al id del aula asignada.
        /// </summary>
        public int? IdAula
        {
            set;
            get;
        }

        /// <summary>
        /// Retorna y asigna la hora de inicio.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Cuando el valor es null.</exception>
        public TimeSpan HoraInicio
        {
            set
            {
                if (null == value)
                    throw new ArgumentNullException("value");
                horaInicio = value;
            }
            get { return horaInicio; }
        }

        /// <summary>
        /// Retorna y asigna la hora de fin.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Cuando el valor es null.</exception>
        public TimeSpan HoraFin
        {
            set
            {
                if (null == value)
                    throw new ArgumentNullException("value");
                horaFin = value;
            }
            get { return horaFin; }
        }

        /// <summary>
        /// Retorna y asigna el dia.
        /// </summary>
        public byte Dia
        {
            set;
            get;
        } 
        #endregion

        #region Metodos

        /// <summary>
        /// Prueba si la instancia es valida.
        /// </summary>
        /// <returns>True si es valida, de otra forma false.</returns>
        public bool esValido()
        {
            if (HoraInicio.CompareTo(HoraFin) < 0)
                return true;
            return false;
        }

        /// <summary>
        /// Obtiene un horario de un grupo.
        /// </summary>
        /// <param name="codigoAsignatura"></param>
        /// <param name="numeroGrupo"></param>
        /// <param name="horario_no"></param>
        /// <param name="logic"></param>
        /// <returns>Horario obtenido</returns>
        /// <exception cref="System.ArgumentNullEsception">Si codigoAsignatura o logic son null.</exception>
        public static VO_HorarioGrupo getHorarioGrupo(String codigoAsignatura, byte numeroGrupo, byte horario_no, BLL logic)
        {
            if (null == codigoAsignatura)
                throw new ArgumentNullException();
            if (null == logic)
                throw new ArgumentNullException();

            var grupo = VO_Grupo.getGrupo(codigoAsignatura, numeroGrupo, logic);

            if (null != grupo)
                foreach (var horario in grupo.getHorarios(logic))
                    if (horario.HorarioNo == horario_no)
                        return horario;
                return null;
        }

        /// <summary>
        /// Obtiene el aula asignada.
        /// </summary>
        /// <param name="logic"></param>
        /// <returns>Aula asignada.</returns>
        public VO_Aula getAula(BLL logic)
        {
            if (null == logic)
                throw new ArgumentNullException("logic");
            if (IdAula == null)
                return null;
            else
                return logic.getAula(IdAula.Value);
        }
        #endregion

    }
}
