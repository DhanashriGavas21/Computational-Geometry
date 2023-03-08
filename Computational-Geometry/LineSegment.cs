using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Computational_Geometry
{
  class LineSegment
  {
    int count;
    Vector3D point1;
    Vector3D point2;
    List<Vector3D> linePoint;
    public LineSegment()
    {
      point1 = new Vector3D();
      point2 = new Vector3D();
      linePoint = new List<Vector3D>();
      getUserData();
    }
    void getUserData()
    {
      
      Console.WriteLine("Enter the First point of (x,y,z)" );
      point1.X = double.Parse(Console.ReadLine());
      point1.Y = double.Parse(Console.ReadLine());
      point1.Z = double.Parse(Console.ReadLine());

      Console.WriteLine("Enter the Second point of (x,y,z)");
      point2.X = double.Parse(Console.ReadLine());
      point2.Y = double.Parse(Console.ReadLine());
      point2.Z = double.Parse(Console.ReadLine());

      Console.WriteLine("Enter the count of point");
      count = int.Parse(Console.ReadLine());
      drawLineSegment(point1, point2, count);

    }

    void drawLineSegment(Vector3D point1, Vector3D point2, int count)
    {
      FileOperation fileOperation = new FileOperation();
      
      double step = 1.0 / count;
      for (double u = 0; u < 1; u += step)
      {
        Vector3D vector = point1 * (1 - u) + (point2 * u);
        linePoint.Add(vector);
      }
      GraphicalInterface graphicalInterface = new GraphicalInterface();
      graphicalInterface.showData3D("LineSegment",linePoint);
      //graphicalInterface.Demo(linePoint);
      fileOperation.createFile("LineSegment", linePoint);

    }
  }
}
