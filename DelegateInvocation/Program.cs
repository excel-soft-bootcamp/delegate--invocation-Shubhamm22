using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInvocation
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations _operations = new Operations();
            
            Func<int, double, double> calculatePtr = new Func<int, double, double>(Operations.Calculate);
            Action<int> updatePtr = new Action<int>(_operations.Update);
            Action<string> deletePtr = new Action<string>(_operations.Delete);
            Action action = new Action(_operations.ZeroArguments);
            Action<string> stringPtr = new Action<string>(_operations.String);
            Func<int, int> integerPtr = new Func<int, int>(_operations.Integer);
            Func<string, string, bool> boolPtr = new Func<string, string, bool>(_operations.StringBoolean);

            Operations.FunctionsAsAnArguments(action, stringPtr, integerPtr, boolPtr, calculatePtr, updatePtr);

        }
    }
}