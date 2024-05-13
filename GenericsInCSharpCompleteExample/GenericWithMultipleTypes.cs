using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInCSharpCompleteExample
{
    public class MyClass1
    {
        public string Name { get; set; }

        public MyClass1()
        {
            Name = "Default";
        }
    }

    public class GenericWithMultipleTypes<T> where T : class, new()
    {
        private T _value;

        public GenericWithMultipleTypes()
        {
            _value = new T();
        }

        public void SetValue(T newValue)
        {
            _value = newValue;
        }

        public T GetValue()
        {
            return _value;
        }
    }
}
