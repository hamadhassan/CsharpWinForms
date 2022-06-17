using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Collision;
using Framework.Core;
using Framework.Movement;

namespace Framework.Collision
{
    public class PLayerCollision :ICollisionAction
    {
        public void perfromAction(IGame game,GameObject source1,GameObject source2)
        {
            GameObject player;
            if (source1.Otype == ObjectType.player)
            {
                player = source1;
            }
            else
            {
                player = source2;
            }
            game.risePlayerDieEvent(player.Pb);
        }
    }
}
