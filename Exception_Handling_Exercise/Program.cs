using System;

namespace Exception_Handling_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a try/catch block to handle all of the exceptions!!!

            // RUN THE APPLICATION WITHOUT DEBUGGING! (Ctrl + F5)


            // TODO: Handle the ArithmeticException
            Methods.ArithmeticExample();


            // TODO: Handle the ArrayTypeMismatchException
            Methods.ArrayTypeMismatchExample();


            // TODO: Handle the DivideByZeroException
            Methods.DivideByZeroExample();


            // TODO: Handle the IndexOutOfRangeException
            Methods.IndexOutOfRangeExample();


            // TODO: Handle the InvalidCastException
            Methods.InvalidCastExample();


            // TODO: Handle the NullReferenceException
            Methods.NullReferenceExample();


            // TODO: Handle the OutOfMemoryException
            Methods.OutOfMemoryExample();


            // TODO: Handle the OverflowException
            Methods.OverflowExample();


            // TODO: Handle the StackOverflowException
            Methods.StackOverflowExample();


            // TODO: Handle the TypeInitializationException
            Methods.TypeInitializationExample();


            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/exceptions
        }
    }
}
