﻿using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;

using Light.Model;
namespace Light.BLL{
	 	//newsinfo
		public partial class newsinfo
	{
   		     
		private readonly Light.DAL.newsinfo dal=new Light.DAL.newsinfo();
		public newsinfo()
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
		public void  Add(Light.Model.newsinfo model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Light.Model.newsinfo model)
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
		public Light.Model.newsinfo GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Light.Model.newsinfo GetModelByCache(int id)
		{
			
			string CacheKey = "newsinfoModel-" + id;
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
			return (Light.Model.newsinfo)objModel;
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
		public List<Light.Model.newsinfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Light.Model.newsinfo> DataTableToList(DataTable dt)
		{
			List<Light.Model.newsinfo> modelList = new List<Light.Model.newsinfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Light.Model.newsinfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Light.Model.newsinfo();					
													if(dt.Rows[n]["id"].ToString()!="")
				{
					model.id=int.Parse(dt.Rows[n]["id"].ToString());
				}
																																				model.title= dt.Rows[n]["title"].ToString();
																																																								model.subtitle= dt.Rows[n]["subtitle"].ToString();
																																												if(dt.Rows[n]["isread"].ToString()!="")
				{
					if((dt.Rows[n]["isread"].ToString()=="1")||(dt.Rows[n]["isread"].ToString().ToLower()=="true"))
					{
					model.isread= true;
					}
					else
					{
					model.isread= false;
					}
				}
																																if(dt.Rows[n]["ishot"].ToString()!="")
				{
					if((dt.Rows[n]["ishot"].ToString()=="1")||(dt.Rows[n]["ishot"].ToString().ToLower()=="true"))
					{
					model.ishot= true;
					}
					else
					{
					model.ishot= false;
					}
				}
																if(dt.Rows[n]["createman"].ToString()!="")
				{
					model.createman=int.Parse(dt.Rows[n]["createman"].ToString());
				}
																																if(dt.Rows[n]["createtime"].ToString()!="")
				{
					model.createtime=DateTime.Parse(dt.Rows[n]["createtime"].ToString());
				}
																										
				
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