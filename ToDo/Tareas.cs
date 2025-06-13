namespace Tarea
{
    public class Tareas
    {
        private int tareaid;
        private string? descripcion;
        private int duracion;


        public int Tareaid { get => tareaid; set => tareaid = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public int Verificacion{get => duracion; set => duracion = value;}

        public void FuncionVerificacion(string Stiempo, int tiempo){
            Console.WriteLine("Ingrese la duracion de su Tarea, (10 a 100)min:");
            Stiempo = Console.ReadLine();
            bool resultTime = int.TryParse(Stiempo, out tiempo);
            while (tiempo < 10 || tiempo > 100)
            {
                Console.WriteLine(@"!! El tiempo tiene que estar definido entre 10 a 100 min");
                Console.WriteLine("Ingrese una nueva duracion entre 10 a 100 min");
                Stiempo = Console.ReadLine();
                bool resultTime = int.TryParse(Stiempo, out tiempo);
            }
            duracion = tiempo;
        }

        public Tareas(int tareaid, string? descripcion, int duracion)
        {
            this.Tareaid = tareaid;
            this.Duracion = duracion;
            this.Descripcion = descripcion;
        }


    }
}