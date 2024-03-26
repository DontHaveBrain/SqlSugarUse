using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///用户信息表
    ///</summary>
    public partial class t_user
    {
           public t_user(){

            this.status =Convert.ToByte("0");
            this.created_at =DateTime.Now;

           }
           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int user_id {get;set;}

           /// <summary>
           /// Desc:用户名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string username {get;set;}

           /// <summary>
           /// Desc:姓名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string full_name {get;set;}

           /// <summary>
           /// Desc:工号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string employee_id {get;set;}

           /// <summary>
           /// Desc:工号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string password {get;set;}

           /// <summary>
           /// Desc:联系方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string phone {get;set;}

           /// <summary>
           /// Desc:权限角色id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? permission_role_id {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? status {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? created_at {get;set;}

    }
}
