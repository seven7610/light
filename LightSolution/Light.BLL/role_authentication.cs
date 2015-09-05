using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;

using Light.Model;
namespace Light.BLL{
	 	//role_authentication
		public partial class role_authentication
	{
   		     
		private readonly Light.DAL.role_authentication dal=new Light.DAL.role_authentication();
		public role_authentication()
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
		public void  Add(Light.Model.role_authentication model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Light.Model.role_authentication model)
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
		public Light.Model.role_authentication GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Light.Model.role_authentication GetModelByCache(int id)
		{
			
			string CacheKey = "role_authenticationModel-" + id;
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
			return (Light.Model.role_authentication)objModel;
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
		public List<Light.Model.role_authentication> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Light.Model.role_authentication> DataTableToList(DataTable dt)
		{
			List<Light.Model.role_authentication> modelList = new List<Light.Model.role_authentication>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Light.Model.role_authentication model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Light.Model.role_authentication();					
													if(dt.Rows[n]["id"].ToString()!="")
				{
					model.id=int.Parse(dt.Rows[n]["id"].ToString());
				}
																																if(dt.Rows[n]["roleid"].ToString()!="")
				{
					model.roleid=int.Parse(dt.Rows[n]["roleid"].ToString());
				}
																																if(dt.Rows[n]["authenticationid"].ToString()!="")
				{
					model.authenticationid=int.Parse(dt.Rows[n]["authenticationid"].ToString());
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