using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Light.Command
{
    public class JsonData
    {
        /// <summary>
        /// 系统编码    
        /// </summary>
        public int sys_code { get; set; }
        /// <summary>
        /// 系统信息
        /// </summary>
        public string sys_msg { get; set; }
        /// <summary>
        /// 业务编码
        /// </summary>
        public int result_code { get; set; }
        /// <summary>
        /// 业务信息
        /// </summary>
        public string result_msg { get; set; }
        /// <summary>
        /// 其他信息
        /// </summary>  
        public object obj { get; set; }

        public JsonData()
        {
            sys_code = 0;
            sys_msg = "";
            result_code = 0;
            result_msg = "403";
            obj = null;
        }
    }
}
