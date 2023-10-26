using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace InsertSpecialCharApp
{
	public static class DbmsUtils
	{
		private const string _keyWordDataSource = "Data Source";
		private const string _keyWorkdUserId = "User ID";
		private const string _keyWordPassword = "Password";

		public static IDbConnection GetOracleConnection(
			string databaseName,
			string userName,
			string password = null)
		{
			string connectionString =
				$"{_keyWordDataSource}={databaseName};{_keyWorkdUserId}={userName};{_keyWordPassword}={password}";

			return new OracleConnection(connectionString);
		}

		public static IDbCommand CreateOracleCommand(IDbConnection connection,
			string statement = null)
		{
			IDbCommand oracleCommand = new OracleCommand();

			if (!string.IsNullOrEmpty(statement))
			{
				oracleCommand.CommandText = statement;
			}

			oracleCommand.Connection = connection;

			return oracleCommand;
		}
	}
}