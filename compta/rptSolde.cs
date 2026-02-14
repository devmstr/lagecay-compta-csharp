using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace compta;

public class rptSolde : XtraReport
{
	private bool OUV;

	private IContainer components;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private DetailBand Detail;

	private PageHeaderBand PageHeader;

	private GroupHeaderBand GroupHeader1;

	private GroupHeaderBand GroupHeader2;

	private GroupFooterBand GroupFooter1;

	private GroupFooterBand GroupFooter2;

	private PageFooterBand PageFooter;

	private XRLabel xrLabel3;

	private XRLabel xrLabel2;

	private XRLabel xrLabel1;

	private XRLabel xrLabel4;

	private XRLabel xrLabel7;

	private XRLabel xrLabel8;

	private XRLabel xrLabel6;

	private XRLabel xrLabel5;

	private XRLabel re;

	private XRLabel RD;

	private XRLabel RC;

	private XRLabel produits;

	private XRLabel charges;

	private XRLabel pro;

	private XRLabel xrLabel15;

	private XRLabel xrLabel9;

	private XRLabel xrLabel10;

	private XRLabel Dossier;

	private XRLabel Titre;

	private XRLabel Titre1;

	private XRPageInfo xrPageInfo1;

	public rptSolde()
	{
		InitializeComponent();
	}

	public rptSolde(bool ouverture)
	{
		InitializeComponent();
		if (ouverture)
		{
			OUV = true;
		}
	}

	private void GroupFooter1_BeforePrint(object sender, PrintEventArgs e)
	{
		if (!OUV)
		{
			OleDbCommand cmd = new OleDbCommand();
			cmd.Connection = monModule.gbase;
			cmd.CommandText = "Select sum(Ecritures.DEB)-sum(Ecritures.CRE) as c From Ecritures Where Ecritures.Exercice=" + monModule.eExercice + " AND Ecritures.UNI='" + monModule.eUNI + "' AND (Ecritures.CPT LIKE '7%') ";
			object t = cmd.ExecuteScalar();
			decimal S7 = ((t == DBNull.Value) ? 0m : Math.Abs(Convert.ToDecimal(t)));
			cmd.CommandText = "Select sum(Ecritures.DEB)-sum(Ecritures.CRE) as c From Ecritures Where Ecritures.Exercice=" + monModule.eExercice + " AND Ecritures.UNI='" + monModule.eUNI + "' AND (Ecritures.CPT LIKE '6%') ";
			t = cmd.ExecuteScalar();
			decimal S8 = ((t == DBNull.Value) ? 0m : Math.Abs(Convert.ToDecimal(t)));
			charges.Text = S8.ToString("#,##0.00;#,##0.00; ");
			produits.Text = S7.ToString("#,##0.00;#,##0.00; ");
			if (S7 < S8)
			{
				RD.Text = (S8 - S7).ToString("#,##0.00;#,##0.00; ");
				RC.Text = "";
			}
			else
			{
				RC.Text = (S7 - S8).ToString("#,##0.00;#,##0.00; ");
				RD.Text = "";
			}
		}
	}

	private void PageHeader_BeforePrint(object sender, PrintEventArgs e)
	{
		if (OUV)
		{
			Dossier.Text = monModule.eUNI + " : " + monModule.eUNILIB;
			Titre1.Text = "Journal Ouverture";
			Titre.Text = "Exercice " + monModule.eExercice;
			RD.Visible = false;
			RC.Visible = false;
			produits.Visible = false;
			charges.Visible = false;
			pro.Visible = false;
			re.Visible = false;
		}
		else
		{
			Dossier.Text = monModule.eUNI + " : " + monModule.eUNILIB;
			Titre.Text = "au mois de " + monModule.gMois[monModule.eMOIS] + " " + monModule.eExercice;
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
		xrLabel3 = new XRLabel();
		xrLabel2 = new XRLabel();
		xrLabel1 = new XRLabel();
		xrLabel4 = new XRLabel();
		PageHeader = new PageHeaderBand();
		Titre1 = new XRLabel();
		Dossier = new XRLabel();
		Titre = new XRLabel();
		GroupHeader1 = new GroupHeaderBand();
		xrLabel7 = new XRLabel();
		xrLabel8 = new XRLabel();
		xrLabel6 = new XRLabel();
		xrLabel5 = new XRLabel();
		GroupHeader2 = new GroupHeaderBand();
		GroupFooter1 = new GroupFooterBand();
		re = new XRLabel();
		RD = new XRLabel();
		RC = new XRLabel();
		produits = new XRLabel();
		charges = new XRLabel();
		pro = new XRLabel();
		xrLabel15 = new XRLabel();
		xrLabel9 = new XRLabel();
		xrLabel10 = new XRLabel();
		GroupFooter2 = new GroupFooterBand();
		PageFooter = new PageFooterBand();
		xrPageInfo1 = new XRPageInfo();
		((ISupportInitialize)this).BeginInit();
		TopMargin.HeightF = 49.08333f;
		TopMargin.Name = "TopMargin";
		BottomMargin.HeightF = 49.19847f;
		BottomMargin.Name = "BottomMargin";
		Detail.Borders = BorderSide.All;
		Detail.Controls.AddRange(new XRControl[4] { xrLabel3, xrLabel2, xrLabel1, xrLabel4 });
		Detail.HeightF = 26.45833f;
		Detail.Name = "Detail";
		Detail.StylePriority.UseBorders = false;
		xrLabel3.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel3.CanGrow = false;
		xrLabel3.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SDEBIT]")
		});
		xrLabel3.LocationFloat = new PointFloat(450f, 0f);
		xrLabel3.Multiline = true;
		xrLabel3.Name = "xrLabel3";
		xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel3.SizeF = new SizeF(123.9583f, 26.45833f);
		xrLabel3.StylePriority.UseBorders = false;
		xrLabel3.StylePriority.UseTextAlignment = false;
		xrLabel3.Text = "xrLabel3";
		xrLabel3.TextAlignment = TextAlignment.MiddleRight;
		xrLabel3.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel2.Borders = BorderSide.None;
		xrLabel2.CanGrow = false;
		xrLabel2.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[LIB]")
		});
		xrLabel2.LocationFloat = new PointFloat(135.4584f, 0f);
		xrLabel2.Multiline = true;
		xrLabel2.Name = "xrLabel2";
		xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.SizeF = new SizeF(314.5416f, 26.45833f);
		xrLabel2.StylePriority.UseBorders = false;
		xrLabel2.StylePriority.UseTextAlignment = false;
		xrLabel2.Text = "xrLabel2";
		xrLabel2.TextAlignment = TextAlignment.MiddleLeft;
		xrLabel1.BorderDashStyle = BorderDashStyle.Solid;
		xrLabel1.Borders = BorderSide.Left | BorderSide.Right;
		xrLabel1.CanGrow = false;
		xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[Compte]")
		});
		xrLabel1.LocationFloat = new PointFloat(35.45847f, 0f);
		xrLabel1.Multiline = true;
		xrLabel1.Name = "xrLabel1";
		xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel1.SizeF = new SizeF(100f, 26.45833f);
		xrLabel1.StylePriority.UseBorderDashStyle = false;
		xrLabel1.StylePriority.UseBorders = false;
		xrLabel1.StylePriority.UseTextAlignment = false;
		xrLabel1.Text = "xrLabel1";
		xrLabel1.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel4.Borders = BorderSide.Right;
		xrLabel4.CanGrow = false;
		xrLabel4.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "[SCREDIT]")
		});
		xrLabel4.LocationFloat = new PointFloat(575f, 0f);
		xrLabel4.Multiline = true;
		xrLabel4.Name = "xrLabel4";
		xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel4.SizeF = new SizeF(125f, 26.45833f);
		xrLabel4.StylePriority.UseBorders = false;
		xrLabel4.StylePriority.UseTextAlignment = false;
		xrLabel4.Text = "xrLabel4";
		xrLabel4.TextAlignment = TextAlignment.MiddleRight;
		xrLabel4.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		PageHeader.Controls.AddRange(new XRControl[4] { xrPageInfo1, Titre1, Dossier, Titre });
		PageHeader.HeightF = 74.75986f;
		PageHeader.Name = "PageHeader";
		PageHeader.BeforePrint += PageHeader_BeforePrint;
		Titre1.Font = new Font("Arial", 11f, FontStyle.Bold);
		Titre1.LocationFloat = new PointFloat(35.45864f, 23f);
		Titre1.Multiline = true;
		Titre1.Name = "Titre1";
		Titre1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Titre1.SizeF = new SizeF(664.5415f, 23.00001f);
		Titre1.StylePriority.UseFont = false;
		Titre1.StylePriority.UseTextAlignment = false;
		Titre1.Text = "Balance des Soldes";
		Titre1.TextAlignment = TextAlignment.MiddleCenter;
		Dossier.Font = new Font("Arial", 11f, FontStyle.Bold);
		Dossier.LocationFloat = new PointFloat(34.99999f, 0f);
		Dossier.Multiline = true;
		Dossier.Name = "Dossier";
		Dossier.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Dossier.SizeF = new SizeF(449.375f, 23f);
		Dossier.StylePriority.UseFont = false;
		Dossier.StylePriority.UseTextAlignment = false;
		Dossier.Text = "Balance des Soldes";
		Dossier.TextAlignment = TextAlignment.MiddleLeft;
		Titre.Font = new Font("Arial", 11f, FontStyle.Bold);
		Titre.LocationFloat = new PointFloat(34.45846f, 46f);
		Titre.Multiline = true;
		Titre.Name = "Titre";
		Titre.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		Titre.SizeF = new SizeF(664.9999f, 23.00001f);
		Titre.StylePriority.UseFont = false;
		Titre.StylePriority.UseTextAlignment = false;
		Titre.Text = "au mois";
		Titre.TextAlignment = TextAlignment.MiddleCenter;
		GroupHeader1.Controls.AddRange(new XRControl[4] { xrLabel7, xrLabel8, xrLabel6, xrLabel5 });
		GroupHeader1.GroupUnion = GroupUnion.WholePage;
		GroupHeader1.HeightF = 26.99006f;
		GroupHeader1.Level = 1;
		GroupHeader1.Name = "GroupHeader1";
		xrLabel7.BackColor = Color.WhiteSmoke;
		xrLabel7.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
		xrLabel7.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel7.LocationFloat = new PointFloat(575.0001f, 0f);
		xrLabel7.Multiline = true;
		xrLabel7.Name = "xrLabel7";
		xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel7.SizeF = new SizeF(125f, 26.45833f);
		xrLabel7.StylePriority.UseBackColor = false;
		xrLabel7.StylePriority.UseBorders = false;
		xrLabel7.StylePriority.UseFont = false;
		xrLabel7.StylePriority.UseTextAlignment = false;
		xrLabel7.Text = "Crédit";
		xrLabel7.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel8.BackColor = Color.WhiteSmoke;
		xrLabel8.Borders = BorderSide.Top | BorderSide.Bottom;
		xrLabel8.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel8.LocationFloat = new PointFloat(135f, 0f);
		xrLabel8.Multiline = true;
		xrLabel8.Name = "xrLabel8";
		xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.SizeF = new SizeF(315.0001f, 26.45833f);
		xrLabel8.StylePriority.UseBackColor = false;
		xrLabel8.StylePriority.UseBorders = false;
		xrLabel8.StylePriority.UseFont = false;
		xrLabel8.StylePriority.UseTextAlignment = false;
		xrLabel8.Text = "Intitulé";
		xrLabel8.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel6.BackColor = Color.WhiteSmoke;
		xrLabel6.Borders = BorderSide.All;
		xrLabel6.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel6.LocationFloat = new PointFloat(450.0001f, 0f);
		xrLabel6.Multiline = true;
		xrLabel6.Name = "xrLabel6";
		xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel6.SizeF = new SizeF(123.9583f, 26.45833f);
		xrLabel6.StylePriority.UseBackColor = false;
		xrLabel6.StylePriority.UseBorders = false;
		xrLabel6.StylePriority.UseFont = false;
		xrLabel6.StylePriority.UseTextAlignment = false;
		xrLabel6.Text = "Débit";
		xrLabel6.TextAlignment = TextAlignment.MiddleCenter;
		xrLabel5.BackColor = Color.WhiteSmoke;
		xrLabel5.Borders = BorderSide.All;
		xrLabel5.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel5.LocationFloat = new PointFloat(35f, 0f);
		xrLabel5.Multiline = true;
		xrLabel5.Name = "xrLabel5";
		xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.SizeF = new SizeF(100f, 26.45833f);
		xrLabel5.StylePriority.UseBackColor = false;
		xrLabel5.StylePriority.UseBorders = false;
		xrLabel5.StylePriority.UseFont = false;
		xrLabel5.StylePriority.UseTextAlignment = false;
		xrLabel5.Text = "Compte";
		xrLabel5.TextAlignment = TextAlignment.MiddleCenter;
		GroupHeader2.GroupFields.AddRange(new GroupField[1]
		{
			new GroupField("UN", XRColumnSortOrder.Ascending)
		});
		GroupHeader2.HeightF = 0f;
		GroupHeader2.Name = "GroupHeader2";
		GroupFooter1.Controls.AddRange(new XRControl[9] { re, RD, RC, produits, charges, pro, xrLabel15, xrLabel9, xrLabel10 });
		GroupFooter1.GroupUnion = GroupFooterUnion.WithLastDetail;
		GroupFooter1.HeightF = 96.65683f;
		GroupFooter1.Level = 1;
		GroupFooter1.Name = "GroupFooter1";
		GroupFooter1.BeforePrint += GroupFooter1_BeforePrint;
		re.Borders = BorderSide.None;
		re.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		re.LocationFloat = new PointFloat(34.99999f, 53.91668f);
		re.Multiline = true;
		re.Name = "re";
		re.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		re.SizeF = new SizeF(415f, 26.45832f);
		re.StylePriority.UseBorders = false;
		re.StylePriority.UseFont = false;
		re.StylePriority.UseTextAlignment = false;
		re.Text = "Résultat";
		re.TextAlignment = TextAlignment.MiddleRight;
		RD.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
		RD.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		RD.LocationFloat = new PointFloat(450f, 53.91668f);
		RD.Multiline = true;
		RD.Name = "RD";
		RD.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		RD.SizeF = new SizeF(123.9583f, 26.45833f);
		RD.StylePriority.UseBorders = false;
		RD.StylePriority.UseFont = false;
		RD.StylePriority.UseTextAlignment = false;
		RD.TextAlignment = TextAlignment.MiddleRight;
		RD.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		RC.Borders = BorderSide.Right | BorderSide.Bottom;
		RC.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		RC.LocationFloat = new PointFloat(575f, 53.91668f);
		RC.Multiline = true;
		RC.Name = "RC";
		RC.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		RC.SizeF = new SizeF(125f, 26.45833f);
		RC.StylePriority.UseBorders = false;
		RC.StylePriority.UseFont = false;
		RC.StylePriority.UseTextAlignment = false;
		RC.TextAlignment = TextAlignment.MiddleRight;
		RC.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		produits.Borders = BorderSide.Right | BorderSide.Bottom;
		produits.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		produits.LocationFloat = new PointFloat(575.0001f, 27.45833f);
		produits.Multiline = true;
		produits.Name = "produits";
		produits.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		produits.SizeF = new SizeF(125f, 26.45833f);
		produits.StylePriority.UseBorders = false;
		produits.StylePriority.UseFont = false;
		produits.StylePriority.UseTextAlignment = false;
		produits.TextAlignment = TextAlignment.MiddleRight;
		produits.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		charges.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
		charges.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		charges.LocationFloat = new PointFloat(450.0001f, 27.45833f);
		charges.Multiline = true;
		charges.Name = "charges";
		charges.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		charges.SizeF = new SizeF(123.9583f, 26.45833f);
		charges.StylePriority.UseBorders = false;
		charges.StylePriority.UseFont = false;
		charges.StylePriority.UseTextAlignment = false;
		charges.TextAlignment = TextAlignment.MiddleRight;
		charges.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		pro.Borders = BorderSide.None;
		pro.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		pro.LocationFloat = new PointFloat(34.45847f, 27.45833f);
		pro.Multiline = true;
		pro.Name = "pro";
		pro.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		pro.SizeF = new SizeF(415f, 26.45833f);
		pro.StylePriority.UseBorders = false;
		pro.StylePriority.UseFont = false;
		pro.StylePriority.UseTextAlignment = false;
		pro.Text = "Charges/Produits";
		pro.TextAlignment = TextAlignment.MiddleRight;
		xrLabel15.Borders = BorderSide.Top;
		xrLabel15.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel15.LocationFloat = new PointFloat(34.99999f, 0f);
		xrLabel15.Multiline = true;
		xrLabel15.Name = "xrLabel15";
		xrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel15.SizeF = new SizeF(415f, 26.45833f);
		xrLabel15.StylePriority.UseBorders = false;
		xrLabel15.StylePriority.UseFont = false;
		xrLabel15.StylePriority.UseTextAlignment = false;
		xrLabel15.Text = "Total";
		xrLabel15.TextAlignment = TextAlignment.MiddleRight;
		xrLabel9.Borders = BorderSide.All;
		xrLabel9.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SDEBIT])")
		});
		xrLabel9.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel9.LocationFloat = new PointFloat(450f, 0f);
		xrLabel9.Multiline = true;
		xrLabel9.Name = "xrLabel9";
		xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel9.SizeF = new SizeF(123.9583f, 26.45833f);
		xrLabel9.StylePriority.UseBorders = false;
		xrLabel9.StylePriority.UseFont = false;
		xrLabel9.StylePriority.UseTextAlignment = false;
		xrSummary1.Running = SummaryRunning.Group;
		xrLabel9.Summary = xrSummary1;
		xrLabel9.Text = "xrLabel3";
		xrLabel9.TextAlignment = TextAlignment.MiddleRight;
		xrLabel9.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		xrLabel10.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
		xrLabel10.ExpressionBindings.AddRange(new ExpressionBinding[1]
		{
			new ExpressionBinding("BeforePrint", "Text", "sumSum([SCREDIT])")
		});
		xrLabel10.Font = new Font("Arial", 9.75f, FontStyle.Bold);
		xrLabel10.LocationFloat = new PointFloat(575f, 0f);
		xrLabel10.Multiline = true;
		xrLabel10.Name = "xrLabel10";
		xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel10.SizeF = new SizeF(125f, 26.45833f);
		xrLabel10.StylePriority.UseBorders = false;
		xrLabel10.StylePriority.UseFont = false;
		xrLabel10.StylePriority.UseTextAlignment = false;
		xrSummary2.Running = SummaryRunning.Group;
		xrLabel10.Summary = xrSummary2;
		xrLabel10.Text = "xrLabel4";
		xrLabel10.TextAlignment = TextAlignment.MiddleRight;
		xrLabel10.TextFormatString = "{0:#,##0.00;(#,##0.00); }";
		GroupFooter2.HeightF = 0f;
		GroupFooter2.Name = "GroupFooter2";
		PageFooter.HeightF = 22.11514f;
		PageFooter.Name = "PageFooter";
		xrPageInfo1.LocationFloat = new PointFloat(600.0001f, 0f);
		xrPageInfo1.Name = "xrPageInfo1";
		xrPageInfo1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo1.SizeF = new SizeF(99.99998f, 23f);
		xrPageInfo1.StylePriority.UseTextAlignment = false;
		xrPageInfo1.TextAlignment = TextAlignment.MiddleRight;
		xrPageInfo1.TextFormatString = "Page {0} sur {1}";
		base.Bands.AddRange(new Band[9] { TopMargin, BottomMargin, Detail, PageHeader, GroupHeader1, GroupHeader2, GroupFooter1, GroupFooter2, PageFooter });
		Font = new Font("Arial", 9.75f);
		base.Margins = new Margins(34, 57, 49, 49);
		base.PageHeight = 1169;
		base.PageWidth = 827;
		base.PaperKind = PaperKind.A4;
		base.ScriptLanguage = ScriptLanguage.VisualBasic;
		base.Version = "20.1";
		((ISupportInitialize)this).EndInit();
	}
}
