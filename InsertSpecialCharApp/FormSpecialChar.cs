using System.Data;

namespace InsertSpecialCharApp
{
	public partial class FormSpecialChar : Form
	{
		private int _lastId;

		public FormSpecialChar()
		{
			InitializeComponent();
		}

		private void buttonInsert_Click(object sender, EventArgs e)
		{
			string specialChar = _txtBoxSpecialChar.Text;

			IDbConnection? connection = OpenConnection();

			if (connection == null)
			{
				return;
			}

			try
			{
				_lastId = new Random().Next();
				string insertStatement = "INSERT INTO TEST_SPECIAL_CHAR (ID, TEXT) VALUES (" +
										 $"{_lastId}, '{specialChar}')";

				IDbCommand oracleCommand = DbmsUtils.CreateOracleCommand(connection, insertStatement);

				oracleCommand.ExecuteNonQuery();

				_lblInsertedStatement.Text = $"Inserted: {insertStatement}";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection?.Close();
			}
		}

		private void _btnSelect_Click(object sender, EventArgs e)
		{
			string selectStatement = $"SELECT ID, TEXT FROM TEST_SPECIAL_CHAR where ID = {_lastId}";

			IDbConnection? connection = OpenConnection();

			if (connection == null)
			{
				return;
			}

			try
			{
				IDbCommand oracleCommand = DbmsUtils.CreateOracleCommand(connection, selectStatement);

				oracleCommand.ExecuteNonQuery();

				_txtBoxResult.Text = $"{selectStatement}:{Environment.NewLine}";

				IDataReader dataReader = oracleCommand.ExecuteReader();

				while (dataReader.Read())
				{
					_txtBoxResult.Text += $"{dataReader[0]}, {dataReader[1]}{Environment.NewLine}";
				}

				dataReader.Close();
			}
			finally
			{
				connection?.Close();
			}
		}

		const string TableName = "TEST_SPECIAL_CHAR";

		private void _btnCreateTable_Click(object sender, EventArgs e)
		{
			

			IDbConnection? connection = OpenConnection();

			if (connection == null)
			{
				return;
			}

			try
			{
				string createStatement = $"CREATE TABLE {TableName} (ID NUMBER, TEXT NVARCHAR2(20))";

				IDbCommand oracleCommand = DbmsUtils.CreateOracleCommand(connection, createStatement);

				oracleCommand.ExecuteNonQuery();

				_lblInsertedStatement.Text = $"Created Table: {createStatement}";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, $"Error Creating Table {TableName}", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			finally
			{
				connection?.Close();
			}
		}

		private void buttonDropTable_Click(object sender, EventArgs e)
		{

			IDbConnection? connection = OpenConnection();

			if (connection == null)
			{
				return;
			}

			try
			{
				string createStatement = $"DROP TABLE {TableName}";

				IDbCommand oracleCommand = DbmsUtils.CreateOracleCommand(connection, createStatement);

				oracleCommand.ExecuteNonQuery();

				_lblInsertedStatement.Text = $"Dropped Table: {createStatement}";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, $"Error Dropping Table {TableName}", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			finally
			{
				connection?.Close();
			}
		}

		private IDbConnection? OpenConnection()
		{
			string tnsName = _txtBoxTNS.Text;
			string user = _txtBoxUser.Text;
			string password = _txtBoxPassword.Text;

			IDbConnection? connection = null;

			try
			{
				connection = DbmsUtils.GetOracleConnection(tnsName, user, password);

				connection.Open();
			}
			catch (Exception ex)
			{
				connection?.Close();
				connection = null;
				MessageBox.Show(ex.Message, "Error oppening connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return connection;
		}
	}
}