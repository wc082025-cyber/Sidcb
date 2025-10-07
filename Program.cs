using System.Security.Cryptography.X509Certificates;

namespace Sidcb;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("String, int, double, char, bool");

        Publicstringclass();
        Publicinterclass();
        Publicdoubleclass();
        Publiccharclass();
        Boolclass();

    }
    static void Publicstringclass()
    {
        Stringclass myStringclass = new Stringclass();

        myStringclass.WriteLine();
    }

    static void Publicinterclass()
    {
        Integer myIntegerclass = new Integer();

        myIntegerclass.WriteLine();
    }

    static void Publicdoubleclass()
    {
        Doubleclass myDoubleclass = new Doubleclass();

        myDoubleclass.WriteLine();
    }

    static void Publiccharclass()
    {
        Characterclass myCharacterclass = new Characterclass();
        myCharacterclass.WriteLine();
    }

    static void Boolclass()
    {
        Booleanclass myBoolclass = new Booleanclass();
        myBoolclass.WriteLine();
    } 
}
