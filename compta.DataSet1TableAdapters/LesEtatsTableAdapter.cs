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
public class LesEtatsTableAdapter : Component
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
	public LesEtatsTableAdapter()
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
		tableMapping.DataSetTable = "LesEtats";
		tableMapping.ColumnMappings.Add("code", "code");
		tableMapping.ColumnMappings.Add("nom", "nom");
		tableMapping.ColumnMappings.Add("profile", "profile");
		tableMapping.ColumnMappings.Add("papersize", "papersize");
		_adapter.TableMappings.Add(tableMapping);
		_adapter.DeleteCommand = new OleDbCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM `LesEtats` WHERE ((`code` = ?) AND ((? = 1 AND `nom` IS NULL) OR (`nom` = ?)) AND ((? = 1 AND `papersize` IS NULL) OR (`papersize` = ?)))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_code", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "code", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_nom", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "nom", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_nom", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "nom", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_papersize", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "papersize", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_papersize", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "papersize", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand = new OleDbCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO `LesEtats` (`nom`, `profile`, `papersize`) VALUES (?, ?, ?)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("nom", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "nom", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("profile", OleDbType.LongVarBinary, 0, ParameterDirection.Input, 0, 0, "profile", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("papersize", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "papersize", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand = new OleDbCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE `LesEtats` SET `nom` = ?, `profile` = ?, `papersize` = ? WHERE ((`code` = ?) AND ((? = 1 AND `nom` IS NULL) OR (`nom` = ?)) AND ((? = 1 AND `papersize` IS NULL) OR (`papersize` = ?)))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("nom", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "nom", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("profile", OleDbType.LongVarBinary, 0, ParameterDirection.Input, 0, 0, "profile", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("papersize", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "papersize", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_code", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "code", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_nom", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "nom", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_nom", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "nom", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_papersize", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "papersize", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_papersize", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "papersize", DataRowVersion.Original, sourceColumnNullMapping: false, null));
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
		_commandCollection[0].CommandText = "SELECT code, nom, profile, papersize FROM LesEtats";
		_commandCollection[0].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(DataSet1.LesEtatsDataTable dataTable)
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
	public virtual DataSet1.LesEtatsDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		DataSet1.LesEtatsDataTable dataTable = new DataSet1.LesEtatsDataTable();
		Adapter.Fill(dataTable);
		return dataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet1.LesEtatsDataTable dataTable)
	{
		return Adapter.Update(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet1 dataSet)
	{
		return Adapter.Update(dataSet, "LesEtats");
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
	public virtual int Delete(int Original_code, string Original_nom, int? Original_papersize)
	{
		Adapter.DeleteCommand.Parameters[0].Value = Original_code;
		if (Original_nom == null)
		{
			Adapter.DeleteCommand.Parameters[1].Value = 1;
			Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[1].Value = 0;
			Adapter.DeleteCommand.Parameters[2].Value = Original_nom;
		}
		if (Original_papersize.HasValue)
		{
			Adapter.DeleteCommand.Parameters[3].Value = 0;
			Adapter.DeleteCommand.Parameters[4].Value = Original_papersize.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[3].Value = 1;
			Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
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
	public virtual int Insert(string nom, byte[] profile, int? papersize)
	{
		if (nom == null)
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = nom;
		}
		if (profile == null)
		{
			Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[1].Value = profile;
		}
		if (papersize.HasValue)
		{
			Adapter.InsertCommand.Parameters[2].Value = papersize.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
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
	public virtual int Update(string nom, byte[] profile, int? papersize, int Original_code, string Original_nom, int? Original_papersize)
	{
		if (nom == null)
		{
			Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[0].Value = nom;
		}
		if (profile == null)
		{
			Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[1].Value = profile;
		}
		if (papersize.HasValue)
		{
			Adapter.UpdateCommand.Parameters[2].Value = papersize.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		Adapter.UpdateCommand.Parameters[3].Value = Original_code;
		if (Original_nom == null)
		{
			Adapter.UpdateCommand.Parameters[4].Value = 1;
			Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[4].Value = 0;
			Adapter.UpdateCommand.Parameters[5].Value = Original_nom;
		}
		if (Original_papersize.HasValue)
		{
			Adapter.UpdateCommand.Parameters[6].Value = 0;
			Adapter.UpdateCommand.Parameters[7].Value = Original_papersize.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[6].Value = 1;
			Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
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
}
