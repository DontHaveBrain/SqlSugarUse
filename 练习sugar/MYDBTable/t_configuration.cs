using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///
    ///</summary>
    public partial class t_configuration
    {
           public t_configuration(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int t_id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string t_configurationJson {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? t_saveTime {get;set;}

    }
}
