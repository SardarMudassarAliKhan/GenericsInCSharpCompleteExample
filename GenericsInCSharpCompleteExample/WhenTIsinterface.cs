namespace GenericsInCSharpCompleteExample
{
    public interface IShape { }

    public class Circle : IShape { }

    public class GenericWithInterface<T> where T : IShape
    {
        // Class definition
    }
}
