using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEmpresa
{
   public class Empleado:IEmpleado
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Materiales(string tipoMaterial)
        {
            return $"Estoy fabricando un vehículo con este material: {tipoMaterial}";

        }
        public string ModeloVehiculo(string tipoModelo)
        {
            return $"Estoy fabricando un vehículo de este modelo: {tipoModelo}";

        }
        public string MarcaVehiculo(string tipoMarca)
        {
            return $"Estoy fabricando un vehículo de esta marca: {tipoMarca}";

        }
    }
}
