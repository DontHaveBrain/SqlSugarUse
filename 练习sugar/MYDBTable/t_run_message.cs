using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///
    ///</summary>
    public partial class t_run_message
    {
           public t_run_message(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:工位id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int station_id {get;set;}

           /// <summary>
           /// Desc:开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? start_time {get;set;}

           /// <summary>
           /// Desc:是否继续运行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public byte? is_run {get;set;}

           /// <summary>
           /// Desc:停止时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? end_time {get;set;}

    }
}
