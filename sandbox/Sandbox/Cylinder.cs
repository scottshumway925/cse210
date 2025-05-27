using System.Security.Cryptography.X509Certificates;

class Cylidner 
{
    private Circle _circle;
    private double _height;

    public Cylidner()
    {
        _circle = null;
        _height = 0.0;
    }

    public Cylidner(Circle circle)
    {
        _circle = circle;
        _height = 0.0;
    }

    public Cylidner(Circle circle, double height)
    {
        _circle = circle;
        _height = height;
    }

    public Cylidner(double height, double radius) {
        _circle = new Circle(radius);
        _height = height;
    }

    public void SetCircle(Circle circle)
    {
        _circle = circle;
    }

    public void SetHeight(double height) {
        _height = height;
    }

    public double GetVolume() {
        return Math.PI * _circle.GetRadius() * _circle.GetRadius() * _height;
    }
}