using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Computational_Geometry
{
  class FileOperation
  {
     StreamWriter streamWriter;

   public  void createFile(string filename, List<Vector3D> vector)
    {
      using (StreamWriter sw = new StreamWriter(filename + ".dat"))
      {
        for(int i =0;i<vector.Count;i++)
        {
          sw.Write(vector[i].X);
          //sw.Write(vector.X);
          sw.Write("   ");
          sw.Write(vector[i].Y);
          sw.Write("    ");
          sw.Write(vector[i].Z);
          sw.Write("\n");
        }
        GraphicalInterface graphicalInterface = new GraphicalInterface();
       
      }
    }
    
  }
}
