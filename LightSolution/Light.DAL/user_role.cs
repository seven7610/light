using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using Light.Command;
using MySql.Data.MySqlClient;
using System.Data;

namespace Light.DAL  
	
{
	 	//user_role
		public partial class user_role
	{
   		     
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from user_role");
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
		public void Add(Light.Model.user_role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into user_role(");			
            strSql.Append("id,userid,roleid,specialty,introducemyself,tip,createman,createtime,executiontimes");
			strSql.Append(") values (");
            strSql.Append("@id,@userid,@roleid,@specialty,@introducemyself,@tip,@createman,@createtime,@executiontimes");            
            strSql.Append(") ");            
            		
			MySqlParameter[] parameters = {
			            new MySqlParameter("@id", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@userid", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@roleid", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@specialty", MySqlDbType.VarChar,500) ,            
                        new MySqlParameter("@introducemyself", MySqlDbType.VarChar,500) ,            
                        new MySqlParameter("@tip", MySqlDbType.Int32,20) ,            
                        new MySqlParameter("@createman", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@createtime", MySqlDbType.DateTime) ,            
                        new MySqlParameter("@executiontimes", MySqlDbType.Int32,10)             
              
            };
			            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.userid;                        
            parameters[2].Value = model.roleid;                        
            parameters[3].Value = model.specialty;                        
            parameters[4].Value = model.introducemyself;                        
            parameters[5].Value = model.tip;                        
            parameters[6].Value = model.createman;                        
            parameters[7].Value = model.createtime;                        
            parameters[8].Value = model.executiontimes;                        
			            DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Light.Model.user_role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update user_role set ");
			                        
            strSql.Append(" id = @id , ");                                    
            strSql.Append(" userid = @userid , ");                                    
            strSql.Append(" roleid = @roleid , ");                                    
            strSql.Append(" specialty = @specialty , ");                                    
            strSql.Append(" introducemyself = @introducemyself , ");                                    
            strSql.Append(" tip = @tip , ");                                    
            strSql.Append(" createman = @createman , ");                                    
            strSql.Append(" createtime = @createtime , ");                                    
            strSql.Append(" executiontimes = @executiontimes  ");            			
			strSql.Append(" where id=@id  ");
						
MySqlParameter[] parameters = {
			            new MySqlParameter("@id", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@userid", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@roleid", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@specialty", MySqlDbType.VarChar,500) ,            
                        new MySqlParameter("@introducemyself", MySqlDbType.VarChar,500) ,            
                        new MySqlParameter("@tip", MySqlDbType.Int32,20) ,            
                        new MySqlParameter("@createman", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@createtime", MySqlDbType.DateTime) ,            
                        new MySqlParameter("@executiontimes", MySqlDbType.Int32,10)             
              
            };
						            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.userid;                        
            parameters[2].Value = model.roleid;                        
            parameters[3].Value = model.specialty;                        
            parameters[4].Value = model.introducemyself;                        
            parameters[5].Value = model.tip;                        
            parameters[6].Value = model.createman;                        
            parameters[7].Value = model.createtime;                        
            parameters[8].Value = model.executiontimes;                        
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
			strSql.Append("delete from user_role ");
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
		public Light.Model.user_role GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id, userid, roleid, specialty, introducemyself, tip, createman, createtime, executiontimes  ");			
			strSql.Append("  from user_role ");
			strSql.Append(" where id=@id ");
						MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10)			};
			parameters[0].Value = id;

			
			Light.Model.user_role model=new Light.Model.user_role();
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
																																if(ds.Tables[0].Rows[0]["roleid"].ToString()!="")
				{
					model.roleid=int.Parse(ds.Tables[0].Rows[0]["roleid"].ToString());
				}
																																				model.specialty= ds.Tables[0].Rows[0]["specialty"].ToString();
																																model.introducemyself= ds.Tables[0].Rows[0]["introducemyself"].ToString();
																												if(ds.Tables[0].Rows[0]["tip"].ToString()!="")
				{
					model.tip=int.Parse(ds.Tables[0].Rows[0]["tip"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["createman"].ToString()!="")
				{
					model.createman=int.Parse(ds.Tables[0].Rows[0]["createman"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["createtime"].ToString()!="")
				{
					model.createtime=DateTime.Parse(ds.Tables[0].Rows[0]["createtime"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["executiontimes"].ToString()!="")
				{
					model.executiontimes=int.Parse(ds.Tables[0].Rows[0]["executiontimes"].ToString());
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
			strSql.Append(" FROM user_role ");
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
			strSql.Append(" FROM user_role ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperMySQL.Query(strSql.ToString());
		}

   
	}
}

