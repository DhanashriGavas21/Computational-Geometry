using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Computational_Geometry
{
  class GraphicalInterface
  {

    public void showData3D(string filename, List<Vector3D> listPoint)
    {
      ProcessStartInfo processStartInfo = new ProcessStartInfo(@"C:\Program Files\gnuplot\bin\gnuplot.exe");
      processStartInfo.UseShellExecute = false;
      processStartInfo.RedirectStandardInput = true;
      Process gpProc = new Process();
      gpProc.StartInfo = processStartInfo;
      gpProc.Start();
      gpProc.StartInfo.RedirectStandardInput = true;
      StreamWriter gpcommands = gpProc.StandardInput;
      gpcommands.WriteLine("set terminal wxt");
      gpcommands.WriteLine("set xlabel \"x\"");
      gpcommands.WriteLine("set ylabel \"y\"");
      gpcommands.WriteLine("set zlabel \"z\"");
      gpcommands.WriteLine("splot '-' with lines");
      for (int i = 0; i < listPoint.Count; i++)
      {
        gpcommands.WriteLine("{0} {1} {2}",listPoint[i].X, listPoint[i].Y, listPoint[i].Z);
      }
      gpcommands.WriteLine("e");

      // Wait for the process to exit
      gpProc.WaitForExit();
    }
  

  }

}
