void AgregarTurno()
{
    if (contador < 100)
    {
        Paciente p = new Paciente();
        p.id = contador + 1;
        Console.Write("Nombre: ");
        p.nombre = Console.ReadLine();
        Console.Write("Cédula: ");
        p.cedula = Console.ReadLine();
        Console.Write("Especialidad: ");
        p.especialidad = Console.ReadLine();
        Console.Write("Fecha del Turno (dd/mm/yyyy): ");
        p.fechaTurno = Console.ReadLine();
        agenda[contador] = p;
        contador++;
        Console.WriteLine("✅ Turno registrado con éxito.\n");
    }
    else
    {
        Console.WriteLine("❌ Agenda llena.\n");
    }
}
