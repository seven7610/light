using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Light.Model{
	 	//countryinfo
		public class countryinfo
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
		/// countryname
        /// </summary>		
		private string _countryname;
        public string countryname
        {
            get{ return _countryname; }
            set{ _countryname = value; }
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

