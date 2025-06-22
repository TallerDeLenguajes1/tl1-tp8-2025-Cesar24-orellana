namespace CalculadoraHistorial
{
    public class Calculadora
    {
        private double resultado;
        private List<Operacion> historial;
        public Calculadora()
        {
            resultado = 0;
            historial = new List<Operacion>();
        }
        public double Resultado => resultado;
        public bool EjecutarOperacion(double valor, Operacion.TipoOperacion tipo)
        {
            if (tipo == Operacion.TipoOperacion.Division && valor == 0) return false;
            Operacion operacion = new Operacion(resultado, valor, tipo);
            resultado = operacion.Resultado;
            return true;
        }

        public void Limpiar()
        {
            Operacion operacion = new Operacion(resultado, 0, Operacion.TipoOperacion.limpiar);
            resultado = 0;
            historial.Add(operacion);
        }
        public void MostrarHistorial()
        {
            Console.WriteLine("Historial de Operaciones:");
            foreach (var operacion in historial)
            {
                Console.WriteLine(operacion);
            }
        }
    }
}