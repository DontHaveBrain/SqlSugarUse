using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///权限角色列表
    ///</summary>
    public partial class t_permission_role
    {
           public t_permission_role(){


           }
           /// <summary>
           /// Desc:ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:角色名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string role_name {get;set;}

           /// <summary>
           /// Desc:用户数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int user_count {get;set;}

           /// <summary>
           /// Desc:权限
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string permission {get;set;}

           /// <summary>
           /// Desc:角色状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte role_status {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remarks {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? created_time {get;set;}

    }
}
