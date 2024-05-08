
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 练习sugar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 显示数据
        /// </summary>
        /// <param name="str"></param>
        public void MsgShow(string str)//文本展示
        {
            tbChar.AppendText(DateTime.Now + str + "\r\n");
        }
        private SqlSugarClient _db;
        public bool ConnectDB()//连接数据库
        {
            try
            {
                _db = new SqlSugarClient(
                new ConnectionConfig()
                {
                    ConnectionString = @"server=192.168.1.101;uid=admin;pwd=admin123;database=heat pump",
                    //@"Data source=LAPTOP-1AT3A4GN;uid=sa;pwd=~;database=mydb",
                    DbType = SqlSugar.DbType.MySql,
                    IsAutoCloseConnection = true,
                    InitKeyType = InitKeyType.Attribute
                }) ;
                _db.Aop.OnLogExecuting = (sql, pars) =>
                {
                    MsgShow(sql);
                    MsgShow(_db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                };
                return true;
            }
            catch (Exception ex)
            {

                MsgShow(ex.Message.ToString());
                return false;
            }
        }

        private void bt连接_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDB();
                MsgShow("连接成功");
            }
            catch (Exception ex)
            {
                MsgShow(ex.Message.ToString());
            }
        }

        private void bt生成_Click(object sender, EventArgs e)
        {
            try
            {
                _db.DbFirst.IsCreateAttribute(true);
                _db.DbFirst.SettingNamespaceTemplate((x) => { return "using SqlSugar;"; });
                _db.DbFirst.IsCreateDefaultValue(true).CreateClassFile(@"C:\Users\steve\Desktop\sugarClass");
                MsgShow("类生成成功");
            }
            catch (Exception ex)
            {
                MsgShow(ex.Message.ToString());
            }
        }
        private void bt插入_Click(object sender, EventArgs e)
        {
           //t_data_store ts=new t_data_store();
           // ts.device_message = "12";
           // ts.station_id = 53;
           // ts.height = 3;
           // ts.width = 3;
           // ts.lift_address = "sags";
           // ts.right_address = "ffsf";
           // int n=_db.Queryable<t_data_store>().Where(x => x.station_id == ts.station_id).Count();
           // if (n==0)
           // {
           //     _db.Insertable(ts).ExecuteCommand();
           // }
           // else
           // {
           //     MsgShow("主键重复");
           // }
           // List<t_data_store> td=new List<t_data_store>();
           // for (int i = 0; i < 1000; i++)
           // {
           //     t_data_store temp=new t_data_store();
           //     temp.device_message = ts.device_message;
           //     temp.right_address=ts.right_address;
           //     temp.lift_address=ts.lift_address;
           //     temp.height = ts.height;
           //     temp.width = ts.width;
           //     temp.station_id = i + 100;
           //     td.Add(temp);
           // }
           // _db.Fastest<t_data_store>().BulkCopy(td);
            
        }

        private void bt修改_Click(object sender, EventArgs e)
        {
            //t_data_store ts = _db.Queryable<t_data_store>().Where(x=>x.station_id==53).First();
            //if (ts!=null)
            //{
            //    ts.width = 666;
            //    _db.Updateable(ts).ExecuteCommand();
            //}
            //else
            //{
            //    MsgShow("修改对象不能为空");
            //}
        }

        private void bt删除_Click(object sender, EventArgs e)
        {
            //_db.Deleteable<t_data_store>().Where(x=>x.station_id==53).ExecuteCommand();
        }

        private void bt查询_Click(object sender, EventArgs e)
        {
            //ObservableCollection<t_data_store> result =new ObservableCollection<t_data_store>(_db.Queryable<t_data_store>().ToList());
            //foreach (var item in result)
            //{
            //    MsgShow(item.lift_address);
            //    MsgShow(item.right_address);
            //    MsgShow(item.station_id.ToString());
            //    MsgShow(item.height.ToString());
            //    MsgShow(item.width.ToString());
            //    MsgShow(item.device_message);
            //}
        }
    }
}
