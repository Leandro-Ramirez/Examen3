#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms.Clases
{
    class Ingeniero : Universitario
    {
        #region Variables
        string Proyecto;
        int HoraTotal;
        int HoraCompleta;
        #endregion

        #region Get & set
        public string Proyectos
        {
            get => Proyecto;
            set => Proyecto = value;
        }
        public int HoraTotales
        {
            get => HoraTotal;
            set => HoraTotal = value;
        }
        public int HoraCompletadas
        {
            get => HoraCompleta;
            set => HoraCompleta = value;
        }
        #endregion

        #region Public Ingeniero
        public Ingeniero()
        {
            Proyectos = string.Empty;
            HoraTotales = 0;
            HoraCompletadas = 0;
        }
        #endregion

        #region Public Herencia
        public Ingeniero(string Nombre, string Sexo, int Edad,
            string Carnet, string Nivel, string Universidad,
            string Carrera, string Materia, int Nota,
            string Proyecto, int HoraTotal, int HoraCompleta)
        {
            this.Nombres = Nombre;
            this.Sexos = Sexo;
            this.Edades = Edad;
            this.Carnets = Carnet;
            this.Niveles = Nivel;
            this.Universidades = Universidad;
            this.Carreras = Carrera;
            this.Materias = Materia;
            this.Notas = Nota;
            this.Proyectos = Proyecto;
            this.HoraTotales = HoraTotal;
            this.HoraCompletadas = HoraCompleta;
        }
        #endregion
    }
}