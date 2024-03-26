using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///点位表
    ///</summary>
    public partial class t_points
    {
           public t_points(){

            this.point_type =Convert.ToInt32("0");
            this.created_time =DateTime.Now;

           }
           /// <summary>
           /// Desc:点位ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int point_id {get;set;}

           /// <summary>
           /// Desc:设备编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? device_id {get;set;}

           /// <summary>
           /// Desc:设备名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string device_name {get;set;}

           /// <summary>
           /// Desc:分组
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string group_id {get;set;}

           /// <summary>
           /// Desc:点位名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string point_name {get;set;}

           /// <summary>
           /// Desc:点位地址
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string point_address {get;set;}

           /// <summary>
           /// Desc:值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string point_value {get;set;}

           /// <summary>
           /// Desc:数据类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string data_type {get;set;}

           /// <summary>
           /// Desc:数据长度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? data_length {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remarks {get;set;}

           /// <summary>
           /// Desc:点位类型（0，1启动按钮，2暂停按钮，3继续，4完成； 10 实时点位 ，20反应釜标志点位，）
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? point_type {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? created_time {get;set;}

           /// <summary>
           /// Desc:单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string unit {get;set;}

    }
}
