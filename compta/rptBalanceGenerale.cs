using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace compta;

public class rptBalanceGenerale : XtraReport
{
	private IContainer components;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private DetailBand Detail;

	private XRLabel xrLabel3;

	private XRLabel xrLabel7;

	private XRLabel xrLabel6;

	private XRLabel xrLabel8;

	private XRLabel xrLabel2;

	private XRLabel xrLabel1;

	private XRLabel xrLabel4;

	private XRLabel xrLabel5;

	private PageHeaderBand PageHeader;

	private GroupHeaderBand GroupHeader1;

	private XRLabel xrLabel9;

	private XRLabel xrLabel10;

	private XRLabel xrLabel11;

	private XRLabel xrLabel12;

	private XRLabel xrLabel13;

	private XRLabel xrLabel14;

	private XRLabel xrLabel15;

	private XRLabel xrLabel16;

	private GroupFooterBand GroupFooter1;

	private XRLabel xrLabel23;

	private XRLabel xrLabel17;

	private XRLabel xrLabel18;

	private XRLabel xrLabel19;

	private XRLabel xrLabel20;

	private XRLabel xrLabel21;

	private XRLabel xrLabel22;

	private XRLabel Titre;

	private XRPageInfo xrPageInfo1;

	private XRLabel Dossier;

	private XRLabel Periode;

	private XRLabel xrLabel24;

	public rptBalanceGenerale()
	{
		InitializeComponent();
	}

	private void PageHeader_BeforePrint(object sender, PrintEventArgs e)
	{
		Dossier.Text = monModule.eUNI + " : " + monModule.eUNILIB;
		Periode.Text = "au mois de " + monModule.gMois[monModule.eMOIS] + " " + monModule.eExercice;
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
		XRSummary xrSummary3 = new XRSummary();
		XRSummary xrSummary4 = new XRSummary();
		XRSummary xrSummary5 = new XRSummary();
		XRSummary xrSummary6 = new XRSummary();
		TopMargin = new TopMarginBand();
		BottomMargin = new BottomMarginBand();
		Detail = new DetailBand();
		xrLabel4 = new XRLabel();
		xrLabel5 = new XRLabel();
		xrLabel3 = new XRLabel();
		xrLabel7 = new XRLabel();
		xrLabel6 = new XRLabel();
		xrLabel8 = new XRLabel();
		xrLabel2 = new XRLabel();
		xrLabel1 = new XRLabel();
		PageHeader = new PageHeaderBand();
		Titre = new XRLabel();
		xrPageInfo1 = new XRPageInfo();
		Dossier = new XRLabel();
		Periode = new XRLabel();
		GroupHeader1 = new GroupHeaderBand();
		xrLabel9 = new XRLabel();
		xrLabel10 = new XRLabel();
		xrLabel11 = new XRLabel();
		xrLabel12 = new XRLabel();
		xrLabel13 = new XRLabel();
		xrLabel14 = new XRLabel();
		xrLabel15 = new XRLabel();
		xrLabel16 = new XRLabel();
		GroupFooter1 = new GroupFooterBand();
		xrLabel23 = new XRLabel();
		xrLabel17 = new XRLabel();
		xrLabel18 = new XRLabel();
		xrLabel19 = new XRLabel();
		xrLabel20 = new XRLabel();
		xrLabel21 = new XRLabel();
		xrLabel22 = new XRLabel();
		xrLabel24 = new XRLabel();
		((ISupportInitialize)this).BeginInit();
		TopMargin.HeightF = 26.04167f;
		TopMargin.Name = "TopMargin";
		BottomMargin.HeightF = 27.08333f;
		BottomMargin.Name = "BottomMargin";
		Detail.Controls.AddRange(new XRControl[8] { xrLabel4, xrLabel5, xrLabel3, xrLabel7, xrLabel6, xrLabel8, xrLabel2, xrLabel1 });
		Detail.HeightF = 23.95833f;
		Detail.Name = "Detail";
		xrLabel4.Borders = BorderSide.Right;
		xrLabel4.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SCREDIT]")
		});
		xrLabel4.Font = new Font("Arial", 9f);
		xrLabel4.LocationFloat = new PointFloat(974.0001f, 0f);
		xrLabel4.Multiline = true;
		xrLabel4.Name = "xrLabel4";
		xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel4.SizeF = new SizeF(114f, 23f);
		xrLabel4.StylePriority.UseBorders = false;
		xrLabel4.StylePriority.UseFont = false;
		xrLabel4.StylePriority.UseTextAlignment = false;
		xrLabel4.TextAlignment = TextAlignment.MiddleRight;
		xrLabel4.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel5.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel5.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SDEBIT]")
		});
		xrLabel5.Font = new Font("Arial", 9f);
		xrLabel5.LocationFloat = new PointFloat(860.0001f, 0f);
		xrLabel5.Multiline = true;
		xrLabel5.Name = "xrLabel5";
		xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.SizeF = new SizeF(114f, 23f);
		xrLabel5.StylePriority.UseBorders = false;
		xrLabel5.StylePriority.UseFont = false;
		xrLabel5.StylePriority.UseTextAlignment = false;
		xrLabel5.TextAlignment = TextAlignment.MiddleRight;
		xrLabel5.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel3.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel3.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[Compte]")
		});
		xrLabel3.Font = new Font("Arial", 9f);
		xrLabel3.LocationFloat = new PointFloat(0f, 0f);
		xrLabel3.Multiline = true;
		xrLabel3.Name = "xrLabel3";
		xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel3.SizeF = new SizeF(61.75f, 23f);
		xrLabel3.StylePriority.UseBorders = false;
		xrLabel3.StylePriority.UseFont = false;
		xrLabel3.StylePriority.UseTextAlignment = false;
		xrLabel3.Text = "12345";
		xrLabel3.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel7.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel7.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DEBI]")
		});
		xrLabel7.Font = new Font("Arial", 9f);
		xrLabel7.LocationFloat = new PointFloat(404.0002f, 0f);
		xrLabel7.Multiline = true;
		xrLabel7.Name = "xrLabel7";
		xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel7.SizeF = new SizeF(114f, 23f);
		xrLabel7.StylePriority.UseBorders = false;
		xrLabel7.StylePriority.UseFont = false;
		xrLabel7.StylePriority.UseTextAlignment = false;
		xrLabel7.TextAlignment = TextAlignment.MiddleRight;
		xrLabel7.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel6.Borders = BorderSide.None;
		xrLabel6.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[LIB]")
		});
		xrLabel6.Font = new Font("Arial", 9f);
		xrLabel6.LocationFloat = new PointFloat(61.74999f, 0f);
		xrLabel6.Multiline = true;
		xrLabel6.Name = "xrLabel6";
		xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel6.SizeF = new SizeF(342.2502f, 23f);
		xrLabel6.StylePriority.UseBorders = false;
		xrLabel6.StylePriority.UseFont = false;
		xrLabel6.StylePriority.UseTextAlignment = false;
		xrLabel6.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel8.Borders = BorderSide.None;
		xrLabel8.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[CREI]")
		});
		xrLabel8.Font = new Font("Arial", 9f);
		xrLabel8.LocationFloat = new PointFloat(518.0002f, 0f);
		xrLabel8.Multiline = true;
		xrLabel8.Name = "xrLabel8";
		xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.SizeF = new SizeF(114f, 23f);
		xrLabel8.StylePriority.UseBorders = false;
		xrLabel8.StylePriority.UseFont = false;
		xrLabel8.StylePriority.UseTextAlignment = false;
		xrLabel8.TextAlignment = TextAlignment.MiddleRight;
		xrLabel8.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel2.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel2.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SDEB]")
		});
		xrLabel2.Font = new Font("Arial", 9f);
		xrLabel2.LocationFloat = new PointFloat(632.0002f, 0f);
		xrLabel2.Multiline = true;
		xrLabel2.Name = "xrLabel2";
		xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.SizeF = new SizeF(114f, 23f);
		xrLabel2.StylePriority.UseBorders = false;
		xrLabel2.StylePriority.UseFont = false;
		xrLabel2.StylePriority.UseTextAlignment = false;
		xrLabel2.TextAlignment = TextAlignment.MiddleRight;
		xrLabel2.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel1.Borders = BorderSide.None;
		xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SCRE]")
		});
		xrLabel1.Font = new Font("Arial", 9f);
		xrLabel1.LocationFloat = new PointFloat(746.0002f, 0f);
		xrLabel1.Multiline = true;
		xrLabel1.Name = "xrLabel1";
		xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel1.SizeF = new SizeF(114f, 23f);
		xrLabel1.StylePriority.UseBorders = false;
		xrLabel1.StylePriority.UseFont = false;
		xrLabel1.StylePriority.UseTextAlignment = false;
		xrLabel1.TextAlignment = TextAlignment.MiddleRight;
		xrLabel1.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		PageHeader.Controls.AddRange(new XRControl[5] { xrLabel24, Titre, xrPageInfo1, Dossier, Periode });
		PageHeader.HeightF = 69.79166f;
		PageHeader.Name = "PageHeader";
		PageHeader.BeforePrint += PageHeader_BeforePrint;
		Titre.Font = new Font("Arial", 11f, FontStyle.Bold);
		Titre.LocationFloat = new PointFloat(0f, 23f);
		Titre.Multiline = true;
		Titre.Name = "Titre";
		Titre.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Titre.SizeF = new SizeF(1088f, 23.00001f);
		Titre.StylePriority.UseFont = false;
		Titre.StylePriority.UseTextAlignment = false;
		Titre.Text = "Balance Générale";
		Titre.TextAlignment = TextAlignment.MiddleCenter;
		xrPageInfo1.LocationFloat = new PointFloat(988.0001f, 0f);
		xrPageInfo1.Name = "xrPageInfo1";
		xrPageInfo1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo1.SizeF = new SizeF(100f, 23f);
		xrPageInfo1.StylePriority.UseTextAlignment = false;
		xrPageInfo1.TextAlignment = TextAlignment.MiddleRight;
		xrPageInfo1.TextFormatString = "Page {0} sur {1}";
		Dossier.Font = new Font("Arial", 11f, FontStyle.Bold);
		Dossier.LocationFloat = new PointFloat(0f, 0f);
		Dossier.Multiline = true;
		Dossier.Name = "Dossier";
		Dossier.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Dossier.SizeF = new SizeF(538.3753f, 23f);
		Dossier.StylePriority.UseFont = false;
		Dossier.StylePriority.UseTextAlignment = false;
		Dossier.Text = "Balance des Soldes";
		Dossier.TextAlignment = TextAlignment.MiddleLeft;
		Periode.Font = new Font("Arial", 11f, FontStyle.Bold);
		Periode.LocationFloat = new PointFloat(0f, 46.00002f);
		Periode.Multiline = true;
		Periode.Name = "Periode";
		Periode.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Periode.SizeF = new SizeF(1088f, 23.00001f);
		Periode.StylePriority.UseFont = false;
		Periode.StylePriority.UseTextAlignment = false;
		Periode.Text = "au mois";
		Periode.TextAlignment = TextAlignment.MiddleCenter;
		GroupHeader1.Controls.AddRange(new XRControl[8] { xrLabel9, xrLabel10, xrLabel11, xrLabel12, xrLabel13, xrLabel14, xrLabel15, xrLabel16 });
		GroupHeader1.GroupUnion = GroupUnion.WholePage;
		GroupHeader1.HeightF = 66.66666f;
		GroupHeader1.Name = "GroupHeader1";
		GroupHeader1.RepeatEveryPage = true;
		xrLabel9.Borders = BorderSide.All;
		xrLabel9.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel9.LocationFloat = new PointFloat(0f, 14.87498f);
		xrLabel9.Multiline = true;
		xrLabel9.Name = "xrLabel9";
		xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel9.SizeF = new SizeF(61.75f, 51.12502f);
		xrLabel9.StylePriority.UseBorders = false;
		xrLabel9.StylePriority.UseFont = false;
		xrLabel9.StylePriority.UseTextAlignment = false;
		xrLabel9.Text = "Compte";
		xrLabel9.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel10.Borders = BorderSide.All;
		xrLabel10.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel10.LocationFloat = new PointFloat(860.0001f, 14.87498f);
		xrLabel10.Multiline = true;
		xrLabel10.Name = "xrLabel10";
		xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel10.SizeF = new SizeF(114f, 51.12502f);
		xrLabel10.StylePriority.UseBorders = false;
		xrLabel10.StylePriority.UseFont = false;
		xrLabel10.StylePriority.UseTextAlignment = false;
		xrLabel10.Text = "Solde Débit";
		xrLabel10.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel11.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel11.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel11.LocationFloat = new PointFloat(746.0003f, 14.87498f);
		xrLabel11.Multiline = true;
		xrLabel11.Name = "xrLabel11";
		xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel11.SizeF = new SizeF(114f, 51.12502f);
		xrLabel11.StylePriority.UseBorders = false;
		xrLabel11.StylePriority.UseFont = false;
		xrLabel11.StylePriority.UseTextAlignment = false;
		xrLabel11.Text = "Mouvement Crédit";
		xrLabel11.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel12.Borders = BorderSide.All;
		xrLabel12.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel12.LocationFloat = new PointFloat(632.0002f, 14.87498f);
		xrLabel12.Multiline = true;
		xrLabel12.Name = "xrLabel12";
		xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel12.SizeF = new SizeF(114f, 51.12502f);
		xrLabel12.StylePriority.UseBorders = false;
		xrLabel12.StylePriority.UseFont = false;
		xrLabel12.StylePriority.UseTextAlignment = false;
		xrLabel12.Text = "Mouvement Débit";
		xrLabel12.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel13.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel13.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel13.LocationFloat = new PointFloat(518.0004f, 14.87498f);
		xrLabel13.Multiline = true;
		xrLabel13.Name = "xrLabel13";
		xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel13.SizeF = new SizeF(114f, 51.12502f);
		xrLabel13.StylePriority.UseBorders = false;
		xrLabel13.StylePriority.UseFont = false;
		xrLabel13.StylePriority.UseTextAlignment = false;
		xrLabel13.Text = "Crédit Initial";
		xrLabel13.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel14.Borders = BorderSide.All;
		xrLabel14.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel14.LocationFloat = new PointFloat(404.0002f, 14.87498f);
		xrLabel14.Multiline = true;
		xrLabel14.Name = "xrLabel14";
		xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel14.SizeF = new SizeF(114f, 51.12502f);
		xrLabel14.StylePriority.UseBorders = false;
		xrLabel14.StylePriority.UseFont = false;
		xrLabel14.StylePriority.UseTextAlignment = false;
		xrLabel14.Text = "Débit Initial";
		xrLabel14.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel15.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel15.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel15.LocationFloat = new PointFloat(61.74996f, 14.87498f);
		xrLabel15.Multiline = true;
		xrLabel15.Name = "xrLabel15";
		xrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel15.SizeF = new SizeF(342.2502f, 51.12502f);
		xrLabel15.StylePriority.UseBorders = false;
		xrLabel15.StylePriority.UseFont = false;
		xrLabel15.StylePriority.UseTextAlignment = false;
		xrLabel15.Text = "Intitulé";
		xrLabel15.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel16.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
		xrLabel16.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel16.LocationFloat = new PointFloat(974.0002f, 14.87498f);
		xrLabel16.Multiline = true;
		xrLabel16.Name = "xrLabel16";
		xrLabel16.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel16.SizeF = new SizeF(114f, 51.12502f);
		xrLabel16.StylePriority.UseBorders = false;
		xrLabel16.StylePriority.UseFont = false;
		xrLabel16.StylePriority.UseTextAlignment = false;
		xrLabel16.Text = "Solde Crédit";
		xrLabel16.TextAlignment = TextAlignment.MiddleCenter;
		GroupFooter1.Controls.AddRange(new XRControl[7] { xrLabel23, xrLabel17, xrLabel18, xrLabel19, xrLabel20, xrLabel21, xrLabel22 });
		GroupFooter1.GroupUnion = GroupFooterUnion.WithLastDetail;
		GroupFooter1.HeightF = 36.45833f;
		GroupFooter1.Name = "GroupFooter1";
		xrLabel23.Borders = BorderSide.Top;
		xrLabel23.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel23.LocationFloat = new PointFloat(0f, 0f);
		xrLabel23.Multiline = true;
		xrLabel23.Name = "xrLabel23";
		xrLabel23.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel23.SizeF = new SizeF(404.0002f, 23f);
		xrLabel23.StylePriority.UseBorders = false;
		xrLabel23.StylePriority.UseFont = false;
		xrLabel23.StylePriority.UseTextAlignment = false;
		xrLabel23.Text = "TOTAUX";
		xrLabel23.TextAlignment = TextAlignment.MiddleRight;
		xrLabel17.Borders = BorderSide.All;
		xrLabel17.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([DEBI])")
		});
		xrLabel17.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel17.LocationFloat = new PointFloat(404.0002f, 0f);
		xrLabel17.Multiline = true;
		xrLabel17.Name = "xrLabel17";
		xrLabel17.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel17.SizeF = new SizeF(114f, 23f);
		xrLabel17.StylePriority.UseBorders = false;
		xrLabel17.StylePriority.UseFont = false;
		xrLabel17.StylePriority.UseTextAlignment = false;
		xrSummary1.Running = SummaryRunning.Report;
		xrLabel17.Summary = xrSummary1;
		xrLabel17.TextAlignment = TextAlignment.MiddleRight;
		xrLabel17.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel18.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel18.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([CREI])")
		});
		xrLabel18.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel18.LocationFloat = new PointFloat(518.0002f, 0f);
		xrLabel18.Multiline = true;
		xrLabel18.Name = "xrLabel18";
		xrLabel18.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel18.SizeF = new SizeF(114f, 23f);
		xrLabel18.StylePriority.UseBorders = false;
		xrLabel18.StylePriority.UseFont = false;
		xrLabel18.StylePriority.UseTextAlignment = false;
		xrSummary2.Running = SummaryRunning.Report;
		xrLabel18.Summary = xrSummary2;
		xrLabel18.TextAlignment = TextAlignment.MiddleRight;
		xrLabel18.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel19.Borders = BorderSide.All;
		xrLabel19.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SDEB])")
		});
		xrLabel19.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel19.LocationFloat = new PointFloat(632.0002f, 0f);
		xrLabel19.Multiline = true;
		xrLabel19.Name = "xrLabel19";
		xrLabel19.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel19.SizeF = new SizeF(114f, 23f);
		xrLabel19.StylePriority.UseBorders = false;
		xrLabel19.StylePriority.UseFont = false;
		xrLabel19.StylePriority.UseTextAlignment = false;
		xrSummary3.Running = SummaryRunning.Report;
		xrLabel19.Summary = xrSummary3;
		xrLabel19.TextAlignment = TextAlignment.MiddleRight;
		xrLabel19.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel20.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel20.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SCRE])")
		});
		xrLabel20.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel20.LocationFloat = new PointFloat(746.0001f, 0f);
		xrLabel20.Multiline = true;
		xrLabel20.Name = "xrLabel20";
		xrLabel20.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel20.SizeF = new SizeF(114f, 23f);
		xrLabel20.StylePriority.UseBorders = false;
		xrLabel20.StylePriority.UseFont = false;
		xrLabel20.StylePriority.UseTextAlignment = false;
		xrSummary4.Running = SummaryRunning.Report;
		xrLabel20.Summary = xrSummary4;
		xrLabel20.TextAlignment = TextAlignment.MiddleRight;
		xrLabel20.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel21.Borders = BorderSide.All;
		xrLabel21.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SDEBIT])")
		});
		xrLabel21.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel21.LocationFloat = new PointFloat(860.0002f, 0f);
		xrLabel21.Multiline = true;
		xrLabel21.Name = "xrLabel21";
		xrLabel21.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel21.SizeF = new SizeF(114f, 23f);
		xrLabel21.StylePriority.UseBorders = false;
		xrLabel21.StylePriority.UseFont = false;
		xrLabel21.StylePriority.UseTextAlignment = false;
		xrSummary5.Running = SummaryRunning.Report;
		xrLabel21.Summary = xrSummary5;
		xrLabel21.TextAlignment = TextAlignment.MiddleRight;
		xrLabel21.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel22.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
		xrLabel22.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SCREDIT])")
		});
		xrLabel22.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel22.LocationFloat = new PointFloat(974.0002f, 0f);
		xrLabel22.Multiline = true;
		xrLabel22.Name = "xrLabel22";
		xrLabel22.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel22.SizeF = new SizeF(114f, 23f);
		xrLabel22.StylePriority.UseBorders = false;
		xrLabel22.StylePriority.UseFont = false;
		xrLabel22.StylePriority.UseTextAlignment = false;
		xrSummary6.Running = SummaryRunning.Report;
		xrLabel22.Summary = xrSummary6;
		xrLabel22.TextAlignment = TextAlignment.MiddleRight;
		xrLabel22.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel24.LocationFloat = new PointFloat(589.9167f, 0f);
		xrLabel24.Multiline = true;
		xrLabel24.Name = "xrLabel24";
		xrLabel24.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
		xrLabel24.SizeF = new SizeF(100f, 23f);
		xrLabel24.Text = "IDRISS";
		base.Bands.AddRange(new Band[6] { TopMargin, BottomMargin, Detail, PageHeader, GroupHeader1, GroupFooter1 });
		Font = new Font("Arial", 9.75f);
		base.Landscape = true;
		base.Margins = new Margins(33, 38, 26, 27);
		base.PageHeight = 827;
		base.PageWidth = 1169;
		base.PaperKind = PaperKind.A4;
		base.ScriptLanguage = ScriptLanguage.VisualBasic;
		base.Version = "20.1";
		((ISupportInitialize)this).EndInit();
	}
}
