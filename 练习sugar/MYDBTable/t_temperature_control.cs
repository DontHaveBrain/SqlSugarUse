using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///温度控制表
    ///</summary>
    public partial class t_temperature_control
    {
           public t_temperature_control(){

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
           /// Desc:稀土总量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public double total_rare_earth {get;set;}

           /// <summary>
           /// Desc:控制模式
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? control_mode {get;set;}

           /// <summary>
           /// Desc:液位点位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string liquid_level_point {get;set;}

           /// <summary>
           /// Desc:液位最小值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? liquid_level_min {get;set;}

           /// <summary>
           /// Desc:液位最大值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? liquid_level_max {get;set;}

           /// <summary>
           /// Desc:温度计点位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string temperature_point {get;set;}

           /// <summary>
           /// Desc:温度最小值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? temperature_min {get;set;}

           /// <summary>
           /// Desc:温度最大值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? temperature_max {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? create_time {get;set;}

    }
}
