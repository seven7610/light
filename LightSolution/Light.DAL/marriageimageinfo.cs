﻿using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using Light.Command;
using MySql.Data.MySqlClient;
using System.Data;
namespace Light.DAL  
	
{
	 	//marriageimageinfo
		public partial class marriageimageinfo
	{
   		     
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from marriageimageinfo");
			strSql.Append(" where ");
			                                       strSql.Append(" id = @id  ");
                            			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10)			};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Light.Model.marriageimageinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into marriageimageinfo(");			
            strSql.Append("id,url,marriageid,createman,createtime");
			strSql.Append(") values (");
            strSql.Append("@id,@url,@marriageid,@createman,@createtime");            
            strSql.Append(") ");            
            		
			MySqlParameter[] parameters = {
			            new MySqlParameter("@id", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@url", MySqlDbType.VarChar,500) ,            
                        new MySqlParameter("@marriageid", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@createman", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@createtime", MySqlDbType.DateTime)             
              
            };
			            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.url;                        
            parameters[2].Value = model.marriageid;                        
            parameters[3].Value = model.createman;                        
            parameters[4].Value = model.createtime;                        
			            DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Light.Model.marriageimageinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update marriageimageinfo set ");
			                        
            strSql.Append(" id = @id , ");                                    
            strSql.Append(" url = @url , ");                                    
            strSql.Append(" marriageid = @marriageid , ");                                    
            strSql.Append(" createman = @createman , ");                                    
            strSql.Append(" createtime = @createtime  ");            			
			strSql.Append(" where id=@id  ");
						
MySqlParameter[] parameters = {
			            new MySqlParameter("@id", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@url", MySqlDbType.VarChar,500) ,            
                        new MySqlParameter("@marriageid", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@createman", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@createtime", MySqlDbType.DateTime)             
              
            };
						            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.url;                        
            parameters[2].Value = model.marriageid;                        
            parameters[3].Value = model.createman;                        
            parameters[4].Value = model.createtime;                        
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
			strSql.Append("delete from marriageimageinfo ");
			strSql.Append(" where id=@id ");
						MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10)			};
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
		/// 得到一个对象实体
		/// </summary>
		public Light.Model.marriageimageinfo GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id, url, marriageid, createman, createtime  ");			
			strSql.Append("  from marriageimageinfo ");
			strSql.Append(" where id=@id ");
						MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10)			};
			parameters[0].Value = id;

			
			Light.Model.marriageimageinfo model=new Light.Model.marriageimageinfo();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
																																				model.url= ds.Tables[0].Rows[0]["url"].ToString();
																												if(ds.Tables[0].Rows[0]["marriageid"].ToString()!="")
				{
					model.marriageid=int.Parse(ds.Tables[0].Rows[0]["marriageid"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["createman"].ToString()!="")
				{
					model.createman=int.Parse(ds.Tables[0].Rows[0]["createman"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["createtime"].ToString()!="")
				{
					model.createtime=DateTime.Parse(ds.Tables[0].Rows[0]["createtime"].ToString());
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
			strSql.Append(" FROM marriageimageinfo ");
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
			strSql.Append(" FROM marriageimageinfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperMySQL.Query(strSql.ToString());
		}

   
	}
}

