using System;
using System.Collections.Generic;
using System.Text;

namespace Pushe.co
{
    public class Button
    {
        public Button()
        {
            Btn_Action = new PusheAction();

        }


        /// <summary>
        /// آیکون دکمه	
        /// </summary>
        public string Btn_Icon { get; set; }


        /// <summary>
        /// یکی از اعداد 1، 2 یا 3
        /// </summary>
        public int Btn_Order { get; set; }



        /// <summary>
        /// متن دکمه	
        /// </summary>
        public string Btn_Content { get; set; }


        /// <summary>
        /// ID دکمه، برابر با همان مقدار btn_order
        /// </summary>
        public int Btn_Id { get; set; }


        /// <summary>
        /// تعیین نوع عملکرد	
        /// </summary>
        public PusheAction Btn_Action { get; set; }



    }
}
