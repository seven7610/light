using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Light.Model{
	 	//authenticationinfo
		public class authenticationinfo
	{
   		     
      	/// <summary>
		/// id
        /// </summary>		
		private int _id;
        public int id
        {
            get{ return _id; }
            set{ _id = value; }
        }        
		/// <summary>
		/// authenticationname
        /// </summary>		
		private string _authenticationname;
        public string authenticationname
        {
            get{ return _authenticationname; }
            set{ _authenticationname = value; }
        }        
		/// <summary>
		/// Introduction
        /// </summary>		
		private string _introduction;
        public string Introduction
        {
            get{ return _introduction; }
            set{ _introduction = value; }
        }        
		/// <summary>
		/// createman
        /// </summary>		
		private int _createman;
        public int createman
        {
            get{ return _createman; }
            set{ _createman = value; }
        }        
		/// <summary>
		/// createtime
        /// </summary>		
		private DateTime _createtime;
        public DateTime createtime
        {
            get{ return _createtime; }
            set{ _createtime = value; }
        }        
		   
	}
}

