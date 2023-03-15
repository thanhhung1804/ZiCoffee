using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zi.Common.Enumerator
{
    public enum AccessLevel
    {
        /// <summary>
        /// S for the bigest access level
        /// </summary>
        S,
        /// <summary>
        /// Administrator for the second bigest access level
        /// </summary>
        Administrator,
        /// <summary>
        /// Manager for the third bigest access level
        /// </summary>
        Manager,
        /// <summary>
        /// Stocker for access level of warehouse staff
        /// </summary>
        Stocker,
        /// <summary>
        /// bartender for access level of staff in the dispensing counter
        /// </summary>
        Bartender,
        /// <summary>
        /// Cashier for access level of cashier
        /// </summary>
        Cashier,
        /// <summary>
        /// Basic for the smallest access level 
        /// </summary>
        Basic,
    }
}
