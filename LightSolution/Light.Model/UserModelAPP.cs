using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Light.Model
{
    public class UserModelAPP
    {
        	/// <summary>
		/// 用户id
        /// </summary>		
		private string _userid;
        public string userid
        {
            get{ return _userid; }
            set{ _userid = value; }
        }  
     	/// <summary>
		/// 手机号
        /// </summary>		
		private string _tel;
        public string tel
        {
            get{ return _tel; }
            set{ _tel = value; }
        }        
		/// <summary>
		/// email
        /// </summary>		
		private string _email;
        public string email
        {
            get{ return _email; }
            set{ _email = value; }
        }    
        	/// <summary>
		/// 生理性别
        /// </summary>		
		private string _physiology_society_gender;
        public string physiology_society_gender
        {
            get{ return _physiology_society_gender; }
            set{ _physiology_society_gender = value; }
        }        
		/// <summary>
		/// 社会性别
        /// </summary>		
		private string _society_gender;
        public string society_gender
        {
            get{ return _society_gender; }
            set{ _society_gender = value; }
        }  
        /// <summary>
		/// 昵称
        /// </summary>		
		private string _name;
        public string name
        {
            get{ return _name; }
            set{ _name = value; }
        } 
        /// <summary>
		/// 头像的url
        /// </summary>		
		private string _avatar;
        public string avatar
        {
            get{ return _avatar; }
            set{ _avatar = value; }
        }     

/*description String 个性签名（可能为空，不返回这个字段）
area String 地区（可能为空，不返回这个字段）
birthday int 生日，YYYYMMDDHH（可能为空，不返回这个字段）*/
    }
}
