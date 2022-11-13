using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program;

public class Printerlol : Printer
{
    public override void Print(string value)
    {
        var prevColor = Console.ForegroundColor;

        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine(value.GetType());

        Console.ForegroundColor = ConsoleColor.Yellow;

        base.Print(value);

        Console.ForegroundColor = prevColor;
    }
}
