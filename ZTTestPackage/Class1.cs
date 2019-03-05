using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Geo = Autodesk.DesignScript.Geometry;
using Autodesk.DesignScript.Interfaces;
using Autodesk.DesignScript.Runtime;

namespace ZTTestPackage
{
    
    public class Class1
    {
        private string test = "test";

        [AllowRankReduction]
        public List<object> TestReduced => new List<object> { test };

        [AllowRankReduction]
        public List<string> Test {
            [AllowRankReduction]
            get
            {
                return new List<string> { test };
            }
        }
        
        public List<string> GetTest()
        {
            return new List<string> { test };
        }

        [AllowRankReduction]
        public List<string> GetTestReduced()
        {
            return new List<string> { test };
        }


        /*[AllowRankReduction]
        public static List<int> RankReduceTest()
        {
            return new List<int> { 0 };
        }

        [AllowRankReduction]
        public List<int> NonStaticRankReduceTest()
        {
            return new List<int> { 0 };
        }

        public static List<int> NoRankReduceTest()
        {
            return new List<int> { 0 };
        }

        [AllowRankReduction]
        public IEnumerable<int> RankReductionArrowFunction => new List<int> { 0 };

        [AllowRankReduction]
        public IEnumerable<int> RankReductionArrowFunctionStatic => new List<int> { 0 };*/
    }
}
