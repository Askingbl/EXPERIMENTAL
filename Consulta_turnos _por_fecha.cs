void ConsultarPorFecha()
{
    Console.Write("Ingrese la fecha a consultar (dd/mm/yyyy): ");
    string fecha = Console.ReadLine();
    bool encontrado = false;
    for (int i = 0; i < contador; i++)
    {
        if (agenda[i].fechaTurno == fecha)
        {
            Console.WriteLine($"Paciente: {agenda[i].nombre}, Cédula: {agenda[i].cedula}, Especialidad: {agenda[i].especialidad}");
            encontrado = true;
        }
    }
    if (!encontrado)
        Console.WriteLine("🔍 No hay turnos en esa fecha.\n");
}
