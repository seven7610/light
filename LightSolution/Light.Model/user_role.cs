using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Light.Model{
	 	//user_role
		public class user_role
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
		/// userid
        /// </summary>		
		private int _userid;
        public int userid
        {
            get{ return _userid; }
            set{ _userid = value; }
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
		/// specialty
        /// </summary>		
		private string _specialty;
        public string specialty
        {
            get{ return _specialty; }
            set{ _specialty = value; }
        }        
		/// <summary>
		/// introducemyself
        /// </summary>		
		private string _introducemyself;
        public string introducemyself
        {
            get{ return _introducemyself; }
            set{ _introducemyself = value; }
        }        
		/// <summary>
		/// tip
        /// </summary>		
		private int _tip;
        public int tip
        {
            get{ return _tip; }
            set{ _tip = value; }
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
		/// <summary>
		/// executiontimes
        /// </summary>		
		private int _executiontimes;
        public int executiontimes
        {
            get{ return _executiontimes; }
            set{ _executiontimes = value; }
        }        
		   
	}
}

