using System;
using System.Text;

Console.WriteLine("Hello \"World\"!");

Console.WriteLine("c:\\source\\repos");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

Console.Write(@"c:\invoices");
Console.Write(@"\Harry");

var projectName = "SecretOperation";

Console.WriteLine($@"C:\Output\{projectName}\Data");

// In C#, a const variable is a compile-time constant, and its value must be known at compile time. However, string interpolation requires the value of projectName to be known at runtime because it's substituted into the string during execution.

// Therefore, this code gives an error
// const projectName = "SecretOperation";
// Console.WriteLine($@"C:\Output\{projectName}\Data");


// Mutable StringBuilder like in Java

StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("Hello");
stringBuilder.Append(" World!");

Console.WriteLine(stringBuilder.ToString());