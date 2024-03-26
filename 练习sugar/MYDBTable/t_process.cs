using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///
    ///</summary>
    public partial class t_process
    {
           public t_process(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:流程名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string process_name {get;set;}

           /// <summary>
           /// Desc:反应釜id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int station_id {get;set;}

           /// <summary>
           /// Desc:反应釜名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string station_name {get;set;}

           /// <summary>
           /// Desc:组态设备
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string device_message {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? create_time {get;set;}

           /// <summary>
           /// Desc:宽度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? width {get;set;}

           /// <summary>
           /// Desc:高度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? height {get;set;}

    }
}
