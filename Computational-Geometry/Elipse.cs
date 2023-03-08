using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Computational_Geometry
{
  class Elipse
  {

    List<Vector3D> elipsePoint;
    public Elipse()
    {
      elipsePoint = new List<Vector3D>();
      getUserData();
    }
    void getUserData()
    {
      int count;
      double radius;
      double radius1;
      Vector3D point1 = new Vector3D();

      Console.WriteLine("Enter the center point of (x,y,z)");
      point1.X = double.Parse(Console.ReadLine());
      point1.Y = double.Parse(Console.ReadLine());
      point1.Z = double.Parse(Console.ReadLine());

      Console.WriteLine("Enter the radius of circle");
      radius = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter the radius of circle");
      radius1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter the count of point");
      count = int.Parse(Console.ReadLine());
      drawCircle(point1, radius, radius1, count);

    }
    void drawCircle(Vector3D point1, double radius, double radius1, int count)
    {
      Vector3D vector = new Vector3D();
      double step = 2 * Math.PI / (count);


      for (double t = 0; t < 2 * Math.PI; t += step)
      {
        vector.X = point1.X + radius * Math.Cos(t);
        vector.Y = point1.Y + radius1 * Math.Sin(t);
        vector.Z = point1.Z;
        elipsePoint.Add(vector);
      }
      GraphicalInterface graphicalInterface = new GraphicalInterface();
      graphicalInterface.showData3D("Elipse", elipsePoint);
    }

  }
}

