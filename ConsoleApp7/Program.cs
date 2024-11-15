using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;

//List<string> names = new(){ "Миша", "Вася", "Петя", "Гриша"};

//var result = names.Where(x => x.First() == x.First()).ToList();
//Console.WriteLine($"{result.First()}\n");


//var result1 = names.Skip(1).Take(2).ToList();
//for (int i = 0; i < result1.Count; i++)
//{
//    Console.WriteLine(result1[i]);
//}
//Console.WriteLine();


//var selectedNames = names.Where(p => p.ToUpper().StartsWith("М")).OrderBy(p => p);
//foreach (string x in selectedNames)
//{
//    Console.WriteLine(x);
//}
//Console.WriteLine();

//var selectedNames1 = names.Where(p => p.ToUpper().Contains("Я")).ToList();
//foreach (var y in selectedNames1)
//{
//    Console.WriteLine(y);
//}
//Console.WriteLine();

//var selectedNames2 = names.Where(p => p.ToUpper().Contains("Я")).Count();
//Console.WriteLine(selectedNames2);
//Console.WriteLine();

//var selectedNames3 = names.Any(p => p.ToUpper().Contains("ПЕТЯ"));
//Console.WriteLine(selectedNames3);
//Console.WriteLine();

//var selectedNames4 = names.OrderBy(p => p);
//foreach (var h in selectedNames4)
//{
//    Console.WriteLine(h);
//}
//Console.WriteLine();





//List<Person> persons = new()
//{
//    new() { FirstName = "Виталий", LastName = "Цаль", Age = 33 },
//    new() { FirstName = "Куджо", LastName = "Джотаро", Age = 40 },
//    new() { FirstName = "Юрий", LastName = "Хованский", Age = 34 },
//    new() { FirstName = "Михаил", LastName = "Петров", Age = 15 },
//    new() { FirstName = "Виталий", LastName = "Гачиев", Age = 40 },
//    new() { FirstName = "Юрий", LastName = "Гагарин", Age = 34 },
//};

//var selectedNames5 = persons.Where(p => p.FirstName == "Юрий").Count();
//Console.WriteLine(selectedNames5);
//Console.WriteLine();

//var selectedNames6 = persons.Select(p => $"{p.FirstName} {p.LastName}").ToList();
//foreach (var huy in selectedNames6)
//{
//    Console.WriteLine(huy);
//}
//Console.WriteLine();

//var selectedNames7 = persons.Select(p => p.Age).Average();
//Console.WriteLine(selectedNames7);
//Console.WriteLine();

//var selectedNames8 = persons.GroupBy(p => p.Age);
//foreach (var huy in selectedNames8)
//{
//    Console.WriteLine(huy.Key);
//    foreach(var x  in huy)
//    {
//        Console.WriteLine(x.FirstName + ' ' + x.LastName);
//    }
//}
//public class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public int Age { get; set; }
//}

List<Person> persons = new()
{
    new() { FirstName = "Виталий", LastName = "Цаль", Age = 33 },
    new() { FirstName = "Куджо", LastName = "Джотаро", Age = 40 },
    new() { FirstName = "Юрий", LastName = "Хованский", Age = 34 },
    new() { FirstName = "Михаил", LastName = "Петров", Age = 15 },
    new() { FirstName = "Виталий", LastName = "Гачиев", Age = 40 },
    new() { FirstName = "Юрий", LastName = "Гагарин", Age = 34 },
};

List<Person> FilterPersons(
    List<Person> all,
    string? firstName = null,
    string? lastName = null,
    int? age = null)
{
// Фильтрация по firstName, lastName, age, каждое поле проверяется на null
// и фильтр по нему добавляется, только если оно не null.
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

