using Profesiones.Interface;
using Profesiones.Entidad;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class CarpinteroMusical : ICarpintero, IEquatable<CarpinteroMusical>
    {
       private Carpintero carpintero = new Carpintero();
        public int Id { get { return carpintero.Id; } set { carpintero.Id = value; } }
        public string Clavar()
        {
            return "Estoy clavando y escuchando Trap";
        }

        public string Diseñar()
        {
            return "Estoy diseñando y clavando";
        }

        public bool Equals([AllowNull] CarpinteroMusical other)
        {
            return this.Id == other.Id;
        }

        public string Lacar()
        {
            return "Estoy lancando y bailando";
        }

        public string Lijar()
        {
            return "Estoy lijando y piropeando";
        }

        public string Medir()
        {
            return "Estoy midiendo mientras silbo";
        }

        public string Serruchar()
        {
            return "Estoy serruchando con música ";
        }
    }
}
