using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class WeaponProperties
    {
        #region Properties
        /// <summary>
        /// Gets or Sets the LightWeight property 
        /// </summary>
        public bool LightWeight{ get; set;}
        /// <summary>
        /// Gets or Sets the Medium Weight property
        /// </summary>
        public bool MediumWeight{ get; set;}
        /// <summary>
        /// Gets or Sets the Heavy Weight property
        /// </summary>
        public bool HeavyWeight{ get; set;}
        /// <summary>
        /// Gets or Sets the Finesse property
        /// </summary>
        public bool Finesse{ get; set;}
        /// <summary>
        /// Gets or Sets the Versatile property
        /// </summary>
        public bool Versatile{ get; set;}
        /// <summary>
        /// Gets or Sets the Thrown property
        /// </summary>
        public bool Thrown{get; set;}

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor sets all properties to false
        /// </summary>
        public WeaponProperties()
        {
            LightWeight = false;
            MediumWeight = false;
            HeavyWeight = false;
            Finesse = false;
            Versatile = false;
            Thrown = false;
        }
        #endregion
    }
}
