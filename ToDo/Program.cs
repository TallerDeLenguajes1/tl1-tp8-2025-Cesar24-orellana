using System;
using Tarea;
var tareasPendientes = new List<Tareas>();
var tareasRealizas = new List<Tareas>();

int salir = 1;
int id = 1;
Console.WriteLine("- - Bienvenido/a - -");
do
{
    menu();
    if (int.TryParse(Console.ReadLine(), out int opcion))
    {
        switch (opcion)
        {
            case 1:
                crearTareas(tareasPendientes, id);
                break;
            case 2:
                MoverTareas(tareasPendientes, tareasRealizas);
                break;
            case 3:
                Console.WriteLine("Lista de Tareas Pendientes");
                MostrarLista(tareasPendientes);
                break;
            case 4:
                Console.WriteLine("Lista de Tareas Realizadas");
                MostrarLista(tareasRealizas);
                break;
            default:
                salir = 0;
                break;
        }
    }

} while (salir != 0);


void crearTareas(List<Tareas> ListaTarea, int id)
{
    Random random = new Random();
    int Cantidad = random.Next(3, 6);
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

        Console.WriteLine($"Ingrese la descripcion de su Tarea {i + 1}:");
        Descripcion = Console.ReadLine();


        var tareaAux = new Tareas(id, Descripcion, tiempo);
        ListaTarea.Add(tareaAux);
        id++;
    }
}

void MostrarLista(List<Tareas> ListasTarea)
{
    foreach (var lista in ListasTarea)
    {
        Console.WriteLine($"Tarea: {lista.Tareaid}");
        Console.WriteLine($"Descripcion:{lista.Descripcion}");
        Console.WriteLine($"Duracion:{lista.Duracion}");
        Console.WriteLine("---------");
    }
}

void MoverTareas(List<Tareas> pendiente, List<Tareas> realizada)
{
    int ID = 0;
    //string? Sid;
    Console.WriteLine("Escriba el ID que desea marcar como Completada");
    /* Sid = Console.ReadLine();
    bool resultID = int.TryParse(Sid, out ID); */
    if (int.TryParse(Console.ReadLine(), out ID))
    {
        var tareaMover = pendiente.Find(t => t.Tareaid == ID);
        if (tareaMover != null)
        {
            realizada.Add(tareaMover);
            pendiente.Remove(tareaMover);
            Console.WriteLine("Tarea agregada a realizadas");
            Console.WriteLine($"Tarea: {tareaMover.Tareaid}");
            Console.WriteLine($"Descripcion:{tareaMover.Descripcion}");
            Console.WriteLine($"Duracion:{tareaMover.Duracion}");
            Console.WriteLine("---------");
        }
        else
        {
            Console.WriteLine("No se encontro su tarea");
        }
    }
    /* int Cantidad = pendiente.Count();
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
    } */
}

void menu()
{
    Console.WriteLine("--> Menu Principal <--");
    Console.WriteLine("1- Cargar Nuevas tareas");
    Console.WriteLine("2- Marcar como Realizada");
    Console.WriteLine("3- Mostrar Lista de tareas Pendientes");
    Console.WriteLine("4- Mostrar Lista de tareas Realizadas");
    Console.WriteLine("0- Salir");
}