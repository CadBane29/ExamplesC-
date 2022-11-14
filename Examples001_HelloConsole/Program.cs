// See https://aka.ms/new-console-template for more information
//Console.WriteLine("2Hello, World!");
// using System;

// public class Example
// {
//     public static void Main()
//     {
//         Console.Clear();

//         DateTime dat = DateTime.Now;

//         Console.WriteLine("\nToday is {0:d} at {0:T}.", dat);
//         Console.Write("\nPress any key to continue... ");
//         Console.ReadLine();
//     }
// }


// using System;
// using System.IO;

// public class InsertTabs
// {
//     private const int tabSize = 4;
//     private const string usageText = "Usage: INTERTTABS inputfile.txt outputfile.txt";
//     public static int Main(string[] args)
//     {
//         if (args.Length < 2)
//         {
//             Console.WriteLine(usageText);
//             return 1;
//         }

//         try
//         {
//             // attempt to open output file.
//             using(var writer = new StreamWriter(args[1]))
//             {
//                 using(var reader = new StreamReader(args[0]))
//                 {
//                     // Redirect standart output from the console to the output file.
//                     Console.SetOut(writer);
//                     // Redirect standart input from the console to the input file.
//                     Console.SetIn(reader);
//                     string line;
//                     while ((line = Console.ReadLine()) != null)
//                     {
//                         string newLine = line.Replace(("").PadRight(tabSize, ' '), "\t");
//                         Console.WriteLine(newLine);
//                     }
//                 }
//             }

//         }
//         catch(IOException e)
//         {
//             TextWriter errorWriter = Console.Error;
//             errorWriter.WriteLine(e.Message);
//             errorWriter.WriteLine(usageText);
//             return 1;
//         }

//         // Recover the standart output stream so that a completion message can be displayed.
//         var standardOutput = new StreamWriter(Console.OpenStandardOutput());
//         standardOutput.AutoFlush = true;
//         Console.SetOut(standardOutput);
//         Console.WriteLine($"INSERTTABS has complited the processing of {args[0]}.");
//         return 0;
//     }
// }



using System;

public class Example
{
    public static void Main() 
    {
        if (! Console.IsInputRedirected) {
           Console.WriteLine("This example requires that input be redirected from a file.");
           return;
        }

        Console.WriteLine("About to call Console.ReadLine in a loop.");
        Console.WriteLine("----");
        String s;
        int ctr = 0;
        do{
            ctr++;
            s = Console.ReadLine();
            Console.WriteLine("Line {0}: {1}", ctr, s);
        } while (s != null);
        Console.WriteLine("---");
        
    }
}