using SqlSugar;
using System.Configuration;
using System.Net;
SqlSugarClient _db=null;
try
{

    _db = new SqlSugarClient(
        new ConnectionConfig()
        {
            ConnectionString = $@"server={ConfigurationManager.AppSettings["IP_Address"]};uid={ConfigurationManager.AppSettings["user_name"]};pwd={ConfigurationManager.AppSettings["pass_word"]};database={ConfigurationManager.AppSettings["database_name"]}",
            //@"Data source=LAPTOP-1AT3A4GN;uid=sa;pwd=~;database=mydb",
            DbType = SqlSugar.DbType.MySql,
            IsAutoCloseConnection = true,
            InitKeyType = InitKeyType.Attribute
        });
    _db.Aop.OnLogExecuting = (sql, pars) =>
    {
        Console.WriteLine(sql);
        Console.WriteLine(_db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
    };

    Console.WriteLine ("连接成功");
    string BaseDtnr= AppDomain.CurrentDomain.BaseDirectory;
    string realPath = Path.Combine(BaseDtnr, "MySqlClassCollention");
    Directory.CreateDirectory(realPath);
    _db.DbFirst.SettingNamespaceTemplate((x) => { return "using SqlSugar;"; });
    _db.DbFirst.IsCreateAttribute(true).IsCreateDefaultValue(true).CreateClassFile(realPath); 
    Console.WriteLine("类生成成功");
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine (ex.Message.ToString());
}

 




static bool ConnectDB(SqlSugarClient _db)//连接数据库
{
    
    try
    {
        
       
        return true;
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message.ToString());
        return false;
    }
}