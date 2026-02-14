using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace compta;

public class rptTVA : XtraReport
{
	private IContainer components;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private DetailBand Detail;

	private PageHeaderBand PageHeader;

	private GroupHeaderBand GroupHeader1;

	private PageFooterBand PageFooter;

	private GroupFooterBand GroupFooter1;

	private XRPageInfo xrPageInfo1;

	private XRLabel Periode;

	private XRLabel NOMUNI;

	private XRLabel Titre;

	private XRLabel NUMIF;

	private XRLabel ADR;

	private XRLabel ACT;

	private XRLabel xrLabel5;

	private XRLabel xrLabel4;

	private XRLabel xrLabel3;

	private XRLabel xrLabel2;

	private XRLabel xrLabel1;

	private XRLabel xrLabel8;

	private XRLabel xrLabel9;

	private XRLabel xrLabel10;

	private XRLabel xrLabel11;

	private XRLabel xrLabel12;

	private XRLabel xrLabel13;

	private XRLabel xrLabel14;

	private XRLabel xrLabel7;

	private XRLabel xrLabel6;

	private XRLabel xrLabel15;

	private XRLabel xrLabel16;

	private XRLabel xrLabel17;

	public rptTVA()
	{
		InitializeComponent();
	}

	private void PageHeader_BeforePrint(object sender, PrintEventArgs e)
	{
		Periode.Text = "Exercice " + monModule.eExercice;
		DataRow[] foundRows = monModule.dtDossiers.Select("UNI='" + monModule.eUNI + "'");
		monModule.eUNILIB = "";
		if (foundRows.Length != 0)
		{
			NOMUNI.Text = foundRows[0]["LIB"].ToString();
			ACT.Text = foundRows[0]["ACT"].ToString();
			ADR.Text = foundRows[0]["ADR"].ToString();
			NUMIF.Text = foundRows[0]["NUMIF"].ToString();
		}
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
		xrLabel8 = new XRLabel();
		xrLabel9 = new XRLabel();
		xrLabel10 = new XRLabel();
		xrLabel11 = new XRLabel();
		xrLabel12 = new XRLabel();
		xrLabel13 = new XRLabel();
		xrLabel14 = new XRLabel();
		PageHeader = new PageHeaderBand();
		NUMIF = new XRLabel();
		ADR = new XRLabel();
		ACT = new XRLabel();
		xrPageInfo1 = new XRPageInfo();
		Periode = new XRLabel();
		NOMUNI = new XRLabel();
		Titre = new XRLabel();
		GroupHeader1 = new GroupHeaderBand();
		xrLabel7 = new XRLabel();
		xrLabel6 = new XRLabel();
		xrLabel5 = new XRLabel();
		xrLabel4 = new XRLabel();
		xrLabel3 = new XRLabel();
		xrLabel2 = new XRLabel();
		xrLabel1 = new XRLabel();
		PageFooter = new PageFooterBand();
		GroupFooter1 = new GroupFooterBand();
		xrLabel15 = new XRLabel();
		xrLabel16 = new XRLabel();
		xrLabel17 = new XRLabel();
		((ISupportInitialize)this).BeginInit();
		TopMargin.HeightF = 25f;
		TopMargin.Name = "TopMargin";
		BottomMargin.HeightF = 27.08333f;
		BottomMargin.Name = "BottomMargin";
		Detail.Controls.AddRange(new XRControl[7] { xrLabel8, xrLabel9, xrLabel10, xrLabel11, xrLabel12, xrLabel13, xrLabel14 });
		Detail.HeightF = 26.45833f;
		Detail.Name = "Detail";
		xrLabel8.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel8.CanGrow = false;
		xrLabel8.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[CL2]")
		});
		xrLabel8.LocationFloat = new PointFloat(972.4583f, 0f);
		xrLabel8.Multiline = true;
		xrLabel8.Name = "xrLabel8";
		xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.SizeF = new SizeF(123.9583f, 26.45833f);
		xrLabel8.StylePriority.UseBorders = false;
		xrLabel8.StylePriority.UseTextAlignment = false;
		xrLabel8.Text = "xrLabel3";
		xrLabel8.TextAlignment = TextAlignment.MiddleRight;
		xrLabel8.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel9.BorderDashStyle = BorderDashStyle.Solid;
		xrLabel9.Borders = BorderSide.None;
		xrLabel9.CanGrow = false;
		xrLabel9.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[AITRS]")
		});
		xrLabel9.LocationFloat = new PointFloat(109f, 0f);
		xrLabel9.Multiline = true;
		xrLabel9.Name = "xrLabel9";
		xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel9.SizeF = new SizeF(100f, 26.45833f);
		xrLabel9.StylePriority.UseBorderDashStyle = false;
		xrLabel9.StylePriority.UseBorders = false;
		xrLabel9.StylePriority.UseTextAlignment = false;
		xrLabel9.Text = "xrLabel1";
		xrLabel9.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel10.BorderDashStyle = BorderDashStyle.Solid;
		xrLabel10.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel10.CanGrow = false;
		xrLabel10.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[NIFTRS]")
		});
		xrLabel10.LocationFloat = new PointFloat(209f, 0f);
		xrLabel10.Multiline = true;
		xrLabel10.Name = "xrLabel10";
		xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel10.SizeF = new SizeF(136.4584f, 26.45833f);
		xrLabel10.StylePriority.UseBorderDashStyle = false;
		xrLabel10.StylePriority.UseBorders = false;
		xrLabel10.StylePriority.UseTextAlignment = false;
		xrLabel10.Text = "xrLabel1";
		xrLabel10.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel11.Borders = BorderSide.None;
		xrLabel11.CanGrow = false;
		xrLabel11.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[NOMTRS]")
		});
		xrLabel11.LocationFloat = new PointFloat(345.4583f, 0f);
		xrLabel11.Multiline = true;
		xrLabel11.Name = "xrLabel11";
		xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel11.SizeF = new SizeF(252.0416f, 26.45833f);
		xrLabel11.StylePriority.UseBorders = false;
		xrLabel11.StylePriority.UseTextAlignment = false;
		xrLabel11.Text = "xrLabel2";
		xrLabel11.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel12.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel12.CanGrow = false;
		xrLabel12.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[ADRTRS]")
		});
		xrLabel12.LocationFloat = new PointFloat(597.4999f, 0f);
		xrLabel12.Multiline = true;
		xrLabel12.Name = "xrLabel12";
		xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel12.SizeF = new SizeF(250.9999f, 26.45833f);
		xrLabel12.StylePriority.UseBorders = false;
		xrLabel12.StylePriority.UseTextAlignment = false;
		xrLabel12.Text = "xrLabel2";
		xrLabel12.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel13.Borders = BorderSide.None;
		xrLabel13.CanGrow = false;
		xrLabel13.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[CL1]")
		});
		xrLabel13.LocationFloat = new PointFloat(848.4998f, 0f);
		xrLabel13.Multiline = true;
		xrLabel13.Name = "xrLabel13";
		xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel13.SizeF = new SizeF(123.9583f, 26.45833f);
		xrLabel13.StylePriority.UseBorders = false;
		xrLabel13.StylePriority.UseTextAlignment = false;
		xrLabel13.Text = "xrLabel3";
		xrLabel13.TextAlignment = TextAlignment.MiddleRight;
		xrLabel13.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel14.BorderDashStyle = BorderDashStyle.Solid;
		xrLabel14.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel14.CanGrow = false;
		xrLabel14.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[RCTRS]")
		});
		xrLabel14.LocationFloat = new PointFloat(9f, 0f);
		xrLabel14.Multiline = true;
		xrLabel14.Name = "xrLabel14";
		xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel14.SizeF = new SizeF(100f, 26.45833f);
		xrLabel14.StylePriority.UseBorderDashStyle = false;
		xrLabel14.StylePriority.UseBorders = false;
		xrLabel14.StylePriority.UseTextAlignment = false;
		xrLabel14.Text = "xrLabel1";
		xrLabel14.TextAlignment = TextAlignment.MiddleCenter;
		PageHeader.Controls.AddRange(new XRControl[7] { NUMIF, ADR, ACT, xrPageInfo1, Periode, NOMUNI, Titre });
		PageHeader.HeightF = 173.6667f;
		PageHeader.Name = "PageHeader";
		PageHeader.BeforePrint += PageHeader_BeforePrint;
		NUMIF.Font = new Font("Arial", 11f, FontStyle.Bold);
		NUMIF.LocationFloat = new PointFloat(9f, 68.99999f);
		NUMIF.Multiline = true;
		NUMIF.Name = "NUMIF";
		NUMIF.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		NUMIF.SizeF = new SizeF(538.3753f, 23f);
		NUMIF.StylePriority.UseFont = false;
		NUMIF.StylePriority.UseTextAlignment = false;
		NUMIF.TextAlignment = TextAlignment.MiddleLeft;
		ADR.Font = new Font("Arial", 11f, FontStyle.Bold);
		ADR.LocationFloat = new PointFloat(9f, 46f);
		ADR.Multiline = true;
		ADR.Name = "ADR";
		ADR.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		ADR.SizeF = new SizeF(538.3753f, 23f);
		ADR.StylePriority.UseFont = false;
		ADR.StylePriority.UseTextAlignment = false;
		ADR.TextAlignment = TextAlignment.MiddleLeft;
		ACT.Font = new Font("Arial", 11f, FontStyle.Bold);
		ACT.LocationFloat = new PointFloat(9f, 23f);
		ACT.Multiline = true;
		ACT.Name = "ACT";
		ACT.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		ACT.SizeF = new SizeF(538.3753f, 23f);
		ACT.StylePriority.UseFont = false;
		ACT.StylePriority.UseTextAlignment = false;
		ACT.TextAlignment = TextAlignment.MiddleLeft;
		xrPageInfo1.LocationFloat = new PointFloat(997.0002f, 0f);
		xrPageInfo1.Name = "xrPageInfo1";
		xrPageInfo1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo1.SizeF = new SizeF(100f, 23f);
		xrPageInfo1.StylePriority.UseTextAlignment = false;
		xrPageInfo1.TextAlignment = TextAlignment.MiddleRight;
		xrPageInfo1.TextFormatString = "Page {0} sur {1}";
		Periode.Font = new Font("Arial", 11f, FontStyle.Bold);
		Periode.LocationFloat = new PointFloat(9f, 136.0833f);
		Periode.Multiline = true;
		Periode.Name = "Periode";
		Periode.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Periode.SizeF = new SizeF(1088f, 23.00001f);
		Periode.StylePriority.UseFont = false;
		Periode.StylePriority.UseTextAlignment = false;
		Periode.Text = "au mois";
		Periode.TextAlignment = TextAlignment.MiddleCenter;
		NOMUNI.Font = new Font("Arial", 11f, FontStyle.Bold);
		NOMUNI.LocationFloat = new PointFloat(9f, 0f);
		NOMUNI.Multiline = true;
		NOMUNI.Name = "NOMUNI";
		NOMUNI.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		NOMUNI.SizeF = new SizeF(538.3753f, 23f);
		NOMUNI.StylePriority.UseFont = false;
		NOMUNI.StylePriority.UseTextAlignment = false;
		NOMUNI.TextAlignment = TextAlignment.MiddleLeft;
		Titre.Font = new Font("Arial", 11f, FontStyle.Bold);
		Titre.LocationFloat = new PointFloat(9f, 113.0834f);
		Titre.Multiline = true;
		Titre.Name = "Titre";
		Titre.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Titre.SizeF = new SizeF(1088f, 23.00001f);
		Titre.StylePriority.UseFont = false;
		Titre.StylePriority.UseTextAlignment = false;
		Titre.Text = "ETAT CLIENTS";
		Titre.TextAlignment = TextAlignment.MiddleCenter;
		GroupHeader1.Controls.AddRange(new XRControl[7] { xrLabel7, xrLabel6, xrLabel5, xrLabel4, xrLabel3, xrLabel2, xrLabel1 });
		GroupHeader1.HeightF = 45.49993f;
		GroupHeader1.Name = "GroupHeader1";
		xrLabel7.Borders = BorderSide.All;
		xrLabel7.CanGrow = false;
		xrLabel7.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel7.LocationFloat = new PointFloat(972.4582f, 0f);
		xrLabel7.Multiline = true;
		xrLabel7.Name = "xrLabel7";
		xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel7.SizeF = new SizeF(123.9583f, 45.49993f);
		xrLabel7.StylePriority.UseBorders = false;
		xrLabel7.StylePriority.UseFont = false;
		xrLabel7.StylePriority.UseTextAlignment = false;
		xrLabel7.Text = "TVA";
		xrLabel7.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel7.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel6.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel6.CanGrow = false;
		xrLabel6.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel6.LocationFloat = new PointFloat(848.4999f, 0f);
		xrLabel6.Multiline = true;
		xrLabel6.Name = "xrLabel6";
		xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel6.SizeF = new SizeF(123.9583f, 45.49993f);
		xrLabel6.StylePriority.UseBorders = false;
		xrLabel6.StylePriority.UseFont = false;
		xrLabel6.StylePriority.UseTextAlignment = false;
		xrLabel6.Text = "Montant Hors Taxes";
		xrLabel6.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel6.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel5.Borders = BorderSide.All;
		xrLabel5.CanGrow = false;
		xrLabel5.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel5.LocationFloat = new PointFloat(597.4999f, 0f);
		xrLabel5.Multiline = true;
		xrLabel5.Name = "xrLabel5";
		xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.SizeF = new SizeF(250.9999f, 45.49993f);
		xrLabel5.StylePriority.UseBorders = false;
		xrLabel5.StylePriority.UseFont = false;
		xrLabel5.StylePriority.UseTextAlignment = false;
		xrLabel5.Text = "Adresse";
		xrLabel5.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel4.BorderDashStyle = BorderDashStyle.Solid;
		xrLabel4.Borders = BorderSide.All;
		xrLabel4.CanGrow = false;
		xrLabel4.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel4.LocationFloat = new PointFloat(209f, 0f);
		xrLabel4.Multiline = true;
		xrLabel4.Name = "xrLabel4";
		xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel4.SizeF = new SizeF(136.4584f, 45.49993f);
		xrLabel4.StylePriority.UseBorderDashStyle = false;
		xrLabel4.StylePriority.UseBorders = false;
		xrLabel4.StylePriority.UseFont = false;
		xrLabel4.StylePriority.UseTextAlignment = false;
		xrLabel4.Text = "Identifiant Fiscal";
		xrLabel4.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel3.BorderDashStyle = BorderDashStyle.Solid;
		xrLabel3.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel3.CanGrow = false;
		xrLabel3.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel3.LocationFloat = new PointFloat(109f, 0f);
		xrLabel3.Multiline = true;
		xrLabel3.Name = "xrLabel3";
		xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel3.SizeF = new SizeF(100f, 45.49993f);
		xrLabel3.StylePriority.UseBorderDashStyle = false;
		xrLabel3.StylePriority.UseBorders = false;
		xrLabel3.StylePriority.UseFont = false;
		xrLabel3.StylePriority.UseTextAlignment = false;
		xrLabel3.Text = "Article d'Imposition";
		xrLabel3.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel2.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel2.CanGrow = false;
		xrLabel2.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel2.LocationFloat = new PointFloat(345.4583f, 0f);
		xrLabel2.Multiline = true;
		xrLabel2.Name = "xrLabel2";
		xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.SizeF = new SizeF(252.0416f, 45.49993f);
		xrLabel2.StylePriority.UseBorders = false;
		xrLabel2.StylePriority.UseFont = false;
		xrLabel2.StylePriority.UseTextAlignment = false;
		xrLabel2.Text = "Nom - Raison Sociale";
		xrLabel2.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel1.BorderDashStyle = BorderDashStyle.Solid;
		xrLabel1.Borders = BorderSide.All;
		xrLabel1.CanGrow = false;
		xrLabel1.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel1.LocationFloat = new PointFloat(9f, 0f);
		xrLabel1.Multiline = true;
		xrLabel1.Name = "xrLabel1";
		xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel1.SizeF = new SizeF(100f, 45.49993f);
		xrLabel1.StylePriority.UseBorderDashStyle = false;
		xrLabel1.StylePriority.UseBorders = false;
		xrLabel1.StylePriority.UseFont = false;
		xrLabel1.StylePriority.UseTextAlignment = false;
		xrLabel1.Text = "N° RC";
		xrLabel1.TextAlignment = TextAlignment.MiddleCenter;
		PageFooter.HeightF = 22.91667f;
		PageFooter.Name = "PageFooter";
		GroupFooter1.Controls.AddRange(new XRControl[3] { xrLabel15, xrLabel16, xrLabel17 });
		GroupFooter1.HeightF = 26.45833f;
		GroupFooter1.Name = "GroupFooter1";
		xrLabel15.Borders = BorderSide.All;
		xrLabel15.CanGrow = false;
		xrLabel15.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([CL2])")
		});
		xrLabel15.LocationFloat = new PointFloat(972.4583f, 0f);
		xrLabel15.Multiline = true;
		xrLabel15.Name = "xrLabel15";
		xrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel15.SizeF = new SizeF(123.9583f, 26.45833f);
		xrLabel15.StylePriority.UseBorders = false;
		xrLabel15.StylePriority.UseTextAlignment = false;
		xrSummary1.Running = SummaryRunning.Report;
		xrLabel15.Summary = xrSummary1;
		xrLabel15.Text = "xrLabel3";
		xrLabel15.TextAlignment = TextAlignment.MiddleRight;
		xrLabel15.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel16.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel16.CanGrow = false;
		xrLabel16.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([CL1])")
		});
		xrLabel16.LocationFloat = new PointFloat(848.4998f, 0f);
		xrLabel16.Multiline = true;
		xrLabel16.Name = "xrLabel16";
		xrLabel16.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel16.SizeF = new SizeF(123.9583f, 26.45833f);
		xrLabel16.StylePriority.UseBorders = false;
		xrLabel16.StylePriority.UseTextAlignment = false;
		xrSummary2.Running = SummaryRunning.Report;
		xrLabel16.Summary = xrSummary2;
		xrLabel16.Text = "xrLabel3";
		xrLabel16.TextAlignment = TextAlignment.MiddleRight;
		xrLabel16.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel17.Borders = BorderSide.Top | BorderSide.Right;
		xrLabel17.CanGrow = false;
		xrLabel17.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel17.LocationFloat = new PointFloat(9f, 0f);
		xrLabel17.Multiline = true;
		xrLabel17.Name = "xrLabel17";
		xrLabel17.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel17.SizeF = new SizeF(839.4999f, 26.45833f);
		xrLabel17.StylePriority.UseBorders = false;
		xrLabel17.StylePriority.UseFont = false;
		xrLabel17.StylePriority.UseTextAlignment = false;
		xrLabel17.Text = "TOTAL";
		xrLabel17.TextAlignment = TextAlignment.MiddleRight;
		base.Bands.AddRange(new Band[7] { TopMargin, BottomMargin, Detail, PageHeader, GroupHeader1, PageFooter, GroupFooter1 });
		Font = new Font("Arial", 9.75f);
		base.Landscape = true;
		base.Margins = new Margins(27, 34, 25, 27);
		base.PageHeight = 827;
		base.PageWidth = 1169;
		base.PaperKind = PaperKind.A4;
		base.ScriptLanguage = ScriptLanguage.VisualBasic;
		base.Version = "20.1";
		((ISupportInitialize)this).EndInit();
	}
}
