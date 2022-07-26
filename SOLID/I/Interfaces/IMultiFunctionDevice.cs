using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I.Interfaces
{
    //You can also create your IMachine interface with the help of smaller interfaces if you want
    public interface IMultiFunctionDevice : IScanner, IPrinter, IFaxer
    {
    }
}
