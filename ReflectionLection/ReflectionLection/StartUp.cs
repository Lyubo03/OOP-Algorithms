namespace ReflectionLection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    public class StartUp
    {
        public static void Main()
        { 
        }
    }
}
//Type[] types = Assembly.GetExecutingAssembly().GetTypes();

//var typesAndAttributes = types.
//    Select(t => new
//    {
//        Type = t,
//        Attributes = t.GetCustomAttributes<AuthorAttribute>()
//    })
//    .Where(a => a.Attributes.Any());
//Dictionary<string, List<string>> res = new Dictionary<string, List<string>>();
//foreach (var typeAndAttribute in typesAndAttributes)
//{
//    string type = typeAndAttribute.Type.Name;
//    var authors = typeAndAttribute.Attributes.Select(a => a.Name);
//    foreach (var author in authors)
//    {
//        if (!res.ContainsKey(author))
//        {
//            res[author] = new List<string>();
//        }
//        res[author].Add(type);
//    }
//}
//foreach (var kvp in res)
//{
//    string classes = string.Join(", ", kvp.Value);
//    Console.WriteLine($"{kvp.Key} - {classes}");//var method = typeof(Car).GetMethod("addPlateNumber");

//Car car = (Car)Activator.CreateInstance(typeof(Car), "Tesla");
//Console.WriteLine(method.Invoke(car,new object[0]));
//            Console.WriteLine(car.Model);
//            string baseNamespace = "ReflectionLection";

//Console.Write("Vehicle type: ");
//            string typeVehicle = Console.ReadLine();

//Console.Write("Vehicle model: ");
//            string vehicleModel = Console.ReadLine();

//Type type = Type.GetType($"{baseNamespace}.{typeVehicle}");
//Vehicle vehicle = (Vehicle)Activator.CreateInstance(type, vehicleModel);

//Console.WriteLine(vehicle.Model); }