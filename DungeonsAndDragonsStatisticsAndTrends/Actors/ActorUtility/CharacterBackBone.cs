using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actor
{

    class CharacterBackBone : ActorBackBone
    {
        /// <summary>
        /// Gets or Sets the Character Level
        /// </summary>
        public ActorLevel Level { get; protected set; }
    }

}
