

namespace ConsoleEmpresa
{
   public class Motor:IAcciones1
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string TipoDeMotor { get; set; }

        public string Acelerar(string limiteAcelerar)
        {
            return $"Puedo acelerar {limiteAcelerar}";
        }
        public string Desacelerar(string tipoDesacelerar)
        {
            return $"Puedo desacelerar {tipoDesacelerar}";
        }
    }
}
