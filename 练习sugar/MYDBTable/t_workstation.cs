using System;
using System.Linq;
using System.Text;

namespace 练习sugar
{
    ///<summary>
    ///工位表
    ///</summary>
    public partial class t_workstation
    {
           public t_workstation(){

            this.status =Convert.ToByte("0");

           }
           /// <summary>
           /// Desc:ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:工位名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string workstation_name {get;set;}

           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string workstation_number {get;set;}

           /// <summary>
           /// Desc:产物
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string product {get;set;}

           /// <summary>
           /// Desc:位置
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string location {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remarks {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? status {get;set;}

           /// <summary>
           /// Desc:运行时长
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string run_time {get;set;}

           /// <summary>
           /// Desc:控制点位（json）只保存点位的id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string control_point {get;set;}

           /// <summary>
           /// Desc:采集点位（json）只保存点位的id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string collection_point {get;set;}

           /// <summary>
           /// Desc:组态名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string configuration_name {get;set;}

           /// <summary>
           /// Desc:配方id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? recipe_id {get;set;}

           /// <summary>
           /// Desc:配方名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string recipe_name {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? created_time {get;set;}

           /// <summary>
           /// Desc:启动地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string start_address {get;set;}

           /// <summary>
           /// Desc:暂停地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string pause_address {get;set;}

           /// <summary>
           /// Desc:完成地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string complete_address {get;set;}

           /// <summary>
           /// Desc:继续地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string continue_address {get;set;}

           /// <summary>
           /// Desc:当前反应时间地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string current_time_address {get;set;}

           /// <summary>
           /// Desc:当前反应阶段地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string current_stage_address {get;set;}

    }
}
