using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using compta.Properties;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Functions;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using DevExpress.XtraSpreadsheet;

namespace compta;

public class frmPrintBilan : XtraForm
{
	private SpreadsheetControl spreadsheetControl1 = new SpreadsheetControl();

	private IWorkbook workbook;

	private IContainer components;

	private CheckEdit tab2;

	private SimpleButton simpleButton1;

	private CheckedListBoxControl chk;

	private CheckEdit tab1;

	private LayoutControl layoutControl1;

	private LayoutControlGroup Root;

	private LayoutControlItem layoutControlItem1;

	private LayoutControlItem layoutControlItem2;

	private LayoutControlItem layoutControlItem3;

	private LayoutControlItem layoutControlItem4;

	private EmptySpaceItem emptySpaceItem1;

	public frmPrintBilan(string fichier)
	{
		InitializeComponent();
		spreadsheetControl1.DocumentLoaded += SpreadsheetControl_DocumentLoaded;
		spreadsheetControl1.BeforePrintSheet += spreadsheetControl_BeforePrintSheet;
		spreadsheetControl1.LoadDocument(fichier, DocumentFormat.Xlsx);
		workbook = spreadsheetControl1.Document;
		ChargerExcel();
	}

	private void spreadsheetControl_BeforePrintSheet(object sender, BeforePrintSheetEventArgs e)
	{
		if (e.Index < 8)
		{
			e.Cancel = chk.Items[e.Index].CheckState == CheckState.Unchecked;
		}
		else
		{
			e.Cancel = true;
		}
	}

	private void ImprimerBilan()
	{
	}

	private void SpreadsheetControl_DocumentLoaded(object sender, EventArgs e)
	{
		workbook.Calculate();
		workbook.CalculateFullRebuild();
		workbook.CalculateFull();
	}

	private void simpleButton1_Click_1(object sender, EventArgs e)
	{
		workbook.Calculate();
		spreadsheetControl1.ShowPrintPreview();
		Close();
	}

	private void ChargerExcel()
	{
		NIF _nif = new NIF();
		ACT _act = new ACT();
		Client _nom = new Client();
		ADRS _adr = new ADRS();
		ACTAR _actar = new ACTAR();
		ClientAR _nomar = new ClientAR();
		ADRSAR _adrar = new ADRSAR();
		Ville _ville = new Ville();
		Commune _commune = new Commune();
		VilleAR _villear = new VilleAR();
		CommuneAR _communear = new CommuneAR();
		Recette _recette = new Recette();
		Inspection _inspection = new Inspection();
		CodePostal _codepostal = new CodePostal();
		Exercice _exercice = new Exercice();
		CodeActivite _codeactivite = new CodeActivite();
		NUMAI _numai = new NUMAI();
		SD _sd = new SD();
		SC _sc = new SC();
		SDP _sdp = new SDP();
		SCP _scp = new SCP();
		SDPF _sdpf = new SDPF();
		SCPF _scpf = new SCPF();
		S _s = new S();
		SS _ss = new SS();
		SP _sp = new SP();
		SSP _ssp = new SSP();
		SF _sf = new SF();
		SPF _spf = new SPF();
		SCF _scf = new SCF();
		SDF _sdf = new SDF();
		MC _mc = new MC();
		MD _md = new MD();
		MCF _mcf = new MCF();
		MDF _mdf = new MDF();
		workbook.DocumentSettings.Calculation.FullCalculationOnLoad = true;
		spreadsheetControl1.Options.CalculationMode = WorkbookCalculationMode.Automatic;
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_actar.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_actar);
			ICustomFunctionDescriptionsRegisterService service = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments = new CustomFunctionArgumentsDescriptionsCollection();
			service.RegisterFunctionDescriptions(_actar.Name, "Activité de l'entreprise", arguments);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_nomar.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_nomar);
			ICustomFunctionDescriptionsRegisterService service2 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service2 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments2 = new CustomFunctionArgumentsDescriptionsCollection();
			service2.RegisterFunctionDescriptions(_nomar.Name, "Nom de l'entreprise", arguments2);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_adrar.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_adrar);
			ICustomFunctionDescriptionsRegisterService service3 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service3 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments3 = new CustomFunctionArgumentsDescriptionsCollection();
			service3.RegisterFunctionDescriptions(_adrar.Name, "Adresse de l'entreprise", arguments3);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_numai.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_numai);
			ICustomFunctionDescriptionsRegisterService service4 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service4 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments4 = new CustomFunctionArgumentsDescriptionsCollection();
			service4.RegisterFunctionDescriptions(_numai.Name, "Numéro d'Article d'Imposition", arguments4);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_codeactivite.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_codeactivite);
			ICustomFunctionDescriptionsRegisterService service5 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service5 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments5 = new CustomFunctionArgumentsDescriptionsCollection();
			service5.RegisterFunctionDescriptions(_codeactivite.Name, "Code Activité", arguments5);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_exercice.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_exercice);
			ICustomFunctionDescriptionsRegisterService service6 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service6 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments6 = new CustomFunctionArgumentsDescriptionsCollection();
			service6.RegisterFunctionDescriptions(_exercice.Name, "Exercice Fiscal", arguments6);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_codepostal.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_codepostal);
			ICustomFunctionDescriptionsRegisterService service7 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service7 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments7 = new CustomFunctionArgumentsDescriptionsCollection();
			service7.RegisterFunctionDescriptions(_codepostal.Name, "Code Postal", arguments7);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_inspection.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_inspection);
			ICustomFunctionDescriptionsRegisterService service8 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service8 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments8 = new CustomFunctionArgumentsDescriptionsCollection();
			service8.RegisterFunctionDescriptions(_inspection.Name, "Inspection", arguments8);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_recette.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_recette);
			ICustomFunctionDescriptionsRegisterService service9 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service9 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments9 = new CustomFunctionArgumentsDescriptionsCollection();
			service9.RegisterFunctionDescriptions(_recette.Name, "Recette", arguments9);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_commune.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_commune);
			ICustomFunctionDescriptionsRegisterService service10 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service10 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments10 = new CustomFunctionArgumentsDescriptionsCollection();
			service10.RegisterFunctionDescriptions(_commune.Name, "Commune", arguments10);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_ville.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_ville);
			ICustomFunctionDescriptionsRegisterService service11 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service11 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments11 = new CustomFunctionArgumentsDescriptionsCollection();
			service11.RegisterFunctionDescriptions(_ville.Name, "Ville", arguments11);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_communear.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_communear);
			ICustomFunctionDescriptionsRegisterService service12 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service12 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments12 = new CustomFunctionArgumentsDescriptionsCollection();
			service12.RegisterFunctionDescriptions(_communear.Name, "Commune", arguments12);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_villear.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_villear);
			ICustomFunctionDescriptionsRegisterService service13 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service13 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments13 = new CustomFunctionArgumentsDescriptionsCollection();
			service13.RegisterFunctionDescriptions(_villear.Name, "Ville", arguments13);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_nif.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_nif);
			ICustomFunctionDescriptionsRegisterService service14 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service14 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments14 = new CustomFunctionArgumentsDescriptionsCollection();
			service14.RegisterFunctionDescriptions(_nif.Name, "Numéro d'Identification Fiscale", arguments14);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_act.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_act);
			ICustomFunctionDescriptionsRegisterService service15 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service15 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments15 = new CustomFunctionArgumentsDescriptionsCollection();
			service15.RegisterFunctionDescriptions(_act.Name, "Activité de l'entreprise", arguments15);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_nom.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_nom);
			ICustomFunctionDescriptionsRegisterService service16 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service16 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments16 = new CustomFunctionArgumentsDescriptionsCollection();
			service16.RegisterFunctionDescriptions(_nom.Name, "Nom de l'entreprise", arguments16);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_adr.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_adr);
			ICustomFunctionDescriptionsRegisterService service17 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service17 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments17 = new CustomFunctionArgumentsDescriptionsCollection();
			service17.RegisterFunctionDescriptions(_adr.Name, "Adresse de l'entreprise", arguments17);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_sd.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_sd);
			ICustomFunctionDescriptionsRegisterService service18 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service18 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments18 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments18.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "nombre"));
			service18.RegisterFunctionDescriptions(_sd.Name, "Solde débit d'un compte", arguments18);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_sc.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_sc);
			ICustomFunctionDescriptionsRegisterService service19 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service19 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments19 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments19.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "nombre"));
			service19.RegisterFunctionDescriptions(_sc.Name, "Solde crédit d'un compte", arguments19);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_sdp.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_sdp);
			ICustomFunctionDescriptionsRegisterService service20 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service20 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments20 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments20.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "nombre"));
			service20.RegisterFunctionDescriptions(_sdp.Name, "Solde débit de l'exercice précédent", arguments20);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_scp.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_scp);
			ICustomFunctionDescriptionsRegisterService service21 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service21 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments21 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments21.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "nombre"));
			service21.RegisterFunctionDescriptions(_scp.Name, "Solde crédit de l'exercice précédent", arguments21);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_s.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_s);
			ICustomFunctionDescriptionsRegisterService service22 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service22 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments22 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments22.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service22.RegisterFunctionDescriptions(_s.Name, "Solde d'un compte.", arguments22);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_sf.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_sf);
			ICustomFunctionDescriptionsRegisterService service23 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service23 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments23 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments23.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service23.RegisterFunctionDescriptions(_sf.Name, "Solde d'un compte.", arguments23);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_spf.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_spf);
			ICustomFunctionDescriptionsRegisterService service24 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service24 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments24 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments24.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service24.RegisterFunctionDescriptions(_spf.Name, "Solde d'un compte.", arguments24);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_scf.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_scf);
			ICustomFunctionDescriptionsRegisterService service25 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service25 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments25 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments25.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service25.RegisterFunctionDescriptions(_scf.Name, "Solde d'un compte.", arguments25);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_sdf.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_sdf);
			ICustomFunctionDescriptionsRegisterService service26 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service26 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments26 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments26.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service26.RegisterFunctionDescriptions(_sdf.Name, "Solde Débit Finace d'un compte.", arguments26);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_mc.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_mc);
			ICustomFunctionDescriptionsRegisterService service27 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service27 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments27 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments27.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service27.RegisterFunctionDescriptions(_mc.Name, "Mouvement Crédit d'un compte.", arguments27);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_md.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_md);
			ICustomFunctionDescriptionsRegisterService service28 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service28 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments28 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments28.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service28.RegisterFunctionDescriptions(_md.Name, "Mouvement Débit d'un compte.", arguments28);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_sp.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_sp);
			ICustomFunctionDescriptionsRegisterService service29 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service29 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments29 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments29.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service29.RegisterFunctionDescriptions(_sp.Name, "Solde Précédent  d'un compte.", arguments29);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_ss.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_ss);
			ICustomFunctionDescriptionsRegisterService service30 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service30 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments30 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments30.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service30.RegisterFunctionDescriptions(_ss.Name, "Solde Précédent  d'un compte.", arguments30);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_ssp.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_ssp);
			ICustomFunctionDescriptionsRegisterService service31 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service31 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments31 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments31.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service31.RegisterFunctionDescriptions(_ssp.Name, "Solde Précédent  d'un compte.", arguments31);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_sdpf.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_sdpf);
			ICustomFunctionDescriptionsRegisterService service32 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service32 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments32 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments32.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service32.RegisterFunctionDescriptions(_sdpf.Name, "Solde Précédent  d'un compte.", arguments32);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_scpf.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_scpf);
			ICustomFunctionDescriptionsRegisterService service33 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service33 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments33 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments33.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service33.RegisterFunctionDescriptions(_scpf.Name, "Solde Précédent  d'un compte.", arguments33);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_mcf.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_mcf);
			ICustomFunctionDescriptionsRegisterService service34 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service34 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments34 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments34.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service34.RegisterFunctionDescriptions(_mcf.Name, "Mouvement Crédit Arrondi  d'un compte.", arguments34);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_mdf.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_mdf);
			ICustomFunctionDescriptionsRegisterService service35 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service35 != null)
			{
				CustomFunctionArgumentsDescriptionsCollection arguments35 = new CustomFunctionArgumentsDescriptionsCollection();
				arguments35.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
				service35.RegisterFunctionDescriptions(_mdf.Name, "Mouvement débit Arrondi  d'un compte.", arguments35);
			}
		}
	}

	private void frmPrintBilan_Load(object sender, EventArgs e)
	{
	}

	private void ExporterPDF()
	{
		string fic = Path.GetDirectoryName(workbook.Path) + "\\" + Path.GetFileNameWithoutExtension(workbook.Path) + ".pdf";
		using (FileStream pdfFileStream = new FileStream(fic, FileMode.Create))
		{
			workbook.ExportToPdf(pdfFileStream);
		}
		XtraMessageBox.Show("Fichier exporté dans " + fic, "Exportation PDF");
	}

	private void ExporterEXCEL()
	{
		string fic = Path.GetDirectoryName(workbook.Path) + "\\" + Path.GetFileNameWithoutExtension(workbook.Path) + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".xlsx";
		spreadsheetControl1.Options.DocumentCapabilities.Formulas = DocumentCapability.Disabled;
		workbook.SaveDocument(fic, DocumentFormat.Xlsx);
		spreadsheetControl1.Options.DocumentCapabilities.Formulas = DocumentCapability.Enabled;
		XtraMessageBox.Show("Fichier enregistrer dans " + fic, "Enregistrement sans formules");
	}

	private void tab1_CheckedChanged(object sender, EventArgs e)
	{
		if (tab1.CheckState == CheckState.Unchecked)
		{
			chk.UnCheckAll();
		}
		else
		{
			chk.CheckAll();
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
		this.tab2 = new DevExpress.XtraEditors.CheckEdit();
		this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
		this.tab1 = new DevExpress.XtraEditors.CheckEdit();
		this.chk = new DevExpress.XtraEditors.CheckedListBoxControl();
		this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
		this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
		this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
		((System.ComponentModel.ISupportInitialize)this.tab2.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).BeginInit();
		this.layoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.tab1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.chk).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).BeginInit();
		base.SuspendLayout();
		this.tab2.Location = new System.Drawing.Point(243, 12);
		this.tab2.Margin = new System.Windows.Forms.Padding(2);
		this.tab2.MaximumSize = new System.Drawing.Size(300, 0);
		this.tab2.Name = "tab2";
		this.tab2.Properties.Appearance.Options.UseTextOptions = true;
		this.tab2.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
		this.tab2.Properties.Caption = "Copie destinée au contribuable";
		this.tab2.Size = new System.Drawing.Size(169, 19);
		this.tab2.StyleController = this.layoutControl1;
		this.tab2.TabIndex = 13;
		this.layoutControl1.Controls.Add(this.tab2);
		this.layoutControl1.Controls.Add(this.simpleButton1);
		this.layoutControl1.Controls.Add(this.tab1);
		this.layoutControl1.Controls.Add(this.chk);
		this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.layoutControl1.Location = new System.Drawing.Point(0, 0);
		this.layoutControl1.Name = "layoutControl1";
		this.layoutControl1.Root = this.Root;
		this.layoutControl1.Size = new System.Drawing.Size(424, 356);
		this.layoutControl1.TabIndex = 22;
		this.layoutControl1.Text = "layoutControl1";
		this.tab1.Location = new System.Drawing.Point(12, 12);
		this.tab1.Margin = new System.Windows.Forms.Padding(2);
		this.tab1.Name = "tab1";
		this.tab1.Properties.Appearance.Options.UseTextOptions = true;
		this.tab1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
		this.tab1.Properties.Caption = "Cocher/Décocher Tout";
		this.tab1.Size = new System.Drawing.Size(227, 19);
		this.tab1.StyleController = this.layoutControl1;
		this.tab1.TabIndex = 12;
		this.tab1.CheckedChanged += new System.EventHandler(tab1_CheckedChanged);
		this.chk.Appearance.Options.UseTextOptions = true;
		this.chk.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
		this.chk.CheckOnClick = true;
		this.chk.ItemHeight = 29;
		this.chk.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[8]
		{
			new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Actif", "", System.Windows.Forms.CheckState.Unchecked),
			new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Passif", "", 1),
			new DevExpress.XtraEditors.Controls.CheckedListBoxItem("TCR", "", 2),
			new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Amortissements et pertes de valeurs/Immobilisations créées ou acquises au cours de l'exercice", "", 3),
			new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Relevé des pertes de valeurs", "", 4),
			new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Mouvements des stocks/fluctuation de la production stockée", "", 5),
			new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Immobilisations cédées (plus ou moins value) au cours de l'exercice/Provisions et pertes de valeurs", "", 6),
			new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Charges de personnel, impôts, taxes et versements assimilés, autres services Autres charges et produits opérationnels", "", 7)
		});
		this.chk.Location = new System.Drawing.Point(12, 35);
		this.chk.Margin = new System.Windows.Forms.Padding(2);
		this.chk.Name = "chk";
		this.chk.Size = new System.Drawing.Size(400, 258);
		this.chk.StyleController = this.layoutControl1;
		this.chk.TabIndex = 21;
		this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
		this.Root.GroupBordersVisible = false;
		this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[5] { this.layoutControlItem1, this.layoutControlItem2, this.layoutControlItem3, this.layoutControlItem4, this.emptySpaceItem1 });
		this.Root.Name = "Root";
		this.Root.Size = new System.Drawing.Size(424, 356);
		this.Root.TextVisible = false;
		this.layoutControlItem1.Control = this.chk;
		this.layoutControlItem1.Location = new System.Drawing.Point(0, 23);
		this.layoutControlItem1.Name = "layoutControlItem1";
		this.layoutControlItem1.Size = new System.Drawing.Size(404, 262);
		this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem1.TextVisible = false;
		this.layoutControlItem3.Control = this.tab1;
		this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
		this.layoutControlItem3.Name = "layoutControlItem3";
		this.layoutControlItem3.Size = new System.Drawing.Size(231, 23);
		this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem3.TextVisible = false;
		this.layoutControlItem4.Control = this.tab2;
		this.layoutControlItem4.Location = new System.Drawing.Point(231, 0);
		this.layoutControlItem4.Name = "layoutControlItem4";
		this.layoutControlItem4.Size = new System.Drawing.Size(173, 23);
		this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem4.TextVisible = false;
		this.emptySpaceItem1.AllowHotTrack = false;
		this.emptySpaceItem1.Location = new System.Drawing.Point(0, 285);
		this.emptySpaceItem1.Name = "emptySpaceItem1";
		this.emptySpaceItem1.Size = new System.Drawing.Size(404, 25);
		this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
		this.simpleButton1.ImageOptions.Image = compta.Properties.Resources.print_16x16;
		this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton1.Location = new System.Drawing.Point(12, 322);
		this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
		this.simpleButton1.Name = "simpleButton1";
		this.simpleButton1.Size = new System.Drawing.Size(400, 22);
		this.simpleButton1.StyleController = this.layoutControl1;
		this.simpleButton1.TabIndex = 20;
		this.simpleButton1.Text = "Imprimer";
		this.simpleButton1.Click += new System.EventHandler(simpleButton1_Click_1);
		this.layoutControlItem2.Control = this.simpleButton1;
		this.layoutControlItem2.Location = new System.Drawing.Point(0, 310);
		this.layoutControlItem2.Name = "layoutControlItem2";
		this.layoutControlItem2.Size = new System.Drawing.Size(404, 26);
		this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem2.TextVisible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(424, 356);
		base.Controls.Add(this.layoutControl1);
		base.Margin = new System.Windows.Forms.Padding(2);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmPrintBilan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Impression du Bilan";
		base.Load += new System.EventHandler(frmPrintBilan_Load);
		((System.ComponentModel.ISupportInitialize)this.tab2.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).EndInit();
		this.layoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.tab1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.chk).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).EndInit();
		base.ResumeLayout(false);
	}
}
