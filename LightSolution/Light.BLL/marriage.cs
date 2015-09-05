using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;

using Light.Model;
namespace Light.BLL{
	 	//marriage
		public partial class marriage
	{
   		     
		private readonly Light.DAL.marriage dal=new Light.DAL.marriage();
		public marriage()
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
		public void  Add(Light.Model.marriage model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Light.Model.marriage model)
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
		public Light.Model.marriage GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Light.Model.marriage GetModelByCache(int id)
		{
			
			string CacheKey = "marriageModel-" + id;
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
			return (Light.Model.marriage)objModel;
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
		public List<Light.Model.marriage> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Light.Model.marriage> DataTableToList(DataTable dt)
		{
			List<Light.Model.marriage> modelList = new List<Light.Model.marriage>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Light.Model.marriage model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Light.Model.marriage();					
													if(dt.Rows[n]["id"].ToString()!="")
				{
					model.id=int.Parse(dt.Rows[n]["id"].ToString());
				}
																																if(dt.Rows[n]["proposeid"].ToString()!="")
				{
					model.proposeid=int.Parse(dt.Rows[n]["proposeid"].ToString());
				}
																																if(dt.Rows[n]["whoid"].ToString()!="")
				{
					model.whoid=int.Parse(dt.Rows[n]["whoid"].ToString());
				}
																																if(dt.Rows[n]["state"].ToString()!="")
				{
					model.state=int.Parse(dt.Rows[n]["state"].ToString());
				}
																																				model.synopsis= dt.Rows[n]["synopsis"].ToString();
																												if(dt.Rows[n]["proposetime"].ToString()!="")
				{
					model.proposetime=DateTime.Parse(dt.Rows[n]["proposetime"].ToString());
				}
																																if(dt.Rows[n]["agreetime"].ToString()!="")
				{
					model.agreetime=DateTime.Parse(dt.Rows[n]["agreetime"].ToString());
				}
																																if(dt.Rows[n]["checktime"].ToString()!="")
				{
					model.checktime=DateTime.Parse(dt.Rows[n]["checktime"].ToString());
				}
																																if(dt.Rows[n]["checkman"].ToString()!="")
				{
					model.checkman=int.Parse(dt.Rows[n]["checkman"].ToString());
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