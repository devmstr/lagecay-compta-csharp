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
public class JournauxTableAdapter : Component
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
	public JournauxTableAdapter()
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
		tableMapping.DataSetTable = "Journaux";
		tableMapping.ColumnMappings.Add("JA", "JA");
		tableMapping.ColumnMappings.Add("LIB", "LIB");
		tableMapping.ColumnMappings.Add("CPT", "CPT");
		tableMapping.ColumnMappings.Add("CPTOT", "CPTOT");
		tableMapping.ColumnMappings.Add("ID", "ID");
		tableMapping.ColumnMappings.Add("UserC", "UserC");
		tableMapping.ColumnMappings.Add("DateC", "DateC");
		tableMapping.ColumnMappings.Add("UserM", "UserM");
		tableMapping.ColumnMappings.Add("DateM", "DateM");
		tableMapping.ColumnMappings.Add("LIBAR", "LIBAR");
		_adapter.TableMappings.Add(tableMapping);
		_adapter.DeleteCommand = new OleDbCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM `Journaux` WHERE ((`JA` = ?) AND ((? = 1 AND `LIB` IS NULL) OR (`LIB` = ?)) AND ((? = 1 AND `CPT` IS NULL) OR (`CPT` = ?)) AND ((? = 1 AND `CPTOT` IS NULL) OR (`CPTOT` = ?)) AND ((? = 1 AND `ID` IS NULL) OR (`ID` = ?)) AND ((? = 1 AND `UserC` IS NULL) OR (`UserC` = ?)) AND ((? = 1 AND `DateC` IS NULL) OR (`DateC` = ?)) AND ((? = 1 AND `UserM` IS NULL) OR (`UserM` = ?)) AND ((? = 1 AND `DateM` IS NULL) OR (`DateM` = ?)) AND ((? = 1 AND `LIBAR` IS NULL) OR (`LIBAR` = ?)))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_JA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "JA", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_LIB", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CPT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CPT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CPTOT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPTOT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CPTOT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPTOT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_UserC", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_UserC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_DateC", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_DateC", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_UserM", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_UserM", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_DateM", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_DateM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_LIBAR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIBAR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_LIBAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIBAR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand = new OleDbCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO `Journaux` (`JA`, `LIB`, `CPT`, `CPTOT`, `UserC`, `DateC`, `UserM`, `DateM`, `LIBAR`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("JA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "JA", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CPT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CPTOT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPTOT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("UserC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DateC", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("UserM", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DateM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("LIBAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIBAR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand = new OleDbCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE `Journaux` SET `JA` = ?, `LIB` = ?, `CPT` = ?, `CPTOT` = ?, `UserC` = ?, `DateC` = ?, `UserM` = ?, `DateM` = ?, `LIBAR` = ? WHERE ((`JA` = ?) AND ((? = 1 AND `LIB` IS NULL) OR (`LIB` = ?)) AND ((? = 1 AND `CPT` IS NULL) OR (`CPT` = ?)) AND ((? = 1 AND `CPTOT` IS NULL) OR (`CPTOT` = ?)) AND ((? = 1 AND `ID` IS NULL) OR (`ID` = ?)) AND ((? = 1 AND `UserC` IS NULL) OR (`UserC` = ?)) AND ((? = 1 AND `DateC` IS NULL) OR (`DateC` = ?)) AND ((? = 1 AND `UserM` IS NULL) OR (`UserM` = ?)) AND ((? = 1 AND `DateM` IS NULL) OR (`DateM` = ?)) AND ((? = 1 AND `LIBAR` IS NULL) OR (`LIBAR` = ?)))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("JA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "JA", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CPT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CPTOT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPTOT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("UserC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DateC", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("UserM", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DateM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("LIBAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIBAR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_JA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "JA", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_LIB", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CPT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CPT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CPTOT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPTOT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CPTOT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPTOT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_UserC", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_UserC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_DateC", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_DateC", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_UserM", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_UserM", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_DateM", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_DateM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_LIBAR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIBAR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_LIBAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIBAR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
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
		_commandCollection[0].CommandText = "SELECT        JA, LIB, CPT, CPTOT, ID, UserC, DateC, UserM, DateM, LIBAR\r\nFROM            Journaux";
		_commandCollection[0].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(DataSet1.JournauxDataTable dataTable)
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
	public virtual DataSet1.JournauxDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		DataSet1.JournauxDataTable dataTable = new DataSet1.JournauxDataTable();
		Adapter.Fill(dataTable);
		return dataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet1.JournauxDataTable dataTable)
	{
		return Adapter.Update(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet1 dataSet)
	{
		return Adapter.Update(dataSet, "Journaux");
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
	public virtual int Delete(string Original_JA, string Original_LIB, string Original_CPT, string Original_CPTOT, int Original_ID, string Original_UserC, DateTime? Original_DateC, string Original_UserM, DateTime? Original_DateM, string Original_LIBAR)
	{
		if (Original_JA == null)
		{
			Adapter.DeleteCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[0].Value = Original_JA;
		}
		if (Original_LIB == null)
		{
			Adapter.DeleteCommand.Parameters[1].Value = 1;
			Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[1].Value = 0;
			Adapter.DeleteCommand.Parameters[2].Value = Original_LIB;
		}
		if (Original_CPT == null)
		{
			Adapter.DeleteCommand.Parameters[3].Value = 1;
			Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[3].Value = 0;
			Adapter.DeleteCommand.Parameters[4].Value = Original_CPT;
		}
		if (Original_CPTOT == null)
		{
			Adapter.DeleteCommand.Parameters[5].Value = 1;
			Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[5].Value = 0;
			Adapter.DeleteCommand.Parameters[6].Value = Original_CPTOT;
		}
		Adapter.DeleteCommand.Parameters[7].Value = 0;
		Adapter.DeleteCommand.Parameters[8].Value = Original_ID;
		if (Original_UserC == null)
		{
			Adapter.DeleteCommand.Parameters[9].Value = 1;
			Adapter.DeleteCommand.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[9].Value = 0;
			Adapter.DeleteCommand.Parameters[10].Value = Original_UserC;
		}
		if (Original_DateC.HasValue)
		{
			Adapter.DeleteCommand.Parameters[11].Value = 0;
			Adapter.DeleteCommand.Parameters[12].Value = Original_DateC.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[11].Value = 1;
			Adapter.DeleteCommand.Parameters[12].Value = DBNull.Value;
		}
		if (Original_UserM == null)
		{
			Adapter.DeleteCommand.Parameters[13].Value = 1;
			Adapter.DeleteCommand.Parameters[14].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[13].Value = 0;
			Adapter.DeleteCommand.Parameters[14].Value = Original_UserM;
		}
		if (Original_DateM.HasValue)
		{
			Adapter.DeleteCommand.Parameters[15].Value = 0;
			Adapter.DeleteCommand.Parameters[16].Value = Original_DateM.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[15].Value = 1;
			Adapter.DeleteCommand.Parameters[16].Value = DBNull.Value;
		}
		if (Original_LIBAR == null)
		{
			Adapter.DeleteCommand.Parameters[17].Value = 1;
			Adapter.DeleteCommand.Parameters[18].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[17].Value = 0;
			Adapter.DeleteCommand.Parameters[18].Value = Original_LIBAR;
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
	public virtual int Insert(string JA, string LIB, string CPT, string CPTOT, string UserC, DateTime? DateC, string UserM, DateTime? DateM, string LIBAR)
	{
		if (JA == null)
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = JA;
		}
		if (LIB == null)
		{
			Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[1].Value = LIB;
		}
		if (CPT == null)
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = CPT;
		}
		if (CPTOT == null)
		{
			Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[3].Value = CPTOT;
		}
		if (UserC == null)
		{
			Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[4].Value = UserC;
		}
		if (DateC.HasValue)
		{
			Adapter.InsertCommand.Parameters[5].Value = DateC.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
		}
		if (UserM == null)
		{
			Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[6].Value = UserM;
		}
		if (DateM.HasValue)
		{
			Adapter.InsertCommand.Parameters[7].Value = DateM.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
		}
		if (LIBAR == null)
		{
			Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[8].Value = LIBAR;
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
	public virtual int Update(string JA, string LIB, string CPT, string CPTOT, string UserC, DateTime? DateC, string UserM, DateTime? DateM, string LIBAR, string Original_JA, string Original_LIB, string Original_CPT, string Original_CPTOT, int Original_ID, string Original_UserC, DateTime? Original_DateC, string Original_UserM, DateTime? Original_DateM, string Original_LIBAR)
	{
		if (JA == null)
		{
			Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[0].Value = JA;
		}
		if (LIB == null)
		{
			Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[1].Value = LIB;
		}
		if (CPT == null)
		{
			Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[2].Value = CPT;
		}
		if (CPTOT == null)
		{
			Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[3].Value = CPTOT;
		}
		if (UserC == null)
		{
			Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[4].Value = UserC;
		}
		if (DateC.HasValue)
		{
			Adapter.UpdateCommand.Parameters[5].Value = DateC.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
		}
		if (UserM == null)
		{
			Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[6].Value = UserM;
		}
		if (DateM.HasValue)
		{
			Adapter.UpdateCommand.Parameters[7].Value = DateM.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
		}
		if (LIBAR == null)
		{
			Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[8].Value = LIBAR;
		}
		if (Original_JA == null)
		{
			Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[9].Value = Original_JA;
		}
		if (Original_LIB == null)
		{
			Adapter.UpdateCommand.Parameters[10].Value = 1;
			Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[10].Value = 0;
			Adapter.UpdateCommand.Parameters[11].Value = Original_LIB;
		}
		if (Original_CPT == null)
		{
			Adapter.UpdateCommand.Parameters[12].Value = 1;
			Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[12].Value = 0;
			Adapter.UpdateCommand.Parameters[13].Value = Original_CPT;
		}
		if (Original_CPTOT == null)
		{
			Adapter.UpdateCommand.Parameters[14].Value = 1;
			Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[14].Value = 0;
			Adapter.UpdateCommand.Parameters[15].Value = Original_CPTOT;
		}
		Adapter.UpdateCommand.Parameters[16].Value = 0;
		Adapter.UpdateCommand.Parameters[17].Value = Original_ID;
		if (Original_UserC == null)
		{
			Adapter.UpdateCommand.Parameters[18].Value = 1;
			Adapter.UpdateCommand.Parameters[19].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[18].Value = 0;
			Adapter.UpdateCommand.Parameters[19].Value = Original_UserC;
		}
		if (Original_DateC.HasValue)
		{
			Adapter.UpdateCommand.Parameters[20].Value = 0;
			Adapter.UpdateCommand.Parameters[21].Value = Original_DateC.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[20].Value = 1;
			Adapter.UpdateCommand.Parameters[21].Value = DBNull.Value;
		}
		if (Original_UserM == null)
		{
			Adapter.UpdateCommand.Parameters[22].Value = 1;
			Adapter.UpdateCommand.Parameters[23].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[22].Value = 0;
			Adapter.UpdateCommand.Parameters[23].Value = Original_UserM;
		}
		if (Original_DateM.HasValue)
		{
			Adapter.UpdateCommand.Parameters[24].Value = 0;
			Adapter.UpdateCommand.Parameters[25].Value = Original_DateM.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[24].Value = 1;
			Adapter.UpdateCommand.Parameters[25].Value = DBNull.Value;
		}
		if (Original_LIBAR == null)
		{
			Adapter.UpdateCommand.Parameters[26].Value = 1;
			Adapter.UpdateCommand.Parameters[27].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[26].Value = 0;
			Adapter.UpdateCommand.Parameters[27].Value = Original_LIBAR;
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
	public virtual int Update(string LIB, string CPT, string CPTOT, string UserC, DateTime? DateC, string UserM, DateTime? DateM, string LIBAR, string Original_JA, string Original_LIB, string Original_CPT, string Original_CPTOT, int Original_ID, string Original_UserC, DateTime? Original_DateC, string Original_UserM, DateTime? Original_DateM, string Original_LIBAR)
	{
		return Update(Original_JA, LIB, CPT, CPTOT, UserC, DateC, UserM, DateM, LIBAR, Original_JA, Original_LIB, Original_CPT, Original_CPTOT, Original_ID, Original_UserC, Original_DateC, Original_UserM, Original_DateM, Original_LIBAR);
	}
}
