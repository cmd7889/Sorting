using System.Diagnostics;

namespace lab_0.Entities;

public class Derivation
{
    private List<double> _array = new List<double>();
    private Stopwatch _stopwatch = new Stopwatch();
    private int _counter = 0;

    // public Derivation(List<double> Array, Stopwatch Stopwatch)
    // {
    //     _array = Array;
    //     _stopwatch = Stopwatch;
    // }

    public void PrintTheOriginalArray(List<double> _array)
    {
        Console.WriteLine("\n\tThe original array:\n");
        
        foreach (var number in _array)
        {
            _counter++;
            Console.WriteLine($"{_counter})   {number.ToString("F" + 4)}");
        }

        _counter = 0;
        Console.WriteLine();
    }

    public void PrintSortedArray(string method)
    {
        Console.WriteLine($"\tSorted array by {method}:\n");
        
        foreach (var number in _array)
        {
            _counter++;
            Console.WriteLine($"{_counter})   {number.ToString("F" + 4)}");
        }
        _counter = 0;
    }
    
    public void PrintSortingAsymptotics() => Console.WriteLine($"{"\nSorting asymptotics:"} {_stopwatch.ElapsedMilliseconds} {"milliseconds"}");
}