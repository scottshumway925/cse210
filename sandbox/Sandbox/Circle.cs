class Circle 
{
    private double _radius;

    public void SetRadius(double radius) {
        _radius = radius;
    }

    public double GetRadius() {
        return _radius;
    }

    public double GetArea() {
        return Math.PI * _radius * _radius;
    }
}