using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CocosSharp;

namespace tests
{
    public class FlipAngularRightOver : CCTransitionFlipAngular
    {
        public FlipAngularRightOver(float t, CCScene s)
            : base(t, s, CCTransitionOrientation.RightOver)
        {
        }
    }
}
