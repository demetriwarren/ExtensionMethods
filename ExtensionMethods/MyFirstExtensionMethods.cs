using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods;
                                                    // this is basically replacing the Console Commands
public static class MyFirstExtensionMethods        
{
    public static void Debug(this string str, string label)   //void to say we will not return anything
    {    
        Console.WriteLine($"{label}: [{str}]");
        
    }
    public static void Debug(this int i, string label)
    {
        Console.WriteLine($"{label}: [{i}]");
    }
    public static int Func(this int x)
        {
            return (x * x) + (x * 3) + 5;
        }
    public static int Cubed(this int x)
    {
        return x * x * x;
    }
    public static 
}
