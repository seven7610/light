using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Light.Model{
	 	//marriageimageinfo
		public class marriageimageinfo
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
		/// url
        /// </summary>		
		private string _url;
        public string url
        {
            get{ return _url; }
            set{ _url = value; }
        }        
		/// <summary>
		/// marriageid
        /// </summary>		
		private int _marriageid;
        public int marriageid
        {
            get{ return _marriageid; }
            set{ _marriageid = value; }
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

