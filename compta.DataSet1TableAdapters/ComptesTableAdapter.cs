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
public class ComptesTableAdapter : Component
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
	public ComptesTableAdapter()
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
		tableMapping.DataSetTable = "Comptes";
		tableMapping.ColumnMappings.Add("CPT", "CPT");
		tableMapping.ColumnMappings.Add("LIB", "LIB");
		tableMapping.ColumnMappings.Add("IMPUT", "IMPUT");
		tableMapping.ColumnMappings.Add("TRS", "TRS");
		tableMapping.ColumnMappings.Add("ANA", "ANA");
		tableMapping.ColumnMappings.Add("IMMO", "IMMO");
		tableMapping.ColumnMappings.Add("CML", "CML");
		tableMapping.ColumnMappings.Add("SNS", "SNS");
		tableMapping.ColumnMappings.Add("RAP", "RAP");
		tableMapping.ColumnMappings.Add("TAG", "TAG");
		tableMapping.ColumnMappings.Add("ID", "ID");
		tableMapping.ColumnMappings.Add("UserC", "UserC");
		tableMapping.ColumnMappings.Add("DateC", "DateC");
		tableMapping.ColumnMappings.Add("UserM", "UserM");
		tableMapping.ColumnMappings.Add("DateM", "DateM");
		tableMapping.ColumnMappings.Add("AMOR", "AMOR");
		tableMapping.ColumnMappings.Add("DOT", "DOT");
		tableMapping.ColumnMappings.Add("PROD", "PROD");
		tableMapping.ColumnMappings.Add("LIBAR", "LIBAR");
		_adapter.TableMappings.Add(tableMapping);
		_adapter.DeleteCommand = new OleDbCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM `Comptes` WHERE ((`CPT` = ?) AND ((? = 1 AND `LIB` IS NULL) OR (`LIB` = ?)) AND ((? = 1 AND `IMPUT` IS NULL) OR (`IMPUT` = ?)) AND ((? = 1 AND `TRS` IS NULL) OR (`TRS` = ?)) AND ((? = 1 AND `ANA` IS NULL) OR (`ANA` = ?)) AND ((? = 1 AND `IMMO` IS NULL) OR (`IMMO` = ?)) AND ((? = 1 AND `CML` IS NULL) OR (`CML` = ?)) AND ((? = 1 AND `SNS` IS NULL) OR (`SNS` = ?)) AND ((? = 1 AND `RAP` IS NULL) OR (`RAP` = ?)) AND ((? = 1 AND `TAG` IS NULL) OR (`TAG` = ?)) AND ((? = 1 AND `ID` IS NULL) OR (`ID` = ?)) AND ((? = 1 AND `UserC` IS NULL) OR (`UserC` = ?)) AND ((? = 1 AND `DateC` IS NULL) OR (`DateC` = ?)) AND ((? = 1 AND `UserM` IS NULL) OR (`UserM` = ?)) AND ((? = 1 AND `DateM` IS NULL) OR (`DateM` = ?)) AND ((? = 1 AND `AMOR` IS NULL) OR (`AMOR` = ?)) AND ((? = 1 AND `DOT` IS NULL) OR (`DOT` = ?)) AND ((? = 1 AND `PROD` IS NULL) OR (`PROD` = ?)) AND ((? = 1 AND `LIBAR` IS NULL) OR (`LIBAR` = ?)))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CPT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_LIB", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_IMPUT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "IMPUT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_IMPUT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "IMPUT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TRS", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TRS", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TRS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TRS", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ANA", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ANA", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ANA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ANA", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_IMMO", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "IMMO", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_IMMO", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "IMMO", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CML", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CML", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CML", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CML", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_SNS", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SNS", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_SNS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SNS", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_RAP", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "RAP", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_RAP", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "RAP", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TAG", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TAG", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TAG", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TAG", DataRowVersion.Original, sourceColumnNullMapping: false, null));
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
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_AMOR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "AMOR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_AMOR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "AMOR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_DOT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DOT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_DOT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "DOT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_PROD", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "PROD", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_PROD", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PROD", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_LIBAR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIBAR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_LIBAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIBAR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand = new OleDbCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO `Comptes` (`CPT`, `LIB`, `IMPUT`, `TRS`, `ANA`, `IMMO`, `CML`, `SNS`, `RAP`, `TAG`, `UserC`, `DateC`, `UserM`, `DateM`, `AMOR`, `DOT`, `PROD`, `LIBAR`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CPT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("IMPUT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "IMPUT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TRS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TRS", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ANA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ANA", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("IMMO", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "IMMO", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CML", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CML", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("SNS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SNS", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("RAP", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "RAP", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TAG", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TAG", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("UserC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DateC", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("UserM", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DateM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("AMOR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "AMOR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DOT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "DOT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("PROD", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PROD", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("LIBAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIBAR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand = new OleDbCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE `Comptes` SET `CPT` = ?, `LIB` = ?, `IMPUT` = ?, `TRS` = ?, `ANA` = ?, `IMMO` = ?, `CML` = ?, `SNS` = ?, `RAP` = ?, `TAG` = ?, `UserC` = ?, `DateC` = ?, `UserM` = ?, `DateM` = ?, `AMOR` = ?, `DOT` = ?, `PROD` = ?, `LIBAR` = ? WHERE ((`CPT` = ?) AND ((? = 1 AND `LIB` IS NULL) OR (`LIB` = ?)) AND ((? = 1 AND `IMPUT` IS NULL) OR (`IMPUT` = ?)) AND ((? = 1 AND `TRS` IS NULL) OR (`TRS` = ?)) AND ((? = 1 AND `ANA` IS NULL) OR (`ANA` = ?)) AND ((? = 1 AND `IMMO` IS NULL) OR (`IMMO` = ?)) AND ((? = 1 AND `CML` IS NULL) OR (`CML` = ?)) AND ((? = 1 AND `SNS` IS NULL) OR (`SNS` = ?)) AND ((? = 1 AND `RAP` IS NULL) OR (`RAP` = ?)) AND ((? = 1 AND `TAG` IS NULL) OR (`TAG` = ?)) AND ((? = 1 AND `ID` IS NULL) OR (`ID` = ?)) AND ((? = 1 AND `UserC` IS NULL) OR (`UserC` = ?)) AND ((? = 1 AND `DateC` IS NULL) OR (`DateC` = ?)) AND ((? = 1 AND `UserM` IS NULL) OR (`UserM` = ?)) AND ((? = 1 AND `DateM` IS NULL) OR (`DateM` = ?)) AND ((? = 1 AND `AMOR` IS NULL) OR (`AMOR` = ?)) AND ((? = 1 AND `DOT` IS NULL) OR (`DOT` = ?)) AND ((? = 1 AND `PROD` IS NULL) OR (`PROD` = ?)) AND ((? = 1 AND `LIBAR` IS NULL) OR (`LIBAR` = ?)))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CPT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IMPUT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "IMPUT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TRS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TRS", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ANA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ANA", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IMMO", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "IMMO", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CML", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CML", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("SNS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SNS", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("RAP", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "RAP", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TAG", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TAG", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("UserC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DateC", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("UserM", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DateM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("AMOR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "AMOR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DOT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "DOT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("PROD", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PROD", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("LIBAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIBAR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CPT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_LIB", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_IMPUT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "IMPUT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_IMPUT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "IMPUT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TRS", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TRS", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TRS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TRS", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ANA", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ANA", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ANA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ANA", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_IMMO", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "IMMO", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_IMMO", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "IMMO", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CML", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CML", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CML", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CML", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_SNS", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "SNS", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_SNS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "SNS", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_RAP", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "RAP", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_RAP", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "RAP", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TAG", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TAG", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TAG", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TAG", DataRowVersion.Original, sourceColumnNullMapping: false, null));
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
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_AMOR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "AMOR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_AMOR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "AMOR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_DOT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DOT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_DOT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "DOT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_PROD", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "PROD", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_PROD", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PROD", DataRowVersion.Original, sourceColumnNullMapping: false, null));
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
		_commandCollection = new OleDbCommand[12];
		_commandCollection[0] = new OleDbCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT        CPT, LIB, IMPUT, TRS, ANA, IMMO, CML, SNS, RAP, TAG, ID, UserC, DateC, UserM, DateM, AMOR, DOT, PROD, LIBAR\r\nFROM            Comptes";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[1] = new OleDbCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "SELECT AMOR, ANA, CML, CPT, DOT, DateC, DateM, ID, IMMO, IMPUT, LIB, LIBAR, PROD, RAP, SNS, TAG, TRS, UserC, UserM FROM Comptes WHERE (IMPUT = 'O')";
		_commandCollection[1].CommandType = CommandType.Text;
		_commandCollection[2] = new OleDbCommand();
		_commandCollection[2].Connection = Connection;
		_commandCollection[2].CommandText = "SELECT AMOR, ANA, CML, CPT, DOT, DateC, DateM, ID, IMMO, IMPUT, LIB, LIBAR, PROD, RAP, SNS, TAG, TRS, UserC, UserM FROM Comptes WHERE (IMPUT = 'O') AND (IMMO = 'O')";
		_commandCollection[2].CommandType = CommandType.Text;
		_commandCollection[3] = new OleDbCommand();
		_commandCollection[3].Connection = Connection;
		_commandCollection[3].CommandText = "SELECT AMOR, ANA, CML, CPT, DOT, DateC, DateM, ID, IMMO, IMPUT, LIB, LIBAR, PROD, RAP, SNS, TAG, TRS, UserC, UserM FROM Comptes WHERE (IMPUT = 'O') AND (AMOR = 'O')";
		_commandCollection[3].CommandType = CommandType.Text;
		_commandCollection[4] = new OleDbCommand();
		_commandCollection[4].Connection = Connection;
		_commandCollection[4].CommandText = "SELECT AMOR, ANA, CML, CPT, DOT, DateC, DateM, ID, IMMO, IMPUT, LIB, LIBAR, PROD, RAP, SNS, TAG, TRS, UserC, UserM FROM Comptes WHERE (IMPUT = 'O') AND (DOT = 'O')";
		_commandCollection[4].CommandType = CommandType.Text;
		_commandCollection[5] = new OleDbCommand();
		_commandCollection[5].Connection = Connection;
		_commandCollection[5].CommandText = "SELECT AMOR, ANA, CML, CPT, DOT, DateC, DateM, ID, IMMO, IMPUT, LIB, LIBAR, PROD, RAP, SNS, TAG, TRS, UserC, UserM FROM Comptes WHERE (IMPUT = 'O') AND (PROD = 'O')";
		_commandCollection[5].CommandType = CommandType.Text;
		_commandCollection[6] = new OleDbCommand();
		_commandCollection[6].Connection = Connection;
		_commandCollection[6].CommandText = "SELECT AMOR, ANA, CML, CPT, DOT, DateC, DateM, ID, IMMO, IMPUT, LIB, LIBAR, PROD, RAP, SNS, TAG, TRS, UserC, UserM FROM Comptes WHERE (IMPUT = 'O') AND (AMOR = 'O')";
		_commandCollection[6].CommandType = CommandType.Text;
		_commandCollection[7] = new OleDbCommand();
		_commandCollection[7].Connection = Connection;
		_commandCollection[7].CommandText = "SELECT AMOR, ANA, CML, CPT, DOT, DateC, DateM, ID, IMMO, IMPUT, LIB, LIBAR, PROD, RAP, SNS, TAG, TRS, UserC, UserM FROM Comptes WHERE (IMPUT = 'O') AND (DOT = 'O')";
		_commandCollection[7].CommandType = CommandType.Text;
		_commandCollection[8] = new OleDbCommand();
		_commandCollection[8].Connection = Connection;
		_commandCollection[8].CommandText = "SELECT AMOR, ANA, CML, CPT, DOT, DateC, DateM, ID, IMMO, IMPUT, LIB, LIBAR, PROD, RAP, SNS, TAG, TRS, UserC, UserM FROM Comptes WHERE (IMPUT = 'O') AND (IMMO = 'O')";
		_commandCollection[8].CommandType = CommandType.Text;
		_commandCollection[9] = new OleDbCommand();
		_commandCollection[9].Connection = Connection;
		_commandCollection[9].CommandText = "SELECT AMOR, ANA, CML, CPT, DOT, DateC, DateM, ID, IMMO, IMPUT, LIB, LIBAR, PROD, RAP, SNS, TAG, TRS, UserC, UserM FROM Comptes WHERE (IMPUT = 'O')";
		_commandCollection[9].CommandType = CommandType.Text;
		_commandCollection[10] = new OleDbCommand();
		_commandCollection[10].Connection = Connection;
		_commandCollection[10].CommandText = "SELECT AMOR, ANA, CML, CPT, DOT, DateC, DateM, ID, IMMO, IMPUT, LIB, LIBAR, PROD, RAP, SNS, TAG, TRS, UserC, UserM FROM Comptes WHERE ([INPUT] = 'O')";
		_commandCollection[10].CommandType = CommandType.Text;
		_commandCollection[11] = new OleDbCommand();
		_commandCollection[11].Connection = Connection;
		_commandCollection[11].CommandText = "SELECT AMOR, ANA, CML, CPT, DOT, DateC, DateM, ID, IMMO, IMPUT, LIB, LIBAR, PROD, RAP, SNS, TAG, TRS, UserC, UserM FROM Comptes WHERE (IMPUT = 'O') AND (PROD = 'O')";
		_commandCollection[11].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(DataSet1.ComptesDataTable dataTable)
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
	public virtual DataSet1.ComptesDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		DataSet1.ComptesDataTable dataTable = new DataSet1.ComptesDataTable();
		Adapter.Fill(dataTable);
		return dataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill1(DataSet1.ComptesDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[1];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int FillBy(DataSet1.ComptesDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[2];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int FillBy1(DataSet1.ComptesDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[3];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual DataSet1.ComptesDataTable GetDataBy2()
	{
		Adapter.SelectCommand = CommandCollection[3];
		DataSet1.ComptesDataTable dataTable = new DataSet1.ComptesDataTable();
		Adapter.Fill(dataTable);
		return dataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int FillBy2(DataSet1.ComptesDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[4];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual DataSet1.ComptesDataTable GetDataBy3()
	{
		Adapter.SelectCommand = CommandCollection[4];
		DataSet1.ComptesDataTable dataTable = new DataSet1.ComptesDataTable();
		Adapter.Fill(dataTable);
		return dataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int FillBy3(DataSet1.ComptesDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[5];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual DataSet1.ComptesDataTable GetDataBy4()
	{
		Adapter.SelectCommand = CommandCollection[5];
		DataSet1.ComptesDataTable dataTable = new DataSet1.ComptesDataTable();
		Adapter.Fill(dataTable);
		return dataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int FillByAMOR(DataSet1.ComptesDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[6];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int FillByDot(DataSet1.ComptesDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[7];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int FillByIMO(DataSet1.ComptesDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[8];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int FillByIMPUT(DataSet1.ComptesDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[9];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual DataSet1.ComptesDataTable GetDataBy9()
	{
		Adapter.SelectCommand = CommandCollection[9];
		DataSet1.ComptesDataTable dataTable = new DataSet1.ComptesDataTable();
		Adapter.Fill(dataTable);
		return dataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int FillByIMPUT1(DataSet1.ComptesDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[10];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int FillByProd(DataSet1.ComptesDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[11];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet1.ComptesDataTable dataTable)
	{
		return Adapter.Update(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet1 dataSet)
	{
		return Adapter.Update(dataSet, "Comptes");
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
	public virtual int Delete(string Original_CPT, string Original_LIB, string Original_IMPUT, string Original_TRS, string Original_ANA, string Original_IMMO, string Original_CML, string Original_SNS, string Original_RAP, string Original_TAG, int Original_ID, string Original_UserC, DateTime? Original_DateC, string Original_UserM, DateTime? Original_DateM, string Original_AMOR, string Original_DOT, string Original_PROD, string Original_LIBAR)
	{
		if (Original_CPT == null)
		{
			Adapter.DeleteCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[0].Value = Original_CPT;
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
		if (Original_IMPUT == null)
		{
			Adapter.DeleteCommand.Parameters[3].Value = 1;
			Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[3].Value = 0;
			Adapter.DeleteCommand.Parameters[4].Value = Original_IMPUT;
		}
		if (Original_TRS == null)
		{
			Adapter.DeleteCommand.Parameters[5].Value = 1;
			Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[5].Value = 0;
			Adapter.DeleteCommand.Parameters[6].Value = Original_TRS;
		}
		if (Original_ANA == null)
		{
			Adapter.DeleteCommand.Parameters[7].Value = 1;
			Adapter.DeleteCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[7].Value = 0;
			Adapter.DeleteCommand.Parameters[8].Value = Original_ANA;
		}
		if (Original_IMMO == null)
		{
			Adapter.DeleteCommand.Parameters[9].Value = 1;
			Adapter.DeleteCommand.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[9].Value = 0;
			Adapter.DeleteCommand.Parameters[10].Value = Original_IMMO;
		}
		if (Original_CML == null)
		{
			Adapter.DeleteCommand.Parameters[11].Value = 1;
			Adapter.DeleteCommand.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[11].Value = 0;
			Adapter.DeleteCommand.Parameters[12].Value = Original_CML;
		}
		if (Original_SNS == null)
		{
			Adapter.DeleteCommand.Parameters[13].Value = 1;
			Adapter.DeleteCommand.Parameters[14].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[13].Value = 0;
			Adapter.DeleteCommand.Parameters[14].Value = Original_SNS;
		}
		if (Original_RAP == null)
		{
			Adapter.DeleteCommand.Parameters[15].Value = 1;
			Adapter.DeleteCommand.Parameters[16].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[15].Value = 0;
			Adapter.DeleteCommand.Parameters[16].Value = Original_RAP;
		}
		if (Original_TAG == null)
		{
			Adapter.DeleteCommand.Parameters[17].Value = 1;
			Adapter.DeleteCommand.Parameters[18].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[17].Value = 0;
			Adapter.DeleteCommand.Parameters[18].Value = Original_TAG;
		}
		Adapter.DeleteCommand.Parameters[19].Value = 0;
		Adapter.DeleteCommand.Parameters[20].Value = Original_ID;
		if (Original_UserC == null)
		{
			Adapter.DeleteCommand.Parameters[21].Value = 1;
			Adapter.DeleteCommand.Parameters[22].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[21].Value = 0;
			Adapter.DeleteCommand.Parameters[22].Value = Original_UserC;
		}
		if (Original_DateC.HasValue)
		{
			Adapter.DeleteCommand.Parameters[23].Value = 0;
			Adapter.DeleteCommand.Parameters[24].Value = Original_DateC.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[23].Value = 1;
			Adapter.DeleteCommand.Parameters[24].Value = DBNull.Value;
		}
		if (Original_UserM == null)
		{
			Adapter.DeleteCommand.Parameters[25].Value = 1;
			Adapter.DeleteCommand.Parameters[26].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[25].Value = 0;
			Adapter.DeleteCommand.Parameters[26].Value = Original_UserM;
		}
		if (Original_DateM.HasValue)
		{
			Adapter.DeleteCommand.Parameters[27].Value = 0;
			Adapter.DeleteCommand.Parameters[28].Value = Original_DateM.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[27].Value = 1;
			Adapter.DeleteCommand.Parameters[28].Value = DBNull.Value;
		}
		if (Original_AMOR == null)
		{
			Adapter.DeleteCommand.Parameters[29].Value = 1;
			Adapter.DeleteCommand.Parameters[30].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[29].Value = 0;
			Adapter.DeleteCommand.Parameters[30].Value = Original_AMOR;
		}
		if (Original_DOT == null)
		{
			Adapter.DeleteCommand.Parameters[31].Value = 1;
			Adapter.DeleteCommand.Parameters[32].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[31].Value = 0;
			Adapter.DeleteCommand.Parameters[32].Value = Original_DOT;
		}
		if (Original_PROD == null)
		{
			Adapter.DeleteCommand.Parameters[33].Value = 1;
			Adapter.DeleteCommand.Parameters[34].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[33].Value = 0;
			Adapter.DeleteCommand.Parameters[34].Value = Original_PROD;
		}
		if (Original_LIBAR == null)
		{
			Adapter.DeleteCommand.Parameters[35].Value = 1;
			Adapter.DeleteCommand.Parameters[36].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[35].Value = 0;
			Adapter.DeleteCommand.Parameters[36].Value = Original_LIBAR;
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
	public virtual int Insert(string CPT, string LIB, string IMPUT, string TRS, string ANA, string IMMO, string CML, string SNS, string RAP, string TAG, string UserC, DateTime? DateC, string UserM, DateTime? DateM, string AMOR, string DOT, string PROD, string LIBAR)
	{
		if (CPT == null)
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = CPT;
		}
		if (LIB == null)
		{
			Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[1].Value = LIB;
		}
		if (IMPUT == null)
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = IMPUT;
		}
		if (TRS == null)
		{
			Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[3].Value = TRS;
		}
		if (ANA == null)
		{
			Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[4].Value = ANA;
		}
		if (IMMO == null)
		{
			Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[5].Value = IMMO;
		}
		if (CML == null)
		{
			Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[6].Value = CML;
		}
		if (SNS == null)
		{
			Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[7].Value = SNS;
		}
		if (RAP == null)
		{
			Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[8].Value = RAP;
		}
		if (TAG == null)
		{
			Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[9].Value = TAG;
		}
		if (UserC == null)
		{
			Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[10].Value = UserC;
		}
		if (DateC.HasValue)
		{
			Adapter.InsertCommand.Parameters[11].Value = DateC.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
		}
		if (UserM == null)
		{
			Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[12].Value = UserM;
		}
		if (DateM.HasValue)
		{
			Adapter.InsertCommand.Parameters[13].Value = DateM.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[13].Value = DBNull.Value;
		}
		if (AMOR == null)
		{
			Adapter.InsertCommand.Parameters[14].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[14].Value = AMOR;
		}
		if (DOT == null)
		{
			Adapter.InsertCommand.Parameters[15].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[15].Value = DOT;
		}
		if (PROD == null)
		{
			Adapter.InsertCommand.Parameters[16].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[16].Value = PROD;
		}
		if (LIBAR == null)
		{
			Adapter.InsertCommand.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[17].Value = LIBAR;
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
	public virtual int Update(string CPT, string LIB, string IMPUT, string TRS, string ANA, string IMMO, string CML, string SNS, string RAP, string TAG, string UserC, DateTime? DateC, string UserM, DateTime? DateM, string AMOR, string DOT, string PROD, string LIBAR, string Original_CPT, string Original_LIB, string Original_IMPUT, string Original_TRS, string Original_ANA, string Original_IMMO, string Original_CML, string Original_SNS, string Original_RAP, string Original_TAG, int Original_ID, string Original_UserC, DateTime? Original_DateC, string Original_UserM, DateTime? Original_DateM, string Original_AMOR, string Original_DOT, string Original_PROD, string Original_LIBAR)
	{
		if (CPT == null)
		{
			Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[0].Value = CPT;
		}
		if (LIB == null)
		{
			Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[1].Value = LIB;
		}
		if (IMPUT == null)
		{
			Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[2].Value = IMPUT;
		}
		if (TRS == null)
		{
			Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[3].Value = TRS;
		}
		if (ANA == null)
		{
			Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[4].Value = ANA;
		}
		if (IMMO == null)
		{
			Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[5].Value = IMMO;
		}
		if (CML == null)
		{
			Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[6].Value = CML;
		}
		if (SNS == null)
		{
			Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[7].Value = SNS;
		}
		if (RAP == null)
		{
			Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[8].Value = RAP;
		}
		if (TAG == null)
		{
			Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[9].Value = TAG;
		}
		if (UserC == null)
		{
			Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[10].Value = UserC;
		}
		if (DateC.HasValue)
		{
			Adapter.UpdateCommand.Parameters[11].Value = DateC.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
		}
		if (UserM == null)
		{
			Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[12].Value = UserM;
		}
		if (DateM.HasValue)
		{
			Adapter.UpdateCommand.Parameters[13].Value = DateM.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
		}
		if (AMOR == null)
		{
			Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[14].Value = AMOR;
		}
		if (DOT == null)
		{
			Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[15].Value = DOT;
		}
		if (PROD == null)
		{
			Adapter.UpdateCommand.Parameters[16].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[16].Value = PROD;
		}
		if (LIBAR == null)
		{
			Adapter.UpdateCommand.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[17].Value = LIBAR;
		}
		if (Original_CPT == null)
		{
			Adapter.UpdateCommand.Parameters[18].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[18].Value = Original_CPT;
		}
		if (Original_LIB == null)
		{
			Adapter.UpdateCommand.Parameters[19].Value = 1;
			Adapter.UpdateCommand.Parameters[20].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[19].Value = 0;
			Adapter.UpdateCommand.Parameters[20].Value = Original_LIB;
		}
		if (Original_IMPUT == null)
		{
			Adapter.UpdateCommand.Parameters[21].Value = 1;
			Adapter.UpdateCommand.Parameters[22].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[21].Value = 0;
			Adapter.UpdateCommand.Parameters[22].Value = Original_IMPUT;
		}
		if (Original_TRS == null)
		{
			Adapter.UpdateCommand.Parameters[23].Value = 1;
			Adapter.UpdateCommand.Parameters[24].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[23].Value = 0;
			Adapter.UpdateCommand.Parameters[24].Value = Original_TRS;
		}
		if (Original_ANA == null)
		{
			Adapter.UpdateCommand.Parameters[25].Value = 1;
			Adapter.UpdateCommand.Parameters[26].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[25].Value = 0;
			Adapter.UpdateCommand.Parameters[26].Value = Original_ANA;
		}
		if (Original_IMMO == null)
		{
			Adapter.UpdateCommand.Parameters[27].Value = 1;
			Adapter.UpdateCommand.Parameters[28].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[27].Value = 0;
			Adapter.UpdateCommand.Parameters[28].Value = Original_IMMO;
		}
		if (Original_CML == null)
		{
			Adapter.UpdateCommand.Parameters[29].Value = 1;
			Adapter.UpdateCommand.Parameters[30].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[29].Value = 0;
			Adapter.UpdateCommand.Parameters[30].Value = Original_CML;
		}
		if (Original_SNS == null)
		{
			Adapter.UpdateCommand.Parameters[31].Value = 1;
			Adapter.UpdateCommand.Parameters[32].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[31].Value = 0;
			Adapter.UpdateCommand.Parameters[32].Value = Original_SNS;
		}
		if (Original_RAP == null)
		{
			Adapter.UpdateCommand.Parameters[33].Value = 1;
			Adapter.UpdateCommand.Parameters[34].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[33].Value = 0;
			Adapter.UpdateCommand.Parameters[34].Value = Original_RAP;
		}
		if (Original_TAG == null)
		{
			Adapter.UpdateCommand.Parameters[35].Value = 1;
			Adapter.UpdateCommand.Parameters[36].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[35].Value = 0;
			Adapter.UpdateCommand.Parameters[36].Value = Original_TAG;
		}
		Adapter.UpdateCommand.Parameters[37].Value = 0;
		Adapter.UpdateCommand.Parameters[38].Value = Original_ID;
		if (Original_UserC == null)
		{
			Adapter.UpdateCommand.Parameters[39].Value = 1;
			Adapter.UpdateCommand.Parameters[40].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[39].Value = 0;
			Adapter.UpdateCommand.Parameters[40].Value = Original_UserC;
		}
		if (Original_DateC.HasValue)
		{
			Adapter.UpdateCommand.Parameters[41].Value = 0;
			Adapter.UpdateCommand.Parameters[42].Value = Original_DateC.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[41].Value = 1;
			Adapter.UpdateCommand.Parameters[42].Value = DBNull.Value;
		}
		if (Original_UserM == null)
		{
			Adapter.UpdateCommand.Parameters[43].Value = 1;
			Adapter.UpdateCommand.Parameters[44].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[43].Value = 0;
			Adapter.UpdateCommand.Parameters[44].Value = Original_UserM;
		}
		if (Original_DateM.HasValue)
		{
			Adapter.UpdateCommand.Parameters[45].Value = 0;
			Adapter.UpdateCommand.Parameters[46].Value = Original_DateM.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[45].Value = 1;
			Adapter.UpdateCommand.Parameters[46].Value = DBNull.Value;
		}
		if (Original_AMOR == null)
		{
			Adapter.UpdateCommand.Parameters[47].Value = 1;
			Adapter.UpdateCommand.Parameters[48].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[47].Value = 0;
			Adapter.UpdateCommand.Parameters[48].Value = Original_AMOR;
		}
		if (Original_DOT == null)
		{
			Adapter.UpdateCommand.Parameters[49].Value = 1;
			Adapter.UpdateCommand.Parameters[50].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[49].Value = 0;
			Adapter.UpdateCommand.Parameters[50].Value = Original_DOT;
		}
		if (Original_PROD == null)
		{
			Adapter.UpdateCommand.Parameters[51].Value = 1;
			Adapter.UpdateCommand.Parameters[52].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[51].Value = 0;
			Adapter.UpdateCommand.Parameters[52].Value = Original_PROD;
		}
		if (Original_LIBAR == null)
		{
			Adapter.UpdateCommand.Parameters[53].Value = 1;
			Adapter.UpdateCommand.Parameters[54].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[53].Value = 0;
			Adapter.UpdateCommand.Parameters[54].Value = Original_LIBAR;
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
	public virtual int Update(string LIB, string IMPUT, string TRS, string ANA, string IMMO, string CML, string SNS, string RAP, string TAG, string UserC, DateTime? DateC, string UserM, DateTime? DateM, string AMOR, string DOT, string PROD, string LIBAR, string Original_CPT, string Original_LIB, string Original_IMPUT, string Original_TRS, string Original_ANA, string Original_IMMO, string Original_CML, string Original_SNS, string Original_RAP, string Original_TAG, int Original_ID, string Original_UserC, DateTime? Original_DateC, string Original_UserM, DateTime? Original_DateM, string Original_AMOR, string Original_DOT, string Original_PROD, string Original_LIBAR)
	{
		return Update(Original_CPT, LIB, IMPUT, TRS, ANA, IMMO, CML, SNS, RAP, TAG, UserC, DateC, UserM, DateM, AMOR, DOT, PROD, LIBAR, Original_CPT, Original_LIB, Original_IMPUT, Original_TRS, Original_ANA, Original_IMMO, Original_CML, Original_SNS, Original_RAP, Original_TAG, Original_ID, Original_UserC, Original_DateC, Original_UserM, Original_DateM, Original_AMOR, Original_DOT, Original_PROD, Original_LIBAR);
	}
}
