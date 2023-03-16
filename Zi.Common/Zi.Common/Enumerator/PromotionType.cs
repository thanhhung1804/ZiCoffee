using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zi.Common.Enumerator
{
    public enum PromotionType
    {
        /// <summary>
        /// Discount for direct discount form
        /// </summary>
        Discount,
        /// <summary>
        /// Voucher for the discount form by the voucher
        /// </summary>
        Voucher,
        /// <summary>
        /// Coupon for the discount form by the couple
        /// </summary>
        Coupon,
        /// <summary>
        /// MemberPoint for the discount form by the point of member
        /// </summary>
        MemberPoint,
    }
}
