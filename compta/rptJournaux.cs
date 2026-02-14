using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using compta.DataSet1TableAdapters;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace compta;

public class rptJournaux : XtraReport
{
	private IContainer components;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private DetailBand Detail;

	private XRLabel xrLabel4;

	private XRLabel xrLabel3;

	private XRLabel xrLabel2;

	private XRLabel xrLabel1;

	private PageHeaderBand PageHeader;

	private GroupHeaderBand GroupHeader1;

	private GroupHeaderBand GroupHeader2;

	private GroupFooterBand GroupFooter1;

	private GroupFooterBand GroupFooter2;

	private PageFooterBand PageFooter;

	private DataSet1 dataSet11;

	private BalanceTableAdapter balanceTableAdapter;

	private XRLabel xrLabel9;

	private XRLabel xrLabel10;

	private XRLabel xrLabel7;

	private XRLabel xrLabel8;

	private XRLabel xrLabel6;

	private XRLabel xrLabel5;

	private XRLabel xrLabel14;

	private XRLabel xrLabel12;

	private XRLabel xrLabel13;

	private XRLabel xrLabel11;

	private XRLabel xrLabel15;

	private XRLabel journal;

	private XRLabel MM;

	private XRLabel JA;

	private XRLabel LIBJA;

	private XRLabel Titre;

	private XRLabel Dossier;

	private XRPageInfo xrPageInfo1;

	public rptJournaux()
	{
		InitializeComponent();
	}

	private void GroupHeader2_BeforePrint(object sender, PrintEventArgs e)
	{
		string jnl = GetCurrentColumnValue<string>("JA");
		string libjnl = GetCurrentColumnValue<string>("LIBJA");
		journal.Text = "Journal : " + jnl + " " + libjnl;
	}

	private void PageHeader_BeforePrint(object sender, PrintEventArgs e)
	{
		Dossier.Text = monModule.eUNI + " : " + monModule.eUNILIB;
		Titre.Text = "Journaux de l'exercice " + monModule.eExercice;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		XRSummary xrSummary1 = new XRSummary();
		XRSummary xrSummary2 = new XRSummary();
		TopMargin = new TopMarginBand();
		BottomMargin = new BottomMarginBand();
		Detail = new DetailBand();
		xrLabel14 = new XRLabel();
		xrLabel12 = new XRLabel();
		xrLabel4 = new XRLabel();
		xrLabel3 = new XRLabel();
		xrLabel2 = new XRLabel();
		xrLabel1 = new XRLabel();
		PageHeader = new PageHeaderBand();
		xrPageInfo1 = new XRPageInfo();
		Titre = new XRLabel();
		Dossier = new XRLabel();
		GroupHeader1 = new GroupHeaderBand();
		GroupHeader2 = new GroupHeaderBand();
		LIBJA = new XRLabel();
		MM = new XRLabel();
		JA = new XRLabel();
		journal = new XRLabel();
		xrLabel13 = new XRLabel();
		xrLabel11 = new XRLabel();
		xrLabel7 = new XRLabel();
		xrLabel8 = new XRLabel();
		xrLabel6 = new XRLabel();
		xrLabel5 = new XRLabel();
		GroupFooter1 = new GroupFooterBand();
		GroupFooter2 = new GroupFooterBand();
		xrLabel15 = new XRLabel();
		xrLabel9 = new XRLabel();
		xrLabel10 = new XRLabel();
		PageFooter = new PageFooterBand();
		dataSet11 = new DataSet1();
		balanceTableAdapter = new BalanceTableAdapter();
		((ISupportInitialize)dataSet11).BeginInit();
		((ISupportInitialize)this).BeginInit();
		TopMargin.Dpi = 254f;
		TopMargin.HeightF = 87.3125f;
		TopMargin.Name = "TopMargin";
		BottomMargin.Dpi = 254f;
		BottomMargin.HeightF = 87.20657f;
		BottomMargin.Name = "BottomMargin";
		Detail.Controls.AddRange(new XRControl[6] { xrLabel14, xrLabel12, xrLabel4, xrLabel3, xrLabel2, xrLabel1 });
		Detail.Dpi = 254f;
		Detail.HeightF = 68.79166f;
		Detail.HierarchyPrintOptions.Indent = 50.8f;
		Detail.Name = "Detail";
		xrLabel14.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel14.Dpi = 254f;
		xrLabel14.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DAT]")
		});
		xrLabel14.LocationFloat = new PointFloat(34.26f, 0f);
		xrLabel14.Multiline = true;
		xrLabel14.Name = "xrLabel14";
		xrLabel14.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		xrLabel14.SizeF = new SizeF(254f, 67.20415f);
		xrLabel14.StylePriority.UseBorders = false;
		xrLabel14.StylePriority.UseTextAlignment = false;
		xrLabel14.Text = "xrLabel1";
		xrLabel14.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel14.TextFormatString = "{0:dd-MM-yyyy}";
		xrLabel12.Borders = BorderSide.None;
		xrLabel12.Dpi = 254f;
		xrLabel12.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[NOP]")
		});
		xrLabel12.LocationFloat = new PointFloat(288.26f, 0f);
		xrLabel12.Multiline = true;
		xrLabel12.Name = "xrLabel12";
		xrLabel12.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		xrLabel12.SizeF = new SizeF(254f, 67.20415f);
		xrLabel12.StylePriority.UseBorders = false;
		xrLabel12.StylePriority.UseTextAlignment = false;
		xrLabel12.Text = "xrLabel1";
		xrLabel12.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel4.Borders = BorderSide.Right;
		xrLabel4.Dpi = 254f;
		xrLabel4.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[CRE]")
		});
		xrLabel4.LocationFloat = new PointFloat(1784.32f, 0f);
		xrLabel4.Multiline = true;
		xrLabel4.Name = "xrLabel4";
		xrLabel4.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		xrLabel4.SizeF = new SizeF(254.0001f, 67.20415f);
		xrLabel4.StylePriority.UseBorders = false;
		xrLabel4.StylePriority.UseTextAlignment = false;
		xrLabel4.Text = "xrLabel4";
		xrLabel4.TextAlignment = TextAlignment.MiddleRight;
		xrLabel4.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel3.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel3.Dpi = 254f;
		xrLabel3.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DEB]")
		});
		xrLabel3.LocationFloat = new PointFloat(1530.32f, 0f);
		xrLabel3.Multiline = true;
		xrLabel3.Name = "xrLabel3";
		xrLabel3.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		xrLabel3.SizeF = new SizeF(254f, 67.20415f);
		xrLabel3.StylePriority.UseBorders = false;
		xrLabel3.StylePriority.UseTextAlignment = false;
		xrLabel3.Text = "xrLabel3";
		xrLabel3.TextAlignment = TextAlignment.MiddleRight;
		xrLabel3.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel2.Borders = BorderSide.None;
		xrLabel2.Dpi = 254f;
		xrLabel2.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[LIBECR]")
		});
		xrLabel2.LocationFloat = new PointFloat(796.26f, 0f);
		xrLabel2.Multiline = true;
		xrLabel2.Name = "xrLabel2";
		xrLabel2.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		xrLabel2.SizeF = new SizeF(732.8958f, 67.20415f);
		xrLabel2.StylePriority.UseBorders = false;
		xrLabel2.StylePriority.UseTextAlignment = false;
		xrLabel2.Text = "xrLabel2";
		xrLabel2.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel1.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel1.Dpi = 254f;
		xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[CPT]")
		});
		xrLabel1.LocationFloat = new PointFloat(542.26f, 0f);
		xrLabel1.Multiline = true;
		xrLabel1.Name = "xrLabel1";
		xrLabel1.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		xrLabel1.SizeF = new SizeF(254f, 67.20415f);
		xrLabel1.StylePriority.UseBorders = false;
		xrLabel1.StylePriority.UseTextAlignment = false;
		xrLabel1.Text = "xrLabel1";
		xrLabel1.TextAlignment = TextAlignment.MiddleCenter;
		PageHeader.Controls.AddRange(new XRControl[3] { xrPageInfo1, Titre, Dossier });
		PageHeader.Dpi = 254f;
		PageHeader.HeightF = 121.7083f;
		PageHeader.Name = "PageHeader";
		PageHeader.BeforePrint += PageHeader_BeforePrint;
		xrPageInfo1.Dpi = 254f;
		xrPageInfo1.LocationFloat = new PointFloat(1784.32f, 0f);
		xrPageInfo1.Name = "xrPageInfo1";
		xrPageInfo1.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		xrPageInfo1.SizeF = new SizeF(254f, 58.42f);
		xrPageInfo1.StylePriority.UseTextAlignment = false;
		xrPageInfo1.TextAlignment = TextAlignment.MiddleRight;
		xrPageInfo1.TextFormatString = "Page {0} sur {1}";
		Titre.Dpi = 254f;
		Titre.Font = new Font("Arial", 11f, FontStyle.Bold);
		Titre.LocationFloat = new PointFloat(34.26f, 58.42001f);
		Titre.Multiline = true;
		Titre.Name = "Titre";
		Titre.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		Titre.SizeF = new SizeF(2004.059f, 58.42001f);
		Titre.StylePriority.UseFont = false;
		Titre.StylePriority.UseTextAlignment = false;
		Titre.Text = "JOURNAUX";
		Titre.TextAlignment = TextAlignment.MiddleCenter;
		Dossier.Dpi = 254f;
		Dossier.Font = new Font("Arial", 11f, FontStyle.Bold);
		Dossier.LocationFloat = new PointFloat(34.26f, 0f);
		Dossier.Multiline = true;
		Dossier.Name = "Dossier";
		Dossier.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		Dossier.SizeF = new SizeF(1435.206f, 58.42f);
		Dossier.StylePriority.UseFont = false;
		Dossier.StylePriority.UseTextAlignment = false;
		Dossier.Text = "Balance des Soldes";
		Dossier.TextAlignment = TextAlignment.MiddleLeft;
		GroupHeader1.Dpi = 254f;
		GroupHeader1.GroupFields.AddRange(new GroupField[1]
		{
			new GroupField("JA", XRColumnSortOrder.Ascending)
		});
		GroupHeader1.HeightF = 0f;
		GroupHeader1.Level = 1;
		GroupHeader1.Name = "GroupHeader1";
		GroupHeader1.PageBreak = PageBreak.BeforeBand;
		GroupHeader1.RepeatEveryPage = true;
		GroupHeader2.Controls.AddRange(new XRControl[10] { LIBJA, MM, JA, journal, xrLabel13, xrLabel11, xrLabel7, xrLabel8, xrLabel6, xrLabel5 });
		GroupHeader2.Dpi = 254f;
		GroupHeader2.GroupFields.AddRange(new GroupField[1]
		{
			new GroupField("MM", XRColumnSortOrder.Ascending)
		});
		GroupHeader2.GroupUnion = GroupUnion.WholePage;
		GroupHeader2.HeightF = 224.5783f;
		GroupHeader2.KeepTogether = true;
		GroupHeader2.Name = "GroupHeader2";
		GroupHeader2.BeforePrint += GroupHeader2_BeforePrint;
		LIBJA.Borders = BorderSide.Left | BorderSide.Right;
		LIBJA.Dpi = 254f;
		LIBJA.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[LIBJA]")
		});
		LIBJA.LocationFloat = new PointFloat(1530.32f, 0f);
		LIBJA.Multiline = true;
		LIBJA.Name = "LIBJA";
		LIBJA.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		LIBJA.SizeF = new SizeF(254f, 67.20415f);
		LIBJA.StylePriority.UseBorders = false;
		LIBJA.StylePriority.UseTextAlignment = false;
		LIBJA.Text = "LIBJA";
		LIBJA.TextAlignment = TextAlignment.MiddleCenter;
		LIBJA.Visible = false;
		MM.Borders = BorderSide.Left | BorderSide.Right;
		MM.Dpi = 254f;
		MM.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[MM]")
		});
		MM.LocationFloat = new PointFloat(1090.371f, 0f);
		MM.Multiline = true;
		MM.Name = "MM";
		MM.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		MM.SizeF = new SizeF(254.0001f, 67.20415f);
		MM.StylePriority.UseBorders = false;
		MM.StylePriority.UseTextAlignment = false;
		MM.Text = "MM";
		MM.TextAlignment = TextAlignment.MiddleCenter;
		MM.Visible = false;
		JA.Borders = BorderSide.Left | BorderSide.Right;
		JA.Dpi = 254f;
		JA.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[JA]")
		});
		JA.LocationFloat = new PointFloat(643.225f, 0f);
		JA.Multiline = true;
		JA.Name = "JA";
		JA.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		JA.SizeF = new SizeF(254f, 67.20415f);
		JA.StylePriority.UseBorders = false;
		JA.StylePriority.UseTextAlignment = false;
		JA.Text = "JA";
		JA.TextAlignment = TextAlignment.MiddleCenter;
		JA.Visible = false;
		journal.Dpi = 254f;
		journal.Font = new Font("Arial", 10f, FontStyle.Bold);
		journal.LocationFloat = new PointFloat(34.26015f, 67.20415f);
		journal.Multiline = true;
		journal.Name = "journal";
		journal.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		journal.SizeF = new SizeF(2004.06f, 58.42f);
		journal.StylePriority.UseFont = false;
		journal.StylePriority.UseTextAlignment = false;
		journal.Text = "journal";
		journal.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel13.BackColor = Color.WhiteSmoke;
		xrLabel13.Borders = BorderSide.All;
		xrLabel13.Dpi = 254f;
		xrLabel13.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel13.LocationFloat = new PointFloat(34.26f, 157.3742f);
		xrLabel13.Multiline = true;
		xrLabel13.Name = "xrLabel13";
		xrLabel13.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		xrLabel13.SizeF = new SizeF(254f, 67.20416f);
		xrLabel13.StylePriority.UseBackColor = false;
		xrLabel13.StylePriority.UseBorders = false;
		xrLabel13.StylePriority.UseFont = false;
		xrLabel13.StylePriority.UseTextAlignment = false;
		xrLabel13.Text = "Date";
		xrLabel13.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel11.BackColor = Color.WhiteSmoke;
		xrLabel11.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel11.Dpi = 254f;
		xrLabel11.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel11.LocationFloat = new PointFloat(288.26f, 157.3742f);
		xrLabel11.Multiline = true;
		xrLabel11.Name = "xrLabel11";
		xrLabel11.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		xrLabel11.SizeF = new SizeF(254f, 67.20416f);
		xrLabel11.StylePriority.UseBackColor = false;
		xrLabel11.StylePriority.UseBorders = false;
		xrLabel11.StylePriority.UseFont = false;
		xrLabel11.StylePriority.UseTextAlignment = false;
		xrLabel11.Text = "Pièce";
		xrLabel11.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel7.BackColor = Color.WhiteSmoke;
		xrLabel7.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
		xrLabel7.Dpi = 254f;
		xrLabel7.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel7.LocationFloat = new PointFloat(1784.32f, 157.3742f);
		xrLabel7.Multiline = true;
		xrLabel7.Name = "xrLabel7";
		xrLabel7.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		xrLabel7.SizeF = new SizeF(254.0001f, 67.20416f);
		xrLabel7.StylePriority.UseBackColor = false;
		xrLabel7.StylePriority.UseBorders = false;
		xrLabel7.StylePriority.UseFont = false;
		xrLabel7.StylePriority.UseTextAlignment = false;
		xrLabel7.Text = "Crédit";
		xrLabel7.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel8.BackColor = Color.WhiteSmoke;
		xrLabel8.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel8.Dpi = 254f;
		xrLabel8.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel8.LocationFloat = new PointFloat(796.26f, 157.3742f);
		xrLabel8.Multiline = true;
		xrLabel8.Name = "xrLabel8";
		xrLabel8.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		xrLabel8.SizeF = new SizeF(732.8958f, 67.20416f);
		xrLabel8.StylePriority.UseBackColor = false;
		xrLabel8.StylePriority.UseBorders = false;
		xrLabel8.StylePriority.UseFont = false;
		xrLabel8.StylePriority.UseTextAlignment = false;
		xrLabel8.Text = "Intitulé";
		xrLabel8.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel6.BackColor = Color.WhiteSmoke;
		xrLabel6.Borders = BorderSide.All;
		xrLabel6.Dpi = 254f;
		xrLabel6.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel6.LocationFloat = new PointFloat(1530.32f, 157.3742f);
		xrLabel6.Multiline = true;
		xrLabel6.Name = "xrLabel6";
		xrLabel6.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		xrLabel6.SizeF = new SizeF(254f, 67.20416f);
		xrLabel6.StylePriority.UseBackColor = false;
		xrLabel6.StylePriority.UseBorders = false;
		xrLabel6.StylePriority.UseFont = false;
		xrLabel6.StylePriority.UseTextAlignment = false;
		xrLabel6.Text = "Débit";
		xrLabel6.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel5.BackColor = Color.WhiteSmoke;
		xrLabel5.Borders = BorderSide.All;
		xrLabel5.Dpi = 254f;
		xrLabel5.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel5.LocationFloat = new PointFloat(542.26f, 157.3742f);
		xrLabel5.Multiline = true;
		xrLabel5.Name = "xrLabel5";
		xrLabel5.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		xrLabel5.SizeF = new SizeF(254f, 67.20416f);
		xrLabel5.StylePriority.UseBackColor = false;
		xrLabel5.StylePriority.UseBorders = false;
		xrLabel5.StylePriority.UseFont = false;
		xrLabel5.StylePriority.UseTextAlignment = false;
		xrLabel5.Text = "Compte";
		xrLabel5.TextAlignment = TextAlignment.MiddleCenter;
		GroupFooter1.Dpi = 254f;
		GroupFooter1.HeightF = 2.96332f;
		GroupFooter1.Level = 1;
		GroupFooter1.Name = "GroupFooter1";
		GroupFooter2.Controls.AddRange(new XRControl[3] { xrLabel15, xrLabel9, xrLabel10 });
		GroupFooter2.Dpi = 254f;
		GroupFooter2.HeightF = 79.69248f;
		GroupFooter2.Name = "GroupFooter2";
		xrLabel15.Borders = BorderSide.Top;
		xrLabel15.Dpi = 254f;
		xrLabel15.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel15.LocationFloat = new PointFloat(34.26f, 0f);
		xrLabel15.Multiline = true;
		xrLabel15.Name = "xrLabel15";
		xrLabel15.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		xrLabel15.SizeF = new SizeF(1496.06f, 67.20415f);
		xrLabel15.StylePriority.UseBorders = false;
		xrLabel15.StylePriority.UseFont = false;
		xrLabel15.StylePriority.UseTextAlignment = false;
		xrLabel15.Text = "TOTAUX";
		xrLabel15.TextAlignment = TextAlignment.MiddleRight;
		xrLabel9.Borders = BorderSide.All;
		xrLabel9.Dpi = 254f;
		xrLabel9.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([DEB])")
		});
		xrLabel9.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel9.LocationFloat = new PointFloat(1530.32f, 0f);
		xrLabel9.Multiline = true;
		xrLabel9.Name = "xrLabel9";
		xrLabel9.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		xrLabel9.SizeF = new SizeF(254f, 67.20415f);
		xrLabel9.StylePriority.UseBorders = false;
		xrLabel9.StylePriority.UseFont = false;
		xrLabel9.StylePriority.UseTextAlignment = false;
		xrSummary1.Running = SummaryRunning.Group;
		xrLabel9.Summary = xrSummary1;
		xrLabel9.Text = "xrLabel3";
		xrLabel9.TextAlignment = TextAlignment.MiddleRight;
		xrLabel9.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel10.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
		xrLabel10.Dpi = 254f;
		xrLabel10.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([CRE])")
		});
		xrLabel10.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel10.LocationFloat = new PointFloat(1784.32f, 0f);
		xrLabel10.Multiline = true;
		xrLabel10.Name = "xrLabel10";
		xrLabel10.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		xrLabel10.SizeF = new SizeF(254.0001f, 67.20415f);
		xrLabel10.StylePriority.UseBorders = false;
		xrLabel10.StylePriority.UseFont = false;
		xrLabel10.StylePriority.UseTextAlignment = false;
		xrSummary2.Running = SummaryRunning.Group;
		xrLabel10.Summary = xrSummary2;
		xrLabel10.Text = "xrLabel4";
		xrLabel10.TextAlignment = TextAlignment.MiddleRight;
		xrLabel10.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		PageFooter.Dpi = 254f;
		PageFooter.HeightF = 76.09419f;
		PageFooter.Name = "PageFooter";
		dataSet11.DataSetName = "DataSet1";
		dataSet11.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		balanceTableAdapter.ClearBeforeFill = true;
		base.Bands.AddRange(new Band[9] { TopMargin, BottomMargin, Detail, PageHeader, GroupHeader1, GroupHeader2, GroupFooter1, GroupFooter2, PageFooter });
		base.ComponentStorage.AddRange(new IComponent[1] { dataSet11 });
		base.DataAdapter = balanceTableAdapter;
		base.DataSource = dataSet11;
		Dpi = 254f;
		Font = new Font("Arial", 9.75f);
		base.Margins = new Margins(25, 25, 87, 87);
		base.PageHeight = 2970;
		base.PageWidth = 2100;
		base.PaperKind = PaperKind.A4;
		base.ReportUnit = ReportUnit.TenthsOfAMillimeter;
		base.ScriptLanguage = ScriptLanguage.VisualBasic;
		base.SnapGridSize = 25f;
		base.Version = "20.1";
		((ISupportInitialize)dataSet11).EndInit();
		((ISupportInitialize)this).EndInit();
	}
}
