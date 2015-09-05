using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;

using Light.Model;
namespace Light.BLL{
	 	//user_im
		public partial class user_im
	{
   		     
		private readonly Light.DAL.user_im dal=new Light.DAL.user_im();
		public user_im()
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
		public int  Add(Light.Model.user_im model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Light.Model.user_im model)
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
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			return dal.DeleteList(idlist );
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Light.Model.user_im GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Light.Model.user_im GetModelByCache(int id)
		{
			
			string CacheKey = "user_imModel-" + id;
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
			return (Light.Model.user_im)objModel;
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
		public List<Light.Model.user_im> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Light.Model.user_im> DataTableToList(DataTable dt)
		{
			List<Light.Model.user_im> modelList = new List<Light.Model.user_im>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Light.Model.user_im model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Light.Model.user_im();					
													if(dt.Rows[n]["id"].ToString()!="")
				{
					model.id=int.Parse(dt.Rows[n]["id"].ToString());
				}
																																if(dt.Rows[n]["userid"].ToString()!="")
				{
					model.userid=int.Parse(dt.Rows[n]["userid"].ToString());
				}
																																				model.imtoken= dt.Rows[n]["imtoken"].ToString();
																												if(dt.Rows[n]["create_time"].ToString()!="")
				{
					model.create_time=long.Parse(dt.Rows[n]["create_time"].ToString());
				}
																																if(dt.Rows[n]["update_time"].ToString()!="")
				{
					model.update_time=long.Parse(dt.Rows[n]["update_time"].ToString());
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