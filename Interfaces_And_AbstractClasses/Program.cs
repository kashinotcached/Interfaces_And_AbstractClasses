
namespace Interfaces_And_AbstractClasses;

//Interfaces And Abstract Classes

/* ----------------------------------------------------------------------------------------------------------- */


/*
What is an Interface?
    - Contains a group of related functions that any class that implements the interface must implement.
    - Important because C# doesn't support multiple inheritance of classes.
    - Interfaces are a workaround for multiple inheritance.

* Think of an interface like a contract.
* Class agrees to implement all of the functions inside the interface.
* A class or struct can implement one or more interfaces.

 */


/* ----------------------------------------------------------------------------------------------------------- */


//Creating and implementing an interface 

class Program : IExample, ISecondExample
{
    static void Main(string[] args)
    {

    }

    public void Example()
    {
        System.Diagnostics.Debug.WriteLine("Hello World");
    }

    public int Example2()
    {
        return 1;
    }

    public string Example3(string string1, string string2)
    {
        return string1 + " " + string2;
    }

    public void SecondExample()
    {
        System.Diagnostics.Debug.WriteLine("Hello World");
    }

    public int SecondExample2()
    {
        return 2;
    }

    public string SecondExample3()
    {
        return "How are ya?";
    }
}

interface IExample
{
    void Example();

    int Example2();

    string Example3(string string1, string string2);
}

interface ISecondExample
{
    void SecondExample();

    int SecondExample2();

    string SecondExample3();
}

/* ----------------------------------------------------------------------------------------------------------- */


// Pros and Cons of an Interface 

/*
 
 * Pros
    - Decouple classes.
    - Can reuse functionality.
    - Workaround to multiple inheritance
    - Can contain events, indexers, methods, and properties.

 * Cons 
    - Cannot contain fields or variables
    - Any class that implements it must implement ALL of the interface members, 
    or the code will not compile

 */


/* ----------------------------------------------------------------------------------------------------------- */
