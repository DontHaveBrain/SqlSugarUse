using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///设备表

    ///</summary>
    public partial class t_devices
    {
           public t_devices(){

            this.created_time =DateTime.Now;

           }
           /// <summary>
           /// Desc:设备id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int device_id {get;set;}

           /// <summary>
           /// Desc:设备名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string device_name {get;set;}

           /// <summary>
           /// Desc:设备编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string device_code {get;set;}

           /// <summary>
           /// Desc:设备类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string device_type {get;set;}

           /// <summary>
           /// Desc:设备型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string device_model {get;set;}

           /// <summary>
           /// Desc:车间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string workshop {get;set;}

           /// <summary>
           /// Desc:接口
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string interfaces {get;set;}

           /// <summary>
           /// Desc:驱动
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string driver {get;set;}

           /// <summary>
           /// Desc:设备状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte device_status {get;set;}

           /// <summary>
           /// Desc:驱动状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte driver_status {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remarks {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string address {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? created_time {get;set;}

           /// <summary>
           /// Desc:ip
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ip {get;set;}

           /// <summary>
           /// Desc:端口
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? port {get;set;}

    }
}
