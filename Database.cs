using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerSystem
{
    class Database
    {
        /// 数据库连接字符串root
        public string MysqlConnString = "server=127.0.0.1;User Id=root;password=root;Database=test;";
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="Mysql_SQL">查询语句</param>
        /// <returns></returns>
        public DataSet Quety(string Mysql_SQL)
        {
            //数据库连接器,创建数据库连接.
            MySqlConnection Mysqlconnce = new MySqlConnection(MysqlConnString);
            //数据库命名对象,指定要执行sql语句与连接对象conn.参数1：SQL操作语句，参数2：数据库连接.
            MySqlDataAdapter mysqlDa = new MySqlDataAdapter(Mysql_SQL, Mysqlconnce);
            //实例化数据集.
            DataSet ds = new DataSet();
            //将数据适配器中的数据填充到数据集.
            mysqlDa.Fill(ds);
            return ds;
        }
        /// <summary>
        /// 操作
        /// </summary>
        /// <param name="Mysql_SQL">操作语句</param>
        /// <returns></returns>
        public int Operation(string Mysql_SQL)
        {
            //数据库连接器,创建数据库连接.
            MySqlConnection Mysqlconnce = new MySqlConnection(MysqlConnString);
            //数据库命名对象,指定要执行sql语句与连接对象conn.参数1：SQL操作语句，参数2：数据库连接.
            MySqlCommand mysqlComm = new MySqlCommand(Mysql_SQL, Mysqlconnce);
            //打开数据库
            Mysqlconnce.Open();
            //执行,返回影响行数
            int rows = mysqlComm.ExecuteNonQuery();
            //关闭数据库
            Mysqlconnce.Close();
            return rows;
        }
    }
}
