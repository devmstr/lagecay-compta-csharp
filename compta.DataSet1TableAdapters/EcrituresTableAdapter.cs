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
public class EcrituresTableAdapter : Component
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
	public EcrituresTableAdapter()
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
		tableMapping.DataSetTable = "Ecritures";
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
		_adapter.InsertCommand = new OleDbCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO `Ecritures` (`UNI`, `Exercice`, `JA`, `NOP`, `LIG`, `CPT`, `TRS`, `DAT`, `LIB`, `DEB`, `CRE`, `PTG`, `PTGX`, `RAP`, `Jour`, `UserC`, `DateC`, `UserM`, `DateM`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("UNI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UNI", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("Exercice", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Exercice", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("JA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "JA", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("NOP", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "NOP", DataRowVersion.Current, sourceColumnNullMapping: false, null));
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
		_commandCollection[0].CommandText = "SELECT UNI, Exercice, JA, NOP, LIG, CPT, TRS, DAT, LIB, DEB, CRE, PTG, PTGX, RAP, ID, Jour, UserC, DateC, UserM, DateM FROM Ecritures";
		_commandCollection[0].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(DataSet1.EcrituresDataTable dataTable)
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
	public virtual DataSet1.EcrituresDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		DataSet1.EcrituresDataTable dataTable = new DataSet1.EcrituresDataTable();
		Adapter.Fill(dataTable);
		return dataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet1.EcrituresDataTable dataTable)
	{
		return Adapter.Update(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet1 dataSet)
	{
		return Adapter.Update(dataSet, "Ecritures");
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
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	public virtual int Insert(string UNI, int? Exercice, string JA, int? NOP, int? LIG, string CPT, string TRS, DateTime? DAT, string LIB, decimal? DEB, decimal? CRE, string PTG, string PTGX, string RAP, byte? Jour, string UserC, DateTime? DateC, string UserM, DateTime? DateM)
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
		if (NOP.HasValue)
		{
			Adapter.InsertCommand.Parameters[3].Value = NOP.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
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
}
