using System;
using Tarea;
var tareasPendientes = new List<Tareas>( );
var tareasRealizas = new List<Tareas>();

int Cantidad;
string? Scantidad;
Console.WriteLine("Ingrese la cantidad de Tareas:");
Scantidad = Console.ReadLine();
bool resultCant = int.TryParse(Scantidad, out Cantidad);

crearTareas(tareasPendientes, Cantidad);
Console.WriteLine("---------");
Console.WriteLine("Lista de Tareas Pendientes");
MostrarLista(tareasPendientes);
MoverTareas(tareasPendientes, tareasRealizas);
Console.WriteLine("Lista de Tareas Realizadas");
MostrarLista(tareasRealizas);

void crearTareas(List<Tareas> ListaTarea, int Cantidad)
{
int tiempo = 0;
string? Stiempo = "";
string? Descripcion;
for (int i = 0; i < Cantidad; i++)
{
    Console.WriteLine("Ingrese la duracion de su Tarea, (10 a 100)min:");
    Stiempo = Console.ReadLine();
    bool resultTime = int.TryParse(Stiempo, out tiempo);
    while (tiempo < 10 || tiempo > 100)
    {
        Console.WriteLine(@"!! El tiempo tiene que estar definido entre 10 a 100 min");
        Console.WriteLine("Ingrese una nueva duracion entre 10 a 100 min");
        Stiempo = Console.ReadLine();
        bool resultTime2 = int.TryParse(Stiempo, out tiempo);
    }

    Console.WriteLine($"Ingrese la descripcion de su Tarea{i+1}:");
    Descripcion = Console.ReadLine();


    var tareaAux = new Tareas(i+1,Descripcion,tiempo);
    ListaTarea.Add(tareaAux);
}
}

void MostrarLista(List<Tareas> ListasTarea){
    foreach (var lista in ListasTarea)
    {
    Console.WriteLine($"Tarea: {lista.Tareaid}");
    Console.WriteLine($"Descripcion:{lista.Descripcion}");
    Console.WriteLine($"Duracion:{lista.Duracion}");
    Console.WriteLine("---------");
    }
}

void MoverTareas(List<Tareas> pendiente, List<Tareas> realizada){
int ID=0;
string? Sid;
Console.WriteLine("Escriba el ID que desea marcar como Completada");
Sid = Console.ReadLine();
bool resultID = int.TryParse(Sid, out ID);
int Cantidad = pendiente.Count();
for (int i = 0; i < Cantidad; i++)
{
    if (pendiente[i].Tareaid == ID)
    {
        var tareaMover = new Tareas(pendiente[i].Tareaid, pendiente[i].Descripcion, pendiente[i].Duracion);

    if (tareaMover != null)
    {
        realizada.Add(tareaMover);
        pendiente.Remove(tareaMover);
    } 
    }
}
}