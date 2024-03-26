using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///
    ///</summary>
    public partial class t_product
    {
           public t_product(){


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
           /// Desc:工位名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string station_name {get;set;}

           /// <summary>
           /// Desc:产物
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string product {get;set;}

           /// <summary>
           /// Desc:生产数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? product_num {get;set;}

           /// <summary>
           /// Desc:草酸
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? use_oxalate {get;set;}

           /// <summary>
           /// Desc:稀土溶液
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? use_rare_earth {get;set;}

           /// <summary>
           /// Desc:热水
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? use_hot_water {get;set;}

           /// <summary>
           /// Desc:冷水
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? use_cold_water {get;set;}

           /// <summary>
           /// Desc:生产时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? create_time {get;set;}

    }
}
