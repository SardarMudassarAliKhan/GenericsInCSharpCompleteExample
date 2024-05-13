namespace GenericsInCSharpCompleteExample
{
    public class Animal { }

    public class Dog : Animal { }

    public class GenericWithBaseClass<T> where T : Animal
    {

    }
}
