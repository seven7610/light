﻿using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using Light.Command;
using MySql.Data.MySqlClient;
using System.Data;

namespace Light.DAL  
	
{
	 	//regioninfo
		public partial class regioninfo
	{
   		     
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from regioninfo");
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
		public void Add(Light.Model.regioninfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into regioninfo(");			
            strSql.Append("id,countryid,regionname,creatman,creattime,remark");
			strSql.Append(") values (");
            strSql.Append("@id,@countryid,@regionname,@creatman,@creattime,@remark");            
            strSql.Append(") ");            
            		
			MySqlParameter[] parameters = {
			            new MySqlParameter("@id", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@countryid", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@regionname", MySqlDbType.VarChar,10) ,            
                        new MySqlParameter("@creatman", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@creattime", MySqlDbType.DateTime) ,            
                        new MySqlParameter("@remark", MySqlDbType.VarChar,200)             
              
            };
			            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.countryid;                        
            parameters[2].Value = model.regionname;                        
            parameters[3].Value = model.creatman;                        
            parameters[4].Value = model.creattime;                        
            parameters[5].Value = model.remark;                        
			            DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Light.Model.regioninfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update regioninfo set ");
			                        
            strSql.Append(" id = @id , ");                                    
            strSql.Append(" countryid = @countryid , ");                                    
            strSql.Append(" regionname = @regionname , ");                                    
            strSql.Append(" creatman = @creatman , ");                                    
            strSql.Append(" creattime = @creattime , ");                                    
            strSql.Append(" remark = @remark  ");            			
			strSql.Append(" where id=@id  ");
						
MySqlParameter[] parameters = {
			            new MySqlParameter("@id", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@countryid", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@regionname", MySqlDbType.VarChar,10) ,            
                        new MySqlParameter("@creatman", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@creattime", MySqlDbType.DateTime) ,            
                        new MySqlParameter("@remark", MySqlDbType.VarChar,200)             
              
            };
						            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.countryid;                        
            parameters[2].Value = model.regionname;                        
            parameters[3].Value = model.creatman;                        
            parameters[4].Value = model.creattime;                        
            parameters[5].Value = model.remark;                        
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
			strSql.Append("delete from regioninfo ");
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
		public Light.Model.regioninfo GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id, countryid, regionname, creatman, creattime, remark  ");			
			strSql.Append("  from regioninfo ");
			strSql.Append(" where id=@id ");
						MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10)			};
			parameters[0].Value = id;

			
			Light.Model.regioninfo model=new Light.Model.regioninfo();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["countryid"].ToString()!="")
				{
					model.countryid=int.Parse(ds.Tables[0].Rows[0]["countryid"].ToString());
				}
																																				model.regionname= ds.Tables[0].Rows[0]["regionname"].ToString();
																												if(ds.Tables[0].Rows[0]["creatman"].ToString()!="")
				{
					model.creatman=int.Parse(ds.Tables[0].Rows[0]["creatman"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["creattime"].ToString()!="")
				{
					model.creattime=DateTime.Parse(ds.Tables[0].Rows[0]["creattime"].ToString());
				}
																																				model.remark= ds.Tables[0].Rows[0]["remark"].ToString();
																										
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
			strSql.Append(" FROM regioninfo ");
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
			strSql.Append(" FROM regioninfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperMySQL.Query(strSql.ToString());
		}

   
	}
}

