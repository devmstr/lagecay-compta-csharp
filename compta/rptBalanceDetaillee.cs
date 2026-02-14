using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace compta;

public class rptBalanceDetaillee : XtraReport
{
	private IContainer components;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private DetailBand Detail;

	private PageHeaderBand PageHeader;

	private GroupHeaderBand GroupHeader1;

	private GroupFooterBand GroupFooter1;

	private PageFooterBand PageFooter;

	private GroupHeaderBand GroupHeader2;

	private XRLabel xrLabel1;

	private XRLabel xrLabel2;

	private XRLabel xrLabel8;

	private XRLabel xrLabel4;

	private XRLabel xrLabel6;

	private XRLabel xrLabel7;

	private XRLabel xrLabel3;

	private XRLabel xrLabel5;

	private XRLabel xrLabel9;

	private XRLabel xrLabel10;

	private XRLabel xrLabel11;

	private XRLabel xrLabel12;

	private XRLabel xrLabel13;

	private XRLabel xrLabel14;

	private XRLabel xrLabel15;

	private XRLabel xrLabel16;

	private XRLabel xrLabel17;

	private XRLabel xrLabel18;

	private XRLabel xrLabel19;

	private XRLabel Titre;

	private XRLabel Dossier;

	private XRLabel Periode;

	private XRPageInfo xrPageInfo1;

	public rptBalanceDetaillee()
	{
		InitializeComponent();
	}

	private void PageHeader_BeforePrint(object sender, PrintEventArgs e)
	{
		Dossier.Text = monModule.eUNI + " : " + monModule.eUNILIB;
		Periode.Text = "au mois de " + monModule.gMois[monModule.eAU] + " " + monModule.eExercice;
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
		TopMargin = new TopMarginBand();
		BottomMargin = new BottomMarginBand();
		Detail = new DetailBand();
		xrLabel1 = new XRLabel();
		xrLabel2 = new XRLabel();
		xrLabel8 = new XRLabel();
		xrLabel4 = new XRLabel();
		xrLabel6 = new XRLabel();
		xrLabel7 = new XRLabel();
		xrLabel3 = new XRLabel();
		PageHeader = new PageHeaderBand();
		xrPageInfo1 = new XRPageInfo();
		Titre = new XRLabel();
		Dossier = new XRLabel();
		Periode = new XRLabel();
		GroupHeader1 = new GroupHeaderBand();
		xrLabel5 = new XRLabel();
		xrLabel9 = new XRLabel();
		xrLabel10 = new XRLabel();
		xrLabel11 = new XRLabel();
		xrLabel12 = new XRLabel();
		xrLabel13 = new XRLabel();
		xrLabel14 = new XRLabel();
		GroupFooter1 = new GroupFooterBand();
		xrLabel15 = new XRLabel();
		xrLabel16 = new XRLabel();
		xrLabel17 = new XRLabel();
		xrLabel18 = new XRLabel();
		xrLabel19 = new XRLabel();
		PageFooter = new PageFooterBand();
		GroupHeader2 = new GroupHeaderBand();
		((ISupportInitialize)this).BeginInit();
		TopMargin.HeightF = 25f;
		TopMargin.Name = "TopMargin";
		BottomMargin.HeightF = 22.91667f;
		BottomMargin.Name = "BottomMargin";
		Detail.Controls.AddRange(new XRControl[7] { xrLabel1, xrLabel2, xrLabel8, xrLabel4, xrLabel6, xrLabel7, xrLabel3 });
		Detail.HeightF = 23f;
		Detail.Name = "Detail";
		xrLabel1.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SCCRE]")
		});
		xrLabel1.Font = new Font("Arial", 8f);
		xrLabel1.LocationFloat = new PointFloat(688.0419f, 0f);
		xrLabel1.Multiline = true;
		xrLabel1.Name = "xrLabel1";
		xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel1.SizeF = new SizeF(88f, 23f);
		xrLabel1.StylePriority.UseBorders = false;
		xrLabel1.StylePriority.UseFont = false;
		xrLabel1.StylePriority.UseTextAlignment = false;
		xrLabel1.TextAlignment = TextAlignment.MiddleRight;
		xrLabel1.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel2.Borders = BorderSide.None;
		xrLabel2.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SCDEB]")
		});
		xrLabel2.Font = new Font("Arial", 8f);
		xrLabel2.LocationFloat = new PointFloat(600.0419f, 0f);
		xrLabel2.Multiline = true;
		xrLabel2.Name = "xrLabel2";
		xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.SizeF = new SizeF(88f, 23f);
		xrLabel2.StylePriority.UseBorders = false;
		xrLabel2.StylePriority.UseFont = false;
		xrLabel2.StylePriority.UseTextAlignment = false;
		xrLabel2.TextAlignment = TextAlignment.MiddleRight;
		xrLabel2.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel8.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel8.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SCRE]")
		});
		xrLabel8.Font = new Font("Arial", 8f);
		xrLabel8.LocationFloat = new PointFloat(512.042f, 0f);
		xrLabel8.Multiline = true;
		xrLabel8.Name = "xrLabel8";
		xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.SizeF = new SizeF(88f, 23f);
		xrLabel8.StylePriority.UseBorders = false;
		xrLabel8.StylePriority.UseFont = false;
		xrLabel8.StylePriority.UseTextAlignment = false;
		xrLabel8.TextAlignment = TextAlignment.MiddleRight;
		xrLabel8.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel4.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[TRS]")
		});
		xrLabel4.Font = new Font("Arial", 8f);
		xrLabel4.LocationFloat = new PointFloat(73.75f, 0f);
		xrLabel4.Multiline = true;
		xrLabel4.Name = "xrLabel4";
		xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel4.SizeF = new SizeF(63.54165f, 23f);
		xrLabel4.StylePriority.UseFont = false;
		xrLabel4.StylePriority.UseTextAlignment = false;
		xrLabel4.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel6.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel6.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[LIB]")
		});
		xrLabel6.Font = new Font("Arial", 8f);
		xrLabel6.LocationFloat = new PointFloat(137.2917f, 0f);
		xrLabel6.Multiline = true;
		xrLabel6.Name = "xrLabel6";
		xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel6.SizeF = new SizeF(286.7503f, 23f);
		xrLabel6.StylePriority.UseBorders = false;
		xrLabel6.StylePriority.UseFont = false;
		xrLabel6.StylePriority.UseTextAlignment = false;
		xrLabel6.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel7.Borders = BorderSide.None;
		xrLabel7.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SDEB]")
		});
		xrLabel7.Font = new Font("Arial", 8f);
		xrLabel7.LocationFloat = new PointFloat(424.042f, 0f);
		xrLabel7.Multiline = true;
		xrLabel7.Name = "xrLabel7";
		xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel7.SizeF = new SizeF(88f, 23f);
		xrLabel7.StylePriority.UseBorders = false;
		xrLabel7.StylePriority.UseFont = false;
		xrLabel7.StylePriority.UseTextAlignment = false;
		xrLabel7.TextAlignment = TextAlignment.MiddleRight;
		xrLabel7.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel3.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel3.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[Compte]")
		});
		xrLabel3.Font = new Font("Arial", 8f);
		xrLabel3.LocationFloat = new PointFloat(12f, 0f);
		xrLabel3.Multiline = true;
		xrLabel3.Name = "xrLabel3";
		xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel3.SizeF = new SizeF(61.75f, 23f);
		xrLabel3.StylePriority.UseBorders = false;
		xrLabel3.StylePriority.UseFont = false;
		xrLabel3.StylePriority.UseTextAlignment = false;
		xrLabel3.Text = "12345";
		xrLabel3.TextAlignment = TextAlignment.MiddleCenter;
		PageHeader.Controls.AddRange(new XRControl[4] { xrPageInfo1, Titre, Dossier, Periode });
		PageHeader.HeightF = 72.91666f;
		PageHeader.Name = "PageHeader";
		PageHeader.BeforePrint += PageHeader_BeforePrint;
		xrPageInfo1.LocationFloat = new PointFloat(676.0417f, 0f);
		xrPageInfo1.Name = "xrPageInfo1";
		xrPageInfo1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo1.SizeF = new SizeF(100f, 23f);
		xrPageInfo1.StylePriority.UseTextAlignment = false;
		xrPageInfo1.TextAlignment = TextAlignment.MiddleRight;
		xrPageInfo1.TextFormatString = "Page {0} sur {1}";
		Titre.Font = new Font("Arial", 11f, FontStyle.Bold);
		Titre.LocationFloat = new PointFloat(12.49998f, 22.99999f);
		Titre.Multiline = true;
		Titre.Name = "Titre";
		Titre.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Titre.SizeF = new SizeF(763.5417f, 23.00001f);
		Titre.StylePriority.UseFont = false;
		Titre.StylePriority.UseTextAlignment = false;
		Titre.Text = "Balance Détaillée";
		Titre.TextAlignment = TextAlignment.MiddleCenter;
		Dossier.Font = new Font("Arial", 11f, FontStyle.Bold);
		Dossier.LocationFloat = new PointFloat(12.49998f, 0f);
		Dossier.Multiline = true;
		Dossier.Name = "Dossier";
		Dossier.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Dossier.SizeF = new SizeF(538.3753f, 23f);
		Dossier.StylePriority.UseFont = false;
		Dossier.StylePriority.UseTextAlignment = false;
		Dossier.Text = "Balance des Soldes";
		Dossier.TextAlignment = TextAlignment.MiddleLeft;
		Periode.Font = new Font("Arial", 11f, FontStyle.Bold);
		Periode.LocationFloat = new PointFloat(12.49998f, 46f);
		Periode.Multiline = true;
		Periode.Name = "Periode";
		Periode.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Periode.SizeF = new SizeF(763.5421f, 23.00001f);
		Periode.StylePriority.UseFont = false;
		Periode.StylePriority.UseTextAlignment = false;
		Periode.Text = "au mois";
		Periode.TextAlignment = TextAlignment.MiddleCenter;
		GroupHeader1.Controls.AddRange(new XRControl[7] { xrLabel5, xrLabel9, xrLabel10, xrLabel11, xrLabel12, xrLabel13, xrLabel14 });
		GroupHeader1.GroupUnion = GroupUnion.WholePage;
		GroupHeader1.HeightF = 61.12503f;
		GroupHeader1.Level = 1;
		GroupHeader1.Name = "GroupHeader1";
		GroupHeader1.RepeatEveryPage = true;
		xrLabel5.Borders = BorderSide.All;
		xrLabel5.Font = new Font("Arial", 8f, FontStyle.Bold);
		xrLabel5.LocationFloat = new PointFloat(688.0417f, 10.00001f);
		xrLabel5.Multiline = true;
		xrLabel5.Name = "xrLabel5";
		xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.SizeF = new SizeF(88f, 51.12502f);
		xrLabel5.StylePriority.UseBorders = false;
		xrLabel5.StylePriority.UseFont = false;
		xrLabel5.StylePriority.UseTextAlignment = false;
		xrLabel5.Text = "Solde Crédit";
		xrLabel5.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel5.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel9.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel9.Font = new Font("Arial", 8f, FontStyle.Bold);
		xrLabel9.LocationFloat = new PointFloat(73.75002f, 10.00001f);
		xrLabel9.Multiline = true;
		xrLabel9.Name = "xrLabel9";
		xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel9.SizeF = new SizeF(63.54166f, 51.12502f);
		xrLabel9.StylePriority.UseBorders = false;
		xrLabel9.StylePriority.UseFont = false;
		xrLabel9.StylePriority.UseTextAlignment = false;
		xrLabel9.Text = "Tiers";
		xrLabel9.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel10.Borders = BorderSide.All;
		xrLabel10.Font = new Font("Arial", 8f, FontStyle.Bold);
		xrLabel10.LocationFloat = new PointFloat(137.2917f, 10.00001f);
		xrLabel10.Multiline = true;
		xrLabel10.Name = "xrLabel10";
		xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel10.SizeF = new SizeF(286.7503f, 51.12502f);
		xrLabel10.StylePriority.UseBorders = false;
		xrLabel10.StylePriority.UseFont = false;
		xrLabel10.StylePriority.UseTextAlignment = false;
		xrLabel10.Text = "Intitulé";
		xrLabel10.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel11.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel11.Font = new Font("Arial", 8f, FontStyle.Bold);
		xrLabel11.LocationFloat = new PointFloat(424.0419f, 10.00001f);
		xrLabel11.Multiline = true;
		xrLabel11.Name = "xrLabel11";
		xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel11.SizeF = new SizeF(87.99997f, 51.12502f);
		xrLabel11.StylePriority.UseBorders = false;
		xrLabel11.StylePriority.UseFont = false;
		xrLabel11.StylePriority.UseTextAlignment = false;
		xrLabel11.Text = "Cummul Débit";
		xrLabel11.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel12.Borders = BorderSide.All;
		xrLabel12.Font = new Font("Arial", 8f, FontStyle.Bold);
		xrLabel12.LocationFloat = new PointFloat(512.0418f, 10.00001f);
		xrLabel12.Multiline = true;
		xrLabel12.Name = "xrLabel12";
		xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel12.SizeF = new SizeF(88.00012f, 51.12502f);
		xrLabel12.StylePriority.UseBorders = false;
		xrLabel12.StylePriority.UseFont = false;
		xrLabel12.StylePriority.UseTextAlignment = false;
		xrLabel12.Text = "Cummul Crédit";
		xrLabel12.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel13.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel13.Font = new Font("Arial", 8f, FontStyle.Bold);
		xrLabel13.LocationFloat = new PointFloat(600.0417f, 10.00001f);
		xrLabel13.Multiline = true;
		xrLabel13.Name = "xrLabel13";
		xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel13.SizeF = new SizeF(88f, 51.12502f);
		xrLabel13.StylePriority.UseBorders = false;
		xrLabel13.StylePriority.UseFont = false;
		xrLabel13.StylePriority.UseTextAlignment = false;
		xrLabel13.Text = "Solde Débit";
		xrLabel13.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel14.Borders = BorderSide.All;
		xrLabel14.Font = new Font("Arial", 8f, FontStyle.Bold);
		xrLabel14.LocationFloat = new PointFloat(12f, 10.00001f);
		xrLabel14.Multiline = true;
		xrLabel14.Name = "xrLabel14";
		xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel14.SizeF = new SizeF(61.75f, 51.12502f);
		xrLabel14.StylePriority.UseBorders = false;
		xrLabel14.StylePriority.UseFont = false;
		xrLabel14.StylePriority.UseTextAlignment = false;
		xrLabel14.Text = "Compte";
		xrLabel14.TextAlignment = TextAlignment.MiddleCenter;
		GroupFooter1.Controls.AddRange(new XRControl[5] { xrLabel15, xrLabel16, xrLabel17, xrLabel18, xrLabel19 });
		GroupFooter1.GroupUnion = GroupFooterUnion.WithLastDetail;
		GroupFooter1.HeightF = 37.41671f;
		GroupFooter1.Name = "GroupFooter1";
		xrLabel15.Borders = BorderSide.All;
		xrLabel15.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SCCRE])")
		});
		xrLabel15.Font = new Font("Arial", 8f, FontStyle.Bold);
		xrLabel15.LocationFloat = new PointFloat(688.0421f, 0f);
		xrLabel15.Multiline = true;
		xrLabel15.Name = "xrLabel15";
		xrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel15.SizeF = new SizeF(88f, 23f);
		xrLabel15.StylePriority.UseBorders = false;
		xrLabel15.StylePriority.UseFont = false;
		xrLabel15.StylePriority.UseTextAlignment = false;
		xrSummary1.Running = SummaryRunning.Group;
		xrLabel15.Summary = xrSummary1;
		xrLabel15.TextAlignment = TextAlignment.MiddleRight;
		xrLabel15.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel16.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel16.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SDEB])")
		});
		xrLabel16.Font = new Font("Arial", 8f, FontStyle.Bold);
		xrLabel16.LocationFloat = new PointFloat(424.042f, 0f);
		xrLabel16.Multiline = true;
		xrLabel16.Name = "xrLabel16";
		xrLabel16.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel16.SizeF = new SizeF(88f, 23f);
		xrLabel16.StylePriority.UseBorders = false;
		xrLabel16.StylePriority.UseFont = false;
		xrLabel16.StylePriority.UseTextAlignment = false;
		xrSummary2.Running = SummaryRunning.Group;
		xrLabel16.Summary = xrSummary2;
		xrLabel16.TextAlignment = TextAlignment.MiddleRight;
		xrLabel16.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel17.Borders = BorderSide.All;
		xrLabel17.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SCRE])")
		});
		xrLabel17.Font = new Font("Arial", 8f, FontStyle.Bold);
		xrLabel17.LocationFloat = new PointFloat(512.042f, 0f);
		xrLabel17.Multiline = true;
		xrLabel17.Name = "xrLabel17";
		xrLabel17.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel17.SizeF = new SizeF(88f, 23f);
		xrLabel17.StylePriority.UseBorders = false;
		xrLabel17.StylePriority.UseFont = false;
		xrLabel17.StylePriority.UseTextAlignment = false;
		xrSummary3.Running = SummaryRunning.Group;
		xrLabel17.Summary = xrSummary3;
		xrLabel17.TextAlignment = TextAlignment.MiddleRight;
		xrLabel17.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel18.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel18.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SCDEB])")
		});
		xrLabel18.Font = new Font("Arial", 8f, FontStyle.Bold);
		xrLabel18.LocationFloat = new PointFloat(600.042f, 0f);
		xrLabel18.Multiline = true;
		xrLabel18.Name = "xrLabel18";
		xrLabel18.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel18.SizeF = new SizeF(88f, 23f);
		xrLabel18.StylePriority.UseBorders = false;
		xrLabel18.StylePriority.UseFont = false;
		xrLabel18.StylePriority.UseTextAlignment = false;
		xrSummary4.Running = SummaryRunning.Group;
		xrLabel18.Summary = xrSummary4;
		xrLabel18.TextAlignment = TextAlignment.MiddleRight;
		xrLabel18.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel19.Borders = BorderSide.Top | BorderSide.Right;
		xrLabel19.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel19.LocationFloat = new PointFloat(12f, 0f);
		xrLabel19.Multiline = true;
		xrLabel19.Name = "xrLabel19";
		xrLabel19.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel19.SizeF = new SizeF(412.0421f, 23f);
		xrLabel19.StylePriority.UseBorders = false;
		xrLabel19.StylePriority.UseFont = false;
		xrLabel19.StylePriority.UseTextAlignment = false;
		xrLabel19.Text = "TOTAL";
		xrLabel19.TextAlignment = TextAlignment.MiddleRight;
		PageFooter.HeightF = 23.24994f;
		PageFooter.Name = "PageFooter";
		GroupHeader2.GroupFields.AddRange(new GroupField[1]
		{
			new GroupField("UN", XRColumnSortOrder.Ascending)
		});
		GroupHeader2.HeightF = 0f;
		GroupHeader2.Name = "GroupHeader2";
		base.Bands.AddRange(new Band[8] { TopMargin, BottomMargin, Detail, PageHeader, GroupHeader1, GroupFooter1, PageFooter, GroupHeader2 });
		Font = new Font("Arial", 9.75f);
		base.Margins = new Margins(21, 27, 25, 23);
		base.PageHeight = 1169;
		base.PageWidth = 827;
		base.PaperKind = PaperKind.A4;
		base.ScriptLanguage = ScriptLanguage.VisualBasic;
		base.Version = "20.1";
		((ISupportInitialize)this).EndInit();
	}
}
