using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling_Exercise
{
    internal class Methods
    {
        public static void ArithmeticExample()
        {
            throw new ArithmeticException();
        }

        public static void ArrayTypeMismatchExample()
        {
            throw new ArrayTypeMismatchException();
        }

        public static void DivideByZeroExample()
        {
            throw new DivideByZeroException();
        }

        public static void IndexOutOfRangeExample()
        {
            throw new IndexOutOfRangeException();
        }

        public static void InvalidCastExample()
        {
            throw new InvalidCastException();
        }

        public static void NullReferenceExample()
        {
            throw new NullReferenceException();
        }

        public static void OutOfMemoryExample()
        {
            throw new OutOfMemoryException();
        }

        public static void OverflowExample()
        {
            throw new OverflowException();
        }

        public static void StackOverflowExample()
        {
            throw new StackOverflowException();
        }

        public static void TypeInitializationExample()
        {
            throw new TypeInitializationException("FullTypeNameExample", new ArgumentOutOfRangeException());
        }
    }
}
