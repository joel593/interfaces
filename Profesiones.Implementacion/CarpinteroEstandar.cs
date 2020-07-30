using System.Collections.Generic;
using Profesiones.Interface;
namespace Profesiones.Implementacion
{
    public class CarpinteroEstandar : ICarpintero 
    {
        private List<string> materialesParaClavar;  //Ejemplo: clavo, tachuela
        private string nombre; //Ejemplo: Juan

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<string> MaterialesParaClavar { get { return materialesParaClavar; } set { materialesParaClavar = value; } }
        public string Diseñar()
        {
            return "Estoy diseñando";
        }
        public string Medir()
        {
            return "Estoy midiendo con metro";
        }
        public string Serruchar()
        {
            return "Estoy serruchando";
        }
        public string Clavar()
        {
            return "Estoy clavando";
        }
        public string Lijar()
        {
            return "Estoy lijando";
        }
        public string Lacar()
        {
            return "Estoy lacando";
        }
    }
}
