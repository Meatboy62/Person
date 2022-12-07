// See https://aka.ms/new-console-template for more information
using Person.Console.Entities;
using Person.Console.Repositories;

Console.WriteLine("Demo para la lista de las personas");

List<PersonEntity> list;
PersonReporitory repo = new PersonReporitory();

list = repo.GetAll();

foreach (var item in list)
{
    Console.WriteLine(item.Id + " " + item.Name);
}


