using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///点位设定表
    ///</summary>
    public partial class t_setting_point
    {
           public t_setting_point(){


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
           /// Desc:设定值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string set_value {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? create_time {get;set;}

    }
}
