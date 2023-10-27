using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Utilities
{
    //SD = static details
    public static class SD
    {
        #region USER_ROLES
        public const string Role_User_Customer = "Customer";
        public const string Role_User_Company = "Company";
        public const string Role_Admin = "Admin";
        public const string Role_Employee = "Employee";
        #endregion

        #region ORDER_STATUS
        public const string StatusPending = "Pending";
        public const string StatusApproved = "Approved";
        public const string StatusInProcess = "Processing";
        public const string StatusShipped = "Shipped";
        public const string StatusCancelled = "Cancelled";
        public const string StatusRefunded = "Refunded";
        #endregion

        #region PAYMENT_STATUS
        public const string PaymentStatusPending = "Pending";
        public const string PaymentStatusApproved = "Approved";
        public const string PaymentStatusDelayPayment = "ApprovedForDelayPayment";
        public const string PaymentStatusRejected = "Rejected";
        #endregion

        #region SESSION
        public const string SessionCart = "SessionShoppingCart";
        #endregion
    }


}
