using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LightAppinterface
{
    /// <summary>
    /// LightApp 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class LightApp : System.Web.Services.WebService
    {

        public void ToJsonResponse(object parm)
        {
            Light.Command.JsonData jsonData = new Light.Command.JsonData();
            jsonData.obj = parm;
            Context.Response.ContentType = "text/json; charset=utf-8";
            string returnValue = JsonConvert.SerializeObject(jsonData);
            string a = "";
            returnValue = returnValue.Replace("null", '"' + a + '"');
           
            Context.Response.Write(returnValue);
            Context.Response.End();
        }

        /// <summary>
        /// 用户名不存在
        /// </summary>
        public void UserNotExistJson()
        {
            Light.Command.JsonData jsonData = new Light.Command.JsonData();
            jsonData.obj = "";
            jsonData.result_code = 1;
            jsonData.result_msg = "用户不存在，请联系管理员";
            jsonData.sys_code = 1;
            jsonData.sys_msg = "用户不存在，请联系管理员";
            Context.Response.ContentType = "text/json; charset=utf-8";
            Context.Response.Write(JsonConvert.SerializeObject(jsonData));
            Context.Response.End();
        }
        
        /// <summary>
        /// 用户名密码错误
        /// </summary>
        public void UserNoLoginJson()
        {
            Light.Command.JsonData jsonData = new Light.Command.JsonData();
            jsonData.obj = "";
            jsonData.result_code = 1;
            jsonData.result_msg = "用户名密码错误";
            jsonData.sys_code = 1;
            jsonData.sys_msg = "用户名密码错误";
            Context.Response.ContentType = "text/json; charset=utf-8";
            Context.Response.Write(JsonConvert.SerializeObject(jsonData));
            Context.Response.End();
        }


        [WebMethod(Description = "登录")]
        public void login(string code, string pwd)
        {
            Light.BLL.userinfo userInfoBLL = new Light.BLL.userinfo();
            Light.Command.Validate validate = new Light.Command.Validate();
            List<Light.Model.userinfo> userInfoModelList= new List<Light.Model.userinfo>();
            string rdUserSessionID = "";
            if (validate.IsMoblieNumber(code))
                userInfoModelList = userInfoBLL.GetModelList(" phone='" + code + "'");
            else if(validate.IsEmail(code))
                userInfoModelList = userInfoBLL.GetModelList(" email='" + code + "'");

            if (userInfoModelList.Count <= 0)//用户不存在
            {
                UserNotExistJson();
                return;
            }
            Light.Model.userinfo userinfo = userInfoModelList[0];
            if (userinfo.password != pwd) //用户密码错误
            {
                UserNoLoginJson();
                return;
            }

            Random r = new Random();
            rdUserSessionID = r.Next(1, 999999).ToString();
            userinfo.loginidentification = rdUserSessionID;
            userInfoBLL.Update(userinfo);
            Light.Model.UserModelAPP userapp = new Light.Model.UserModelAPP();
            userapp.avatar = userinfo.faceurl;
            userapp.email = userinfo.email;
            userapp.name = userinfo.username;
            userapp.physiology_society_gender = userinfo.sex;
            userapp.society_gender = userinfo.gender;
            userapp.tel = userinfo.phone;
            userapp.userid = userinfo.userid;
            ToJsonResponse(userapp);
        }
    }
}
