namespace GenericsInCSharpCompleteExample
{
    public class GenericUnmanaged<T> where T : unmanaged
    {
        private T _value;

        public GenericUnmanaged(T value)
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
