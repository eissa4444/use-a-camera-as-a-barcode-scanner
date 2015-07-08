//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Data.SqlClient;
//using System.Collections;
//using System.Data;

//namespace functioneissasql
//{
//    public class functioneissa
//    {
//        public string getDate()
//        {
//            string date = DateTime.Now.ToLongTimeString() + DateTime.Now.Day + DateTime.Now.Month;
//            date = date.Replace("-", "").Replace(":", "").Replace(" ", "");
//            date = date.Replace("/", "").Replace(":", "").Replace(" ", "");

//            if (date.Contains("AM") || date.Contains("am"))
//                date = date.Replace("AM", "");
//            else date = date.Replace("PM", "");

//            return date;
//        }

//        public SqlConnection conn;
//        public SqlCommand cmd;

//       public SqlConnection con = new SqlConnection("DATA SOURCE=KALILINUX;database=barcode;INTEGRATED SECURITY=true");//cc.InitiatConnection("", "root", "root");
//        public string InitiatConnection(string dbname)
//        {
//            string strConnection = string.Format("DATA SOURCE= KALILINUX;database={0};INTEGRATED SECURITY=true",dbname );
//            conn = new SqlConnection(strConnection);
//            if (conn.State != ConnectionState.Open)
//            {
//                conn.Open();
//                return "Connection Opened";
//            }
//            else return "Connection Not Openned";
//        }

//        public string InsertFN(SortedList sl, string sql)
//        { 
//            cmd = new SqlCommand();
//                cmd.Connection = conn;

//                for (int i = 0; i < sl.Count; i++)
//                {
//                    cmd.Parameters.AddWithValue(sl.GetKey(i).ToString(), sl.GetByIndex(i).ToString());
//                }
//                cmd.CommandText = sql;
//                int j = cmd.ExecuteNonQuery();
//                if (j > 0)
//                {
//                    return " Data Saved ";
//                }
//                else return "Error ";


//        }

//        public DataTable GetData(SortedList sl, string sql)
//        {
//            cmd = new SqlCommand();
//            cmd.Connection = conn;
//            for (int i = 0; i < sl.Count; i++)
//            {
//                cmd.Parameters.AddWithValue(sl.GetKey(i).ToString(), sl.GetByIndex(i).ToString());
//            }
//            cmd.CommandText = sql;
//            SqlDataAdapter msda = new SqlDataAdapter(cmd);
//            DataSet ds = new DataSet();
//            msda.Fill(ds);
//            return ds.Tables[0];
//        }
//        public SortedList ReturnString(SortedList sl ,string sql)
//        {
//            SortedList resultArray = new SortedList();
//            cmd = new SqlCommand();
//            cmd.Connection = conn;
//            for (int i = 0; i < sl.Count; i++)
//            {
//                cmd.Parameters.AddWithValue(sl.GetKey(i).ToString(), sl.GetByIndex(i).ToString());
//            }
//            cmd.CommandText = sql;
//            SqlDataReader r = cmd.ExecuteReader();
//            if (r.Read())
//            {
//                for (int i = 0; i < resultArray.Count; i++)
//                {
//                    resultArray.Add(sl.GetKey(i),r.GetValue(i).ToString());
//                }
//            }
            
//            return resultArray;
//        }
//        public string ReturnOneValue(SortedList sl,string sql)
//        {
//            string value="";
//            cmd = new SqlCommand();
//            cmd.Connection = conn;
//            for (int i = 0; i < sl.Count; i++)
//            {
//                cmd.Parameters.AddWithValue(sl.GetKey(i).ToString(), sl.GetByIndex(i).ToString());
//            }
//            cmd.CommandText = sql;
//            SqlDataReader r = cmd.ExecuteReader();
//            while (r.Read())
//            {
//                value = r.GetValue(0).ToString();
//            }

//            return value;
            
//        }
//    }
//}
