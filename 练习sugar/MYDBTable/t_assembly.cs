using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///组件表

    ///</summary>
    public partial class t_assembly
    {
           public t_assembly(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:图标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string icon {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string header {get;set;}

           /// <summary>
           /// Desc:类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string target_type {get;set;}

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
