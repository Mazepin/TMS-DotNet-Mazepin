using System;

namespace Mazepin.Homework1
{
    class Program
    {
        static void Main(string[] args)
            /// <summary>
            /// XML comment for class.
            /// </summary>
            /// 
        internal class Program
        {
            /// <summary>
            /// This is my enum.
            /// </summary>
            private enum Week
            {
                Mon = 1, // 1
                Tue, // 2
                Wed, // 3
                Thu, // 4
                Fri, // 5
                Sat = 10, // 10
                Sun  // 11
            }

            /// <summary>
            /// XML comment for field.
            /// </summary>
            private static string myValue = "My value";

            /// <summary>
            /// XML comment for property.
            /// </summary>
            public int MyProperty { get; set; }

            /// <summary>
            /// XML comment.
            /// </summary>
            /// <param name="args">Agrs.</param>
            private static void Main(string[] args)
            {
               
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
            string temp = "Hello TMS!";
            string Temp = "Another TMS value."; // My first comment
            bool b = false; // true
            int i = 0; // 1, 2, 3..
            double d = 1.53; // 2.34, 3.45..
            decimal dec = 1.23M;// денежное вычисление, точное
            char c = 'a'; // 'b', 'c'..
            string str = "str"; // "qwe"..
            string nullValue = null;// данная переменная ссылается на пустоту
         
            Console.WriteLine(nullValue);
            i = (int)d; // 1   (.53)
            Console.WriteLine(i);
            i = 0;
            i = Convert.ToInt32(d); // 1.53 -> 2
            i = 123;

            Console.Write("Enter some text: ");
            string userInputString = Console.ReadLine();
            Console.WriteLine(">> " + userInputString);// конкатенирование строк
            Console.WriteLine($">> {userInputString}");// интерполяция строк

            Console.WriteLine(Week.Mon);
            Console.WriteLine((int)Week.Mon);

            object obj = i;//неявная упаковка
            obj = "sadasd";
            //int test = (int)obj;
            string strTest = (string)obj;//явное распаковка

            int? nullableIntValue = 1; // 1, 2, 3, null..
            nullableIntValue = null;

            Console.WriteLine($"Nullable: >>{nullableIntValue}<<");

            string myStr = "\"qwe123\"";
            Console.WriteLine(myStr);

            Console.WriteLine(i);
            Console.WriteLine("Hello World!");
            Console.WriteLine(temp);
            Console.WriteLine(Temp);
            Console.ReadLine();
            
                
        }
    }
}
