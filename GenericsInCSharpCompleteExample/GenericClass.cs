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
