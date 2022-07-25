using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S
{
    public class Journal
    {
        private readonly List<string> _entries = new List<string>();
        private static int _count = 0;

        public int AddEntry(string text)
        {
            _entries.Add($"{++_count}: {text}");
            return _count;
        }

        public void RemoveEntry(int idx) => _entries.RemoveAt(idx);

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries);
        }

        //Until this point we are ok

        //The below however is adding too much responsibility to the journal class

        public void Save(string fileName)
        {
            //...
        }

        public static Journal Load(string fileName)
        {
            return null;
        }

        public static Journal Load(Uri uri)
        {
            return null;
        }

        //Instead we should create a new class to handle these (see Persistence class)
    }
}
