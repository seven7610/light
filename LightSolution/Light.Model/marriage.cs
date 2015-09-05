using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Light.Model{
	 	//marriage
		public class marriage
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
		/// proposeid
        /// </summary>		
		private int _proposeid;
        public int proposeid
        {
            get{ return _proposeid; }
            set{ _proposeid = value; }
        }        
		/// <summary>
		/// whoid
        /// </summary>		
		private int _whoid;
        public int whoid
        {
            get{ return _whoid; }
            set{ _whoid = value; }
        }        
		/// <summary>
		/// state
        /// </summary>		
		private int _state;
        public int state
        {
            get{ return _state; }
            set{ _state = value; }
        }        
		/// <summary>
		/// synopsis
        /// </summary>		
		private string _synopsis;
        public string synopsis
        {
            get{ return _synopsis; }
            set{ _synopsis = value; }
        }        
		/// <summary>
		/// proposetime
        /// </summary>		
		private DateTime _proposetime;
        public DateTime proposetime
        {
            get{ return _proposetime; }
            set{ _proposetime = value; }
        }        
		/// <summary>
		/// agreetime
        /// </summary>		
		private DateTime _agreetime;
        public DateTime agreetime
        {
            get{ return _agreetime; }
            set{ _agreetime = value; }
        }        
		/// <summary>
		/// checktime
        /// </summary>		
		private DateTime _checktime;
        public DateTime checktime
        {
            get{ return _checktime; }
            set{ _checktime = value; }
        }        
		/// <summary>
		/// checkman
        /// </summary>		
		private int _checkman;
        public int checkman
        {
            get{ return _checkman; }
            set{ _checkman = value; }
        }        
		   
	}
}

