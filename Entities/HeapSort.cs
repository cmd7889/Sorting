using System.Diagnostics;
using lab_0.Services;

namespace lab_0.Entities;

internal class HeapSort : ISorting
{
    private List<double> _array = new List<double>();
    private Stopwatch _stopwatch = new Stopwatch();
    private int _counter = 0;

    public HeapSort(List<double> Array)=> _array = Array;

    void ISorting.Sorting()
    {
        Console.WriteLine("\n\tThe original array:\n");
        
        foreach (var number in _array)
        {
            _counter++;
            Console.WriteLine($"{_counter}{")"}   {number.ToString("F" + 4)}");
        }

        _counter = 0;
        Console.WriteLine();
        
        _stopwatch.Start();
        
        double item = 0;
        
        void heapify(int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && _array[left] > _array[largest])
                largest = left;

            if (right < n && _array[right] > _array[largest])
                largest = right;

            if (largest != i)
            {
                item = _array[i];
                _array[i] = _array[largest];
                _array[largest] = item;
                
                heapify(n, largest);
            }
        }

        double item2;

        for (int i = _array.Count / 2 - 1; i >= 0; i--) 
            
            heapify(_array.Count, i);
        
        for (int i = _array.Count - 1; i >= 0; i--)
        {
            item2 = _array[0];
            _array[0] = _array[i];
            _array[i] = item2;
                
            heapify(i, 0);
        }
            
        _stopwatch.Stop();
        
        Console.WriteLine("\tSorted array by heap sort:\n");
        
        foreach (var number in _array)
        {
            _counter++;
            Console.WriteLine($"{_counter}{")"}   {number.ToString("F" + 4)}");
        }

        _counter = 0;
       
        Console.WriteLine($"{"\nSorting asymptotics:"} {_stopwatch.ElapsedMilliseconds} {"milliseconds"}");
    }
}