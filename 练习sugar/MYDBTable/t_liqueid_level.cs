using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///液位信息表
    ///</summary>
    public partial class t_liqueid_level
    {
           public t_liqueid_level(){

            this.created_time =DateTime.Now;

           }
           /// <summary>
           /// Desc:设备id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:表主键id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int key_id {get;set;}

           /// <summary>
           /// Desc:液位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? liquid_level {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? created_time {get;set;}

    }
}
