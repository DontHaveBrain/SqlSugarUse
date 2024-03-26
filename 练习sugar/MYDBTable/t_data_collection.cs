using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///数据采集表
    ///</summary>
    public partial class t_data_collection
    {
           public t_data_collection(){

            this.status =Convert.ToByte("0");

           }
           /// <summary>
           /// Desc:数据采集ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:工位ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? station_id {get;set;}

           /// <summary>
           /// Desc:设备id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? device_id {get;set;}

           /// <summary>
           /// Desc:点位id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? point_id {get;set;}

           /// <summary>
           /// Desc:设备名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string device_name {get;set;}

           /// <summary>
           /// Desc:采集参数名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string point_name {get;set;}

           /// <summary>
           /// Desc:对应点位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string point_address {get;set;}

           /// <summary>
           /// Desc:单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string unit {get;set;}

           /// <summary>
           /// Desc:下限值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? low_threshold {get;set;}

           /// <summary>
           /// Desc:状态提示
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string low_status_prompt {get;set;}

           /// <summary>
           /// Desc:报警提示
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string low_alarm_prompt {get;set;}

           /// <summary>
           /// Desc:处理方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string low_handling_method {get;set;}

           /// <summary>
           /// Desc:上限值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? high_threshold {get;set;}

           /// <summary>
           /// Desc:状态提示
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string high_status_prompt {get;set;}

           /// <summary>
           /// Desc:报警提示
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string high_alarm_prompt {get;set;}

           /// <summary>
           /// Desc:处理方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string high_handling_method {get;set;}

           /// <summary>
           /// Desc:参数状态
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? status {get;set;}

           /// <summary>
           /// Desc:参数状态名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string status_text {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? create_time {get;set;}

    }
}
