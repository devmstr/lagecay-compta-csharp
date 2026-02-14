using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;

namespace compta.DataSet1TableAdapters;

[DesignerCategory("code")]
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapterManager")]
public class TableAdapterManager : Component
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public enum UpdateOrderOption
	{
		InsertUpdateDelete,
		UpdateInsertDelete
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private class SelfReferenceComparer : IComparer<DataRow>
	{
		private DataRelation _relation;

		private int _childFirst;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal SelfReferenceComparer(DataRelation relation, bool childFirst)
		{
			_relation = relation;
			if (childFirst)
			{
				_childFirst = -1;
			}
			else
			{
				_childFirst = 1;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private DataRow GetRoot(DataRow row, out int distance)
		{
			DataRow root = row;
			distance = 0;
			IDictionary<DataRow, DataRow> traversedRows = new Dictionary<DataRow, DataRow>();
			traversedRows[row] = row;
			DataRow parent = row.GetParentRow(_relation, DataRowVersion.Default);
			while (parent != null && !traversedRows.ContainsKey(parent))
			{
				distance++;
				root = parent;
				traversedRows[parent] = parent;
				parent = parent.GetParentRow(_relation, DataRowVersion.Default);
			}
			if (distance == 0)
			{
				traversedRows.Clear();
				traversedRows[row] = row;
				parent = row.GetParentRow(_relation, DataRowVersion.Original);
				while (parent != null && !traversedRows.ContainsKey(parent))
				{
					distance++;
					root = parent;
					traversedRows[parent] = parent;
					parent = parent.GetParentRow(_relation, DataRowVersion.Original);
				}
			}
			return root;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int Compare(DataRow row1, DataRow row2)
		{
			if (row1 == row2)
			{
				return 0;
			}
			if (row1 == null)
			{
				return -1;
			}
			if (row2 == null)
			{
				return 1;
			}
			int distance1 = 0;
			DataRow root1 = GetRoot(row1, out distance1);
			int distance2 = 0;
			DataRow root2 = GetRoot(row2, out distance2);
			if (root1 == root2)
			{
				return _childFirst * distance1.CompareTo(distance2);
			}
			if (root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2))
			{
				return -1;
			}
			return 1;
		}
	}

	private UpdateOrderOption _updateOrder;

	private BalanceTableAdapter _balanceTableAdapter;

	private ComptesTableAdapter _comptesTableAdapter;

	private DossiersTableAdapter _dossiersTableAdapter;

	private Ecritures00TableAdapter _ecritures00TableAdapter;

	private EcrtriTableAdapter _ecrtriTableAdapter;

	private EtatsTableAdapter _etatsTableAdapter;

	private ImmoTableAdapter _immoTableAdapter;

	private JournauxTableAdapter _journauxTableAdapter;

	private LesEtatsTableAdapter _lesEtatsTableAdapter;

	private LesMoisTableAdapter _lesMoisTableAdapter;

	private TiersTableAdapter _tiersTableAdapter;

	private VillesTableAdapter _villesTableAdapter;

	private Ecritures_tTableAdapter _ecritures_tTableAdapter;

	private EcrituresTableAdapter _ecrituresTableAdapter;

	private PiecesTableAdapter _piecesTableAdapter;

	private bool _backupDataSetBeforeUpdate;

	private IDbConnection _connection;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public UpdateOrderOption UpdateOrder
	{
		get
		{
			return _updateOrder;
		}
		set
		{
			_updateOrder = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public BalanceTableAdapter BalanceTableAdapter
	{
		get
		{
			return _balanceTableAdapter;
		}
		set
		{
			_balanceTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public ComptesTableAdapter ComptesTableAdapter
	{
		get
		{
			return _comptesTableAdapter;
		}
		set
		{
			_comptesTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public DossiersTableAdapter DossiersTableAdapter
	{
		get
		{
			return _dossiersTableAdapter;
		}
		set
		{
			_dossiersTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public Ecritures00TableAdapter Ecritures00TableAdapter
	{
		get
		{
			return _ecritures00TableAdapter;
		}
		set
		{
			_ecritures00TableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public EcrtriTableAdapter EcrtriTableAdapter
	{
		get
		{
			return _ecrtriTableAdapter;
		}
		set
		{
			_ecrtriTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public EtatsTableAdapter EtatsTableAdapter
	{
		get
		{
			return _etatsTableAdapter;
		}
		set
		{
			_etatsTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public ImmoTableAdapter ImmoTableAdapter
	{
		get
		{
			return _immoTableAdapter;
		}
		set
		{
			_immoTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public JournauxTableAdapter JournauxTableAdapter
	{
		get
		{
			return _journauxTableAdapter;
		}
		set
		{
			_journauxTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public LesEtatsTableAdapter LesEtatsTableAdapter
	{
		get
		{
			return _lesEtatsTableAdapter;
		}
		set
		{
			_lesEtatsTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public LesMoisTableAdapter LesMoisTableAdapter
	{
		get
		{
			return _lesMoisTableAdapter;
		}
		set
		{
			_lesMoisTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public TiersTableAdapter TiersTableAdapter
	{
		get
		{
			return _tiersTableAdapter;
		}
		set
		{
			_tiersTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public VillesTableAdapter VillesTableAdapter
	{
		get
		{
			return _villesTableAdapter;
		}
		set
		{
			_villesTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public Ecritures_tTableAdapter Ecritures_tTableAdapter
	{
		get
		{
			return _ecritures_tTableAdapter;
		}
		set
		{
			_ecritures_tTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public EcrituresTableAdapter EcrituresTableAdapter
	{
		get
		{
			return _ecrituresTableAdapter;
		}
		set
		{
			_ecrituresTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public PiecesTableAdapter PiecesTableAdapter
	{
		get
		{
			return _piecesTableAdapter;
		}
		set
		{
			_piecesTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool BackupDataSetBeforeUpdate
	{
		get
		{
			return _backupDataSetBeforeUpdate;
		}
		set
		{
			_backupDataSetBeforeUpdate = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	public IDbConnection Connection
	{
		get
		{
			if (_connection != null)
			{
				return _connection;
			}
			if (_balanceTableAdapter != null && _balanceTableAdapter.Connection != null)
			{
				return _balanceTableAdapter.Connection;
			}
			if (_comptesTableAdapter != null && _comptesTableAdapter.Connection != null)
			{
				return _comptesTableAdapter.Connection;
			}
			if (_dossiersTableAdapter != null && _dossiersTableAdapter.Connection != null)
			{
				return _dossiersTableAdapter.Connection;
			}
			if (_ecritures00TableAdapter != null && _ecritures00TableAdapter.Connection != null)
			{
				return _ecritures00TableAdapter.Connection;
			}
			if (_ecrtriTableAdapter != null && _ecrtriTableAdapter.Connection != null)
			{
				return _ecrtriTableAdapter.Connection;
			}
			if (_etatsTableAdapter != null && _etatsTableAdapter.Connection != null)
			{
				return _etatsTableAdapter.Connection;
			}
			if (_immoTableAdapter != null && _immoTableAdapter.Connection != null)
			{
				return _immoTableAdapter.Connection;
			}
			if (_journauxTableAdapter != null && _journauxTableAdapter.Connection != null)
			{
				return _journauxTableAdapter.Connection;
			}
			if (_lesEtatsTableAdapter != null && _lesEtatsTableAdapter.Connection != null)
			{
				return _lesEtatsTableAdapter.Connection;
			}
			if (_lesMoisTableAdapter != null && _lesMoisTableAdapter.Connection != null)
			{
				return _lesMoisTableAdapter.Connection;
			}
			if (_tiersTableAdapter != null && _tiersTableAdapter.Connection != null)
			{
				return _tiersTableAdapter.Connection;
			}
			if (_villesTableAdapter != null && _villesTableAdapter.Connection != null)
			{
				return _villesTableAdapter.Connection;
			}
			if (_ecritures_tTableAdapter != null && _ecritures_tTableAdapter.Connection != null)
			{
				return _ecritures_tTableAdapter.Connection;
			}
			if (_ecrituresTableAdapter != null && _ecrituresTableAdapter.Connection != null)
			{
				return _ecrituresTableAdapter.Connection;
			}
			if (_piecesTableAdapter != null && _piecesTableAdapter.Connection != null)
			{
				return _piecesTableAdapter.Connection;
			}
			return null;
		}
		set
		{
			_connection = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	public int TableAdapterInstanceCount
	{
		get
		{
			int count = 0;
			if (_balanceTableAdapter != null)
			{
				count++;
			}
			if (_comptesTableAdapter != null)
			{
				count++;
			}
			if (_dossiersTableAdapter != null)
			{
				count++;
			}
			if (_ecritures00TableAdapter != null)
			{
				count++;
			}
			if (_ecrtriTableAdapter != null)
			{
				count++;
			}
			if (_etatsTableAdapter != null)
			{
				count++;
			}
			if (_immoTableAdapter != null)
			{
				count++;
			}
			if (_journauxTableAdapter != null)
			{
				count++;
			}
			if (_lesEtatsTableAdapter != null)
			{
				count++;
			}
			if (_lesMoisTableAdapter != null)
			{
				count++;
			}
			if (_tiersTableAdapter != null)
			{
				count++;
			}
			if (_villesTableAdapter != null)
			{
				count++;
			}
			if (_ecritures_tTableAdapter != null)
			{
				count++;
			}
			if (_ecrituresTableAdapter != null)
			{
				count++;
			}
			if (_piecesTableAdapter != null)
			{
				count++;
			}
			return count;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int UpdateUpdatedRows(DataSet1 dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
	{
		int result = 0;
		if (_dossiersTableAdapter != null)
		{
			DataRow[] updatedRows = dataSet.Dossiers.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows = GetRealUpdatedRows(updatedRows, allAddedRows);
			if (updatedRows != null && updatedRows.Length != 0)
			{
				result += _dossiersTableAdapter.Update(updatedRows);
				allChangedRows.AddRange(updatedRows);
			}
		}
		if (_journauxTableAdapter != null)
		{
			DataRow[] updatedRows2 = dataSet.Journaux.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows2 = GetRealUpdatedRows(updatedRows2, allAddedRows);
			if (updatedRows2 != null && updatedRows2.Length != 0)
			{
				result += _journauxTableAdapter.Update(updatedRows2);
				allChangedRows.AddRange(updatedRows2);
			}
		}
		if (_comptesTableAdapter != null)
		{
			DataRow[] updatedRows3 = dataSet.Comptes.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows3 = GetRealUpdatedRows(updatedRows3, allAddedRows);
			if (updatedRows3 != null && updatedRows3.Length != 0)
			{
				result += _comptesTableAdapter.Update(updatedRows3);
				allChangedRows.AddRange(updatedRows3);
			}
		}
		if (_tiersTableAdapter != null)
		{
			DataRow[] updatedRows4 = dataSet.Tiers.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows4 = GetRealUpdatedRows(updatedRows4, allAddedRows);
			if (updatedRows4 != null && updatedRows4.Length != 0)
			{
				result += _tiersTableAdapter.Update(updatedRows4);
				allChangedRows.AddRange(updatedRows4);
			}
		}
		if (_piecesTableAdapter != null)
		{
			DataRow[] updatedRows5 = dataSet.Pieces.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows5 = GetRealUpdatedRows(updatedRows5, allAddedRows);
			if (updatedRows5 != null && updatedRows5.Length != 0)
			{
				result += _piecesTableAdapter.Update(updatedRows5);
				allChangedRows.AddRange(updatedRows5);
			}
		}
		if (_balanceTableAdapter != null)
		{
			DataRow[] updatedRows6 = dataSet.Balance.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows6 = GetRealUpdatedRows(updatedRows6, allAddedRows);
			if (updatedRows6 != null && updatedRows6.Length != 0)
			{
				result += _balanceTableAdapter.Update(updatedRows6);
				allChangedRows.AddRange(updatedRows6);
			}
		}
		if (_ecritures00TableAdapter != null)
		{
			DataRow[] updatedRows7 = dataSet.Ecritures00.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows7 = GetRealUpdatedRows(updatedRows7, allAddedRows);
			if (updatedRows7 != null && updatedRows7.Length != 0)
			{
				result += _ecritures00TableAdapter.Update(updatedRows7);
				allChangedRows.AddRange(updatedRows7);
			}
		}
		if (_ecrtriTableAdapter != null)
		{
			DataRow[] updatedRows8 = dataSet.Ecrtri.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows8 = GetRealUpdatedRows(updatedRows8, allAddedRows);
			if (updatedRows8 != null && updatedRows8.Length != 0)
			{
				result += _ecrtriTableAdapter.Update(updatedRows8);
				allChangedRows.AddRange(updatedRows8);
			}
		}
		if (_etatsTableAdapter != null)
		{
			DataRow[] updatedRows9 = dataSet.Etats.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows9 = GetRealUpdatedRows(updatedRows9, allAddedRows);
			if (updatedRows9 != null && updatedRows9.Length != 0)
			{
				result += _etatsTableAdapter.Update(updatedRows9);
				allChangedRows.AddRange(updatedRows9);
			}
		}
		if (_immoTableAdapter != null)
		{
			DataRow[] updatedRows10 = dataSet.Immo.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows10 = GetRealUpdatedRows(updatedRows10, allAddedRows);
			if (updatedRows10 != null && updatedRows10.Length != 0)
			{
				result += _immoTableAdapter.Update(updatedRows10);
				allChangedRows.AddRange(updatedRows10);
			}
		}
		if (_lesEtatsTableAdapter != null)
		{
			DataRow[] updatedRows11 = dataSet.LesEtats.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows11 = GetRealUpdatedRows(updatedRows11, allAddedRows);
			if (updatedRows11 != null && updatedRows11.Length != 0)
			{
				result += _lesEtatsTableAdapter.Update(updatedRows11);
				allChangedRows.AddRange(updatedRows11);
			}
		}
		if (_lesMoisTableAdapter != null)
		{
			DataRow[] updatedRows12 = dataSet.LesMois.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows12 = GetRealUpdatedRows(updatedRows12, allAddedRows);
			if (updatedRows12 != null && updatedRows12.Length != 0)
			{
				result += _lesMoisTableAdapter.Update(updatedRows12);
				allChangedRows.AddRange(updatedRows12);
			}
		}
		if (_villesTableAdapter != null)
		{
			DataRow[] updatedRows13 = dataSet.Villes.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows13 = GetRealUpdatedRows(updatedRows13, allAddedRows);
			if (updatedRows13 != null && updatedRows13.Length != 0)
			{
				result += _villesTableAdapter.Update(updatedRows13);
				allChangedRows.AddRange(updatedRows13);
			}
		}
		if (_ecritures_tTableAdapter != null)
		{
			DataRow[] updatedRows14 = dataSet.Ecritures_t.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows14 = GetRealUpdatedRows(updatedRows14, allAddedRows);
			if (updatedRows14 != null && updatedRows14.Length != 0)
			{
				result += _ecritures_tTableAdapter.Update(updatedRows14);
				allChangedRows.AddRange(updatedRows14);
			}
		}
		if (_ecrituresTableAdapter != null)
		{
			DataRow[] updatedRows15 = dataSet.Ecritures.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows15 = GetRealUpdatedRows(updatedRows15, allAddedRows);
			if (updatedRows15 != null && updatedRows15.Length != 0)
			{
				result += _ecrituresTableAdapter.Update(updatedRows15);
				allChangedRows.AddRange(updatedRows15);
			}
		}
		return result;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int UpdateInsertedRows(DataSet1 dataSet, List<DataRow> allAddedRows)
	{
		int result = 0;
		if (_dossiersTableAdapter != null)
		{
			DataRow[] addedRows = dataSet.Dossiers.Select(null, null, DataViewRowState.Added);
			if (addedRows != null && addedRows.Length != 0)
			{
				result += _dossiersTableAdapter.Update(addedRows);
				allAddedRows.AddRange(addedRows);
			}
		}
		if (_journauxTableAdapter != null)
		{
			DataRow[] addedRows2 = dataSet.Journaux.Select(null, null, DataViewRowState.Added);
			if (addedRows2 != null && addedRows2.Length != 0)
			{
				result += _journauxTableAdapter.Update(addedRows2);
				allAddedRows.AddRange(addedRows2);
			}
		}
		if (_comptesTableAdapter != null)
		{
			DataRow[] addedRows3 = dataSet.Comptes.Select(null, null, DataViewRowState.Added);
			if (addedRows3 != null && addedRows3.Length != 0)
			{
				result += _comptesTableAdapter.Update(addedRows3);
				allAddedRows.AddRange(addedRows3);
			}
		}
		if (_tiersTableAdapter != null)
		{
			DataRow[] addedRows4 = dataSet.Tiers.Select(null, null, DataViewRowState.Added);
			if (addedRows4 != null && addedRows4.Length != 0)
			{
				result += _tiersTableAdapter.Update(addedRows4);
				allAddedRows.AddRange(addedRows4);
			}
		}
		if (_piecesTableAdapter != null)
		{
			DataRow[] addedRows5 = dataSet.Pieces.Select(null, null, DataViewRowState.Added);
			if (addedRows5 != null && addedRows5.Length != 0)
			{
				result += _piecesTableAdapter.Update(addedRows5);
				allAddedRows.AddRange(addedRows5);
			}
		}
		if (_balanceTableAdapter != null)
		{
			DataRow[] addedRows6 = dataSet.Balance.Select(null, null, DataViewRowState.Added);
			if (addedRows6 != null && addedRows6.Length != 0)
			{
				result += _balanceTableAdapter.Update(addedRows6);
				allAddedRows.AddRange(addedRows6);
			}
		}
		if (_ecritures00TableAdapter != null)
		{
			DataRow[] addedRows7 = dataSet.Ecritures00.Select(null, null, DataViewRowState.Added);
			if (addedRows7 != null && addedRows7.Length != 0)
			{
				result += _ecritures00TableAdapter.Update(addedRows7);
				allAddedRows.AddRange(addedRows7);
			}
		}
		if (_ecrtriTableAdapter != null)
		{
			DataRow[] addedRows8 = dataSet.Ecrtri.Select(null, null, DataViewRowState.Added);
			if (addedRows8 != null && addedRows8.Length != 0)
			{
				result += _ecrtriTableAdapter.Update(addedRows8);
				allAddedRows.AddRange(addedRows8);
			}
		}
		if (_etatsTableAdapter != null)
		{
			DataRow[] addedRows9 = dataSet.Etats.Select(null, null, DataViewRowState.Added);
			if (addedRows9 != null && addedRows9.Length != 0)
			{
				result += _etatsTableAdapter.Update(addedRows9);
				allAddedRows.AddRange(addedRows9);
			}
		}
		if (_immoTableAdapter != null)
		{
			DataRow[] addedRows10 = dataSet.Immo.Select(null, null, DataViewRowState.Added);
			if (addedRows10 != null && addedRows10.Length != 0)
			{
				result += _immoTableAdapter.Update(addedRows10);
				allAddedRows.AddRange(addedRows10);
			}
		}
		if (_lesEtatsTableAdapter != null)
		{
			DataRow[] addedRows11 = dataSet.LesEtats.Select(null, null, DataViewRowState.Added);
			if (addedRows11 != null && addedRows11.Length != 0)
			{
				result += _lesEtatsTableAdapter.Update(addedRows11);
				allAddedRows.AddRange(addedRows11);
			}
		}
		if (_lesMoisTableAdapter != null)
		{
			DataRow[] addedRows12 = dataSet.LesMois.Select(null, null, DataViewRowState.Added);
			if (addedRows12 != null && addedRows12.Length != 0)
			{
				result += _lesMoisTableAdapter.Update(addedRows12);
				allAddedRows.AddRange(addedRows12);
			}
		}
		if (_villesTableAdapter != null)
		{
			DataRow[] addedRows13 = dataSet.Villes.Select(null, null, DataViewRowState.Added);
			if (addedRows13 != null && addedRows13.Length != 0)
			{
				result += _villesTableAdapter.Update(addedRows13);
				allAddedRows.AddRange(addedRows13);
			}
		}
		if (_ecritures_tTableAdapter != null)
		{
			DataRow[] addedRows14 = dataSet.Ecritures_t.Select(null, null, DataViewRowState.Added);
			if (addedRows14 != null && addedRows14.Length != 0)
			{
				result += _ecritures_tTableAdapter.Update(addedRows14);
				allAddedRows.AddRange(addedRows14);
			}
		}
		if (_ecrituresTableAdapter != null)
		{
			DataRow[] addedRows15 = dataSet.Ecritures.Select(null, null, DataViewRowState.Added);
			if (addedRows15 != null && addedRows15.Length != 0)
			{
				result += _ecrituresTableAdapter.Update(addedRows15);
				allAddedRows.AddRange(addedRows15);
			}
		}
		return result;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int UpdateDeletedRows(DataSet1 dataSet, List<DataRow> allChangedRows)
	{
		int result = 0;
		if (_ecrituresTableAdapter != null)
		{
			DataRow[] deletedRows = dataSet.Ecritures.Select(null, null, DataViewRowState.Deleted);
			if (deletedRows != null && deletedRows.Length != 0)
			{
				result += _ecrituresTableAdapter.Update(deletedRows);
				allChangedRows.AddRange(deletedRows);
			}
		}
		if (_ecritures_tTableAdapter != null)
		{
			DataRow[] deletedRows2 = dataSet.Ecritures_t.Select(null, null, DataViewRowState.Deleted);
			if (deletedRows2 != null && deletedRows2.Length != 0)
			{
				result += _ecritures_tTableAdapter.Update(deletedRows2);
				allChangedRows.AddRange(deletedRows2);
			}
		}
		if (_villesTableAdapter != null)
		{
			DataRow[] deletedRows3 = dataSet.Villes.Select(null, null, DataViewRowState.Deleted);
			if (deletedRows3 != null && deletedRows3.Length != 0)
			{
				result += _villesTableAdapter.Update(deletedRows3);
				allChangedRows.AddRange(deletedRows3);
			}
		}
		if (_lesMoisTableAdapter != null)
		{
			DataRow[] deletedRows4 = dataSet.LesMois.Select(null, null, DataViewRowState.Deleted);
			if (deletedRows4 != null && deletedRows4.Length != 0)
			{
				result += _lesMoisTableAdapter.Update(deletedRows4);
				allChangedRows.AddRange(deletedRows4);
			}
		}
		if (_lesEtatsTableAdapter != null)
		{
			DataRow[] deletedRows5 = dataSet.LesEtats.Select(null, null, DataViewRowState.Deleted);
			if (deletedRows5 != null && deletedRows5.Length != 0)
			{
				result += _lesEtatsTableAdapter.Update(deletedRows5);
				allChangedRows.AddRange(deletedRows5);
			}
		}
		if (_immoTableAdapter != null)
		{
			DataRow[] deletedRows6 = dataSet.Immo.Select(null, null, DataViewRowState.Deleted);
			if (deletedRows6 != null && deletedRows6.Length != 0)
			{
				result += _immoTableAdapter.Update(deletedRows6);
				allChangedRows.AddRange(deletedRows6);
			}
		}
		if (_etatsTableAdapter != null)
		{
			DataRow[] deletedRows7 = dataSet.Etats.Select(null, null, DataViewRowState.Deleted);
			if (deletedRows7 != null && deletedRows7.Length != 0)
			{
				result += _etatsTableAdapter.Update(deletedRows7);
				allChangedRows.AddRange(deletedRows7);
			}
		}
		if (_ecrtriTableAdapter != null)
		{
			DataRow[] deletedRows8 = dataSet.Ecrtri.Select(null, null, DataViewRowState.Deleted);
			if (deletedRows8 != null && deletedRows8.Length != 0)
			{
				result += _ecrtriTableAdapter.Update(deletedRows8);
				allChangedRows.AddRange(deletedRows8);
			}
		}
		if (_ecritures00TableAdapter != null)
		{
			DataRow[] deletedRows9 = dataSet.Ecritures00.Select(null, null, DataViewRowState.Deleted);
			if (deletedRows9 != null && deletedRows9.Length != 0)
			{
				result += _ecritures00TableAdapter.Update(deletedRows9);
				allChangedRows.AddRange(deletedRows9);
			}
		}
		if (_balanceTableAdapter != null)
		{
			DataRow[] deletedRows10 = dataSet.Balance.Select(null, null, DataViewRowState.Deleted);
			if (deletedRows10 != null && deletedRows10.Length != 0)
			{
				result += _balanceTableAdapter.Update(deletedRows10);
				allChangedRows.AddRange(deletedRows10);
			}
		}
		if (_piecesTableAdapter != null)
		{
			DataRow[] deletedRows11 = dataSet.Pieces.Select(null, null, DataViewRowState.Deleted);
			if (deletedRows11 != null && deletedRows11.Length != 0)
			{
				result += _piecesTableAdapter.Update(deletedRows11);
				allChangedRows.AddRange(deletedRows11);
			}
		}
		if (_tiersTableAdapter != null)
		{
			DataRow[] deletedRows12 = dataSet.Tiers.Select(null, null, DataViewRowState.Deleted);
			if (deletedRows12 != null && deletedRows12.Length != 0)
			{
				result += _tiersTableAdapter.Update(deletedRows12);
				allChangedRows.AddRange(deletedRows12);
			}
		}
		if (_comptesTableAdapter != null)
		{
			DataRow[] deletedRows13 = dataSet.Comptes.Select(null, null, DataViewRowState.Deleted);
			if (deletedRows13 != null && deletedRows13.Length != 0)
			{
				result += _comptesTableAdapter.Update(deletedRows13);
				allChangedRows.AddRange(deletedRows13);
			}
		}
		if (_journauxTableAdapter != null)
		{
			DataRow[] deletedRows14 = dataSet.Journaux.Select(null, null, DataViewRowState.Deleted);
			if (deletedRows14 != null && deletedRows14.Length != 0)
			{
				result += _journauxTableAdapter.Update(deletedRows14);
				allChangedRows.AddRange(deletedRows14);
			}
		}
		if (_dossiersTableAdapter != null)
		{
			DataRow[] deletedRows15 = dataSet.Dossiers.Select(null, null, DataViewRowState.Deleted);
			if (deletedRows15 != null && deletedRows15.Length != 0)
			{
				result += _dossiersTableAdapter.Update(deletedRows15);
				allChangedRows.AddRange(deletedRows15);
			}
		}
		return result;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
	{
		if (updatedRows == null || updatedRows.Length < 1)
		{
			return updatedRows;
		}
		if (allAddedRows == null || allAddedRows.Count < 1)
		{
			return updatedRows;
		}
		List<DataRow> realUpdatedRows = new List<DataRow>();
		foreach (DataRow row in updatedRows)
		{
			if (!allAddedRows.Contains(row))
			{
				realUpdatedRows.Add(row);
			}
		}
		return realUpdatedRows.ToArray();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int UpdateAll(DataSet1 dataSet)
	{
		if (dataSet == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!dataSet.HasChanges())
		{
			return 0;
		}
		if (_balanceTableAdapter != null && !MatchTableAdapterConnection(_balanceTableAdapter.Connection))
		{
			throw new ArgumentException("Tous les TableAdapters managés par un TableAdapterManager doivent utiliser la même chaîne de connexion.");
		}
		if (_comptesTableAdapter != null && !MatchTableAdapterConnection(_comptesTableAdapter.Connection))
		{
			throw new ArgumentException("Tous les TableAdapters managés par un TableAdapterManager doivent utiliser la même chaîne de connexion.");
		}
		if (_dossiersTableAdapter != null && !MatchTableAdapterConnection(_dossiersTableAdapter.Connection))
		{
			throw new ArgumentException("Tous les TableAdapters managés par un TableAdapterManager doivent utiliser la même chaîne de connexion.");
		}
		if (_ecritures00TableAdapter != null && !MatchTableAdapterConnection(_ecritures00TableAdapter.Connection))
		{
			throw new ArgumentException("Tous les TableAdapters managés par un TableAdapterManager doivent utiliser la même chaîne de connexion.");
		}
		if (_ecrtriTableAdapter != null && !MatchTableAdapterConnection(_ecrtriTableAdapter.Connection))
		{
			throw new ArgumentException("Tous les TableAdapters managés par un TableAdapterManager doivent utiliser la même chaîne de connexion.");
		}
		if (_etatsTableAdapter != null && !MatchTableAdapterConnection(_etatsTableAdapter.Connection))
		{
			throw new ArgumentException("Tous les TableAdapters managés par un TableAdapterManager doivent utiliser la même chaîne de connexion.");
		}
		if (_immoTableAdapter != null && !MatchTableAdapterConnection(_immoTableAdapter.Connection))
		{
			throw new ArgumentException("Tous les TableAdapters managés par un TableAdapterManager doivent utiliser la même chaîne de connexion.");
		}
		if (_journauxTableAdapter != null && !MatchTableAdapterConnection(_journauxTableAdapter.Connection))
		{
			throw new ArgumentException("Tous les TableAdapters managés par un TableAdapterManager doivent utiliser la même chaîne de connexion.");
		}
		if (_lesEtatsTableAdapter != null && !MatchTableAdapterConnection(_lesEtatsTableAdapter.Connection))
		{
			throw new ArgumentException("Tous les TableAdapters managés par un TableAdapterManager doivent utiliser la même chaîne de connexion.");
		}
		if (_lesMoisTableAdapter != null && !MatchTableAdapterConnection(_lesMoisTableAdapter.Connection))
		{
			throw new ArgumentException("Tous les TableAdapters managés par un TableAdapterManager doivent utiliser la même chaîne de connexion.");
		}
		if (_tiersTableAdapter != null && !MatchTableAdapterConnection(_tiersTableAdapter.Connection))
		{
			throw new ArgumentException("Tous les TableAdapters managés par un TableAdapterManager doivent utiliser la même chaîne de connexion.");
		}
		if (_villesTableAdapter != null && !MatchTableAdapterConnection(_villesTableAdapter.Connection))
		{
			throw new ArgumentException("Tous les TableAdapters managés par un TableAdapterManager doivent utiliser la même chaîne de connexion.");
		}
		if (_ecritures_tTableAdapter != null && !MatchTableAdapterConnection(_ecritures_tTableAdapter.Connection))
		{
			throw new ArgumentException("Tous les TableAdapters managés par un TableAdapterManager doivent utiliser la même chaîne de connexion.");
		}
		if (_ecrituresTableAdapter != null && !MatchTableAdapterConnection(_ecrituresTableAdapter.Connection))
		{
			throw new ArgumentException("Tous les TableAdapters managés par un TableAdapterManager doivent utiliser la même chaîne de connexion.");
		}
		if (_piecesTableAdapter != null && !MatchTableAdapterConnection(_piecesTableAdapter.Connection))
		{
			throw new ArgumentException("Tous les TableAdapters managés par un TableAdapterManager doivent utiliser la même chaîne de connexion.");
		}
		IDbConnection workConnection = Connection;
		if (workConnection == null)
		{
			throw new ApplicationException("TableAdapterManager ne contient pas d'informations de connexion. Définissez chaque propriété TableAdapterManager TableAdapter à une instance valide de TableAdapter.");
		}
		bool workConnOpened = false;
		if ((workConnection.State & ConnectionState.Broken) == ConnectionState.Broken)
		{
			workConnection.Close();
		}
		if (workConnection.State == ConnectionState.Closed)
		{
			workConnection.Open();
			workConnOpened = true;
		}
		IDbTransaction workTransaction = workConnection.BeginTransaction();
		if (workTransaction == null)
		{
			throw new ApplicationException("La transaction ne peut pas commencer. La connexion de données actuelle ne prend pas en charge les transactions ou l'état actuel n'autorise pas le début de la transaction.");
		}
		List<DataRow> allChangedRows = new List<DataRow>();
		List<DataRow> allAddedRows = new List<DataRow>();
		List<DataAdapter> adaptersWithAcceptChangesDuringUpdate = new List<DataAdapter>();
		Dictionary<object, IDbConnection> revertConnections = new Dictionary<object, IDbConnection>();
		int result = 0;
		DataSet backupDataSet = null;
		if (BackupDataSetBeforeUpdate)
		{
			backupDataSet = new DataSet();
			backupDataSet.Merge(dataSet);
		}
		try
		{
			if (_balanceTableAdapter != null)
			{
				revertConnections.Add(_balanceTableAdapter, _balanceTableAdapter.Connection);
				_balanceTableAdapter.Connection = (OleDbConnection)workConnection;
				_balanceTableAdapter.Transaction = (OleDbTransaction)workTransaction;
				if (_balanceTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_balanceTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					adaptersWithAcceptChangesDuringUpdate.Add(_balanceTableAdapter.Adapter);
				}
			}
			if (_comptesTableAdapter != null)
			{
				revertConnections.Add(_comptesTableAdapter, _comptesTableAdapter.Connection);
				_comptesTableAdapter.Connection = (OleDbConnection)workConnection;
				_comptesTableAdapter.Transaction = (OleDbTransaction)workTransaction;
				if (_comptesTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_comptesTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					adaptersWithAcceptChangesDuringUpdate.Add(_comptesTableAdapter.Adapter);
				}
			}
			if (_dossiersTableAdapter != null)
			{
				revertConnections.Add(_dossiersTableAdapter, _dossiersTableAdapter.Connection);
				_dossiersTableAdapter.Connection = (OleDbConnection)workConnection;
				_dossiersTableAdapter.Transaction = (OleDbTransaction)workTransaction;
				if (_dossiersTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_dossiersTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					adaptersWithAcceptChangesDuringUpdate.Add(_dossiersTableAdapter.Adapter);
				}
			}
			if (_ecritures00TableAdapter != null)
			{
				revertConnections.Add(_ecritures00TableAdapter, _ecritures00TableAdapter.Connection);
				_ecritures00TableAdapter.Connection = (OleDbConnection)workConnection;
				_ecritures00TableAdapter.Transaction = (OleDbTransaction)workTransaction;
				if (_ecritures00TableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_ecritures00TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					adaptersWithAcceptChangesDuringUpdate.Add(_ecritures00TableAdapter.Adapter);
				}
			}
			if (_ecrtriTableAdapter != null)
			{
				revertConnections.Add(_ecrtriTableAdapter, _ecrtriTableAdapter.Connection);
				_ecrtriTableAdapter.Connection = (OleDbConnection)workConnection;
				_ecrtriTableAdapter.Transaction = (OleDbTransaction)workTransaction;
				if (_ecrtriTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_ecrtriTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					adaptersWithAcceptChangesDuringUpdate.Add(_ecrtriTableAdapter.Adapter);
				}
			}
			if (_etatsTableAdapter != null)
			{
				revertConnections.Add(_etatsTableAdapter, _etatsTableAdapter.Connection);
				_etatsTableAdapter.Connection = (OleDbConnection)workConnection;
				_etatsTableAdapter.Transaction = (OleDbTransaction)workTransaction;
				if (_etatsTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_etatsTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					adaptersWithAcceptChangesDuringUpdate.Add(_etatsTableAdapter.Adapter);
				}
			}
			if (_immoTableAdapter != null)
			{
				revertConnections.Add(_immoTableAdapter, _immoTableAdapter.Connection);
				_immoTableAdapter.Connection = (OleDbConnection)workConnection;
				_immoTableAdapter.Transaction = (OleDbTransaction)workTransaction;
				if (_immoTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_immoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					adaptersWithAcceptChangesDuringUpdate.Add(_immoTableAdapter.Adapter);
				}
			}
			if (_journauxTableAdapter != null)
			{
				revertConnections.Add(_journauxTableAdapter, _journauxTableAdapter.Connection);
				_journauxTableAdapter.Connection = (OleDbConnection)workConnection;
				_journauxTableAdapter.Transaction = (OleDbTransaction)workTransaction;
				if (_journauxTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_journauxTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					adaptersWithAcceptChangesDuringUpdate.Add(_journauxTableAdapter.Adapter);
				}
			}
			if (_lesEtatsTableAdapter != null)
			{
				revertConnections.Add(_lesEtatsTableAdapter, _lesEtatsTableAdapter.Connection);
				_lesEtatsTableAdapter.Connection = (OleDbConnection)workConnection;
				_lesEtatsTableAdapter.Transaction = (OleDbTransaction)workTransaction;
				if (_lesEtatsTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_lesEtatsTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					adaptersWithAcceptChangesDuringUpdate.Add(_lesEtatsTableAdapter.Adapter);
				}
			}
			if (_lesMoisTableAdapter != null)
			{
				revertConnections.Add(_lesMoisTableAdapter, _lesMoisTableAdapter.Connection);
				_lesMoisTableAdapter.Connection = (OleDbConnection)workConnection;
				_lesMoisTableAdapter.Transaction = (OleDbTransaction)workTransaction;
				if (_lesMoisTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_lesMoisTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					adaptersWithAcceptChangesDuringUpdate.Add(_lesMoisTableAdapter.Adapter);
				}
			}
			if (_tiersTableAdapter != null)
			{
				revertConnections.Add(_tiersTableAdapter, _tiersTableAdapter.Connection);
				_tiersTableAdapter.Connection = (OleDbConnection)workConnection;
				_tiersTableAdapter.Transaction = (OleDbTransaction)workTransaction;
				if (_tiersTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_tiersTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					adaptersWithAcceptChangesDuringUpdate.Add(_tiersTableAdapter.Adapter);
				}
			}
			if (_villesTableAdapter != null)
			{
				revertConnections.Add(_villesTableAdapter, _villesTableAdapter.Connection);
				_villesTableAdapter.Connection = (OleDbConnection)workConnection;
				_villesTableAdapter.Transaction = (OleDbTransaction)workTransaction;
				if (_villesTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_villesTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					adaptersWithAcceptChangesDuringUpdate.Add(_villesTableAdapter.Adapter);
				}
			}
			if (_ecritures_tTableAdapter != null)
			{
				revertConnections.Add(_ecritures_tTableAdapter, _ecritures_tTableAdapter.Connection);
				_ecritures_tTableAdapter.Connection = (OleDbConnection)workConnection;
				_ecritures_tTableAdapter.Transaction = (OleDbTransaction)workTransaction;
				if (_ecritures_tTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_ecritures_tTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					adaptersWithAcceptChangesDuringUpdate.Add(_ecritures_tTableAdapter.Adapter);
				}
			}
			if (_ecrituresTableAdapter != null)
			{
				revertConnections.Add(_ecrituresTableAdapter, _ecrituresTableAdapter.Connection);
				_ecrituresTableAdapter.Connection = (OleDbConnection)workConnection;
				_ecrituresTableAdapter.Transaction = (OleDbTransaction)workTransaction;
				if (_ecrituresTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_ecrituresTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					adaptersWithAcceptChangesDuringUpdate.Add(_ecrituresTableAdapter.Adapter);
				}
			}
			if (_piecesTableAdapter != null)
			{
				revertConnections.Add(_piecesTableAdapter, _piecesTableAdapter.Connection);
				_piecesTableAdapter.Connection = (OleDbConnection)workConnection;
				_piecesTableAdapter.Transaction = (OleDbTransaction)workTransaction;
				if (_piecesTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_piecesTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					adaptersWithAcceptChangesDuringUpdate.Add(_piecesTableAdapter.Adapter);
				}
			}
			if (UpdateOrder == UpdateOrderOption.UpdateInsertDelete)
			{
				result += UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
				result += UpdateInsertedRows(dataSet, allAddedRows);
			}
			else
			{
				result += UpdateInsertedRows(dataSet, allAddedRows);
				result += UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
			}
			result += UpdateDeletedRows(dataSet, allChangedRows);
			workTransaction.Commit();
			if (0 < allAddedRows.Count)
			{
				DataRow[] rows = new DataRow[allAddedRows.Count];
				allAddedRows.CopyTo(rows);
				for (int i = 0; i < rows.Length; i++)
				{
					rows[i].AcceptChanges();
				}
			}
			if (0 < allChangedRows.Count)
			{
				DataRow[] rows2 = new DataRow[allChangedRows.Count];
				allChangedRows.CopyTo(rows2);
				for (int j = 0; j < rows2.Length; j++)
				{
					rows2[j].AcceptChanges();
				}
			}
		}
		catch (Exception ex)
		{
			workTransaction.Rollback();
			if (BackupDataSetBeforeUpdate)
			{
				dataSet.Clear();
				dataSet.Merge(backupDataSet);
			}
			else if (0 < allAddedRows.Count)
			{
				DataRow[] rows3 = new DataRow[allAddedRows.Count];
				allAddedRows.CopyTo(rows3);
				foreach (DataRow obj in rows3)
				{
					obj.AcceptChanges();
					obj.SetAdded();
				}
			}
			throw ex;
		}
		finally
		{
			if (workConnOpened)
			{
				workConnection.Close();
			}
			if (_balanceTableAdapter != null)
			{
				_balanceTableAdapter.Connection = (OleDbConnection)revertConnections[_balanceTableAdapter];
				_balanceTableAdapter.Transaction = null;
			}
			if (_comptesTableAdapter != null)
			{
				_comptesTableAdapter.Connection = (OleDbConnection)revertConnections[_comptesTableAdapter];
				_comptesTableAdapter.Transaction = null;
			}
			if (_dossiersTableAdapter != null)
			{
				_dossiersTableAdapter.Connection = (OleDbConnection)revertConnections[_dossiersTableAdapter];
				_dossiersTableAdapter.Transaction = null;
			}
			if (_ecritures00TableAdapter != null)
			{
				_ecritures00TableAdapter.Connection = (OleDbConnection)revertConnections[_ecritures00TableAdapter];
				_ecritures00TableAdapter.Transaction = null;
			}
			if (_ecrtriTableAdapter != null)
			{
				_ecrtriTableAdapter.Connection = (OleDbConnection)revertConnections[_ecrtriTableAdapter];
				_ecrtriTableAdapter.Transaction = null;
			}
			if (_etatsTableAdapter != null)
			{
				_etatsTableAdapter.Connection = (OleDbConnection)revertConnections[_etatsTableAdapter];
				_etatsTableAdapter.Transaction = null;
			}
			if (_immoTableAdapter != null)
			{
				_immoTableAdapter.Connection = (OleDbConnection)revertConnections[_immoTableAdapter];
				_immoTableAdapter.Transaction = null;
			}
			if (_journauxTableAdapter != null)
			{
				_journauxTableAdapter.Connection = (OleDbConnection)revertConnections[_journauxTableAdapter];
				_journauxTableAdapter.Transaction = null;
			}
			if (_lesEtatsTableAdapter != null)
			{
				_lesEtatsTableAdapter.Connection = (OleDbConnection)revertConnections[_lesEtatsTableAdapter];
				_lesEtatsTableAdapter.Transaction = null;
			}
			if (_lesMoisTableAdapter != null)
			{
				_lesMoisTableAdapter.Connection = (OleDbConnection)revertConnections[_lesMoisTableAdapter];
				_lesMoisTableAdapter.Transaction = null;
			}
			if (_tiersTableAdapter != null)
			{
				_tiersTableAdapter.Connection = (OleDbConnection)revertConnections[_tiersTableAdapter];
				_tiersTableAdapter.Transaction = null;
			}
			if (_villesTableAdapter != null)
			{
				_villesTableAdapter.Connection = (OleDbConnection)revertConnections[_villesTableAdapter];
				_villesTableAdapter.Transaction = null;
			}
			if (_ecritures_tTableAdapter != null)
			{
				_ecritures_tTableAdapter.Connection = (OleDbConnection)revertConnections[_ecritures_tTableAdapter];
				_ecritures_tTableAdapter.Transaction = null;
			}
			if (_ecrituresTableAdapter != null)
			{
				_ecrituresTableAdapter.Connection = (OleDbConnection)revertConnections[_ecrituresTableAdapter];
				_ecrituresTableAdapter.Transaction = null;
			}
			if (_piecesTableAdapter != null)
			{
				_piecesTableAdapter.Connection = (OleDbConnection)revertConnections[_piecesTableAdapter];
				_piecesTableAdapter.Transaction = null;
			}
			if (0 < adaptersWithAcceptChangesDuringUpdate.Count)
			{
				DataAdapter[] adapters = new DataAdapter[adaptersWithAcceptChangesDuringUpdate.Count];
				adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters);
				for (int l = 0; l < adapters.Length; l++)
				{
					adapters[l].AcceptChangesDuringUpdate = true;
				}
			}
		}
		return result;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
	{
		Array.Sort(rows, new SelfReferenceComparer(relation, childFirst));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
	{
		if (_connection != null)
		{
			return true;
		}
		if (Connection == null || inputConnection == null)
		{
			return true;
		}
		if (string.Equals(Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}
}
