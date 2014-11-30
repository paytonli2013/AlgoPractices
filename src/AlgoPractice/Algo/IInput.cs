using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo
{
    public interface IInput<T>
    {
        T Input { get; }
    }

    public interface IInput<T1, T2>
    {
        T1 Input1 { get; }

        T2 Input2 { get; }
    }

    public interface IInput<T1, T2, T3>
    {
        T1 Input1 { get; }

        T2 Input2 { get; }

        T3 Input3 { get; }
    }

    public static class Input
    {
        class InputImp<T> : IInput<T>
        {
            T _input;

            public T Input
            {
                get { return _input; }
            }
            public InputImp(T input)
            {
                _input = input;
            }
        }

        class InputImp<T1, T2> : IInput<T1, T2>
        {
            T1 _input1;

            public T1 Input1
            {
                get { return _input1; }
            }

            T2 _input2;

            public T2 Input2
            {
                get { return _input2; }
            }
            public InputImp(T1 input1, T2 input2)
            {
                _input1 = input1;
                _input2 = input2;
            }
        }

        public static IInput<T> From<T>(T input)
        {
            return new InputImp<T>(input);
        }
        public static IInput<T1,T2> From<T1,T2>(T1 input1,T2 input2)
        {
            return new InputImp<T1,T2>(input1,input2);
        }
    }
}
