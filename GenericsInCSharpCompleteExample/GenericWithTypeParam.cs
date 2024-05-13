namespace GenericsInCSharpCompleteExample
{
    public class MyBaseClass { }

    public class MyClass : MyBaseClass { }

    public class GenericWithTypeParam<T, U> where T : U
    {
        private T _value;

        public GenericWithTypeParam(T value)
        {
            _value = value;
        }

        public T GetValue()
        {
            return _value;
        }

        public void SetValue(T newValue)
        {
            _value = newValue;
        }
    }
}
