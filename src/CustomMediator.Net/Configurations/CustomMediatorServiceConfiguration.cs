using System.Reflection;

namespace CustomMediator.Net.Configurations
{
    public class CustomMediatorServiceConfiguration
    {
        internal List<Assembly> AssembliesToRegister { get; } = new();

        public CustomMediatorServiceConfiguration RegisterServicesFromAssemblyContaining<T>() => RegisterServicesFromAssemblyContaining(typeof(T));

        public CustomMediatorServiceConfiguration RegisterServicesFromAssemblyContaining(Type type) => RegisterServicesFromAssembly(type.Assembly);

        public CustomMediatorServiceConfiguration RegisterServicesFromAssembly(Assembly assembly)
        {
            AssembliesToRegister.Add(assembly);

            return this;
        }

        public CustomMediatorServiceConfiguration RegisterServicesFromAsseblies(params Assembly[] assemblies)
        {
            AssembliesToRegister.AddRange(assemblies);

            return this;
        }
    }
}
