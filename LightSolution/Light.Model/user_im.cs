using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Light.Model{
	 	//user_im
		public class user_im
	{
   		     
      	/// <summary>
		/// auto_increment
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
		/// imtoken
        /// </summary>		
		private string _imtoken;
        public string imtoken
        {
            get{ return _imtoken; }
            set{ _imtoken = value; }
        }        
		/// <summary>
		/// create_time
        /// </summary>		
		private long _create_time;
        public long create_time
        {
            get{ return _create_time; }
            set{ _create_time = value; }
        }        
		/// <summary>
		/// update_time
        /// </summary>		
		private long _update_time;
        public long update_time
        {
            get{ return _update_time; }
            set{ _update_time = value; }
        }        
		   
	}
}

