using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling_Exercise
{
    internal class Methods
    {
        public static void ArithmeticExample()
        {
            try
            {
                throw new ArithmeticException();
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ArrayTypeMismatchExample()
        {
            try
            {
                throw new ArrayTypeMismatchException();
            }
            catch (ArrayTypeMismatchException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DivideByZeroExample()
        {
            try
            {
                throw new DivideByZeroException();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void IndexOutOfRangeExample()
        {
            try
            {
                throw new IndexOutOfRangeException();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void InvalidCastExample()
        {
            try
            {
                throw new InvalidCastException();
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void NullReferenceExample()
        {
            try
            {
                throw new NullReferenceException();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void OutOfMemoryExample()
        {
            try
            {
                throw new OutOfMemoryException();
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void OverflowExample()
        {
            try
            {
                throw new OverflowException();
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void StackOverflowExample()
        {
            try
            {
                throw new StackOverflowException();
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void TypeInitializationExample()
        {
            try
            {
                throw new TypeInitializationException("FullTypeNameExample", new ArgumentOutOfRangeException());
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (TypeInitializationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
