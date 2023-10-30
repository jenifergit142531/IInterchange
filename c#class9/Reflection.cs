using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace c_class9
{
    class Person
    {
        private static string name;
        private static int age;
        public Person()
        {
            Console.WriteLine("Empty constructor");
        }
        public string Name
        {
            get;
            set;
        } = "Amy";
        public int Age
        {
            get;
            set;
        } = 25;

        public static void display()
        {
            Console.WriteLine($"{name}{age}");
        }
    }
    internal class Reflection
    {
        public static void typeReflect()
        {
            Type num = typeof(Int64);
            Console.WriteLine(num.FullName);
            Console.WriteLine(num.IsValueType);
            Console.WriteLine(num.IsEnum);
            Console.WriteLine(num.GUID);
            Console.WriteLine(num.BaseType);
            Console.WriteLine(num.Namespace);

        }

        public static void classReflection()
        {
            Assembly exec = Assembly.GetExecutingAssembly();
            Console.WriteLine("Assembly Name :" +exec.GetName().Name);
            Console.WriteLine("Files : " +exec.GetFiles().Length);
            Console.WriteLine("GUID :" + exec.GetName().Version);

            Type[] typeInfo = exec.GetTypes();
            foreach(var mytypes in typeInfo)
            {
                Console.WriteLine("Class : " + mytypes.FullName);

                ConstructorInfo[] ci = mytypes.GetConstructors();
                foreach(var i in ci)
                {
                    Console.WriteLine("Constructor Info :" + i.ToString());
                }

                MethodInfo[] mi = mytypes.GetMethods();
                foreach (var methods in mi)
                {
                    Console.WriteLine("Method Name :" + methods.Name);


                    ParameterInfo[] pi = methods.GetParameters();
                    foreach(var arg in pi)
                    {
                        Console.WriteLine("Parameter Name :" + arg.Name);
                        Console.WriteLine("Parameter Type :" + arg.ParameterType);
                    }
                 }
            }
        }
    }
}
