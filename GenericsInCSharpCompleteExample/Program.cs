// See https://aka.ms/new-console-template for more information
using GenericsInCSharpCompleteExample;

var genericStruct = new GenericStruct<int>(10);
Console.WriteLine(genericStruct.Value);

var genericStruct2 = new GenericStruct<double>(2525);
Console.WriteLine(genericStruct2.Value);

var genericClass = new GenericClass<string>("Hello");
Console.WriteLine(genericClass.Instance);

var genericClass2 = new GenericClass<string>("Sardar Mudasssar Ali Khan");
Console.WriteLine(genericClass2.Instance);

var genericWithConstructor = new GenericWithConstructor<Dog>();
var instance = genericWithConstructor.CreateInstance();
Console.WriteLine(instance.GetType().Name);

var genericWithBaseClass = new GenericWithBaseClass<Dog>();

var genericWithInterface = new GenericWithInterface<Circle>();


var genericInt = new GenericUnmanaged<int>(10);
Console.WriteLine($"Value: {genericInt.GetValue()}");

genericInt.SetValue(20);
Console.WriteLine($"New Value: {genericInt.GetValue()}"); 

var genericFloat = new GenericUnmanaged<float>(3.14f);
Console.WriteLine($"Value: {genericFloat.GetValue()}"); 

genericFloat.SetValue(2.71f);
Console.WriteLine($"New Value: {genericFloat.GetValue()}");

var myClassInstance = new MyClass();
var genericWithTypeParam = new GenericWithTypeParam<MyClass, MyBaseClass>(myClassInstance);
Console.WriteLine($"Value: {genericWithTypeParam.GetValue()}");

var genericWithTypeParam2 = new GenericWithTypeParam<MyBaseClass, MyBaseClass>(new MyBaseClass());
Console.WriteLine($"Value: {genericWithTypeParam2.GetValue()}");

var genericWithMultipleTypes = new GenericWithMultipleTypes<MyClass1>();
Console.WriteLine($"Initial Value: {genericWithMultipleTypes.GetValue().Name}");

var newMyClass = new MyClass1 { Name = "Updated" };
genericWithMultipleTypes.SetValue(newMyClass);
Console.WriteLine($"New Value: {genericWithMultipleTypes.GetValue().Name}");

