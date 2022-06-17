using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Collision;

namespace Framework.Collision
{
    public class CollisionClass
    {
        private ObjectType g1;
        private ObjectType g2;
        private ICollisionAction behaviour;
        public CollisionClass(ObjectType g1, ObjectType g2, ICollisionAction behaviour)
        {
            this.g1 = g1;
            this.g2 = g2;
            this.behaviour = behaviour;
        }

        public ObjectType G1 { get => g1; set => g1 = value; }
        public ObjectType G2 { get => g2; set => g2 = value; }
        public ICollisionAction Behaviour { get => behaviour; set => behaviour = value; }
    }
}
