using System;
namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output Constructor 
            //Said Hej
            Singleton.SayHej();
            var instace = Singleton.Instace;
            var sameInstace = Singleton.Instace;
        }
    }

    /// <summary>
    /// Thread Safe Singleton
    /// </summary>
    public class Singleton
    {
        //C# 6 This is readonly
        public static Singleton Instace { get; } = new Singleton();
        //or
        //public static Singleton Instace => new Singleton();


        private Singleton()
        {
            Console.WriteLine("Constructor");
        }
        public static void SayHej()
        {
            Console.WriteLine("Said hej");
        }

        //Wrong this is not readonly !
        //If you want to use this then create a 
        //private static readonly backing field and initialize with new Singleton()
        //public static Singleton Instace
        //{
        //    get
        //    {
        //        return new Singleton();
        //    }
        // }
    }
}
//Ref: Static Initialization is thread safe https://docs.microsoft.com/en-us/previous-versions/msp-n-p/ff650316(v=pandp.10)
//Jon Skeet: http://csharpindepth.com/Articles/General/Singleton.aspx