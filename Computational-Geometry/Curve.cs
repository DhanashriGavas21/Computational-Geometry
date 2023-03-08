using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Computational_Geometry
{
  class Curve
  {
    int count;


    List<Vector3D> curvePoint;
    public Curve()
    {

      curvePoint = new List<Vector3D>();
      getUserData();
    }
    void getUserData()
    {
      Vector3D point1 = new Vector3D();
      Vector3D point2 = new Vector3D();
      Vector3D point3 = new Vector3D();
      Console.WriteLine("Enter the First point of (x,y,z)");
      point1.X = double.Parse(Console.ReadLine());
      point1.Y = double.Parse(Console.ReadLine());
      point1.Z = double.Parse(Console.ReadLine());

      Console.WriteLine("Enter the Second point of (x,y,z)");
      point2.X = double.Parse(Console.ReadLine());
      point2.Y = double.Parse(Console.ReadLine());
      point2.Z = double.Parse(Console.ReadLine());

      Console.WriteLine("Enter the Second point of (x,y,z)");
      point3.X = double.Parse(Console.ReadLine());
      point3.Y = double.Parse(Console.ReadLine());
      point3.Z = double.Parse(Console.ReadLine());

      Console.WriteLine("Enter the count of point");
      count = int.Parse(Console.ReadLine());
      drawCurve(point1, point2, point3, count);

    }
    void drawCurve(Vector3D point1, Vector3D point2, Vector3D point3, int count)
    {
      Vector3D vector = new Vector3D();
      double step = (double)1.0 / count;
      for (double u = 0; u < 1; u += step)
      {
        vector.X= (point1.X * Math.Pow((1 - u), 2)) + 2 * (point2.X * (1 - u) * (u)) + (point3.X * Math.Pow(u, 2));
        vector.Y = (point1.Y * Math.Pow((1 - u), 2)) + 2 * (point2.Y * (u) * (1 - u)) + (point3.Y * Math.Pow(u, 2));
        vector.Z = (point1.Z * Math.Pow((1 - u), 2)) + 2 * (point2.Z * (u) * (1 - u)) + (point3.Z * Math.Pow(u, 2));

        curvePoint.Add(vector);
      }
      GraphicalInterface graphicalInterface = new GraphicalInterface();
      graphicalInterface.showData3D("Curve", curvePoint);
    }

  }
}
