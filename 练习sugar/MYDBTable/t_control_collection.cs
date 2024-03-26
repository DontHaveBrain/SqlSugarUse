using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///控制点位表
    ///</summary>
    public partial class t_control_collection
    {
           public t_control_collection(){


           }
           /// <summary>
           /// Desc:控制点位ID
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
           /// Desc:点位id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? point_id {get;set;}

           /// <summary>
           /// Desc:采集参数名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string parameter_name {get;set;}

           /// <summary>
           /// Desc:点位地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string point_address {get;set;}

           /// <summary>
           /// Desc:控制类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string control_type {get;set;}

           /// <summary>
           /// Desc:设备名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string device_name {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime create_time {get;set;}

    }
}
