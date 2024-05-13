using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInCSharpCompleteExample
{
    public class GenericClass<T> where T : class
    {
        public T Instance { get; set; }

        public GenericClass(T instance)
        {
            Instance = instance;
        }
    }
}
