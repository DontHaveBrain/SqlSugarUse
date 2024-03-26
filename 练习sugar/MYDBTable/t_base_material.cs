using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///底料控制
    ///</summary>
    public partial class t_base_material
    {
           public t_base_material(){

            this.create_time =DateTime.Now;

           }
           /// <summary>
           /// Desc:主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:配方id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int recipe_id {get;set;}

           /// <summary>
           /// Desc:步骤名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string step_name {get;set;}

           /// <summary>
           /// Desc:底料体积
           /// Default:
           /// Nullable:False
           /// </summary>           
           public double material_volume {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? create_time {get;set;}

    }
}
