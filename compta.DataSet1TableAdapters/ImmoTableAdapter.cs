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
public class ImmoTableAdapter : Component
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
	public ImmoTableAdapter()
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
		tableMapping.DataSetTable = "Immo";
		tableMapping.ColumnMappings.Add("UNI", "UNI");
		tableMapping.ColumnMappings.Add("MAT", "MAT");
		tableMapping.ColumnMappings.Add("LIB", "LIB");
		tableMapping.ColumnMappings.Add("CPT", "CPT");
		tableMapping.ColumnMappings.Add("DATACQ", "DATACQ");
		tableMapping.ColumnMappings.Add("MTACQ", "MTACQ");
		tableMapping.ColumnMappings.Add("TVA", "TVA");
		tableMapping.ColumnMappings.Add("TX", "TX");
		tableMapping.ColumnMappings.Add("DATAM", "DATAM");
		tableMapping.ColumnMappings.Add("MTANT", "MTANT");
		tableMapping.ColumnMappings.Add("MTDOT", "MTDOT");
		tableMapping.ColumnMappings.Add("CUMDOT", "CUMDOT");
		tableMapping.ColumnMappings.Add("VNC", "VNC");
		tableMapping.ColumnMappings.Add("MTIMP", "MTIMP");
		tableMapping.ColumnMappings.Add("DATEX", "DATEX");
		tableMapping.ColumnMappings.Add("DATSOR", "DATSOR");
		tableMapping.ColumnMappings.Add("MTCES", "MTCES");
		tableMapping.ColumnMappings.Add("OBS", "OBS");
		tableMapping.ColumnMappings.Add("ID", "ID");
		tableMapping.ColumnMappings.Add("UserC", "UserC");
		tableMapping.ColumnMappings.Add("DateC", "DateC");
		tableMapping.ColumnMappings.Add("UserM", "UserM");
		tableMapping.ColumnMappings.Add("DateM", "DateM");
		tableMapping.ColumnMappings.Add("CPTAMOR", "CPTAMOR");
		tableMapping.ColumnMappings.Add("CPTDOT", "CPTDOT");
		tableMapping.ColumnMappings.Add("CPTPROD", "CPTPROD");
		_adapter.TableMappings.Add(tableMapping);
		_adapter.DeleteCommand = new OleDbCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM `Immo` WHERE ((`UNI` = ?) AND (`MAT` = ?) AND ((? = 1 AND `LIB` IS NULL) OR (`LIB` = ?)) AND ((? = 1 AND `CPT` IS NULL) OR (`CPT` = ?)) AND ((? = 1 AND `DATACQ` IS NULL) OR (`DATACQ` = ?)) AND ((? = 1 AND `MTACQ` IS NULL) OR (`MTACQ` = ?)) AND ((? = 1 AND `TVA` IS NULL) OR (`TVA` = ?)) AND ((? = 1 AND `TX` IS NULL) OR (`TX` = ?)) AND ((? = 1 AND `DATAM` IS NULL) OR (`DATAM` = ?)) AND ((? = 1 AND `MTANT` IS NULL) OR (`MTANT` = ?)) AND ((? = 1 AND `MTDOT` IS NULL) OR (`MTDOT` = ?)) AND ((? = 1 AND `CUMDOT` IS NULL) OR (`CUMDOT` = ?)) AND ((? = 1 AND `VNC` IS NULL) OR (`VNC` = ?)) AND ((? = 1 AND `MTIMP` IS NULL) OR (`MTIMP` = ?)) AND ((? = 1 AND `DATEX` IS NULL) OR (`DATEX` = ?)) AND ((? = 1 AND `DATSOR` IS NULL) OR (`DATSOR` = ?)) AND ((? = 1 AND `MTCES` IS NULL) OR (`MTCES` = ?)) AND ((? = 1 AND `OBS` IS NULL) OR (`OBS` = ?)) AND ((? = 1 AND `ID` IS NULL) OR (`ID` = ?)) AND ((? = 1 AND `UserC` IS NULL) OR (`UserC` = ?)) AND ((? = 1 AND `DateC` IS NULL) OR (`DateC` = ?)) AND ((? = 1 AND `UserM` IS NULL) OR (`UserM` = ?)) AND ((? = 1 AND `DateM` IS NULL) OR (`DateM` = ?)) AND ((? = 1 AND `CPTAMOR` IS NULL) OR (`CPTAMOR` = ?)) AND ((? = 1 AND `CPTDOT` IS NULL) OR (`CPTDOT` = ?)) AND ((? = 1 AND `CPTPROD` IS NULL) OR (`CPTPROD` = ?)))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_UNI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UNI", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_MAT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "MAT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_LIB", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CPT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CPT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_DATACQ", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DATACQ", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_DATACQ", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DATACQ", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_MTACQ", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "MTACQ", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_MTACQ", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTACQ", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TVA", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TVA", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TVA", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "TVA", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TX", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TX", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TX", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "TX", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_DATAM", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DATAM", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_DATAM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DATAM", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_MTANT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "MTANT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_MTANT", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTANT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_MTDOT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "MTDOT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_MTDOT", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTDOT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CUMDOT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CUMDOT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CUMDOT", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "CUMDOT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_VNC", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "VNC", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_VNC", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "VNC", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_MTIMP", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "MTIMP", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_MTIMP", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTIMP", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_DATEX", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DATEX", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_DATEX", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DATEX", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_DATSOR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DATSOR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_DATSOR", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DATSOR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_MTCES", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "MTCES", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_MTCES", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTCES", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_OBS", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "OBS", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_OBS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "OBS", DataRowVersion.Original, sourceColumnNullMapping: false, null));
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
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CPTAMOR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPTAMOR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CPTAMOR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPTAMOR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CPTDOT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPTDOT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CPTDOT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPTDOT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CPTPROD", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPTPROD", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CPTPROD", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPTPROD", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand = new OleDbCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO `Immo` (`UNI`, `MAT`, `LIB`, `CPT`, `DATACQ`, `MTACQ`, `TVA`, `TX`, `DATAM`, `MTANT`, `MTDOT`, `CUMDOT`, `VNC`, `MTIMP`, `DATEX`, `DATSOR`, `MTCES`, `OBS`, `UserC`, `DateC`, `UserM`, `DateM`, `CPTAMOR`, `CPTDOT`, `CPTPROD`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("UNI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UNI", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("MAT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "MAT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CPT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DATACQ", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DATACQ", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("MTACQ", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTACQ", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TVA", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "TVA", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TX", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "TX", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DATAM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DATAM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("MTANT", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTANT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("MTDOT", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTDOT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CUMDOT", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "CUMDOT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("VNC", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "VNC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("MTIMP", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTIMP", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DATEX", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DATEX", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DATSOR", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DATSOR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("MTCES", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTCES", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("OBS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "OBS", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("UserC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DateC", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("UserM", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DateM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CPTAMOR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPTAMOR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CPTDOT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPTDOT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CPTPROD", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPTPROD", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand = new OleDbCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE `Immo` SET `UNI` = ?, `MAT` = ?, `LIB` = ?, `CPT` = ?, `DATACQ` = ?, `MTACQ` = ?, `TVA` = ?, `TX` = ?, `DATAM` = ?, `MTANT` = ?, `MTDOT` = ?, `CUMDOT` = ?, `VNC` = ?, `MTIMP` = ?, `DATEX` = ?, `DATSOR` = ?, `MTCES` = ?, `OBS` = ?, `UserC` = ?, `DateC` = ?, `UserM` = ?, `DateM` = ?, `CPTAMOR` = ?, `CPTDOT` = ?, `CPTPROD` = ? WHERE ((`UNI` = ?) AND (`MAT` = ?) AND ((? = 1 AND `LIB` IS NULL) OR (`LIB` = ?)) AND ((? = 1 AND `CPT` IS NULL) OR (`CPT` = ?)) AND ((? = 1 AND `DATACQ` IS NULL) OR (`DATACQ` = ?)) AND ((? = 1 AND `MTACQ` IS NULL) OR (`MTACQ` = ?)) AND ((? = 1 AND `TVA` IS NULL) OR (`TVA` = ?)) AND ((? = 1 AND `TX` IS NULL) OR (`TX` = ?)) AND ((? = 1 AND `DATAM` IS NULL) OR (`DATAM` = ?)) AND ((? = 1 AND `MTANT` IS NULL) OR (`MTANT` = ?)) AND ((? = 1 AND `MTDOT` IS NULL) OR (`MTDOT` = ?)) AND ((? = 1 AND `CUMDOT` IS NULL) OR (`CUMDOT` = ?)) AND ((? = 1 AND `VNC` IS NULL) OR (`VNC` = ?)) AND ((? = 1 AND `MTIMP` IS NULL) OR (`MTIMP` = ?)) AND ((? = 1 AND `DATEX` IS NULL) OR (`DATEX` = ?)) AND ((? = 1 AND `DATSOR` IS NULL) OR (`DATSOR` = ?)) AND ((? = 1 AND `MTCES` IS NULL) OR (`MTCES` = ?)) AND ((? = 1 AND `OBS` IS NULL) OR (`OBS` = ?)) AND ((? = 1 AND `ID` IS NULL) OR (`ID` = ?)) AND ((? = 1 AND `UserC` IS NULL) OR (`UserC` = ?)) AND ((? = 1 AND `DateC` IS NULL) OR (`DateC` = ?)) AND ((? = 1 AND `UserM` IS NULL) OR (`UserM` = ?)) AND ((? = 1 AND `DateM` IS NULL) OR (`DateM` = ?)) AND ((? = 1 AND `CPTAMOR` IS NULL) OR (`CPTAMOR` = ?)) AND ((? = 1 AND `CPTDOT` IS NULL) OR (`CPTDOT` = ?)) AND ((? = 1 AND `CPTPROD` IS NULL) OR (`CPTPROD` = ?)))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("UNI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UNI", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("MAT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "MAT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CPT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DATACQ", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DATACQ", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("MTACQ", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTACQ", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TVA", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "TVA", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TX", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "TX", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DATAM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DATAM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("MTANT", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTANT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("MTDOT", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTDOT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CUMDOT", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "CUMDOT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("VNC", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "VNC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("MTIMP", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTIMP", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DATEX", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DATEX", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DATSOR", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DATSOR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("MTCES", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTCES", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("OBS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "OBS", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("UserC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DateC", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("UserM", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DateM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CPTAMOR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPTAMOR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CPTDOT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPTDOT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CPTPROD", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPTPROD", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_UNI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UNI", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_MAT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "MAT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_LIB", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CPT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CPT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_DATACQ", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DATACQ", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_DATACQ", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DATACQ", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_MTACQ", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "MTACQ", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_MTACQ", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTACQ", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TVA", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TVA", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TVA", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "TVA", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TX", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TX", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TX", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "TX", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_DATAM", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DATAM", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_DATAM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DATAM", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_MTANT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "MTANT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_MTANT", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTANT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_MTDOT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "MTDOT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_MTDOT", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTDOT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CUMDOT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CUMDOT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CUMDOT", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "CUMDOT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_VNC", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "VNC", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_VNC", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "VNC", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_MTIMP", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "MTIMP", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_MTIMP", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTIMP", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_DATEX", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DATEX", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_DATEX", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DATEX", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_DATSOR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DATSOR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_DATSOR", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DATSOR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_MTCES", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "MTCES", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_MTCES", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "MTCES", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_OBS", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "OBS", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_OBS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "OBS", DataRowVersion.Original, sourceColumnNullMapping: false, null));
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
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CPTAMOR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPTAMOR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CPTAMOR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPTAMOR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CPTDOT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPTDOT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CPTDOT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPTDOT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CPTPROD", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPTPROD", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CPTPROD", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPTPROD", DataRowVersion.Original, sourceColumnNullMapping: false, null));
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
		_commandCollection = new OleDbCommand[2];
		_commandCollection[0] = new OleDbCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT        UNI, MAT, LIB, CPT, DATACQ, MTACQ, TVA, TX, DATAM, MTANT, MTDOT, CUMDOT, VNC, MTIMP, DATEX, DATSOR, MTCES, OBS, ID, UserC, DateC, UserM, DateM, CPTAMOR, CPTDOT, CPTPROD\r\nFROM            Immo";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[1] = new OleDbCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "SELECT CPT, CPTAMOR, CPTDOT, CPTPROD, CUMDOT, DATACQ, DATAM, DATEX, DATSOR, DateC, DateM, ID, LIB, MAT, MTACQ, MTANT, MTCES, MTDOT, MTIMP, OBS, TVA, TX, UNI, UserC, UserM, VNC FROM Immo WHERE (UNI = ?)";
		_commandCollection[1].CommandType = CommandType.Text;
		_commandCollection[1].Parameters.Add(new OleDbParameter("UNI", OleDbType.WChar, 3, ParameterDirection.Input, 0, 0, "UNI", DataRowVersion.Current, sourceColumnNullMapping: false, null));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(DataSet1.ImmoDataTable dataTable)
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
	public virtual DataSet1.ImmoDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		DataSet1.ImmoDataTable dataTable = new DataSet1.ImmoDataTable();
		Adapter.Fill(dataTable);
		return dataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int FillBy(DataSet1.ImmoDataTable dataTable, string UNI)
	{
		Adapter.SelectCommand = CommandCollection[1];
		if (UNI == null)
		{
			throw new ArgumentNullException("UNI");
		}
		Adapter.SelectCommand.Parameters[0].Value = UNI;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet1.ImmoDataTable dataTable)
	{
		return Adapter.Update(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet1 dataSet)
	{
		return Adapter.Update(dataSet, "Immo");
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
	public virtual int Delete(string Original_UNI, string Original_MAT, string Original_LIB, string Original_CPT, DateTime? Original_DATACQ, double? Original_MTACQ, double? Original_TVA, double? Original_TX, DateTime? Original_DATAM, double? Original_MTANT, double? Original_MTDOT, double? Original_CUMDOT, double? Original_VNC, double? Original_MTIMP, DateTime? Original_DATEX, DateTime? Original_DATSOR, double? Original_MTCES, string Original_OBS, int Original_ID, string Original_UserC, DateTime? Original_DateC, string Original_UserM, DateTime? Original_DateM, string Original_CPTAMOR, string Original_CPTDOT, string Original_CPTPROD)
	{
		if (Original_UNI == null)
		{
			Adapter.DeleteCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[0].Value = Original_UNI;
		}
		if (Original_MAT == null)
		{
			Adapter.DeleteCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[1].Value = Original_MAT;
		}
		if (Original_LIB == null)
		{
			Adapter.DeleteCommand.Parameters[2].Value = 1;
			Adapter.DeleteCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[2].Value = 0;
			Adapter.DeleteCommand.Parameters[3].Value = Original_LIB;
		}
		if (Original_CPT == null)
		{
			Adapter.DeleteCommand.Parameters[4].Value = 1;
			Adapter.DeleteCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[4].Value = 0;
			Adapter.DeleteCommand.Parameters[5].Value = Original_CPT;
		}
		if (Original_DATACQ.HasValue)
		{
			Adapter.DeleteCommand.Parameters[6].Value = 0;
			Adapter.DeleteCommand.Parameters[7].Value = Original_DATACQ.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[6].Value = 1;
			Adapter.DeleteCommand.Parameters[7].Value = DBNull.Value;
		}
		if (Original_MTACQ.HasValue)
		{
			Adapter.DeleteCommand.Parameters[8].Value = 0;
			Adapter.DeleteCommand.Parameters[9].Value = Original_MTACQ.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[8].Value = 1;
			Adapter.DeleteCommand.Parameters[9].Value = DBNull.Value;
		}
		if (Original_TVA.HasValue)
		{
			Adapter.DeleteCommand.Parameters[10].Value = 0;
			Adapter.DeleteCommand.Parameters[11].Value = Original_TVA.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[10].Value = 1;
			Adapter.DeleteCommand.Parameters[11].Value = DBNull.Value;
		}
		if (Original_TX.HasValue)
		{
			Adapter.DeleteCommand.Parameters[12].Value = 0;
			Adapter.DeleteCommand.Parameters[13].Value = Original_TX.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[12].Value = 1;
			Adapter.DeleteCommand.Parameters[13].Value = DBNull.Value;
		}
		if (Original_DATAM.HasValue)
		{
			Adapter.DeleteCommand.Parameters[14].Value = 0;
			Adapter.DeleteCommand.Parameters[15].Value = Original_DATAM.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[14].Value = 1;
			Adapter.DeleteCommand.Parameters[15].Value = DBNull.Value;
		}
		if (Original_MTANT.HasValue)
		{
			Adapter.DeleteCommand.Parameters[16].Value = 0;
			Adapter.DeleteCommand.Parameters[17].Value = Original_MTANT.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[16].Value = 1;
			Adapter.DeleteCommand.Parameters[17].Value = DBNull.Value;
		}
		if (Original_MTDOT.HasValue)
		{
			Adapter.DeleteCommand.Parameters[18].Value = 0;
			Adapter.DeleteCommand.Parameters[19].Value = Original_MTDOT.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[18].Value = 1;
			Adapter.DeleteCommand.Parameters[19].Value = DBNull.Value;
		}
		if (Original_CUMDOT.HasValue)
		{
			Adapter.DeleteCommand.Parameters[20].Value = 0;
			Adapter.DeleteCommand.Parameters[21].Value = Original_CUMDOT.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[20].Value = 1;
			Adapter.DeleteCommand.Parameters[21].Value = DBNull.Value;
		}
		if (Original_VNC.HasValue)
		{
			Adapter.DeleteCommand.Parameters[22].Value = 0;
			Adapter.DeleteCommand.Parameters[23].Value = Original_VNC.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[22].Value = 1;
			Adapter.DeleteCommand.Parameters[23].Value = DBNull.Value;
		}
		if (Original_MTIMP.HasValue)
		{
			Adapter.DeleteCommand.Parameters[24].Value = 0;
			Adapter.DeleteCommand.Parameters[25].Value = Original_MTIMP.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[24].Value = 1;
			Adapter.DeleteCommand.Parameters[25].Value = DBNull.Value;
		}
		if (Original_DATEX.HasValue)
		{
			Adapter.DeleteCommand.Parameters[26].Value = 0;
			Adapter.DeleteCommand.Parameters[27].Value = Original_DATEX.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[26].Value = 1;
			Adapter.DeleteCommand.Parameters[27].Value = DBNull.Value;
		}
		if (Original_DATSOR.HasValue)
		{
			Adapter.DeleteCommand.Parameters[28].Value = 0;
			Adapter.DeleteCommand.Parameters[29].Value = Original_DATSOR.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[28].Value = 1;
			Adapter.DeleteCommand.Parameters[29].Value = DBNull.Value;
		}
		if (Original_MTCES.HasValue)
		{
			Adapter.DeleteCommand.Parameters[30].Value = 0;
			Adapter.DeleteCommand.Parameters[31].Value = Original_MTCES.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[30].Value = 1;
			Adapter.DeleteCommand.Parameters[31].Value = DBNull.Value;
		}
		if (Original_OBS == null)
		{
			Adapter.DeleteCommand.Parameters[32].Value = 1;
			Adapter.DeleteCommand.Parameters[33].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[32].Value = 0;
			Adapter.DeleteCommand.Parameters[33].Value = Original_OBS;
		}
		Adapter.DeleteCommand.Parameters[34].Value = 0;
		Adapter.DeleteCommand.Parameters[35].Value = Original_ID;
		if (Original_UserC == null)
		{
			Adapter.DeleteCommand.Parameters[36].Value = 1;
			Adapter.DeleteCommand.Parameters[37].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[36].Value = 0;
			Adapter.DeleteCommand.Parameters[37].Value = Original_UserC;
		}
		if (Original_DateC.HasValue)
		{
			Adapter.DeleteCommand.Parameters[38].Value = 0;
			Adapter.DeleteCommand.Parameters[39].Value = Original_DateC.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[38].Value = 1;
			Adapter.DeleteCommand.Parameters[39].Value = DBNull.Value;
		}
		if (Original_UserM == null)
		{
			Adapter.DeleteCommand.Parameters[40].Value = 1;
			Adapter.DeleteCommand.Parameters[41].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[40].Value = 0;
			Adapter.DeleteCommand.Parameters[41].Value = Original_UserM;
		}
		if (Original_DateM.HasValue)
		{
			Adapter.DeleteCommand.Parameters[42].Value = 0;
			Adapter.DeleteCommand.Parameters[43].Value = Original_DateM.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[42].Value = 1;
			Adapter.DeleteCommand.Parameters[43].Value = DBNull.Value;
		}
		if (Original_CPTAMOR == null)
		{
			Adapter.DeleteCommand.Parameters[44].Value = 1;
			Adapter.DeleteCommand.Parameters[45].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[44].Value = 0;
			Adapter.DeleteCommand.Parameters[45].Value = Original_CPTAMOR;
		}
		if (Original_CPTDOT == null)
		{
			Adapter.DeleteCommand.Parameters[46].Value = 1;
			Adapter.DeleteCommand.Parameters[47].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[46].Value = 0;
			Adapter.DeleteCommand.Parameters[47].Value = Original_CPTDOT;
		}
		if (Original_CPTPROD == null)
		{
			Adapter.DeleteCommand.Parameters[48].Value = 1;
			Adapter.DeleteCommand.Parameters[49].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[48].Value = 0;
			Adapter.DeleteCommand.Parameters[49].Value = Original_CPTPROD;
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
	public virtual int Insert(string UNI, string MAT, string LIB, string CPT, DateTime? DATACQ, double? MTACQ, double? TVA, double? TX, DateTime? DATAM, double? MTANT, double? MTDOT, double? CUMDOT, double? VNC, double? MTIMP, DateTime? DATEX, DateTime? DATSOR, double? MTCES, string OBS, string UserC, DateTime? DateC, string UserM, DateTime? DateM, string CPTAMOR, string CPTDOT, string CPTPROD)
	{
		if (UNI == null)
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = UNI;
		}
		if (MAT == null)
		{
			Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[1].Value = MAT;
		}
		if (LIB == null)
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = LIB;
		}
		if (CPT == null)
		{
			Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[3].Value = CPT;
		}
		if (DATACQ.HasValue)
		{
			Adapter.InsertCommand.Parameters[4].Value = DATACQ.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
		}
		if (MTACQ.HasValue)
		{
			Adapter.InsertCommand.Parameters[5].Value = MTACQ.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
		}
		if (TVA.HasValue)
		{
			Adapter.InsertCommand.Parameters[6].Value = TVA.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
		}
		if (TX.HasValue)
		{
			Adapter.InsertCommand.Parameters[7].Value = TX.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
		}
		if (DATAM.HasValue)
		{
			Adapter.InsertCommand.Parameters[8].Value = DATAM.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
		}
		if (MTANT.HasValue)
		{
			Adapter.InsertCommand.Parameters[9].Value = MTANT.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
		}
		if (MTDOT.HasValue)
		{
			Adapter.InsertCommand.Parameters[10].Value = MTDOT.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
		}
		if (CUMDOT.HasValue)
		{
			Adapter.InsertCommand.Parameters[11].Value = CUMDOT.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
		}
		if (VNC.HasValue)
		{
			Adapter.InsertCommand.Parameters[12].Value = VNC.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
		}
		if (MTIMP.HasValue)
		{
			Adapter.InsertCommand.Parameters[13].Value = MTIMP.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[13].Value = DBNull.Value;
		}
		if (DATEX.HasValue)
		{
			Adapter.InsertCommand.Parameters[14].Value = DATEX.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[14].Value = DBNull.Value;
		}
		if (DATSOR.HasValue)
		{
			Adapter.InsertCommand.Parameters[15].Value = DATSOR.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[15].Value = DBNull.Value;
		}
		if (MTCES.HasValue)
		{
			Adapter.InsertCommand.Parameters[16].Value = MTCES.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[16].Value = DBNull.Value;
		}
		if (OBS == null)
		{
			Adapter.InsertCommand.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[17].Value = OBS;
		}
		if (UserC == null)
		{
			Adapter.InsertCommand.Parameters[18].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[18].Value = UserC;
		}
		if (DateC.HasValue)
		{
			Adapter.InsertCommand.Parameters[19].Value = DateC.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[19].Value = DBNull.Value;
		}
		if (UserM == null)
		{
			Adapter.InsertCommand.Parameters[20].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[20].Value = UserM;
		}
		if (DateM.HasValue)
		{
			Adapter.InsertCommand.Parameters[21].Value = DateM.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[21].Value = DBNull.Value;
		}
		if (CPTAMOR == null)
		{
			Adapter.InsertCommand.Parameters[22].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[22].Value = CPTAMOR;
		}
		if (CPTDOT == null)
		{
			Adapter.InsertCommand.Parameters[23].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[23].Value = CPTDOT;
		}
		if (CPTPROD == null)
		{
			Adapter.InsertCommand.Parameters[24].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[24].Value = CPTPROD;
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
	public virtual int Update(string UNI, string MAT, string LIB, string CPT, DateTime? DATACQ, double? MTACQ, double? TVA, double? TX, DateTime? DATAM, double? MTANT, double? MTDOT, double? CUMDOT, double? VNC, double? MTIMP, DateTime? DATEX, DateTime? DATSOR, double? MTCES, string OBS, string UserC, DateTime? DateC, string UserM, DateTime? DateM, string CPTAMOR, string CPTDOT, string CPTPROD, string Original_UNI, string Original_MAT, string Original_LIB, string Original_CPT, DateTime? Original_DATACQ, double? Original_MTACQ, double? Original_TVA, double? Original_TX, DateTime? Original_DATAM, double? Original_MTANT, double? Original_MTDOT, double? Original_CUMDOT, double? Original_VNC, double? Original_MTIMP, DateTime? Original_DATEX, DateTime? Original_DATSOR, double? Original_MTCES, string Original_OBS, int Original_ID, string Original_UserC, DateTime? Original_DateC, string Original_UserM, DateTime? Original_DateM, string Original_CPTAMOR, string Original_CPTDOT, string Original_CPTPROD)
	{
		if (UNI == null)
		{
			Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[0].Value = UNI;
		}
		if (MAT == null)
		{
			Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[1].Value = MAT;
		}
		if (LIB == null)
		{
			Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[2].Value = LIB;
		}
		if (CPT == null)
		{
			Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[3].Value = CPT;
		}
		if (DATACQ.HasValue)
		{
			Adapter.UpdateCommand.Parameters[4].Value = DATACQ.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
		}
		if (MTACQ.HasValue)
		{
			Adapter.UpdateCommand.Parameters[5].Value = MTACQ.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
		}
		if (TVA.HasValue)
		{
			Adapter.UpdateCommand.Parameters[6].Value = TVA.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
		}
		if (TX.HasValue)
		{
			Adapter.UpdateCommand.Parameters[7].Value = TX.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
		}
		if (DATAM.HasValue)
		{
			Adapter.UpdateCommand.Parameters[8].Value = DATAM.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
		}
		if (MTANT.HasValue)
		{
			Adapter.UpdateCommand.Parameters[9].Value = MTANT.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
		}
		if (MTDOT.HasValue)
		{
			Adapter.UpdateCommand.Parameters[10].Value = MTDOT.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
		}
		if (CUMDOT.HasValue)
		{
			Adapter.UpdateCommand.Parameters[11].Value = CUMDOT.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
		}
		if (VNC.HasValue)
		{
			Adapter.UpdateCommand.Parameters[12].Value = VNC.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
		}
		if (MTIMP.HasValue)
		{
			Adapter.UpdateCommand.Parameters[13].Value = MTIMP.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
		}
		if (DATEX.HasValue)
		{
			Adapter.UpdateCommand.Parameters[14].Value = DATEX.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
		}
		if (DATSOR.HasValue)
		{
			Adapter.UpdateCommand.Parameters[15].Value = DATSOR.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
		}
		if (MTCES.HasValue)
		{
			Adapter.UpdateCommand.Parameters[16].Value = MTCES.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[16].Value = DBNull.Value;
		}
		if (OBS == null)
		{
			Adapter.UpdateCommand.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[17].Value = OBS;
		}
		if (UserC == null)
		{
			Adapter.UpdateCommand.Parameters[18].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[18].Value = UserC;
		}
		if (DateC.HasValue)
		{
			Adapter.UpdateCommand.Parameters[19].Value = DateC.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[19].Value = DBNull.Value;
		}
		if (UserM == null)
		{
			Adapter.UpdateCommand.Parameters[20].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[20].Value = UserM;
		}
		if (DateM.HasValue)
		{
			Adapter.UpdateCommand.Parameters[21].Value = DateM.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[21].Value = DBNull.Value;
		}
		if (CPTAMOR == null)
		{
			Adapter.UpdateCommand.Parameters[22].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[22].Value = CPTAMOR;
		}
		if (CPTDOT == null)
		{
			Adapter.UpdateCommand.Parameters[23].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[23].Value = CPTDOT;
		}
		if (CPTPROD == null)
		{
			Adapter.UpdateCommand.Parameters[24].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[24].Value = CPTPROD;
		}
		if (Original_UNI == null)
		{
			Adapter.UpdateCommand.Parameters[25].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[25].Value = Original_UNI;
		}
		if (Original_MAT == null)
		{
			Adapter.UpdateCommand.Parameters[26].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[26].Value = Original_MAT;
		}
		if (Original_LIB == null)
		{
			Adapter.UpdateCommand.Parameters[27].Value = 1;
			Adapter.UpdateCommand.Parameters[28].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[27].Value = 0;
			Adapter.UpdateCommand.Parameters[28].Value = Original_LIB;
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
		if (Original_DATACQ.HasValue)
		{
			Adapter.UpdateCommand.Parameters[31].Value = 0;
			Adapter.UpdateCommand.Parameters[32].Value = Original_DATACQ.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[31].Value = 1;
			Adapter.UpdateCommand.Parameters[32].Value = DBNull.Value;
		}
		if (Original_MTACQ.HasValue)
		{
			Adapter.UpdateCommand.Parameters[33].Value = 0;
			Adapter.UpdateCommand.Parameters[34].Value = Original_MTACQ.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[33].Value = 1;
			Adapter.UpdateCommand.Parameters[34].Value = DBNull.Value;
		}
		if (Original_TVA.HasValue)
		{
			Adapter.UpdateCommand.Parameters[35].Value = 0;
			Adapter.UpdateCommand.Parameters[36].Value = Original_TVA.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[35].Value = 1;
			Adapter.UpdateCommand.Parameters[36].Value = DBNull.Value;
		}
		if (Original_TX.HasValue)
		{
			Adapter.UpdateCommand.Parameters[37].Value = 0;
			Adapter.UpdateCommand.Parameters[38].Value = Original_TX.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[37].Value = 1;
			Adapter.UpdateCommand.Parameters[38].Value = DBNull.Value;
		}
		if (Original_DATAM.HasValue)
		{
			Adapter.UpdateCommand.Parameters[39].Value = 0;
			Adapter.UpdateCommand.Parameters[40].Value = Original_DATAM.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[39].Value = 1;
			Adapter.UpdateCommand.Parameters[40].Value = DBNull.Value;
		}
		if (Original_MTANT.HasValue)
		{
			Adapter.UpdateCommand.Parameters[41].Value = 0;
			Adapter.UpdateCommand.Parameters[42].Value = Original_MTANT.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[41].Value = 1;
			Adapter.UpdateCommand.Parameters[42].Value = DBNull.Value;
		}
		if (Original_MTDOT.HasValue)
		{
			Adapter.UpdateCommand.Parameters[43].Value = 0;
			Adapter.UpdateCommand.Parameters[44].Value = Original_MTDOT.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[43].Value = 1;
			Adapter.UpdateCommand.Parameters[44].Value = DBNull.Value;
		}
		if (Original_CUMDOT.HasValue)
		{
			Adapter.UpdateCommand.Parameters[45].Value = 0;
			Adapter.UpdateCommand.Parameters[46].Value = Original_CUMDOT.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[45].Value = 1;
			Adapter.UpdateCommand.Parameters[46].Value = DBNull.Value;
		}
		if (Original_VNC.HasValue)
		{
			Adapter.UpdateCommand.Parameters[47].Value = 0;
			Adapter.UpdateCommand.Parameters[48].Value = Original_VNC.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[47].Value = 1;
			Adapter.UpdateCommand.Parameters[48].Value = DBNull.Value;
		}
		if (Original_MTIMP.HasValue)
		{
			Adapter.UpdateCommand.Parameters[49].Value = 0;
			Adapter.UpdateCommand.Parameters[50].Value = Original_MTIMP.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[49].Value = 1;
			Adapter.UpdateCommand.Parameters[50].Value = DBNull.Value;
		}
		if (Original_DATEX.HasValue)
		{
			Adapter.UpdateCommand.Parameters[51].Value = 0;
			Adapter.UpdateCommand.Parameters[52].Value = Original_DATEX.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[51].Value = 1;
			Adapter.UpdateCommand.Parameters[52].Value = DBNull.Value;
		}
		if (Original_DATSOR.HasValue)
		{
			Adapter.UpdateCommand.Parameters[53].Value = 0;
			Adapter.UpdateCommand.Parameters[54].Value = Original_DATSOR.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[53].Value = 1;
			Adapter.UpdateCommand.Parameters[54].Value = DBNull.Value;
		}
		if (Original_MTCES.HasValue)
		{
			Adapter.UpdateCommand.Parameters[55].Value = 0;
			Adapter.UpdateCommand.Parameters[56].Value = Original_MTCES.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[55].Value = 1;
			Adapter.UpdateCommand.Parameters[56].Value = DBNull.Value;
		}
		if (Original_OBS == null)
		{
			Adapter.UpdateCommand.Parameters[57].Value = 1;
			Adapter.UpdateCommand.Parameters[58].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[57].Value = 0;
			Adapter.UpdateCommand.Parameters[58].Value = Original_OBS;
		}
		Adapter.UpdateCommand.Parameters[59].Value = 0;
		Adapter.UpdateCommand.Parameters[60].Value = Original_ID;
		if (Original_UserC == null)
		{
			Adapter.UpdateCommand.Parameters[61].Value = 1;
			Adapter.UpdateCommand.Parameters[62].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[61].Value = 0;
			Adapter.UpdateCommand.Parameters[62].Value = Original_UserC;
		}
		if (Original_DateC.HasValue)
		{
			Adapter.UpdateCommand.Parameters[63].Value = 0;
			Adapter.UpdateCommand.Parameters[64].Value = Original_DateC.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[63].Value = 1;
			Adapter.UpdateCommand.Parameters[64].Value = DBNull.Value;
		}
		if (Original_UserM == null)
		{
			Adapter.UpdateCommand.Parameters[65].Value = 1;
			Adapter.UpdateCommand.Parameters[66].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[65].Value = 0;
			Adapter.UpdateCommand.Parameters[66].Value = Original_UserM;
		}
		if (Original_DateM.HasValue)
		{
			Adapter.UpdateCommand.Parameters[67].Value = 0;
			Adapter.UpdateCommand.Parameters[68].Value = Original_DateM.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[67].Value = 1;
			Adapter.UpdateCommand.Parameters[68].Value = DBNull.Value;
		}
		if (Original_CPTAMOR == null)
		{
			Adapter.UpdateCommand.Parameters[69].Value = 1;
			Adapter.UpdateCommand.Parameters[70].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[69].Value = 0;
			Adapter.UpdateCommand.Parameters[70].Value = Original_CPTAMOR;
		}
		if (Original_CPTDOT == null)
		{
			Adapter.UpdateCommand.Parameters[71].Value = 1;
			Adapter.UpdateCommand.Parameters[72].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[71].Value = 0;
			Adapter.UpdateCommand.Parameters[72].Value = Original_CPTDOT;
		}
		if (Original_CPTPROD == null)
		{
			Adapter.UpdateCommand.Parameters[73].Value = 1;
			Adapter.UpdateCommand.Parameters[74].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[73].Value = 0;
			Adapter.UpdateCommand.Parameters[74].Value = Original_CPTPROD;
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
	public virtual int Update(string LIB, string CPT, DateTime? DATACQ, double? MTACQ, double? TVA, double? TX, DateTime? DATAM, double? MTANT, double? MTDOT, double? CUMDOT, double? VNC, double? MTIMP, DateTime? DATEX, DateTime? DATSOR, double? MTCES, string OBS, string UserC, DateTime? DateC, string UserM, DateTime? DateM, string CPTAMOR, string CPTDOT, string CPTPROD, string Original_UNI, string Original_MAT, string Original_LIB, string Original_CPT, DateTime? Original_DATACQ, double? Original_MTACQ, double? Original_TVA, double? Original_TX, DateTime? Original_DATAM, double? Original_MTANT, double? Original_MTDOT, double? Original_CUMDOT, double? Original_VNC, double? Original_MTIMP, DateTime? Original_DATEX, DateTime? Original_DATSOR, double? Original_MTCES, string Original_OBS, int Original_ID, string Original_UserC, DateTime? Original_DateC, string Original_UserM, DateTime? Original_DateM, string Original_CPTAMOR, string Original_CPTDOT, string Original_CPTPROD)
	{
		return Update(Original_UNI, Original_MAT, LIB, CPT, DATACQ, MTACQ, TVA, TX, DATAM, MTANT, MTDOT, CUMDOT, VNC, MTIMP, DATEX, DATSOR, MTCES, OBS, UserC, DateC, UserM, DateM, CPTAMOR, CPTDOT, CPTPROD, Original_UNI, Original_MAT, Original_LIB, Original_CPT, Original_DATACQ, Original_MTACQ, Original_TVA, Original_TX, Original_DATAM, Original_MTANT, Original_MTDOT, Original_CUMDOT, Original_VNC, Original_MTIMP, Original_DATEX, Original_DATSOR, Original_MTCES, Original_OBS, Original_ID, Original_UserC, Original_DateC, Original_UserM, Original_DateM, Original_CPTAMOR, Original_CPTDOT, Original_CPTPROD);
	}
}
