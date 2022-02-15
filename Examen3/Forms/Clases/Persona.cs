#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms.Clases
{
    class Persona
    {
        #region Variables
        string Nombre;
        string Sexo;
        int Edad;
        #endregion

        #region Get & Set
        public string Nombres
        {
            get => Nombre;
            set => Nombre = value;
        }
        public string Sexos
        {
            get => Sexo;
            set => Sexo = value;
        }
        public int Edades
        {
            get => Edad;
            set => Edad = value;
        }
        #endregion

        #region Public Persona
        public Persona()
        {
            Nombres = string.Empty;
            Sexos = string.Empty;
            Edades = 0;
        }
        #endregion
    }
}