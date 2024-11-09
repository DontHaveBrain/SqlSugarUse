using SqlSugar;
using System.Configuration;
using System.Net;



try
{
    SqlSugarClient _db;
    Console.WriteLine("请输入要生成的数据库名称:1=>mysql,2=>sqlserver");
    string read=Console.ReadLine();
    if (read=="1")
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

        Console.WriteLine("连接成功");
        string BaseDtnr = AppDomain.CurrentDomain.BaseDirectory;
        string realPath = Path.Combine(BaseDtnr, "MySqlClassCollention");
        Directory.CreateDirectory(realPath);
        _db.DbFirst.SettingNamespaceTemplate((x) => { return "using SqlSugar;"; });
        _db.DbFirst.IsCreateAttribute(true).IsCreateDefaultValue(true).CreateClassFile(realPath);
        Console.WriteLine($"类生成成功 位置:{realPath}");
        Console.ReadKey();
    }
    else if (read == "2")
    {
        _db = new SqlSugarClient(
       new ConnectionConfig()
       {
           ConnectionString = ConfigurationManager.AppSettings["MSsql_connectionstrings"],
           //@"Data source=LAPTOP-1AT3A4GN;uid=sa;pwd=~;database=mydb",
           DbType = SqlSugar.DbType.SqlServer,
           IsAutoCloseConnection = true,
           InitKeyType = InitKeyType.Attribute
       });
        _db.Aop.OnLogExecuting = (sql, pars) =>
        {
            Console.WriteLine(sql);
            Console.WriteLine(_db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
        };

        Console.WriteLine("连接成功");
        string BaseDtnr = AppDomain.CurrentDomain.BaseDirectory;
        string realPath = Path.Combine(BaseDtnr, "SqlServerClassCollention");
        Directory.CreateDirectory(realPath);
        _db.DbFirst 
                   .SettingClassTemplate(( table) =>  { return $@"using ShuseiCommon.Common.Sqlsugar.DB.DBServer;
using ShuseiCommon.Common.Sqlsugar.DB.DBFactory;
using ShuseiCommon.Common.Sqlsugar.DB.DBEntity"  + @";

namespace " + "SqlSugar.Model" + @"
{	
	/// <summary>
	/// {ClassName}
	/// </summary>	
    {ClassDescription}{SugarTable}
    public class {ClassName} :EntityBasic" + @"
	{
        public {ClassName}()
        {
       {Constructor}
        }
       {PropertyName}
    }
    #region {ClassName}Server
    public interface i{ClassName}Server : IServerBase<{ClassName}, int>
	{ 
    }
    [Injection(type = typeof(i{ClassName}Server), serviceLifetime = ServiceLifetime.Singleton)]
    public class {ClassName}Server :ServerBase<{ClassName}, int> , i{ClassName}Server
	{ 
        private readonly i{ClassName}Data _i{ClassName}data;
        public {ClassName}Server(i{ClassName}Data i{ClassName}data):base(i{ClassName}data)
        {
            _i{ClassName}data=i{ClassName}data;
        }
    }
    #endregion
    #region {ClassName}Data
    public interface i{ClassName}Data : iDBBase<{ClassName},int>
	{ 
    }
    [Injection(type = typeof(i{ClassName}Data), serviceLifetime = ServiceLifetime.Singleton)]
    public class {ClassName}Data : DBBase<{ClassName},int>,i{ClassName}Data
	{ 
        public {ClassName}Data(IDbFactory dbFactory, string DBConnect = null):base(dbFactory,DBConnect)  {}
    } 
    #endregion
}";  })
                   .IsCreateAttribute(true)
                   .IsCreateDefaultValue(true)
                   .CreateClassFile(realPath);
        Console.WriteLine($"类生成成功 位置:{realPath}");
        Console.ReadKey();
    }
    else
    {

        Console.WriteLine("所示类型不存在，类生成失败");
    }
   
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