using Profesiones.Interface;

namespace Profesiones.Negocio
{
    public class Constructora 
    {
        public ICarpintero Carpintero { get; set; }
        public string ContratarCarpintero(ICarpintero carpintero)
        {
            Carpintero = carpintero;
            return "Contraté un carpintero";
        }
        public string ConstruirMesa()
        {
            return Carpintero.Diseñar() + "mesa"+ Carpintero.Medir() + "mesa" + Carpintero.Clavar() + "mesa";
        }
        public string ContratarCarpintero()
        {
            return "Contraté un carpintero";
        }     
    }
}
