class Rectangle: Shape{
    private double _length;
    private double _width;
     public Rectangle(double l, double w)
    {
        _length = l;
        _width = w;
    }
    public override double GetArea()
    {
        return _length*_width;
    }
}