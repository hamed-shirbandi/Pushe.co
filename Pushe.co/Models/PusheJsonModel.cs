using System.Collections.Generic;

namespace Pushe.co
{
    public class PusheJsonModel
    {
        public PusheJsonModel()
        {
            Notification = new Notification();
            Filter = new Filter();
            Custom_Content = new Dictionary<string, string>();
            Applications = new string[] { };
        }


        /// <summary>
        /// قرار دادن نام پکیج اپلیکیشن ها	
        /// رشته ای از نام بسته ها
        /// </summary>
        public string[] Applications { get; set; }



        /// <summary>
        /// جزییات نوتیفیکیشن
        /// </summary>
        public Notification Notification { get; set; }


        /// <summary>
        /// فیلترها
        /// </summary>
        public Filter Filter { get; set; }



        /// <summary>
        /// ارسال دیتا به صورت کلید-مقدار به اپلیکیشن
        /// </summary>
        public Dictionary<string, string> Custom_Content { get; set; }


    }

    

 

}
