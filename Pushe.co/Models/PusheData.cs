using System;
using System.Collections.Generic;
using System.Text;

namespace Pushe.co
{
    public class PusheData
    {

        /// <summary>
        /// عدم نمایش تا زمانی که گوشی غیرفعال است	
        /// </summary>
        public bool Delay_While_Idle { get; set; }


        /// <summary>
        /// کلید جابجایی	
        /// </summary>
        public string Collapse_Key { get; set; }


        /// <summary>
        /// زمان ماندگاری به ثانیه
        /// </summary>
        public int Time_To_Live { get; set; }
    }
}
