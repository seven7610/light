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
	 	//userinfo
		public partial class userinfo
	{
   		     
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from userinfo");
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
		public void Add(Light.Model.userinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into userinfo(");			
            strSql.Append("id,phone,email,qqid,weiboid,password,username,sex,gender,createtime,logincount,lastlogintime,userid,birthday,cityid,roleid,loginvalidate,faceurl,state");
			strSql.Append(") values (");
            strSql.Append("@id,@phone,@email,@qqid,@weiboid,@password,@username,@sex,@gender,@createtime,@logincount,@lastlogintime,@userid,@birthday,@cityid,@roleid,@loginvalidate,@faceurl,@state");            
            strSql.Append(") ");            
            		
			MySqlParameter[] parameters = {
			            new MySqlParameter("@id", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@phone", MySqlDbType.VarChar,20) ,            
                        new MySqlParameter("@email", MySqlDbType.VarChar,50) ,            
                        new MySqlParameter("@qqid", MySqlDbType.VarChar,30) ,            
                        new MySqlParameter("@weiboid", MySqlDbType.VarChar,30) ,            
                        new MySqlParameter("@password", MySqlDbType.VarChar,50) ,            
                        new MySqlParameter("@username", MySqlDbType.VarChar,50) ,            
                        new MySqlParameter("@sex", MySqlDbType.VarChar,10) ,            
                        new MySqlParameter("@gender", MySqlDbType.VarChar,10) ,            
                        new MySqlParameter("@createtime", MySqlDbType.DateTime) ,            
                        new MySqlParameter("@logincount", MySqlDbType.Int32,20) ,            
                        new MySqlParameter("@lastlogintime", MySqlDbType.DateTime) ,            
                        new MySqlParameter("@userid", MySqlDbType.VarChar,20) ,            
                        new MySqlParameter("@birthday", MySqlDbType.DateTime) ,            
                        new MySqlParameter("@cityid", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@roleid", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@loginvalidate", MySqlDbType.VarChar,10) ,            
                        new MySqlParameter("@faceurl", MySqlDbType.VarChar,300) ,            
                        new MySqlParameter("@state", MySqlDbType.Int32,10)             
              
            };
			            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.phone;                        
            parameters[2].Value = model.email;                        
            parameters[3].Value = model.qqid;                        
            parameters[4].Value = model.weiboid;                        
            parameters[5].Value = model.password;                        
            parameters[6].Value = model.username;                        
            parameters[7].Value = model.sex;                        
            parameters[8].Value = model.gender;                        
            parameters[9].Value = model.createtime;                        
            parameters[10].Value = model.logincount;                        
            parameters[11].Value = model.lastlogintime;                        
            parameters[12].Value = model.userid;                        
            parameters[13].Value = model.birthday;                        
            parameters[14].Value = model.cityid;                        
            parameters[15].Value = model.roleid;                        
            parameters[16].Value = model.loginvalidate;                        
            parameters[17].Value = model.faceurl;                        
            parameters[18].Value = model.state;                        
			            DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Light.Model.userinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update userinfo set ");
			                        
            strSql.Append(" id = @id , ");                                    
            strSql.Append(" phone = @phone , ");                                    
            strSql.Append(" email = @email , ");                                    
            strSql.Append(" qqid = @qqid , ");                                    
            strSql.Append(" weiboid = @weiboid , ");                                    
            strSql.Append(" password = @password , ");                                    
            strSql.Append(" username = @username , ");                                    
            strSql.Append(" sex = @sex , ");                                    
            strSql.Append(" gender = @gender , ");                                    
            strSql.Append(" createtime = @createtime , ");                                    
            strSql.Append(" logincount = @logincount , ");                                    
            strSql.Append(" lastlogintime = @lastlogintime , ");                                    
            strSql.Append(" userid = @userid , ");                                    
            strSql.Append(" birthday = @birthday , ");                                    
            strSql.Append(" cityid = @cityid , ");                                    
            strSql.Append(" roleid = @roleid , ");                                    
            strSql.Append(" loginvalidate = @loginvalidate , ");                                    
            strSql.Append(" faceurl = @faceurl , ");                                    
            strSql.Append(" state = @state  ");            			
			strSql.Append(" where id=@id  ");
						
MySqlParameter[] parameters = {
			            new MySqlParameter("@id", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@phone", MySqlDbType.VarChar,20) ,            
                        new MySqlParameter("@email", MySqlDbType.VarChar,50) ,            
                        new MySqlParameter("@qqid", MySqlDbType.VarChar,30) ,            
                        new MySqlParameter("@weiboid", MySqlDbType.VarChar,30) ,            
                        new MySqlParameter("@password", MySqlDbType.VarChar,50) ,            
                        new MySqlParameter("@username", MySqlDbType.VarChar,50) ,            
                        new MySqlParameter("@sex", MySqlDbType.VarChar,10) ,            
                        new MySqlParameter("@gender", MySqlDbType.VarChar,10) ,            
                        new MySqlParameter("@createtime", MySqlDbType.DateTime) ,            
                        new MySqlParameter("@logincount", MySqlDbType.Int32,20) ,            
                        new MySqlParameter("@lastlogintime", MySqlDbType.DateTime) ,            
                        new MySqlParameter("@userid", MySqlDbType.VarChar,20) ,            
                        new MySqlParameter("@birthday", MySqlDbType.DateTime) ,            
                        new MySqlParameter("@cityid", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@roleid", MySqlDbType.Int32,10) ,            
                        new MySqlParameter("@loginvalidate", MySqlDbType.VarChar,10) ,            
                        new MySqlParameter("@faceurl", MySqlDbType.VarChar,300) ,            
                        new MySqlParameter("@state", MySqlDbType.Int32,10)             
              
            };
						            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.phone;                        
            parameters[2].Value = model.email;                        
            parameters[3].Value = model.qqid;                        
            parameters[4].Value = model.weiboid;                        
            parameters[5].Value = model.password;                        
            parameters[6].Value = model.username;                        
            parameters[7].Value = model.sex;                        
            parameters[8].Value = model.gender;                        
            parameters[9].Value = model.createtime;                        
            parameters[10].Value = model.logincount;                        
            parameters[11].Value = model.lastlogintime;                        
            parameters[12].Value = model.userid;                        
            parameters[13].Value = model.birthday;                        
            parameters[14].Value = model.cityid;                        
            parameters[15].Value = model.roleid;                        
            parameters[16].Value = model.loginvalidate;                        
            parameters[17].Value = model.faceurl;                        
            parameters[18].Value = model.state;                        
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
			strSql.Append("delete from userinfo ");
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
		public Light.Model.userinfo GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id, phone, email, qqid, weiboid, password, username, sex, gender, createtime, logincount, lastlogintime, userid, birthday, cityid, roleid, loginvalidate, faceurl, state  ");			
			strSql.Append("  from userinfo ");
			strSql.Append(" where id=@id ");
						MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10)			};
			parameters[0].Value = id;

			
			Light.Model.userinfo model=new Light.Model.userinfo();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
																																				model.phone= ds.Tables[0].Rows[0]["phone"].ToString();
																																model.email= ds.Tables[0].Rows[0]["email"].ToString();
																																model.qqid= ds.Tables[0].Rows[0]["qqid"].ToString();
																																model.weiboid= ds.Tables[0].Rows[0]["weiboid"].ToString();
																																model.password= ds.Tables[0].Rows[0]["password"].ToString();
																																model.username= ds.Tables[0].Rows[0]["username"].ToString();
																																model.sex= ds.Tables[0].Rows[0]["sex"].ToString();
																																model.gender= ds.Tables[0].Rows[0]["gender"].ToString();
																												if(ds.Tables[0].Rows[0]["createtime"].ToString()!="")
				{
					model.createtime=DateTime.Parse(ds.Tables[0].Rows[0]["createtime"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["logincount"].ToString()!="")
				{
					model.logincount=int.Parse(ds.Tables[0].Rows[0]["logincount"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["lastlogintime"].ToString()!="")
				{
					model.lastlogintime=DateTime.Parse(ds.Tables[0].Rows[0]["lastlogintime"].ToString());
				}
																																				model.userid= ds.Tables[0].Rows[0]["userid"].ToString();
																												if(ds.Tables[0].Rows[0]["birthday"].ToString()!="")
				{
					model.birthday=DateTime.Parse(ds.Tables[0].Rows[0]["birthday"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["cityid"].ToString()!="")
				{
					model.cityid=int.Parse(ds.Tables[0].Rows[0]["cityid"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["roleid"].ToString()!="")
				{
					model.roleid=int.Parse(ds.Tables[0].Rows[0]["roleid"].ToString());
				}
																																				model.loginvalidate= ds.Tables[0].Rows[0]["loginvalidate"].ToString();
																																model.faceurl= ds.Tables[0].Rows[0]["faceurl"].ToString();
																												if(ds.Tables[0].Rows[0]["state"].ToString()!="")
				{
					model.state=int.Parse(ds.Tables[0].Rows[0]["state"].ToString());
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
			strSql.Append(" FROM userinfo ");
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
			strSql.Append(" FROM userinfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperMySQL.Query(strSql.ToString());
		}

   
	}
}

