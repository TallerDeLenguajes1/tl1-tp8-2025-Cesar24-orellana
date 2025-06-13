using Tarea;
//List<Tareas> tareasPendientes = new List<Tareas>( );
List<Tareas> tareasRealizas = new List<Tareas>();

int Cantidad;
string? Scantidad;
Console.WriteLine("Ingrese la cantidad de Tareas:");
Scantidad = Console.ReadLine();
bool resultCant = int.TryParse(Scantidad, out Cantidad);
Tareas[] tareasPendientes = new Tareas[Cantidad];
int ID = 100, tiempo = 0;
string? Stiempo = "";
string? Descripcion;
for (int i = 0; i < Cantidad; i++)
{
    Console.WriteLine("Ingrese la descripcion de su Tarea:");
    Descripcion = Console.ReadLine();
    tareasPendientes[i].FuncionVerificacion(Stiempo, tiempo);
    //tareasPendientes[i] = new Tareas(ID, Descripcion);
    ID++;
}
Console.WriteLine("Lista de Tareas Pendientes");
foreach (var lista in tareasPendientes)
{
    Console.WriteLine($"Tarea: {lista.Tareaid}");
    Console.WriteLine($"Descripcion:{lista.Descripcion}");
    Console.WriteLine($"Duracion:{lista.Duracion}");
    Console.WriteLine("---------");
}