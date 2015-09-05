using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Light.Model{
	 	//regioninfo
		public class regioninfo
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
		/// countryid
        /// </summary>		
		private int _countryid;
        public int countryid
        {
            get{ return _countryid; }
            set{ _countryid = value; }
        }        
		/// <summary>
		/// regionname
        /// </summary>		
		private string _regionname;
        public string regionname
        {
            get{ return _regionname; }
            set{ _regionname = value; }
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

