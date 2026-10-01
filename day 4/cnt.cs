public class Counter
{
    int _value;
    public Counter(){}
    public Counter(int value)
    {
        _value = value;
    }
    public int Decrement()
    {
        if(_value==0){
            return 0;
        }
        else
        {
            _value-=1;
        return _value;
        }
    }
    public void Reset()
    {
        _value=0;
    }
    public void PrintValue()
    {
        Console.WriteLine(_value);
    }
}