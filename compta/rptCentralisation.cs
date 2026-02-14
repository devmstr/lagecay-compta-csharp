using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace compta;

public class rptCentralisation : XtraReport
{
	private IContainer components;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private DetailBand Detail;

	private PageHeaderBand PageHeader;

	private GroupHeaderBand GroupHeader1;

	private GroupFooterBand GroupFooter1;

	private PageFooterBand PageFooter;

	private ReportFooterBand ReportFooter;

	private XRLabel xrLabel2;

	private XRLabel xrLabel1;

	private XRLabel xrLabel3;

	private XRLabel xrLabel4;

	private XRLabel xrLabel5;

	private XRLabel xrLabel6;

	private XRLabel xrLabel7;

	private XRLabel xrLabel8;

	private XRLabel xrLabel9;

	private XRLabel xrLabel10;

	private XRLabel xrLabel11;

	private XRLabel xrLabel12;

	private XRLabel xrLabel13;

	private XRLabel xrLabel14;

	private XRLabel Dossier;

	private XRPageInfo xrPageInfo1;

	private XRLabel Titre;

	private XRLabel Periode;

	public rptCentralisation()
	{
		InitializeComponent();
	}

	private void GroupHeader1_BeforePrint(object sender, PrintEventArgs e)
	{
		int m = GetCurrentColumnValue<short>("MM");
		Periode.Text = "Centralisation du mois:  " + monModule.gMois[m];
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
		xrLabel2 = new XRLabel();
		xrLabel1 = new XRLabel();
		xrLabel3 = new XRLabel();
		xrLabel4 = new XRLabel();
		PageHeader = new PageHeaderBand();
		Dossier = new XRLabel();
		xrPageInfo1 = new XRPageInfo();
		Titre = new XRLabel();
		GroupHeader1 = new GroupHeaderBand();
		Periode = new XRLabel();
		xrLabel5 = new XRLabel();
		xrLabel6 = new XRLabel();
		xrLabel7 = new XRLabel();
		xrLabel8 = new XRLabel();
		GroupFooter1 = new GroupFooterBand();
		xrLabel9 = new XRLabel();
		xrLabel10 = new XRLabel();
		xrLabel11 = new XRLabel();
		PageFooter = new PageFooterBand();
		ReportFooter = new ReportFooterBand();
		xrLabel12 = new XRLabel();
		xrLabel13 = new XRLabel();
		xrLabel14 = new XRLabel();
		((ISupportInitialize)this).BeginInit();
		TopMargin.HeightF = 27.08333f;
		TopMargin.Name = "TopMargin";
		BottomMargin.HeightF = 27.08333f;
		BottomMargin.Name = "BottomMargin";
		Detail.Controls.AddRange(new XRControl[4] { xrLabel2, xrLabel1, xrLabel3, xrLabel4 });
		Detail.HeightF = 27.085f;
		Detail.Name = "Detail";
		xrLabel2.Borders = BorderSide.None;
		xrLabel2.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[LIBJA]")
		});
		xrLabel2.LocationFloat = new PointFloat(110f, (float)Math.E * 63f / 274f);
		xrLabel2.Multiline = true;
		xrLabel2.Name = "xrLabel2";
		xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.SizeF = new SizeF(336.6631f, 26.45833f);
		xrLabel2.StylePriority.UseBorders = false;
		xrLabel2.StylePriority.UseTextAlignment = false;
		xrLabel2.Text = "xrLabel2";
		xrLabel2.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel1.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[JA]")
		});
		xrLabel1.LocationFloat = new PointFloat(9.999998f, (float)Math.E * 63f / 274f);
		xrLabel1.Multiline = true;
		xrLabel1.Name = "xrLabel1";
		xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel1.SizeF = new SizeF(100f, 26.45833f);
		xrLabel1.StylePriority.UseBorders = false;
		xrLabel1.StylePriority.UseTextAlignment = false;
		xrLabel1.Text = "xrLabel1";
		xrLabel1.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel3.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel3.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SDEB]")
		});
		xrLabel3.LocationFloat = new PointFloat(446.6632f, (float)Math.E * 63f / 274f);
		xrLabel3.Multiline = true;
		xrLabel3.Name = "xrLabel3";
		xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel3.SizeF = new SizeF(154.17f, 26.46f);
		xrLabel3.StylePriority.UseBorders = false;
		xrLabel3.StylePriority.UseTextAlignment = false;
		xrLabel3.Text = "xrLabel3";
		xrLabel3.TextAlignment = TextAlignment.MiddleRight;
		xrLabel3.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel4.Borders = BorderSide.Right;
		xrLabel4.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SCRE]")
		});
		xrLabel4.LocationFloat = new PointFloat(600.8333f, (float)Math.E * 63f / 274f);
		xrLabel4.Multiline = true;
		xrLabel4.Name = "xrLabel4";
		xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel4.SizeF = new SizeF(154.1667f, 26.45833f);
		xrLabel4.StylePriority.UseBorders = false;
		xrLabel4.StylePriority.UseTextAlignment = false;
		xrLabel4.Text = "xrLabel4";
		xrLabel4.TextAlignment = TextAlignment.MiddleRight;
		xrLabel4.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		PageHeader.Controls.AddRange(new XRControl[3] { Dossier, xrPageInfo1, Titre });
		PageHeader.HeightF = 52.08333f;
		PageHeader.Name = "PageHeader";
		Dossier.Font = new Font("Arial", 11f, FontStyle.Bold);
		Dossier.LocationFloat = new PointFloat(9.999998f, 0f);
		Dossier.Multiline = true;
		Dossier.Name = "Dossier";
		Dossier.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Dossier.SizeF = new SizeF(538.3753f, 23f);
		Dossier.StylePriority.UseFont = false;
		Dossier.StylePriority.UseTextAlignment = false;
		Dossier.Text = "Balance des Soldes";
		Dossier.TextAlignment = TextAlignment.MiddleLeft;
		xrPageInfo1.LocationFloat = new PointFloat(654.9999f, 0f);
		xrPageInfo1.Name = "xrPageInfo1";
		xrPageInfo1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo1.SizeF = new SizeF(100f, 23f);
		xrPageInfo1.StylePriority.UseTextAlignment = false;
		xrPageInfo1.TextAlignment = TextAlignment.MiddleRight;
		xrPageInfo1.TextFormatString = "Page {0} sur {1}";
		Titre.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[Exercice]")
		});
		Titre.Font = new Font("Arial", 11f, FontStyle.Bold);
		Titre.LocationFloat = new PointFloat(9.999998f, 23f);
		Titre.Multiline = true;
		Titre.Name = "Titre";
		Titre.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Titre.SizeF = new SizeF(745f, 23.00001f);
		Titre.StylePriority.UseFont = false;
		Titre.StylePriority.UseTextAlignment = false;
		Titre.Text = "Centralisation";
		Titre.TextAlignment = TextAlignment.MiddleCenter;
		GroupHeader1.Controls.AddRange(new XRControl[5] { Periode, xrLabel5, xrLabel6, xrLabel7, xrLabel8 });
		GroupHeader1.GroupFields.AddRange(new GroupField[1]
		{
			new GroupField("MM", XRColumnSortOrder.Ascending)
		});
		GroupHeader1.GroupUnion = GroupUnion.WholePage;
		GroupHeader1.HeightF = 56.46f;
		GroupHeader1.Name = "GroupHeader1";
		GroupHeader1.RepeatEveryPage = true;
		GroupHeader1.BeforePrint += GroupHeader1_BeforePrint;
		Periode.Font = new Font("Arial", 11f, FontStyle.Bold);
		Periode.LocationFloat = new PointFloat(10.00001f, 0f);
		Periode.Multiline = true;
		Periode.Name = "Periode";
		Periode.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Periode.SizeF = new SizeF(745f, 23f);
		Periode.StylePriority.UseFont = false;
		Periode.StylePriority.UseTextAlignment = false;
		Periode.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel5.Borders = BorderSide.All;
		xrLabel5.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel5.LocationFloat = new PointFloat(9.999998f, 30f);
		xrLabel5.Multiline = true;
		xrLabel5.Name = "xrLabel5";
		xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.SizeF = new SizeF(100f, 26.45833f);
		xrLabel5.StylePriority.UseBorders = false;
		xrLabel5.StylePriority.UseFont = false;
		xrLabel5.StylePriority.UseTextAlignment = false;
		xrLabel5.Text = "Journal";
		xrLabel5.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel6.Borders = BorderSide.All;
		xrLabel6.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel6.LocationFloat = new PointFloat(446.6631f, 30f);
		xrLabel6.Multiline = true;
		xrLabel6.Name = "xrLabel6";
		xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel6.SizeF = new SizeF(154.17f, 26.46f);
		xrLabel6.StylePriority.UseBorders = false;
		xrLabel6.StylePriority.UseFont = false;
		xrLabel6.StylePriority.UseTextAlignment = false;
		xrLabel6.Text = "Solde Débit";
		xrLabel6.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel6.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel7.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
		xrLabel7.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel7.LocationFloat = new PointFloat(600.8332f, 30f);
		xrLabel7.Multiline = true;
		xrLabel7.Name = "xrLabel7";
		xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel7.SizeF = new SizeF(154.1667f, 26.45833f);
		xrLabel7.StylePriority.UseBorders = false;
		xrLabel7.StylePriority.UseFont = false;
		xrLabel7.StylePriority.UseTextAlignment = false;
		xrLabel7.Text = "Solde Crédit";
		xrLabel7.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel7.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel8.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel8.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel8.LocationFloat = new PointFloat(110f, 30f);
		xrLabel8.Multiline = true;
		xrLabel8.Name = "xrLabel8";
		xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.SizeF = new SizeF(336.6631f, 26.45833f);
		xrLabel8.StylePriority.UseBorders = false;
		xrLabel8.StylePriority.UseFont = false;
		xrLabel8.StylePriority.UseTextAlignment = false;
		xrLabel8.Text = "Intitulé";
		xrLabel8.TextAlignment = TextAlignment.MiddleCenter;
		GroupFooter1.Controls.AddRange(new XRControl[3] { xrLabel9, xrLabel10, xrLabel11 });
		GroupFooter1.GroupUnion = GroupFooterUnion.WithLastDetail;
		GroupFooter1.HeightF = 48.74503f;
		GroupFooter1.Name = "GroupFooter1";
		xrLabel9.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
		xrLabel9.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SCRE])")
		});
		xrLabel9.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel9.LocationFloat = new PointFloat(600.8333f, 0f);
		xrLabel9.Multiline = true;
		xrLabel9.Name = "xrLabel9";
		xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel9.SizeF = new SizeF(154.1667f, 26.45833f);
		xrLabel9.StylePriority.UseBorders = false;
		xrLabel9.StylePriority.UseFont = false;
		xrLabel9.StylePriority.UseTextAlignment = false;
		xrSummary1.Running = SummaryRunning.Group;
		xrLabel9.Summary = xrSummary1;
		xrLabel9.Text = "xrLabel4";
		xrLabel9.TextAlignment = TextAlignment.MiddleRight;
		xrLabel9.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel10.Borders = BorderSide.All;
		xrLabel10.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SDEB])")
		});
		xrLabel10.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel10.LocationFloat = new PointFloat(446.6632f, 0f);
		xrLabel10.Multiline = true;
		xrLabel10.Name = "xrLabel10";
		xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel10.SizeF = new SizeF(154.17f, 26.46f);
		xrLabel10.StylePriority.UseBorders = false;
		xrLabel10.StylePriority.UseFont = false;
		xrLabel10.StylePriority.UseTextAlignment = false;
		xrSummary2.Running = SummaryRunning.Group;
		xrLabel10.Summary = xrSummary2;
		xrLabel10.Text = "xrLabel3";
		xrLabel10.TextAlignment = TextAlignment.MiddleRight;
		xrLabel10.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel11.Borders = BorderSide.Top;
		xrLabel11.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel11.LocationFloat = new PointFloat(9.999998f, 0f);
		xrLabel11.Multiline = true;
		xrLabel11.Name = "xrLabel11";
		xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel11.SizeF = new SizeF(436.6632f, 26.45833f);
		xrLabel11.StylePriority.UseBorders = false;
		xrLabel11.StylePriority.UseFont = false;
		xrLabel11.StylePriority.UseTextAlignment = false;
		xrLabel11.Text = "TOTAUX DU MOIS";
		xrLabel11.TextAlignment = TextAlignment.MiddleRight;
		PageFooter.HeightF = 25f;
		PageFooter.Name = "PageFooter";
		ReportFooter.Controls.AddRange(new XRControl[3] { xrLabel12, xrLabel13, xrLabel14 });
		ReportFooter.HeightF = 29.16336f;
		ReportFooter.KeepTogether = true;
		ReportFooter.Name = "ReportFooter";
		xrLabel12.BackColor = Color.WhiteSmoke;
		xrLabel12.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Bottom;
		xrLabel12.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel12.LocationFloat = new PointFloat(9.999998f, 0f);
		xrLabel12.Multiline = true;
		xrLabel12.Name = "xrLabel12";
		xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel12.SizeF = new SizeF(436.6632f, 26.45833f);
		xrLabel12.StylePriority.UseBackColor = false;
		xrLabel12.StylePriority.UseBorders = false;
		xrLabel12.StylePriority.UseFont = false;
		xrLabel12.StylePriority.UseTextAlignment = false;
		xrLabel12.Text = "TOTAUX GENERAUX";
		xrLabel12.TextAlignment = TextAlignment.MiddleRight;
		xrLabel13.BackColor = Color.WhiteSmoke;
		xrLabel13.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
		xrLabel13.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SCRE])")
		});
		xrLabel13.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel13.LocationFloat = new PointFloat(600.8333f, 0f);
		xrLabel13.Multiline = true;
		xrLabel13.Name = "xrLabel13";
		xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel13.SizeF = new SizeF(154.1667f, 26.45833f);
		xrLabel13.StylePriority.UseBackColor = false;
		xrLabel13.StylePriority.UseBorders = false;
		xrLabel13.StylePriority.UseFont = false;
		xrLabel13.StylePriority.UseTextAlignment = false;
		xrSummary3.Running = SummaryRunning.Report;
		xrLabel13.Summary = xrSummary3;
		xrLabel13.Text = "xrLabel4";
		xrLabel13.TextAlignment = TextAlignment.MiddleRight;
		xrLabel13.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel14.BackColor = Color.WhiteSmoke;
		xrLabel14.Borders = BorderSide.All;
		xrLabel14.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SDEB])")
		});
		xrLabel14.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel14.LocationFloat = new PointFloat(446.6631f, 0f);
		xrLabel14.Multiline = true;
		xrLabel14.Name = "xrLabel14";
		xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel14.SizeF = new SizeF(154.17f, 26.46f);
		xrLabel14.StylePriority.UseBackColor = false;
		xrLabel14.StylePriority.UseBorders = false;
		xrLabel14.StylePriority.UseFont = false;
		xrLabel14.StylePriority.UseTextAlignment = false;
		xrSummary4.Running = SummaryRunning.Report;
		xrLabel14.Summary = xrSummary4;
		xrLabel14.Text = "xrLabel3";
		xrLabel14.TextAlignment = TextAlignment.MiddleRight;
		xrLabel14.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		base.Bands.AddRange(new Band[8] { TopMargin, BottomMargin, Detail, PageHeader, GroupHeader1, GroupFooter1, PageFooter, ReportFooter });
		Font = new Font("Arial", 9.75f);
		base.Margins = new Margins(28, 34, 27, 27);
		base.PageHeight = 1169;
		base.PageWidth = 827;
		base.PaperKind = PaperKind.A4;
		base.ScriptLanguage = ScriptLanguage.VisualBasic;
		base.Version = "20.1";
		((ISupportInitialize)this).EndInit();
	}
}
