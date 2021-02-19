namespace ReflectionLection
{
    using System;
    using System.Reflection;
    [Author("Gosho")]
    public class SpyTools
    {
        private Type type;
        public Type Type
        {
            get => this.type;
            set
            {
                this.type = value;
            }
        }
        public Type GetType(string name)
        {
            Type type = Assembly.GetCallingAssembly().GetType(name);
            this.type = type;
            return type;
        }
        [Author("Lyubo")]
        public FieldInfo[] GetAllFields()
        {
            FieldInfo[] fields = this.type.GetFields(BindingFlags.Instance | BindingFlags.Public);
            return fields;
        }
        public MethodInfo[] GetAllMethods()
        {
            MethodInfo[] methods = this.type.GetMethods();
            return methods;
        }
    }
}