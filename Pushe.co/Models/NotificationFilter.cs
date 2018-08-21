using System;
using System.Collections.Generic;
using System.Text;

namespace Pushe.co
{
    public class NotificationFilter
    {
        public NotificationFilter()
        {
            Operator = new string[] { };
            Brand = new string[] { };
            Mobile_Net = new string[] { };
            State = new string[] { };

        }



        /// <summary>
        /// نام اپراتور موبایل	
        /// operator:["ir-mci", "irancell", "rightel"]
        /// </summary>
        public string[] Operator { get; set; }


        /// <summary>
        /// نام برند دستگاه
        /// brand:["samsung", "LGE", "asus", "htc", "lenovo", "sony", "huawei"]
        /// </summary>
        public string[] Brand { get; set; }


        /// <summary>
        /// نوع اینترنت	
        /// mobile_net:["lte", "wifi"]
        /// </summary>
        public string[] Mobile_Net { get; set; }


        /// <summary>
        /// استان
        /// طبق مقادیر کلاس Province
        /// </summary>
        public string[] State { get; set; }


    }

}
