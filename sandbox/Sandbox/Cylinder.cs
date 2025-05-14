using System.Security.Cryptography.X509Certificates;

class Cylidner 
{
    private Circle _circle;
    private double _height;

    public void SetCircle(Circle circle) {
        _circle = circle;
    }

    public void SetHeight(double height) {
        _height = height;
    }

    public double GetVolume() {
        return Math.PI * _circle.GetRadius() * _circle.GetRadius() * _height;
    }
}