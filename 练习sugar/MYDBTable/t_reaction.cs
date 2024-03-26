using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///最终反应阶段
    ///</summary>
    public partial class t_reaction
    {
           public t_reaction(){

            this.control_mode =Convert.ToByte("0");
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
           /// Desc:顺序
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int reaction_index {get;set;}

           /// <summary>
           /// Desc:控制模式
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? control_mode {get;set;}

           /// <summary>
           /// Desc:稀土流速值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? velocity_of_flow_value {get;set;}

           /// <summary>
           /// Desc:草酸系数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string coefficient {get;set;}

           /// <summary>
           /// Desc:时
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? reaction_hour {get;set;}

           /// <summary>
           /// Desc:分钟
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? reaction_minute {get;set;}

           /// <summary>
           /// Desc:秒
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? reaction_second {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? create_time {get;set;}

    }
}
