using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Light.Model{
	 	//tipdetail
		public class tipdetail
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
		/// sendee
        /// </summary>		
		private int _sendee;
        public int sendee
        {
            get{ return _sendee; }
            set{ _sendee = value; }
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
		/// payer
        /// </summary>		
		private int _payer;
        public int payer
        {
            get{ return _payer; }
            set{ _payer = value; }
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

