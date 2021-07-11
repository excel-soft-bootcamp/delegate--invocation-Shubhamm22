using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInvocation
{


    public class Operations
    {
        public static double Calculate(int x, double y) { return x + y; }

        public void Update(int newNumber) { System.Console.WriteLine(newNumber); }

        public void Delete(string key) { }
        public void ZeroArguments() { }
        public void String(string data) { }
        public int Integer(int x)
        {
            return x;
        }
        public bool StringBoolean(string data, string newData)
        {
            return true;
        }

        public static void FunctionsAsAnArguments(Action obj, Action<string> obj2, Func<int, int> obj3, Func<string, string, bool> obj4, Func<int, double, double> obj7, Action<int> obj8)
        {
            obj.Invoke();
            obj2.Invoke("hello");
            int intValue = obj3.Invoke(111);
            bool boolValue = obj4.Invoke("Good Morning", "Good Evening");
            double doubleValue = obj7.Invoke(55, 7.5);
            obj8.Invoke(3);

            Console.WriteLine(intValue);
            Console.WriteLine(boolValue);
            Console.WriteLine(doubleValue);
        }
       
    }

        
         

}
