using Pushe.co.Resource;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pushe.co
{
    public class Notification
    {
        public Notification()
        {
            Action = new PusheAction();
            Buttons = new List<Button>();
            Data = new PusheData();
            Filter = new NotificationFilter();
            Topics = new string[] { };
            Show_App = true;
            Visibility = true;
            Wake_Screen = true;
            Unique = false;

        }


        /// <summary>
        /// تیتر اعلان کوچک
        /// </summary>
        [Display(Name = "Notification_Title", ResourceType = typeof(PusheMetadata))]
        public string Title { get; set; }


        /// <summary>
        /// تیتر اعلان بزرگ	
        /// </summary>
        [Display(Name = "Notification_Big_Title", ResourceType = typeof(PusheMetadata))]
        public string Big_Title { get; set; }


        /// <summary>
        /// متن اعلان کوچک	
        /// </summary>
        [Display(Name = "Notification_Content", ResourceType = typeof(PusheMetadata))]
        public string Content { get; set; }


        /// <summary>
        /// متن اعلان بزرگ	
        /// </summary>
        [Display(Name = "Notification_Big_Content", ResourceType = typeof(PusheMetadata))]
        public string Big_Content { get; set; }


        /// <summary>
        /// آدرس عکس بنر	
        /// </summary>
        [Display(Name = "Notification_Image", ResourceType = typeof(PusheMetadata))]
        public string Image { get; set; }


        /// <summary>
        ///  آدرس آیکون داخلی پوش	
        /// </summary>
        [Display(Name = "Notification_Icon", ResourceType = typeof(PusheMetadata))]
        public string Icon { get; set; }


        /// <summary>
        /// متن نوار اعلان	
        /// </summary>
        [Display(Name = "Notification_Ticker", ResourceType = typeof(PusheMetadata))]
        public string Ticker { get; set; }



        /// <summary>
        /// آیکون جایگزین آیکون اپ	
        /// یکی از مقادیر جدول 2 در داکیومنت http://panel.pushe.co/documentation
        /// </summary>
        [Display(Name = "Notification_Notif_Icon", ResourceType = typeof(PusheMetadata))]
        public string Notif_Icon { get; set; }


        /// <summary>
        /// روشن شدن صفحه نمایش به هنگام دریافت پیام	
        /// </summary>
        [Display(Name = "Notification_Wake_Screen", ResourceType = typeof(PusheMetadata))]
        public bool Wake_Screen { get; set; }


        /// <summary>
        /// آدرس صدای هشدار به هنگام دریافت اعلان	
        /// </summary>
        [Display(Name = "Notification_Sound_Url", ResourceType = typeof(PusheMetadata))]
        public string Sound_Url { get; set; }


        /// <summary>
        /// اعلان نمایش داده شود یا خیر	
        /// </summary>
        [Display(Name = "Notification_Visibility", ResourceType = typeof(PusheMetadata))]
        public bool Visibility { get; set; }


        /// <summary>
        /// تعیین رنگ led	
        /// </summary>
        [Display(Name = "Notification_LED_Color", ResourceType = typeof(PusheMetadata))]
        public string LED_Color { get; set; }


        /// <summary>
        /// نمایش اعلان در اپلیکیشن
        /// </summary>
        [Display(Name = "Notification_Show_App", ResourceType = typeof(PusheMetadata))]
        public bool Show_App { get; set; }


        /// <summary>
        /// زمان روشن ماندن led به میلی ثانیه
        /// </summary>

        [Display(Name = "Notification_LED_On", ResourceType = typeof(PusheMetadata))]
        public int LED_On { get; set; }


        /// <summary>
        /// زمان خاموش ماندن led به میلی ثانیه
        /// </summary>
        [Display(Name = "Notification_LED_Off", ResourceType = typeof(PusheMetadata))]
        public string LED_Off { get; set; }


        /// <summary>
        /// تعیین نوع عملکرد
        /// </summary>
        public PusheAction Action { get; set; }



        /// <summary>
        /// دکمه ها
        /// </summary>
        public List<Button> Buttons { get; set; }



        /// <summary>
        /// تعاریف اعلان زمانی که گوشی غیر فعال است
        /// </summary>
        public PusheData Data { get; set; }


        /// <summary>
        /// فیلتر
        /// </summary>
        public NotificationFilter Filter { get; set; }


        /// <summary>
        /// تعیین کانالهایی که پیام ارسال شود	
        /// رشته ای از نام کانال ها که با کاما جدا شوند
        /// </summary>
        public string[] Topics { get; set; }



        /// <summary>
        /// به کاربران مشترک اپها یک پیام ارسال شود	
        /// </summary>
        [Display(Name = "Notification_Unique", ResourceType = typeof(PusheMetadata))]
        public bool Unique { get; set; }


        /// <summary>
        /// تعیین زمان ارسال	
        /// eta:"2016-10-18T13:28:00+03:30"
        /// </summary>
        [Display(Name = "Notification_Eta", ResourceType = typeof(PusheMetadata))]
        public string Eta { get; set; }


    }

}
