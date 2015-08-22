using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using entityLayer;

namespace businessLayer
{
    public static class wrapperDataBuffer
    {
        private static wrapper wrapperObject;

        public static void initalizeWrapper()
        {
            wrapperObject = new wrapper();
        }

        public static wrapper WrapperObject
        {
            get { return wrapperObject; }
            set { wrapperObject = value; }
        }
    }
}
