using SqlSugar;
 SqlSugarClient _db=null;
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
        });
    _db.Aop.OnLogExecuting = (sql, pars) =>
    {
        Console.WriteLine(sql);
        Console.WriteLine(_db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
    };

    Console.WriteLine ("连接成功"); 
    _db.DbFirst.SettingNamespaceTemplate((x) => { return "using SqlSugar;"; });
    _db.DbFirst.IsCreateAttribute(true).IsCreateDefaultValue(true).CreateClassFile(@"C:\Users\steve\Desktop\sugarClass"); 
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