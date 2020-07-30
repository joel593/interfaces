using Profesiones.Interface;
using Profesiones.Entidad;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class CarpinteroModerno : Carpintero, ICarpintero, IEquatable<CarpinteroModerno>
    {
        public string Diseñar()
        {
            return "Estoy diseñando con AutoCad";
        }
        public string Medir()
        {
            return "Estoy midiendo con láser";
        }
        public string Serruchar()
        {
            return "Estoy serruchando con máquina";
        }
        public string Clavar()
        {
            return "Estoy clavando con pistola de aire comprimido";
        }
        public string Lijar()
        {
            return "Estoy lijando con lijadora con absorción";
        }
        public string Lacar()
        {
            return "Estoy lacando de secado instantáneo";
        }

        public bool Equals([AllowNull] CarpinteroModerno other)
        {
            return this.Id == other.Id;
        }
    }
}
