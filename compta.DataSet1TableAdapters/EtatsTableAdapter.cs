using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using compta.Properties;

namespace compta.DataSet1TableAdapters;

[DesignerCategory("code")]
[ToolboxItem(true)]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
public class EtatsTableAdapter : Component
{
	private OleDbDataAdapter _adapter;

	private OleDbConnection _connection;

	private OleDbTransaction _transaction;

	private OleDbCommand[] _commandCollection;

	private bool _clearBeforeFill;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal OleDbDataAdapter Adapter
	{
		get
		{
			if (_adapter == null)
			{
				InitAdapter();
			}
			return _adapter;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal OleDbConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				InitConnection();
			}
			return _connection;
		}
		set
		{
			_connection = value;
			if (Adapter.InsertCommand != null)
			{
				Adapter.InsertCommand.Connection = value;
			}
			if (Adapter.DeleteCommand != null)
			{
				Adapter.DeleteCommand.Connection = value;
			}
			if (Adapter.UpdateCommand != null)
			{
				Adapter.UpdateCommand.Connection = value;
			}
			for (int i = 0; i < CommandCollection.Length; i++)
			{
				if (CommandCollection[i] != null)
				{
					CommandCollection[i].Connection = value;
				}
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal OleDbTransaction Transaction
	{
		get
		{
			return _transaction;
		}
		set
		{
			_transaction = value;
			for (int i = 0; i < CommandCollection.Length; i++)
			{
				CommandCollection[i].Transaction = _transaction;
			}
			if (Adapter != null && Adapter.DeleteCommand != null)
			{
				Adapter.DeleteCommand.Transaction = _transaction;
			}
			if (Adapter != null && Adapter.InsertCommand != null)
			{
				Adapter.InsertCommand.Transaction = _transaction;
			}
			if (Adapter != null && Adapter.UpdateCommand != null)
			{
				Adapter.UpdateCommand.Transaction = _transaction;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected OleDbCommand[] CommandCollection
	{
		get
		{
			if (_commandCollection == null)
			{
				InitCommandCollection();
			}
			return _commandCollection;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return _clearBeforeFill;
		}
		set
		{
			_clearBeforeFill = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public EtatsTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void InitAdapter()
	{
		_adapter = new OleDbDataAdapter();
		DataTableMapping tableMapping = new DataTableMapping();
		tableMapping.SourceTable = "Table";
		tableMapping.DataSetTable = "Etats";
		tableMapping.ColumnMappings.Add("ID", "ID");
		tableMapping.ColumnMappings.Add("PARENTID", "PARENTID");
		tableMapping.ColumnMappings.Add("DEPARTMENT", "DEPARTMENT");
		_adapter.TableMappings.Add(tableMapping);
		_adapter.DeleteCommand = new OleDbCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM `Etats` WHERE ((`ID` = ?) AND ((? = 1 AND `PARENTID` IS NULL) OR (`PARENTID` = ?)) AND ((? = 1 AND `DEPARTMENT` IS NULL) OR (`DEPARTMENT` = ?)))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ID", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_PARENTID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "PARENTID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_PARENTID", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "PARENTID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_DEPARTMENT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DEPARTMENT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_DEPARTMENT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "DEPARTMENT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand = new OleDbCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO `Etats` (`ID`, `PARENTID`, `DEPARTMENT`) VALUES (?, ?, ?)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ID", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("PARENTID", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "PARENTID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DEPARTMENT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "DEPARTMENT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand = new OleDbCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE `Etats` SET `ID` = ?, `PARENTID` = ?, `DEPARTMENT` = ? WHERE ((`ID` = ?) AND ((? = 1 AND `PARENTID` IS NULL) OR (`PARENTID` = ?)) AND ((? = 1 AND `DEPARTMENT` IS NULL) OR (`DEPARTMENT` = ?)))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ID", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("PARENTID", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "PARENTID", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DEPARTMENT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "DEPARTMENT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ID", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_PARENTID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "PARENTID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_PARENTID", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "PARENTID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_DEPARTMENT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DEPARTMENT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_DEPARTMENT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "DEPARTMENT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void InitConnection()
	{
		_connection = new OleDbConnection();
		_connection.ConnectionString = Settings.Default.NouvelleBase2014ConnectionString;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void InitCommandCollection()
	{
		_commandCollection = new OleDbCommand[1];
		_commandCollection[0] = new OleDbCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT ID, PARENTID, DEPARTMENT FROM Etats";
		_commandCollection[0].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(DataSet1.EtatsDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual DataSet1.EtatsDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		DataSet1.EtatsDataTable dataTable = new DataSet1.EtatsDataTable();
		Adapter.Fill(dataTable);
		return dataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet1.EtatsDataTable dataTable)
	{
		return Adapter.Update(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet1 dataSet)
	{
		return Adapter.Update(dataSet, "Etats");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataRow dataRow)
	{
		return Adapter.Update(new DataRow[1] { dataRow });
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataRow[] dataRows)
	{
		return Adapter.Update(dataRows);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	public virtual int Delete(double? Original_ID, double? Original_PARENTID, string Original_DEPARTMENT)
	{
		if (Original_ID.HasValue)
		{
			Adapter.DeleteCommand.Parameters[0].Value = Original_ID.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[0].Value = DBNull.Value;
		}
		if (Original_PARENTID.HasValue)
		{
			Adapter.DeleteCommand.Parameters[1].Value = 0;
			Adapter.DeleteCommand.Parameters[2].Value = Original_PARENTID.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[1].Value = 1;
			Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
		}
		if (Original_DEPARTMENT == null)
		{
			Adapter.DeleteCommand.Parameters[3].Value = 1;
			Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[3].Value = 0;
			Adapter.DeleteCommand.Parameters[4].Value = Original_DEPARTMENT;
		}
		ConnectionState previousConnectionState = Adapter.DeleteCommand.Connection.State;
		if ((Adapter.DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.DeleteCommand.Connection.Open();
		}
		try
		{
			return Adapter.DeleteCommand.ExecuteNonQuery();
		}
		finally
		{
			if (previousConnectionState == ConnectionState.Closed)
			{
				Adapter.DeleteCommand.Connection.Close();
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	public virtual int Insert(double? ID, double? PARENTID, string DEPARTMENT)
	{
		if (ID.HasValue)
		{
			Adapter.InsertCommand.Parameters[0].Value = ID.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		if (PARENTID.HasValue)
		{
			Adapter.InsertCommand.Parameters[1].Value = PARENTID.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
		}
		if (DEPARTMENT == null)
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = DEPARTMENT;
		}
		ConnectionState previousConnectionState = Adapter.InsertCommand.Connection.State;
		if ((Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.InsertCommand.Connection.Open();
		}
		try
		{
			return Adapter.InsertCommand.ExecuteNonQuery();
		}
		finally
		{
			if (previousConnectionState == ConnectionState.Closed)
			{
				Adapter.InsertCommand.Connection.Close();
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Update(double? ID, double? PARENTID, string DEPARTMENT, double? Original_ID, double? Original_PARENTID, string Original_DEPARTMENT)
	{
		if (ID.HasValue)
		{
			Adapter.UpdateCommand.Parameters[0].Value = ID.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
		}
		if (PARENTID.HasValue)
		{
			Adapter.UpdateCommand.Parameters[1].Value = PARENTID.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
		}
		if (DEPARTMENT == null)
		{
			Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[2].Value = DEPARTMENT;
		}
		if (Original_ID.HasValue)
		{
			Adapter.UpdateCommand.Parameters[3].Value = Original_ID.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
		}
		if (Original_PARENTID.HasValue)
		{
			Adapter.UpdateCommand.Parameters[4].Value = 0;
			Adapter.UpdateCommand.Parameters[5].Value = Original_PARENTID.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[4].Value = 1;
			Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
		}
		if (Original_DEPARTMENT == null)
		{
			Adapter.UpdateCommand.Parameters[6].Value = 1;
			Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[6].Value = 0;
			Adapter.UpdateCommand.Parameters[7].Value = Original_DEPARTMENT;
		}
		ConnectionState previousConnectionState = Adapter.UpdateCommand.Connection.State;
		if ((Adapter.UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.UpdateCommand.Connection.Open();
		}
		try
		{
			return Adapter.UpdateCommand.ExecuteNonQuery();
		}
		finally
		{
			if (previousConnectionState == ConnectionState.Closed)
			{
				Adapter.UpdateCommand.Connection.Close();
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Update(double? PARENTID, string DEPARTMENT, double? Original_ID, double? Original_PARENTID, string Original_DEPARTMENT)
	{
		return Update(Original_ID, PARENTID, DEPARTMENT, Original_ID, Original_PARENTID, Original_DEPARTMENT);
	}
}
