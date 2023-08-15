using Shared;
using DataAccessLayer;
using DataAccessLayer.DAL;
using DataAccessLayer.IDALs;
using System.Globalization;

IDAL_Persona idal = new DAL_Persona();
do
{
    try
    { 
        Persona per = new Persona();

        Console.WriteLine("Nombre:");
        per.nombre = Console.ReadLine();

        Console.WriteLine("Apellido:");
        per.apellido = Console.ReadLine();

        Console.WriteLine("Documento:");
        per.Documento = Console.ReadLine();

        Console.Write("Fecha de nacimiento (dd/mm/yyyy): ");
        string fechaNacString = Console.ReadLine();
        per.fechaNac = DateTime.ParseExact(fechaNacString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        idal.Insert(per);

    }catch(Exception ex)
    {
        Console.WriteLine("Error:" + ex.Message);
    }

    Console.WriteLine("Desea seguir? S|N");

} while(Console.ReadLine()!= "N");

var personasOrdenadas = idal.GetPersonasOrdenadasPorFechaNacimiento();

foreach (var persona in personasOrdenadas)
{
    Console.WriteLine($"Nombre: {persona.nombre}, Fecha de Nacimiento: {persona.fechaNac}");
}


