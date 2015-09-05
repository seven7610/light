using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Light.Model{
	 	//newsinfo
		public class newsinfo
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
		/// title
        /// </summary>		
		private string _title;
        public string title
        {
            get{ return _title; }
            set{ _title = value; }
        }        
		/// <summary>
		/// content
        /// </summary>		
		private string _content;
        public string content
        {
            get{ return _content; }
            set{ _content = value; }
        }        
		/// <summary>
		/// subtitle
        /// </summary>		
		private string _subtitle;
        public string subtitle
        {
            get{ return _subtitle; }
            set{ _subtitle = value; }
        }        
		/// <summary>
		/// isread
        /// </summary>		
		private bool _isread;
        public bool isread
        {
            get{ return _isread; }
            set{ _isread = value; }
        }        
		/// <summary>
		/// ishot
        /// </summary>		
		private bool _ishot;
        public bool ishot
        {
            get{ return _ishot; }
            set{ _ishot = value; }
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

