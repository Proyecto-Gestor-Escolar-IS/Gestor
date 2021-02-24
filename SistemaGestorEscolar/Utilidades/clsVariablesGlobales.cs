using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorEscolar
{   
    /// <summary>
    /// 
    /// 
    /// 
    ///                     OOOOOOOOJJJJJOOOOOOO
    ///                
    ///         AL SER UNA CLASE ESTATICA NO ES NECESARIO INSTANCIARLA, VASTA CON PONER
    ///         
    ///                 clsVariablesGlobales.nombreVariable
    ///                 
    ///         PARA OBTENER O ASIGNAR UN VALOR
    /// 
    /// 
    /// 
    /// </summary>
    static class clsVariablesGlobales
    {
        //Variable global numeroIdentidad, toma valor en el login y es una variable global que identifica quien entro al programa
        private static string numIdentidad;
        //Metodo para acceder a la variable
        public static string NumIdentidad { get => numIdentidad; set => numIdentidad = value; }




    }
}
