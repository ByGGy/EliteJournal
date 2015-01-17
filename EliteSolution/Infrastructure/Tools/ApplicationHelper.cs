using System;
using System.Linq;
using System.Reflection;

namespace Infrastructure
{
    public static class ApplicationHelper
    {
        public static string GetProductName()
        {
            Assembly assembly = Assembly.GetEntryAssembly();
            AssemblyProductAttribute attribute = (AssemblyProductAttribute)assembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false).FirstOrDefault();
            if (attribute != null)
                return attribute.Product;

            return string.Empty;
        }

        public static Version GetVersion()
        {
            Assembly assembly = Assembly.GetEntryAssembly();
            return assembly.GetName().Version;
        }
    }
}
