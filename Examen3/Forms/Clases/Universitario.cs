#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms.Clases
{
    class Universitario : Estudiante
    {
        #region Variables
        string Universidad;
        string Carrera;
        string Materia;
        int Nota;
        #endregion

        #region Get & Set
        public string Universidades
        {
            get => Universidad;
            set => Universidad = value;
        }
        public string Carreras
        {
            get => Carrera; set => Carrera = value;
        }
        public string Materias
        {
            get => Materia;
            set => Materia = value;
        }
        public int Notas
        {
            get => Nota;
            set => Nota = value;
        }
        #endregion

        #region Public Universitario
        public Universitario()
        {
            Universidades = string.Empty;
            Carreras = string.Empty;
            Materias = string.Empty;
            Notas = 0;
        }
        #endregion
    }
}