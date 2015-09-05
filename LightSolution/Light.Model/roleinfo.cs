using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Light.Model{
	 	//roleinfo
		public class roleinfo
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
		/// rolename
        /// </summary>		
		private string _rolename;
        public string rolename
        {
            get{ return _rolename; }
            set{ _rolename = value; }
        }        
		/// <summary>
		/// remark
        /// </summary>		
		private string _remark;
        public string remark
        {
            get{ return _remark; }
            set{ _remark = value; }
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

