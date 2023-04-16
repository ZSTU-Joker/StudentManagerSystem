using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace StudentManagerSystem
{
    class OcrDB
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //MySqlOp();
            OcrDB p = new OcrDB();

            //p.Operation("delete from student where sName='aaa'");

            //p.Operation("insert into student values('123','bbbbb',11)");

            p.Operation("INSERT INTO lg_ocr_device_data(device_id, device_name, device_code, device_model, create_by, data1, data2)VALUES(123, 'name-for-test', 'aaa-111', 'ocr_model', 'controller-test1', 11, 22); ");

            p.Operation("INSERT INTO lg_ocr_device_image(device_id, device_name, device_code, device_model, create_by, image_path)VALUES(123, 'equipment-111', 'code-123', 'haidebao', 'ocr-baidu', 'E:/zstu/Baidu_OCR/Baidu_OCR_C#'); ");

            //p.Operation("update student set sName='asd',age=31 where sNo='123'");

            //https://blog.csdn.net/pan_junbiao/article/details/8872362
            DataSet thisDataSet = new DataSet();
            thisDataSet =  p.Quety("select * from lg_ocr_device_data");
            foreach (DataRow row in thisDataSet.Tables[0].Rows)
            {
                string str =  Convert.ToString(row["id"]);
                string str2 = Convert.ToString(row["device_id"]);
                Console.WriteLine(str);
                Console.WriteLine(str2);
            }

            Console.ReadKey();
        }
        /// 数据库连接字符串root
        public string MysqlConnString = "server=127.0.0.1;User Id=root;password=root;Database=pem_db_yunchuang;";
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
