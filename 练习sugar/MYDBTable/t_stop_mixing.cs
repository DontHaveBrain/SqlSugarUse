using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///底料控制
    ///</summary>
    public partial class t_stop_mixing
    {
           public t_stop_mixing(){

            this.create_time =DateTime.Now;

           }
           /// <summary>
           /// Desc:主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:配方id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int recipe_id {get;set;}

           /// <summary>
           /// Desc:步骤名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string step_name {get;set;}

           /// <summary>
           /// Desc:分钟
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int stop_minute {get;set;}

           /// <summary>
           /// Desc:秒
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int stop_second {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? create_time {get;set;}

    }
}
