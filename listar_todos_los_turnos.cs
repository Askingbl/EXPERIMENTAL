void ListarTurnos()
{
    for (int i = 0; i < contador; i++)
    {
        Console.WriteLine($"{agenda[i].id}. {agenda[i].nombre} | {agenda[i].cedula} | {agenda[i].especialidad} | {agenda[i].fechaTurno}");
    }
}
