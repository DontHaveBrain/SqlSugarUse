using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///
    ///</summary>
    public partial class t_alarm
    {
           public t_alarm(){

            this.created_time =DateTime.Now;

           }
           /// <summary>
           /// Desc:报警ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:设备ID
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
           /// Desc:点位ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int point_id {get;set;}

           /// <summary>
           /// Desc:报警值
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal alarm_value {get;set;}

           /// <summary>
           /// Desc:参数名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string parameter_name {get;set;}

           /// <summary>
           /// Desc:报警提示
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string alarm_message {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? created_time {get;set;}

    }
}
