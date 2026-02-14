using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace compta;

[Serializable]
[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("DataSet1")]
[HelpKeyword("vs.data.DataSet")]
public class DataSet1 : DataSet
{
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class EcrituresDataTable : TypedTableBase<EcrituresRow>
	{
		private DataColumn columnUNI;

		private DataColumn columnExercice;

		private DataColumn columnJA;

		private DataColumn columnNOP;

		private DataColumn columnLIG;

		private DataColumn columnCPT;

		private DataColumn columnTRS;

		private DataColumn columnDAT;

		private DataColumn columnLIB;

		private DataColumn columnDEB;

		private DataColumn columnCRE;

		private DataColumn columnPTG;

		private DataColumn columnPTGX;

		private DataColumn columnRAP;

		private DataColumn columnID;

		private DataColumn columnJour;

		private DataColumn columnUserC;

		private DataColumn columnDateC;

		private DataColumn columnUserM;

		private DataColumn columnDateM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UNIColumn => columnUNI;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ExerciceColumn => columnExercice;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn JAColumn => columnJA;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NOPColumn => columnNOP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIGColumn => columnLIG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPTColumn => columnCPT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn TRSColumn => columnTRS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DATColumn => columnDAT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBColumn => columnLIB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DEBColumn => columnDEB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CREColumn => columnCRE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PTGColumn => columnPTG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PTGXColumn => columnPTGX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn RAPColumn => columnRAP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn IDColumn => columnID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn JourColumn => columnJour;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserCColumn => columnUserC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateCColumn => columnDateC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserMColumn => columnUserM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateMColumn => columnDateM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EcrituresRow this[int index] => (EcrituresRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event EcrituresRowChangeEventHandler EcrituresRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event EcrituresRowChangeEventHandler EcrituresRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event EcrituresRowChangeEventHandler EcrituresRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event EcrituresRowChangeEventHandler EcrituresRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EcrituresDataTable()
		{
			base.TableName = "Ecritures";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal EcrituresDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected EcrituresDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void AddEcrituresRow(EcrituresRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EcrituresRow AddEcrituresRow(string UNI, int Exercice, string JA, int NOP, int LIG, ComptesRow parentComptesRowByComptesEcritures, string TRS, DateTime DAT, string LIB, decimal DEB, decimal CRE, string PTG, string PTGX, string RAP, byte Jour, string UserC, DateTime DateC, string UserM, DateTime DateM)
		{
			EcrituresRow rowEcrituresRow = (EcrituresRow)NewRow();
			object[] columnValuesArray = new object[20]
			{
				UNI, Exercice, JA, NOP, LIG, null, TRS, DAT, LIB, DEB,
				CRE, PTG, PTGX, RAP, null, Jour, UserC, DateC, UserM, DateM
			};
			if (parentComptesRowByComptesEcritures != null)
			{
				columnValuesArray[5] = parentComptesRowByComptesEcritures[0];
			}
			rowEcrituresRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowEcrituresRow);
			return rowEcrituresRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Clone()
		{
			EcrituresDataTable obj = (EcrituresDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new EcrituresDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			columnUNI = base.Columns["UNI"];
			columnExercice = base.Columns["Exercice"];
			columnJA = base.Columns["JA"];
			columnNOP = base.Columns["NOP"];
			columnLIG = base.Columns["LIG"];
			columnCPT = base.Columns["CPT"];
			columnTRS = base.Columns["TRS"];
			columnDAT = base.Columns["DAT"];
			columnLIB = base.Columns["LIB"];
			columnDEB = base.Columns["DEB"];
			columnCRE = base.Columns["CRE"];
			columnPTG = base.Columns["PTG"];
			columnPTGX = base.Columns["PTGX"];
			columnRAP = base.Columns["RAP"];
			columnID = base.Columns["ID"];
			columnJour = base.Columns["Jour"];
			columnUserC = base.Columns["UserC"];
			columnDateC = base.Columns["DateC"];
			columnUserM = base.Columns["UserM"];
			columnDateM = base.Columns["DateM"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			columnUNI = new DataColumn("UNI", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUNI);
			columnExercice = new DataColumn("Exercice", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnExercice);
			columnJA = new DataColumn("JA", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnJA);
			columnNOP = new DataColumn("NOP", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnNOP);
			columnLIG = new DataColumn("LIG", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnLIG);
			columnCPT = new DataColumn("CPT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCPT);
			columnTRS = new DataColumn("TRS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTRS);
			columnDAT = new DataColumn("DAT", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDAT);
			columnLIB = new DataColumn("LIB", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIB);
			columnDEB = new DataColumn("DEB", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnDEB);
			columnCRE = new DataColumn("CRE", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnCRE);
			columnPTG = new DataColumn("PTG", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPTG);
			columnPTGX = new DataColumn("PTGX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPTGX);
			columnRAP = new DataColumn("RAP", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnRAP);
			columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnID);
			columnJour = new DataColumn("Jour", typeof(byte), null, MappingType.Element);
			base.Columns.Add(columnJour);
			columnUserC = new DataColumn("UserC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserC);
			columnDateC = new DataColumn("DateC", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateC);
			columnUserM = new DataColumn("UserM", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserM);
			columnDateM = new DataColumn("DateM", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateM);
			columnUNI.MaxLength = 3;
			columnJA.MaxLength = 2;
			columnCPT.MaxLength = 6;
			columnTRS.MaxLength = 6;
			columnLIB.MaxLength = 30;
			columnPTG.MaxLength = 1;
			columnPTGX.MaxLength = 1;
			columnRAP.MaxLength = 1;
			columnID.AutoIncrement = true;
			columnID.AutoIncrementSeed = -1L;
			columnID.AutoIncrementStep = -1L;
			columnUserC.MaxLength = 6;
			columnUserM.MaxLength = 6;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EcrituresRow NewEcrituresRow()
		{
			return (EcrituresRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new EcrituresRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(EcrituresRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.EcrituresRowChanged != null)
			{
				this.EcrituresRowChanged(this, new EcrituresRowChangeEvent((EcrituresRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.EcrituresRowChanging != null)
			{
				this.EcrituresRowChanging(this, new EcrituresRowChangeEvent((EcrituresRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.EcrituresRowDeleted != null)
			{
				this.EcrituresRowDeleted(this, new EcrituresRowChangeEvent((EcrituresRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.EcrituresRowDeleting != null)
			{
				this.EcrituresRowDeleting(this, new EcrituresRowChangeEvent((EcrituresRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void RemoveEcrituresRow(EcrituresRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			DataSet1 ds = new DataSet1();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = 0m;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = 1m;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "EcrituresDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						XmlSchema obj = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						obj.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void BalanceRowChangeEventHandler(object sender, BalanceRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void ComptesRowChangeEventHandler(object sender, ComptesRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void DossiersRowChangeEventHandler(object sender, DossiersRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void Ecritures00RowChangeEventHandler(object sender, Ecritures00RowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void EcrtriRowChangeEventHandler(object sender, EcrtriRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void EtatsRowChangeEventHandler(object sender, EtatsRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void ImmoRowChangeEventHandler(object sender, ImmoRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void JournauxRowChangeEventHandler(object sender, JournauxRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void LesEtatsRowChangeEventHandler(object sender, LesEtatsRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void LesMoisRowChangeEventHandler(object sender, LesMoisRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void TiersRowChangeEventHandler(object sender, TiersRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void VillesRowChangeEventHandler(object sender, VillesRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void Ecritures_tRowChangeEventHandler(object sender, Ecritures_tRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void EcrituresRowChangeEventHandler(object sender, EcrituresRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void PiecesRowChangeEventHandler(object sender, PiecesRowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class BalanceDataTable : TypedTableBase<BalanceRow>
	{
		private DataColumn columnUNI;

		private DataColumn columnExercice;

		private DataColumn columnCPT;

		private DataColumn columnDEB;

		private DataColumn columnCRE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UNIColumn => columnUNI;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ExerciceColumn => columnExercice;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPTColumn => columnCPT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DEBColumn => columnDEB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CREColumn => columnCRE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public BalanceRow this[int index] => (BalanceRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event BalanceRowChangeEventHandler BalanceRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event BalanceRowChangeEventHandler BalanceRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event BalanceRowChangeEventHandler BalanceRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event BalanceRowChangeEventHandler BalanceRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public BalanceDataTable()
		{
			base.TableName = "Balance";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal BalanceDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected BalanceDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void AddBalanceRow(BalanceRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public BalanceRow AddBalanceRow(string UNI, int Exercice, string CPT, decimal DEB, decimal CRE)
		{
			BalanceRow rowBalanceRow = (BalanceRow)NewRow();
			object[] columnValuesArray = new object[5] { UNI, Exercice, CPT, DEB, CRE };
			rowBalanceRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowBalanceRow);
			return rowBalanceRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Clone()
		{
			BalanceDataTable obj = (BalanceDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new BalanceDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			columnUNI = base.Columns["UNI"];
			columnExercice = base.Columns["Exercice"];
			columnCPT = base.Columns["CPT"];
			columnDEB = base.Columns["DEB"];
			columnCRE = base.Columns["CRE"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			columnUNI = new DataColumn("UNI", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUNI);
			columnExercice = new DataColumn("Exercice", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnExercice);
			columnCPT = new DataColumn("CPT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCPT);
			columnDEB = new DataColumn("DEB", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnDEB);
			columnCRE = new DataColumn("CRE", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnCRE);
			columnUNI.MaxLength = 3;
			columnCPT.MaxLength = 6;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public BalanceRow NewBalanceRow()
		{
			return (BalanceRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new BalanceRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(BalanceRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.BalanceRowChanged != null)
			{
				this.BalanceRowChanged(this, new BalanceRowChangeEvent((BalanceRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.BalanceRowChanging != null)
			{
				this.BalanceRowChanging(this, new BalanceRowChangeEvent((BalanceRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.BalanceRowDeleted != null)
			{
				this.BalanceRowDeleted(this, new BalanceRowChangeEvent((BalanceRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.BalanceRowDeleting != null)
			{
				this.BalanceRowDeleting(this, new BalanceRowChangeEvent((BalanceRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void RemoveBalanceRow(BalanceRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			DataSet1 ds = new DataSet1();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = 0m;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = 1m;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "BalanceDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						XmlSchema obj = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						obj.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class ComptesDataTable : TypedTableBase<ComptesRow>
	{
		private DataColumn columnCPT;

		private DataColumn columnLIB;

		private DataColumn columnIMPUT;

		private DataColumn columnTRS;

		private DataColumn columnANA;

		private DataColumn columnIMMO;

		private DataColumn columnCML;

		private DataColumn columnSNS;

		private DataColumn columnRAP;

		private DataColumn columnTAG;

		private DataColumn columnID;

		private DataColumn columnUserC;

		private DataColumn columnDateC;

		private DataColumn columnUserM;

		private DataColumn columnDateM;

		private DataColumn columnAMOR;

		private DataColumn columnDOT;

		private DataColumn columnPROD;

		private DataColumn columnLIBAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPTColumn => columnCPT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBColumn => columnLIB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn IMPUTColumn => columnIMPUT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn TRSColumn => columnTRS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ANAColumn => columnANA;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn IMMOColumn => columnIMMO;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CMLColumn => columnCML;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn SNSColumn => columnSNS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn RAPColumn => columnRAP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn TAGColumn => columnTAG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn IDColumn => columnID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserCColumn => columnUserC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateCColumn => columnDateC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserMColumn => columnUserM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateMColumn => columnDateM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn AMORColumn => columnAMOR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DOTColumn => columnDOT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PRODColumn => columnPROD;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBARColumn => columnLIBAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public ComptesRow this[int index] => (ComptesRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event ComptesRowChangeEventHandler ComptesRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event ComptesRowChangeEventHandler ComptesRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event ComptesRowChangeEventHandler ComptesRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event ComptesRowChangeEventHandler ComptesRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public ComptesDataTable()
		{
			base.TableName = "Comptes";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal ComptesDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected ComptesDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void AddComptesRow(ComptesRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public ComptesRow AddComptesRow(string CPT, string LIB, string IMPUT, string TRS, string ANA, string IMMO, string CML, string SNS, string RAP, string TAG, string UserC, DateTime DateC, string UserM, DateTime DateM, string AMOR, string DOT, string PROD, string LIBAR)
		{
			ComptesRow rowComptesRow = (ComptesRow)NewRow();
			object[] columnValuesArray = new object[19]
			{
				CPT, LIB, IMPUT, TRS, ANA, IMMO, CML, SNS, RAP, TAG,
				null, UserC, DateC, UserM, DateM, AMOR, DOT, PROD, LIBAR
			};
			rowComptesRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowComptesRow);
			return rowComptesRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public ComptesRow FindByCPT(string CPT)
		{
			return (ComptesRow)base.Rows.Find(new object[1] { CPT });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Clone()
		{
			ComptesDataTable obj = (ComptesDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new ComptesDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			columnCPT = base.Columns["CPT"];
			columnLIB = base.Columns["LIB"];
			columnIMPUT = base.Columns["IMPUT"];
			columnTRS = base.Columns["TRS"];
			columnANA = base.Columns["ANA"];
			columnIMMO = base.Columns["IMMO"];
			columnCML = base.Columns["CML"];
			columnSNS = base.Columns["SNS"];
			columnRAP = base.Columns["RAP"];
			columnTAG = base.Columns["TAG"];
			columnID = base.Columns["ID"];
			columnUserC = base.Columns["UserC"];
			columnDateC = base.Columns["DateC"];
			columnUserM = base.Columns["UserM"];
			columnDateM = base.Columns["DateM"];
			columnAMOR = base.Columns["AMOR"];
			columnDOT = base.Columns["DOT"];
			columnPROD = base.Columns["PROD"];
			columnLIBAR = base.Columns["LIBAR"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			columnCPT = new DataColumn("CPT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCPT);
			columnLIB = new DataColumn("LIB", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIB);
			columnIMPUT = new DataColumn("IMPUT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnIMPUT);
			columnTRS = new DataColumn("TRS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTRS);
			columnANA = new DataColumn("ANA", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnANA);
			columnIMMO = new DataColumn("IMMO", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnIMMO);
			columnCML = new DataColumn("CML", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCML);
			columnSNS = new DataColumn("SNS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSNS);
			columnRAP = new DataColumn("RAP", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnRAP);
			columnTAG = new DataColumn("TAG", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTAG);
			columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnID);
			columnUserC = new DataColumn("UserC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserC);
			columnDateC = new DataColumn("DateC", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateC);
			columnUserM = new DataColumn("UserM", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserM);
			columnDateM = new DataColumn("DateM", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateM);
			columnAMOR = new DataColumn("AMOR", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnAMOR);
			columnDOT = new DataColumn("DOT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDOT);
			columnPROD = new DataColumn("PROD", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPROD);
			columnLIBAR = new DataColumn("LIBAR", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIBAR);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnCPT }, isPrimaryKey: true));
			columnCPT.AllowDBNull = false;
			columnCPT.Unique = true;
			columnCPT.MaxLength = 6;
			columnLIB.MaxLength = 80;
			columnIMPUT.MaxLength = 1;
			columnTRS.MaxLength = 1;
			columnANA.MaxLength = 1;
			columnIMMO.MaxLength = 1;
			columnCML.MaxLength = 1;
			columnSNS.MaxLength = 1;
			columnRAP.MaxLength = 1;
			columnTAG.MaxLength = 6;
			columnID.AutoIncrement = true;
			columnID.AutoIncrementSeed = -1L;
			columnID.AutoIncrementStep = -1L;
			columnUserC.MaxLength = 6;
			columnUserM.MaxLength = 6;
			columnAMOR.MaxLength = 1;
			columnDOT.MaxLength = 1;
			columnPROD.MaxLength = 1;
			columnLIBAR.MaxLength = 80;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public ComptesRow NewComptesRow()
		{
			return (ComptesRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new ComptesRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(ComptesRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.ComptesRowChanged != null)
			{
				this.ComptesRowChanged(this, new ComptesRowChangeEvent((ComptesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.ComptesRowChanging != null)
			{
				this.ComptesRowChanging(this, new ComptesRowChangeEvent((ComptesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.ComptesRowDeleted != null)
			{
				this.ComptesRowDeleted(this, new ComptesRowChangeEvent((ComptesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.ComptesRowDeleting != null)
			{
				this.ComptesRowDeleting(this, new ComptesRowChangeEvent((ComptesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void RemoveComptesRow(ComptesRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			DataSet1 ds = new DataSet1();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = 0m;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = 1m;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "ComptesDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						XmlSchema obj = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						obj.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DossiersDataTable : TypedTableBase<DossiersRow>
	{
		private DataColumn columnUNI;

		private DataColumn columnLIB;

		private DataColumn columnADR;

		private DataColumn columnCP;

		private DataColumn columnNUMIF;

		private DataColumn columnNUMAI;

		private DataColumn columnACT;

		private DataColumn columnRC;

		private DataColumn columnEXER_CG;

		private DataColumn columnEXER_PA;

		private DataColumn columnID;

		private DataColumn columnPassword;

		private DataColumn columnUserC;

		private DataColumn columnDateC;

		private DataColumn columnUserM;

		private DataColumn columnDateM;

		private DataColumn columnTEL;

		private DataColumn columnFAX;

		private DataColumn columnCF;

		private DataColumn columnMAIL;

		private DataColumn columnNIS;

		private DataColumn columnCodeActivite;

		private DataColumn columnCPWilaya;

		private DataColumn columnCPCommune;

		private DataColumn columnInspection;

		private DataColumn columnRecette;

		private DataColumn columnLIBAR;

		private DataColumn columnADRAR;

		private DataColumn columnACTAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UNIColumn => columnUNI;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBColumn => columnLIB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ADRColumn => columnADR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPColumn => columnCP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NUMIFColumn => columnNUMIF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NUMAIColumn => columnNUMAI;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ACTColumn => columnACT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn RCColumn => columnRC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn EXER_CGColumn => columnEXER_CG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn EXER_PAColumn => columnEXER_PA;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn IDColumn => columnID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PasswordColumn => columnPassword;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserCColumn => columnUserC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateCColumn => columnDateC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserMColumn => columnUserM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateMColumn => columnDateM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn TELColumn => columnTEL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn FAXColumn => columnFAX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CFColumn => columnCF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn MAILColumn => columnMAIL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NISColumn => columnNIS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CodeActiviteColumn => columnCodeActivite;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPWilayaColumn => columnCPWilaya;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPCommuneColumn => columnCPCommune;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn InspectionColumn => columnInspection;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn RecetteColumn => columnRecette;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBARColumn => columnLIBAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ADRARColumn => columnADRAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ACTARColumn => columnACTAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DossiersRow this[int index] => (DossiersRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event DossiersRowChangeEventHandler DossiersRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event DossiersRowChangeEventHandler DossiersRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event DossiersRowChangeEventHandler DossiersRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event DossiersRowChangeEventHandler DossiersRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DossiersDataTable()
		{
			base.TableName = "Dossiers";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal DossiersDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected DossiersDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void AddDossiersRow(DossiersRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DossiersRow AddDossiersRow(string UNI, string LIB, string ADR, string CP, string NUMIF, string NUMAI, string ACT, string RC, string EXER_CG, string EXER_PA, string Password, string UserC, DateTime DateC, string UserM, DateTime DateM, string TEL, string FAX, string CF, string MAIL, string NIS, string CodeActivite, string CPWilaya, string CPCommune, string Inspection, string Recette, string LIBAR, string ADRAR, string ACTAR)
		{
			DossiersRow rowDossiersRow = (DossiersRow)NewRow();
			object[] columnValuesArray = new object[29]
			{
				UNI, LIB, ADR, CP, NUMIF, NUMAI, ACT, RC, EXER_CG, EXER_PA,
				null, Password, UserC, DateC, UserM, DateM, TEL, FAX, CF, MAIL,
				NIS, CodeActivite, CPWilaya, CPCommune, Inspection, Recette, LIBAR, ADRAR, ACTAR
			};
			rowDossiersRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowDossiersRow);
			return rowDossiersRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DossiersRow FindByUNI(string UNI)
		{
			return (DossiersRow)base.Rows.Find(new object[1] { UNI });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Clone()
		{
			DossiersDataTable obj = (DossiersDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new DossiersDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			columnUNI = base.Columns["UNI"];
			columnLIB = base.Columns["LIB"];
			columnADR = base.Columns["ADR"];
			columnCP = base.Columns["CP"];
			columnNUMIF = base.Columns["NUMIF"];
			columnNUMAI = base.Columns["NUMAI"];
			columnACT = base.Columns["ACT"];
			columnRC = base.Columns["RC"];
			columnEXER_CG = base.Columns["EXER_CG"];
			columnEXER_PA = base.Columns["EXER_PA"];
			columnID = base.Columns["ID"];
			columnPassword = base.Columns["Password"];
			columnUserC = base.Columns["UserC"];
			columnDateC = base.Columns["DateC"];
			columnUserM = base.Columns["UserM"];
			columnDateM = base.Columns["DateM"];
			columnTEL = base.Columns["TEL"];
			columnFAX = base.Columns["FAX"];
			columnCF = base.Columns["CF"];
			columnMAIL = base.Columns["MAIL"];
			columnNIS = base.Columns["NIS"];
			columnCodeActivite = base.Columns["CodeActivite"];
			columnCPWilaya = base.Columns["CPWilaya"];
			columnCPCommune = base.Columns["CPCommune"];
			columnInspection = base.Columns["Inspection"];
			columnRecette = base.Columns["Recette"];
			columnLIBAR = base.Columns["LIBAR"];
			columnADRAR = base.Columns["ADRAR"];
			columnACTAR = base.Columns["ACTAR"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			columnUNI = new DataColumn("UNI", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUNI);
			columnLIB = new DataColumn("LIB", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIB);
			columnADR = new DataColumn("ADR", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnADR);
			columnCP = new DataColumn("CP", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCP);
			columnNUMIF = new DataColumn("NUMIF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNUMIF);
			columnNUMAI = new DataColumn("NUMAI", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNUMAI);
			columnACT = new DataColumn("ACT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnACT);
			columnRC = new DataColumn("RC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnRC);
			columnEXER_CG = new DataColumn("EXER_CG", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnEXER_CG);
			columnEXER_PA = new DataColumn("EXER_PA", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnEXER_PA);
			columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnID);
			columnPassword = new DataColumn("Password", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPassword);
			columnUserC = new DataColumn("UserC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserC);
			columnDateC = new DataColumn("DateC", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateC);
			columnUserM = new DataColumn("UserM", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserM);
			columnDateM = new DataColumn("DateM", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateM);
			columnTEL = new DataColumn("TEL", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTEL);
			columnFAX = new DataColumn("FAX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFAX);
			columnCF = new DataColumn("CF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCF);
			columnMAIL = new DataColumn("MAIL", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMAIL);
			columnNIS = new DataColumn("NIS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNIS);
			columnCodeActivite = new DataColumn("CodeActivite", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCodeActivite);
			columnCPWilaya = new DataColumn("CPWilaya", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCPWilaya);
			columnCPCommune = new DataColumn("CPCommune", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCPCommune);
			columnInspection = new DataColumn("Inspection", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnInspection);
			columnRecette = new DataColumn("Recette", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnRecette);
			columnLIBAR = new DataColumn("LIBAR", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIBAR);
			columnADRAR = new DataColumn("ADRAR", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnADRAR);
			columnACTAR = new DataColumn("ACTAR", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnACTAR);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnUNI }, isPrimaryKey: true));
			columnUNI.AllowDBNull = false;
			columnUNI.Unique = true;
			columnUNI.MaxLength = 3;
			columnLIB.MaxLength = 80;
			columnADR.MaxLength = 30;
			columnCP.MaxLength = 30;
			columnNUMIF.MaxLength = 15;
			columnNUMAI.MaxLength = 11;
			columnACT.MaxLength = 120;
			columnRC.MaxLength = 20;
			columnEXER_CG.MaxLength = 4;
			columnEXER_PA.MaxLength = 6;
			columnID.AutoIncrement = true;
			columnID.AutoIncrementSeed = -1L;
			columnID.AutoIncrementStep = -1L;
			columnPassword.MaxLength = 50;
			columnUserC.MaxLength = 6;
			columnUserM.MaxLength = 6;
			columnTEL.MaxLength = 20;
			columnFAX.MaxLength = 20;
			columnCF.MaxLength = 50;
			columnMAIL.MaxLength = 50;
			columnNIS.MaxLength = 20;
			columnCodeActivite.MaxLength = 50;
			columnCPWilaya.MaxLength = 5;
			columnCPCommune.MaxLength = 5;
			columnInspection.MaxLength = 50;
			columnRecette.MaxLength = 50;
			columnLIBAR.MaxLength = 80;
			columnADRAR.MaxLength = 80;
			columnACTAR.MaxLength = 80;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DossiersRow NewDossiersRow()
		{
			return (DossiersRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DossiersRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(DossiersRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.DossiersRowChanged != null)
			{
				this.DossiersRowChanged(this, new DossiersRowChangeEvent((DossiersRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.DossiersRowChanging != null)
			{
				this.DossiersRowChanging(this, new DossiersRowChangeEvent((DossiersRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.DossiersRowDeleted != null)
			{
				this.DossiersRowDeleted(this, new DossiersRowChangeEvent((DossiersRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.DossiersRowDeleting != null)
			{
				this.DossiersRowDeleting(this, new DossiersRowChangeEvent((DossiersRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void RemoveDossiersRow(DossiersRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			DataSet1 ds = new DataSet1();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = 0m;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = 1m;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "DossiersDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						XmlSchema obj = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						obj.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Ecritures00DataTable : TypedTableBase<Ecritures00Row>
	{
		private DataColumn columnUNI;

		private DataColumn columnExercice;

		private DataColumn columnJA;

		private DataColumn columnNOP;

		private DataColumn columnLIG;

		private DataColumn columnCPT;

		private DataColumn columnTRS;

		private DataColumn columnDAT;

		private DataColumn columnLIB;

		private DataColumn columnDEB;

		private DataColumn columnCRE;

		private DataColumn columnPTG;

		private DataColumn columnPTGX;

		private DataColumn columnRAP;

		private DataColumn columnID;

		private DataColumn columnJour;

		private DataColumn columnUserC;

		private DataColumn columnDateC;

		private DataColumn columnUserM;

		private DataColumn columnDateM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UNIColumn => columnUNI;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ExerciceColumn => columnExercice;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn JAColumn => columnJA;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NOPColumn => columnNOP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIGColumn => columnLIG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPTColumn => columnCPT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn TRSColumn => columnTRS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DATColumn => columnDAT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBColumn => columnLIB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DEBColumn => columnDEB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CREColumn => columnCRE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PTGColumn => columnPTG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PTGXColumn => columnPTGX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn RAPColumn => columnRAP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn IDColumn => columnID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn JourColumn => columnJour;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserCColumn => columnUserC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateCColumn => columnDateC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserMColumn => columnUserM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateMColumn => columnDateM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ecritures00Row this[int index] => (Ecritures00Row)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Ecritures00RowChangeEventHandler Ecritures00RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Ecritures00RowChangeEventHandler Ecritures00RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Ecritures00RowChangeEventHandler Ecritures00RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Ecritures00RowChangeEventHandler Ecritures00RowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ecritures00DataTable()
		{
			base.TableName = "Ecritures00";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Ecritures00DataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected Ecritures00DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void AddEcritures00Row(Ecritures00Row row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ecritures00Row AddEcritures00Row(string UNI, int Exercice, string JA, string NOP, int LIG, string CPT, string TRS, DateTime DAT, string LIB, decimal DEB, decimal CRE, string PTG, string PTGX, string RAP, byte Jour, string UserC, DateTime DateC, string UserM, DateTime DateM)
		{
			Ecritures00Row rowEcritures00Row = (Ecritures00Row)NewRow();
			object[] columnValuesArray = new object[20]
			{
				UNI, Exercice, JA, NOP, LIG, CPT, TRS, DAT, LIB, DEB,
				CRE, PTG, PTGX, RAP, null, Jour, UserC, DateC, UserM, DateM
			};
			rowEcritures00Row.ItemArray = columnValuesArray;
			base.Rows.Add(rowEcritures00Row);
			return rowEcritures00Row;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ecritures00Row FindByID(int ID)
		{
			return (Ecritures00Row)base.Rows.Find(new object[1] { ID });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Clone()
		{
			Ecritures00DataTable obj = (Ecritures00DataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Ecritures00DataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			columnUNI = base.Columns["UNI"];
			columnExercice = base.Columns["Exercice"];
			columnJA = base.Columns["JA"];
			columnNOP = base.Columns["NOP"];
			columnLIG = base.Columns["LIG"];
			columnCPT = base.Columns["CPT"];
			columnTRS = base.Columns["TRS"];
			columnDAT = base.Columns["DAT"];
			columnLIB = base.Columns["LIB"];
			columnDEB = base.Columns["DEB"];
			columnCRE = base.Columns["CRE"];
			columnPTG = base.Columns["PTG"];
			columnPTGX = base.Columns["PTGX"];
			columnRAP = base.Columns["RAP"];
			columnID = base.Columns["ID"];
			columnJour = base.Columns["Jour"];
			columnUserC = base.Columns["UserC"];
			columnDateC = base.Columns["DateC"];
			columnUserM = base.Columns["UserM"];
			columnDateM = base.Columns["DateM"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			columnUNI = new DataColumn("UNI", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUNI);
			columnExercice = new DataColumn("Exercice", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnExercice);
			columnJA = new DataColumn("JA", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnJA);
			columnNOP = new DataColumn("NOP", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNOP);
			columnLIG = new DataColumn("LIG", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnLIG);
			columnCPT = new DataColumn("CPT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCPT);
			columnTRS = new DataColumn("TRS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTRS);
			columnDAT = new DataColumn("DAT", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDAT);
			columnLIB = new DataColumn("LIB", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIB);
			columnDEB = new DataColumn("DEB", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnDEB);
			columnCRE = new DataColumn("CRE", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnCRE);
			columnPTG = new DataColumn("PTG", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPTG);
			columnPTGX = new DataColumn("PTGX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPTGX);
			columnRAP = new DataColumn("RAP", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnRAP);
			columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnID);
			columnJour = new DataColumn("Jour", typeof(byte), null, MappingType.Element);
			base.Columns.Add(columnJour);
			columnUserC = new DataColumn("UserC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserC);
			columnDateC = new DataColumn("DateC", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateC);
			columnUserM = new DataColumn("UserM", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserM);
			columnDateM = new DataColumn("DateM", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateM);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnID }, isPrimaryKey: true));
			columnUNI.MaxLength = 3;
			columnJA.MaxLength = 2;
			columnNOP.MaxLength = 6;
			columnCPT.MaxLength = 6;
			columnTRS.MaxLength = 6;
			columnLIB.MaxLength = 30;
			columnPTG.MaxLength = 1;
			columnPTGX.MaxLength = 1;
			columnRAP.MaxLength = 1;
			columnID.AutoIncrement = true;
			columnID.AutoIncrementSeed = -1L;
			columnID.AutoIncrementStep = -1L;
			columnID.AllowDBNull = false;
			columnID.Unique = true;
			columnUserC.MaxLength = 6;
			columnUserM.MaxLength = 6;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ecritures00Row NewEcritures00Row()
		{
			return (Ecritures00Row)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Ecritures00Row(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Ecritures00Row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.Ecritures00RowChanged != null)
			{
				this.Ecritures00RowChanged(this, new Ecritures00RowChangeEvent((Ecritures00Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.Ecritures00RowChanging != null)
			{
				this.Ecritures00RowChanging(this, new Ecritures00RowChangeEvent((Ecritures00Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.Ecritures00RowDeleted != null)
			{
				this.Ecritures00RowDeleted(this, new Ecritures00RowChangeEvent((Ecritures00Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.Ecritures00RowDeleting != null)
			{
				this.Ecritures00RowDeleting(this, new Ecritures00RowChangeEvent((Ecritures00Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void RemoveEcritures00Row(Ecritures00Row row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			DataSet1 ds = new DataSet1();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = 0m;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = 1m;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "Ecritures00DataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						XmlSchema obj = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						obj.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class EcrtriDataTable : TypedTableBase<EcrtriRow>
	{
		private DataColumn columnUNI;

		private DataColumn columnExercice;

		private DataColumn columnJA;

		private DataColumn columnNOP;

		private DataColumn columnLIG;

		private DataColumn columnCPT;

		private DataColumn columnTRS;

		private DataColumn columnDAT;

		private DataColumn columnLIB;

		private DataColumn columnDEB;

		private DataColumn columnCRE;

		private DataColumn columnPTG;

		private DataColumn columnPTGX;

		private DataColumn columnRAP;

		private DataColumn columnJour;

		private DataColumn columnUserC;

		private DataColumn columnDateC;

		private DataColumn columnUserM;

		private DataColumn columnDateM;

		private DataColumn columnID;

		private DataColumn columnNUM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UNIColumn => columnUNI;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ExerciceColumn => columnExercice;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn JAColumn => columnJA;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NOPColumn => columnNOP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIGColumn => columnLIG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPTColumn => columnCPT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn TRSColumn => columnTRS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DATColumn => columnDAT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBColumn => columnLIB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DEBColumn => columnDEB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CREColumn => columnCRE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PTGColumn => columnPTG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PTGXColumn => columnPTGX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn RAPColumn => columnRAP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn JourColumn => columnJour;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserCColumn => columnUserC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateCColumn => columnDateC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserMColumn => columnUserM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateMColumn => columnDateM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn IDColumn => columnID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NUMColumn => columnNUM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EcrtriRow this[int index] => (EcrtriRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event EcrtriRowChangeEventHandler EcrtriRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event EcrtriRowChangeEventHandler EcrtriRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event EcrtriRowChangeEventHandler EcrtriRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event EcrtriRowChangeEventHandler EcrtriRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EcrtriDataTable()
		{
			base.TableName = "Ecrtri";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal EcrtriDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected EcrtriDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void AddEcrtriRow(EcrtriRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EcrtriRow AddEcrtriRow(string UNI, int Exercice, string JA, string NOP, int LIG, string CPT, string TRS, DateTime DAT, string LIB, decimal DEB, decimal CRE, string PTG, string PTGX, string RAP, byte Jour, string UserC, DateTime DateC, string UserM, DateTime DateM, int ID)
		{
			EcrtriRow rowEcrtriRow = (EcrtriRow)NewRow();
			object[] columnValuesArray = new object[21]
			{
				UNI, Exercice, JA, NOP, LIG, CPT, TRS, DAT, LIB, DEB,
				CRE, PTG, PTGX, RAP, Jour, UserC, DateC, UserM, DateM, ID,
				null
			};
			rowEcrtriRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowEcrtriRow);
			return rowEcrtriRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Clone()
		{
			EcrtriDataTable obj = (EcrtriDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new EcrtriDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			columnUNI = base.Columns["UNI"];
			columnExercice = base.Columns["Exercice"];
			columnJA = base.Columns["JA"];
			columnNOP = base.Columns["NOP"];
			columnLIG = base.Columns["LIG"];
			columnCPT = base.Columns["CPT"];
			columnTRS = base.Columns["TRS"];
			columnDAT = base.Columns["DAT"];
			columnLIB = base.Columns["LIB"];
			columnDEB = base.Columns["DEB"];
			columnCRE = base.Columns["CRE"];
			columnPTG = base.Columns["PTG"];
			columnPTGX = base.Columns["PTGX"];
			columnRAP = base.Columns["RAP"];
			columnJour = base.Columns["Jour"];
			columnUserC = base.Columns["UserC"];
			columnDateC = base.Columns["DateC"];
			columnUserM = base.Columns["UserM"];
			columnDateM = base.Columns["DateM"];
			columnID = base.Columns["ID"];
			columnNUM = base.Columns["NUM"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			columnUNI = new DataColumn("UNI", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUNI);
			columnExercice = new DataColumn("Exercice", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnExercice);
			columnJA = new DataColumn("JA", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnJA);
			columnNOP = new DataColumn("NOP", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNOP);
			columnLIG = new DataColumn("LIG", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnLIG);
			columnCPT = new DataColumn("CPT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCPT);
			columnTRS = new DataColumn("TRS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTRS);
			columnDAT = new DataColumn("DAT", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDAT);
			columnLIB = new DataColumn("LIB", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIB);
			columnDEB = new DataColumn("DEB", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnDEB);
			columnCRE = new DataColumn("CRE", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnCRE);
			columnPTG = new DataColumn("PTG", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPTG);
			columnPTGX = new DataColumn("PTGX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPTGX);
			columnRAP = new DataColumn("RAP", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnRAP);
			columnJour = new DataColumn("Jour", typeof(byte), null, MappingType.Element);
			base.Columns.Add(columnJour);
			columnUserC = new DataColumn("UserC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserC);
			columnDateC = new DataColumn("DateC", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateC);
			columnUserM = new DataColumn("UserM", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserM);
			columnDateM = new DataColumn("DateM", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateM);
			columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnID);
			columnNUM = new DataColumn("NUM", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnNUM);
			columnUNI.MaxLength = 3;
			columnJA.MaxLength = 2;
			columnNOP.MaxLength = 6;
			columnCPT.MaxLength = 6;
			columnTRS.MaxLength = 6;
			columnLIB.MaxLength = 30;
			columnPTG.MaxLength = 1;
			columnPTGX.MaxLength = 1;
			columnRAP.MaxLength = 1;
			columnUserC.MaxLength = 6;
			columnUserM.MaxLength = 6;
			columnNUM.AutoIncrement = true;
			columnNUM.AutoIncrementSeed = -1L;
			columnNUM.AutoIncrementStep = -1L;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EcrtriRow NewEcrtriRow()
		{
			return (EcrtriRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new EcrtriRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(EcrtriRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.EcrtriRowChanged != null)
			{
				this.EcrtriRowChanged(this, new EcrtriRowChangeEvent((EcrtriRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.EcrtriRowChanging != null)
			{
				this.EcrtriRowChanging(this, new EcrtriRowChangeEvent((EcrtriRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.EcrtriRowDeleted != null)
			{
				this.EcrtriRowDeleted(this, new EcrtriRowChangeEvent((EcrtriRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.EcrtriRowDeleting != null)
			{
				this.EcrtriRowDeleting(this, new EcrtriRowChangeEvent((EcrtriRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void RemoveEcrtriRow(EcrtriRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			DataSet1 ds = new DataSet1();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = 0m;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = 1m;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "EcrtriDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						XmlSchema obj = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						obj.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class EtatsDataTable : TypedTableBase<EtatsRow>
	{
		private DataColumn columnID;

		private DataColumn columnPARENTID;

		private DataColumn columnDEPARTMENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn IDColumn => columnID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PARENTIDColumn => columnPARENTID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DEPARTMENTColumn => columnDEPARTMENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EtatsRow this[int index] => (EtatsRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event EtatsRowChangeEventHandler EtatsRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event EtatsRowChangeEventHandler EtatsRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event EtatsRowChangeEventHandler EtatsRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event EtatsRowChangeEventHandler EtatsRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EtatsDataTable()
		{
			base.TableName = "Etats";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal EtatsDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected EtatsDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void AddEtatsRow(EtatsRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EtatsRow AddEtatsRow(double ID, double PARENTID, string DEPARTMENT)
		{
			EtatsRow rowEtatsRow = (EtatsRow)NewRow();
			object[] columnValuesArray = new object[3] { ID, PARENTID, DEPARTMENT };
			rowEtatsRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowEtatsRow);
			return rowEtatsRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EtatsRow FindByID(double ID)
		{
			return (EtatsRow)base.Rows.Find(new object[1] { ID });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Clone()
		{
			EtatsDataTable obj = (EtatsDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new EtatsDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			columnID = base.Columns["ID"];
			columnPARENTID = base.Columns["PARENTID"];
			columnDEPARTMENT = base.Columns["DEPARTMENT"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			columnID = new DataColumn("ID", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnID);
			columnPARENTID = new DataColumn("PARENTID", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPARENTID);
			columnDEPARTMENT = new DataColumn("DEPARTMENT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEPARTMENT);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnID }, isPrimaryKey: true));
			columnID.AllowDBNull = false;
			columnID.Unique = true;
			columnDEPARTMENT.MaxLength = 100;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EtatsRow NewEtatsRow()
		{
			return (EtatsRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new EtatsRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(EtatsRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.EtatsRowChanged != null)
			{
				this.EtatsRowChanged(this, new EtatsRowChangeEvent((EtatsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.EtatsRowChanging != null)
			{
				this.EtatsRowChanging(this, new EtatsRowChangeEvent((EtatsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.EtatsRowDeleted != null)
			{
				this.EtatsRowDeleted(this, new EtatsRowChangeEvent((EtatsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.EtatsRowDeleting != null)
			{
				this.EtatsRowDeleting(this, new EtatsRowChangeEvent((EtatsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void RemoveEtatsRow(EtatsRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			DataSet1 ds = new DataSet1();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = 0m;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = 1m;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "EtatsDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						XmlSchema obj = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						obj.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class ImmoDataTable : TypedTableBase<ImmoRow>
	{
		private DataColumn columnUNI;

		private DataColumn columnMAT;

		private DataColumn columnLIB;

		private DataColumn columnCPT;

		private DataColumn columnDATACQ;

		private DataColumn columnMTACQ;

		private DataColumn columnTVA;

		private DataColumn columnTX;

		private DataColumn columnDATAM;

		private DataColumn columnMTANT;

		private DataColumn columnMTDOT;

		private DataColumn columnCUMDOT;

		private DataColumn columnVNC;

		private DataColumn columnMTIMP;

		private DataColumn columnDATEX;

		private DataColumn columnDATSOR;

		private DataColumn columnMTCES;

		private DataColumn columnOBS;

		private DataColumn columnID;

		private DataColumn columnUserC;

		private DataColumn columnDateC;

		private DataColumn columnUserM;

		private DataColumn columnDateM;

		private DataColumn columnCPTAMOR;

		private DataColumn columnCPTDOT;

		private DataColumn columnCPTPROD;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UNIColumn => columnUNI;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn MATColumn => columnMAT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBColumn => columnLIB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPTColumn => columnCPT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DATACQColumn => columnDATACQ;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn MTACQColumn => columnMTACQ;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn TVAColumn => columnTVA;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn TXColumn => columnTX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DATAMColumn => columnDATAM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn MTANTColumn => columnMTANT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn MTDOTColumn => columnMTDOT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CUMDOTColumn => columnCUMDOT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn VNCColumn => columnVNC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn MTIMPColumn => columnMTIMP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DATEXColumn => columnDATEX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DATSORColumn => columnDATSOR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn MTCESColumn => columnMTCES;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn OBSColumn => columnOBS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn IDColumn => columnID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserCColumn => columnUserC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateCColumn => columnDateC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserMColumn => columnUserM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateMColumn => columnDateM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPTAMORColumn => columnCPTAMOR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPTDOTColumn => columnCPTDOT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPTPRODColumn => columnCPTPROD;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public ImmoRow this[int index] => (ImmoRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event ImmoRowChangeEventHandler ImmoRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event ImmoRowChangeEventHandler ImmoRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event ImmoRowChangeEventHandler ImmoRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event ImmoRowChangeEventHandler ImmoRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public ImmoDataTable()
		{
			base.TableName = "Immo";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal ImmoDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected ImmoDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void AddImmoRow(ImmoRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public ImmoRow AddImmoRow(string UNI, string MAT, string LIB, string CPT, DateTime DATACQ, double MTACQ, double TVA, double TX, DateTime DATAM, double MTANT, double MTDOT, double CUMDOT, double VNC, double MTIMP, DateTime DATEX, DateTime DATSOR, double MTCES, string OBS, string UserC, DateTime DateC, string UserM, DateTime DateM, string CPTAMOR, string CPTDOT, string CPTPROD)
		{
			ImmoRow rowImmoRow = (ImmoRow)NewRow();
			object[] columnValuesArray = new object[26]
			{
				UNI, MAT, LIB, CPT, DATACQ, MTACQ, TVA, TX, DATAM, MTANT,
				MTDOT, CUMDOT, VNC, MTIMP, DATEX, DATSOR, MTCES, OBS, null, UserC,
				DateC, UserM, DateM, CPTAMOR, CPTDOT, CPTPROD
			};
			rowImmoRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowImmoRow);
			return rowImmoRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public ImmoRow FindByUNIMAT(string UNI, string MAT)
		{
			return (ImmoRow)base.Rows.Find(new object[2] { UNI, MAT });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Clone()
		{
			ImmoDataTable obj = (ImmoDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new ImmoDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			columnUNI = base.Columns["UNI"];
			columnMAT = base.Columns["MAT"];
			columnLIB = base.Columns["LIB"];
			columnCPT = base.Columns["CPT"];
			columnDATACQ = base.Columns["DATACQ"];
			columnMTACQ = base.Columns["MTACQ"];
			columnTVA = base.Columns["TVA"];
			columnTX = base.Columns["TX"];
			columnDATAM = base.Columns["DATAM"];
			columnMTANT = base.Columns["MTANT"];
			columnMTDOT = base.Columns["MTDOT"];
			columnCUMDOT = base.Columns["CUMDOT"];
			columnVNC = base.Columns["VNC"];
			columnMTIMP = base.Columns["MTIMP"];
			columnDATEX = base.Columns["DATEX"];
			columnDATSOR = base.Columns["DATSOR"];
			columnMTCES = base.Columns["MTCES"];
			columnOBS = base.Columns["OBS"];
			columnID = base.Columns["ID"];
			columnUserC = base.Columns["UserC"];
			columnDateC = base.Columns["DateC"];
			columnUserM = base.Columns["UserM"];
			columnDateM = base.Columns["DateM"];
			columnCPTAMOR = base.Columns["CPTAMOR"];
			columnCPTDOT = base.Columns["CPTDOT"];
			columnCPTPROD = base.Columns["CPTPROD"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			columnUNI = new DataColumn("UNI", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUNI);
			columnMAT = new DataColumn("MAT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMAT);
			columnLIB = new DataColumn("LIB", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIB);
			columnCPT = new DataColumn("CPT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCPT);
			columnDATACQ = new DataColumn("DATACQ", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDATACQ);
			columnMTACQ = new DataColumn("MTACQ", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnMTACQ);
			columnTVA = new DataColumn("TVA", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnTVA);
			columnTX = new DataColumn("TX", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnTX);
			columnDATAM = new DataColumn("DATAM", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDATAM);
			columnMTANT = new DataColumn("MTANT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnMTANT);
			columnMTDOT = new DataColumn("MTDOT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnMTDOT);
			columnCUMDOT = new DataColumn("CUMDOT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCUMDOT);
			columnVNC = new DataColumn("VNC", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnVNC);
			columnMTIMP = new DataColumn("MTIMP", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnMTIMP);
			columnDATEX = new DataColumn("DATEX", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDATEX);
			columnDATSOR = new DataColumn("DATSOR", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDATSOR);
			columnMTCES = new DataColumn("MTCES", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnMTCES);
			columnOBS = new DataColumn("OBS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnOBS);
			columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnID);
			columnUserC = new DataColumn("UserC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserC);
			columnDateC = new DataColumn("DateC", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateC);
			columnUserM = new DataColumn("UserM", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserM);
			columnDateM = new DataColumn("DateM", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateM);
			columnCPTAMOR = new DataColumn("CPTAMOR", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCPTAMOR);
			columnCPTDOT = new DataColumn("CPTDOT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCPTDOT);
			columnCPTPROD = new DataColumn("CPTPROD", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCPTPROD);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[2] { columnUNI, columnMAT }, isPrimaryKey: true));
			columnUNI.AllowDBNull = false;
			columnUNI.MaxLength = 3;
			columnMAT.AllowDBNull = false;
			columnMAT.MaxLength = 6;
			columnLIB.MaxLength = 30;
			columnCPT.MaxLength = 6;
			columnOBS.MaxLength = 30;
			columnID.AutoIncrement = true;
			columnID.AutoIncrementSeed = -1L;
			columnID.AutoIncrementStep = -1L;
			columnUserC.MaxLength = 6;
			columnUserM.MaxLength = 6;
			columnCPTAMOR.MaxLength = 6;
			columnCPTDOT.MaxLength = 6;
			columnCPTPROD.MaxLength = 6;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public ImmoRow NewImmoRow()
		{
			return (ImmoRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new ImmoRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(ImmoRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.ImmoRowChanged != null)
			{
				this.ImmoRowChanged(this, new ImmoRowChangeEvent((ImmoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.ImmoRowChanging != null)
			{
				this.ImmoRowChanging(this, new ImmoRowChangeEvent((ImmoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.ImmoRowDeleted != null)
			{
				this.ImmoRowDeleted(this, new ImmoRowChangeEvent((ImmoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.ImmoRowDeleting != null)
			{
				this.ImmoRowDeleting(this, new ImmoRowChangeEvent((ImmoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void RemoveImmoRow(ImmoRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			DataSet1 ds = new DataSet1();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = 0m;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = 1m;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "ImmoDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						XmlSchema obj = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						obj.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class JournauxDataTable : TypedTableBase<JournauxRow>
	{
		private DataColumn columnJA;

		private DataColumn columnLIB;

		private DataColumn columnCPT;

		private DataColumn columnCPTOT;

		private DataColumn columnID;

		private DataColumn columnUserC;

		private DataColumn columnDateC;

		private DataColumn columnUserM;

		private DataColumn columnDateM;

		private DataColumn columnLIBAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn JAColumn => columnJA;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBColumn => columnLIB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPTColumn => columnCPT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPTOTColumn => columnCPTOT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn IDColumn => columnID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserCColumn => columnUserC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateCColumn => columnDateC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserMColumn => columnUserM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateMColumn => columnDateM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBARColumn => columnLIBAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public JournauxRow this[int index] => (JournauxRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event JournauxRowChangeEventHandler JournauxRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event JournauxRowChangeEventHandler JournauxRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event JournauxRowChangeEventHandler JournauxRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event JournauxRowChangeEventHandler JournauxRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public JournauxDataTable()
		{
			base.TableName = "Journaux";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal JournauxDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected JournauxDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void AddJournauxRow(JournauxRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public JournauxRow AddJournauxRow(string JA, string LIB, string CPT, string CPTOT, string UserC, DateTime DateC, string UserM, DateTime DateM, string LIBAR)
		{
			JournauxRow rowJournauxRow = (JournauxRow)NewRow();
			object[] columnValuesArray = new object[10] { JA, LIB, CPT, CPTOT, null, UserC, DateC, UserM, DateM, LIBAR };
			rowJournauxRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowJournauxRow);
			return rowJournauxRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public JournauxRow FindByJA(string JA)
		{
			return (JournauxRow)base.Rows.Find(new object[1] { JA });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Clone()
		{
			JournauxDataTable obj = (JournauxDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new JournauxDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			columnJA = base.Columns["JA"];
			columnLIB = base.Columns["LIB"];
			columnCPT = base.Columns["CPT"];
			columnCPTOT = base.Columns["CPTOT"];
			columnID = base.Columns["ID"];
			columnUserC = base.Columns["UserC"];
			columnDateC = base.Columns["DateC"];
			columnUserM = base.Columns["UserM"];
			columnDateM = base.Columns["DateM"];
			columnLIBAR = base.Columns["LIBAR"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			columnJA = new DataColumn("JA", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnJA);
			columnLIB = new DataColumn("LIB", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIB);
			columnCPT = new DataColumn("CPT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCPT);
			columnCPTOT = new DataColumn("CPTOT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCPTOT);
			columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnID);
			columnUserC = new DataColumn("UserC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserC);
			columnDateC = new DataColumn("DateC", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateC);
			columnUserM = new DataColumn("UserM", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserM);
			columnDateM = new DataColumn("DateM", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateM);
			columnLIBAR = new DataColumn("LIBAR", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIBAR);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnJA }, isPrimaryKey: true));
			columnJA.AllowDBNull = false;
			columnJA.Unique = true;
			columnJA.MaxLength = 2;
			columnLIB.MaxLength = 80;
			columnCPT.MaxLength = 6;
			columnCPTOT.MaxLength = 6;
			columnID.AutoIncrement = true;
			columnID.AutoIncrementSeed = -1L;
			columnID.AutoIncrementStep = -1L;
			columnUserC.MaxLength = 6;
			columnUserM.MaxLength = 6;
			columnLIBAR.MaxLength = 80;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public JournauxRow NewJournauxRow()
		{
			return (JournauxRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new JournauxRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(JournauxRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.JournauxRowChanged != null)
			{
				this.JournauxRowChanged(this, new JournauxRowChangeEvent((JournauxRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.JournauxRowChanging != null)
			{
				this.JournauxRowChanging(this, new JournauxRowChangeEvent((JournauxRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.JournauxRowDeleted != null)
			{
				this.JournauxRowDeleted(this, new JournauxRowChangeEvent((JournauxRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.JournauxRowDeleting != null)
			{
				this.JournauxRowDeleting(this, new JournauxRowChangeEvent((JournauxRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void RemoveJournauxRow(JournauxRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			DataSet1 ds = new DataSet1();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = 0m;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = 1m;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "JournauxDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						XmlSchema obj = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						obj.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class LesEtatsDataTable : TypedTableBase<LesEtatsRow>
	{
		private DataColumn columncode;

		private DataColumn columnnom;

		private DataColumn columnprofile;

		private DataColumn columnpapersize;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn codeColumn => columncode;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn nomColumn => columnnom;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn profileColumn => columnprofile;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn papersizeColumn => columnpapersize;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public LesEtatsRow this[int index] => (LesEtatsRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event LesEtatsRowChangeEventHandler LesEtatsRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event LesEtatsRowChangeEventHandler LesEtatsRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event LesEtatsRowChangeEventHandler LesEtatsRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event LesEtatsRowChangeEventHandler LesEtatsRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public LesEtatsDataTable()
		{
			base.TableName = "LesEtats";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal LesEtatsDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected LesEtatsDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void AddLesEtatsRow(LesEtatsRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public LesEtatsRow AddLesEtatsRow(string nom, byte[] profile, int papersize)
		{
			LesEtatsRow rowLesEtatsRow = (LesEtatsRow)NewRow();
			object[] columnValuesArray = new object[4] { null, nom, profile, papersize };
			rowLesEtatsRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowLesEtatsRow);
			return rowLesEtatsRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public LesEtatsRow FindBycode(int code)
		{
			return (LesEtatsRow)base.Rows.Find(new object[1] { code });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Clone()
		{
			LesEtatsDataTable obj = (LesEtatsDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new LesEtatsDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			columncode = base.Columns["code"];
			columnnom = base.Columns["nom"];
			columnprofile = base.Columns["profile"];
			columnpapersize = base.Columns["papersize"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			columncode = new DataColumn("code", typeof(int), null, MappingType.Element);
			base.Columns.Add(columncode);
			columnnom = new DataColumn("nom", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnnom);
			columnprofile = new DataColumn("profile", typeof(byte[]), null, MappingType.Element);
			base.Columns.Add(columnprofile);
			columnpapersize = new DataColumn("papersize", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnpapersize);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columncode }, isPrimaryKey: true));
			columncode.AutoIncrement = true;
			columncode.AutoIncrementSeed = -1L;
			columncode.AutoIncrementStep = -1L;
			columncode.AllowDBNull = false;
			columncode.Unique = true;
			columnnom.MaxLength = 50;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public LesEtatsRow NewLesEtatsRow()
		{
			return (LesEtatsRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new LesEtatsRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(LesEtatsRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.LesEtatsRowChanged != null)
			{
				this.LesEtatsRowChanged(this, new LesEtatsRowChangeEvent((LesEtatsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.LesEtatsRowChanging != null)
			{
				this.LesEtatsRowChanging(this, new LesEtatsRowChangeEvent((LesEtatsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.LesEtatsRowDeleted != null)
			{
				this.LesEtatsRowDeleted(this, new LesEtatsRowChangeEvent((LesEtatsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.LesEtatsRowDeleting != null)
			{
				this.LesEtatsRowDeleting(this, new LesEtatsRowChangeEvent((LesEtatsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void RemoveLesEtatsRow(LesEtatsRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			DataSet1 ds = new DataSet1();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = 0m;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = 1m;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "LesEtatsDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						XmlSchema obj = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						obj.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class LesMoisDataTable : TypedTableBase<LesMoisRow>
	{
		private DataColumn columnMOIS;

		private DataColumn columnLIB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn MOISColumn => columnMOIS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBColumn => columnLIB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public LesMoisRow this[int index] => (LesMoisRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event LesMoisRowChangeEventHandler LesMoisRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event LesMoisRowChangeEventHandler LesMoisRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event LesMoisRowChangeEventHandler LesMoisRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event LesMoisRowChangeEventHandler LesMoisRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public LesMoisDataTable()
		{
			base.TableName = "LesMois";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal LesMoisDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected LesMoisDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void AddLesMoisRow(LesMoisRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public LesMoisRow AddLesMoisRow(byte MOIS, string LIB)
		{
			LesMoisRow rowLesMoisRow = (LesMoisRow)NewRow();
			object[] columnValuesArray = new object[2] { MOIS, LIB };
			rowLesMoisRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowLesMoisRow);
			return rowLesMoisRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public LesMoisRow FindByMOIS(byte MOIS)
		{
			return (LesMoisRow)base.Rows.Find(new object[1] { MOIS });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Clone()
		{
			LesMoisDataTable obj = (LesMoisDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new LesMoisDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			columnMOIS = base.Columns["MOIS"];
			columnLIB = base.Columns["LIB"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			columnMOIS = new DataColumn("MOIS", typeof(byte), null, MappingType.Element);
			base.Columns.Add(columnMOIS);
			columnLIB = new DataColumn("LIB", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIB);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnMOIS }, isPrimaryKey: true));
			columnMOIS.AllowDBNull = false;
			columnMOIS.Unique = true;
			columnLIB.MaxLength = 50;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public LesMoisRow NewLesMoisRow()
		{
			return (LesMoisRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new LesMoisRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(LesMoisRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.LesMoisRowChanged != null)
			{
				this.LesMoisRowChanged(this, new LesMoisRowChangeEvent((LesMoisRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.LesMoisRowChanging != null)
			{
				this.LesMoisRowChanging(this, new LesMoisRowChangeEvent((LesMoisRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.LesMoisRowDeleted != null)
			{
				this.LesMoisRowDeleted(this, new LesMoisRowChangeEvent((LesMoisRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.LesMoisRowDeleting != null)
			{
				this.LesMoisRowDeleting(this, new LesMoisRowChangeEvent((LesMoisRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void RemoveLesMoisRow(LesMoisRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			DataSet1 ds = new DataSet1();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = 0m;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = 1m;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "LesMoisDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						XmlSchema obj = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						obj.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class TiersDataTable : TypedTableBase<TiersRow>
	{
		private DataColumn columnUNI;

		private DataColumn columnTRS;

		private DataColumn columnLIB;

		private DataColumn columnACT;

		private DataColumn columnADR;

		private DataColumn columnCP;

		private DataColumn columnRC;

		private DataColumn columnNUMIF;

		private DataColumn columnNUMAI;

		private DataColumn columnID;

		private DataColumn columnTypeTiers;

		private DataColumn columnUserC;

		private DataColumn columnDateC;

		private DataColumn columnUserM;

		private DataColumn columnDateM;

		private DataColumn columnCF;

		private DataColumn columnTEL;

		private DataColumn columnFAX;

		private DataColumn columnPORT;

		private DataColumn columnMAIL;

		private DataColumn columnNIS;

		private DataColumn columnLIBAR;

		private DataColumn columnADRAR;

		private DataColumn columnACTAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UNIColumn => columnUNI;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn TRSColumn => columnTRS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBColumn => columnLIB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ACTColumn => columnACT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ADRColumn => columnADR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPColumn => columnCP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn RCColumn => columnRC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NUMIFColumn => columnNUMIF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NUMAIColumn => columnNUMAI;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn IDColumn => columnID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn TypeTiersColumn => columnTypeTiers;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserCColumn => columnUserC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateCColumn => columnDateC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserMColumn => columnUserM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateMColumn => columnDateM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CFColumn => columnCF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn TELColumn => columnTEL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn FAXColumn => columnFAX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PORTColumn => columnPORT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn MAILColumn => columnMAIL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NISColumn => columnNIS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBARColumn => columnLIBAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ADRARColumn => columnADRAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ACTARColumn => columnACTAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public TiersRow this[int index] => (TiersRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event TiersRowChangeEventHandler TiersRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event TiersRowChangeEventHandler TiersRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event TiersRowChangeEventHandler TiersRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event TiersRowChangeEventHandler TiersRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public TiersDataTable()
		{
			base.TableName = "Tiers";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal TiersDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected TiersDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void AddTiersRow(TiersRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public TiersRow AddTiersRow(DossiersRow parentDossiersRowByDossiersTiers, string TRS, string LIB, string ACT, string ADR, string CP, string RC, string NUMIF, string NUMAI, string TypeTiers, string UserC, DateTime DateC, string UserM, DateTime DateM, string CF, string TEL, string FAX, string PORT, string MAIL, string NIS, string LIBAR, string ADRAR, string ACTAR)
		{
			TiersRow rowTiersRow = (TiersRow)NewRow();
			object[] columnValuesArray = new object[24]
			{
				null, TRS, LIB, ACT, ADR, CP, RC, NUMIF, NUMAI, null,
				TypeTiers, UserC, DateC, UserM, DateM, CF, TEL, FAX, PORT, MAIL,
				NIS, LIBAR, ADRAR, ACTAR
			};
			if (parentDossiersRowByDossiersTiers != null)
			{
				columnValuesArray[0] = parentDossiersRowByDossiersTiers[0];
			}
			rowTiersRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowTiersRow);
			return rowTiersRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public TiersRow FindByUNITRS(string UNI, string TRS)
		{
			return (TiersRow)base.Rows.Find(new object[2] { UNI, TRS });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Clone()
		{
			TiersDataTable obj = (TiersDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new TiersDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			columnUNI = base.Columns["UNI"];
			columnTRS = base.Columns["TRS"];
			columnLIB = base.Columns["LIB"];
			columnACT = base.Columns["ACT"];
			columnADR = base.Columns["ADR"];
			columnCP = base.Columns["CP"];
			columnRC = base.Columns["RC"];
			columnNUMIF = base.Columns["NUMIF"];
			columnNUMAI = base.Columns["NUMAI"];
			columnID = base.Columns["ID"];
			columnTypeTiers = base.Columns["TypeTiers"];
			columnUserC = base.Columns["UserC"];
			columnDateC = base.Columns["DateC"];
			columnUserM = base.Columns["UserM"];
			columnDateM = base.Columns["DateM"];
			columnCF = base.Columns["CF"];
			columnTEL = base.Columns["TEL"];
			columnFAX = base.Columns["FAX"];
			columnPORT = base.Columns["PORT"];
			columnMAIL = base.Columns["MAIL"];
			columnNIS = base.Columns["NIS"];
			columnLIBAR = base.Columns["LIBAR"];
			columnADRAR = base.Columns["ADRAR"];
			columnACTAR = base.Columns["ACTAR"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			columnUNI = new DataColumn("UNI", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUNI);
			columnTRS = new DataColumn("TRS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTRS);
			columnLIB = new DataColumn("LIB", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIB);
			columnACT = new DataColumn("ACT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnACT);
			columnADR = new DataColumn("ADR", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnADR);
			columnCP = new DataColumn("CP", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCP);
			columnRC = new DataColumn("RC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnRC);
			columnNUMIF = new DataColumn("NUMIF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNUMIF);
			columnNUMAI = new DataColumn("NUMAI", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNUMAI);
			columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnID);
			columnTypeTiers = new DataColumn("TypeTiers", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTypeTiers);
			columnUserC = new DataColumn("UserC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserC);
			columnDateC = new DataColumn("DateC", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateC);
			columnUserM = new DataColumn("UserM", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserM);
			columnDateM = new DataColumn("DateM", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateM);
			columnCF = new DataColumn("CF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCF);
			columnTEL = new DataColumn("TEL", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTEL);
			columnFAX = new DataColumn("FAX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFAX);
			columnPORT = new DataColumn("PORT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPORT);
			columnMAIL = new DataColumn("MAIL", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMAIL);
			columnNIS = new DataColumn("NIS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNIS);
			columnLIBAR = new DataColumn("LIBAR", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIBAR);
			columnADRAR = new DataColumn("ADRAR", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnADRAR);
			columnACTAR = new DataColumn("ACTAR", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnACTAR);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[2] { columnUNI, columnTRS }, isPrimaryKey: true));
			base.Constraints.Add(new UniqueConstraint("Constraint2", new DataColumn[1] { columnID }, isPrimaryKey: false));
			columnUNI.AllowDBNull = false;
			columnUNI.MaxLength = 3;
			columnTRS.AllowDBNull = false;
			columnTRS.MaxLength = 6;
			columnLIB.MaxLength = 80;
			columnACT.MaxLength = 15;
			columnADR.MaxLength = 30;
			columnCP.MaxLength = 30;
			columnRC.MaxLength = 15;
			columnNUMIF.MaxLength = 15;
			columnNUMAI.MaxLength = 11;
			columnID.AutoIncrement = true;
			columnID.AutoIncrementSeed = -1L;
			columnID.AutoIncrementStep = -1L;
			columnID.ReadOnly = true;
			columnID.Unique = true;
			columnTypeTiers.MaxLength = 1;
			columnUserC.MaxLength = 6;
			columnUserM.MaxLength = 6;
			columnCF.MaxLength = 20;
			columnTEL.MaxLength = 20;
			columnFAX.MaxLength = 20;
			columnPORT.MaxLength = 20;
			columnMAIL.MaxLength = 50;
			columnNIS.MaxLength = 15;
			columnLIBAR.MaxLength = 80;
			columnADRAR.MaxLength = 80;
			columnACTAR.MaxLength = 80;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public TiersRow NewTiersRow()
		{
			return (TiersRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new TiersRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(TiersRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.TiersRowChanged != null)
			{
				this.TiersRowChanged(this, new TiersRowChangeEvent((TiersRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.TiersRowChanging != null)
			{
				this.TiersRowChanging(this, new TiersRowChangeEvent((TiersRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.TiersRowDeleted != null)
			{
				this.TiersRowDeleted(this, new TiersRowChangeEvent((TiersRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.TiersRowDeleting != null)
			{
				this.TiersRowDeleting(this, new TiersRowChangeEvent((TiersRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void RemoveTiersRow(TiersRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			DataSet1 ds = new DataSet1();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = 0m;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = 1m;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "TiersDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						XmlSchema obj = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						obj.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class VillesDataTable : TypedTableBase<VillesRow>
	{
		private DataColumn columnCP;

		private DataColumn columnLIB;

		private DataColumn columnUserC;

		private DataColumn columnDateC;

		private DataColumn columnUserM;

		private DataColumn columnDateM;

		private DataColumn columnLIBAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPColumn => columnCP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBColumn => columnLIB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserCColumn => columnUserC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateCColumn => columnDateC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserMColumn => columnUserM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateMColumn => columnDateM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBARColumn => columnLIBAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public VillesRow this[int index] => (VillesRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event VillesRowChangeEventHandler VillesRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event VillesRowChangeEventHandler VillesRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event VillesRowChangeEventHandler VillesRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event VillesRowChangeEventHandler VillesRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public VillesDataTable()
		{
			base.TableName = "Villes";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal VillesDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected VillesDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void AddVillesRow(VillesRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public VillesRow AddVillesRow(string CP, string LIB, string UserC, DateTime DateC, string UserM, DateTime DateM, string LIBAR)
		{
			VillesRow rowVillesRow = (VillesRow)NewRow();
			object[] columnValuesArray = new object[7] { CP, LIB, UserC, DateC, UserM, DateM, LIBAR };
			rowVillesRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowVillesRow);
			return rowVillesRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public VillesRow FindByCP(string CP)
		{
			return (VillesRow)base.Rows.Find(new object[1] { CP });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Clone()
		{
			VillesDataTable obj = (VillesDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new VillesDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			columnCP = base.Columns["CP"];
			columnLIB = base.Columns["LIB"];
			columnUserC = base.Columns["UserC"];
			columnDateC = base.Columns["DateC"];
			columnUserM = base.Columns["UserM"];
			columnDateM = base.Columns["DateM"];
			columnLIBAR = base.Columns["LIBAR"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			columnCP = new DataColumn("CP", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCP);
			columnLIB = new DataColumn("LIB", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIB);
			columnUserC = new DataColumn("UserC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserC);
			columnDateC = new DataColumn("DateC", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateC);
			columnUserM = new DataColumn("UserM", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserM);
			columnDateM = new DataColumn("DateM", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateM);
			columnLIBAR = new DataColumn("LIBAR", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIBAR);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnCP }, isPrimaryKey: true));
			columnCP.AllowDBNull = false;
			columnCP.Unique = true;
			columnCP.MaxLength = 5;
			columnLIB.MaxLength = 30;
			columnUserC.MaxLength = 6;
			columnUserM.MaxLength = 6;
			columnLIBAR.MaxLength = 80;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public VillesRow NewVillesRow()
		{
			return (VillesRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new VillesRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(VillesRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.VillesRowChanged != null)
			{
				this.VillesRowChanged(this, new VillesRowChangeEvent((VillesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.VillesRowChanging != null)
			{
				this.VillesRowChanging(this, new VillesRowChangeEvent((VillesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.VillesRowDeleted != null)
			{
				this.VillesRowDeleted(this, new VillesRowChangeEvent((VillesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.VillesRowDeleting != null)
			{
				this.VillesRowDeleting(this, new VillesRowChangeEvent((VillesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void RemoveVillesRow(VillesRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			DataSet1 ds = new DataSet1();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = 0m;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = 1m;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "VillesDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						XmlSchema obj = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						obj.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Ecritures_tDataTable : TypedTableBase<Ecritures_tRow>
	{
		private DataColumn columnUNI;

		private DataColumn columnExercice;

		private DataColumn columnJA;

		private DataColumn columnNOP;

		private DataColumn columnLIG;

		private DataColumn columnCPT;

		private DataColumn columnTRS;

		private DataColumn columnDAT;

		private DataColumn columnLIB;

		private DataColumn columnDEB;

		private DataColumn columnCRE;

		private DataColumn columnPTG;

		private DataColumn columnPTGX;

		private DataColumn columnRAP;

		private DataColumn columnJour;

		private DataColumn columnUserC;

		private DataColumn columnDateC;

		private DataColumn columnUserM;

		private DataColumn columnDateM;

		private DataColumn columnID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UNIColumn => columnUNI;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ExerciceColumn => columnExercice;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn JAColumn => columnJA;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NOPColumn => columnNOP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIGColumn => columnLIG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CPTColumn => columnCPT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn TRSColumn => columnTRS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DATColumn => columnDAT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBColumn => columnLIB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DEBColumn => columnDEB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CREColumn => columnCRE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PTGColumn => columnPTG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PTGXColumn => columnPTGX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn RAPColumn => columnRAP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn JourColumn => columnJour;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserCColumn => columnUserC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateCColumn => columnDateC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserMColumn => columnUserM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateMColumn => columnDateM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn IDColumn => columnID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ecritures_tRow this[int index] => (Ecritures_tRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Ecritures_tRowChangeEventHandler Ecritures_tRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Ecritures_tRowChangeEventHandler Ecritures_tRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Ecritures_tRowChangeEventHandler Ecritures_tRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Ecritures_tRowChangeEventHandler Ecritures_tRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ecritures_tDataTable()
		{
			base.TableName = "Ecritures_t";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Ecritures_tDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected Ecritures_tDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void AddEcritures_tRow(Ecritures_tRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ecritures_tRow AddEcritures_tRow(string UNI, int Exercice, string JA, string NOP, int LIG, string CPT, string TRS, DateTime DAT, string LIB, decimal DEB, decimal CRE, string PTG, string PTGX, string RAP, byte Jour, string UserC, DateTime DateC, string UserM, DateTime DateM)
		{
			Ecritures_tRow rowEcritures_tRow = (Ecritures_tRow)NewRow();
			object[] columnValuesArray = new object[20]
			{
				UNI, Exercice, JA, NOP, LIG, CPT, TRS, DAT, LIB, DEB,
				CRE, PTG, PTGX, RAP, Jour, UserC, DateC, UserM, DateM, null
			};
			rowEcritures_tRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowEcritures_tRow);
			return rowEcritures_tRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ecritures_tRow FindByID(int ID)
		{
			return (Ecritures_tRow)base.Rows.Find(new object[1] { ID });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Clone()
		{
			Ecritures_tDataTable obj = (Ecritures_tDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Ecritures_tDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			columnUNI = base.Columns["UNI"];
			columnExercice = base.Columns["Exercice"];
			columnJA = base.Columns["JA"];
			columnNOP = base.Columns["NOP"];
			columnLIG = base.Columns["LIG"];
			columnCPT = base.Columns["CPT"];
			columnTRS = base.Columns["TRS"];
			columnDAT = base.Columns["DAT"];
			columnLIB = base.Columns["LIB"];
			columnDEB = base.Columns["DEB"];
			columnCRE = base.Columns["CRE"];
			columnPTG = base.Columns["PTG"];
			columnPTGX = base.Columns["PTGX"];
			columnRAP = base.Columns["RAP"];
			columnJour = base.Columns["Jour"];
			columnUserC = base.Columns["UserC"];
			columnDateC = base.Columns["DateC"];
			columnUserM = base.Columns["UserM"];
			columnDateM = base.Columns["DateM"];
			columnID = base.Columns["ID"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			columnUNI = new DataColumn("UNI", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUNI);
			columnExercice = new DataColumn("Exercice", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnExercice);
			columnJA = new DataColumn("JA", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnJA);
			columnNOP = new DataColumn("NOP", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNOP);
			columnLIG = new DataColumn("LIG", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnLIG);
			columnCPT = new DataColumn("CPT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCPT);
			columnTRS = new DataColumn("TRS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTRS);
			columnDAT = new DataColumn("DAT", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDAT);
			columnLIB = new DataColumn("LIB", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIB);
			columnDEB = new DataColumn("DEB", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnDEB);
			columnCRE = new DataColumn("CRE", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnCRE);
			columnPTG = new DataColumn("PTG", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPTG);
			columnPTGX = new DataColumn("PTGX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPTGX);
			columnRAP = new DataColumn("RAP", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnRAP);
			columnJour = new DataColumn("Jour", typeof(byte), null, MappingType.Element);
			base.Columns.Add(columnJour);
			columnUserC = new DataColumn("UserC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserC);
			columnDateC = new DataColumn("DateC", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateC);
			columnUserM = new DataColumn("UserM", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserM);
			columnDateM = new DataColumn("DateM", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateM);
			columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnID);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnID }, isPrimaryKey: true));
			columnUNI.MaxLength = 3;
			columnJA.MaxLength = 2;
			columnNOP.MaxLength = 6;
			columnCPT.MaxLength = 6;
			columnTRS.MaxLength = 6;
			columnLIB.MaxLength = 30;
			columnPTG.MaxLength = 1;
			columnPTGX.MaxLength = 1;
			columnRAP.MaxLength = 1;
			columnUserC.MaxLength = 6;
			columnUserM.MaxLength = 6;
			columnID.AutoIncrement = true;
			columnID.AutoIncrementSeed = -1L;
			columnID.AutoIncrementStep = -1L;
			columnID.AllowDBNull = false;
			columnID.Unique = true;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ecritures_tRow NewEcritures_tRow()
		{
			return (Ecritures_tRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Ecritures_tRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Ecritures_tRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.Ecritures_tRowChanged != null)
			{
				this.Ecritures_tRowChanged(this, new Ecritures_tRowChangeEvent((Ecritures_tRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.Ecritures_tRowChanging != null)
			{
				this.Ecritures_tRowChanging(this, new Ecritures_tRowChangeEvent((Ecritures_tRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.Ecritures_tRowDeleted != null)
			{
				this.Ecritures_tRowDeleted(this, new Ecritures_tRowChangeEvent((Ecritures_tRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.Ecritures_tRowDeleting != null)
			{
				this.Ecritures_tRowDeleting(this, new Ecritures_tRowChangeEvent((Ecritures_tRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void RemoveEcritures_tRow(Ecritures_tRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			DataSet1 ds = new DataSet1();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = 0m;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = 1m;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "Ecritures_tDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						XmlSchema obj = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						obj.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class PiecesDataTable : TypedTableBase<PiecesRow>
	{
		private DataColumn columnUNI;

		private DataColumn columnExercice;

		private DataColumn columnJA;

		private DataColumn columnNOP;

		private DataColumn columnDat;

		private DataColumn columnMois;

		private DataColumn columnLIB;

		private DataColumn columnID;

		private DataColumn columnUserC;

		private DataColumn columnDateC;

		private DataColumn columnUserM;

		private DataColumn columnDateM;

		private DataColumn columnLIBAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UNIColumn => columnUNI;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ExerciceColumn => columnExercice;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn JAColumn => columnJA;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NOPColumn => columnNOP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DatColumn => columnDat;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn MoisColumn => columnMois;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBColumn => columnLIB;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn IDColumn => columnID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserCColumn => columnUserC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateCColumn => columnDateC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn UserMColumn => columnUserM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn DateMColumn => columnDateM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn LIBARColumn => columnLIBAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public PiecesRow this[int index] => (PiecesRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event PiecesRowChangeEventHandler PiecesRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event PiecesRowChangeEventHandler PiecesRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event PiecesRowChangeEventHandler PiecesRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event PiecesRowChangeEventHandler PiecesRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public PiecesDataTable()
		{
			base.TableName = "Pieces";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal PiecesDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected PiecesDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void AddPiecesRow(PiecesRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public PiecesRow AddPiecesRow(DossiersRow parentDossiersRowByDossiersPieces, int Exercice, JournauxRow parentJournauxRowByJournauxPieces, int NOP, DateTime Dat, byte Mois, string LIB, string UserC, DateTime DateC, string UserM, DateTime DateM, string LIBAR)
		{
			PiecesRow rowPiecesRow = (PiecesRow)NewRow();
			object[] columnValuesArray = new object[13]
			{
				null, Exercice, null, NOP, Dat, Mois, LIB, null, UserC, DateC,
				UserM, DateM, LIBAR
			};
			if (parentDossiersRowByDossiersPieces != null)
			{
				columnValuesArray[0] = parentDossiersRowByDossiersPieces[0];
			}
			if (parentJournauxRowByJournauxPieces != null)
			{
				columnValuesArray[2] = parentJournauxRowByJournauxPieces[0];
			}
			rowPiecesRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowPiecesRow);
			return rowPiecesRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public PiecesRow FindByUNIExerciceJANOP(string UNI, int Exercice, string JA, int NOP)
		{
			return (PiecesRow)base.Rows.Find(new object[4] { UNI, Exercice, JA, NOP });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Clone()
		{
			PiecesDataTable obj = (PiecesDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new PiecesDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			columnUNI = base.Columns["UNI"];
			columnExercice = base.Columns["Exercice"];
			columnJA = base.Columns["JA"];
			columnNOP = base.Columns["NOP"];
			columnDat = base.Columns["Dat"];
			columnMois = base.Columns["Mois"];
			columnLIB = base.Columns["LIB"];
			columnID = base.Columns["ID"];
			columnUserC = base.Columns["UserC"];
			columnDateC = base.Columns["DateC"];
			columnUserM = base.Columns["UserM"];
			columnDateM = base.Columns["DateM"];
			columnLIBAR = base.Columns["LIBAR"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			columnUNI = new DataColumn("UNI", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUNI);
			columnExercice = new DataColumn("Exercice", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnExercice);
			columnJA = new DataColumn("JA", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnJA);
			columnNOP = new DataColumn("NOP", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnNOP);
			columnDat = new DataColumn("Dat", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDat);
			columnMois = new DataColumn("Mois", typeof(byte), null, MappingType.Element);
			base.Columns.Add(columnMois);
			columnLIB = new DataColumn("LIB", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIB);
			columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnID);
			columnUserC = new DataColumn("UserC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserC);
			columnDateC = new DataColumn("DateC", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateC);
			columnUserM = new DataColumn("UserM", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserM);
			columnDateM = new DataColumn("DateM", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateM);
			columnLIBAR = new DataColumn("LIBAR", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLIBAR);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[4] { columnUNI, columnExercice, columnJA, columnNOP }, isPrimaryKey: true));
			columnUNI.AllowDBNull = false;
			columnUNI.MaxLength = 3;
			columnExercice.AllowDBNull = false;
			columnJA.AllowDBNull = false;
			columnJA.MaxLength = 2;
			columnNOP.AllowDBNull = false;
			columnLIB.MaxLength = 50;
			columnID.AutoIncrement = true;
			columnID.AutoIncrementSeed = -1L;
			columnID.AutoIncrementStep = -1L;
			columnUserC.MaxLength = 6;
			columnUserM.MaxLength = 6;
			columnLIBAR.MaxLength = 80;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public PiecesRow NewPiecesRow()
		{
			return (PiecesRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new PiecesRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(PiecesRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.PiecesRowChanged != null)
			{
				this.PiecesRowChanged(this, new PiecesRowChangeEvent((PiecesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.PiecesRowChanging != null)
			{
				this.PiecesRowChanging(this, new PiecesRowChangeEvent((PiecesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.PiecesRowDeleted != null)
			{
				this.PiecesRowDeleted(this, new PiecesRowChangeEvent((PiecesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.PiecesRowDeleting != null)
			{
				this.PiecesRowDeleting(this, new PiecesRowChangeEvent((PiecesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void RemovePiecesRow(PiecesRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			DataSet1 ds = new DataSet1();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = 0m;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = 1m;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "PiecesDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						XmlSchema obj = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						obj.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	public class BalanceRow : DataRow
	{
		private BalanceDataTable tableBalance;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UNI
		{
			get
			{
				try
				{
					return (string)base[tableBalance.UNIColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UNI' dans la table 'Balance' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableBalance.UNIColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int Exercice
		{
			get
			{
				try
				{
					return (int)base[tableBalance.ExerciceColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'Exercice' dans la table 'Balance' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableBalance.ExerciceColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CPT
		{
			get
			{
				try
				{
					return (string)base[tableBalance.CPTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CPT' dans la table 'Balance' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableBalance.CPTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public decimal DEB
		{
			get
			{
				try
				{
					return (decimal)base[tableBalance.DEBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DEB' dans la table 'Balance' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableBalance.DEBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public decimal CRE
		{
			get
			{
				try
				{
					return (decimal)base[tableBalance.CREColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CRE' dans la table 'Balance' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableBalance.CREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal BalanceRow(DataRowBuilder rb)
			: base(rb)
		{
			tableBalance = (BalanceDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUNINull()
		{
			return IsNull(tableBalance.UNIColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUNINull()
		{
			base[tableBalance.UNIColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsExerciceNull()
		{
			return IsNull(tableBalance.ExerciceColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetExerciceNull()
		{
			base[tableBalance.ExerciceColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCPTNull()
		{
			return IsNull(tableBalance.CPTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCPTNull()
		{
			base[tableBalance.CPTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDEBNull()
		{
			return IsNull(tableBalance.DEBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDEBNull()
		{
			base[tableBalance.DEBColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCRENull()
		{
			return IsNull(tableBalance.CREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCRENull()
		{
			base[tableBalance.CREColumn] = Convert.DBNull;
		}
	}

	public class ComptesRow : DataRow
	{
		private ComptesDataTable tableComptes;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CPT
		{
			get
			{
				return (string)base[tableComptes.CPTColumn];
			}
			set
			{
				base[tableComptes.CPTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIB
		{
			get
			{
				try
				{
					return (string)base[tableComptes.LIBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIB' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.LIBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string IMPUT
		{
			get
			{
				try
				{
					return (string)base[tableComptes.IMPUTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'IMPUT' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.IMPUTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string TRS
		{
			get
			{
				try
				{
					return (string)base[tableComptes.TRSColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'TRS' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.TRSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string ANA
		{
			get
			{
				try
				{
					return (string)base[tableComptes.ANAColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ANA' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.ANAColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string IMMO
		{
			get
			{
				try
				{
					return (string)base[tableComptes.IMMOColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'IMMO' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.IMMOColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CML
		{
			get
			{
				try
				{
					return (string)base[tableComptes.CMLColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CML' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.CMLColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string SNS
		{
			get
			{
				try
				{
					return (string)base[tableComptes.SNSColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'SNS' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.SNSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string RAP
		{
			get
			{
				try
				{
					return (string)base[tableComptes.RAPColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'RAP' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.RAPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string TAG
		{
			get
			{
				try
				{
					return (string)base[tableComptes.TAGColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'TAG' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.TAGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int ID
		{
			get
			{
				try
				{
					return (int)base[tableComptes.IDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ID' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserC
		{
			get
			{
				try
				{
					return (string)base[tableComptes.UserCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserC' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.UserCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateC
		{
			get
			{
				try
				{
					return (DateTime)base[tableComptes.DateCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateC' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.DateCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserM
		{
			get
			{
				try
				{
					return (string)base[tableComptes.UserMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserM' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.UserMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateM
		{
			get
			{
				try
				{
					return (DateTime)base[tableComptes.DateMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateM' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.DateMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string AMOR
		{
			get
			{
				try
				{
					return (string)base[tableComptes.AMORColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'AMOR' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.AMORColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string DOT
		{
			get
			{
				try
				{
					return (string)base[tableComptes.DOTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DOT' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.DOTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string PROD
		{
			get
			{
				try
				{
					return (string)base[tableComptes.PRODColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'PROD' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.PRODColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIBAR
		{
			get
			{
				try
				{
					return (string)base[tableComptes.LIBARColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIBAR' dans la table 'Comptes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableComptes.LIBARColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal ComptesRow(DataRowBuilder rb)
			: base(rb)
		{
			tableComptes = (ComptesDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBNull()
		{
			return IsNull(tableComptes.LIBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBNull()
		{
			base[tableComptes.LIBColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsIMPUTNull()
		{
			return IsNull(tableComptes.IMPUTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetIMPUTNull()
		{
			base[tableComptes.IMPUTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsTRSNull()
		{
			return IsNull(tableComptes.TRSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetTRSNull()
		{
			base[tableComptes.TRSColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsANANull()
		{
			return IsNull(tableComptes.ANAColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetANANull()
		{
			base[tableComptes.ANAColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsIMMONull()
		{
			return IsNull(tableComptes.IMMOColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetIMMONull()
		{
			base[tableComptes.IMMOColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCMLNull()
		{
			return IsNull(tableComptes.CMLColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCMLNull()
		{
			base[tableComptes.CMLColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsSNSNull()
		{
			return IsNull(tableComptes.SNSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetSNSNull()
		{
			base[tableComptes.SNSColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsRAPNull()
		{
			return IsNull(tableComptes.RAPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetRAPNull()
		{
			base[tableComptes.RAPColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsTAGNull()
		{
			return IsNull(tableComptes.TAGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetTAGNull()
		{
			base[tableComptes.TAGColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsIDNull()
		{
			return IsNull(tableComptes.IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetIDNull()
		{
			base[tableComptes.IDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserCNull()
		{
			return IsNull(tableComptes.UserCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserCNull()
		{
			base[tableComptes.UserCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateCNull()
		{
			return IsNull(tableComptes.DateCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateCNull()
		{
			base[tableComptes.DateCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserMNull()
		{
			return IsNull(tableComptes.UserMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserMNull()
		{
			base[tableComptes.UserMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateMNull()
		{
			return IsNull(tableComptes.DateMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateMNull()
		{
			base[tableComptes.DateMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsAMORNull()
		{
			return IsNull(tableComptes.AMORColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetAMORNull()
		{
			base[tableComptes.AMORColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDOTNull()
		{
			return IsNull(tableComptes.DOTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDOTNull()
		{
			base[tableComptes.DOTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsPRODNull()
		{
			return IsNull(tableComptes.PRODColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetPRODNull()
		{
			base[tableComptes.PRODColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBARNull()
		{
			return IsNull(tableComptes.LIBARColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBARNull()
		{
			base[tableComptes.LIBARColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EcrituresRow[] GetEcrituresRows()
		{
			if (base.Table.ChildRelations["ComptesEcritures"] == null)
			{
				return new EcrituresRow[0];
			}
			return (EcrituresRow[])GetChildRows(base.Table.ChildRelations["ComptesEcritures"]);
		}
	}

	public class DossiersRow : DataRow
	{
		private DossiersDataTable tableDossiers;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UNI
		{
			get
			{
				return (string)base[tableDossiers.UNIColumn];
			}
			set
			{
				base[tableDossiers.UNIColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIB
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.LIBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIB' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.LIBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string ADR
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.ADRColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ADR' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.ADRColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CP
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.CPColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CP' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.CPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string NUMIF
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.NUMIFColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'NUMIF' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.NUMIFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string NUMAI
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.NUMAIColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'NUMAI' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.NUMAIColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string ACT
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.ACTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ACT' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.ACTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string RC
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.RCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'RC' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.RCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string EXER_CG
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.EXER_CGColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'EXER_CG' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.EXER_CGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string EXER_PA
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.EXER_PAColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'EXER_PA' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.EXER_PAColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int ID
		{
			get
			{
				try
				{
					return (int)base[tableDossiers.IDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ID' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Password
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.PasswordColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'Password' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.PasswordColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserC
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.UserCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserC' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.UserCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateC
		{
			get
			{
				try
				{
					return (DateTime)base[tableDossiers.DateCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateC' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.DateCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserM
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.UserMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserM' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.UserMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateM
		{
			get
			{
				try
				{
					return (DateTime)base[tableDossiers.DateMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateM' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.DateMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string TEL
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.TELColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'TEL' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.TELColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string FAX
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.FAXColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'FAX' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.FAXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CF
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.CFColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CF' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.CFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string MAIL
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.MAILColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'MAIL' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.MAILColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string NIS
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.NISColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'NIS' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.NISColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CodeActivite
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.CodeActiviteColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CodeActivite' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.CodeActiviteColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CPWilaya
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.CPWilayaColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CPWilaya' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.CPWilayaColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CPCommune
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.CPCommuneColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CPCommune' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.CPCommuneColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Inspection
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.InspectionColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'Inspection' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.InspectionColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Recette
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.RecetteColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'Recette' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.RecetteColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIBAR
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.LIBARColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIBAR' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.LIBARColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string ADRAR
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.ADRARColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ADRAR' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.ADRARColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string ACTAR
		{
			get
			{
				try
				{
					return (string)base[tableDossiers.ACTARColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ACTAR' dans la table 'Dossiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableDossiers.ACTARColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal DossiersRow(DataRowBuilder rb)
			: base(rb)
		{
			tableDossiers = (DossiersDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBNull()
		{
			return IsNull(tableDossiers.LIBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBNull()
		{
			base[tableDossiers.LIBColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsADRNull()
		{
			return IsNull(tableDossiers.ADRColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetADRNull()
		{
			base[tableDossiers.ADRColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCPNull()
		{
			return IsNull(tableDossiers.CPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCPNull()
		{
			base[tableDossiers.CPColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsNUMIFNull()
		{
			return IsNull(tableDossiers.NUMIFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetNUMIFNull()
		{
			base[tableDossiers.NUMIFColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsNUMAINull()
		{
			return IsNull(tableDossiers.NUMAIColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetNUMAINull()
		{
			base[tableDossiers.NUMAIColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsACTNull()
		{
			return IsNull(tableDossiers.ACTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetACTNull()
		{
			base[tableDossiers.ACTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsRCNull()
		{
			return IsNull(tableDossiers.RCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetRCNull()
		{
			base[tableDossiers.RCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsEXER_CGNull()
		{
			return IsNull(tableDossiers.EXER_CGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetEXER_CGNull()
		{
			base[tableDossiers.EXER_CGColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsEXER_PANull()
		{
			return IsNull(tableDossiers.EXER_PAColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetEXER_PANull()
		{
			base[tableDossiers.EXER_PAColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsIDNull()
		{
			return IsNull(tableDossiers.IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetIDNull()
		{
			base[tableDossiers.IDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsPasswordNull()
		{
			return IsNull(tableDossiers.PasswordColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetPasswordNull()
		{
			base[tableDossiers.PasswordColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserCNull()
		{
			return IsNull(tableDossiers.UserCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserCNull()
		{
			base[tableDossiers.UserCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateCNull()
		{
			return IsNull(tableDossiers.DateCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateCNull()
		{
			base[tableDossiers.DateCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserMNull()
		{
			return IsNull(tableDossiers.UserMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserMNull()
		{
			base[tableDossiers.UserMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateMNull()
		{
			return IsNull(tableDossiers.DateMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateMNull()
		{
			base[tableDossiers.DateMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsTELNull()
		{
			return IsNull(tableDossiers.TELColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetTELNull()
		{
			base[tableDossiers.TELColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsFAXNull()
		{
			return IsNull(tableDossiers.FAXColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetFAXNull()
		{
			base[tableDossiers.FAXColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCFNull()
		{
			return IsNull(tableDossiers.CFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCFNull()
		{
			base[tableDossiers.CFColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsMAILNull()
		{
			return IsNull(tableDossiers.MAILColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetMAILNull()
		{
			base[tableDossiers.MAILColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsNISNull()
		{
			return IsNull(tableDossiers.NISColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetNISNull()
		{
			base[tableDossiers.NISColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCodeActiviteNull()
		{
			return IsNull(tableDossiers.CodeActiviteColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCodeActiviteNull()
		{
			base[tableDossiers.CodeActiviteColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCPWilayaNull()
		{
			return IsNull(tableDossiers.CPWilayaColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCPWilayaNull()
		{
			base[tableDossiers.CPWilayaColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCPCommuneNull()
		{
			return IsNull(tableDossiers.CPCommuneColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCPCommuneNull()
		{
			base[tableDossiers.CPCommuneColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsInspectionNull()
		{
			return IsNull(tableDossiers.InspectionColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetInspectionNull()
		{
			base[tableDossiers.InspectionColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsRecetteNull()
		{
			return IsNull(tableDossiers.RecetteColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetRecetteNull()
		{
			base[tableDossiers.RecetteColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBARNull()
		{
			return IsNull(tableDossiers.LIBARColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBARNull()
		{
			base[tableDossiers.LIBARColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsADRARNull()
		{
			return IsNull(tableDossiers.ADRARColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetADRARNull()
		{
			base[tableDossiers.ADRARColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsACTARNull()
		{
			return IsNull(tableDossiers.ACTARColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetACTARNull()
		{
			base[tableDossiers.ACTARColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public TiersRow[] GetTiersRows()
		{
			if (base.Table.ChildRelations["DossiersTiers"] == null)
			{
				return new TiersRow[0];
			}
			return (TiersRow[])GetChildRows(base.Table.ChildRelations["DossiersTiers"]);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public PiecesRow[] GetPiecesRows()
		{
			if (base.Table.ChildRelations["DossiersPieces"] == null)
			{
				return new PiecesRow[0];
			}
			return (PiecesRow[])GetChildRows(base.Table.ChildRelations["DossiersPieces"]);
		}
	}

	public class Ecritures00Row : DataRow
	{
		private Ecritures00DataTable tableEcritures00;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UNI
		{
			get
			{
				try
				{
					return (string)base[tableEcritures00.UNIColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UNI' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.UNIColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int Exercice
		{
			get
			{
				try
				{
					return (int)base[tableEcritures00.ExerciceColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'Exercice' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.ExerciceColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string JA
		{
			get
			{
				try
				{
					return (string)base[tableEcritures00.JAColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'JA' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.JAColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string NOP
		{
			get
			{
				try
				{
					return (string)base[tableEcritures00.NOPColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'NOP' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.NOPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int LIG
		{
			get
			{
				try
				{
					return (int)base[tableEcritures00.LIGColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIG' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.LIGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CPT
		{
			get
			{
				try
				{
					return (string)base[tableEcritures00.CPTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CPT' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.CPTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string TRS
		{
			get
			{
				try
				{
					return (string)base[tableEcritures00.TRSColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'TRS' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.TRSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DAT
		{
			get
			{
				try
				{
					return (DateTime)base[tableEcritures00.DATColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DAT' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.DATColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIB
		{
			get
			{
				try
				{
					return (string)base[tableEcritures00.LIBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIB' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.LIBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public decimal DEB
		{
			get
			{
				try
				{
					return (decimal)base[tableEcritures00.DEBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DEB' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.DEBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public decimal CRE
		{
			get
			{
				try
				{
					return (decimal)base[tableEcritures00.CREColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CRE' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.CREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string PTG
		{
			get
			{
				try
				{
					return (string)base[tableEcritures00.PTGColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'PTG' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.PTGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string PTGX
		{
			get
			{
				try
				{
					return (string)base[tableEcritures00.PTGXColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'PTGX' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.PTGXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string RAP
		{
			get
			{
				try
				{
					return (string)base[tableEcritures00.RAPColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'RAP' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.RAPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int ID
		{
			get
			{
				return (int)base[tableEcritures00.IDColumn];
			}
			set
			{
				base[tableEcritures00.IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public byte Jour
		{
			get
			{
				try
				{
					return (byte)base[tableEcritures00.JourColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'Jour' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.JourColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserC
		{
			get
			{
				try
				{
					return (string)base[tableEcritures00.UserCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserC' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.UserCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateC
		{
			get
			{
				try
				{
					return (DateTime)base[tableEcritures00.DateCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateC' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.DateCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserM
		{
			get
			{
				try
				{
					return (string)base[tableEcritures00.UserMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserM' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.UserMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateM
		{
			get
			{
				try
				{
					return (DateTime)base[tableEcritures00.DateMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateM' dans la table 'Ecritures00' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures00.DateMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Ecritures00Row(DataRowBuilder rb)
			: base(rb)
		{
			tableEcritures00 = (Ecritures00DataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUNINull()
		{
			return IsNull(tableEcritures00.UNIColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUNINull()
		{
			base[tableEcritures00.UNIColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsExerciceNull()
		{
			return IsNull(tableEcritures00.ExerciceColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetExerciceNull()
		{
			base[tableEcritures00.ExerciceColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsJANull()
		{
			return IsNull(tableEcritures00.JAColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetJANull()
		{
			base[tableEcritures00.JAColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsNOPNull()
		{
			return IsNull(tableEcritures00.NOPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetNOPNull()
		{
			base[tableEcritures00.NOPColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIGNull()
		{
			return IsNull(tableEcritures00.LIGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIGNull()
		{
			base[tableEcritures00.LIGColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCPTNull()
		{
			return IsNull(tableEcritures00.CPTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCPTNull()
		{
			base[tableEcritures00.CPTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsTRSNull()
		{
			return IsNull(tableEcritures00.TRSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetTRSNull()
		{
			base[tableEcritures00.TRSColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDATNull()
		{
			return IsNull(tableEcritures00.DATColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDATNull()
		{
			base[tableEcritures00.DATColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBNull()
		{
			return IsNull(tableEcritures00.LIBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBNull()
		{
			base[tableEcritures00.LIBColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDEBNull()
		{
			return IsNull(tableEcritures00.DEBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDEBNull()
		{
			base[tableEcritures00.DEBColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCRENull()
		{
			return IsNull(tableEcritures00.CREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCRENull()
		{
			base[tableEcritures00.CREColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsPTGNull()
		{
			return IsNull(tableEcritures00.PTGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetPTGNull()
		{
			base[tableEcritures00.PTGColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsPTGXNull()
		{
			return IsNull(tableEcritures00.PTGXColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetPTGXNull()
		{
			base[tableEcritures00.PTGXColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsRAPNull()
		{
			return IsNull(tableEcritures00.RAPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetRAPNull()
		{
			base[tableEcritures00.RAPColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsJourNull()
		{
			return IsNull(tableEcritures00.JourColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetJourNull()
		{
			base[tableEcritures00.JourColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserCNull()
		{
			return IsNull(tableEcritures00.UserCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserCNull()
		{
			base[tableEcritures00.UserCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateCNull()
		{
			return IsNull(tableEcritures00.DateCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateCNull()
		{
			base[tableEcritures00.DateCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserMNull()
		{
			return IsNull(tableEcritures00.UserMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserMNull()
		{
			base[tableEcritures00.UserMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateMNull()
		{
			return IsNull(tableEcritures00.DateMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateMNull()
		{
			base[tableEcritures00.DateMColumn] = Convert.DBNull;
		}
	}

	public class EcrtriRow : DataRow
	{
		private EcrtriDataTable tableEcrtri;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UNI
		{
			get
			{
				try
				{
					return (string)base[tableEcrtri.UNIColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UNI' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.UNIColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int Exercice
		{
			get
			{
				try
				{
					return (int)base[tableEcrtri.ExerciceColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'Exercice' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.ExerciceColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string JA
		{
			get
			{
				try
				{
					return (string)base[tableEcrtri.JAColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'JA' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.JAColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string NOP
		{
			get
			{
				try
				{
					return (string)base[tableEcrtri.NOPColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'NOP' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.NOPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int LIG
		{
			get
			{
				try
				{
					return (int)base[tableEcrtri.LIGColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIG' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.LIGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CPT
		{
			get
			{
				try
				{
					return (string)base[tableEcrtri.CPTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CPT' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.CPTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string TRS
		{
			get
			{
				try
				{
					return (string)base[tableEcrtri.TRSColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'TRS' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.TRSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DAT
		{
			get
			{
				try
				{
					return (DateTime)base[tableEcrtri.DATColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DAT' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.DATColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIB
		{
			get
			{
				try
				{
					return (string)base[tableEcrtri.LIBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIB' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.LIBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public decimal DEB
		{
			get
			{
				try
				{
					return (decimal)base[tableEcrtri.DEBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DEB' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.DEBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public decimal CRE
		{
			get
			{
				try
				{
					return (decimal)base[tableEcrtri.CREColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CRE' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.CREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string PTG
		{
			get
			{
				try
				{
					return (string)base[tableEcrtri.PTGColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'PTG' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.PTGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string PTGX
		{
			get
			{
				try
				{
					return (string)base[tableEcrtri.PTGXColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'PTGX' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.PTGXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string RAP
		{
			get
			{
				try
				{
					return (string)base[tableEcrtri.RAPColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'RAP' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.RAPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public byte Jour
		{
			get
			{
				try
				{
					return (byte)base[tableEcrtri.JourColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'Jour' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.JourColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserC
		{
			get
			{
				try
				{
					return (string)base[tableEcrtri.UserCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserC' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.UserCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateC
		{
			get
			{
				try
				{
					return (DateTime)base[tableEcrtri.DateCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateC' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.DateCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserM
		{
			get
			{
				try
				{
					return (string)base[tableEcrtri.UserMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserM' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.UserMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateM
		{
			get
			{
				try
				{
					return (DateTime)base[tableEcrtri.DateMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateM' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.DateMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int ID
		{
			get
			{
				try
				{
					return (int)base[tableEcrtri.IDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ID' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int NUM
		{
			get
			{
				try
				{
					return (int)base[tableEcrtri.NUMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'NUM' dans la table 'Ecrtri' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcrtri.NUMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal EcrtriRow(DataRowBuilder rb)
			: base(rb)
		{
			tableEcrtri = (EcrtriDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUNINull()
		{
			return IsNull(tableEcrtri.UNIColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUNINull()
		{
			base[tableEcrtri.UNIColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsExerciceNull()
		{
			return IsNull(tableEcrtri.ExerciceColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetExerciceNull()
		{
			base[tableEcrtri.ExerciceColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsJANull()
		{
			return IsNull(tableEcrtri.JAColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetJANull()
		{
			base[tableEcrtri.JAColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsNOPNull()
		{
			return IsNull(tableEcrtri.NOPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetNOPNull()
		{
			base[tableEcrtri.NOPColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIGNull()
		{
			return IsNull(tableEcrtri.LIGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIGNull()
		{
			base[tableEcrtri.LIGColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCPTNull()
		{
			return IsNull(tableEcrtri.CPTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCPTNull()
		{
			base[tableEcrtri.CPTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsTRSNull()
		{
			return IsNull(tableEcrtri.TRSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetTRSNull()
		{
			base[tableEcrtri.TRSColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDATNull()
		{
			return IsNull(tableEcrtri.DATColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDATNull()
		{
			base[tableEcrtri.DATColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBNull()
		{
			return IsNull(tableEcrtri.LIBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBNull()
		{
			base[tableEcrtri.LIBColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDEBNull()
		{
			return IsNull(tableEcrtri.DEBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDEBNull()
		{
			base[tableEcrtri.DEBColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCRENull()
		{
			return IsNull(tableEcrtri.CREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCRENull()
		{
			base[tableEcrtri.CREColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsPTGNull()
		{
			return IsNull(tableEcrtri.PTGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetPTGNull()
		{
			base[tableEcrtri.PTGColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsPTGXNull()
		{
			return IsNull(tableEcrtri.PTGXColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetPTGXNull()
		{
			base[tableEcrtri.PTGXColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsRAPNull()
		{
			return IsNull(tableEcrtri.RAPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetRAPNull()
		{
			base[tableEcrtri.RAPColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsJourNull()
		{
			return IsNull(tableEcrtri.JourColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetJourNull()
		{
			base[tableEcrtri.JourColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserCNull()
		{
			return IsNull(tableEcrtri.UserCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserCNull()
		{
			base[tableEcrtri.UserCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateCNull()
		{
			return IsNull(tableEcrtri.DateCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateCNull()
		{
			base[tableEcrtri.DateCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserMNull()
		{
			return IsNull(tableEcrtri.UserMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserMNull()
		{
			base[tableEcrtri.UserMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateMNull()
		{
			return IsNull(tableEcrtri.DateMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateMNull()
		{
			base[tableEcrtri.DateMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsIDNull()
		{
			return IsNull(tableEcrtri.IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetIDNull()
		{
			base[tableEcrtri.IDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsNUMNull()
		{
			return IsNull(tableEcrtri.NUMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetNUMNull()
		{
			base[tableEcrtri.NUMColumn] = Convert.DBNull;
		}
	}

	public class EtatsRow : DataRow
	{
		private EtatsDataTable tableEtats;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public double ID
		{
			get
			{
				return (double)base[tableEtats.IDColumn];
			}
			set
			{
				base[tableEtats.IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public double PARENTID
		{
			get
			{
				try
				{
					return (double)base[tableEtats.PARENTIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'PARENTID' dans la table 'Etats' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEtats.PARENTIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string DEPARTMENT
		{
			get
			{
				try
				{
					return (string)base[tableEtats.DEPARTMENTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DEPARTMENT' dans la table 'Etats' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEtats.DEPARTMENTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal EtatsRow(DataRowBuilder rb)
			: base(rb)
		{
			tableEtats = (EtatsDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsPARENTIDNull()
		{
			return IsNull(tableEtats.PARENTIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetPARENTIDNull()
		{
			base[tableEtats.PARENTIDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDEPARTMENTNull()
		{
			return IsNull(tableEtats.DEPARTMENTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDEPARTMENTNull()
		{
			base[tableEtats.DEPARTMENTColumn] = Convert.DBNull;
		}
	}

	public class ImmoRow : DataRow
	{
		private ImmoDataTable tableImmo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UNI
		{
			get
			{
				return (string)base[tableImmo.UNIColumn];
			}
			set
			{
				base[tableImmo.UNIColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string MAT
		{
			get
			{
				return (string)base[tableImmo.MATColumn];
			}
			set
			{
				base[tableImmo.MATColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIB
		{
			get
			{
				try
				{
					return (string)base[tableImmo.LIBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIB' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.LIBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CPT
		{
			get
			{
				try
				{
					return (string)base[tableImmo.CPTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CPT' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.CPTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DATACQ
		{
			get
			{
				try
				{
					return (DateTime)base[tableImmo.DATACQColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DATACQ' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.DATACQColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public double MTACQ
		{
			get
			{
				try
				{
					return (double)base[tableImmo.MTACQColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'MTACQ' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.MTACQColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public double TVA
		{
			get
			{
				try
				{
					return (double)base[tableImmo.TVAColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'TVA' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.TVAColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public double TX
		{
			get
			{
				try
				{
					return (double)base[tableImmo.TXColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'TX' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.TXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DATAM
		{
			get
			{
				try
				{
					return (DateTime)base[tableImmo.DATAMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DATAM' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.DATAMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public double MTANT
		{
			get
			{
				try
				{
					return (double)base[tableImmo.MTANTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'MTANT' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.MTANTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public double MTDOT
		{
			get
			{
				try
				{
					return (double)base[tableImmo.MTDOTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'MTDOT' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.MTDOTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public double CUMDOT
		{
			get
			{
				try
				{
					return (double)base[tableImmo.CUMDOTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CUMDOT' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.CUMDOTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public double VNC
		{
			get
			{
				try
				{
					return (double)base[tableImmo.VNCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'VNC' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.VNCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public double MTIMP
		{
			get
			{
				try
				{
					return (double)base[tableImmo.MTIMPColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'MTIMP' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.MTIMPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DATEX
		{
			get
			{
				try
				{
					return (DateTime)base[tableImmo.DATEXColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DATEX' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.DATEXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DATSOR
		{
			get
			{
				try
				{
					return (DateTime)base[tableImmo.DATSORColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DATSOR' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.DATSORColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public double MTCES
		{
			get
			{
				try
				{
					return (double)base[tableImmo.MTCESColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'MTCES' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.MTCESColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string OBS
		{
			get
			{
				try
				{
					return (string)base[tableImmo.OBSColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'OBS' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.OBSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int ID
		{
			get
			{
				try
				{
					return (int)base[tableImmo.IDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ID' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserC
		{
			get
			{
				try
				{
					return (string)base[tableImmo.UserCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserC' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.UserCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateC
		{
			get
			{
				try
				{
					return (DateTime)base[tableImmo.DateCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateC' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.DateCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserM
		{
			get
			{
				try
				{
					return (string)base[tableImmo.UserMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserM' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.UserMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateM
		{
			get
			{
				try
				{
					return (DateTime)base[tableImmo.DateMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateM' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.DateMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CPTAMOR
		{
			get
			{
				try
				{
					return (string)base[tableImmo.CPTAMORColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CPTAMOR' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.CPTAMORColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CPTDOT
		{
			get
			{
				try
				{
					return (string)base[tableImmo.CPTDOTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CPTDOT' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.CPTDOTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CPTPROD
		{
			get
			{
				try
				{
					return (string)base[tableImmo.CPTPRODColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CPTPROD' dans la table 'Immo' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableImmo.CPTPRODColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal ImmoRow(DataRowBuilder rb)
			: base(rb)
		{
			tableImmo = (ImmoDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBNull()
		{
			return IsNull(tableImmo.LIBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBNull()
		{
			base[tableImmo.LIBColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCPTNull()
		{
			return IsNull(tableImmo.CPTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCPTNull()
		{
			base[tableImmo.CPTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDATACQNull()
		{
			return IsNull(tableImmo.DATACQColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDATACQNull()
		{
			base[tableImmo.DATACQColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsMTACQNull()
		{
			return IsNull(tableImmo.MTACQColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetMTACQNull()
		{
			base[tableImmo.MTACQColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsTVANull()
		{
			return IsNull(tableImmo.TVAColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetTVANull()
		{
			base[tableImmo.TVAColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsTXNull()
		{
			return IsNull(tableImmo.TXColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetTXNull()
		{
			base[tableImmo.TXColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDATAMNull()
		{
			return IsNull(tableImmo.DATAMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDATAMNull()
		{
			base[tableImmo.DATAMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsMTANTNull()
		{
			return IsNull(tableImmo.MTANTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetMTANTNull()
		{
			base[tableImmo.MTANTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsMTDOTNull()
		{
			return IsNull(tableImmo.MTDOTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetMTDOTNull()
		{
			base[tableImmo.MTDOTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCUMDOTNull()
		{
			return IsNull(tableImmo.CUMDOTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCUMDOTNull()
		{
			base[tableImmo.CUMDOTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsVNCNull()
		{
			return IsNull(tableImmo.VNCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetVNCNull()
		{
			base[tableImmo.VNCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsMTIMPNull()
		{
			return IsNull(tableImmo.MTIMPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetMTIMPNull()
		{
			base[tableImmo.MTIMPColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDATEXNull()
		{
			return IsNull(tableImmo.DATEXColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDATEXNull()
		{
			base[tableImmo.DATEXColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDATSORNull()
		{
			return IsNull(tableImmo.DATSORColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDATSORNull()
		{
			base[tableImmo.DATSORColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsMTCESNull()
		{
			return IsNull(tableImmo.MTCESColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetMTCESNull()
		{
			base[tableImmo.MTCESColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsOBSNull()
		{
			return IsNull(tableImmo.OBSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetOBSNull()
		{
			base[tableImmo.OBSColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsIDNull()
		{
			return IsNull(tableImmo.IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetIDNull()
		{
			base[tableImmo.IDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserCNull()
		{
			return IsNull(tableImmo.UserCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserCNull()
		{
			base[tableImmo.UserCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateCNull()
		{
			return IsNull(tableImmo.DateCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateCNull()
		{
			base[tableImmo.DateCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserMNull()
		{
			return IsNull(tableImmo.UserMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserMNull()
		{
			base[tableImmo.UserMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateMNull()
		{
			return IsNull(tableImmo.DateMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateMNull()
		{
			base[tableImmo.DateMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCPTAMORNull()
		{
			return IsNull(tableImmo.CPTAMORColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCPTAMORNull()
		{
			base[tableImmo.CPTAMORColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCPTDOTNull()
		{
			return IsNull(tableImmo.CPTDOTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCPTDOTNull()
		{
			base[tableImmo.CPTDOTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCPTPRODNull()
		{
			return IsNull(tableImmo.CPTPRODColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCPTPRODNull()
		{
			base[tableImmo.CPTPRODColumn] = Convert.DBNull;
		}
	}

	public class JournauxRow : DataRow
	{
		private JournauxDataTable tableJournaux;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string JA
		{
			get
			{
				return (string)base[tableJournaux.JAColumn];
			}
			set
			{
				base[tableJournaux.JAColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIB
		{
			get
			{
				try
				{
					return (string)base[tableJournaux.LIBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIB' dans la table 'Journaux' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableJournaux.LIBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CPT
		{
			get
			{
				try
				{
					return (string)base[tableJournaux.CPTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CPT' dans la table 'Journaux' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableJournaux.CPTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CPTOT
		{
			get
			{
				try
				{
					return (string)base[tableJournaux.CPTOTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CPTOT' dans la table 'Journaux' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableJournaux.CPTOTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int ID
		{
			get
			{
				try
				{
					return (int)base[tableJournaux.IDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ID' dans la table 'Journaux' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableJournaux.IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserC
		{
			get
			{
				try
				{
					return (string)base[tableJournaux.UserCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserC' dans la table 'Journaux' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableJournaux.UserCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateC
		{
			get
			{
				try
				{
					return (DateTime)base[tableJournaux.DateCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateC' dans la table 'Journaux' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableJournaux.DateCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserM
		{
			get
			{
				try
				{
					return (string)base[tableJournaux.UserMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserM' dans la table 'Journaux' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableJournaux.UserMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateM
		{
			get
			{
				try
				{
					return (DateTime)base[tableJournaux.DateMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateM' dans la table 'Journaux' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableJournaux.DateMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIBAR
		{
			get
			{
				try
				{
					return (string)base[tableJournaux.LIBARColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIBAR' dans la table 'Journaux' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableJournaux.LIBARColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal JournauxRow(DataRowBuilder rb)
			: base(rb)
		{
			tableJournaux = (JournauxDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBNull()
		{
			return IsNull(tableJournaux.LIBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBNull()
		{
			base[tableJournaux.LIBColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCPTNull()
		{
			return IsNull(tableJournaux.CPTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCPTNull()
		{
			base[tableJournaux.CPTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCPTOTNull()
		{
			return IsNull(tableJournaux.CPTOTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCPTOTNull()
		{
			base[tableJournaux.CPTOTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsIDNull()
		{
			return IsNull(tableJournaux.IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetIDNull()
		{
			base[tableJournaux.IDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserCNull()
		{
			return IsNull(tableJournaux.UserCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserCNull()
		{
			base[tableJournaux.UserCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateCNull()
		{
			return IsNull(tableJournaux.DateCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateCNull()
		{
			base[tableJournaux.DateCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserMNull()
		{
			return IsNull(tableJournaux.UserMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserMNull()
		{
			base[tableJournaux.UserMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateMNull()
		{
			return IsNull(tableJournaux.DateMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateMNull()
		{
			base[tableJournaux.DateMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBARNull()
		{
			return IsNull(tableJournaux.LIBARColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBARNull()
		{
			base[tableJournaux.LIBARColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public PiecesRow[] GetPiecesRows()
		{
			if (base.Table.ChildRelations["JournauxPieces"] == null)
			{
				return new PiecesRow[0];
			}
			return (PiecesRow[])GetChildRows(base.Table.ChildRelations["JournauxPieces"]);
		}
	}

	public class LesEtatsRow : DataRow
	{
		private LesEtatsDataTable tableLesEtats;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int code
		{
			get
			{
				return (int)base[tableLesEtats.codeColumn];
			}
			set
			{
				base[tableLesEtats.codeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string nom
		{
			get
			{
				try
				{
					return (string)base[tableLesEtats.nomColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'nom' dans la table 'LesEtats' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableLesEtats.nomColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public byte[] profile
		{
			get
			{
				try
				{
					return (byte[])base[tableLesEtats.profileColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'profile' dans la table 'LesEtats' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableLesEtats.profileColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int papersize
		{
			get
			{
				try
				{
					return (int)base[tableLesEtats.papersizeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'papersize' dans la table 'LesEtats' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableLesEtats.papersizeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal LesEtatsRow(DataRowBuilder rb)
			: base(rb)
		{
			tableLesEtats = (LesEtatsDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsnomNull()
		{
			return IsNull(tableLesEtats.nomColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetnomNull()
		{
			base[tableLesEtats.nomColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsprofileNull()
		{
			return IsNull(tableLesEtats.profileColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetprofileNull()
		{
			base[tableLesEtats.profileColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IspapersizeNull()
		{
			return IsNull(tableLesEtats.papersizeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetpapersizeNull()
		{
			base[tableLesEtats.papersizeColumn] = Convert.DBNull;
		}
	}

	public class LesMoisRow : DataRow
	{
		private LesMoisDataTable tableLesMois;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public byte MOIS
		{
			get
			{
				return (byte)base[tableLesMois.MOISColumn];
			}
			set
			{
				base[tableLesMois.MOISColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIB
		{
			get
			{
				try
				{
					return (string)base[tableLesMois.LIBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIB' dans la table 'LesMois' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableLesMois.LIBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal LesMoisRow(DataRowBuilder rb)
			: base(rb)
		{
			tableLesMois = (LesMoisDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBNull()
		{
			return IsNull(tableLesMois.LIBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBNull()
		{
			base[tableLesMois.LIBColumn] = Convert.DBNull;
		}
	}

	public class TiersRow : DataRow
	{
		private TiersDataTable tableTiers;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UNI
		{
			get
			{
				return (string)base[tableTiers.UNIColumn];
			}
			set
			{
				base[tableTiers.UNIColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string TRS
		{
			get
			{
				return (string)base[tableTiers.TRSColumn];
			}
			set
			{
				base[tableTiers.TRSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIB
		{
			get
			{
				try
				{
					return (string)base[tableTiers.LIBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIB' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.LIBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string ACT
		{
			get
			{
				try
				{
					return (string)base[tableTiers.ACTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ACT' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.ACTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string ADR
		{
			get
			{
				try
				{
					return (string)base[tableTiers.ADRColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ADR' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.ADRColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CP
		{
			get
			{
				try
				{
					return (string)base[tableTiers.CPColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CP' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.CPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string RC
		{
			get
			{
				try
				{
					return (string)base[tableTiers.RCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'RC' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.RCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string NUMIF
		{
			get
			{
				try
				{
					return (string)base[tableTiers.NUMIFColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'NUMIF' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.NUMIFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string NUMAI
		{
			get
			{
				try
				{
					return (string)base[tableTiers.NUMAIColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'NUMAI' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.NUMAIColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int ID
		{
			get
			{
				try
				{
					return (int)base[tableTiers.IDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ID' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string TypeTiers
		{
			get
			{
				try
				{
					return (string)base[tableTiers.TypeTiersColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'TypeTiers' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.TypeTiersColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserC
		{
			get
			{
				try
				{
					return (string)base[tableTiers.UserCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserC' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.UserCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateC
		{
			get
			{
				try
				{
					return (DateTime)base[tableTiers.DateCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateC' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.DateCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserM
		{
			get
			{
				try
				{
					return (string)base[tableTiers.UserMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserM' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.UserMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateM
		{
			get
			{
				try
				{
					return (DateTime)base[tableTiers.DateMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateM' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.DateMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CF
		{
			get
			{
				try
				{
					return (string)base[tableTiers.CFColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CF' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.CFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string TEL
		{
			get
			{
				try
				{
					return (string)base[tableTiers.TELColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'TEL' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.TELColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string FAX
		{
			get
			{
				try
				{
					return (string)base[tableTiers.FAXColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'FAX' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.FAXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string PORT
		{
			get
			{
				try
				{
					return (string)base[tableTiers.PORTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'PORT' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.PORTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string MAIL
		{
			get
			{
				try
				{
					return (string)base[tableTiers.MAILColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'MAIL' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.MAILColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string NIS
		{
			get
			{
				try
				{
					return (string)base[tableTiers.NISColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'NIS' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.NISColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIBAR
		{
			get
			{
				try
				{
					return (string)base[tableTiers.LIBARColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIBAR' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.LIBARColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string ADRAR
		{
			get
			{
				try
				{
					return (string)base[tableTiers.ADRARColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ADRAR' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.ADRARColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string ACTAR
		{
			get
			{
				try
				{
					return (string)base[tableTiers.ACTARColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ACTAR' dans la table 'Tiers' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableTiers.ACTARColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DossiersRow DossiersRow
		{
			get
			{
				return (DossiersRow)GetParentRow(base.Table.ParentRelations["DossiersTiers"]);
			}
			set
			{
				SetParentRow(value, base.Table.ParentRelations["DossiersTiers"]);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal TiersRow(DataRowBuilder rb)
			: base(rb)
		{
			tableTiers = (TiersDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBNull()
		{
			return IsNull(tableTiers.LIBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBNull()
		{
			base[tableTiers.LIBColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsACTNull()
		{
			return IsNull(tableTiers.ACTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetACTNull()
		{
			base[tableTiers.ACTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsADRNull()
		{
			return IsNull(tableTiers.ADRColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetADRNull()
		{
			base[tableTiers.ADRColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCPNull()
		{
			return IsNull(tableTiers.CPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCPNull()
		{
			base[tableTiers.CPColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsRCNull()
		{
			return IsNull(tableTiers.RCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetRCNull()
		{
			base[tableTiers.RCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsNUMIFNull()
		{
			return IsNull(tableTiers.NUMIFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetNUMIFNull()
		{
			base[tableTiers.NUMIFColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsNUMAINull()
		{
			return IsNull(tableTiers.NUMAIColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetNUMAINull()
		{
			base[tableTiers.NUMAIColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsIDNull()
		{
			return IsNull(tableTiers.IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetIDNull()
		{
			base[tableTiers.IDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsTypeTiersNull()
		{
			return IsNull(tableTiers.TypeTiersColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetTypeTiersNull()
		{
			base[tableTiers.TypeTiersColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserCNull()
		{
			return IsNull(tableTiers.UserCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserCNull()
		{
			base[tableTiers.UserCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateCNull()
		{
			return IsNull(tableTiers.DateCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateCNull()
		{
			base[tableTiers.DateCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserMNull()
		{
			return IsNull(tableTiers.UserMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserMNull()
		{
			base[tableTiers.UserMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateMNull()
		{
			return IsNull(tableTiers.DateMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateMNull()
		{
			base[tableTiers.DateMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCFNull()
		{
			return IsNull(tableTiers.CFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCFNull()
		{
			base[tableTiers.CFColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsTELNull()
		{
			return IsNull(tableTiers.TELColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetTELNull()
		{
			base[tableTiers.TELColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsFAXNull()
		{
			return IsNull(tableTiers.FAXColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetFAXNull()
		{
			base[tableTiers.FAXColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsPORTNull()
		{
			return IsNull(tableTiers.PORTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetPORTNull()
		{
			base[tableTiers.PORTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsMAILNull()
		{
			return IsNull(tableTiers.MAILColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetMAILNull()
		{
			base[tableTiers.MAILColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsNISNull()
		{
			return IsNull(tableTiers.NISColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetNISNull()
		{
			base[tableTiers.NISColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBARNull()
		{
			return IsNull(tableTiers.LIBARColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBARNull()
		{
			base[tableTiers.LIBARColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsADRARNull()
		{
			return IsNull(tableTiers.ADRARColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetADRARNull()
		{
			base[tableTiers.ADRARColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsACTARNull()
		{
			return IsNull(tableTiers.ACTARColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetACTARNull()
		{
			base[tableTiers.ACTARColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EcrituresRow[] GetEcrituresRows()
		{
			if (base.Table.ChildRelations["TiersEcritures"] == null)
			{
				return new EcrituresRow[0];
			}
			return (EcrituresRow[])GetChildRows(base.Table.ChildRelations["TiersEcritures"]);
		}
	}

	public class VillesRow : DataRow
	{
		private VillesDataTable tableVilles;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CP
		{
			get
			{
				return (string)base[tableVilles.CPColumn];
			}
			set
			{
				base[tableVilles.CPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIB
		{
			get
			{
				try
				{
					return (string)base[tableVilles.LIBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIB' dans la table 'Villes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableVilles.LIBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserC
		{
			get
			{
				try
				{
					return (string)base[tableVilles.UserCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserC' dans la table 'Villes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableVilles.UserCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateC
		{
			get
			{
				try
				{
					return (DateTime)base[tableVilles.DateCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateC' dans la table 'Villes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableVilles.DateCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserM
		{
			get
			{
				try
				{
					return (string)base[tableVilles.UserMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserM' dans la table 'Villes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableVilles.UserMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateM
		{
			get
			{
				try
				{
					return (DateTime)base[tableVilles.DateMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateM' dans la table 'Villes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableVilles.DateMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIBAR
		{
			get
			{
				try
				{
					return (string)base[tableVilles.LIBARColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIBAR' dans la table 'Villes' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableVilles.LIBARColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal VillesRow(DataRowBuilder rb)
			: base(rb)
		{
			tableVilles = (VillesDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBNull()
		{
			return IsNull(tableVilles.LIBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBNull()
		{
			base[tableVilles.LIBColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserCNull()
		{
			return IsNull(tableVilles.UserCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserCNull()
		{
			base[tableVilles.UserCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateCNull()
		{
			return IsNull(tableVilles.DateCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateCNull()
		{
			base[tableVilles.DateCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserMNull()
		{
			return IsNull(tableVilles.UserMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserMNull()
		{
			base[tableVilles.UserMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateMNull()
		{
			return IsNull(tableVilles.DateMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateMNull()
		{
			base[tableVilles.DateMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBARNull()
		{
			return IsNull(tableVilles.LIBARColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBARNull()
		{
			base[tableVilles.LIBARColumn] = Convert.DBNull;
		}
	}

	public class Ecritures_tRow : DataRow
	{
		private Ecritures_tDataTable tableEcritures_t;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UNI
		{
			get
			{
				try
				{
					return (string)base[tableEcritures_t.UNIColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UNI' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.UNIColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int Exercice
		{
			get
			{
				try
				{
					return (int)base[tableEcritures_t.ExerciceColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'Exercice' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.ExerciceColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string JA
		{
			get
			{
				try
				{
					return (string)base[tableEcritures_t.JAColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'JA' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.JAColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string NOP
		{
			get
			{
				try
				{
					return (string)base[tableEcritures_t.NOPColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'NOP' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.NOPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int LIG
		{
			get
			{
				try
				{
					return (int)base[tableEcritures_t.LIGColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIG' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.LIGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CPT
		{
			get
			{
				try
				{
					return (string)base[tableEcritures_t.CPTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CPT' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.CPTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string TRS
		{
			get
			{
				try
				{
					return (string)base[tableEcritures_t.TRSColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'TRS' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.TRSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DAT
		{
			get
			{
				try
				{
					return (DateTime)base[tableEcritures_t.DATColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DAT' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.DATColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIB
		{
			get
			{
				try
				{
					return (string)base[tableEcritures_t.LIBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIB' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.LIBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public decimal DEB
		{
			get
			{
				try
				{
					return (decimal)base[tableEcritures_t.DEBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DEB' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.DEBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public decimal CRE
		{
			get
			{
				try
				{
					return (decimal)base[tableEcritures_t.CREColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CRE' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.CREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string PTG
		{
			get
			{
				try
				{
					return (string)base[tableEcritures_t.PTGColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'PTG' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.PTGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string PTGX
		{
			get
			{
				try
				{
					return (string)base[tableEcritures_t.PTGXColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'PTGX' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.PTGXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string RAP
		{
			get
			{
				try
				{
					return (string)base[tableEcritures_t.RAPColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'RAP' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.RAPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public byte Jour
		{
			get
			{
				try
				{
					return (byte)base[tableEcritures_t.JourColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'Jour' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.JourColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserC
		{
			get
			{
				try
				{
					return (string)base[tableEcritures_t.UserCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserC' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.UserCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateC
		{
			get
			{
				try
				{
					return (DateTime)base[tableEcritures_t.DateCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateC' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.DateCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserM
		{
			get
			{
				try
				{
					return (string)base[tableEcritures_t.UserMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserM' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.UserMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateM
		{
			get
			{
				try
				{
					return (DateTime)base[tableEcritures_t.DateMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateM' dans la table 'Ecritures_t' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures_t.DateMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int ID
		{
			get
			{
				return (int)base[tableEcritures_t.IDColumn];
			}
			set
			{
				base[tableEcritures_t.IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Ecritures_tRow(DataRowBuilder rb)
			: base(rb)
		{
			tableEcritures_t = (Ecritures_tDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUNINull()
		{
			return IsNull(tableEcritures_t.UNIColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUNINull()
		{
			base[tableEcritures_t.UNIColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsExerciceNull()
		{
			return IsNull(tableEcritures_t.ExerciceColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetExerciceNull()
		{
			base[tableEcritures_t.ExerciceColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsJANull()
		{
			return IsNull(tableEcritures_t.JAColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetJANull()
		{
			base[tableEcritures_t.JAColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsNOPNull()
		{
			return IsNull(tableEcritures_t.NOPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetNOPNull()
		{
			base[tableEcritures_t.NOPColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIGNull()
		{
			return IsNull(tableEcritures_t.LIGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIGNull()
		{
			base[tableEcritures_t.LIGColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCPTNull()
		{
			return IsNull(tableEcritures_t.CPTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCPTNull()
		{
			base[tableEcritures_t.CPTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsTRSNull()
		{
			return IsNull(tableEcritures_t.TRSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetTRSNull()
		{
			base[tableEcritures_t.TRSColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDATNull()
		{
			return IsNull(tableEcritures_t.DATColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDATNull()
		{
			base[tableEcritures_t.DATColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBNull()
		{
			return IsNull(tableEcritures_t.LIBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBNull()
		{
			base[tableEcritures_t.LIBColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDEBNull()
		{
			return IsNull(tableEcritures_t.DEBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDEBNull()
		{
			base[tableEcritures_t.DEBColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCRENull()
		{
			return IsNull(tableEcritures_t.CREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCRENull()
		{
			base[tableEcritures_t.CREColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsPTGNull()
		{
			return IsNull(tableEcritures_t.PTGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetPTGNull()
		{
			base[tableEcritures_t.PTGColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsPTGXNull()
		{
			return IsNull(tableEcritures_t.PTGXColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetPTGXNull()
		{
			base[tableEcritures_t.PTGXColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsRAPNull()
		{
			return IsNull(tableEcritures_t.RAPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetRAPNull()
		{
			base[tableEcritures_t.RAPColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsJourNull()
		{
			return IsNull(tableEcritures_t.JourColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetJourNull()
		{
			base[tableEcritures_t.JourColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserCNull()
		{
			return IsNull(tableEcritures_t.UserCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserCNull()
		{
			base[tableEcritures_t.UserCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateCNull()
		{
			return IsNull(tableEcritures_t.DateCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateCNull()
		{
			base[tableEcritures_t.DateCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserMNull()
		{
			return IsNull(tableEcritures_t.UserMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserMNull()
		{
			base[tableEcritures_t.UserMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateMNull()
		{
			return IsNull(tableEcritures_t.DateMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateMNull()
		{
			base[tableEcritures_t.DateMColumn] = Convert.DBNull;
		}
	}

	public class EcrituresRow : DataRow
	{
		private EcrituresDataTable tableEcritures;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UNI
		{
			get
			{
				try
				{
					return (string)base[tableEcritures.UNIColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UNI' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.UNIColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int Exercice
		{
			get
			{
				try
				{
					return (int)base[tableEcritures.ExerciceColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'Exercice' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.ExerciceColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string JA
		{
			get
			{
				try
				{
					return (string)base[tableEcritures.JAColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'JA' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.JAColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int NOP
		{
			get
			{
				try
				{
					return (int)base[tableEcritures.NOPColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'NOP' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.NOPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int LIG
		{
			get
			{
				try
				{
					return (int)base[tableEcritures.LIGColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIG' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.LIGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string CPT
		{
			get
			{
				try
				{
					return (string)base[tableEcritures.CPTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CPT' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.CPTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string TRS
		{
			get
			{
				try
				{
					return (string)base[tableEcritures.TRSColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'TRS' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.TRSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DAT
		{
			get
			{
				try
				{
					return (DateTime)base[tableEcritures.DATColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DAT' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.DATColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIB
		{
			get
			{
				try
				{
					return (string)base[tableEcritures.LIBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIB' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.LIBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public decimal DEB
		{
			get
			{
				try
				{
					return (decimal)base[tableEcritures.DEBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DEB' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.DEBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public decimal CRE
		{
			get
			{
				try
				{
					return (decimal)base[tableEcritures.CREColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'CRE' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.CREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string PTG
		{
			get
			{
				try
				{
					return (string)base[tableEcritures.PTGColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'PTG' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.PTGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string PTGX
		{
			get
			{
				try
				{
					return (string)base[tableEcritures.PTGXColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'PTGX' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.PTGXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string RAP
		{
			get
			{
				try
				{
					return (string)base[tableEcritures.RAPColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'RAP' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.RAPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int ID
		{
			get
			{
				try
				{
					return (int)base[tableEcritures.IDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ID' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public byte Jour
		{
			get
			{
				try
				{
					return (byte)base[tableEcritures.JourColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'Jour' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.JourColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserC
		{
			get
			{
				try
				{
					return (string)base[tableEcritures.UserCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserC' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.UserCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateC
		{
			get
			{
				try
				{
					return (DateTime)base[tableEcritures.DateCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateC' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.DateCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserM
		{
			get
			{
				try
				{
					return (string)base[tableEcritures.UserMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserM' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.UserMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateM
		{
			get
			{
				try
				{
					return (DateTime)base[tableEcritures.DateMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateM' dans la table 'Ecritures' est DBNull.", innerException);
				}
			}
			set
			{
				base[tableEcritures.DateMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public ComptesRow ComptesRow
		{
			get
			{
				return (ComptesRow)GetParentRow(base.Table.ParentRelations["ComptesEcritures"]);
			}
			set
			{
				SetParentRow(value, base.Table.ParentRelations["ComptesEcritures"]);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public TiersRow TiersRowParent
		{
			get
			{
				return (TiersRow)GetParentRow(base.Table.ParentRelations["TiersEcritures"]);
			}
			set
			{
				SetParentRow(value, base.Table.ParentRelations["TiersEcritures"]);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public PiecesRow PiecesRowParent
		{
			get
			{
				return (PiecesRow)GetParentRow(base.Table.ParentRelations["PiecesEcritures"]);
			}
			set
			{
				SetParentRow(value, base.Table.ParentRelations["PiecesEcritures"]);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal EcrituresRow(DataRowBuilder rb)
			: base(rb)
		{
			tableEcritures = (EcrituresDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUNINull()
		{
			return IsNull(tableEcritures.UNIColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUNINull()
		{
			base[tableEcritures.UNIColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsExerciceNull()
		{
			return IsNull(tableEcritures.ExerciceColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetExerciceNull()
		{
			base[tableEcritures.ExerciceColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsJANull()
		{
			return IsNull(tableEcritures.JAColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetJANull()
		{
			base[tableEcritures.JAColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsNOPNull()
		{
			return IsNull(tableEcritures.NOPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetNOPNull()
		{
			base[tableEcritures.NOPColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIGNull()
		{
			return IsNull(tableEcritures.LIGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIGNull()
		{
			base[tableEcritures.LIGColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCPTNull()
		{
			return IsNull(tableEcritures.CPTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCPTNull()
		{
			base[tableEcritures.CPTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsTRSNull()
		{
			return IsNull(tableEcritures.TRSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetTRSNull()
		{
			base[tableEcritures.TRSColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDATNull()
		{
			return IsNull(tableEcritures.DATColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDATNull()
		{
			base[tableEcritures.DATColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBNull()
		{
			return IsNull(tableEcritures.LIBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBNull()
		{
			base[tableEcritures.LIBColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDEBNull()
		{
			return IsNull(tableEcritures.DEBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDEBNull()
		{
			base[tableEcritures.DEBColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsCRENull()
		{
			return IsNull(tableEcritures.CREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetCRENull()
		{
			base[tableEcritures.CREColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsPTGNull()
		{
			return IsNull(tableEcritures.PTGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetPTGNull()
		{
			base[tableEcritures.PTGColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsPTGXNull()
		{
			return IsNull(tableEcritures.PTGXColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetPTGXNull()
		{
			base[tableEcritures.PTGXColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsRAPNull()
		{
			return IsNull(tableEcritures.RAPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetRAPNull()
		{
			base[tableEcritures.RAPColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsIDNull()
		{
			return IsNull(tableEcritures.IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetIDNull()
		{
			base[tableEcritures.IDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsJourNull()
		{
			return IsNull(tableEcritures.JourColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetJourNull()
		{
			base[tableEcritures.JourColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserCNull()
		{
			return IsNull(tableEcritures.UserCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserCNull()
		{
			base[tableEcritures.UserCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateCNull()
		{
			return IsNull(tableEcritures.DateCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateCNull()
		{
			base[tableEcritures.DateCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserMNull()
		{
			return IsNull(tableEcritures.UserMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserMNull()
		{
			base[tableEcritures.UserMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateMNull()
		{
			return IsNull(tableEcritures.DateMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateMNull()
		{
			base[tableEcritures.DateMColumn] = Convert.DBNull;
		}
	}

	public class PiecesRow : DataRow
	{
		private PiecesDataTable tablePieces;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UNI
		{
			get
			{
				return (string)base[tablePieces.UNIColumn];
			}
			set
			{
				base[tablePieces.UNIColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int Exercice
		{
			get
			{
				return (int)base[tablePieces.ExerciceColumn];
			}
			set
			{
				base[tablePieces.ExerciceColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string JA
		{
			get
			{
				return (string)base[tablePieces.JAColumn];
			}
			set
			{
				base[tablePieces.JAColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int NOP
		{
			get
			{
				return (int)base[tablePieces.NOPColumn];
			}
			set
			{
				base[tablePieces.NOPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime Dat
		{
			get
			{
				try
				{
					return (DateTime)base[tablePieces.DatColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'Dat' dans la table 'Pieces' est DBNull.", innerException);
				}
			}
			set
			{
				base[tablePieces.DatColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public byte Mois
		{
			get
			{
				try
				{
					return (byte)base[tablePieces.MoisColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'Mois' dans la table 'Pieces' est DBNull.", innerException);
				}
			}
			set
			{
				base[tablePieces.MoisColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIB
		{
			get
			{
				try
				{
					return (string)base[tablePieces.LIBColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIB' dans la table 'Pieces' est DBNull.", innerException);
				}
			}
			set
			{
				base[tablePieces.LIBColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int ID
		{
			get
			{
				try
				{
					return (int)base[tablePieces.IDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'ID' dans la table 'Pieces' est DBNull.", innerException);
				}
			}
			set
			{
				base[tablePieces.IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserC
		{
			get
			{
				try
				{
					return (string)base[tablePieces.UserCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserC' dans la table 'Pieces' est DBNull.", innerException);
				}
			}
			set
			{
				base[tablePieces.UserCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateC
		{
			get
			{
				try
				{
					return (DateTime)base[tablePieces.DateCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateC' dans la table 'Pieces' est DBNull.", innerException);
				}
			}
			set
			{
				base[tablePieces.DateCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string UserM
		{
			get
			{
				try
				{
					return (string)base[tablePieces.UserMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'UserM' dans la table 'Pieces' est DBNull.", innerException);
				}
			}
			set
			{
				base[tablePieces.UserMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DateTime DateM
		{
			get
			{
				try
				{
					return (DateTime)base[tablePieces.DateMColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'DateM' dans la table 'Pieces' est DBNull.", innerException);
				}
			}
			set
			{
				base[tablePieces.DateMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string LIBAR
		{
			get
			{
				try
				{
					return (string)base[tablePieces.LIBARColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("La valeur pour la colonne 'LIBAR' dans la table 'Pieces' est DBNull.", innerException);
				}
			}
			set
			{
				base[tablePieces.LIBARColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DossiersRow DossiersRow
		{
			get
			{
				return (DossiersRow)GetParentRow(base.Table.ParentRelations["DossiersPieces"]);
			}
			set
			{
				SetParentRow(value, base.Table.ParentRelations["DossiersPieces"]);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public JournauxRow JournauxRow
		{
			get
			{
				return (JournauxRow)GetParentRow(base.Table.ParentRelations["JournauxPieces"]);
			}
			set
			{
				SetParentRow(value, base.Table.ParentRelations["JournauxPieces"]);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal PiecesRow(DataRowBuilder rb)
			: base(rb)
		{
			tablePieces = (PiecesDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDatNull()
		{
			return IsNull(tablePieces.DatColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDatNull()
		{
			base[tablePieces.DatColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsMoisNull()
		{
			return IsNull(tablePieces.MoisColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetMoisNull()
		{
			base[tablePieces.MoisColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBNull()
		{
			return IsNull(tablePieces.LIBColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBNull()
		{
			base[tablePieces.LIBColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsIDNull()
		{
			return IsNull(tablePieces.IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetIDNull()
		{
			base[tablePieces.IDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserCNull()
		{
			return IsNull(tablePieces.UserCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserCNull()
		{
			base[tablePieces.UserCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateCNull()
		{
			return IsNull(tablePieces.DateCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateCNull()
		{
			base[tablePieces.DateCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsUserMNull()
		{
			return IsNull(tablePieces.UserMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetUserMNull()
		{
			base[tablePieces.UserMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsDateMNull()
		{
			return IsNull(tablePieces.DateMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetDateMNull()
		{
			base[tablePieces.DateMColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool IsLIBARNull()
		{
			return IsNull(tablePieces.LIBARColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void SetLIBARNull()
		{
			base[tablePieces.LIBARColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EcrituresRow[] GetEcrituresRows()
		{
			if (base.Table.ChildRelations["PiecesEcritures"] == null)
			{
				return new EcrituresRow[0];
			}
			return (EcrituresRow[])GetChildRows(base.Table.ChildRelations["PiecesEcritures"]);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class BalanceRowChangeEvent : EventArgs
	{
		private BalanceRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public BalanceRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public BalanceRowChangeEvent(BalanceRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class ComptesRowChangeEvent : EventArgs
	{
		private ComptesRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public ComptesRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public ComptesRowChangeEvent(ComptesRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class DossiersRowChangeEvent : EventArgs
	{
		private DossiersRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DossiersRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DossiersRowChangeEvent(DossiersRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class Ecritures00RowChangeEvent : EventArgs
	{
		private Ecritures00Row eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ecritures00Row Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ecritures00RowChangeEvent(Ecritures00Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class EcrtriRowChangeEvent : EventArgs
	{
		private EcrtriRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EcrtriRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EcrtriRowChangeEvent(EcrtriRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class EtatsRowChangeEvent : EventArgs
	{
		private EtatsRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EtatsRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EtatsRowChangeEvent(EtatsRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class ImmoRowChangeEvent : EventArgs
	{
		private ImmoRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public ImmoRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public ImmoRowChangeEvent(ImmoRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class JournauxRowChangeEvent : EventArgs
	{
		private JournauxRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public JournauxRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public JournauxRowChangeEvent(JournauxRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class LesEtatsRowChangeEvent : EventArgs
	{
		private LesEtatsRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public LesEtatsRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public LesEtatsRowChangeEvent(LesEtatsRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class LesMoisRowChangeEvent : EventArgs
	{
		private LesMoisRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public LesMoisRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public LesMoisRowChangeEvent(LesMoisRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class TiersRowChangeEvent : EventArgs
	{
		private TiersRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public TiersRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public TiersRowChangeEvent(TiersRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class VillesRowChangeEvent : EventArgs
	{
		private VillesRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public VillesRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public VillesRowChangeEvent(VillesRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class Ecritures_tRowChangeEvent : EventArgs
	{
		private Ecritures_tRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ecritures_tRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ecritures_tRowChangeEvent(Ecritures_tRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class EcrituresRowChangeEvent : EventArgs
	{
		private EcrituresRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EcrituresRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public EcrituresRowChangeEvent(EcrituresRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class PiecesRowChangeEvent : EventArgs
	{
		private PiecesRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public PiecesRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public PiecesRowChangeEvent(PiecesRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private BalanceDataTable tableBalance;

	private ComptesDataTable tableComptes;

	private DossiersDataTable tableDossiers;

	private Ecritures00DataTable tableEcritures00;

	private EcrtriDataTable tableEcrtri;

	private EtatsDataTable tableEtats;

	private ImmoDataTable tableImmo;

	private JournauxDataTable tableJournaux;

	private LesEtatsDataTable tableLesEtats;

	private LesMoisDataTable tableLesMois;

	private TiersDataTable tableTiers;

	private VillesDataTable tableVilles;

	private Ecritures_tDataTable tableEcritures_t;

	private EcrituresDataTable tableEcritures;

	private PiecesDataTable tablePieces;

	private DataRelation relationDossiersTiers;

	private DataRelation relationComptesEcritures;

	private DataRelation relationTiersEcritures;

	private DataRelation relationDossiersPieces;

	private DataRelation relationJournauxPieces;

	private DataRelation relationPiecesEcritures;

	private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public BalanceDataTable Balance => tableBalance;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ComptesDataTable Comptes => tableComptes;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DossiersDataTable Dossiers => tableDossiers;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Ecritures00DataTable Ecritures00 => tableEcritures00;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public EcrtriDataTable Ecrtri => tableEcrtri;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public EtatsDataTable Etats => tableEtats;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ImmoDataTable Immo => tableImmo;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public JournauxDataTable Journaux => tableJournaux;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public LesEtatsDataTable LesEtats => tableLesEtats;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public LesMoisDataTable LesMois => tableLesMois;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public TiersDataTable Tiers => tableTiers;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public VillesDataTable Villes => tableVilles;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Ecritures_tDataTable Ecritures_t => tableEcritures_t;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public EcrituresDataTable Ecritures => tableEcritures;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public PiecesDataTable Pieces => tablePieces;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataTableCollection Tables => base.Tables;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataRelationCollection Relations => base.Relations;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public DataSet1()
	{
		BeginInit();
		InitClass();
		CollectionChangeEventHandler schemaChangedHandler = SchemaChanged;
		base.Tables.CollectionChanged += schemaChangedHandler;
		base.Relations.CollectionChanged += schemaChangedHandler;
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected DataSet1(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		if (IsBinarySerialized(info, context))
		{
			InitVars(initTable: false);
			CollectionChangeEventHandler schemaChangedHandler1 = SchemaChanged;
			Tables.CollectionChanged += schemaChangedHandler1;
			Relations.CollectionChanged += schemaChangedHandler1;
			return;
		}
		string strSchema = (string)info.GetValue("XmlSchema", typeof(string));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet ds = new DataSet();
			ds.ReadXmlSchema(new XmlTextReader(new StringReader(strSchema)));
			if (ds.Tables["Balance"] != null)
			{
				base.Tables.Add(new BalanceDataTable(ds.Tables["Balance"]));
			}
			if (ds.Tables["Comptes"] != null)
			{
				base.Tables.Add(new ComptesDataTable(ds.Tables["Comptes"]));
			}
			if (ds.Tables["Dossiers"] != null)
			{
				base.Tables.Add(new DossiersDataTable(ds.Tables["Dossiers"]));
			}
			if (ds.Tables["Ecritures00"] != null)
			{
				base.Tables.Add(new Ecritures00DataTable(ds.Tables["Ecritures00"]));
			}
			if (ds.Tables["Ecrtri"] != null)
			{
				base.Tables.Add(new EcrtriDataTable(ds.Tables["Ecrtri"]));
			}
			if (ds.Tables["Etats"] != null)
			{
				base.Tables.Add(new EtatsDataTable(ds.Tables["Etats"]));
			}
			if (ds.Tables["Immo"] != null)
			{
				base.Tables.Add(new ImmoDataTable(ds.Tables["Immo"]));
			}
			if (ds.Tables["Journaux"] != null)
			{
				base.Tables.Add(new JournauxDataTable(ds.Tables["Journaux"]));
			}
			if (ds.Tables["LesEtats"] != null)
			{
				base.Tables.Add(new LesEtatsDataTable(ds.Tables["LesEtats"]));
			}
			if (ds.Tables["LesMois"] != null)
			{
				base.Tables.Add(new LesMoisDataTable(ds.Tables["LesMois"]));
			}
			if (ds.Tables["Tiers"] != null)
			{
				base.Tables.Add(new TiersDataTable(ds.Tables["Tiers"]));
			}
			if (ds.Tables["Villes"] != null)
			{
				base.Tables.Add(new VillesDataTable(ds.Tables["Villes"]));
			}
			if (ds.Tables["Ecritures_t"] != null)
			{
				base.Tables.Add(new Ecritures_tDataTable(ds.Tables["Ecritures_t"]));
			}
			if (ds.Tables["Ecritures"] != null)
			{
				base.Tables.Add(new EcrituresDataTable(ds.Tables["Ecritures"]));
			}
			if (ds.Tables["Pieces"] != null)
			{
				base.Tables.Add(new PiecesDataTable(ds.Tables["Pieces"]));
			}
			base.DataSetName = ds.DataSetName;
			base.Prefix = ds.Prefix;
			base.Namespace = ds.Namespace;
			base.Locale = ds.Locale;
			base.CaseSensitive = ds.CaseSensitive;
			base.EnforceConstraints = ds.EnforceConstraints;
			Merge(ds, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(strSchema)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler schemaChangedHandler2 = SchemaChanged;
		base.Tables.CollectionChanged += schemaChangedHandler2;
		Relations.CollectionChanged += schemaChangedHandler2;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		InitClass();
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public override DataSet Clone()
	{
		DataSet1 obj = (DataSet1)base.Clone();
		obj.InitVars();
		obj.SchemaSerializationMode = SchemaSerializationMode;
		return obj;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet ds = new DataSet();
			ds.ReadXml(reader);
			if (ds.Tables["Balance"] != null)
			{
				base.Tables.Add(new BalanceDataTable(ds.Tables["Balance"]));
			}
			if (ds.Tables["Comptes"] != null)
			{
				base.Tables.Add(new ComptesDataTable(ds.Tables["Comptes"]));
			}
			if (ds.Tables["Dossiers"] != null)
			{
				base.Tables.Add(new DossiersDataTable(ds.Tables["Dossiers"]));
			}
			if (ds.Tables["Ecritures00"] != null)
			{
				base.Tables.Add(new Ecritures00DataTable(ds.Tables["Ecritures00"]));
			}
			if (ds.Tables["Ecrtri"] != null)
			{
				base.Tables.Add(new EcrtriDataTable(ds.Tables["Ecrtri"]));
			}
			if (ds.Tables["Etats"] != null)
			{
				base.Tables.Add(new EtatsDataTable(ds.Tables["Etats"]));
			}
			if (ds.Tables["Immo"] != null)
			{
				base.Tables.Add(new ImmoDataTable(ds.Tables["Immo"]));
			}
			if (ds.Tables["Journaux"] != null)
			{
				base.Tables.Add(new JournauxDataTable(ds.Tables["Journaux"]));
			}
			if (ds.Tables["LesEtats"] != null)
			{
				base.Tables.Add(new LesEtatsDataTable(ds.Tables["LesEtats"]));
			}
			if (ds.Tables["LesMois"] != null)
			{
				base.Tables.Add(new LesMoisDataTable(ds.Tables["LesMois"]));
			}
			if (ds.Tables["Tiers"] != null)
			{
				base.Tables.Add(new TiersDataTable(ds.Tables["Tiers"]));
			}
			if (ds.Tables["Villes"] != null)
			{
				base.Tables.Add(new VillesDataTable(ds.Tables["Villes"]));
			}
			if (ds.Tables["Ecritures_t"] != null)
			{
				base.Tables.Add(new Ecritures_tDataTable(ds.Tables["Ecritures_t"]));
			}
			if (ds.Tables["Ecritures"] != null)
			{
				base.Tables.Add(new EcrituresDataTable(ds.Tables["Ecritures"]));
			}
			if (ds.Tables["Pieces"] != null)
			{
				base.Tables.Add(new PiecesDataTable(ds.Tables["Pieces"]));
			}
			base.DataSetName = ds.DataSetName;
			base.Prefix = ds.Prefix;
			base.Namespace = ds.Namespace;
			base.Locale = ds.Locale;
			base.CaseSensitive = ds.CaseSensitive;
			base.EnforceConstraints = ds.EnforceConstraints;
			Merge(ds, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXml(reader);
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream stream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(stream, null));
		stream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(stream), null);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal void InitVars(bool initTable)
	{
		tableBalance = (BalanceDataTable)base.Tables["Balance"];
		if (initTable && tableBalance != null)
		{
			tableBalance.InitVars();
		}
		tableComptes = (ComptesDataTable)base.Tables["Comptes"];
		if (initTable && tableComptes != null)
		{
			tableComptes.InitVars();
		}
		tableDossiers = (DossiersDataTable)base.Tables["Dossiers"];
		if (initTable && tableDossiers != null)
		{
			tableDossiers.InitVars();
		}
		tableEcritures00 = (Ecritures00DataTable)base.Tables["Ecritures00"];
		if (initTable && tableEcritures00 != null)
		{
			tableEcritures00.InitVars();
		}
		tableEcrtri = (EcrtriDataTable)base.Tables["Ecrtri"];
		if (initTable && tableEcrtri != null)
		{
			tableEcrtri.InitVars();
		}
		tableEtats = (EtatsDataTable)base.Tables["Etats"];
		if (initTable && tableEtats != null)
		{
			tableEtats.InitVars();
		}
		tableImmo = (ImmoDataTable)base.Tables["Immo"];
		if (initTable && tableImmo != null)
		{
			tableImmo.InitVars();
		}
		tableJournaux = (JournauxDataTable)base.Tables["Journaux"];
		if (initTable && tableJournaux != null)
		{
			tableJournaux.InitVars();
		}
		tableLesEtats = (LesEtatsDataTable)base.Tables["LesEtats"];
		if (initTable && tableLesEtats != null)
		{
			tableLesEtats.InitVars();
		}
		tableLesMois = (LesMoisDataTable)base.Tables["LesMois"];
		if (initTable && tableLesMois != null)
		{
			tableLesMois.InitVars();
		}
		tableTiers = (TiersDataTable)base.Tables["Tiers"];
		if (initTable && tableTiers != null)
		{
			tableTiers.InitVars();
		}
		tableVilles = (VillesDataTable)base.Tables["Villes"];
		if (initTable && tableVilles != null)
		{
			tableVilles.InitVars();
		}
		tableEcritures_t = (Ecritures_tDataTable)base.Tables["Ecritures_t"];
		if (initTable && tableEcritures_t != null)
		{
			tableEcritures_t.InitVars();
		}
		tableEcritures = (EcrituresDataTable)base.Tables["Ecritures"];
		if (initTable && tableEcritures != null)
		{
			tableEcritures.InitVars();
		}
		tablePieces = (PiecesDataTable)base.Tables["Pieces"];
		if (initTable && tablePieces != null)
		{
			tablePieces.InitVars();
		}
		relationDossiersTiers = Relations["DossiersTiers"];
		relationComptesEcritures = Relations["ComptesEcritures"];
		relationTiersEcritures = Relations["TiersEcritures"];
		relationDossiersPieces = Relations["DossiersPieces"];
		relationJournauxPieces = Relations["JournauxPieces"];
		relationPiecesEcritures = Relations["PiecesEcritures"];
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void InitClass()
	{
		base.DataSetName = "DataSet1";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/DataSet1.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableBalance = new BalanceDataTable();
		base.Tables.Add(tableBalance);
		tableComptes = new ComptesDataTable();
		base.Tables.Add(tableComptes);
		tableDossiers = new DossiersDataTable();
		base.Tables.Add(tableDossiers);
		tableEcritures00 = new Ecritures00DataTable();
		base.Tables.Add(tableEcritures00);
		tableEcrtri = new EcrtriDataTable();
		base.Tables.Add(tableEcrtri);
		tableEtats = new EtatsDataTable();
		base.Tables.Add(tableEtats);
		tableImmo = new ImmoDataTable();
		base.Tables.Add(tableImmo);
		tableJournaux = new JournauxDataTable();
		base.Tables.Add(tableJournaux);
		tableLesEtats = new LesEtatsDataTable();
		base.Tables.Add(tableLesEtats);
		tableLesMois = new LesMoisDataTable();
		base.Tables.Add(tableLesMois);
		tableTiers = new TiersDataTable();
		base.Tables.Add(tableTiers);
		tableVilles = new VillesDataTable();
		base.Tables.Add(tableVilles);
		tableEcritures_t = new Ecritures_tDataTable();
		base.Tables.Add(tableEcritures_t);
		tableEcritures = new EcrituresDataTable();
		base.Tables.Add(tableEcritures);
		tablePieces = new PiecesDataTable();
		base.Tables.Add(tablePieces);
		relationDossiersTiers = new DataRelation("DossiersTiers", new DataColumn[1] { tableDossiers.UNIColumn }, new DataColumn[1] { tableTiers.UNIColumn }, createConstraints: false);
		Relations.Add(relationDossiersTiers);
		relationComptesEcritures = new DataRelation("ComptesEcritures", new DataColumn[1] { tableComptes.CPTColumn }, new DataColumn[1] { tableEcritures.CPTColumn }, createConstraints: false);
		Relations.Add(relationComptesEcritures);
		relationTiersEcritures = new DataRelation("TiersEcritures", new DataColumn[2] { tableTiers.UNIColumn, tableTiers.TRSColumn }, new DataColumn[2] { tableEcritures.UNIColumn, tableEcritures.TRSColumn }, createConstraints: false);
		Relations.Add(relationTiersEcritures);
		relationDossiersPieces = new DataRelation("DossiersPieces", new DataColumn[1] { tableDossiers.UNIColumn }, new DataColumn[1] { tablePieces.UNIColumn }, createConstraints: false);
		Relations.Add(relationDossiersPieces);
		relationJournauxPieces = new DataRelation("JournauxPieces", new DataColumn[1] { tableJournaux.JAColumn }, new DataColumn[1] { tablePieces.JAColumn }, createConstraints: false);
		Relations.Add(relationJournauxPieces);
		relationPiecesEcritures = new DataRelation("PiecesEcritures", new DataColumn[4] { tablePieces.UNIColumn, tablePieces.ExerciceColumn, tablePieces.JAColumn, tablePieces.NOPColumn }, new DataColumn[4] { tableEcritures.UNIColumn, tableEcritures.ExerciceColumn, tableEcritures.JAColumn, tableEcritures.NOPColumn }, createConstraints: false);
		Relations.Add(relationPiecesEcritures);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool ShouldSerializeBalance()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool ShouldSerializeComptes()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool ShouldSerializeDossiers()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool ShouldSerializeEcritures00()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool ShouldSerializeEcrtri()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool ShouldSerializeEtats()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool ShouldSerializeImmo()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool ShouldSerializeJournaux()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool ShouldSerializeLesEtats()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool ShouldSerializeLesMois()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool ShouldSerializeTiers()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool ShouldSerializeVilles()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool ShouldSerializeEcritures_t()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool ShouldSerializeEcritures()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool ShouldSerializePieces()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		DataSet1 ds = new DataSet1();
		XmlSchemaComplexType type = new XmlSchemaComplexType();
		XmlSchemaSequence sequence = new XmlSchemaSequence();
		XmlSchemaAny any = new XmlSchemaAny();
		any.Namespace = ds.Namespace;
		sequence.Items.Add(any);
		type.Particle = sequence;
		XmlSchema dsSchema = ds.GetSchemaSerializable();
		if (xs.Contains(dsSchema.TargetNamespace))
		{
			MemoryStream s1 = new MemoryStream();
			MemoryStream s2 = new MemoryStream();
			try
			{
				dsSchema.Write(s1);
				IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
				while (schemas.MoveNext())
				{
					XmlSchema obj = (XmlSchema)schemas.Current;
					s2.SetLength(0L);
					obj.Write(s2);
					if (s1.Length == s2.Length)
					{
						s1.Position = 0L;
						s2.Position = 0L;
						while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
						{
						}
						if (s1.Position == s1.Length)
						{
							return type;
						}
					}
				}
			}
			finally
			{
				s1?.Close();
				s2?.Close();
			}
		}
		xs.Add(dsSchema);
		return type;
	}
}
