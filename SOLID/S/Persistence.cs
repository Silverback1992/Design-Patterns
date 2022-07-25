using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S
{
    public static class Persistence
    {
        public static void SaveToFile(Journal j, string fileName, bool overwrtie = false)
        {
            if(overwrtie || !File.Exists(fileName))
                File.WriteAllText(fileName, j.ToString());
        }
    }
}
