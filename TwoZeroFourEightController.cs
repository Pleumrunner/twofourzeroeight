using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twozerofoureight
{
    class TwoZeroFourEightController : Controller
    {
        public const int LEFT = 0;
        public const int RIGHT = 1;
        public const int UP = 2;
        public const int DOWN = 3;

        public TwoZeroFourEightController()
        {

        }

        public override void ActionPerformed(int action)
        {
            foreach (TwoZeroFourEightModel m in mList)
            {
                switch (action)
                {
                    case LEFT:
                        m.PerformLeft();
                        break; 
                    case RIGHT:
                        m.PerformRight();
                        break;
                    case UP:
                        m.PerformUp();
                        break;
                    case DOWN:
                        m.PerformDown();
                        break;
                }
            }
        }
    }
}
