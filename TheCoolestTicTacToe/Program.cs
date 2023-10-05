// See https://aka.ms/new-console-template for more information
using System.Dynamic;

Console.WriteLine("Hello, World!");

string myStringThing;
myStringThing = "null";

Console.WriteLine(myStringThing);

string firstNumber = "10";
string secondNumber = "2";

Console.WriteLine(int.Parse(firstNumber) + int.Parse(secondNumber));

Jeff jeffOry = new Jeff(2, 6);

Console.WriteLine(jeffOry.addStuff(firstNumber, secondNumber));
Console.WriteLine(jeffOry.addStuff());

public class Jeff
{
private short shortOne {get; set;} //adds default getter/setters thank you C#
private short shortTwo {get; set;}

public Jeff() {}
public Jeff(short s1, short s2) 
{
    shortOne = s1;
    shortTwo = s2;
}

public int addStuff()
{
    return shortOne + shortTwo;
}
public int addStuff(int numberOne, int numberTwo)
{
    return numberOne + numberTwo;
}

public string addStuff(string numberOne, string numberTwo) {
    var addedInt = int.Parse(numberOne) + int.Parse(numberTwo);
    return addedInt.ToString();
}

}