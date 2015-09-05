using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Light.Model{
	 	//cityinfo
		public class cityinfo
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
		/// regionid
        /// </summary>		
		private int _regionid;
        public int regionid
        {
            get{ return _regionid; }
            set{ _regionid = value; }
        }        
		/// <summary>
		/// cityname
        /// </summary>		
		private string _cityname;
        public string cityname
        {
            get{ return _cityname; }
            set{ _cityname = value; }
        }        
		/// <summary>
		/// creatman
        /// </summary>		
		private int _creatman;
        public int creatman
        {
            get{ return _creatman; }
            set{ _creatman = value; }
        }        
		/// <summary>
		/// creattime
        /// </summary>		
		private DateTime _creattime;
        public DateTime creattime
        {
            get{ return _creattime; }
            set{ _creattime = value; }
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
		   
	}
}

