namespace GenericsInCSharpCompleteExample
{
    public class GenericStruct<T> where T : struct
    {
        public T Value { get; set; }

        public GenericStruct(T value)
        {
            Value = value;
        }
    }
}
