namespace Tarea
{
    public class Tareas
    {
        private int tareaid;
        private string? descripcion;
        private int duracion;
        //private Estado estado;


        public int Tareaid { get => tareaid; set => tareaid = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        //public Estado Estado { get => estado; set => estado = value;} 

        public Tareas(int tareaid, string? descripcion, int duracion)
        {
            this.Tareaid = tareaid;
            this.Duracion = duracion;
            this.Descripcion = descripcion;
            //Estado = estado;
        }

        /* public enum Estado{
            Pendiente,
            Haciendo,
            Completada
        } */

    }
}