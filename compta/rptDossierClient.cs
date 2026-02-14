using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraReports.UI;

namespace compta;

public class rptDossierClient : XtraReport
{
	private IContainer components;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private DetailBand Detail;

	private XRSubreport xrSubreport2;

	private XRSubreport xrSubreport1;

	private XRSubreport xrSubreport3;

	public rptDossierClient()
	{
		InitializeComponent();
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
		TopMargin = new TopMarginBand();
		BottomMargin = new BottomMarginBand();
		Detail = new DetailBand();
		xrSubreport1 = new XRSubreport();
		xrSubreport2 = new XRSubreport();
		xrSubreport3 = new XRSubreport();
		((ISupportInitialize)this).BeginInit();
		TopMargin.Name = "TopMargin";
		BottomMargin.Name = "BottomMargin";
		Detail.Controls.AddRange(new XRControl[3] { xrSubreport3, xrSubreport2, xrSubreport1 });
		Detail.Name = "Detail";
		xrSubreport1.GenerateOwnPages = true;
		xrSubreport1.LocationFloat = new PointFloat(0f, 0f);
		xrSubreport1.Name = "xrSubreport1";
		xrSubreport1.ReportSource = new rptBalanceGenerale();
		xrSubreport1.SizeF = new SizeF(650f, 23f);
		xrSubreport2.GenerateOwnPages = true;
		xrSubreport2.LocationFloat = new PointFloat(0f, 35.41667f);
		xrSubreport2.Name = "xrSubreport2";
		xrSubreport2.ReportSource = new rptGrandJournal();
		xrSubreport2.SizeF = new SizeF(650f, 23f);
		xrSubreport3.GenerateOwnPages = true;
		xrSubreport3.LocationFloat = new PointFloat(0f, 76.99998f);
		xrSubreport3.Name = "xrSubreport3";
		xrSubreport3.ReportSource = new rptJournaux();
		xrSubreport3.SizeF = new SizeF(650f, 23f);
		base.Bands.AddRange(new Band[3] { TopMargin, BottomMargin, Detail });
		Font = new Font("Arial", 9.75f);
		base.Version = "20.1";
		((ISupportInitialize)this).EndInit();
	}
}
