

using System;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleEmpresa
{
    public class Empresa
    {
        readonly Random random = new Random();

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Propietario { get; set; }



        public Vehiculo ConstruirVehiculo(string modelo)
        {
            return new Vehiculo()
            {
                Id = random.Next(),
                Marca = Nombre,
                Modelo = modelo

            };
        }

        public IEmpleado Empleado{ get; set; }
        
        public string contratarEmpleado(IEmpleado empleado)
        {
            Empleado = empleado;
            return "Contrate un nuevo empleado";
        }
        public string Construir()
        {
           
            var resultadoMaterial = Empleado.Materiales("Acero inoxidalbe");
            var resultadoModelo = Empleado.ModeloVehiculo("Tipo de aveo family");
            var resultadoMarca = Empleado.MarcaVehiculo("Tipo de kia");
            return $"{resultadoMaterial}\n {resultadoModelo}\n {resultadoMarca}\n";
        }

       
    }

    
}
