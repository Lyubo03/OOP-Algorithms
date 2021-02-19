namespace ReflectionLection
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Text;
    [Author ("Lyubo")]
    public class Spy
    {

        public string StealFieldInfo(params string[] args)
        {
            var type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == args[0]);

            object instance = Activator.CreateInstance(type, new object[] { });
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            string result = $"Class under investigation: {type.Name}" + Environment.NewLine;

            foreach (var field in fields.Where(f => args.Contains(f.Name)))
            {

                result += $"{field.Name} = {field.GetValue(instance)} {Environment.NewLine}";
            }
            return result.TrimEnd(' ');
        }

        public string AnalyzeAcessModifiers(string className)
        {
            var type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == className);


            object instance = Activator.CreateInstance(type, new object[] { });
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            StringBuilder sb = new StringBuilder();

            foreach (var field in fields)
            {
                if (field.IsPublic)
                {
                    sb.AppendLine($"{field.Name} must be private!");
                }
            }

            foreach (var method in methods)
            {
                if (method.Name.StartsWith("get_"))
                {
                    if (!method.IsPublic)
                    {
                        sb.AppendLine($"{method.Name} have to be public!");
                    }
                }
                else if (method.Name.StartsWith("set_"))
                {
                    if (method.IsPublic)
                    {
                        sb.AppendLine($"{method.Name} have to be private!");
                    }
                }
            }
            return sb.ToString().TrimEnd(' ');
        }
        public string RevealPrivateMethods(string className)
        {
            StringBuilder sb = new StringBuilder();

            Type type = Assembly.GetCallingAssembly().GetTypes().First(x => x.Name == className);
            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            sb.AppendLine($"All Private Methods of Class: {type.Name}");
            sb.AppendLine($"Base Class: {type.BaseType}");
            object obj = new object();
            foreach (var method in methods)
            {
                sb.AppendLine(method.Name);
            }
            return sb.ToString().TrimEnd();
        }
        public string CollectGettersAndSetters(string className)
        {
            StringBuilder sb = new StringBuilder();

            Type type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == className);

            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (var property in methods.Where(x => x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{property.Name} will return {property.ReturnType}");
            }
            foreach (var prop in methods.Where(x => x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{prop.Name} will set field of {prop.ReturnType}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}