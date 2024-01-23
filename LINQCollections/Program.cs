using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Element  ;
namespace LINQCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Element> elements = BuildList();
            static List<Element> BuildList() => new()
            {
                {new(){Symbol="K", Name="Potassium", AtomicNumber=19} },
                {new(){Symbol="Ca", Name="Calcium", AtomicNumber=20} },
                {new(){Symbol="Sc", Name="Scandium", AtomicNumber=21} },
                {new(){Symbol="Ti", Name="Titanium", AtomicNumber=22} }
            };
        }
    }
}
