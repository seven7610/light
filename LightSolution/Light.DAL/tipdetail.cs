using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using Light.Command;
using MySql.Data.MySqlClient;
using System.Data;

namespace Light.DAL  
	
{
	 	//tipdetail
		public partial class tipdetail
	{
   		     
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tipdetail");
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
		public void Add(Light.Model.tipdetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tipdetail(");			
            strSql.Append("id,sendee,tip,payer,createtime");
			strSql.Append(") values (");
            strSql.Append("@id,@sendee,@tip,@payer,@createtime");            
            strSql.Append(") ");            
            		
			MySqlParameter[] parameters = {
			            new MySqlParameter("@id", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@sendee", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@tip", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@payer", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@createtime", MySqlDbType.DateTime)             
              
            };
			            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.sendee;                        
            parameters[2].Value = model.tip;                        
            parameters[3].Value = model.payer;                        
            parameters[4].Value = model.createtime;                        
			            DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Light.Model.tipdetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tipdetail set ");
			                        
            strSql.Append(" id = @id , ");                                    
            strSql.Append(" sendee = @sendee , ");                                    
            strSql.Append(" tip = @tip , ");                                    
            strSql.Append(" payer = @payer , ");                                    
            strSql.Append(" createtime = @createtime  ");            			
			strSql.Append(" where id=@id  ");
						
MySqlParameter[] parameters = {
			            new MySqlParameter("@id", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@sendee", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@tip", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@payer", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@createtime", MySqlDbType.DateTime)             
              
            };
						            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.sendee;                        
            parameters[2].Value = model.tip;                        
            parameters[3].Value = model.payer;                        
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
			strSql.Append("delete from tipdetail ");
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
		public Light.Model.tipdetail GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id, sendee, tip, payer, createtime  ");			
			strSql.Append("  from tipdetail ");
			strSql.Append(" where id=@id ");
						MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10)			};
			parameters[0].Value = id;

			
			Light.Model.tipdetail model=new Light.Model.tipdetail();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["sendee"].ToString()!="")
				{
					model.sendee=int.Parse(ds.Tables[0].Rows[0]["sendee"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["tip"].ToString()!="")
				{
					model.tip=int.Parse(ds.Tables[0].Rows[0]["tip"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["payer"].ToString()!="")
				{
					model.payer=int.Parse(ds.Tables[0].Rows[0]["payer"].ToString());
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
			strSql.Append(" FROM tipdetail ");
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
			strSql.Append(" FROM tipdetail ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperMySQL.Query(strSql.ToString());
		}

   
	}
}

