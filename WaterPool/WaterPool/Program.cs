namespace WaterPool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class Program
    {
        public static void Main()
        {
            Console.Write("Insert class name: ");
            var className = Console.ReadLine();
            var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            var type = Type.GetType($"{assemblyName}.{className}");

            var values = new List<object>();
            var constructor = type.GetConstructors().First();

            var constructorParameters = constructor.GetParameters();

            foreach (var parameter in constructorParameters)
            {
                while (true)
                {
                    try
                    {
                        var parameterName = parameter.Name;
                        Console.Write($"Insert value for {parameterName}: ");
                        var value = Console.ReadLine();

                        var typeOfParameter = parameter.ParameterType;
                        var converted = Convert.ChangeType(value, typeOfParameter);

                        values.Add(converted);
                        break;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Invalid type");
                    }
                }
            }
            var instance = (Pool)Activator.CreateInstance(type, values.ToArray());

            Console.WriteLine(instance.H);
        }
    }
}