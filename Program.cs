//using MySql.Data.MySqlClient;
//using System;
//using System.Data;

//namespace StudentManagerSystem
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            //MySqlOp();
//            Program p = new Program();

//            //p.Operation("delete from student where sName='aaa'");

//            //p.Operation("insert into student values('123','bbbbb',11)");

//            //p.Operation("update student set sName='asd',age=31 where sNo='123'");

//            //https://blog.csdn.net/pan_junbiao/article/details/8872362
//            DataSet thisDataSet = new DataSet();
//            thisDataSet =  p.Quety("select * from student");
//            foreach (DataRow row in thisDataSet.Tables[0].Rows)
//            {
//                string str =  Convert.ToString(row["sNo"]);
//                Console.WriteLine(str);
//            }

//            Console.ReadKey();
//        }
//        /// 数据库连接字符串root
//        public string MysqlConnString = "server=127.0.0.1;User Id=root;password=root;Database=test;";
//        /// <summary>
//        /// 查询
//        /// </summary>
//        /// <param name="Mysql_SQL">查询语句</param>
//        /// <returns></returns>
//        public DataSet Quety(string Mysql_SQL)
//        {
//            //数据库连接器,创建数据库连接.
//            MySqlConnection Mysqlconnce = new MySqlConnection(MysqlConnString);
//            //数据库命名对象,指定要执行sql语句与连接对象conn.参数1：SQL操作语句，参数2：数据库连接.
//            MySqlDataAdapter mysqlDa = new MySqlDataAdapter(Mysql_SQL, Mysqlconnce);
//            //实例化数据集.
//            DataSet ds = new DataSet();
//            //将数据适配器中的数据填充到数据集.
//            mysqlDa.Fill(ds);
//            return ds;
//        }
//        /// <summary>
//        /// 操作
//        /// </summary>
//        /// <param name="Mysql_SQL">操作语句</param>
//        /// <returns></returns>
//        public int Operation(string Mysql_SQL)
//        {
//            //数据库连接器,创建数据库连接.
//            MySqlConnection Mysqlconnce = new MySqlConnection(MysqlConnString);
//            //数据库命名对象,指定要执行sql语句与连接对象conn.参数1：SQL操作语句，参数2：数据库连接.
//            MySqlCommand mysqlComm = new MySqlCommand(Mysql_SQL, Mysqlconnce);
//            //打开数据库
//            Mysqlconnce.Open();
//            //执行,返回影响行数
//            int rows = mysqlComm.ExecuteNonQuery();
//            //关闭数据库
//            Mysqlconnce.Close();
//            return rows;
//        }
       
//    }
//}
