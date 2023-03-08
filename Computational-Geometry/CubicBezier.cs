using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Computational_Geometry
{
  class CubicBezier
  {
    int count;
    List<Vector3D> cubicBezierCurvePoint;
    public CubicBezier()
    {

      cubicBezierCurvePoint = new List<Vector3D>();
      getUserData();
    }
    void getUserData()
    {
      Vector3D point1 = new Vector3D();
      Vector3D point2 = new Vector3D();
      Vector3D point3 = new Vector3D();
      Vector3D point4 = new Vector3D();

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

      Console.WriteLine("Enter the Second point of (x,y,z)");
      point4.X = double.Parse(Console.ReadLine());
      point4.Y = double.Parse(Console.ReadLine());
      point4.Z = double.Parse(Console.ReadLine());

      Console.WriteLine("Enter the count of point");
      count = int.Parse(Console.ReadLine());
      drawCurve(point1, point2, point3, point4, count);

    }
    void drawCurve(Vector3D point1, Vector3D point2, Vector3D point3, Vector3D point4, int count)
    {
      Vector3D vector = new Vector3D();
      double step = (double)1.0 / count;
      for (double u = 0; u < 1; u += step)
      {
        vector.X = (double)(point1.X * Math.Pow((1 - u), 3) + 3 * point2.X * u * Math.Pow((1 - u), 2) + 3 * point3.X * Math.Pow(u, 2) * (1 - u) + point4.X * Math.Pow(u, 3));
        vector.Y = (double)(point1.Y * Math.Pow((1 - u), 3) + 3 * point2.Y * u * Math.Pow((1 - u), 2) + 3 * point3.Y * Math.Pow(u, 2) * (1 - u) + point4.Y * Math.Pow(u, 3));
        vector.Z = (double)(point1.Z * Math.Pow((1 - u), 3) + 3 * point2.Z * u * Math.Pow((1 - u), 2) + 3 * point3.Z * Math.Pow(u, 2) * (1 - u) + point4.Z * Math.Pow(u, 3));

        cubicBezierCurvePoint.Add(vector);
      }
      GraphicalInterface graphicalInterface = new GraphicalInterface();
      graphicalInterface.showData3D("CubicBezierCurve", cubicBezierCurvePoint);
    }

  }
}
