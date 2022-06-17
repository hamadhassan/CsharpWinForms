using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;

namespace Framework.Collision
{
    public interface ICollisionAction
    {
        void perfromAction(IGame game, GameObject source1, GameObject source2);
    }
}
