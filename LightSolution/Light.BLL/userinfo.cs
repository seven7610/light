using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;

using Light.Model;
namespace Light.BLL{
	 	//userinfo
		public partial class userinfo
	{
   		     
		private readonly Light.DAL.userinfo dal=new Light.DAL.userinfo();
		public userinfo()
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
		public void  Add(Light.Model.userinfo model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Light.Model.userinfo model)
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
		public Light.Model.userinfo GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Light.Model.userinfo GetModelByCache(int id)
		{
			
			string CacheKey = "userinfoModel-" + id;
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
			return (Light.Model.userinfo)objModel;
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
		public List<Light.Model.userinfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Light.Model.userinfo> DataTableToList(DataTable dt)
		{
			List<Light.Model.userinfo> modelList = new List<Light.Model.userinfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Light.Model.userinfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Light.Model.userinfo();					
													if(dt.Rows[n]["id"].ToString()!="")
				{
					model.id=int.Parse(dt.Rows[n]["id"].ToString());
				}
																																				model.phone= dt.Rows[n]["phone"].ToString();
																																model.email= dt.Rows[n]["email"].ToString();
																																model.qqid= dt.Rows[n]["qqid"].ToString();
																																model.weiboid= dt.Rows[n]["weiboid"].ToString();
																																model.password= dt.Rows[n]["password"].ToString();
																																model.username= dt.Rows[n]["username"].ToString();
																																model.sex= dt.Rows[n]["sex"].ToString();
																																model.gender= dt.Rows[n]["gender"].ToString();
																												if(dt.Rows[n]["createtime"].ToString()!="")
				{
					model.createtime=DateTime.Parse(dt.Rows[n]["createtime"].ToString());
				}
																																if(dt.Rows[n]["logincount"].ToString()!="")
				{
					model.logincount=int.Parse(dt.Rows[n]["logincount"].ToString());
				}
																																if(dt.Rows[n]["lastlogintime"].ToString()!="")
				{
					model.lastlogintime=DateTime.Parse(dt.Rows[n]["lastlogintime"].ToString());
				}
																																				model.userid= dt.Rows[n]["userid"].ToString();
																												if(dt.Rows[n]["birthday"].ToString()!="")
				{
					model.birthday=DateTime.Parse(dt.Rows[n]["birthday"].ToString());
				}
																																if(dt.Rows[n]["cityid"].ToString()!="")
				{
					model.cityid=int.Parse(dt.Rows[n]["cityid"].ToString());
				}
																																if(dt.Rows[n]["roleid"].ToString()!="")
				{
					model.roleid=int.Parse(dt.Rows[n]["roleid"].ToString());
				}
																																				model.loginvalidate= dt.Rows[n]["loginvalidate"].ToString();
																																model.faceurl= dt.Rows[n]["faceurl"].ToString();
																												if(dt.Rows[n]["state"].ToString()!="")
				{
					model.state=int.Parse(dt.Rows[n]["state"].ToString());
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