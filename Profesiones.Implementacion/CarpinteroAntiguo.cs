using System.Collections.Generic;
using Profesiones.Interface;

namespace Profesiones.Implementacion
{
    public class CarpinteroAntiguo : ICarpintero
    {
        //Utilisamos sustantivos para definir atributos
        private List<string> materialesParaClavar;  //Ejemplo: clavo, tachuela
        private string nombre; //Ejemplo: Juan

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<string> MaterialesParaClavar { get { return materialesParaClavar; } set { materialesParaClavar = value; } }

        //Utilisamos verbos para los nombres de los metodos
        public string Clavar()
        {
            return $"Mi nombre es {nombre} y estoy clavando {materialesParaClavar[0]}";

        }
        public string Diseñar()
        {
            return "Estoy diseñando";
        }
        public string Medir()
        {
            return "Estoy midiendo";
        }
        public string Serruchar()
        {
            return "Estoy serruchando";
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
