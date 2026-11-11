class Circle: Shape{
    private double _radius;
     public Circle(double r)
    {
        _radius = r;
    }
    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}