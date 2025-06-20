namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double resultado;
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
        }
    }
}