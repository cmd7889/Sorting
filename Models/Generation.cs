using lab_0.Services;

namespace lab_0.Entities;

internal class Generation
{
    private int _length;
    private Random _random = new Random();
    private double _random_number;
    private ISorting _sorting; 
    
    public List<double> Array = new List<double>();
    public Generation(int Length)
    {
        _length = Length;
        
        for (int i = 0; i < _length; i++)
        {
            _random_number = _random.NextDouble() * (100.00 + 0.00) - 0.00;
            Array.Add(_random_number);
        }
    }

    public void SetSorting(ISorting sorting)
    {
        _sorting = sorting;
    }

    public void Sorting()
    {
        _sorting.Sorting();
    }
}