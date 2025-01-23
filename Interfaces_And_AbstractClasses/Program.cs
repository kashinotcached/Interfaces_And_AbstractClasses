
using System.Collections;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

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

//class Program : IExample, ISecondExample
//{
//    static void Main(string[] args)
//    {

//    }

//    public void Example()
//    {
//        System.Diagnostics.Debug.WriteLine("Hello World");
//    }

//    public int Example2()
//    {
//        return 1;
//    }

//    public string Example3(string string1, string string2)
//    {
//        return string1 + " " + string2;
//    }

//    public void SecondExample()
//    {
//        System.Diagnostics.Debug.WriteLine("Hello World");
//    }

//    public int SecondExample2()
//    {
//        return 2;
//    }

//    public string SecondExample3()
//    {
//        return "How are ya?";
//    }
//}

//interface IExample
//{
//    void Example();

//    int Example2();

//    string Example3(string string1, string string2);
//}

//interface ISecondExample
//{
//    void SecondExample();

//    int SecondExample2();

//    string SecondExample3();
//}

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


////INotifyPropertyChanged Interface

//class Program : INotifyPropertyChanged
//{
//    public event PropertyChangedEventHandler? PropertyChanged;

//    public string Name
//    {
//        get
//        {
//            return Name;
//        }
//        set
//        {
//            Name = value;
//            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
//        }
//    }

//    public static void Main(string[] args)
//    {

//    }
//}

/* ----------------------------------------------------------------------------------------------------------- */


////IComparable Interface

///*
// * Interface is used to define a default sort order for objects of a specific type. 
// * This means that classes that implement this interface can be sorted and ordered in a specific way.
// */

//class Program : IComparable
//{
//    public int exampleLength;
//    Program ex1 = new Program() { exampleLength = 2 };

//    static void Main(String[] args)
//    {

//    }

//    public int CompareTo(object? obj)
//    {
//        Program ex2 = (Program)obj;
//        var num = ex1.exampleLength == ex2.exampleLength ? 0 : (ex1.exampleLength > ex2.exampleLength ? 1 : -1);

//        return num;
//    }
//}


/* ----------------------------------------------------------------------------------------------------------- */

// IComparer Interface 

/*

 * It is similar to IComparable Interface, If 'Compare()' function returns -
    - 0, then 2 IDs are equal
    - -1, then Employee1's ID > Employee2's ID
    - 1, then Employee2's ID > Employee1's ID

 */

class Program : IComparer
{
    class Employee
    {
        public int id;
    }

    static void Main(string[] args)
    {

    }

    public int Compare(object? x, object? y)
    {
        Employee employee1 = (Employee)x;
        Employee employee2 = (Employee)y;
        return employee1.id.CompareTo(employee2.id);
    }
}


/* ----------------------------------------------------------------------------------------------------------- */
