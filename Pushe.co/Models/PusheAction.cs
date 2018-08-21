using System;
using System.Collections.Generic;
using System.Text;

namespace Pushe.co
{

    public class PusheAction
    {

        /// <summary>
        /// تعیین هدف عملکرد
        /// طبق جدول ۳. انواع عملکرد در داکیومنت http://panel.pushe.co/documentation
        /// </summary>
        public string Url { get; set; }


        /// <summary>
        /// تعیین نوع عملکرد	
        /// </summary>
        public ActionType Action_Type { get; set; }

    }

}
