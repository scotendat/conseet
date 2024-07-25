using System;
using System.Collections.Generic;

public class PausableState<T>
{
    // This dictionary simulates a state storage mechanism.
    private Dictionary<Type, T> state = new Dictionary<Type, T>();

    public T Value
    {
        get
        {
            if (state.TryGetValue(typeof(PausableState<T>), out T value))
            {
                return value;
            }
            return default(T);
        }
        set
        {
            state[typeof(PausableState<T>)] = value;
        }
    }

    static void Main(string[] args)
    {
        PausableState<int> intState = new PausableState<int>();
        intState.Value = 42;
        Console.WriteLine(intState.Value);  // Outputs: 42

        PausableState<string> stringState = new PausableState<string>();
        stringState.Value = "Hello, world!";
        Console.WriteLine(stringState.Value);  // Outputs: Hello, world!
    }
}
