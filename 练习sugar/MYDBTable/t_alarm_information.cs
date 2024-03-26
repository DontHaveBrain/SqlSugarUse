using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///报警信息表
    ///</summary>
    public partial class t_alarm_information
    {
           public t_alarm_information(){

            this.created_time =DateTime.Now;

           }
           /// <summary>
           /// Desc:报警ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int alarm_id {get;set;}

           /// <summary>
           /// Desc:设备名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string device_name {get;set;}

           /// <summary>
           /// Desc:设备编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string device_id {get;set;}

           /// <summary>
           /// Desc:设备型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string device_model {get;set;}

           /// <summary>
           /// Desc:工位
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string station {get;set;}

           /// <summary>
           /// Desc:点位名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string point_name {get;set;}

           /// <summary>
           /// Desc:点位地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string point_address {get;set;}

           /// <summary>
           /// Desc:报警参数名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string parameter_name {get;set;}

           /// <summary>
           /// Desc:单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string unit {get;set;}

           /// <summary>
           /// Desc:报警值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? alarm_value {get;set;}

           /// <summary>
           /// Desc:报警信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string alarm_message {get;set;}

           /// <summary>
           /// Desc:报警状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string alarm_status {get;set;}

           /// <summary>
           /// Desc:处理建议
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string advice {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? created_time {get;set;}

    }
}
