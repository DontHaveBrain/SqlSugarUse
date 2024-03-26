using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///设备参数表
    ///</summary>
    public partial class t_device_parameters
    {
           public t_device_parameters(){

            this.created_time =DateTime.Now;

           }
           /// <summary>
           /// Desc:参数ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int parameter_id {get;set;}

           /// <summary>
           /// Desc:工艺设备
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string equipment_name {get;set;}

           /// <summary>
           /// Desc:车间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string workshop {get;set;}

           /// <summary>
           /// Desc:参数名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string parameter_name {get;set;}

           /// <summary>
           /// Desc:当前值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? current_value {get;set;}

           /// <summary>
           /// Desc:单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string unit {get;set;}

           /// <summary>
           /// Desc:最低阈值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? min_threshold {get;set;}

           /// <summary>
           /// Desc:最高阈值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? max_threshold {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string status {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? created_time {get;set;}

    }
}
