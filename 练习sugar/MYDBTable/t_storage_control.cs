using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///存储控制

    ///</summary>
    public partial class t_storage_control
    {
           public t_storage_control(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:工位号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? workstation_number {get;set;}

           /// <summary>
           /// Desc:点位ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? point_id {get;set;}

           /// <summary>
           /// Desc:最大值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? max {get;set;}

           /// <summary>
           /// Desc:最小值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? min {get;set;}

    }
}
