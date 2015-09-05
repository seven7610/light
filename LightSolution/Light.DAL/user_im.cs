using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using MySql.Data.MySqlClient;
using Light.Command;
using System.Data;

namespace Light.DAL  
	
{
	 	//user_im
		public partial class user_im
	{
   		     
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from user_im");
			strSql.Append(" where ");
			                                       strSql.Append(" id = @id  ");
                            			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Light.Model.user_im model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into user_im(");			
            strSql.Append("userid,imtoken,create_time,update_time");
			strSql.Append(") values (");
            strSql.Append("@userid,@imtoken,@create_time,@update_time");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			MySqlParameter[] parameters = {
			            new MySqlParameter("@userid", MySqlDbType.Int32,11) ,            
                        new MySqlParameter("@imtoken", MySqlDbType.VarChar,256) ,            
                        new MySqlParameter("@create_time", MySqlDbType.DateTime,13) ,            
                        new MySqlParameter("@update_time", MySqlDbType.DateTime,13)             
              
            };
			            
            parameters[0].Value = model.userid;                        
            parameters[1].Value = model.imtoken;                        
            parameters[2].Value = model.create_time;                        
            parameters[3].Value = model.update_time;                        
			   
			object obj = DbHelperMySQL.GetSingle(strSql.ToString(),parameters);			
			if (obj == null)
			{
				return 0;
			}
			else
			{
				                    
            	return Convert.ToInt32(obj);
                                                                  
			}			   
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Light.Model.user_im model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update user_im set ");
			                                                
            strSql.Append(" userid = @userid , ");                                    
            strSql.Append(" imtoken = @imtoken , ");                                    
            strSql.Append(" create_time = @create_time , ");                                    
            strSql.Append(" update_time = @update_time  ");            			
			strSql.Append(" where id=@id ");
						
MySqlParameter[] parameters = {
			            new MySqlParameter("@id", MySqlDbType.Int32,11) ,            
                        new MySqlParameter("@userid", MySqlDbType.Int32,11) ,            
                        new MySqlParameter("@imtoken", MySqlDbType.VarChar,256) ,            
                        new MySqlParameter("@create_time", MySqlDbType.DateTime,13) ,            
                        new MySqlParameter("@update_time", MySqlDbType.DateTime,13)             
              
            };
						            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.userid;                        
            parameters[2].Value = model.imtoken;                        
            parameters[3].Value = model.create_time;                        
            parameters[4].Value = model.update_time;                        
            int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from user_im ");
			strSql.Append(" where id=@id");
						MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;


			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from user_im ");
			strSql.Append(" where ID in ("+idlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
				
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Light.Model.user_im GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id, userid, imtoken, create_time, update_time  ");			
			strSql.Append("  from user_im ");
			strSql.Append(" where id=@id");
						MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			
			Light.Model.user_im model=new Light.Model.user_im();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["userid"].ToString()!="")
				{
					model.userid=int.Parse(ds.Tables[0].Rows[0]["userid"].ToString());
				}
																																				model.imtoken= ds.Tables[0].Rows[0]["imtoken"].ToString();
																												if(ds.Tables[0].Rows[0]["create_time"].ToString()!="")
				{
					model.create_time=long.Parse(ds.Tables[0].Rows[0]["create_time"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["update_time"].ToString()!="")
				{
					model.update_time=long.Parse(ds.Tables[0].Rows[0]["update_time"].ToString());
				}
																														
				return model;
			}
			else
			{
				return null;
			}
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM user_im ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" * ");
			strSql.Append(" FROM user_im ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperMySQL.Query(strSql.ToString());
		}

   
	}
}

