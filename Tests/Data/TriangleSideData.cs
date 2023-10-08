using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Data
{
    public class TriangleSideData : IEnumerable<object[]>

    {
        private readonly List<object[]> _data = new List<object[]>()
        {
            new object[] { 1, -2, 3 },
            new object[] {4  ,5 -6 },
            new object[] {-1 ,8,9 }
        };
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();


        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
