using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Light.Model{
	 	//role_authentication
		public class role_authentication
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
		/// roleid
        /// </summary>		
		private int _roleid;
        public int roleid
        {
            get{ return _roleid; }
            set{ _roleid = value; }
        }        
		/// <summary>
		/// authenticationid
        /// </summary>		
		private int _authenticationid;
        public int authenticationid
        {
            get{ return _authenticationid; }
            set{ _authenticationid = value; }
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

