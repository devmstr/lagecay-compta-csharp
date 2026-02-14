using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace compta;

public class rptHistCompte : XtraReport
{
	private IContainer components;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private DetailBand Detail;

	private PageHeaderBand PageHeader;

	private GroupHeaderBand GroupHeader1;

	private GroupFooterBand GroupFooter1;

	private PageFooterBand PageFooter;

	private XRLabel xrLabel5;

	private XRLabel xrLabel4;

	private XRLabel xrLabel1;

	private XRLabel xrLabel7;

	private XRLabel xrLabel8;

	private XRLabel xrLabel2;

	private XRLabel xrLabel3;

	private XRLabel xrLabel6;

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

	private XRLabel xrLabel20;

	private XRLabel xrLabel21;

	private XRLabel Dossier;

	private XRLabel Titre1;

	private XRLabel Periode;

	private XRPageInfo xrPageInfo1;

	public rptHistCompte()
	{
		InitializeComponent();
	}

	private void PageHeader_BeforePrint(object sender, PrintEventArgs e)
	{
		Dossier.Text = monModule.eUNI + " : " + monModule.eUNILIB + "Exercice : " + monModule.eExercice;
		Titre1.Text = "Historique (Exercice : " + monModule.eExercice + ")";
		Periode.Text = "Compte : " + monModule.eCPT + " : " + monModule.eCPTLIB;
	}

	private void Detail_BeforePrint(object sender, PrintEventArgs e)
	{
	}

	private void xrLabel2_BeforePrint(object sender, PrintEventArgs e)
	{
		_ = (XRLabel)sender;
	}

	private void xrLabel3_BeforePrint(object sender, PrintEventArgs e)
	{
		if (xrLabel3.Text != "")
		{
			xrLabel3.Text = monModule.gMois[Convert.ToInt32(xrLabel3.Text)];
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
		XRSummary xrSummary3 = new XRSummary();
		XRSummary xrSummary4 = new XRSummary();
		XRSummary xrSummary5 = new XRSummary();
		XRSummary xrSummary6 = new XRSummary();
		TopMargin = new TopMarginBand();
		BottomMargin = new BottomMarginBand();
		Detail = new DetailBand();
		xrLabel5 = new XRLabel();
		xrLabel4 = new XRLabel();
		xrLabel1 = new XRLabel();
		xrLabel7 = new XRLabel();
		xrLabel8 = new XRLabel();
		xrLabel2 = new XRLabel();
		xrLabel3 = new XRLabel();
		PageHeader = new PageHeaderBand();
		Dossier = new XRLabel();
		Titre1 = new XRLabel();
		Periode = new XRLabel();
		GroupHeader1 = new GroupHeaderBand();
		xrLabel6 = new XRLabel();
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
		xrLabel20 = new XRLabel();
		xrLabel21 = new XRLabel();
		PageFooter = new PageFooterBand();
		xrPageInfo1 = new XRPageInfo();
		((ISupportInitialize)this).BeginInit();
		TopMargin.HeightF = 24f;
		TopMargin.Name = "TopMargin";
		BottomMargin.HeightF = 26f;
		BottomMargin.Name = "BottomMargin";
		Detail.Controls.AddRange(new XRControl[7] { xrLabel5, xrLabel4, xrLabel1, xrLabel7, xrLabel8, xrLabel2, xrLabel3 });
		Detail.HeightF = 23.00002f;
		Detail.Name = "Detail";
		Detail.BeforePrint += Detail_BeforePrint;
		xrLabel5.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel5.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SMC]")
		});
		xrLabel5.Font = new Font("Arial", 9f);
		xrLabel5.LocationFloat = new PointFloat(235.7917f, 0f);
		xrLabel5.Multiline = true;
		xrLabel5.Name = "xrLabel5";
		xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.SizeF = new SizeF(88f, 23f);
		xrLabel5.StylePriority.UseBorders = false;
		xrLabel5.StylePriority.UseFont = false;
		xrLabel5.StylePriority.UseTextAlignment = false;
		xrLabel5.TextAlignment = TextAlignment.MiddleRight;
		xrLabel5.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel4.Borders = BorderSide.None;
		xrLabel4.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SMD]")
		});
		xrLabel4.Font = new Font("Arial", 9f);
		xrLabel4.LocationFloat = new PointFloat(147.7917f, 0f);
		xrLabel4.Multiline = true;
		xrLabel4.Name = "xrLabel4";
		xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel4.SizeF = new SizeF(88f, 23f);
		xrLabel4.StylePriority.UseBorders = false;
		xrLabel4.StylePriority.UseFont = false;
		xrLabel4.StylePriority.UseTextAlignment = false;
		xrLabel4.TextAlignment = TextAlignment.MiddleRight;
		xrLabel4.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel1.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SCUMC]")
		});
		xrLabel1.Font = new Font("Arial", 9f);
		xrLabel1.LocationFloat = new PointFloat(587.7916f, 0f);
		xrLabel1.Multiline = true;
		xrLabel1.Name = "xrLabel1";
		xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel1.SizeF = new SizeF(88f, 23f);
		xrLabel1.StylePriority.UseBorders = false;
		xrLabel1.StylePriority.UseFont = false;
		xrLabel1.StylePriority.UseTextAlignment = false;
		xrLabel1.TextAlignment = TextAlignment.MiddleRight;
		xrLabel1.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel7.Borders = BorderSide.None;
		xrLabel7.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SD]")
		});
		xrLabel7.Font = new Font("Arial", 9f);
		xrLabel7.LocationFloat = new PointFloat(323.7917f, 0f);
		xrLabel7.Multiline = true;
		xrLabel7.Name = "xrLabel7";
		xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel7.SizeF = new SizeF(88f, 23f);
		xrLabel7.StylePriority.UseBorders = false;
		xrLabel7.StylePriority.UseFont = false;
		xrLabel7.StylePriority.UseTextAlignment = false;
		xrLabel7.TextAlignment = TextAlignment.MiddleRight;
		xrLabel7.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel8.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel8.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SC]")
		});
		xrLabel8.Font = new Font("Arial", 9f);
		xrLabel8.LocationFloat = new PointFloat(411.7917f, 0f);
		xrLabel8.Multiline = true;
		xrLabel8.Name = "xrLabel8";
		xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.SizeF = new SizeF(88f, 23f);
		xrLabel8.StylePriority.UseBorders = false;
		xrLabel8.StylePriority.UseFont = false;
		xrLabel8.StylePriority.UseTextAlignment = false;
		xrLabel8.TextAlignment = TextAlignment.MiddleRight;
		xrLabel8.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel2.Borders = BorderSide.None;
		xrLabel2.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SCUMD]")
		});
		xrLabel2.Font = new Font("Arial", 9f);
		xrLabel2.LocationFloat = new PointFloat(499.7916f, 0f);
		xrLabel2.Multiline = true;
		xrLabel2.Name = "xrLabel2";
		xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.SizeF = new SizeF(88f, 23f);
		xrLabel2.StylePriority.UseBorders = false;
		xrLabel2.StylePriority.UseFont = false;
		xrLabel2.StylePriority.UseTextAlignment = false;
		xrLabel2.TextAlignment = TextAlignment.MiddleRight;
		xrLabel2.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel2.BeforePrint += xrLabel2_BeforePrint;
		xrLabel3.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel3.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[Periode]")
		});
		xrLabel3.Font = new Font("Arial", 9f);
		xrLabel3.LocationFloat = new PointFloat(9.999998f, 0f);
		xrLabel3.Multiline = true;
		xrLabel3.Name = "xrLabel3";
		xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel3.SizeF = new SizeF(137.7917f, 23f);
		xrLabel3.StylePriority.UseBorders = false;
		xrLabel3.StylePriority.UseFont = false;
		xrLabel3.StylePriority.UseTextAlignment = false;
		xrLabel3.Text = "12345";
		xrLabel3.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel3.BeforePrint += xrLabel3_BeforePrint;
		PageHeader.Controls.AddRange(new XRControl[4] { xrPageInfo1, Dossier, Titre1, Periode });
		PageHeader.HeightF = 77.08334f;
		PageHeader.Name = "PageHeader";
		PageHeader.BeforePrint += PageHeader_BeforePrint;
		Dossier.Font = new Font("Arial", 11f, FontStyle.Bold);
		Dossier.LocationFloat = new PointFloat(9.99999f, 0f);
		Dossier.Multiline = true;
		Dossier.Name = "Dossier";
		Dossier.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Dossier.SizeF = new SizeF(530.625f, 23f);
		Dossier.StylePriority.UseFont = false;
		Dossier.StylePriority.UseTextAlignment = false;
		Dossier.Text = "Balance des Soldes";
		Dossier.TextAlignment = TextAlignment.MiddleLeft;
		Titre1.Font = new Font("Arial", 11f, FontStyle.Bold);
		Titre1.LocationFloat = new PointFloat(9.999998f, 23f);
		Titre1.Multiline = true;
		Titre1.Name = "Titre1";
		Titre1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Titre1.SizeF = new SizeF(665f, 23.00001f);
		Titre1.StylePriority.UseFont = false;
		Titre1.StylePriority.UseTextAlignment = false;
		Titre1.Text = "Historique du Compte";
		Titre1.TextAlignment = TextAlignment.MiddleCenter;
		Periode.Font = new Font("Arial", 11f, FontStyle.Bold);
		Periode.LocationFloat = new PointFloat(9.999998f, 46f);
		Periode.Multiline = true;
		Periode.Name = "Periode";
		Periode.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Periode.SizeF = new SizeF(665f, 23.00001f);
		Periode.StylePriority.UseFont = false;
		Periode.StylePriority.UseTextAlignment = false;
		Periode.Text = "au mois";
		Periode.TextAlignment = TextAlignment.MiddleCenter;
		GroupHeader1.Controls.AddRange(new XRControl[7] { xrLabel6, xrLabel9, xrLabel10, xrLabel11, xrLabel12, xrLabel13, xrLabel14 });
		GroupHeader1.GroupUnion = GroupUnion.WholePage;
		GroupHeader1.HeightF = 51.12502f;
		GroupHeader1.Name = "GroupHeader1";
		GroupHeader1.RepeatEveryPage = true;
		xrLabel6.Borders = BorderSide.All;
		xrLabel6.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel6.LocationFloat = new PointFloat(9.999998f, 0f);
		xrLabel6.Multiline = true;
		xrLabel6.Name = "xrLabel6";
		xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel6.SizeF = new SizeF(137.7917f, 51.12502f);
		xrLabel6.StylePriority.UseBorders = false;
		xrLabel6.StylePriority.UseFont = false;
		xrLabel6.StylePriority.UseTextAlignment = false;
		xrLabel6.Text = "Période";
		xrLabel6.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel9.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel9.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel9.LocationFloat = new PointFloat(499.7916f, 0f);
		xrLabel9.Multiline = true;
		xrLabel9.Name = "xrLabel9";
		xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel9.SizeF = new SizeF(88f, 51.12502f);
		xrLabel9.StylePriority.UseBorders = false;
		xrLabel9.StylePriority.UseFont = false;
		xrLabel9.StylePriority.UseTextAlignment = false;
		xrLabel9.Text = "Solde Débit Cumulé";
		xrLabel9.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel9.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel10.Borders = BorderSide.All;
		xrLabel10.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel10.LocationFloat = new PointFloat(411.7917f, 0f);
		xrLabel10.Multiline = true;
		xrLabel10.Name = "xrLabel10";
		xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel10.SizeF = new SizeF(88f, 51.12502f);
		xrLabel10.StylePriority.UseBorders = false;
		xrLabel10.StylePriority.UseFont = false;
		xrLabel10.StylePriority.UseTextAlignment = false;
		xrLabel10.Text = "Solde Crédit Mensuel";
		xrLabel10.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel10.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel11.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel11.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel11.LocationFloat = new PointFloat(323.7917f, 0f);
		xrLabel11.Multiline = true;
		xrLabel11.Name = "xrLabel11";
		xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel11.SizeF = new SizeF(88f, 51.12502f);
		xrLabel11.StylePriority.UseBorders = false;
		xrLabel11.StylePriority.UseFont = false;
		xrLabel11.StylePriority.UseTextAlignment = false;
		xrLabel11.Text = "Solde Débit Mensuel";
		xrLabel11.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel11.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel12.Borders = BorderSide.All;
		xrLabel12.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel12.LocationFloat = new PointFloat(235.7917f, 0f);
		xrLabel12.Multiline = true;
		xrLabel12.Name = "xrLabel12";
		xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel12.SizeF = new SizeF(88f, 51.12502f);
		xrLabel12.StylePriority.UseBorders = false;
		xrLabel12.StylePriority.UseFont = false;
		xrLabel12.StylePriority.UseTextAlignment = false;
		xrLabel12.Text = "Crédit";
		xrLabel12.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel12.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel13.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel13.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel13.LocationFloat = new PointFloat(147.7917f, 0f);
		xrLabel13.Multiline = true;
		xrLabel13.Name = "xrLabel13";
		xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel13.SizeF = new SizeF(88f, 51.12502f);
		xrLabel13.StylePriority.UseBorders = false;
		xrLabel13.StylePriority.UseFont = false;
		xrLabel13.StylePriority.UseTextAlignment = false;
		xrLabel13.Text = "Débit";
		xrLabel13.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel13.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel14.Borders = BorderSide.All;
		xrLabel14.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel14.LocationFloat = new PointFloat(587.7916f, 0f);
		xrLabel14.Multiline = true;
		xrLabel14.Name = "xrLabel14";
		xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel14.SizeF = new SizeF(88f, 51.12502f);
		xrLabel14.StylePriority.UseBorders = false;
		xrLabel14.StylePriority.UseFont = false;
		xrLabel14.StylePriority.UseTextAlignment = false;
		xrLabel14.Text = "Solde Crédit  Cumulé";
		xrLabel14.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel14.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		GroupFooter1.Controls.AddRange(new XRControl[7] { xrLabel15, xrLabel16, xrLabel17, xrLabel18, xrLabel19, xrLabel20, xrLabel21 });
		GroupFooter1.GroupUnion = GroupFooterUnion.WithLastDetail;
		GroupFooter1.HeightF = 47.91667f;
		GroupFooter1.Name = "GroupFooter1";
		xrLabel15.Borders = BorderSide.Top | BorderSide.Right;
		xrLabel15.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel15.LocationFloat = new PointFloat(9.999998f, 0f);
		xrLabel15.Multiline = true;
		xrLabel15.Name = "xrLabel15";
		xrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel15.SizeF = new SizeF(137.7917f, 23f);
		xrLabel15.StylePriority.UseBorders = false;
		xrLabel15.StylePriority.UseFont = false;
		xrLabel15.StylePriority.UseTextAlignment = false;
		xrLabel15.Text = "TOTAUX";
		xrLabel15.TextAlignment = TextAlignment.MiddleRight;
		xrLabel16.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel16.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SCUMD])")
		});
		xrLabel16.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel16.LocationFloat = new PointFloat(499.7916f, 0f);
		xrLabel16.Multiline = true;
		xrLabel16.Name = "xrLabel16";
		xrLabel16.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel16.SizeF = new SizeF(88f, 23f);
		xrLabel16.StylePriority.UseBorders = false;
		xrLabel16.StylePriority.UseFont = false;
		xrLabel16.StylePriority.UseTextAlignment = false;
		xrSummary1.Running = SummaryRunning.Group;
		xrLabel16.Summary = xrSummary1;
		xrLabel16.TextAlignment = TextAlignment.MiddleRight;
		xrLabel16.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel17.Borders = BorderSide.All;
		xrLabel17.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SC])")
		});
		xrLabel17.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel17.LocationFloat = new PointFloat(411.7917f, 0f);
		xrLabel17.Multiline = true;
		xrLabel17.Name = "xrLabel17";
		xrLabel17.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel17.SizeF = new SizeF(88f, 23f);
		xrLabel17.StylePriority.UseBorders = false;
		xrLabel17.StylePriority.UseFont = false;
		xrLabel17.StylePriority.UseTextAlignment = false;
		xrSummary2.Running = SummaryRunning.Group;
		xrLabel17.Summary = xrSummary2;
		xrLabel17.TextAlignment = TextAlignment.MiddleRight;
		xrLabel17.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel18.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel18.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SD])")
		});
		xrLabel18.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel18.LocationFloat = new PointFloat(323.7917f, 0f);
		xrLabel18.Multiline = true;
		xrLabel18.Name = "xrLabel18";
		xrLabel18.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel18.SizeF = new SizeF(88f, 23f);
		xrLabel18.StylePriority.UseBorders = false;
		xrLabel18.StylePriority.UseFont = false;
		xrLabel18.StylePriority.UseTextAlignment = false;
		xrSummary3.Running = SummaryRunning.Group;
		xrLabel18.Summary = xrSummary3;
		xrLabel18.TextAlignment = TextAlignment.MiddleRight;
		xrLabel18.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel19.Borders = BorderSide.All;
		xrLabel19.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SMC])")
		});
		xrLabel19.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel19.LocationFloat = new PointFloat(235.7917f, 0f);
		xrLabel19.Multiline = true;
		xrLabel19.Name = "xrLabel19";
		xrLabel19.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel19.SizeF = new SizeF(88f, 23f);
		xrLabel19.StylePriority.UseBorders = false;
		xrLabel19.StylePriority.UseFont = false;
		xrLabel19.StylePriority.UseTextAlignment = false;
		xrSummary4.Running = SummaryRunning.Group;
		xrLabel19.Summary = xrSummary4;
		xrLabel19.TextAlignment = TextAlignment.MiddleRight;
		xrLabel19.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel20.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel20.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SMD])")
		});
		xrLabel20.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel20.LocationFloat = new PointFloat(147.7917f, 0f);
		xrLabel20.Multiline = true;
		xrLabel20.Name = "xrLabel20";
		xrLabel20.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel20.SizeF = new SizeF(88f, 23f);
		xrLabel20.StylePriority.UseBorders = false;
		xrLabel20.StylePriority.UseFont = false;
		xrLabel20.StylePriority.UseTextAlignment = false;
		xrSummary5.Running = SummaryRunning.Group;
		xrLabel20.Summary = xrSummary5;
		xrLabel20.TextAlignment = TextAlignment.MiddleRight;
		xrLabel20.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel21.Borders = BorderSide.All;
		xrLabel21.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SCUMC])")
		});
		xrLabel21.Font = new Font("Arial", 9f, FontStyle.Bold);
		xrLabel21.LocationFloat = new PointFloat(587.7916f, 0f);
		xrLabel21.Multiline = true;
		xrLabel21.Name = "xrLabel21";
		xrLabel21.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel21.SizeF = new SizeF(88f, 23f);
		xrLabel21.StylePriority.UseBorders = false;
		xrLabel21.StylePriority.UseFont = false;
		xrLabel21.StylePriority.UseTextAlignment = false;
		xrSummary6.Running = SummaryRunning.Group;
		xrLabel21.Summary = xrSummary6;
		xrLabel21.TextAlignment = TextAlignment.MiddleRight;
		xrLabel21.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		PageFooter.HeightF = 26.04167f;
		PageFooter.Name = "PageFooter";
		xrPageInfo1.LocationFloat = new PointFloat(575f, 0f);
		xrPageInfo1.Name = "xrPageInfo1";
		xrPageInfo1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo1.SizeF = new SizeF(100f, 23f);
		xrPageInfo1.StylePriority.UseTextAlignment = false;
		xrPageInfo1.TextAlignment = TextAlignment.MiddleRight;
		xrPageInfo1.TextFormatString = "Page {0} sur {1}";
		base.Bands.AddRange(new Band[7] { TopMargin, BottomMargin, Detail, PageHeader, GroupHeader1, GroupFooter1, PageFooter });
		Font = new Font("Arial", 9.75f);
		base.Margins = new Margins(78, 64, 24, 26);
		base.PageHeight = 1169;
		base.PageWidth = 827;
		base.PaperKind = PaperKind.A4;
		base.ScriptLanguage = ScriptLanguage.VisualBasic;
		base.Version = "20.1";
		((ISupportInitialize)this).EndInit();
	}
}
