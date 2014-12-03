using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actor
{
    class MonsterBackBone : ActorBackBone 
    {
        /// <summary>
        /// Gets or Sets the monster difficulty
        /// </summary>
        public double Challange { get; protected set; }
    }
}
