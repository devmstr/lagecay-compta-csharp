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
public class DossiersTableAdapter : Component
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
	public DossiersTableAdapter()
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
		tableMapping.DataSetTable = "Dossiers";
		tableMapping.ColumnMappings.Add("UNI", "UNI");
		tableMapping.ColumnMappings.Add("LIB", "LIB");
		tableMapping.ColumnMappings.Add("ADR", "ADR");
		tableMapping.ColumnMappings.Add("CP", "CP");
		tableMapping.ColumnMappings.Add("NUMIF", "NUMIF");
		tableMapping.ColumnMappings.Add("NUMAI", "NUMAI");
		tableMapping.ColumnMappings.Add("ACT", "ACT");
		tableMapping.ColumnMappings.Add("RC", "RC");
		tableMapping.ColumnMappings.Add("EXER_CG", "EXER_CG");
		tableMapping.ColumnMappings.Add("EXER_PA", "EXER_PA");
		tableMapping.ColumnMappings.Add("ID", "ID");
		tableMapping.ColumnMappings.Add("Password", "Password");
		tableMapping.ColumnMappings.Add("UserC", "UserC");
		tableMapping.ColumnMappings.Add("DateC", "DateC");
		tableMapping.ColumnMappings.Add("UserM", "UserM");
		tableMapping.ColumnMappings.Add("DateM", "DateM");
		tableMapping.ColumnMappings.Add("TEL", "TEL");
		tableMapping.ColumnMappings.Add("FAX", "FAX");
		tableMapping.ColumnMappings.Add("CF", "CF");
		tableMapping.ColumnMappings.Add("MAIL", "MAIL");
		tableMapping.ColumnMappings.Add("NIS", "NIS");
		tableMapping.ColumnMappings.Add("CodeActivite", "CodeActivite");
		tableMapping.ColumnMappings.Add("CPWilaya", "CPWilaya");
		tableMapping.ColumnMappings.Add("CPCommune", "CPCommune");
		tableMapping.ColumnMappings.Add("Inspection", "Inspection");
		tableMapping.ColumnMappings.Add("Recette", "Recette");
		tableMapping.ColumnMappings.Add("LIBAR", "LIBAR");
		tableMapping.ColumnMappings.Add("ADRAR", "ADRAR");
		tableMapping.ColumnMappings.Add("ACTAR", "ACTAR");
		_adapter.TableMappings.Add(tableMapping);
		_adapter.DeleteCommand = new OleDbCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM `Dossiers` WHERE ((`UNI` = ?) AND ((? = 1 AND `LIB` IS NULL) OR (`LIB` = ?)) AND ((? = 1 AND `ADR` IS NULL) OR (`ADR` = ?)) AND ((? = 1 AND `CP` IS NULL) OR (`CP` = ?)) AND ((? = 1 AND `NUMIF` IS NULL) OR (`NUMIF` = ?)) AND ((? = 1 AND `NUMAI` IS NULL) OR (`NUMAI` = ?)) AND ((? = 1 AND `ACT` IS NULL) OR (`ACT` = ?)) AND ((? = 1 AND `RC` IS NULL) OR (`RC` = ?)) AND ((? = 1 AND `EXER_CG` IS NULL) OR (`EXER_CG` = ?)) AND ((? = 1 AND `EXER_PA` IS NULL) OR (`EXER_PA` = ?)) AND ((? = 1 AND `ID` IS NULL) OR (`ID` = ?)) AND ((? = 1 AND `Password` IS NULL) OR (`Password` = ?)) AND ((? = 1 AND `UserC` IS NULL) OR (`UserC` = ?)) AND ((? = 1 AND `DateC` IS NULL) OR (`DateC` = ?)) AND ((? = 1 AND `UserM` IS NULL) OR (`UserM` = ?)) AND ((? = 1 AND `DateM` IS NULL) OR (`DateM` = ?)) AND ((? = 1 AND `TEL` IS NULL) OR (`TEL` = ?)) AND ((? = 1 AND `FAX` IS NULL) OR (`FAX` = ?)) AND ((? = 1 AND `CF` IS NULL) OR (`CF` = ?)) AND ((? = 1 AND `MAIL` IS NULL) OR (`MAIL` = ?)) AND ((? = 1 AND `NIS` IS NULL) OR (`NIS` = ?)) AND ((? = 1 AND `CodeActivite` IS NULL) OR (`CodeActivite` = ?)) AND ((? = 1 AND `CPWilaya` IS NULL) OR (`CPWilaya` = ?)) AND ((? = 1 AND `CPCommune` IS NULL) OR (`CPCommune` = ?)) AND ((? = 1 AND `Inspection` IS NULL) OR (`Inspection` = ?)) AND ((? = 1 AND `Recette` IS NULL) OR (`Recette` = ?)) AND ((? = 1 AND `LIBAR` IS NULL) OR (`LIBAR` = ?)) AND ((? = 1 AND `ADRAR` IS NULL) OR (`ADRAR` = ?)) AND ((? = 1 AND `ACTAR` IS NULL) OR (`ACTAR` = ?)))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_UNI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UNI", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_LIB", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ADR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ADR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ADR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ADR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CP", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CP", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CP", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CP", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_NUMIF", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "NUMIF", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_NUMIF", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "NUMIF", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_NUMAI", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "NUMAI", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_NUMAI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "NUMAI", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ACT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ACT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ACT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ACT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_RC", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "RC", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_RC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "RC", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_EXER_CG", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "EXER_CG", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_EXER_CG", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "EXER_CG", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_EXER_PA", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "EXER_PA", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_EXER_PA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "EXER_PA", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_Password", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Password", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Password", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Password", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_UserC", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_UserC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_DateC", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_DateC", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_UserM", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_UserM", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_DateM", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_DateM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_TEL", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TEL", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_TEL", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TEL", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_FAX", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "FAX", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_FAX", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "FAX", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CF", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CF", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CF", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CF", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_MAIL", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "MAIL", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_MAIL", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "MAIL", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_NIS", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "NIS", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_NIS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "NIS", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CodeActivite", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CodeActivite", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CodeActivite", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CodeActivite", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CPWilaya", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPWilaya", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CPWilaya", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPWilaya", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_CPCommune", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPCommune", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_CPCommune", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPCommune", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_Inspection", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Inspection", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Inspection", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Inspection", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_Recette", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Recette", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Recette", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Recette", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_LIBAR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIBAR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_LIBAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIBAR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ADRAR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ADRAR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ADRAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ADRAR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_ACTAR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ACTAR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ACTAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ACTAR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand = new OleDbCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO `Dossiers` (`UNI`, `LIB`, `ADR`, `CP`, `NUMIF`, `NUMAI`, `ACT`, `RC`, `EXER_CG`, `EXER_PA`, `Password`, `UserC`, `DateC`, `UserM`, `DateM`, `TEL`, `FAX`, `CF`, `MAIL`, `NIS`, `CodeActivite`, `CPWilaya`, `CPCommune`, `Inspection`, `Recette`, `LIBAR`, `ADRAR`, `ACTAR`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("UNI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UNI", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ADR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ADR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CP", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CP", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("NUMIF", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "NUMIF", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("NUMAI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "NUMAI", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ACT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ACT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("RC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "RC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("EXER_CG", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "EXER_CG", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("EXER_PA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "EXER_PA", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("Password", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Password", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("UserC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DateC", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("UserM", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("DateM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("TEL", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TEL", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("FAX", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "FAX", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CF", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CF", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("MAIL", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "MAIL", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("NIS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "NIS", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CodeActivite", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CodeActivite", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CPWilaya", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPWilaya", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("CPCommune", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPCommune", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("Inspection", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Inspection", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("Recette", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Recette", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("LIBAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIBAR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ADRAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ADRAR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.InsertCommand.Parameters.Add(new OleDbParameter("ACTAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ACTAR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand = new OleDbCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE `Dossiers` SET `UNI` = ?, `LIB` = ?, `ADR` = ?, `CP` = ?, `NUMIF` = ?, `NUMAI` = ?, `ACT` = ?, `RC` = ?, `EXER_CG` = ?, `EXER_PA` = ?, `Password` = ?, `UserC` = ?, `DateC` = ?, `UserM` = ?, `DateM` = ?, `TEL` = ?, `FAX` = ?, `CF` = ?, `MAIL` = ?, `NIS` = ?, `CodeActivite` = ?, `CPWilaya` = ?, `CPCommune` = ?, `Inspection` = ?, `Recette` = ?, `LIBAR` = ?, `ADRAR` = ?, `ACTAR` = ? WHERE ((`UNI` = ?) AND ((? = 1 AND `LIB` IS NULL) OR (`LIB` = ?)) AND ((? = 1 AND `ADR` IS NULL) OR (`ADR` = ?)) AND ((? = 1 AND `CP` IS NULL) OR (`CP` = ?)) AND ((? = 1 AND `NUMIF` IS NULL) OR (`NUMIF` = ?)) AND ((? = 1 AND `NUMAI` IS NULL) OR (`NUMAI` = ?)) AND ((? = 1 AND `ACT` IS NULL) OR (`ACT` = ?)) AND ((? = 1 AND `RC` IS NULL) OR (`RC` = ?)) AND ((? = 1 AND `EXER_CG` IS NULL) OR (`EXER_CG` = ?)) AND ((? = 1 AND `EXER_PA` IS NULL) OR (`EXER_PA` = ?)) AND ((? = 1 AND `ID` IS NULL) OR (`ID` = ?)) AND ((? = 1 AND `Password` IS NULL) OR (`Password` = ?)) AND ((? = 1 AND `UserC` IS NULL) OR (`UserC` = ?)) AND ((? = 1 AND `DateC` IS NULL) OR (`DateC` = ?)) AND ((? = 1 AND `UserM` IS NULL) OR (`UserM` = ?)) AND ((? = 1 AND `DateM` IS NULL) OR (`DateM` = ?)) AND ((? = 1 AND `TEL` IS NULL) OR (`TEL` = ?)) AND ((? = 1 AND `FAX` IS NULL) OR (`FAX` = ?)) AND ((? = 1 AND `CF` IS NULL) OR (`CF` = ?)) AND ((? = 1 AND `MAIL` IS NULL) OR (`MAIL` = ?)) AND ((? = 1 AND `NIS` IS NULL) OR (`NIS` = ?)) AND ((? = 1 AND `CodeActivite` IS NULL) OR (`CodeActivite` = ?)) AND ((? = 1 AND `CPWilaya` IS NULL) OR (`CPWilaya` = ?)) AND ((? = 1 AND `CPCommune` IS NULL) OR (`CPCommune` = ?)) AND ((? = 1 AND `Inspection` IS NULL) OR (`Inspection` = ?)) AND ((? = 1 AND `Recette` IS NULL) OR (`Recette` = ?)) AND ((? = 1 AND `LIBAR` IS NULL) OR (`LIBAR` = ?)) AND ((? = 1 AND `ADRAR` IS NULL) OR (`ADRAR` = ?)) AND ((? = 1 AND `ACTAR` IS NULL) OR (`ACTAR` = ?)))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("UNI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UNI", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ADR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ADR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CP", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CP", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("NUMIF", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "NUMIF", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("NUMAI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "NUMAI", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ACT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ACT", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("RC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "RC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("EXER_CG", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "EXER_CG", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("EXER_PA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "EXER_PA", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Password", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Password", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("UserC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DateC", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("UserM", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DateM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TEL", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TEL", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("FAX", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "FAX", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CF", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CF", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("MAIL", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "MAIL", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("NIS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "NIS", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CodeActivite", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CodeActivite", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CPWilaya", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPWilaya", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CPCommune", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPCommune", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Inspection", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Inspection", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Recette", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Recette", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("LIBAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIBAR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ADRAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ADRAR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ACTAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ACTAR", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_UNI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UNI", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_LIB", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_LIB", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIB", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ADR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ADR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ADR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ADR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CP", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CP", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CP", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CP", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_NUMIF", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "NUMIF", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_NUMIF", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "NUMIF", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_NUMAI", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "NUMAI", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_NUMAI", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "NUMAI", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ACT", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ACT", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ACT", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ACT", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_RC", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "RC", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_RC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "RC", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_EXER_CG", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "EXER_CG", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_EXER_CG", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "EXER_CG", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_EXER_PA", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "EXER_PA", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_EXER_PA", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "EXER_PA", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_Password", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Password", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Password", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Password", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_UserC", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_UserC", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserC", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_DateC", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_DateC", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateC", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_UserM", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_UserM", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "UserM", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_DateM", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_DateM", OleDbType.Date, 0, ParameterDirection.Input, 0, 0, "DateM", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_TEL", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "TEL", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_TEL", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "TEL", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_FAX", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "FAX", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_FAX", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "FAX", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CF", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CF", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CF", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CF", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_MAIL", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "MAIL", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_MAIL", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "MAIL", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_NIS", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "NIS", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_NIS", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "NIS", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CodeActivite", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CodeActivite", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CodeActivite", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CodeActivite", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CPWilaya", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPWilaya", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CPWilaya", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPWilaya", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_CPCommune", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "CPCommune", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_CPCommune", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "CPCommune", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_Inspection", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Inspection", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Inspection", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Inspection", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_Recette", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Recette", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Recette", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Recette", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_LIBAR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "LIBAR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_LIBAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "LIBAR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ADRAR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ADRAR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ADRAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ADRAR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_ACTAR", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ACTAR", DataRowVersion.Original, sourceColumnNullMapping: true, null));
		_adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ACTAR", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "ACTAR", DataRowVersion.Original, sourceColumnNullMapping: false, null));
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
		_commandCollection[0].CommandText = "SELECT        UNI, LIB, ADR, CP, NUMIF, NUMAI, ACT, RC, EXER_CG, EXER_PA, ID, [Password], UserC, DateC, UserM, DateM, TEL, FAX, CF, MAIL, NIS, CodeActivite, CPWilaya, CPCommune, Inspection, Recette, LIBAR, ADRAR, ACTAR\r\nFROM            Dossiers";
		_commandCollection[0].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(DataSet1.DossiersDataTable dataTable)
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
	public virtual DataSet1.DossiersDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		DataSet1.DossiersDataTable dataTable = new DataSet1.DossiersDataTable();
		Adapter.Fill(dataTable);
		return dataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet1.DossiersDataTable dataTable)
	{
		return Adapter.Update(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet1 dataSet)
	{
		return Adapter.Update(dataSet, "Dossiers");
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
	public virtual int Delete(string Original_UNI, string Original_LIB, string Original_ADR, string Original_CP, string Original_NUMIF, string Original_NUMAI, string Original_ACT, string Original_RC, string Original_EXER_CG, string Original_EXER_PA, int Original_ID, string Original_Password, string Original_UserC, DateTime? Original_DateC, string Original_UserM, DateTime? Original_DateM, string Original_TEL, string Original_FAX, string Original_CF, string Original_MAIL, string Original_NIS, string Original_CodeActivite, string Original_CPWilaya, string Original_CPCommune, string Original_Inspection, string Original_Recette, string Original_LIBAR, string Original_ADRAR, string Original_ACTAR)
	{
		if (Original_UNI == null)
		{
			Adapter.DeleteCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[0].Value = Original_UNI;
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
		if (Original_ADR == null)
		{
			Adapter.DeleteCommand.Parameters[3].Value = 1;
			Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[3].Value = 0;
			Adapter.DeleteCommand.Parameters[4].Value = Original_ADR;
		}
		if (Original_CP == null)
		{
			Adapter.DeleteCommand.Parameters[5].Value = 1;
			Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[5].Value = 0;
			Adapter.DeleteCommand.Parameters[6].Value = Original_CP;
		}
		if (Original_NUMIF == null)
		{
			Adapter.DeleteCommand.Parameters[7].Value = 1;
			Adapter.DeleteCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[7].Value = 0;
			Adapter.DeleteCommand.Parameters[8].Value = Original_NUMIF;
		}
		if (Original_NUMAI == null)
		{
			Adapter.DeleteCommand.Parameters[9].Value = 1;
			Adapter.DeleteCommand.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[9].Value = 0;
			Adapter.DeleteCommand.Parameters[10].Value = Original_NUMAI;
		}
		if (Original_ACT == null)
		{
			Adapter.DeleteCommand.Parameters[11].Value = 1;
			Adapter.DeleteCommand.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[11].Value = 0;
			Adapter.DeleteCommand.Parameters[12].Value = Original_ACT;
		}
		if (Original_RC == null)
		{
			Adapter.DeleteCommand.Parameters[13].Value = 1;
			Adapter.DeleteCommand.Parameters[14].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[13].Value = 0;
			Adapter.DeleteCommand.Parameters[14].Value = Original_RC;
		}
		if (Original_EXER_CG == null)
		{
			Adapter.DeleteCommand.Parameters[15].Value = 1;
			Adapter.DeleteCommand.Parameters[16].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[15].Value = 0;
			Adapter.DeleteCommand.Parameters[16].Value = Original_EXER_CG;
		}
		if (Original_EXER_PA == null)
		{
			Adapter.DeleteCommand.Parameters[17].Value = 1;
			Adapter.DeleteCommand.Parameters[18].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[17].Value = 0;
			Adapter.DeleteCommand.Parameters[18].Value = Original_EXER_PA;
		}
		Adapter.DeleteCommand.Parameters[19].Value = 0;
		Adapter.DeleteCommand.Parameters[20].Value = Original_ID;
		if (Original_Password == null)
		{
			Adapter.DeleteCommand.Parameters[21].Value = 1;
			Adapter.DeleteCommand.Parameters[22].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[21].Value = 0;
			Adapter.DeleteCommand.Parameters[22].Value = Original_Password;
		}
		if (Original_UserC == null)
		{
			Adapter.DeleteCommand.Parameters[23].Value = 1;
			Adapter.DeleteCommand.Parameters[24].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[23].Value = 0;
			Adapter.DeleteCommand.Parameters[24].Value = Original_UserC;
		}
		if (Original_DateC.HasValue)
		{
			Adapter.DeleteCommand.Parameters[25].Value = 0;
			Adapter.DeleteCommand.Parameters[26].Value = Original_DateC.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[25].Value = 1;
			Adapter.DeleteCommand.Parameters[26].Value = DBNull.Value;
		}
		if (Original_UserM == null)
		{
			Adapter.DeleteCommand.Parameters[27].Value = 1;
			Adapter.DeleteCommand.Parameters[28].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[27].Value = 0;
			Adapter.DeleteCommand.Parameters[28].Value = Original_UserM;
		}
		if (Original_DateM.HasValue)
		{
			Adapter.DeleteCommand.Parameters[29].Value = 0;
			Adapter.DeleteCommand.Parameters[30].Value = Original_DateM.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[29].Value = 1;
			Adapter.DeleteCommand.Parameters[30].Value = DBNull.Value;
		}
		if (Original_TEL == null)
		{
			Adapter.DeleteCommand.Parameters[31].Value = 1;
			Adapter.DeleteCommand.Parameters[32].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[31].Value = 0;
			Adapter.DeleteCommand.Parameters[32].Value = Original_TEL;
		}
		if (Original_FAX == null)
		{
			Adapter.DeleteCommand.Parameters[33].Value = 1;
			Adapter.DeleteCommand.Parameters[34].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[33].Value = 0;
			Adapter.DeleteCommand.Parameters[34].Value = Original_FAX;
		}
		if (Original_CF == null)
		{
			Adapter.DeleteCommand.Parameters[35].Value = 1;
			Adapter.DeleteCommand.Parameters[36].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[35].Value = 0;
			Adapter.DeleteCommand.Parameters[36].Value = Original_CF;
		}
		if (Original_MAIL == null)
		{
			Adapter.DeleteCommand.Parameters[37].Value = 1;
			Adapter.DeleteCommand.Parameters[38].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[37].Value = 0;
			Adapter.DeleteCommand.Parameters[38].Value = Original_MAIL;
		}
		if (Original_NIS == null)
		{
			Adapter.DeleteCommand.Parameters[39].Value = 1;
			Adapter.DeleteCommand.Parameters[40].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[39].Value = 0;
			Adapter.DeleteCommand.Parameters[40].Value = Original_NIS;
		}
		if (Original_CodeActivite == null)
		{
			Adapter.DeleteCommand.Parameters[41].Value = 1;
			Adapter.DeleteCommand.Parameters[42].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[41].Value = 0;
			Adapter.DeleteCommand.Parameters[42].Value = Original_CodeActivite;
		}
		if (Original_CPWilaya == null)
		{
			Adapter.DeleteCommand.Parameters[43].Value = 1;
			Adapter.DeleteCommand.Parameters[44].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[43].Value = 0;
			Adapter.DeleteCommand.Parameters[44].Value = Original_CPWilaya;
		}
		if (Original_CPCommune == null)
		{
			Adapter.DeleteCommand.Parameters[45].Value = 1;
			Adapter.DeleteCommand.Parameters[46].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[45].Value = 0;
			Adapter.DeleteCommand.Parameters[46].Value = Original_CPCommune;
		}
		if (Original_Inspection == null)
		{
			Adapter.DeleteCommand.Parameters[47].Value = 1;
			Adapter.DeleteCommand.Parameters[48].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[47].Value = 0;
			Adapter.DeleteCommand.Parameters[48].Value = Original_Inspection;
		}
		if (Original_Recette == null)
		{
			Adapter.DeleteCommand.Parameters[49].Value = 1;
			Adapter.DeleteCommand.Parameters[50].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[49].Value = 0;
			Adapter.DeleteCommand.Parameters[50].Value = Original_Recette;
		}
		if (Original_LIBAR == null)
		{
			Adapter.DeleteCommand.Parameters[51].Value = 1;
			Adapter.DeleteCommand.Parameters[52].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[51].Value = 0;
			Adapter.DeleteCommand.Parameters[52].Value = Original_LIBAR;
		}
		if (Original_ADRAR == null)
		{
			Adapter.DeleteCommand.Parameters[53].Value = 1;
			Adapter.DeleteCommand.Parameters[54].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[53].Value = 0;
			Adapter.DeleteCommand.Parameters[54].Value = Original_ADRAR;
		}
		if (Original_ACTAR == null)
		{
			Adapter.DeleteCommand.Parameters[55].Value = 1;
			Adapter.DeleteCommand.Parameters[56].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[55].Value = 0;
			Adapter.DeleteCommand.Parameters[56].Value = Original_ACTAR;
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
	public virtual int Insert(string UNI, string LIB, string ADR, string CP, string NUMIF, string NUMAI, string ACT, string RC, string EXER_CG, string EXER_PA, string Password, string UserC, DateTime? DateC, string UserM, DateTime? DateM, string TEL, string FAX, string CF, string MAIL, string NIS, string CodeActivite, string CPWilaya, string CPCommune, string Inspection, string Recette, string LIBAR, string ADRAR, string ACTAR)
	{
		if (UNI == null)
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = UNI;
		}
		if (LIB == null)
		{
			Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[1].Value = LIB;
		}
		if (ADR == null)
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = ADR;
		}
		if (CP == null)
		{
			Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[3].Value = CP;
		}
		if (NUMIF == null)
		{
			Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[4].Value = NUMIF;
		}
		if (NUMAI == null)
		{
			Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[5].Value = NUMAI;
		}
		if (ACT == null)
		{
			Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[6].Value = ACT;
		}
		if (RC == null)
		{
			Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[7].Value = RC;
		}
		if (EXER_CG == null)
		{
			Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[8].Value = EXER_CG;
		}
		if (EXER_PA == null)
		{
			Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[9].Value = EXER_PA;
		}
		if (Password == null)
		{
			Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[10].Value = Password;
		}
		if (UserC == null)
		{
			Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[11].Value = UserC;
		}
		if (DateC.HasValue)
		{
			Adapter.InsertCommand.Parameters[12].Value = DateC.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
		}
		if (UserM == null)
		{
			Adapter.InsertCommand.Parameters[13].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[13].Value = UserM;
		}
		if (DateM.HasValue)
		{
			Adapter.InsertCommand.Parameters[14].Value = DateM.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[14].Value = DBNull.Value;
		}
		if (TEL == null)
		{
			Adapter.InsertCommand.Parameters[15].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[15].Value = TEL;
		}
		if (FAX == null)
		{
			Adapter.InsertCommand.Parameters[16].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[16].Value = FAX;
		}
		if (CF == null)
		{
			Adapter.InsertCommand.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[17].Value = CF;
		}
		if (MAIL == null)
		{
			Adapter.InsertCommand.Parameters[18].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[18].Value = MAIL;
		}
		if (NIS == null)
		{
			Adapter.InsertCommand.Parameters[19].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[19].Value = NIS;
		}
		if (CodeActivite == null)
		{
			Adapter.InsertCommand.Parameters[20].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[20].Value = CodeActivite;
		}
		if (CPWilaya == null)
		{
			Adapter.InsertCommand.Parameters[21].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[21].Value = CPWilaya;
		}
		if (CPCommune == null)
		{
			Adapter.InsertCommand.Parameters[22].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[22].Value = CPCommune;
		}
		if (Inspection == null)
		{
			Adapter.InsertCommand.Parameters[23].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[23].Value = Inspection;
		}
		if (Recette == null)
		{
			Adapter.InsertCommand.Parameters[24].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[24].Value = Recette;
		}
		if (LIBAR == null)
		{
			Adapter.InsertCommand.Parameters[25].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[25].Value = LIBAR;
		}
		if (ADRAR == null)
		{
			Adapter.InsertCommand.Parameters[26].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[26].Value = ADRAR;
		}
		if (ACTAR == null)
		{
			Adapter.InsertCommand.Parameters[27].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[27].Value = ACTAR;
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
	public virtual int Update(string UNI, string LIB, string ADR, string CP, string NUMIF, string NUMAI, string ACT, string RC, string EXER_CG, string EXER_PA, string Password, string UserC, DateTime? DateC, string UserM, DateTime? DateM, string TEL, string FAX, string CF, string MAIL, string NIS, string CodeActivite, string CPWilaya, string CPCommune, string Inspection, string Recette, string LIBAR, string ADRAR, string ACTAR, string Original_UNI, string Original_LIB, string Original_ADR, string Original_CP, string Original_NUMIF, string Original_NUMAI, string Original_ACT, string Original_RC, string Original_EXER_CG, string Original_EXER_PA, int Original_ID, string Original_Password, string Original_UserC, DateTime? Original_DateC, string Original_UserM, DateTime? Original_DateM, string Original_TEL, string Original_FAX, string Original_CF, string Original_MAIL, string Original_NIS, string Original_CodeActivite, string Original_CPWilaya, string Original_CPCommune, string Original_Inspection, string Original_Recette, string Original_LIBAR, string Original_ADRAR, string Original_ACTAR)
	{
		if (UNI == null)
		{
			Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[0].Value = UNI;
		}
		if (LIB == null)
		{
			Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[1].Value = LIB;
		}
		if (ADR == null)
		{
			Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[2].Value = ADR;
		}
		if (CP == null)
		{
			Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[3].Value = CP;
		}
		if (NUMIF == null)
		{
			Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[4].Value = NUMIF;
		}
		if (NUMAI == null)
		{
			Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[5].Value = NUMAI;
		}
		if (ACT == null)
		{
			Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[6].Value = ACT;
		}
		if (RC == null)
		{
			Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[7].Value = RC;
		}
		if (EXER_CG == null)
		{
			Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[8].Value = EXER_CG;
		}
		if (EXER_PA == null)
		{
			Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[9].Value = EXER_PA;
		}
		if (Password == null)
		{
			Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[10].Value = Password;
		}
		if (UserC == null)
		{
			Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[11].Value = UserC;
		}
		if (DateC.HasValue)
		{
			Adapter.UpdateCommand.Parameters[12].Value = DateC.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
		}
		if (UserM == null)
		{
			Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[13].Value = UserM;
		}
		if (DateM.HasValue)
		{
			Adapter.UpdateCommand.Parameters[14].Value = DateM.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
		}
		if (TEL == null)
		{
			Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[15].Value = TEL;
		}
		if (FAX == null)
		{
			Adapter.UpdateCommand.Parameters[16].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[16].Value = FAX;
		}
		if (CF == null)
		{
			Adapter.UpdateCommand.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[17].Value = CF;
		}
		if (MAIL == null)
		{
			Adapter.UpdateCommand.Parameters[18].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[18].Value = MAIL;
		}
		if (NIS == null)
		{
			Adapter.UpdateCommand.Parameters[19].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[19].Value = NIS;
		}
		if (CodeActivite == null)
		{
			Adapter.UpdateCommand.Parameters[20].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[20].Value = CodeActivite;
		}
		if (CPWilaya == null)
		{
			Adapter.UpdateCommand.Parameters[21].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[21].Value = CPWilaya;
		}
		if (CPCommune == null)
		{
			Adapter.UpdateCommand.Parameters[22].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[22].Value = CPCommune;
		}
		if (Inspection == null)
		{
			Adapter.UpdateCommand.Parameters[23].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[23].Value = Inspection;
		}
		if (Recette == null)
		{
			Adapter.UpdateCommand.Parameters[24].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[24].Value = Recette;
		}
		if (LIBAR == null)
		{
			Adapter.UpdateCommand.Parameters[25].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[25].Value = LIBAR;
		}
		if (ADRAR == null)
		{
			Adapter.UpdateCommand.Parameters[26].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[26].Value = ADRAR;
		}
		if (ACTAR == null)
		{
			Adapter.UpdateCommand.Parameters[27].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[27].Value = ACTAR;
		}
		if (Original_UNI == null)
		{
			Adapter.UpdateCommand.Parameters[28].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[28].Value = Original_UNI;
		}
		if (Original_LIB == null)
		{
			Adapter.UpdateCommand.Parameters[29].Value = 1;
			Adapter.UpdateCommand.Parameters[30].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[29].Value = 0;
			Adapter.UpdateCommand.Parameters[30].Value = Original_LIB;
		}
		if (Original_ADR == null)
		{
			Adapter.UpdateCommand.Parameters[31].Value = 1;
			Adapter.UpdateCommand.Parameters[32].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[31].Value = 0;
			Adapter.UpdateCommand.Parameters[32].Value = Original_ADR;
		}
		if (Original_CP == null)
		{
			Adapter.UpdateCommand.Parameters[33].Value = 1;
			Adapter.UpdateCommand.Parameters[34].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[33].Value = 0;
			Adapter.UpdateCommand.Parameters[34].Value = Original_CP;
		}
		if (Original_NUMIF == null)
		{
			Adapter.UpdateCommand.Parameters[35].Value = 1;
			Adapter.UpdateCommand.Parameters[36].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[35].Value = 0;
			Adapter.UpdateCommand.Parameters[36].Value = Original_NUMIF;
		}
		if (Original_NUMAI == null)
		{
			Adapter.UpdateCommand.Parameters[37].Value = 1;
			Adapter.UpdateCommand.Parameters[38].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[37].Value = 0;
			Adapter.UpdateCommand.Parameters[38].Value = Original_NUMAI;
		}
		if (Original_ACT == null)
		{
			Adapter.UpdateCommand.Parameters[39].Value = 1;
			Adapter.UpdateCommand.Parameters[40].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[39].Value = 0;
			Adapter.UpdateCommand.Parameters[40].Value = Original_ACT;
		}
		if (Original_RC == null)
		{
			Adapter.UpdateCommand.Parameters[41].Value = 1;
			Adapter.UpdateCommand.Parameters[42].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[41].Value = 0;
			Adapter.UpdateCommand.Parameters[42].Value = Original_RC;
		}
		if (Original_EXER_CG == null)
		{
			Adapter.UpdateCommand.Parameters[43].Value = 1;
			Adapter.UpdateCommand.Parameters[44].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[43].Value = 0;
			Adapter.UpdateCommand.Parameters[44].Value = Original_EXER_CG;
		}
		if (Original_EXER_PA == null)
		{
			Adapter.UpdateCommand.Parameters[45].Value = 1;
			Adapter.UpdateCommand.Parameters[46].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[45].Value = 0;
			Adapter.UpdateCommand.Parameters[46].Value = Original_EXER_PA;
		}
		Adapter.UpdateCommand.Parameters[47].Value = 0;
		Adapter.UpdateCommand.Parameters[48].Value = Original_ID;
		if (Original_Password == null)
		{
			Adapter.UpdateCommand.Parameters[49].Value = 1;
			Adapter.UpdateCommand.Parameters[50].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[49].Value = 0;
			Adapter.UpdateCommand.Parameters[50].Value = Original_Password;
		}
		if (Original_UserC == null)
		{
			Adapter.UpdateCommand.Parameters[51].Value = 1;
			Adapter.UpdateCommand.Parameters[52].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[51].Value = 0;
			Adapter.UpdateCommand.Parameters[52].Value = Original_UserC;
		}
		if (Original_DateC.HasValue)
		{
			Adapter.UpdateCommand.Parameters[53].Value = 0;
			Adapter.UpdateCommand.Parameters[54].Value = Original_DateC.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[53].Value = 1;
			Adapter.UpdateCommand.Parameters[54].Value = DBNull.Value;
		}
		if (Original_UserM == null)
		{
			Adapter.UpdateCommand.Parameters[55].Value = 1;
			Adapter.UpdateCommand.Parameters[56].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[55].Value = 0;
			Adapter.UpdateCommand.Parameters[56].Value = Original_UserM;
		}
		if (Original_DateM.HasValue)
		{
			Adapter.UpdateCommand.Parameters[57].Value = 0;
			Adapter.UpdateCommand.Parameters[58].Value = Original_DateM.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[57].Value = 1;
			Adapter.UpdateCommand.Parameters[58].Value = DBNull.Value;
		}
		if (Original_TEL == null)
		{
			Adapter.UpdateCommand.Parameters[59].Value = 1;
			Adapter.UpdateCommand.Parameters[60].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[59].Value = 0;
			Adapter.UpdateCommand.Parameters[60].Value = Original_TEL;
		}
		if (Original_FAX == null)
		{
			Adapter.UpdateCommand.Parameters[61].Value = 1;
			Adapter.UpdateCommand.Parameters[62].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[61].Value = 0;
			Adapter.UpdateCommand.Parameters[62].Value = Original_FAX;
		}
		if (Original_CF == null)
		{
			Adapter.UpdateCommand.Parameters[63].Value = 1;
			Adapter.UpdateCommand.Parameters[64].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[63].Value = 0;
			Adapter.UpdateCommand.Parameters[64].Value = Original_CF;
		}
		if (Original_MAIL == null)
		{
			Adapter.UpdateCommand.Parameters[65].Value = 1;
			Adapter.UpdateCommand.Parameters[66].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[65].Value = 0;
			Adapter.UpdateCommand.Parameters[66].Value = Original_MAIL;
		}
		if (Original_NIS == null)
		{
			Adapter.UpdateCommand.Parameters[67].Value = 1;
			Adapter.UpdateCommand.Parameters[68].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[67].Value = 0;
			Adapter.UpdateCommand.Parameters[68].Value = Original_NIS;
		}
		if (Original_CodeActivite == null)
		{
			Adapter.UpdateCommand.Parameters[69].Value = 1;
			Adapter.UpdateCommand.Parameters[70].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[69].Value = 0;
			Adapter.UpdateCommand.Parameters[70].Value = Original_CodeActivite;
		}
		if (Original_CPWilaya == null)
		{
			Adapter.UpdateCommand.Parameters[71].Value = 1;
			Adapter.UpdateCommand.Parameters[72].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[71].Value = 0;
			Adapter.UpdateCommand.Parameters[72].Value = Original_CPWilaya;
		}
		if (Original_CPCommune == null)
		{
			Adapter.UpdateCommand.Parameters[73].Value = 1;
			Adapter.UpdateCommand.Parameters[74].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[73].Value = 0;
			Adapter.UpdateCommand.Parameters[74].Value = Original_CPCommune;
		}
		if (Original_Inspection == null)
		{
			Adapter.UpdateCommand.Parameters[75].Value = 1;
			Adapter.UpdateCommand.Parameters[76].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[75].Value = 0;
			Adapter.UpdateCommand.Parameters[76].Value = Original_Inspection;
		}
		if (Original_Recette == null)
		{
			Adapter.UpdateCommand.Parameters[77].Value = 1;
			Adapter.UpdateCommand.Parameters[78].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[77].Value = 0;
			Adapter.UpdateCommand.Parameters[78].Value = Original_Recette;
		}
		if (Original_LIBAR == null)
		{
			Adapter.UpdateCommand.Parameters[79].Value = 1;
			Adapter.UpdateCommand.Parameters[80].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[79].Value = 0;
			Adapter.UpdateCommand.Parameters[80].Value = Original_LIBAR;
		}
		if (Original_ADRAR == null)
		{
			Adapter.UpdateCommand.Parameters[81].Value = 1;
			Adapter.UpdateCommand.Parameters[82].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[81].Value = 0;
			Adapter.UpdateCommand.Parameters[82].Value = Original_ADRAR;
		}
		if (Original_ACTAR == null)
		{
			Adapter.UpdateCommand.Parameters[83].Value = 1;
			Adapter.UpdateCommand.Parameters[84].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[83].Value = 0;
			Adapter.UpdateCommand.Parameters[84].Value = Original_ACTAR;
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
	public virtual int Update(string LIB, string ADR, string CP, string NUMIF, string NUMAI, string ACT, string RC, string EXER_CG, string EXER_PA, string Password, string UserC, DateTime? DateC, string UserM, DateTime? DateM, string TEL, string FAX, string CF, string MAIL, string NIS, string CodeActivite, string CPWilaya, string CPCommune, string Inspection, string Recette, string LIBAR, string ADRAR, string ACTAR, string Original_UNI, string Original_LIB, string Original_ADR, string Original_CP, string Original_NUMIF, string Original_NUMAI, string Original_ACT, string Original_RC, string Original_EXER_CG, string Original_EXER_PA, int Original_ID, string Original_Password, string Original_UserC, DateTime? Original_DateC, string Original_UserM, DateTime? Original_DateM, string Original_TEL, string Original_FAX, string Original_CF, string Original_MAIL, string Original_NIS, string Original_CodeActivite, string Original_CPWilaya, string Original_CPCommune, string Original_Inspection, string Original_Recette, string Original_LIBAR, string Original_ADRAR, string Original_ACTAR)
	{
		return Update(Original_UNI, LIB, ADR, CP, NUMIF, NUMAI, ACT, RC, EXER_CG, EXER_PA, Password, UserC, DateC, UserM, DateM, TEL, FAX, CF, MAIL, NIS, CodeActivite, CPWilaya, CPCommune, Inspection, Recette, LIBAR, ADRAR, ACTAR, Original_UNI, Original_LIB, Original_ADR, Original_CP, Original_NUMIF, Original_NUMAI, Original_ACT, Original_RC, Original_EXER_CG, Original_EXER_PA, Original_ID, Original_Password, Original_UserC, Original_DateC, Original_UserM, Original_DateM, Original_TEL, Original_FAX, Original_CF, Original_MAIL, Original_NIS, Original_CodeActivite, Original_CPWilaya, Original_CPCommune, Original_Inspection, Original_Recette, Original_LIBAR, Original_ADRAR, Original_ACTAR);
	}
}
