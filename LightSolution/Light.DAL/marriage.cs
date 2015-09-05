using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using Light.Command;
using MySql.Data.MySqlClient;
using System.Data;

namespace Light.DAL  
	
{
	 	//marriage
		public partial class marriage
	{
   		     
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from marriage");
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
		public void Add(Light.Model.marriage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into marriage(");			
            strSql.Append("id,proposeid,whoid,state,synopsis,proposetime,agreetime,checktime,checkman");
			strSql.Append(") values (");
            strSql.Append("@id,@proposeid,@whoid,@state,@synopsis,@proposetime,@agreetime,@checktime,@checkman");            
            strSql.Append(") ");            
            		
			MySqlParameter[] parameters = {
			            new MySqlParameter("@id", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@proposeid", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@whoid", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@state", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@synopsis", MySqlDbType.VarChar,500) ,            
                        new MySqlParameter("@proposetime", MySqlDbType.DateTime) ,            
                        new MySqlParameter("@agreetime", MySqlDbType.DateTime) ,            
                        new MySqlParameter("@checktime", MySqlDbType.DateTime) ,            
                        new MySqlParameter("@checkman", MySqlDbType.Int32,10)             
              
            };
			            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.proposeid;                        
            parameters[2].Value = model.whoid;                        
            parameters[3].Value = model.state;                        
            parameters[4].Value = model.synopsis;                        
            parameters[5].Value = model.proposetime;                        
            parameters[6].Value = model.agreetime;                        
            parameters[7].Value = model.checktime;                        
            parameters[8].Value = model.checkman;                        
			            DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Light.Model.marriage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update marriage set ");
			                        
            strSql.Append(" id = @id , ");                                    
            strSql.Append(" proposeid = @proposeid , ");                                    
            strSql.Append(" whoid = @whoid , ");                                    
            strSql.Append(" state = @state , ");                                    
            strSql.Append(" synopsis = @synopsis , ");                                    
            strSql.Append(" proposetime = @proposetime , ");                                    
            strSql.Append(" agreetime = @agreetime , ");                                    
            strSql.Append(" checktime = @checktime , ");                                    
            strSql.Append(" checkman = @checkman  ");            			
			strSql.Append(" where id=@id  ");
						
MySqlParameter[] parameters = {
			            new MySqlParameter("@id", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@proposeid", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@whoid", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@state", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@synopsis", MySqlDbType.VarChar,500) ,            
                        new MySqlParameter("@proposetime", MySqlDbType.DateTime) ,            
                        new MySqlParameter("@agreetime", MySqlDbType.DateTime) ,            
                        new MySqlParameter("@checktime", MySqlDbType.DateTime) ,            
                        new MySqlParameter("@checkman", MySqlDbType.Int32,10)             
              
            };
						            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.proposeid;                        
            parameters[2].Value = model.whoid;                        
            parameters[3].Value = model.state;                        
            parameters[4].Value = model.synopsis;                        
            parameters[5].Value = model.proposetime;                        
            parameters[6].Value = model.agreetime;                        
            parameters[7].Value = model.checktime;                        
            parameters[8].Value = model.checkman;                        
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
			strSql.Append("delete from marriage ");
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
		public Light.Model.marriage GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id, proposeid, whoid, state, synopsis, proposetime, agreetime, checktime, checkman  ");			
			strSql.Append("  from marriage ");
			strSql.Append(" where id=@id ");
						MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10)			};
			parameters[0].Value = id;

			
			Light.Model.marriage model=new Light.Model.marriage();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["proposeid"].ToString()!="")
				{
					model.proposeid=int.Parse(ds.Tables[0].Rows[0]["proposeid"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["whoid"].ToString()!="")
				{
					model.whoid=int.Parse(ds.Tables[0].Rows[0]["whoid"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["state"].ToString()!="")
				{
					model.state=int.Parse(ds.Tables[0].Rows[0]["state"].ToString());
				}
																																				model.synopsis= ds.Tables[0].Rows[0]["synopsis"].ToString();
																												if(ds.Tables[0].Rows[0]["proposetime"].ToString()!="")
				{
					model.proposetime=DateTime.Parse(ds.Tables[0].Rows[0]["proposetime"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["agreetime"].ToString()!="")
				{
					model.agreetime=DateTime.Parse(ds.Tables[0].Rows[0]["agreetime"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["checktime"].ToString()!="")
				{
					model.checktime=DateTime.Parse(ds.Tables[0].Rows[0]["checktime"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["checkman"].ToString()!="")
				{
					model.checkman=int.Parse(ds.Tables[0].Rows[0]["checkman"].ToString());
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
			strSql.Append(" FROM marriage ");
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
			strSql.Append(" FROM marriage ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperMySQL.Query(strSql.ToString());
		}

   
	}
}

