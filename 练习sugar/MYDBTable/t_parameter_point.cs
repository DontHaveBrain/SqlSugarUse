using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///
    ///</summary>
    public partial class t_parameter_point
    {
           public t_parameter_point(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:点位id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int point_id {get;set;}

           /// <summary>
           /// Desc:配方id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int recipe_id {get;set;}

           /// <summary>
           /// Desc:point_name
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string point_name {get;set;}

           /// <summary>
           /// Desc:最小值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? minimum {get;set;}

           /// <summary>
           /// Desc:最大值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? maxmum {get;set;}

    }
}
