using System;
using MySql.Data.MySqlClient;
namespace ThePos.util{
	public class Db{
		private MySqlConnection c;

		public Db(){
			String host = "localhost";
			String dbname = "thepos";
			String user = "root";
			String pass = "";
		}
	}
}