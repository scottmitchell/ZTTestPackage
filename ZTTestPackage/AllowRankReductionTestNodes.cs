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
    
    public class AllowRankReductionTestNodes
    {
        private string someObject = "test";

        [AllowRankReduction]
        public List<object> SomeProperty => new List<object> { someObject };

        [AllowRankReduction]
        public List<object> SomeProperty2
        {
            [AllowRankReduction]
            get
            {
                return new List<object> { someObject };
            }
        }
        
        public List<string> GetTest()
        {
            return new List<string> { someObject };
        }

        [AllowRankReduction]
        public List<string> GetTestReduced()
        {
            return new List<string> { someObject };
        }
    }
}
