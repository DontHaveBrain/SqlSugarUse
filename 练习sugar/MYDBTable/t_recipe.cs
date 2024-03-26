using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///配方表
    ///</summary>
    public partial class t_recipe
    {
           public t_recipe(){

            this.update_time =DateTime.Now;
            this.create_time =DateTime.Now;

           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int recipe_id {get;set;}

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
           /// Desc:配方名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string recipe_name {get;set;}

           /// <summary>
           /// Desc:主要产出
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string main_output {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remarks {get;set;}

           /// <summary>
           /// Desc:稀土溶液浓度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? material_concentration {get;set;}

           /// <summary>
           /// Desc:底料稀土溶液体积
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? sediment_volume {get;set;}

           /// <summary>
           /// Desc:草酸浓度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? oxalic_acid_concentration {get;set;}

           /// <summary>
           /// Desc:底水温度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? bottom_water_temperature {get;set;}

           /// <summary>
           /// Desc:底水体积
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? bottom_water_volume {get;set;}

           /// <summary>
           /// Desc:稀土溶液总加入量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? all_material {get;set;}

           /// <summary>
           /// Desc:反应阶段参数json
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string reaction_parameter_stage {get;set;}

           /// <summary>
           /// Desc:草酸过量体积
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? excessive_oxalic_acid {get;set;}

           /// <summary>
           /// Desc:反应时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? reaction_time {get;set;}

           /// <summary>
           /// Desc:点位范围，点位参数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string point_parameter {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? update_time {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? create_time {get;set;}

           /// <summary>
           /// Desc:底水温度绑定字段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bottom_water_temperature_address {get;set;}

           /// <summary>
           /// Desc:底部水体积绑定字段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bottom_water_volume_address {get;set;}

           /// <summary>
           /// Desc:底料稀土溶液体积绑定字段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sediment_volume_address {get;set;}

           /// <summary>
           /// Desc:稀土溶液浓度绑定字段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string material_concentration_address {get;set;}

           /// <summary>
           /// Desc:草酸浓度绑定字段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string oxalic_acid_concentration_address {get;set;}

           /// <summary>
           /// Desc:稀土溶液总加入量绑定字段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string all_material_address {get;set;}

           /// <summary>
           /// Desc:停止加入草酸时间设定绑定字段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string excessive_oxalic_acid_address {get;set;}

           /// <summary>
           /// Desc:停止搅拌时间设定绑定字段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string reaction_time_address {get;set;}

    }
}
