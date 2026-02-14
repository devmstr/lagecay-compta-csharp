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
public class Ecritures00TableAdapter : Component
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
	public Ecritures00TableAdapter()
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
		tableMapping.DataSetTable = "Ecritures00";
		tableMapping.ColumnMappings.Add("UNI", "UNI");
		tableMapping.ColumnMappings.Add("Exercice", "Exercice");
		tableMapping.ColumnMappings.Add("JA", "JA");
		tableMapping.ColumnMappings.Add("NOP", "NOP");
		tableMapping.ColumnMappings.Add("LIG", "LIG");
		tableMapping.ColumnMappings.Add("CPT", "CPT");
		tableMapping.ColumnMappings.Add("TRS", "TRS");
		tableMapping.ColumnMappings.Add("DAT", "DAT");
		tableMapping.ColumnMappings.Add("LIB", "LIB");
		tableMapping.ColumnMappings.Add("DEB", "DEB");
		tableMapping.ColumnMappings.Add("CRE", "CRE");
		tableMapping.ColumnMappings.Add("PTG", "PTG");
		tableMapping.ColumnMappings.Add("PTGX", "PTGX");
		tableMapping.ColumnMappings.Add("RAP", "RAP");
		tableMapping.ColumnMappings.Add("ID", "ID");
		tableMapping.ColumnMappings.Add("Jour", "Jour");
		tableMapping.ColumnMappings.Add("UserC", "UserC");
		tableMapping.ColumnMappings.Add("DateC", "DateC");
		tableMapping.ColumnMappings.Add("UserM", "UserM");
		tableMapping.ColumnMappings.Add("DateM", "DateM");
		_adapter.TableMappings.Add(tableMapping);
		_adapter.DeleteCommand = new OleDbCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM `Ecritures00` WHERE (((? = 1 AND `UNI` IS NULL) OR (`UNI` = ?)) AND ((? = 1 AND `Exercice` IS NULL) OR (`Exercice` = ?)) AND ((? = 1 AND `JA` IS NULL) OR (`JA` = ?)) AND ((? = 1 AND `NOP` IS NULL) OR (`NOP` = ?)) AND ((? = 1 AND `LIG` IS NULL) OR (`LIG` = ?)) AND ((? = 1 AND `CPT` IS NULL) OR (`CPT` = ?)) AND ((? = 1 AND `TRS` IS NULL) OR (`TRS` = ?)) AND ((? = 1 AND `DAT` IS NULL) OR (`DAT` = ?)) AND ((? = 1 AND `LIB` IS NULL) OR (`LIB` = ?)) AND ((? = 1 AND `DEB` IS NULL) OR (`DEB` = ?)) AND ((? = 1 AND `CRE` IS NULL) OR (`CRE` = ?)) AND ((? = 1 AND `PTG` IS NULL) OR (`PTG` = ?)) AND ((? = 1 AND `PTGX` IS NULL) OR (`PTGX` = ?)) AND ((? = 1 AND `RAP` IS NULL) OR (`RAP` = ?)) AND (`ID` = ?) AND ((? = 1 AND `Jour` IS NULL) OR (`Jour` = ?)) AND ((? = 1 AND `UserC` IS NULL) OR (`UserC` = ?)) AND ((? = 1 AND `DateC` IS NULL) OR (`DateC` = ?)) AND ((? = 1 AND `UserM` IS NULL) OR (`UserM` = ?)) AND ((? = 1 AND `DateM` IS NULL) OR (`DateM` = ?)))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_UNI", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "UNI", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_UNI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UNI", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_Exercice", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Exercice", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Exercice", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Exercice", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_JA", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "JA", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_JA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "JA", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_NOP", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "NOP", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_NOP", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "NOP", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_LIG", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIG", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_LIG", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIG", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CPT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CPT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TRS", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TRS", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TRS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TRS", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_DAT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DAT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_DAT", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DAT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_LIB", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_DEB", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DEB", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_DEB", OleDbType.Numeric, 0, ParameterDirection.Input, 18, 2, "DEB", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CRE", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CRE", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CRE", OleDbType.Numeric, 0, ParameterDirection.Input, 18, 2, "CRE", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_PTG", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "PTG", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_PTG", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PTG", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_PTGX", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "PTGX", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_PTGX", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PTGX", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_RAP", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "RAP", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_RAP", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "RAP", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_Jour", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Jour", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Jour", OleDbType.UnsignedTinyInt, 0, ParameterDirection.Input, 0, 0, "Jour", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_UserC", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_UserC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_DateC", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_DateC", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_UserM", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_UserM", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_DateM", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_DateM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand = new OleDbCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO `Ecritures00` (`UNI`, `Exercice`, `JA`, `NOP`, `LIG`, `CPT`, `TRS`, `DAT`, `LIB`, `DEB`, `CRE`, `PTG`, `PTGX`, `RAP`, `Jour`, `UserC`, `DateC`, `UserM`, `DateM`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("UNI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UNI", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("Exercice", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Exercice", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("JA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "JA", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("NOP", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "NOP", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("LIG", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIG", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CPT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TRS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TRS", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DAT", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DAT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DEB", OleDbType.Numeric, 0, ParameterDirection.Input, 18, 2, "DEB", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CRE", OleDbType.Numeric, 0, ParameterDirection.Input, 18, 2, "CRE", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("PTG", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PTG", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("PTGX", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PTGX", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("RAP", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "RAP", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("Jour", OleDbType.UnsignedTinyInt, 0, ParameterDirection.Input, 0, 0, "Jour", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("UserC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DateC", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("UserM", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DateM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand = new OleDbCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE `Ecritures00` SET `UNI` = ?, `Exercice` = ?, `JA` = ?, `NOP` = ?, `LIG` = ?, `CPT` = ?, `TRS` = ?, `DAT` = ?, `LIB` = ?, `DEB` = ?, `CRE` = ?, `PTG` = ?, `PTGX` = ?, `RAP` = ?, `Jour` = ?, `UserC` = ?, `DateC` = ?, `UserM` = ?, `DateM` = ? WHERE (((? = 1 AND `UNI` IS NULL) OR (`UNI` = ?)) AND ((? = 1 AND `Exercice` IS NULL) OR (`Exercice` = ?)) AND ((? = 1 AND `JA` IS NULL) OR (`JA` = ?)) AND ((? = 1 AND `NOP` IS NULL) OR (`NOP` = ?)) AND ((? = 1 AND `LIG` IS NULL) OR (`LIG` = ?)) AND ((? = 1 AND `CPT` IS NULL) OR (`CPT` = ?)) AND ((? = 1 AND `TRS` IS NULL) OR (`TRS` = ?)) AND ((? = 1 AND `DAT` IS NULL) OR (`DAT` = ?)) AND ((? = 1 AND `LIB` IS NULL) OR (`LIB` = ?)) AND ((? = 1 AND `DEB` IS NULL) OR (`DEB` = ?)) AND ((? = 1 AND `CRE` IS NULL) OR (`CRE` = ?)) AND ((? = 1 AND `PTG` IS NULL) OR (`PTG` = ?)) AND ((? = 1 AND `PTGX` IS NULL) OR (`PTGX` = ?)) AND ((? = 1 AND `RAP` IS NULL) OR (`RAP` = ?)) AND (`ID` = ?) AND ((? = 1 AND `Jour` IS NULL) OR (`Jour` = ?)) AND ((? = 1 AND `UserC` IS NULL) OR (`UserC` = ?)) AND ((? = 1 AND `DateC` IS NULL) OR (`DateC` = ?)) AND ((? = 1 AND `UserM` IS NULL) OR (`UserM` = ?)) AND ((? = 1 AND `DateM` IS NULL) OR (`DateM` = ?)))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("UNI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UNI", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Exercice", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Exercice", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("JA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "JA", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("NOP", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "NOP", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("LIG", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIG", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CPT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TRS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TRS", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DAT", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DAT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DEB", OleDbType.Numeric, 0, ParameterDirection.Input, 18, 2, "DEB", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CRE", OleDbType.Numeric, 0, ParameterDirection.Input, 18, 2, "CRE", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("PTG", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PTG", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("PTGX", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PTGX", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("RAP", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "RAP", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Jour", OleDbType.UnsignedTinyInt, 0, ParameterDirection.Input, 0, 0, "Jour", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("UserC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DateC", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("UserM", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DateM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_UNI", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "UNI", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_UNI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UNI", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_Exercice", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Exercice", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Exercice", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Exercice", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_JA", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "JA", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_JA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "JA", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_NOP", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "NOP", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_NOP", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "NOP", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_LIG", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIG", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_LIG", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIG", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CPT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CPT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TRS", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TRS", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TRS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TRS", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_DAT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DAT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_DAT", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DAT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_LIB", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_DEB", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DEB", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_DEB", OleDbType.Numeric, 0, ParameterDirection.Input, 18, 2, "DEB", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CRE", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CRE", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CRE", OleDbType.Numeric, 0, ParameterDirection.Input, 18, 2, "CRE", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_PTG", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "PTG", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_PTG", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PTG", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_PTGX", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "PTGX", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_PTGX", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "PTGX", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_RAP", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "RAP", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_RAP", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "RAP", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_Jour", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Jour", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Jour", OleDbType.UnsignedTinyInt, 0, ParameterDirection.Input, 0, 0, "Jour", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_UserC", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_UserC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_DateC", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_DateC", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_UserM", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_UserM", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_DateM", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_DateM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Original, sourceColumnNullMapping: false, null));
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
		_commandCollection[0].CommandText = "SELECT UNI, Exercice, JA, NOP, LIG, CPT, TRS, DAT, LIB, DEB, CRE, PTG, PTGX, RAP, ID, Jour, UserC, DateC, UserM, DateM FROM Ecritures00";
		_commandCollection[0].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(DataSet1.Ecritures00DataTable dataTable)
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
	public virtual DataSet1.Ecritures00DataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		DataSet1.Ecritures00DataTable dataTable = new DataSet1.Ecritures00DataTable();
		Adapter.Fill(dataTable);
		return dataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet1.Ecritures00DataTable dataTable)
	{
		return Adapter.Update(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet1 dataSet)
	{
		return Adapter.Update(dataSet, "Ecritures00");
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
	public virtual int Delete(string Original_UNI, int? Original_Exercice, string Original_JA, string Original_NOP, int? Original_LIG, string Original_CPT, string Original_TRS, DateTime? Original_DAT, string Original_LIB, decimal? Original_DEB, decimal? Original_CRE, string Original_PTG, string Original_PTGX, string Original_RAP, int Original_ID, byte? Original_Jour, string Original_UserC, DateTime? Original_DateC, string Original_UserM, DateTime? Original_DateM)
	{
		if (Original_UNI == null)
		{
			Adapter.DeleteCommand.Parameters[0].Value = 1;
			Adapter.DeleteCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[0].Value = 0;
			Adapter.DeleteCommand.Parameters[1].Value = Original_UNI;
		}
		if (Original_Exercice.HasValue)
		{
			Adapter.DeleteCommand.Parameters[2].Value = 0;
			Adapter.DeleteCommand.Parameters[3].Value = Original_Exercice.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[2].Value = 1;
			Adapter.DeleteCommand.Parameters[3].Value = DBNull.Value;
		}
		if (Original_JA == null)
		{
			Adapter.DeleteCommand.Parameters[4].Value = 1;
			Adapter.DeleteCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[4].Value = 0;
			Adapter.DeleteCommand.Parameters[5].Value = Original_JA;
		}
		if (Original_NOP == null)
		{
			Adapter.DeleteCommand.Parameters[6].Value = 1;
			Adapter.DeleteCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[6].Value = 0;
			Adapter.DeleteCommand.Parameters[7].Value = Original_NOP;
		}
		if (Original_LIG.HasValue)
		{
			Adapter.DeleteCommand.Parameters[8].Value = 0;
			Adapter.DeleteCommand.Parameters[9].Value = Original_LIG.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[8].Value = 1;
			Adapter.DeleteCommand.Parameters[9].Value = DBNull.Value;
		}
		if (Original_CPT == null)
		{
			Adapter.DeleteCommand.Parameters[10].Value = 1;
			Adapter.DeleteCommand.Parameters[11].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[10].Value = 0;
			Adapter.DeleteCommand.Parameters[11].Value = Original_CPT;
		}
		if (Original_TRS == null)
		{
			Adapter.DeleteCommand.Parameters[12].Value = 1;
			Adapter.DeleteCommand.Parameters[13].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[12].Value = 0;
			Adapter.DeleteCommand.Parameters[13].Value = Original_TRS;
		}
		if (Original_DAT.HasValue)
		{
			Adapter.DeleteCommand.Parameters[14].Value = 0;
			Adapter.DeleteCommand.Parameters[15].Value = Original_DAT.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[14].Value = 1;
			Adapter.DeleteCommand.Parameters[15].Value = DBNull.Value;
		}
		if (Original_LIB == null)
		{
			Adapter.DeleteCommand.Parameters[16].Value = 1;
			Adapter.DeleteCommand.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[16].Value = 0;
			Adapter.DeleteCommand.Parameters[17].Value = Original_LIB;
		}
		if (Original_DEB.HasValue)
		{
			Adapter.DeleteCommand.Parameters[18].Value = 0;
			Adapter.DeleteCommand.Parameters[19].Value = Original_DEB.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[18].Value = 1;
			Adapter.DeleteCommand.Parameters[19].Value = DBNull.Value;
		}
		if (Original_CRE.HasValue)
		{
			Adapter.DeleteCommand.Parameters[20].Value = 0;
			Adapter.DeleteCommand.Parameters[21].Value = Original_CRE.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[20].Value = 1;
			Adapter.DeleteCommand.Parameters[21].Value = DBNull.Value;
		}
		if (Original_PTG == null)
		{
			Adapter.DeleteCommand.Parameters[22].Value = 1;
			Adapter.DeleteCommand.Parameters[23].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[22].Value = 0;
			Adapter.DeleteCommand.Parameters[23].Value = Original_PTG;
		}
		if (Original_PTGX == null)
		{
			Adapter.DeleteCommand.Parameters[24].Value = 1;
			Adapter.DeleteCommand.Parameters[25].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[24].Value = 0;
			Adapter.DeleteCommand.Parameters[25].Value = Original_PTGX;
		}
		if (Original_RAP == null)
		{
			Adapter.DeleteCommand.Parameters[26].Value = 1;
			Adapter.DeleteCommand.Parameters[27].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[26].Value = 0;
			Adapter.DeleteCommand.Parameters[27].Value = Original_RAP;
		}
		Adapter.DeleteCommand.Parameters[28].Value = Original_ID;
		if (Original_Jour.HasValue)
		{
			Adapter.DeleteCommand.Parameters[29].Value = 0;
			Adapter.DeleteCommand.Parameters[30].Value = Original_Jour.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[29].Value = 1;
			Adapter.DeleteCommand.Parameters[30].Value = DBNull.Value;
		}
		if (Original_UserC == null)
		{
			Adapter.DeleteCommand.Parameters[31].Value = 1;
			Adapter.DeleteCommand.Parameters[32].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[31].Value = 0;
			Adapter.DeleteCommand.Parameters[32].Value = Original_UserC;
		}
		if (Original_DateC.HasValue)
		{
			Adapter.DeleteCommand.Parameters[33].Value = 0;
			Adapter.DeleteCommand.Parameters[34].Value = Original_DateC.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[33].Value = 1;
			Adapter.DeleteCommand.Parameters[34].Value = DBNull.Value;
		}
		if (Original_UserM == null)
		{
			Adapter.DeleteCommand.Parameters[35].Value = 1;
			Adapter.DeleteCommand.Parameters[36].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[35].Value = 0;
			Adapter.DeleteCommand.Parameters[36].Value = Original_UserM;
		}
		if (Original_DateM.HasValue)
		{
			Adapter.DeleteCommand.Parameters[37].Value = 0;
			Adapter.DeleteCommand.Parameters[38].Value = Original_DateM.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[37].Value = 1;
			Adapter.DeleteCommand.Parameters[38].Value = DBNull.Value;
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
	public virtual int Insert(string UNI, int? Exercice, string JA, string NOP, int? LIG, string CPT, string TRS, DateTime? DAT, string LIB, decimal? DEB, decimal? CRE, string PTG, string PTGX, string RAP, byte? Jour, string UserC, DateTime? DateC, string UserM, DateTime? DateM)
	{
		if (UNI == null)
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = UNI;
		}
		if (Exercice.HasValue)
		{
			Adapter.InsertCommand.Parameters[1].Value = Exercice.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
		}
		if (JA == null)
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = JA;
		}
		if (NOP == null)
		{
			Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[3].Value = NOP;
		}
		if (LIG.HasValue)
		{
			Adapter.InsertCommand.Parameters[4].Value = LIG.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
		}
		if (CPT == null)
		{
			Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[5].Value = CPT;
		}
		if (TRS == null)
		{
			Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[6].Value = TRS;
		}
		if (DAT.HasValue)
		{
			Adapter.InsertCommand.Parameters[7].Value = DAT.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
		}
		if (LIB == null)
		{
			Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[8].Value = LIB;
		}
		if (DEB.HasValue)
		{
			Adapter.InsertCommand.Parameters[9].Value = DEB.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
		}
		if (CRE.HasValue)
		{
			Adapter.InsertCommand.Parameters[10].Value = CRE.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
		}
		if (PTG == null)
		{
			Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[11].Value = PTG;
		}
		if (PTGX == null)
		{
			Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[12].Value = PTGX;
		}
		if (RAP == null)
		{
			Adapter.InsertCommand.Parameters[13].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[13].Value = RAP;
		}
		if (Jour.HasValue)
		{
			Adapter.InsertCommand.Parameters[14].Value = Jour.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[14].Value = DBNull.Value;
		}
		if (UserC == null)
		{
			Adapter.InsertCommand.Parameters[15].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[15].Value = UserC;
		}
		if (DateC.HasValue)
		{
			Adapter.InsertCommand.Parameters[16].Value = DateC.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[16].Value = DBNull.Value;
		}
		if (UserM == null)
		{
			Adapter.InsertCommand.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[17].Value = UserM;
		}
		if (DateM.HasValue)
		{
			Adapter.InsertCommand.Parameters[18].Value = DateM.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[18].Value = DBNull.Value;
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
	public virtual int Update(string UNI, int? Exercice, string JA, string NOP, int? LIG, string CPT, string TRS, DateTime? DAT, string LIB, decimal? DEB, decimal? CRE, string PTG, string PTGX, string RAP, byte? Jour, string UserC, DateTime? DateC, string UserM, DateTime? DateM, string Original_UNI, int? Original_Exercice, string Original_JA, string Original_NOP, int? Original_LIG, string Original_CPT, string Original_TRS, DateTime? Original_DAT, string Original_LIB, decimal? Original_DEB, decimal? Original_CRE, string Original_PTG, string Original_PTGX, string Original_RAP, int Original_ID, byte? Original_Jour, string Original_UserC, DateTime? Original_DateC, string Original_UserM, DateTime? Original_DateM)
	{
		if (UNI == null)
		{
			Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[0].Value = UNI;
		}
		if (Exercice.HasValue)
		{
			Adapter.UpdateCommand.Parameters[1].Value = Exercice.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
		}
		if (JA == null)
		{
			Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[2].Value = JA;
		}
		if (NOP == null)
		{
			Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[3].Value = NOP;
		}
		if (LIG.HasValue)
		{
			Adapter.UpdateCommand.Parameters[4].Value = LIG.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
		}
		if (CPT == null)
		{
			Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[5].Value = CPT;
		}
		if (TRS == null)
		{
			Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[6].Value = TRS;
		}
		if (DAT.HasValue)
		{
			Adapter.UpdateCommand.Parameters[7].Value = DAT.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
		}
		if (LIB == null)
		{
			Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[8].Value = LIB;
		}
		if (DEB.HasValue)
		{
			Adapter.UpdateCommand.Parameters[9].Value = DEB.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
		}
		if (CRE.HasValue)
		{
			Adapter.UpdateCommand.Parameters[10].Value = CRE.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
		}
		if (PTG == null)
		{
			Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[11].Value = PTG;
		}
		if (PTGX == null)
		{
			Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[12].Value = PTGX;
		}
		if (RAP == null)
		{
			Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[13].Value = RAP;
		}
		if (Jour.HasValue)
		{
			Adapter.UpdateCommand.Parameters[14].Value = Jour.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
		}
		if (UserC == null)
		{
			Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[15].Value = UserC;
		}
		if (DateC.HasValue)
		{
			Adapter.UpdateCommand.Parameters[16].Value = DateC.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[16].Value = DBNull.Value;
		}
		if (UserM == null)
		{
			Adapter.UpdateCommand.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[17].Value = UserM;
		}
		if (DateM.HasValue)
		{
			Adapter.UpdateCommand.Parameters[18].Value = DateM.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[18].Value = DBNull.Value;
		}
		if (Original_UNI == null)
		{
			Adapter.UpdateCommand.Parameters[19].Value = 1;
			Adapter.UpdateCommand.Parameters[20].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[19].Value = 0;
			Adapter.UpdateCommand.Parameters[20].Value = Original_UNI;
		}
		if (Original_Exercice.HasValue)
		{
			Adapter.UpdateCommand.Parameters[21].Value = 0;
			Adapter.UpdateCommand.Parameters[22].Value = Original_Exercice.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[21].Value = 1;
			Adapter.UpdateCommand.Parameters[22].Value = DBNull.Value;
		}
		if (Original_JA == null)
		{
			Adapter.UpdateCommand.Parameters[23].Value = 1;
			Adapter.UpdateCommand.Parameters[24].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[23].Value = 0;
			Adapter.UpdateCommand.Parameters[24].Value = Original_JA;
		}
		if (Original_NOP == null)
		{
			Adapter.UpdateCommand.Parameters[25].Value = 1;
			Adapter.UpdateCommand.Parameters[26].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[25].Value = 0;
			Adapter.UpdateCommand.Parameters[26].Value = Original_NOP;
		}
		if (Original_LIG.HasValue)
		{
			Adapter.UpdateCommand.Parameters[27].Value = 0;
			Adapter.UpdateCommand.Parameters[28].Value = Original_LIG.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[27].Value = 1;
			Adapter.UpdateCommand.Parameters[28].Value = DBNull.Value;
		}
		if (Original_CPT == null)
		{
			Adapter.UpdateCommand.Parameters[29].Value = 1;
			Adapter.UpdateCommand.Parameters[30].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[29].Value = 0;
			Adapter.UpdateCommand.Parameters[30].Value = Original_CPT;
		}
		if (Original_TRS == null)
		{
			Adapter.UpdateCommand.Parameters[31].Value = 1;
			Adapter.UpdateCommand.Parameters[32].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[31].Value = 0;
			Adapter.UpdateCommand.Parameters[32].Value = Original_TRS;
		}
		if (Original_DAT.HasValue)
		{
			Adapter.UpdateCommand.Parameters[33].Value = 0;
			Adapter.UpdateCommand.Parameters[34].Value = Original_DAT.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[33].Value = 1;
			Adapter.UpdateCommand.Parameters[34].Value = DBNull.Value;
		}
		if (Original_LIB == null)
		{
			Adapter.UpdateCommand.Parameters[35].Value = 1;
			Adapter.UpdateCommand.Parameters[36].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[35].Value = 0;
			Adapter.UpdateCommand.Parameters[36].Value = Original_LIB;
		}
		if (Original_DEB.HasValue)
		{
			Adapter.UpdateCommand.Parameters[37].Value = 0;
			Adapter.UpdateCommand.Parameters[38].Value = Original_DEB.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[37].Value = 1;
			Adapter.UpdateCommand.Parameters[38].Value = DBNull.Value;
		}
		if (Original_CRE.HasValue)
		{
			Adapter.UpdateCommand.Parameters[39].Value = 0;
			Adapter.UpdateCommand.Parameters[40].Value = Original_CRE.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[39].Value = 1;
			Adapter.UpdateCommand.Parameters[40].Value = DBNull.Value;
		}
		if (Original_PTG == null)
		{
			Adapter.UpdateCommand.Parameters[41].Value = 1;
			Adapter.UpdateCommand.Parameters[42].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[41].Value = 0;
			Adapter.UpdateCommand.Parameters[42].Value = Original_PTG;
		}
		if (Original_PTGX == null)
		{
			Adapter.UpdateCommand.Parameters[43].Value = 1;
			Adapter.UpdateCommand.Parameters[44].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[43].Value = 0;
			Adapter.UpdateCommand.Parameters[44].Value = Original_PTGX;
		}
		if (Original_RAP == null)
		{
			Adapter.UpdateCommand.Parameters[45].Value = 1;
			Adapter.UpdateCommand.Parameters[46].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[45].Value = 0;
			Adapter.UpdateCommand.Parameters[46].Value = Original_RAP;
		}
		Adapter.UpdateCommand.Parameters[47].Value = Original_ID;
		if (Original_Jour.HasValue)
		{
			Adapter.UpdateCommand.Parameters[48].Value = 0;
			Adapter.UpdateCommand.Parameters[49].Value = Original_Jour.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[48].Value = 1;
			Adapter.UpdateCommand.Parameters[49].Value = DBNull.Value;
		}
		if (Original_UserC == null)
		{
			Adapter.UpdateCommand.Parameters[50].Value = 1;
			Adapter.UpdateCommand.Parameters[51].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[50].Value = 0;
			Adapter.UpdateCommand.Parameters[51].Value = Original_UserC;
		}
		if (Original_DateC.HasValue)
		{
			Adapter.UpdateCommand.Parameters[52].Value = 0;
			Adapter.UpdateCommand.Parameters[53].Value = Original_DateC.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[52].Value = 1;
			Adapter.UpdateCommand.Parameters[53].Value = DBNull.Value;
		}
		if (Original_UserM == null)
		{
			Adapter.UpdateCommand.Parameters[54].Value = 1;
			Adapter.UpdateCommand.Parameters[55].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[54].Value = 0;
			Adapter.UpdateCommand.Parameters[55].Value = Original_UserM;
		}
		if (Original_DateM.HasValue)
		{
			Adapter.UpdateCommand.Parameters[56].Value = 0;
			Adapter.UpdateCommand.Parameters[57].Value = Original_DateM.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[56].Value = 1;
			Adapter.UpdateCommand.Parameters[57].Value = DBNull.Value;
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
