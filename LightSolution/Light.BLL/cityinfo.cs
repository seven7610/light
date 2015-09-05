using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;

using Light.Model;
namespace Light.BLL{
	 	//cityinfo
		public partial class cityinfo
	{
   		     
		private readonly Light.DAL.cityinfo dal=new Light.DAL.cityinfo();
		public cityinfo()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(Light.Model.cityinfo model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Light.Model.cityinfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			return dal.Delete(id);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Light.Model.cityinfo GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Light.Model.cityinfo GetModelByCache(int id)
		{
			
			string CacheKey = "cityinfoModel-" + id;
			object objModel = Lovell.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(id);
					if (objModel != null)
					{
						int ModelCache = Lovell.Common.ConfigHelper.GetConfigInt("ModelCache");
						Lovell.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Light.Model.cityinfo)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Light.Model.cityinfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Light.Model.cityinfo> DataTableToList(DataTable dt)
		{
			List<Light.Model.cityinfo> modelList = new List<Light.Model.cityinfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Light.Model.cityinfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Light.Model.cityinfo();					
													if(dt.Rows[n]["id"].ToString()!="")
				{
					model.id=int.Parse(dt.Rows[n]["id"].ToString());
				}
																																if(dt.Rows[n]["regionid"].ToString()!="")
				{
					model.regionid=int.Parse(dt.Rows[n]["regionid"].ToString());
				}
																																				model.cityname= dt.Rows[n]["cityname"].ToString();
																												if(dt.Rows[n]["creatman"].ToString()!="")
				{
					model.creatman=int.Parse(dt.Rows[n]["creatman"].ToString());
				}
																																if(dt.Rows[n]["creattime"].ToString()!="")
				{
					model.creattime=DateTime.Parse(dt.Rows[n]["creattime"].ToString());
				}
																																				model.remark= dt.Rows[n]["remark"].ToString();
																						
				
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
#endregion
   
	}
}