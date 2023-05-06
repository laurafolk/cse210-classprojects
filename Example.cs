using System;   // <----This just always goes up here. There are additional ones too.
                // It just means that you are importing (as we said in Python) 
                // built-in functions from that library.

// First, you make the class. The class is the same name as the file name.
// All code within this class file is within the curly brackets associated with line 7.
class NewClass
{
    // Next, comes your attributes for that class. Attributes to me is just another word
    // that means variables. In this case, you have two strings.
    public string _attribute1 = "";
    public string _attribute2 = "";

    // The constructor comes after the attributes.
    // The constructor takes the name of the class, which also matches the file name.
    // The constructor will hold all of the values of the attributes,
    // whether that attribute is a string, an array, a list, or what have you.
    public NewClass()
    {
        _attribute1 = "dog";
        _attribute2 = "cat";
    }

    // Last comes your methods. 
    // Methods are essentially functions that are specific to this class.
    // In this case the first method prints a sentence including the attributes/variables.
    public void NewClassMethod1()
    {
       Console.WriteLine($"I have a {_attribute1} and a {_attribute2}");

    }

    // This is just another method like the first. 
    // It just does somethign different with the same attributes.
    public void NewClassMethod2()
    {
        
    }
}  
