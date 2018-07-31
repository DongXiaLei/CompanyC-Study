using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using BFCommonSystem.DAL;


namespace BFCommonSystem.BLL
{
    /// <summary>
    /// 对User表的业务逻辑层
    /// </summary>
    public class UserManager
    {

        ///<param name="strLoginName">登=登陆民</param>
        ///<param name="strLoginpsd">密码</param>
        ///return登陆成功返回true
        public bool Login(string strLoginName,string strLoginpsd)
        {
            try
            {
                //1，调用数据访问层：根据用户名得到用户信息,放回一张表
                DataTable dtUser = UserService.GetUserInfoByUserName\();
                if (dtUser.Rows.Count > 0)
                {
                    DataRow drUser = dtUser.Rows[0];//取到第一行数据
                                                    //把用户信息的密码与表示层的密码进攻对比
                    if (drUser["psd"].Equals(strLoginpsd))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;//用户名不正确
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

    }
}
