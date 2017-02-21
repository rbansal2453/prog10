using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary
{
    class login
    { 
    public string check(string name, int pass)
    {
        return name == "rajesh" && pass == 123 ? "Welcome Rajesh" : "Invalid Login or Password";

    }

}
class Program
{
    static void Main(string[] args)
    {
        login log = new login();
        Console.WriteLine(log.check("rajesh", 123));

        Console.ReadLine();
    }
}
}