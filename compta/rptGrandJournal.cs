using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace compta;

public class rptGrandJournal : XtraReport
{
	private IContainer components;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private DetailBand Detail;

	private PageHeaderBand PageHeader;

	private PageFooterBand PageFooter;

	private GroupHeaderBand GroupHeader1;

	private GroupFooterBand GroupFooter1;

	private GroupHeaderBand GroupHeader2;

	private GroupFooterBand GroupFooter2;

	private XRLabel xrLabel8;

	private XRLabel xrLabel7;

	private XRLabel xrLabel6;

	private XRLabel xrLabel5;

	private XRLabel xrLabel4;

	private XRLabel xrLabel3;

	private XRLabel xrLabel9;

	private XRLabel xrLabel10;

	private XRLabel xrLabel11;

	private XRLabel xrLabel12;

	private XRLabel xrLabel13;

	private XRLabel xrLabel14;

	private XRLabel xrLabel2;

	private XRLabel xrLabel1;

	private XRLabel Dossier;

	private XRLabel Titre1;

	private XRLabel periode;

	private XRLabel xrLabel17;

	private XRLabel SommeD;

	private XRLabel SommeC;

	private XRLabel xrLabel20;

	private XRLabel sc;

	private XRLabel sd;

	private XRPageInfo xrPageInfo1;

	public rptGrandJournal()
	{
		InitializeComponent();
	}

	private void PageHeader_BeforePrint(object sender, PrintEventArgs e)
	{
		Dossier.Text = monModule.eUNI + " : " + monModule.eUNILIB;
		periode.Text = monModule.gMois[monModule.eDu] + " -- " + monModule.gMois[monModule.eAU] + " " + monModule.eExercice;
	}

	private void GroupFooter2_BeforePrint(object sender, PrintEventArgs e)
	{
	}

	private void SommeD_AfterPrint(object sender, EventArgs e)
	{
	}

	private void GroupFooter2_AfterPrint(object sender, EventArgs e)
	{
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
		xrLabel8 = new XRLabel();
		xrLabel7 = new XRLabel();
		xrLabel6 = new XRLabel();
		xrLabel5 = new XRLabel();
		xrLabel4 = new XRLabel();
		xrLabel3 = new XRLabel();
		PageHeader = new PageHeaderBand();
		xrPageInfo1 = new XRPageInfo();
		Dossier = new XRLabel();
		Titre1 = new XRLabel();
		periode = new XRLabel();
		PageFooter = new PageFooterBand();
		GroupHeader1 = new GroupHeaderBand();
		GroupFooter1 = new GroupFooterBand();
		GroupHeader2 = new GroupHeaderBand();
		xrLabel9 = new XRLabel();
		xrLabel10 = new XRLabel();
		xrLabel11 = new XRLabel();
		xrLabel12 = new XRLabel();
		xrLabel13 = new XRLabel();
		xrLabel14 = new XRLabel();
		xrLabel2 = new XRLabel();
		xrLabel1 = new XRLabel();
		GroupFooter2 = new GroupFooterBand();
		xrLabel20 = new XRLabel();
		sc = new XRLabel();
		sd = new XRLabel();
		xrLabel17 = new XRLabel();
		SommeD = new XRLabel();
		SommeC = new XRLabel();
		((ISupportInitialize)this).BeginInit();
		TopMargin.HeightF = 22.91667f;
		TopMargin.Name = "TopMargin";
		BottomMargin.HeightF = 25.95838f;
		BottomMargin.Name = "BottomMargin";
		Detail.Controls.AddRange(new XRControl[6] { xrLabel8, xrLabel7, xrLabel6, xrLabel5, xrLabel4, xrLabel3 });
		Detail.HeightF = 23f;
		Detail.Name = "Detail";
		xrLabel8.Borders = BorderSide.Right;
		xrLabel8.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[CRE]")
		});
		xrLabel8.LocationFloat = new PointFloat(649.2504f, 0f);
		xrLabel8.Multiline = true;
		xrLabel8.Name = "xrLabel8";
		xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.SizeF = new SizeF(100.7496f, 23f);
		xrLabel8.StylePriority.UseBorders = false;
		xrLabel8.StylePriority.UseTextAlignment = false;
		xrLabel8.TextAlignment = TextAlignment.MiddleRight;
		xrLabel8.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel7.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel7.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DEB]")
		});
		xrLabel7.LocationFloat = new PointFloat(550.5836f, 0f);
		xrLabel7.Multiline = true;
		xrLabel7.Name = "xrLabel7";
		xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel7.SizeF = new SizeF(98.66681f, 23f);
		xrLabel7.StylePriority.UseBorders = false;
		xrLabel7.StylePriority.UseTextAlignment = false;
		xrLabel7.TextAlignment = TextAlignment.MiddleRight;
		xrLabel7.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel6.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[LIBECR]")
		});
		xrLabel6.LocationFloat = new PointFloat(200.2916f, 0f);
		xrLabel6.Multiline = true;
		xrLabel6.Name = "xrLabel6";
		xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel6.SizeF = new SizeF(350.292f, 23f);
		xrLabel6.StylePriority.UseTextAlignment = false;
		xrLabel6.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel5.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel5.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[NOP]")
		});
		xrLabel5.LocationFloat = new PointFloat(128.4167f, 0f);
		xrLabel5.Multiline = true;
		xrLabel5.Name = "xrLabel5";
		xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.SizeF = new SizeF(71.87499f, 23f);
		xrLabel5.StylePriority.UseBorders = false;
		xrLabel5.StylePriority.UseTextAlignment = false;
		xrLabel5.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel4.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[JA]")
		});
		xrLabel4.LocationFloat = new PointFloat(96.12499f, 0f);
		xrLabel4.Multiline = true;
		xrLabel4.Name = "xrLabel4";
		xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel4.SizeF = new SizeF(32.29166f, 23f);
		xrLabel4.StylePriority.UseTextAlignment = false;
		xrLabel4.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel3.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel3.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[DAT]")
		});
		xrLabel3.LocationFloat = new PointFloat(12.5f, 0f);
		xrLabel3.Multiline = true;
		xrLabel3.Name = "xrLabel3";
		xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel3.SizeF = new SizeF(83.62499f, 23f);
		xrLabel3.StylePriority.UseBorders = false;
		xrLabel3.StylePriority.UseTextAlignment = false;
		xrLabel3.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel3.TextFormatString = "{0:dd-MM-yyyy}";
		PageHeader.Controls.AddRange(new XRControl[4] { xrPageInfo1, Dossier, Titre1, periode });
		PageHeader.HeightF = 73.00001f;
		PageHeader.Name = "PageHeader";
		PageHeader.BeforePrint += PageHeader_BeforePrint;
		xrPageInfo1.LocationFloat = new PointFloat(649.2504f, 0f);
		xrPageInfo1.Name = "xrPageInfo1";
		xrPageInfo1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo1.SizeF = new SizeF(100f, 23f);
		xrPageInfo1.StylePriority.UseTextAlignment = false;
		xrPageInfo1.TextAlignment = TextAlignment.MiddleRight;
		xrPageInfo1.TextFormatString = "Page {0} sur {1}";
		Dossier.Font = new Font("Arial", 11f, FontStyle.Bold);
		Dossier.LocationFloat = new PointFloat(12.5f, 0f);
		Dossier.Multiline = true;
		Dossier.Name = "Dossier";
		Dossier.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Dossier.SizeF = new SizeF(488.5416f, 23.00001f);
		Dossier.StylePriority.UseFont = false;
		Dossier.StylePriority.UseTextAlignment = false;
		Dossier.Text = "Balance des Soldes";
		Dossier.TextAlignment = TextAlignment.MiddleLeft;
		Titre1.Font = new Font("Arial", 11f, FontStyle.Bold);
		Titre1.LocationFloat = new PointFloat(12.5f, 25f);
		Titre1.Multiline = true;
		Titre1.Name = "Titre1";
		Titre1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Titre1.SizeF = new SizeF(737.5f, 23.00001f);
		Titre1.StylePriority.UseFont = false;
		Titre1.StylePriority.UseTextAlignment = false;
		Titre1.Text = "Balance des Soldes";
		Titre1.TextAlignment = TextAlignment.MiddleCenter;
		periode.Font = new Font("Arial", 11f, FontStyle.Bold);
		periode.LocationFloat = new PointFloat(12.5f, 50f);
		periode.Multiline = true;
		periode.Name = "periode";
		periode.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		periode.SizeF = new SizeF(737.5f, 23.00001f);
		periode.StylePriority.UseFont = false;
		periode.StylePriority.UseTextAlignment = false;
		periode.Text = "au mois";
		periode.TextAlignment = TextAlignment.MiddleCenter;
		PageFooter.HeightF = 26.04167f;
		PageFooter.Name = "PageFooter";
		GroupHeader1.GroupFields.AddRange(new GroupField[1]
		{
			new GroupField("MM", XRColumnSortOrder.Ascending)
		});
		GroupHeader1.HeightF = 0f;
		GroupHeader1.Name = "GroupHeader1";
		GroupFooter1.HeightF = 0f;
		GroupFooter1.Name = "GroupFooter1";
		GroupHeader2.Controls.AddRange(new XRControl[8] { xrLabel9, xrLabel10, xrLabel11, xrLabel12, xrLabel13, xrLabel14, xrLabel2, xrLabel1 });
		GroupHeader2.GroupFields.AddRange(new GroupField[2]
		{
			new GroupField("CPT", XRColumnSortOrder.Ascending),
			new GroupField("TRS", XRColumnSortOrder.Ascending)
		});
		GroupHeader2.GroupUnion = GroupUnion.WholePage;
		GroupHeader2.HeightF = 87.5f;
		GroupHeader2.Level = 1;
		GroupHeader2.Name = "GroupHeader2";
		xrLabel9.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
		xrLabel9.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel9.LocationFloat = new PointFloat(649.2504f, 64.00002f);
		xrLabel9.Multiline = true;
		xrLabel9.Name = "xrLabel9";
		xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel9.SizeF = new SizeF(100.7496f, 23f);
		xrLabel9.StylePriority.UseBorders = false;
		xrLabel9.StylePriority.UseFont = false;
		xrLabel9.StylePriority.UseTextAlignment = false;
		xrLabel9.Text = "Crédit";
		xrLabel9.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel10.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel10.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel10.LocationFloat = new PointFloat(200.2919f, 64.00002f);
		xrLabel10.Multiline = true;
		xrLabel10.Name = "xrLabel10";
		xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel10.SizeF = new SizeF(350.292f, 23f);
		xrLabel10.StylePriority.UseBorders = false;
		xrLabel10.StylePriority.UseFont = false;
		xrLabel10.StylePriority.UseTextAlignment = false;
		xrLabel10.Text = "Intitulé";
		xrLabel10.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel11.Borders = BorderSide.All;
		xrLabel11.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel11.LocationFloat = new PointFloat(128.4169f, 64.00002f);
		xrLabel11.Multiline = true;
		xrLabel11.Name = "xrLabel11";
		xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel11.SizeF = new SizeF(71.87499f, 23f);
		xrLabel11.StylePriority.UseBorders = false;
		xrLabel11.StylePriority.UseFont = false;
		xrLabel11.StylePriority.UseTextAlignment = false;
		xrLabel11.Text = "Pièce";
		xrLabel11.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel12.Borders = BorderSide.All;
		xrLabel12.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel12.LocationFloat = new PointFloat(550.5839f, 64.00002f);
		xrLabel12.Multiline = true;
		xrLabel12.Name = "xrLabel12";
		xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel12.SizeF = new SizeF(98.6665f, 23f);
		xrLabel12.StylePriority.UseBorders = false;
		xrLabel12.StylePriority.UseFont = false;
		xrLabel12.StylePriority.UseTextAlignment = false;
		xrLabel12.Text = "Débit";
		xrLabel12.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel13.Borders = BorderSide.All;
		xrLabel13.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel13.LocationFloat = new PointFloat(12.5f, 64.00002f);
		xrLabel13.Multiline = true;
		xrLabel13.Name = "xrLabel13";
		xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel13.SizeF = new SizeF(83.62499f, 23f);
		xrLabel13.StylePriority.UseBorders = false;
		xrLabel13.StylePriority.UseFont = false;
		xrLabel13.StylePriority.UseTextAlignment = false;
		xrLabel13.Text = "Date";
		xrLabel13.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel14.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel14.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel14.LocationFloat = new PointFloat(96.1252f, 64.00002f);
		xrLabel14.Multiline = true;
		xrLabel14.Name = "xrLabel14";
		xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel14.SizeF = new SizeF(32.29166f, 23f);
		xrLabel14.StylePriority.UseBorders = false;
		xrLabel14.StylePriority.UseFont = false;
		xrLabel14.StylePriority.UseTextAlignment = false;
		xrLabel14.Text = "JNL";
		xrLabel14.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel2.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[NOMTRS]")
		});
		xrLabel2.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel2.LocationFloat = new PointFloat(10.00001f, 32.99999f);
		xrLabel2.Multiline = true;
		xrLabel2.Name = "xrLabel2";
		xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.SizeF = new SizeF(740f, 23f);
		xrLabel2.StylePriority.UseFont = false;
		xrLabel2.StylePriority.UseTextAlignment = false;
		xrLabel2.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "Concat([CPT],' ',[LIBCPT])")
		});
		xrLabel1.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel1.LocationFloat = new PointFloat(12.5f, 10.00001f);
		xrLabel1.Multiline = true;
		xrLabel1.Name = "xrLabel1";
		xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel1.SizeF = new SizeF(737.5f, 23f);
		xrLabel1.StylePriority.UseFont = false;
		xrLabel1.StylePriority.UseTextAlignment = false;
		xrLabel1.Text = "NOMTRS";
		xrLabel1.TextAlignment = TextAlignment.MiddleLeft;
		GroupFooter2.Controls.AddRange(new XRControl[6] { xrLabel20, sc, sd, xrLabel17, SommeD, SommeC });
		GroupFooter2.GroupUnion = GroupFooterUnion.WithLastDetail;
		GroupFooter2.HeightF = 63.37506f;
		GroupFooter2.Level = 1;
		GroupFooter2.Name = "GroupFooter2";
		GroupFooter2.BeforePrint += GroupFooter2_BeforePrint;
		GroupFooter2.AfterPrint += GroupFooter2_AfterPrint;
		xrLabel20.Borders = BorderSide.None;
		xrLabel20.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel20.LocationFloat = new PointFloat(14.00027f, 22.99999f);
		xrLabel20.Multiline = true;
		xrLabel20.Name = "xrLabel20";
		xrLabel20.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel20.SizeF = new SizeF(536.5836f, 23f);
		xrLabel20.StylePriority.UseBorders = false;
		xrLabel20.StylePriority.UseFont = false;
		xrLabel20.StylePriority.UseTextAlignment = false;
		xrLabel20.Text = "SOLDE FIN PERIODE";
		xrLabel20.TextAlignment = TextAlignment.MiddleRight;
		sc.Borders = BorderSide.Right | BorderSide.Bottom;
		sc.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "Iif((sumSum([DEB])<sumSum([CRE])),sumSum([CRE])-sumSum([DEB]),0) \n\n")
		});
		sc.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		sc.LocationFloat = new PointFloat(649.2506f, 22.99999f);
		sc.Multiline = true;
		sc.Name = "sc";
		sc.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		sc.SizeF = new SizeF(100.7496f, 23f);
		sc.StylePriority.UseBorders = false;
		sc.StylePriority.UseFont = false;
		sc.StylePriority.UseTextAlignment = false;
		xrSummary1.Running = SummaryRunning.Group;
		sc.Summary = xrSummary1;
		sc.TextAlignment = TextAlignment.MiddleRight;
		sc.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		sd.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
		sd.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "Iif((sumSum([DEB])>sumSum([CRE])),sumSum([DEB])-sumSum([CRE]),0) \n\n")
		});
		sd.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		sd.LocationFloat = new PointFloat(550.5839f, 22.99999f);
		sd.Multiline = true;
		sd.Name = "sd";
		sd.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		sd.SizeF = new SizeF(98.66681f, 23f);
		sd.StylePriority.UseBorders = false;
		sd.StylePriority.UseFont = false;
		sd.StylePriority.UseTextAlignment = false;
		xrSummary2.Running = SummaryRunning.Group;
		sd.Summary = xrSummary2;
		sd.TextAlignment = TextAlignment.MiddleRight;
		sd.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel17.Borders = BorderSide.Top;
		xrLabel17.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel17.LocationFloat = new PointFloat(13.99999f, 0f);
		xrLabel17.Multiline = true;
		xrLabel17.Name = "xrLabel17";
		xrLabel17.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel17.SizeF = new SizeF(536.5836f, 23f);
		xrLabel17.StylePriority.UseBorders = false;
		xrLabel17.StylePriority.UseFont = false;
		xrLabel17.StylePriority.UseTextAlignment = false;
		xrLabel17.Text = "TOTAUX PERIODE";
		xrLabel17.TextAlignment = TextAlignment.MiddleRight;
		SommeD.Borders = BorderSide.All;
		SommeD.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([DEB])")
		});
		SommeD.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		SommeD.LocationFloat = new PointFloat(550.5836f, 0f);
		SommeD.Multiline = true;
		SommeD.Name = "SommeD";
		SommeD.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		SommeD.SizeF = new SizeF(98.66681f, 23f);
		SommeD.StylePriority.UseBorders = false;
		SommeD.StylePriority.UseFont = false;
		SommeD.StylePriority.UseTextAlignment = false;
		xrSummary3.Running = SummaryRunning.Group;
		SommeD.Summary = xrSummary3;
		SommeD.TextAlignment = TextAlignment.MiddleRight;
		SommeD.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		SommeD.AfterPrint += SommeD_AfterPrint;
		SommeC.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
		SommeC.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([CRE])")
		});
		SommeC.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		SommeC.LocationFloat = new PointFloat(649.2504f, 0f);
		SommeC.Multiline = true;
		SommeC.Name = "SommeC";
		SommeC.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		SommeC.SizeF = new SizeF(100.7496f, 23f);
		SommeC.StylePriority.UseBorders = false;
		SommeC.StylePriority.UseFont = false;
		SommeC.StylePriority.UseTextAlignment = false;
		xrSummary4.Running = SummaryRunning.Group;
		SommeC.Summary = xrSummary4;
		SommeC.TextAlignment = TextAlignment.MiddleRight;
		SommeC.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		base.Bands.AddRange(new Band[9] { TopMargin, BottomMargin, Detail, PageHeader, PageFooter, GroupHeader1, GroupFooter1, GroupHeader2, GroupFooter2 });
		Font = new Font("Arial", 9.75f);
		base.Margins = new Margins(35, 32, 23, 26);
		base.PageHeight = 1169;
		base.PageWidth = 827;
		base.PaperKind = PaperKind.A4;
		base.ScriptLanguage = ScriptLanguage.VisualBasic;
		base.Version = "20.1";
		((ISupportInitialize)this).EndInit();
	}
}
