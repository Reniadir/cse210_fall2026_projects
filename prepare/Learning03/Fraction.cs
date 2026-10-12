class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int num)
    {
        _top = num;
        _bottom = 1;
    }
    public Fraction(int top, int bot)
    {
        _top = top;
        _bottom = bot;
    }
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBot()
    {
        return _bottom;
    }
    public void SetBot(int bot)
    {
        _bottom = bot;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }
}