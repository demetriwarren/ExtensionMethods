namespace ExtensionMethods;

internal class Program
{
    static void Main(string[] args)
    {
        var str = "bruhhhhhh";
        
        str.Debug("str is");

        var i = 12;
        i.Debug("i is ");

        i.Func().Debug($"f({i}) = ");

        i.Cubed().Debug("I cubed");
    }
}
