namespace GenericsInCSharpCompleteExample
{
    public class GenericWithConstructor<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T();
        }
    }
}
