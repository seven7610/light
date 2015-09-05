using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Light.Command
{
    public class Validate
    {
        /// <summary>
        /// 验证是否是手机号
        /// </summary>
        /// <param name="strNumber">需要验证的字符串</param>
        /// <returns></returns>
        public bool IsMoblieNumber(string strValue)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(strValue, @"^((0?1[358]\d{9})|((0(10|2[1-3]|[3-9]\d{2}))?[1-9]\d{6,7}))$"))
                return true;
            else
                return false;
        }

        public bool IsEmail(string strValue)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(strValue, @"\\w{1,}@\\w{1,}\\.\\w{1,}"))
                return true;
            else
                return false;
        }
        
    }
}
