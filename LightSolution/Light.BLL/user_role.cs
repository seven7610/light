using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;

using Light.Model;
namespace Light.BLL{
	 	//user_role
		public partial class user_role
	{
   		     
		private readonly Light.DAL.user_role dal=new Light.DAL.user_role();
		public user_role()
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
		public void  Add(Light.Model.user_role model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Light.Model.user_role model)
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
		public Light.Model.user_role GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Light.Model.user_role GetModelByCache(int id)
		{
			
			string CacheKey = "user_roleModel-" + id;
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
			return (Light.Model.user_role)objModel;
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
		public List<Light.Model.user_role> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Light.Model.user_role> DataTableToList(DataTable dt)
		{
			List<Light.Model.user_role> modelList = new List<Light.Model.user_role>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Light.Model.user_role model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Light.Model.user_role();					
													if(dt.Rows[n]["id"].ToString()!="")
				{
					model.id=int.Parse(dt.Rows[n]["id"].ToString());
				}
																																if(dt.Rows[n]["userid"].ToString()!="")
				{
					model.userid=int.Parse(dt.Rows[n]["userid"].ToString());
				}
																																if(dt.Rows[n]["roleid"].ToString()!="")
				{
					model.roleid=int.Parse(dt.Rows[n]["roleid"].ToString());
				}
																																				model.specialty= dt.Rows[n]["specialty"].ToString();
																																model.introducemyself= dt.Rows[n]["introducemyself"].ToString();
																												if(dt.Rows[n]["tip"].ToString()!="")
				{
					model.tip=int.Parse(dt.Rows[n]["tip"].ToString());
				}
																																if(dt.Rows[n]["createman"].ToString()!="")
				{
					model.createman=int.Parse(dt.Rows[n]["createman"].ToString());
				}
																																if(dt.Rows[n]["createtime"].ToString()!="")
				{
					model.createtime=DateTime.Parse(dt.Rows[n]["createtime"].ToString());
				}
																																if(dt.Rows[n]["executiontimes"].ToString()!="")
				{
					model.executiontimes=int.Parse(dt.Rows[n]["executiontimes"].ToString());
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