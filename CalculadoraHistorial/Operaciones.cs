namespace CalculadoraHistorial
{
    public class Operacion
    {
        private TipoOperacion operacion;
        private double resultadoAnterior;
        private double nuevoValor;

        public Operacion(double resultadoAnterior, double nuevoValor , TipoOperacion tipoOperacion )
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacion = tipoOperacion;
        }
        public double NuevoValor => nuevoValor;
        public TipoOperacion OperacionRealizada => operacion;
        public double Resultado
        {
            get
            {
                return operacion switch
                {
                    TipoOperacion.Suma => resultadoAnterior + nuevoValor,
                    TipoOperacion.Resta => resultadoAnterior - nuevoValor,
                    TipoOperacion.Multiplicacion => resultadoAnterior * nuevoValor,
                    TipoOperacion.Division => nuevoValor == 0 ? throw new DivideByZeroException() : resultadoAnterior / nuevoValor,
                    TipoOperacion.limpiar => 0,
                    _ => throw new InvalidOperationException()
                };
            }
        }
        public override string ToString()
        {
            string simbolo = operacion switch
            {
                TipoOperacion.Suma => "+",
                TipoOperacion.Resta => "-",
                TipoOperacion.Multiplicacion => "*",
                TipoOperacion.Division => "/",
                TipoOperacion.limpiar => "LIMPIAR",
                _ => "?"
            };
            return operacion == TipoOperacion.limpiar
            ? "Se Limpio el Resultado"
            : $"{resultadoAnterior}  {simbolo} {nuevoValor} = {Resultado}";
        }
        public enum TipoOperacion
        {
            Suma,
            Resta,
            Multiplicacion,
            Division,
            limpiar
        }
        /* private double resultado;
        public double Resultado
        {
            get => resultado;
            set => resultado = value;
        }
        public double dato
        {
            get => resultado;
            set => resultado = value;
        }
        public void Sumar(double termino)
        {
            resultado += termino;
        }
        public void Resta(double termino)
        {
            resultado -= termino;
        }
        public void Multiplicacion(double termino)
        {
            resultado *= termino;
        }
        public void Dividir(double termino)
        {
            resultado /= termino;
        }
        public void limpiar()
        {
            resultado = 0;
        } */
    }
}