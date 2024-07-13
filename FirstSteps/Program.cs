//This file contains:
//Console printing, data types and variable declarations,
//  string formating, console printing types
//First check terminal path first
//Dotnet run on terminal to test code


//Console print
Console.WriteLine("This is the first line.");
Console.WriteLine("This is the second line."); // no genera salto de linea

//Data types
Console.WriteLine("Hello."); //string
Console.WriteLine('C'); //char
Console.WriteLine(1); //int
Console.WriteLine(11.11M); //float
Console.WriteLine(true); //boolean
Console.WriteLine(false); //boolean

//Variables Declaration
string newWord = "Word";
char newCharacter = 'l';
int number = 0;
double floatingNumber = 9.0;
bool state = true;

Console.WriteLine(newWord); //string
Console.WriteLine(newCharacter); //char
Console.WriteLine(number); //int
Console.WriteLine(floatingNumber); //float
Console.WriteLine(state); //boolean

//Introducing var
/*
var absorbs the type its value is
in this case var absorbs string as its type because we hardocoded a string
it cannot be changed, once it takes a type, it cannot absobs another one.
this is usefull when we need to store a value that's not  known its data type
*/

var letters = "None";
Console.WriteLine(letters);


//Character Escape Sequence

Console.WriteLine("Hello\nWorld");// \n Linejump
Console.WriteLine("Hello\tWorld");// \t tab space betwen words
Console.WriteLine("Hello \"World\"!");//  \text\ two barrs to print double quotation
Console.WriteLine("c:\\source\\repos");// \\print only one bar from path string
Console.WriteLine(@"c:\source\repos
    (this is awezome) \n");// @ takes every character in text as string, including linejumps and specials
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // \u allows unicode, \u per character wanted to print, supports utf-16


//String concatenation
string h = "hello";
string w = "world";
Console.WriteLine(h + w); //prints values from string variables concatenated
Console.WriteLine(h + "crazy" + w + "!"); // also you can concatenate string variables and literal strings
string complete = h + "crazy" + w + "!"; // you can save concatenated strings in a string variable
Console.WriteLine(complete);
Console.WriteLine($"{h + w}"); //string interpolation, $ for set the interpolation and {} where inner values are variables or data
string mess =  $"{h} {w}"; // also works in variables, and there can be multiple interpolations
Console.WriteLine($@"Here we say {h} {w} every morning (joke)"); // also, @ allows interpolation, and multiples of it


//Basic operations with numbers
int a = 10;
int b = 5;
Console.WriteLine(a + b); // + between two





