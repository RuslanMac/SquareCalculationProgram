using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Data
{
    public class TriangleTestData : IEnumerable<object[]>
    {
        private readonly List<object[]> notValidSides = new List<object[]>()
        {
           new object[] { 2, 4, 7 },
           new object[] { 7, 5, 2},
           new object[] { 7, 1, 6 }
        };

        public IEnumerator<object[]> GetEnumerator() => notValidSides.GetEnumerator();


        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
