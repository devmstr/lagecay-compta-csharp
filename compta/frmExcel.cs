using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using compta.Properties;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Functions;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Commands;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraSpreadsheet;
using DevExpress.XtraSpreadsheet.Design;
using DevExpress.XtraSpreadsheet.UI;

namespace compta;

public class frmExcel : XtraForm
{
	private IWorkbook workbook;

	private IContainer components;

	private SpreadsheetControl spreadsheetControl1;

	private RibbonControl ribbonControl1;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem1;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem2;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem3;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem4;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem5;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem6;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem7;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem8;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem9;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem10;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem11;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem1;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem12;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem13;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem14;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem15;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem16;

	private FunctionsFinancialItem functionsFinancialItem1;

	private FunctionsLogicalItem functionsLogicalItem1;

	private FunctionsTextItem functionsTextItem1;

	private FunctionsDateAndTimeItem functionsDateAndTimeItem1;

	private FunctionsLookupAndReferenceItem functionsLookupAndReferenceItem1;

	private FunctionsMathAndTrigonometryItem functionsMathAndTrigonometryItem1;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem2;

	private FunctionsStatisticalItem functionsStatisticalItem1;

	private FunctionsEngineeringItem functionsEngineeringItem1;

	private FunctionsInformationItem functionsInformationItem1;

	private FunctionsCompatibilityItem functionsCompatibilityItem1;

	private FunctionsWebItem functionsWebItem1;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem17;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem18;

	private DefinedNameListItem definedNameListItem1;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem19;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem1;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem3;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem2;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem3;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem20;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem21;

	private AverageInfoStaticItem averageInfoStaticItem1;

	private CountInfoStaticItem countInfoStaticItem1;

	private NumericalCountInfoStaticItem numericalCountInfoStaticItem1;

	private MinInfoStaticItem minInfoStaticItem1;

	private MaxInfoStaticItem maxInfoStaticItem1;

	private SumInfoStaticItem sumInfoStaticItem1;

	private ZoomEditItem zoomEditItem1;

	private RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;

	private ShowZoomButtonItem showZoomButtonItem1;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem22;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem23;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem24;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem1;

	private CommandBarGalleryDropDown commandBarGalleryDropDown1;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem2;

	private CommandBarGalleryDropDown commandBarGalleryDropDown2;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem3;

	private CommandBarGalleryDropDown commandBarGalleryDropDown3;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem4;

	private CommandBarGalleryDropDown commandBarGalleryDropDown4;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem5;

	private CommandBarGalleryDropDown commandBarGalleryDropDown5;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem6;

	private CommandBarGalleryDropDown commandBarGalleryDropDown6;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem7;

	private CommandBarGalleryDropDown commandBarGalleryDropDown7;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem25;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem26;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem27;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem28;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem29;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem30;

	private BarButtonGroup barButtonGroup1;

	private ChangeFontNameItem changeFontNameItem1;

	private RepositoryItemFontEdit repositoryItemFontEdit1;

	private ChangeFontSizeItem changeFontSizeItem1;

	private RepositoryItemSpreadsheetFontSizeEdit repositoryItemSpreadsheetFontSizeEdit1;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem31;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem32;

	private BarButtonGroup barButtonGroup2;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem4;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem5;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem6;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem7;

	private BarButtonGroup barButtonGroup3;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem4;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem33;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem34;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem35;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem36;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem37;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem38;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem39;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem40;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem41;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem42;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem43;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem44;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem45;

	private ChangeBorderLineColorItem changeBorderLineColorItem1;

	private ChangeBorderLineStyleItem changeBorderLineStyleItem1;

	private CommandBarGalleryDropDown commandBarGalleryDropDown8;

	private BarButtonGroup barButtonGroup4;

	private ChangeCellFillColorItem changeCellFillColorItem1;

	private ChangeFontColorItem changeFontColorItem1;

	private BarButtonGroup barButtonGroup5;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem8;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem9;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem10;

	private BarButtonGroup barButtonGroup6;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem11;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem12;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem13;

	private BarButtonGroup barButtonGroup7;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem46;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem47;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem14;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem5;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem15;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem48;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem49;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem50;

	private BarButtonGroup barButtonGroup8;

	private ChangeNumberFormatItem changeNumberFormatItem1;

	private RepositoryItemPopupGalleryEdit repositoryItemPopupGalleryEdit1;

	private BarButtonGroup barButtonGroup9;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem6;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem51;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem52;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem53;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem54;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem55;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem56;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem57;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem58;

	private BarButtonGroup barButtonGroup10;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem59;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem60;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem10;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem7;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem61;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem62;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem63;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem64;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem65;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem66;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem67;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem8;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem68;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem69;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem70;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem71;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem72;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem73;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem8;

	private CommandBarGalleryDropDown commandBarGalleryDropDown9;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem9;

	private CommandBarGalleryDropDown commandBarGalleryDropDown10;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem10;

	private CommandBarGalleryDropDown commandBarGalleryDropDown11;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem74;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem9;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem75;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem76;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem77;

	private GalleryFormatAsTableItem galleryFormatAsTableItem1;

	private CommandBarGalleryDropDown commandBarGalleryDropDown12;

	private GalleryChangeStyleItem galleryChangeStyleItem1;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem11;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem78;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem79;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem80;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem81;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem82;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem83;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem84;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem85;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem12;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem86;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem87;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem88;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem89;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem90;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem91;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem14;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem92;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem93;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem94;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem95;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem96;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem13;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem97;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem98;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem99;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem100;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem101;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem102;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem103;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem104;

	private ChangeSheetTabColorItem changeSheetTabColorItem1;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem105;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem16;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem106;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem15;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem16;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem107;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem108;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem109;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem110;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem17;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem111;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem112;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem113;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem114;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem115;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem116;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem18;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem117;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem118;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem17;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem119;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem120;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem19;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem121;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem122;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem123;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem124;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem125;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem126;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem127;

	private FileRibbonPage fileRibbonPage1;

	private CommonRibbonPageGroup commonRibbonPageGroup1;

	private InfoRibbonPageGroup infoRibbonPageGroup1;

	private HomeRibbonPage homeRibbonPage1;

	private ClipboardRibbonPageGroup clipboardRibbonPageGroup1;

	private FontRibbonPageGroup fontRibbonPageGroup1;

	private AlignmentRibbonPageGroup alignmentRibbonPageGroup1;

	private NumberRibbonPageGroup numberRibbonPageGroup1;

	private StylesRibbonPageGroup stylesRibbonPageGroup1;

	private CellsRibbonPageGroup cellsRibbonPageGroup1;

	private EditingRibbonPageGroup editingRibbonPageGroup1;

	private FormulasRibbonPage formulasRibbonPage1;

	private FunctionLibraryRibbonPageGroup functionLibraryRibbonPageGroup1;

	private FormulaDefinedNamesRibbonPageGroup formulaDefinedNamesRibbonPageGroup1;

	private FormulaAuditingRibbonPageGroup formulaAuditingRibbonPageGroup1;

	private FormulaCalculationRibbonPageGroup formulaCalculationRibbonPageGroup1;

	private InsertRibbonPage insertRibbonPage1;

	private TablesRibbonPageGroup tablesRibbonPageGroup1;

	private IllustrationsRibbonPageGroup illustrationsRibbonPageGroup1;

	private ChartsRibbonPageGroup chartsRibbonPageGroup1;

	private LinksRibbonPageGroup linksRibbonPageGroup1;

	private SymbolsRibbonPageGroup symbolsRibbonPageGroup1;

	private RibbonStatusBar ribbonStatusBar1;

	private SpreadsheetFormulaBar spreadsheetFormulaBar1;

	private SplitterControl splitterControl1;

	private SpreadsheetBarController spreadsheetBarController1;

	private BarButtonItem barButtonItem1;

	private RibbonPageGroup ribbonPageGroup1;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem18;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem19;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem128;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem129;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem130;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem131;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem20;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem132;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem133;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem134;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem135;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem136;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem137;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem138;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem139;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem140;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem141;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem142;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem143;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem21;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem20;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem21;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem22;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem144;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem22;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem23;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem24;

	private PageSetupPaperKindItem pageSetupPaperKindItem1;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem23;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem145;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem146;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem147;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem148;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem25;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem26;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem24;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem149;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem150;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem25;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem151;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem152;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem26;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem153;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem154;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem155;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem27;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem156;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem157;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem28;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem158;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem159;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem160;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem161;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem162;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem163;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem164;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem165;

	private GalleryChartLayoutItem galleryChartLayoutItem1;

	private GalleryChartStyleItem galleryChartStyleItem1;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem166;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem29;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem11;

	private CommandBarGalleryDropDown commandBarGalleryDropDown13;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem12;

	private CommandBarGalleryDropDown commandBarGalleryDropDown14;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem30;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem13;

	private CommandBarGalleryDropDown commandBarGalleryDropDown15;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem14;

	private CommandBarGalleryDropDown commandBarGalleryDropDown16;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem15;

	private CommandBarGalleryDropDown commandBarGalleryDropDown17;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem31;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem16;

	private CommandBarGalleryDropDown commandBarGalleryDropDown18;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem17;

	private CommandBarGalleryDropDown commandBarGalleryDropDown19;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem18;

	private CommandBarGalleryDropDown commandBarGalleryDropDown20;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem19;

	private CommandBarGalleryDropDown commandBarGalleryDropDown21;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem20;

	private CommandBarGalleryDropDown commandBarGalleryDropDown22;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem21;

	private CommandBarGalleryDropDown commandBarGalleryDropDown23;

	private SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem22;

	private CommandBarGalleryDropDown commandBarGalleryDropDown24;

	private RenameTableItemCaption renameTableItemCaption1;

	private RenameTableItem renameTableItem1;

	private RepositoryItemTextEdit repositoryItemTextEdit1;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem27;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem28;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem29;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem30;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem31;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem32;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem33;

	private GalleryTableStylesItem galleryTableStylesItem1;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem167;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem168;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem169;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem170;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem171;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem172;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem173;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem32;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem174;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem175;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem176;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem33;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem177;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem178;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem34;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem179;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem180;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem181;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem182;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem35;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem183;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem184;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem185;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem186;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem34;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem35;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem36;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem36;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem187;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem188;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem189;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem37;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem190;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem191;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem192;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem193;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem38;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem194;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem195;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem196;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem197;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem198;

	private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem39;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem199;

	private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem200;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem37;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem38;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem39;

	private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem40;

	private GalleryPivotStylesItem galleryPivotStylesItem1;

	private ViewRibbonPage viewRibbonPage1;

	private ShowRibbonPageGroup showRibbonPageGroup1;

	private ZoomRibbonPageGroup zoomRibbonPageGroup1;

	private WindowRibbonPageGroup windowRibbonPageGroup1;

	private PageLayoutRibbonPage pageLayoutRibbonPage1;

	private PageSetupRibbonPageGroup pageSetupRibbonPageGroup1;

	private PageSetupShowRibbonPageGroup pageSetupShowRibbonPageGroup1;

	private PageSetupPrintRibbonPageGroup pageSetupPrintRibbonPageGroup1;

	private ArrangeRibbonPageGroup arrangeRibbonPageGroup1;

	private BarButtonItem barButtonItem2;

	public frmExcel()
	{
		InitializeComponent();
		workbook = spreadsheetControl1.Document;
	}

	public frmExcel(string fic)
	{
		InitializeComponent();
		spreadsheetControl1.LoadDocument(fic, DocumentFormat.Xlsx);
		workbook = spreadsheetControl1.Document;
	}

	private void frmExcel_Load(object sender, EventArgs e)
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

	private void spreadsheetControl1_DocumentLoaded(object sender, EventArgs e)
	{
		workbook.CalculateFull();
	}

	private void Exporter()
	{
		string fic = Path.GetDirectoryName(workbook.Path) + "\\" + Path.GetFileNameWithoutExtension(workbook.Path) + ".pdf";
		using (FileStream pdfFileStream = new FileStream(fic, FileMode.Create))
		{
			workbook.ExportToPdf(pdfFileStream);
		}
		XtraMessageBox.Show("Fichier exporté dans " + fic, "Exportation PDF");
	}

	private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
	{
		string fic = Path.GetDirectoryName(workbook.Path) + "\\" + Path.GetFileNameWithoutExtension(workbook.Path) + ".pdf";
		using (FileStream pdfFileStream = new FileStream(fic, FileMode.Create))
		{
			workbook.ExportToPdf(pdfFileStream);
		}
		XtraMessageBox.Show("Fichier exporté dans " + fic, "Exportation PDF");
	}

	private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
	{
		string fic = Path.GetDirectoryName(workbook.Path) + "\\" + Path.GetFileNameWithoutExtension(workbook.Path) + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".xlsx";
		XtraSaveFileDialog xtraSaveFileDialog1 = new XtraSaveFileDialog();
		xtraSaveFileDialog1.Filter = "txt files (*.xlsx)|*.xlsx";
		xtraSaveFileDialog1.InitialDirectory = Path.GetDirectoryName(workbook.Path);
		if (xtraSaveFileDialog1.ShowDialog() == DialogResult.OK && (fic = xtraSaveFileDialog1.FileName) != null)
		{
			spreadsheetControl1.Options.DocumentCapabilities.Formulas = DocumentCapability.Disabled;
			workbook.SaveDocument(fic, DocumentFormat.Xlsx);
			spreadsheetControl1.Options.DocumentCapabilities.Formulas = DocumentCapability.Enabled;
			XtraMessageBox.Show("Fichier enregistrer dans " + fic, "Enregistrement sans formules");
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
		this.components = new System.ComponentModel.Container();
		DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
		DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
		DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
		DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
		DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
		DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
		DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipItem toolTipItem7 = new DevExpress.Utils.ToolTipItem();
		DevExpress.Utils.SuperToolTip superToolTip8 = new DevExpress.Utils.SuperToolTip();
		DevExpress.Utils.ToolTipItem toolTipItem8 = new DevExpress.Utils.ToolTipItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem40 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem41 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem42 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem43 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem44 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem45 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem46 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem47 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem48 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem49 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem50 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem51 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem52 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem53 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem54 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem55 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem56 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem57 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem58 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem59 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem60 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem61 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem62 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem63 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem64 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem65 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem66 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem67 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem68 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem69 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem70 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem71 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem72 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem73 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem74 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem75 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem76 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem77 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem78 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem79 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem80 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem81 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem82 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem83 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem84 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem85 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem86 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem87 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem88 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem89 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem90 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem91 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem92 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem93 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem94 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem95 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem96 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem97 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem98 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem99 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem100 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem101 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem102 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem103 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem104 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem105 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem106 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem107 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem108 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem109 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem110 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem111 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem112 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem113 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem114 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem115 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem116 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem117 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem118 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem119 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem120 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem121 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem122 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem123 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem124 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem125 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem126 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem127 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem128 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem129 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem130 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem131 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem132 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem133 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem134 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem135 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem136 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem137 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem138 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem139 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem140 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem141 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem142 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem143 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem144 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem145 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem146 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem147 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem148 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem149 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem150 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem151 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem152 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem153 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem154 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem155 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem156 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem157 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem158 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem159 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem160 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem161 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem162 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem163 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem164 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem165 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem166 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem167 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem168 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem169 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem170 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem171 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem172 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem173 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem174 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem175 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem176 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem177 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem178 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem179 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem180 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem181 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem182 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup40 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem183 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem184 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem185 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem186 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
		DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
		this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
		this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
		this.spreadsheetCommandBarButtonItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.functionsFinancialItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsFinancialItem();
		this.functionsLogicalItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsLogicalItem();
		this.functionsTextItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsTextItem();
		this.functionsDateAndTimeItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsDateAndTimeItem();
		this.functionsLookupAndReferenceItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsLookupAndReferenceItem();
		this.functionsMathAndTrigonometryItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsMathAndTrigonometryItem();
		this.spreadsheetCommandBarSubItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.functionsStatisticalItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsStatisticalItem();
		this.functionsEngineeringItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsEngineeringItem();
		this.functionsInformationItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsInformationItem();
		this.functionsCompatibilityItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsCompatibilityItem();
		this.functionsWebItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsWebItem();
		this.spreadsheetCommandBarButtonItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.definedNameListItem1 = new DevExpress.XtraSpreadsheet.UI.DefinedNameListItem();
		this.spreadsheetCommandBarButtonItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarCheckItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarSubItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarCheckItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarButtonItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.averageInfoStaticItem1 = new DevExpress.XtraSpreadsheet.UI.AverageInfoStaticItem();
		this.countInfoStaticItem1 = new DevExpress.XtraSpreadsheet.UI.CountInfoStaticItem();
		this.numericalCountInfoStaticItem1 = new DevExpress.XtraSpreadsheet.UI.NumericalCountInfoStaticItem();
		this.minInfoStaticItem1 = new DevExpress.XtraSpreadsheet.UI.MinInfoStaticItem();
		this.maxInfoStaticItem1 = new DevExpress.XtraSpreadsheet.UI.MaxInfoStaticItem();
		this.sumInfoStaticItem1 = new DevExpress.XtraSpreadsheet.UI.SumInfoStaticItem();
		this.zoomEditItem1 = new DevExpress.XtraSpreadsheet.UI.ZoomEditItem();
		this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
		this.showZoomButtonItem1 = new DevExpress.XtraSpreadsheet.UI.ShowZoomButtonItem();
		this.spreadsheetCommandBarButtonItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonGalleryDropDownItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown1 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown2 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown3 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown4 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown5 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown6 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown7 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonItem25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
		this.changeFontNameItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeFontNameItem();
		this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
		this.changeFontSizeItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeFontSizeItem();
		this.repositoryItemSpreadsheetFontSizeEdit1 = new DevExpress.XtraSpreadsheet.Design.RepositoryItemSpreadsheetFontSizeEdit();
		this.spreadsheetCommandBarButtonItem31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
		this.spreadsheetCommandBarCheckItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.barButtonGroup3 = new DevExpress.XtraBars.BarButtonGroup();
		this.spreadsheetCommandBarSubItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem40 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem41 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem42 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem43 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem44 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem45 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.changeBorderLineColorItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeBorderLineColorItem();
		this.changeBorderLineStyleItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeBorderLineStyleItem();
		this.commandBarGalleryDropDown8 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.barButtonGroup4 = new DevExpress.XtraBars.BarButtonGroup();
		this.changeCellFillColorItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeCellFillColorItem();
		this.changeFontColorItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeFontColorItem();
		this.barButtonGroup5 = new DevExpress.XtraBars.BarButtonGroup();
		this.spreadsheetCommandBarCheckItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.barButtonGroup6 = new DevExpress.XtraBars.BarButtonGroup();
		this.spreadsheetCommandBarCheckItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.barButtonGroup7 = new DevExpress.XtraBars.BarButtonGroup();
		this.spreadsheetCommandBarButtonItem46 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem47 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarCheckItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarSubItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarCheckItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarButtonItem48 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem49 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem50 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.barButtonGroup8 = new DevExpress.XtraBars.BarButtonGroup();
		this.changeNumberFormatItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeNumberFormatItem();
		this.repositoryItemPopupGalleryEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit();
		this.barButtonGroup9 = new DevExpress.XtraBars.BarButtonGroup();
		this.spreadsheetCommandBarSubItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem51 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem52 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem53 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem54 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem55 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem56 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem57 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem58 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.barButtonGroup10 = new DevExpress.XtraBars.BarButtonGroup();
		this.spreadsheetCommandBarButtonItem59 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem60 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarSubItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem61 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem62 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem63 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem64 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem65 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem66 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem67 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem68 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem69 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem70 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem71 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem72 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem73 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonGalleryDropDownItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown9 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown10 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown11 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonItem74 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem75 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem76 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem77 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.galleryFormatAsTableItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryFormatAsTableItem();
		this.commandBarGalleryDropDown12 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.galleryChangeStyleItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryChangeStyleItem();
		this.spreadsheetCommandBarSubItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem78 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem79 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem80 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem81 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem82 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem83 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem84 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem85 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem86 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem87 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem88 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem89 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem90 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem91 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem92 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem93 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem94 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem95 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem96 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem97 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem98 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem99 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem100 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem101 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem102 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem103 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem104 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.changeSheetTabColorItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeSheetTabColorItem();
		this.spreadsheetCommandBarButtonItem105 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarCheckItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarButtonItem106 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarSubItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem107 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem108 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem109 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem110 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem111 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem112 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem113 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem114 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem115 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem116 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem117 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem118 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarCheckItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarButtonItem119 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem120 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem121 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem122 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem123 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem124 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem125 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem126 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem127 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
		this.spreadsheetCommandBarCheckItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarButtonItem128 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem129 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem130 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem131 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem132 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem133 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem134 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem135 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem136 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem137 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem138 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem139 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem140 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem141 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem142 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem143 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarCheckItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarButtonItem144 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarCheckItem23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.pageSetupPaperKindItem1 = new DevExpress.XtraSpreadsheet.UI.PageSetupPaperKindItem();
		this.spreadsheetCommandBarSubItem23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem145 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem146 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem147 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem148 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarCheckItem25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarSubItem24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem149 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem150 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem151 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem152 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem153 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem154 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem155 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem156 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem157 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem158 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem159 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem160 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem161 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem162 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem163 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem164 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem165 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.galleryChartLayoutItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryChartLayoutItem();
		this.galleryChartStyleItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryChartStyleItem();
		this.spreadsheetCommandBarButtonItem166 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonGalleryDropDownItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown13 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown14 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarSubItem30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonGalleryDropDownItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown15 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown16 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown17 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarSubItem31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonGalleryDropDownItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown18 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown19 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown20 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown21 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown22 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown23 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.spreadsheetCommandBarButtonGalleryDropDownItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
		this.commandBarGalleryDropDown24 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
		this.renameTableItemCaption1 = new DevExpress.XtraSpreadsheet.UI.RenameTableItemCaption();
		this.renameTableItem1 = new DevExpress.XtraSpreadsheet.UI.RenameTableItem();
		this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
		this.spreadsheetCommandBarCheckItem27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.galleryTableStylesItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryTableStylesItem();
		this.spreadsheetCommandBarButtonItem167 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem168 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem169 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem170 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem171 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem172 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem173 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem174 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem175 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem176 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem177 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem178 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem179 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem180 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem181 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem182 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem183 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem184 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem185 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem186 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarCheckItem34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarSubItem36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem187 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem188 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem189 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem190 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem191 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem192 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem193 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem194 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem195 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem196 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem197 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem198 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarSubItem39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
		this.spreadsheetCommandBarButtonItem199 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarButtonItem200 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
		this.spreadsheetCommandBarCheckItem37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.spreadsheetCommandBarCheckItem40 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
		this.galleryPivotStylesItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryPivotStylesItem();
		this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
		this.fileRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.FileRibbonPage();
		this.commonRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup();
		this.infoRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup();
		this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
		this.homeRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.HomeRibbonPage();
		this.clipboardRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ClipboardRibbonPageGroup();
		this.fontRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FontRibbonPageGroup();
		this.alignmentRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.AlignmentRibbonPageGroup();
		this.numberRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.NumberRibbonPageGroup();
		this.stylesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.StylesRibbonPageGroup();
		this.cellsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.CellsRibbonPageGroup();
		this.editingRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.EditingRibbonPageGroup();
		this.formulasRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.FormulasRibbonPage();
		this.functionLibraryRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FunctionLibraryRibbonPageGroup();
		this.formulaDefinedNamesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FormulaDefinedNamesRibbonPageGroup();
		this.formulaAuditingRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FormulaAuditingRibbonPageGroup();
		this.formulaCalculationRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FormulaCalculationRibbonPageGroup();
		this.insertRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.InsertRibbonPage();
		this.tablesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.TablesRibbonPageGroup();
		this.illustrationsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.IllustrationsRibbonPageGroup();
		this.chartsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsRibbonPageGroup();
		this.linksRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.LinksRibbonPageGroup();
		this.symbolsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.SymbolsRibbonPageGroup();
		this.viewRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.ViewRibbonPage();
		this.showRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ShowRibbonPageGroup();
		this.zoomRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ZoomRibbonPageGroup();
		this.windowRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.WindowRibbonPageGroup();
		this.pageLayoutRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.PageLayoutRibbonPage();
		this.pageSetupRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PageSetupRibbonPageGroup();
		this.pageSetupShowRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PageSetupShowRibbonPageGroup();
		this.pageSetupPrintRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PageSetupPrintRibbonPageGroup();
		this.arrangeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ArrangeRibbonPageGroup();
		this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
		this.spreadsheetFormulaBar1 = new DevExpress.XtraSpreadsheet.SpreadsheetFormulaBar();
		this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
		this.spreadsheetBarController1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController(this.components);
		((System.ComponentModel.ISupportInitialize)this.ribbonControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemZoomTrackBar1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown7).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemFontEdit1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemSpreadsheetFontSizeEdit1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown8).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemPopupGalleryEdit1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown9).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown10).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown11).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown12).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown13).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown14).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown15).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown16).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown17).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown18).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown19).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown20).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown21).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown22).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown23).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown24).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemTextEdit1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.spreadsheetBarController1).BeginInit();
		base.SuspendLayout();
		this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.spreadsheetControl1.Location = new System.Drawing.Point(0, 172);
		this.spreadsheetControl1.Margin = new System.Windows.Forms.Padding(2);
		this.spreadsheetControl1.MenuManager = this.ribbonControl1;
		this.spreadsheetControl1.Name = "spreadsheetControl1";
		this.spreadsheetControl1.Size = new System.Drawing.Size(1106, 326);
		this.spreadsheetControl1.TabIndex = 0;
		this.spreadsheetControl1.Text = "spreadsheetControl1";
		this.spreadsheetControl1.DocumentLoaded += new System.EventHandler(spreadsheetControl1_DocumentLoaded);
		this.ribbonControl1.ExpandCollapseItem.Id = 0;
		this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[352]
		{
			this.ribbonControl1.ExpandCollapseItem,
			this.ribbonControl1.SearchEditItem,
			this.spreadsheetCommandBarButtonItem1,
			this.spreadsheetCommandBarButtonItem2,
			this.spreadsheetCommandBarButtonItem3,
			this.spreadsheetCommandBarButtonItem4,
			this.spreadsheetCommandBarButtonItem5,
			this.spreadsheetCommandBarButtonItem6,
			this.spreadsheetCommandBarButtonItem7,
			this.spreadsheetCommandBarButtonItem8,
			this.spreadsheetCommandBarButtonItem9,
			this.spreadsheetCommandBarButtonItem10,
			this.spreadsheetCommandBarButtonItem11,
			this.spreadsheetCommandBarSubItem1,
			this.spreadsheetCommandBarButtonItem12,
			this.spreadsheetCommandBarButtonItem13,
			this.spreadsheetCommandBarButtonItem14,
			this.spreadsheetCommandBarButtonItem15,
			this.spreadsheetCommandBarButtonItem16,
			this.functionsFinancialItem1,
			this.functionsLogicalItem1,
			this.functionsTextItem1,
			this.functionsDateAndTimeItem1,
			this.functionsLookupAndReferenceItem1,
			this.functionsMathAndTrigonometryItem1,
			this.spreadsheetCommandBarSubItem2,
			this.functionsStatisticalItem1,
			this.functionsEngineeringItem1,
			this.functionsInformationItem1,
			this.functionsCompatibilityItem1,
			this.functionsWebItem1,
			this.spreadsheetCommandBarButtonItem17,
			this.spreadsheetCommandBarButtonItem18,
			this.definedNameListItem1,
			this.spreadsheetCommandBarButtonItem19,
			this.spreadsheetCommandBarCheckItem1,
			this.spreadsheetCommandBarSubItem3,
			this.spreadsheetCommandBarCheckItem2,
			this.spreadsheetCommandBarCheckItem3,
			this.spreadsheetCommandBarButtonItem20,
			this.spreadsheetCommandBarButtonItem21,
			this.averageInfoStaticItem1,
			this.countInfoStaticItem1,
			this.numericalCountInfoStaticItem1,
			this.minInfoStaticItem1,
			this.maxInfoStaticItem1,
			this.sumInfoStaticItem1,
			this.zoomEditItem1,
			this.showZoomButtonItem1,
			this.spreadsheetCommandBarButtonItem22,
			this.spreadsheetCommandBarButtonItem23,
			this.spreadsheetCommandBarButtonItem24,
			this.spreadsheetCommandBarButtonGalleryDropDownItem1,
			this.spreadsheetCommandBarButtonGalleryDropDownItem2,
			this.spreadsheetCommandBarButtonGalleryDropDownItem3,
			this.spreadsheetCommandBarButtonGalleryDropDownItem4,
			this.spreadsheetCommandBarButtonGalleryDropDownItem5,
			this.spreadsheetCommandBarButtonGalleryDropDownItem6,
			this.spreadsheetCommandBarButtonGalleryDropDownItem7,
			this.spreadsheetCommandBarButtonItem25,
			this.spreadsheetCommandBarButtonItem26,
			this.spreadsheetCommandBarButtonItem27,
			this.spreadsheetCommandBarButtonItem28,
			this.spreadsheetCommandBarButtonItem29,
			this.spreadsheetCommandBarButtonItem30,
			this.barButtonGroup1,
			this.changeFontNameItem1,
			this.changeFontSizeItem1,
			this.spreadsheetCommandBarButtonItem31,
			this.spreadsheetCommandBarButtonItem32,
			this.barButtonGroup2,
			this.spreadsheetCommandBarCheckItem4,
			this.spreadsheetCommandBarCheckItem5,
			this.spreadsheetCommandBarCheckItem6,
			this.spreadsheetCommandBarCheckItem7,
			this.barButtonGroup3,
			this.spreadsheetCommandBarSubItem4,
			this.spreadsheetCommandBarButtonItem33,
			this.spreadsheetCommandBarButtonItem34,
			this.spreadsheetCommandBarButtonItem35,
			this.spreadsheetCommandBarButtonItem36,
			this.spreadsheetCommandBarButtonItem37,
			this.spreadsheetCommandBarButtonItem38,
			this.spreadsheetCommandBarButtonItem39,
			this.spreadsheetCommandBarButtonItem40,
			this.spreadsheetCommandBarButtonItem41,
			this.spreadsheetCommandBarButtonItem42,
			this.spreadsheetCommandBarButtonItem43,
			this.spreadsheetCommandBarButtonItem44,
			this.spreadsheetCommandBarButtonItem45,
			this.changeBorderLineColorItem1,
			this.changeBorderLineStyleItem1,
			this.barButtonGroup4,
			this.changeCellFillColorItem1,
			this.changeFontColorItem1,
			this.barButtonGroup5,
			this.spreadsheetCommandBarCheckItem8,
			this.spreadsheetCommandBarCheckItem9,
			this.spreadsheetCommandBarCheckItem10,
			this.barButtonGroup6,
			this.spreadsheetCommandBarCheckItem11,
			this.spreadsheetCommandBarCheckItem12,
			this.spreadsheetCommandBarCheckItem13,
			this.barButtonGroup7,
			this.spreadsheetCommandBarButtonItem46,
			this.spreadsheetCommandBarButtonItem47,
			this.spreadsheetCommandBarCheckItem14,
			this.spreadsheetCommandBarSubItem5,
			this.spreadsheetCommandBarCheckItem15,
			this.spreadsheetCommandBarButtonItem48,
			this.spreadsheetCommandBarButtonItem49,
			this.spreadsheetCommandBarButtonItem50,
			this.barButtonGroup8,
			this.changeNumberFormatItem1,
			this.barButtonGroup9,
			this.spreadsheetCommandBarSubItem6,
			this.spreadsheetCommandBarButtonItem51,
			this.spreadsheetCommandBarButtonItem52,
			this.spreadsheetCommandBarButtonItem53,
			this.spreadsheetCommandBarButtonItem54,
			this.spreadsheetCommandBarButtonItem55,
			this.spreadsheetCommandBarButtonItem56,
			this.spreadsheetCommandBarButtonItem57,
			this.spreadsheetCommandBarButtonItem58,
			this.barButtonGroup10,
			this.spreadsheetCommandBarButtonItem59,
			this.spreadsheetCommandBarButtonItem60,
			this.spreadsheetCommandBarSubItem10,
			this.spreadsheetCommandBarButtonItem61,
			this.spreadsheetCommandBarButtonItem62,
			this.spreadsheetCommandBarButtonItem63,
			this.spreadsheetCommandBarButtonItem64,
			this.spreadsheetCommandBarButtonItem65,
			this.spreadsheetCommandBarButtonItem66,
			this.spreadsheetCommandBarButtonItem67,
			this.spreadsheetCommandBarSubItem7,
			this.spreadsheetCommandBarButtonItem68,
			this.spreadsheetCommandBarButtonItem69,
			this.spreadsheetCommandBarButtonItem70,
			this.spreadsheetCommandBarButtonItem71,
			this.spreadsheetCommandBarButtonItem72,
			this.spreadsheetCommandBarButtonItem73,
			this.spreadsheetCommandBarSubItem8,
			this.spreadsheetCommandBarButtonGalleryDropDownItem8,
			this.spreadsheetCommandBarButtonGalleryDropDownItem9,
			this.spreadsheetCommandBarButtonGalleryDropDownItem10,
			this.spreadsheetCommandBarButtonItem74,
			this.spreadsheetCommandBarButtonItem75,
			this.spreadsheetCommandBarButtonItem76,
			this.spreadsheetCommandBarSubItem9,
			this.spreadsheetCommandBarButtonItem77,
			this.galleryFormatAsTableItem1,
			this.galleryChangeStyleItem1,
			this.spreadsheetCommandBarSubItem11,
			this.spreadsheetCommandBarButtonItem78,
			this.spreadsheetCommandBarButtonItem79,
			this.spreadsheetCommandBarButtonItem80,
			this.spreadsheetCommandBarButtonItem81,
			this.spreadsheetCommandBarButtonItem82,
			this.spreadsheetCommandBarButtonItem83,
			this.spreadsheetCommandBarButtonItem84,
			this.spreadsheetCommandBarButtonItem85,
			this.spreadsheetCommandBarSubItem12,
			this.spreadsheetCommandBarButtonItem86,
			this.spreadsheetCommandBarButtonItem87,
			this.spreadsheetCommandBarButtonItem88,
			this.spreadsheetCommandBarButtonItem89,
			this.spreadsheetCommandBarButtonItem90,
			this.spreadsheetCommandBarButtonItem91,
			this.spreadsheetCommandBarSubItem14,
			this.spreadsheetCommandBarButtonItem92,
			this.spreadsheetCommandBarButtonItem93,
			this.spreadsheetCommandBarButtonItem94,
			this.spreadsheetCommandBarButtonItem95,
			this.spreadsheetCommandBarButtonItem96,
			this.spreadsheetCommandBarButtonItem97,
			this.spreadsheetCommandBarButtonItem98,
			this.spreadsheetCommandBarButtonItem99,
			this.spreadsheetCommandBarButtonItem100,
			this.spreadsheetCommandBarButtonItem101,
			this.spreadsheetCommandBarButtonItem102,
			this.spreadsheetCommandBarSubItem13,
			this.spreadsheetCommandBarButtonItem103,
			this.spreadsheetCommandBarButtonItem104,
			this.changeSheetTabColorItem1,
			this.spreadsheetCommandBarButtonItem105,
			this.spreadsheetCommandBarCheckItem16,
			this.spreadsheetCommandBarButtonItem106,
			this.spreadsheetCommandBarSubItem15,
			this.spreadsheetCommandBarSubItem16,
			this.spreadsheetCommandBarButtonItem107,
			this.spreadsheetCommandBarButtonItem108,
			this.spreadsheetCommandBarButtonItem109,
			this.spreadsheetCommandBarButtonItem110,
			this.spreadsheetCommandBarSubItem17,
			this.spreadsheetCommandBarButtonItem111,
			this.spreadsheetCommandBarButtonItem112,
			this.spreadsheetCommandBarButtonItem113,
			this.spreadsheetCommandBarButtonItem114,
			this.spreadsheetCommandBarButtonItem115,
			this.spreadsheetCommandBarButtonItem116,
			this.spreadsheetCommandBarSubItem18,
			this.spreadsheetCommandBarButtonItem117,
			this.spreadsheetCommandBarButtonItem118,
			this.spreadsheetCommandBarCheckItem17,
			this.spreadsheetCommandBarButtonItem119,
			this.spreadsheetCommandBarButtonItem120,
			this.spreadsheetCommandBarSubItem19,
			this.spreadsheetCommandBarButtonItem121,
			this.spreadsheetCommandBarButtonItem122,
			this.spreadsheetCommandBarButtonItem123,
			this.spreadsheetCommandBarButtonItem124,
			this.spreadsheetCommandBarButtonItem125,
			this.spreadsheetCommandBarButtonItem126,
			this.spreadsheetCommandBarButtonItem127,
			this.barButtonItem1,
			this.spreadsheetCommandBarCheckItem18,
			this.spreadsheetCommandBarCheckItem19,
			this.spreadsheetCommandBarButtonItem128,
			this.spreadsheetCommandBarButtonItem129,
			this.spreadsheetCommandBarButtonItem130,
			this.spreadsheetCommandBarButtonItem131,
			this.spreadsheetCommandBarSubItem20,
			this.spreadsheetCommandBarButtonItem132,
			this.spreadsheetCommandBarButtonItem133,
			this.spreadsheetCommandBarButtonItem134,
			this.spreadsheetCommandBarButtonItem135,
			this.spreadsheetCommandBarButtonItem136,
			this.spreadsheetCommandBarButtonItem137,
			this.spreadsheetCommandBarButtonItem138,
			this.spreadsheetCommandBarButtonItem139,
			this.spreadsheetCommandBarButtonItem140,
			this.spreadsheetCommandBarButtonItem141,
			this.spreadsheetCommandBarButtonItem142,
			this.spreadsheetCommandBarButtonItem143,
			this.spreadsheetCommandBarSubItem21,
			this.spreadsheetCommandBarCheckItem20,
			this.spreadsheetCommandBarCheckItem21,
			this.spreadsheetCommandBarCheckItem22,
			this.spreadsheetCommandBarButtonItem144,
			this.spreadsheetCommandBarSubItem22,
			this.spreadsheetCommandBarCheckItem23,
			this.spreadsheetCommandBarCheckItem24,
			this.pageSetupPaperKindItem1,
			this.spreadsheetCommandBarSubItem23,
			this.spreadsheetCommandBarButtonItem145,
			this.spreadsheetCommandBarButtonItem146,
			this.spreadsheetCommandBarButtonItem147,
			this.spreadsheetCommandBarButtonItem148,
			this.spreadsheetCommandBarCheckItem25,
			this.spreadsheetCommandBarCheckItem26,
			this.spreadsheetCommandBarSubItem24,
			this.spreadsheetCommandBarButtonItem149,
			this.spreadsheetCommandBarButtonItem150,
			this.spreadsheetCommandBarSubItem25,
			this.spreadsheetCommandBarButtonItem151,
			this.spreadsheetCommandBarButtonItem152,
			this.spreadsheetCommandBarSubItem26,
			this.spreadsheetCommandBarButtonItem153,
			this.spreadsheetCommandBarButtonItem154,
			this.spreadsheetCommandBarButtonItem155,
			this.spreadsheetCommandBarSubItem27,
			this.spreadsheetCommandBarButtonItem156,
			this.spreadsheetCommandBarButtonItem157,
			this.spreadsheetCommandBarSubItem28,
			this.spreadsheetCommandBarButtonItem158,
			this.spreadsheetCommandBarButtonItem159,
			this.spreadsheetCommandBarButtonItem160,
			this.spreadsheetCommandBarButtonItem161,
			this.spreadsheetCommandBarButtonItem162,
			this.spreadsheetCommandBarButtonItem163,
			this.spreadsheetCommandBarButtonItem164,
			this.spreadsheetCommandBarButtonItem165,
			this.galleryChartLayoutItem1,
			this.galleryChartStyleItem1,
			this.spreadsheetCommandBarButtonItem166,
			this.spreadsheetCommandBarSubItem29,
			this.spreadsheetCommandBarButtonGalleryDropDownItem11,
			this.spreadsheetCommandBarButtonGalleryDropDownItem12,
			this.spreadsheetCommandBarSubItem30,
			this.spreadsheetCommandBarButtonGalleryDropDownItem13,
			this.spreadsheetCommandBarButtonGalleryDropDownItem14,
			this.spreadsheetCommandBarButtonGalleryDropDownItem15,
			this.spreadsheetCommandBarSubItem31,
			this.spreadsheetCommandBarButtonGalleryDropDownItem16,
			this.spreadsheetCommandBarButtonGalleryDropDownItem17,
			this.spreadsheetCommandBarButtonGalleryDropDownItem18,
			this.spreadsheetCommandBarButtonGalleryDropDownItem19,
			this.spreadsheetCommandBarButtonGalleryDropDownItem20,
			this.spreadsheetCommandBarButtonGalleryDropDownItem21,
			this.spreadsheetCommandBarButtonGalleryDropDownItem22,
			this.renameTableItemCaption1,
			this.renameTableItem1,
			this.spreadsheetCommandBarCheckItem27,
			this.spreadsheetCommandBarCheckItem28,
			this.spreadsheetCommandBarCheckItem29,
			this.spreadsheetCommandBarCheckItem30,
			this.spreadsheetCommandBarCheckItem31,
			this.spreadsheetCommandBarCheckItem32,
			this.spreadsheetCommandBarCheckItem33,
			this.galleryTableStylesItem1,
			this.spreadsheetCommandBarButtonItem167,
			this.spreadsheetCommandBarButtonItem168,
			this.spreadsheetCommandBarButtonItem169,
			this.spreadsheetCommandBarButtonItem170,
			this.spreadsheetCommandBarButtonItem171,
			this.spreadsheetCommandBarButtonItem172,
			this.spreadsheetCommandBarButtonItem173,
			this.spreadsheetCommandBarSubItem32,
			this.spreadsheetCommandBarButtonItem174,
			this.spreadsheetCommandBarButtonItem175,
			this.spreadsheetCommandBarButtonItem176,
			this.spreadsheetCommandBarSubItem33,
			this.spreadsheetCommandBarButtonItem177,
			this.spreadsheetCommandBarButtonItem178,
			this.spreadsheetCommandBarSubItem34,
			this.spreadsheetCommandBarButtonItem179,
			this.spreadsheetCommandBarButtonItem180,
			this.spreadsheetCommandBarButtonItem181,
			this.spreadsheetCommandBarButtonItem182,
			this.spreadsheetCommandBarSubItem35,
			this.spreadsheetCommandBarButtonItem183,
			this.spreadsheetCommandBarButtonItem184,
			this.spreadsheetCommandBarButtonItem185,
			this.spreadsheetCommandBarButtonItem186,
			this.spreadsheetCommandBarCheckItem34,
			this.spreadsheetCommandBarCheckItem35,
			this.spreadsheetCommandBarCheckItem36,
			this.spreadsheetCommandBarSubItem36,
			this.spreadsheetCommandBarButtonItem187,
			this.spreadsheetCommandBarButtonItem188,
			this.spreadsheetCommandBarButtonItem189,
			this.spreadsheetCommandBarSubItem37,
			this.spreadsheetCommandBarButtonItem190,
			this.spreadsheetCommandBarButtonItem191,
			this.spreadsheetCommandBarButtonItem192,
			this.spreadsheetCommandBarButtonItem193,
			this.spreadsheetCommandBarSubItem38,
			this.spreadsheetCommandBarButtonItem194,
			this.spreadsheetCommandBarButtonItem195,
			this.spreadsheetCommandBarButtonItem196,
			this.spreadsheetCommandBarButtonItem197,
			this.spreadsheetCommandBarButtonItem198,
			this.spreadsheetCommandBarSubItem39,
			this.spreadsheetCommandBarButtonItem199,
			this.spreadsheetCommandBarButtonItem200,
			this.spreadsheetCommandBarCheckItem37,
			this.spreadsheetCommandBarCheckItem38,
			this.spreadsheetCommandBarCheckItem39,
			this.spreadsheetCommandBarCheckItem40,
			this.galleryPivotStylesItem1,
			this.barButtonItem2
		});
		this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
		this.ribbonControl1.Margin = new System.Windows.Forms.Padding(2);
		this.ribbonControl1.MaxItemId = 351;
		this.ribbonControl1.Name = "ribbonControl1";
		this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[6] { this.fileRibbonPage1, this.homeRibbonPage1, this.formulasRibbonPage1, this.insertRibbonPage1, this.viewRibbonPage1, this.pageLayoutRibbonPage1 });
		this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[5] { this.repositoryItemZoomTrackBar1, this.repositoryItemFontEdit1, this.repositoryItemSpreadsheetFontSizeEdit1, this.repositoryItemPopupGalleryEdit1, this.repositoryItemTextEdit1 });
		this.ribbonControl1.Size = new System.Drawing.Size(1106, 142);
		this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
		this.spreadsheetCommandBarButtonItem1.Caption = "Nouveau";
		this.spreadsheetCommandBarButtonItem1.CommandName = "FileNew";
		this.spreadsheetCommandBarButtonItem1.Id = 1;
		this.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1";
		this.spreadsheetCommandBarButtonItem2.Caption = "Ouvrir";
		this.spreadsheetCommandBarButtonItem2.CommandName = "FileOpen";
		this.spreadsheetCommandBarButtonItem2.Id = 2;
		this.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2";
		this.spreadsheetCommandBarButtonItem3.Caption = "Enregistrer";
		this.spreadsheetCommandBarButtonItem3.CommandName = "FileSave";
		this.spreadsheetCommandBarButtonItem3.Id = 3;
		this.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3";
		this.spreadsheetCommandBarButtonItem4.Caption = "Enregistrer sous";
		this.spreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs";
		this.spreadsheetCommandBarButtonItem4.Id = 4;
		this.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4";
		this.spreadsheetCommandBarButtonItem5.Caption = "Impression rapide";
		this.spreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint";
		this.spreadsheetCommandBarButtonItem5.Id = 5;
		this.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5";
		this.spreadsheetCommandBarButtonItem6.Caption = "Imprimer";
		this.spreadsheetCommandBarButtonItem6.CommandName = "FilePrint";
		this.spreadsheetCommandBarButtonItem6.Id = 6;
		this.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6";
		this.spreadsheetCommandBarButtonItem7.Caption = "Aperçu d'impression";
		this.spreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview";
		this.spreadsheetCommandBarButtonItem7.Id = 7;
		this.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7";
		this.spreadsheetCommandBarButtonItem8.Caption = "Annuler";
		this.spreadsheetCommandBarButtonItem8.CommandName = "FileUndo";
		this.spreadsheetCommandBarButtonItem8.Id = 8;
		this.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8";
		this.spreadsheetCommandBarButtonItem9.Caption = "Refaire";
		this.spreadsheetCommandBarButtonItem9.CommandName = "FileRedo";
		this.spreadsheetCommandBarButtonItem9.Id = 9;
		this.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9";
		this.spreadsheetCommandBarButtonItem10.Caption = "Protéger par mot de passe";
		this.spreadsheetCommandBarButtonItem10.CommandName = "FileEncrypt";
		this.spreadsheetCommandBarButtonItem10.Id = 10;
		this.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10";
		this.spreadsheetCommandBarButtonItem11.Caption = "Propriétés du document";
		this.spreadsheetCommandBarButtonItem11.CommandName = "FileShowDocumentProperties";
		this.spreadsheetCommandBarButtonItem11.Id = 11;
		this.spreadsheetCommandBarButtonItem11.Name = "spreadsheetCommandBarButtonItem11";
		this.spreadsheetCommandBarSubItem1.CommandName = "FunctionsAutoSumCommandGroup";
		this.spreadsheetCommandBarSubItem1.Id = 12;
		this.spreadsheetCommandBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[5]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem12),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem13),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem14),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem15),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem16)
		});
		this.spreadsheetCommandBarSubItem1.Name = "spreadsheetCommandBarSubItem1";
		this.spreadsheetCommandBarButtonItem12.CommandName = "FunctionsInsertSum";
		this.spreadsheetCommandBarButtonItem12.Id = 13;
		this.spreadsheetCommandBarButtonItem12.Name = "spreadsheetCommandBarButtonItem12";
		this.spreadsheetCommandBarButtonItem13.CommandName = "FunctionsInsertAverage";
		this.spreadsheetCommandBarButtonItem13.Id = 14;
		this.spreadsheetCommandBarButtonItem13.Name = "spreadsheetCommandBarButtonItem13";
		this.spreadsheetCommandBarButtonItem14.CommandName = "FunctionsInsertCountNumbers";
		this.spreadsheetCommandBarButtonItem14.Id = 15;
		this.spreadsheetCommandBarButtonItem14.Name = "spreadsheetCommandBarButtonItem14";
		this.spreadsheetCommandBarButtonItem15.CommandName = "FunctionsInsertMax";
		this.spreadsheetCommandBarButtonItem15.Id = 16;
		this.spreadsheetCommandBarButtonItem15.Name = "spreadsheetCommandBarButtonItem15";
		this.spreadsheetCommandBarButtonItem16.CommandName = "FunctionsInsertMin";
		this.spreadsheetCommandBarButtonItem16.Id = 17;
		this.spreadsheetCommandBarButtonItem16.Name = "spreadsheetCommandBarButtonItem16";
		this.functionsFinancialItem1.Id = 18;
		this.functionsFinancialItem1.Name = "functionsFinancialItem1";
		this.functionsLogicalItem1.Id = 19;
		this.functionsLogicalItem1.Name = "functionsLogicalItem1";
		this.functionsTextItem1.Id = 20;
		this.functionsTextItem1.Name = "functionsTextItem1";
		this.functionsDateAndTimeItem1.Id = 21;
		this.functionsDateAndTimeItem1.Name = "functionsDateAndTimeItem1";
		this.functionsLookupAndReferenceItem1.Id = 22;
		this.functionsLookupAndReferenceItem1.Name = "functionsLookupAndReferenceItem1";
		this.functionsMathAndTrigonometryItem1.Id = 23;
		this.functionsMathAndTrigonometryItem1.Name = "functionsMathAndTrigonometryItem1";
		this.spreadsheetCommandBarSubItem2.CommandName = "FunctionsMoreCommandGroup";
		this.spreadsheetCommandBarSubItem2.Id = 24;
		this.spreadsheetCommandBarSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[5]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.functionsStatisticalItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.functionsEngineeringItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.functionsInformationItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.functionsCompatibilityItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.functionsWebItem1)
		});
		this.spreadsheetCommandBarSubItem2.Name = "spreadsheetCommandBarSubItem2";
		this.functionsStatisticalItem1.Id = 25;
		this.functionsStatisticalItem1.Name = "functionsStatisticalItem1";
		this.functionsEngineeringItem1.Id = 26;
		this.functionsEngineeringItem1.Name = "functionsEngineeringItem1";
		this.functionsInformationItem1.Id = 27;
		this.functionsInformationItem1.Name = "functionsInformationItem1";
		this.functionsCompatibilityItem1.Id = 28;
		this.functionsCompatibilityItem1.Name = "functionsCompatibilityItem1";
		this.functionsWebItem1.Id = 29;
		this.functionsWebItem1.Name = "functionsWebItem1";
		this.spreadsheetCommandBarButtonItem17.CommandName = "FormulasShowNameManager";
		this.spreadsheetCommandBarButtonItem17.Id = 30;
		this.spreadsheetCommandBarButtonItem17.Name = "spreadsheetCommandBarButtonItem17";
		this.spreadsheetCommandBarButtonItem18.CommandName = "FormulasDefineNameCommand";
		this.spreadsheetCommandBarButtonItem18.Id = 31;
		this.spreadsheetCommandBarButtonItem18.Name = "spreadsheetCommandBarButtonItem18";
		this.spreadsheetCommandBarButtonItem18.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.definedNameListItem1.Id = 32;
		this.definedNameListItem1.Name = "definedNameListItem1";
		this.definedNameListItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarButtonItem19.CommandName = "FormulasCreateDefinedNamesFromSelection";
		this.spreadsheetCommandBarButtonItem19.Id = 33;
		this.spreadsheetCommandBarButtonItem19.Name = "spreadsheetCommandBarButtonItem19";
		this.spreadsheetCommandBarButtonItem19.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarCheckItem1.CommandName = "ViewShowFormulas";
		this.spreadsheetCommandBarCheckItem1.Id = 34;
		this.spreadsheetCommandBarCheckItem1.Name = "spreadsheetCommandBarCheckItem1";
		this.spreadsheetCommandBarSubItem3.CommandName = "FormulasCalculationOptionsCommandGroup";
		this.spreadsheetCommandBarSubItem3.Id = 35;
		this.spreadsheetCommandBarSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem2),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem3)
		});
		this.spreadsheetCommandBarSubItem3.Name = "spreadsheetCommandBarSubItem3";
		this.spreadsheetCommandBarCheckItem2.CommandName = "FormulasCalculationModeAutomatic";
		this.spreadsheetCommandBarCheckItem2.Id = 36;
		this.spreadsheetCommandBarCheckItem2.Name = "spreadsheetCommandBarCheckItem2";
		this.spreadsheetCommandBarCheckItem3.CommandName = "FormulasCalculationModeManual";
		this.spreadsheetCommandBarCheckItem3.Id = 37;
		this.spreadsheetCommandBarCheckItem3.Name = "spreadsheetCommandBarCheckItem3";
		this.spreadsheetCommandBarButtonItem20.CommandName = "FormulasCalculateNow";
		this.spreadsheetCommandBarButtonItem20.Id = 38;
		this.spreadsheetCommandBarButtonItem20.Name = "spreadsheetCommandBarButtonItem20";
		this.spreadsheetCommandBarButtonItem20.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarButtonItem21.CommandName = "FormulasCalculateSheet";
		this.spreadsheetCommandBarButtonItem21.Id = 39;
		this.spreadsheetCommandBarButtonItem21.Name = "spreadsheetCommandBarButtonItem21";
		this.spreadsheetCommandBarButtonItem21.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.averageInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
		this.averageInfoStaticItem1.Id = 40;
		this.averageInfoStaticItem1.Name = "averageInfoStaticItem1";
		toolTipItem1.Text = "Average of selected cells";
		superToolTip1.Items.Add(toolTipItem1);
		this.averageInfoStaticItem1.SuperTip = superToolTip1;
		this.averageInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
		this.countInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
		this.countInfoStaticItem1.Id = 41;
		this.countInfoStaticItem1.Name = "countInfoStaticItem1";
		toolTipItem2.Text = "Number of selected cells that contain data";
		superToolTip2.Items.Add(toolTipItem2);
		this.countInfoStaticItem1.SuperTip = superToolTip2;
		this.countInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
		this.numericalCountInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
		this.numericalCountInfoStaticItem1.Id = 42;
		this.numericalCountInfoStaticItem1.Name = "numericalCountInfoStaticItem1";
		toolTipItem3.Text = "Number of selected cells that contain numerical data";
		superToolTip3.Items.Add(toolTipItem3);
		this.numericalCountInfoStaticItem1.SuperTip = superToolTip3;
		this.numericalCountInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
		this.minInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
		this.minInfoStaticItem1.Id = 43;
		this.minInfoStaticItem1.Name = "minInfoStaticItem1";
		toolTipItem4.Text = "Minimum value in selection";
		superToolTip4.Items.Add(toolTipItem4);
		this.minInfoStaticItem1.SuperTip = superToolTip4;
		this.minInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
		this.maxInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
		this.maxInfoStaticItem1.Id = 44;
		this.maxInfoStaticItem1.Name = "maxInfoStaticItem1";
		toolTipItem5.Text = "Maximum value in selection";
		superToolTip5.Items.Add(toolTipItem5);
		this.maxInfoStaticItem1.SuperTip = superToolTip5;
		this.maxInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
		this.sumInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
		this.sumInfoStaticItem1.Id = 45;
		this.sumInfoStaticItem1.Name = "sumInfoStaticItem1";
		toolTipItem6.Text = "Sum of selected cells";
		superToolTip6.Items.Add(toolTipItem6);
		this.sumInfoStaticItem1.SuperTip = superToolTip6;
		this.sumInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
		this.zoomEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
		this.zoomEditItem1.Edit = this.repositoryItemZoomTrackBar1;
		this.zoomEditItem1.Id = 46;
		this.zoomEditItem1.Name = "zoomEditItem1";
		toolTipItem7.Text = "Zoom";
		superToolTip7.Items.Add(toolTipItem7);
		this.zoomEditItem1.SuperTip = superToolTip7;
		this.repositoryItemZoomTrackBar1.AllowUseMiddleValue = true;
		this.repositoryItemZoomTrackBar1.LargeChange = 10;
		this.repositoryItemZoomTrackBar1.Maximum = 400;
		this.repositoryItemZoomTrackBar1.Middle = 100;
		this.repositoryItemZoomTrackBar1.Minimum = 10;
		this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
		this.repositoryItemZoomTrackBar1.SmallChange = 10;
		this.repositoryItemZoomTrackBar1.SnapToMiddle = 5;
		this.showZoomButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
		this.showZoomButtonItem1.Id = 47;
		this.showZoomButtonItem1.ItemAppearance.Disabled.Options.UseTextOptions = true;
		this.showZoomButtonItem1.ItemAppearance.Hovered.Options.UseTextOptions = true;
		this.showZoomButtonItem1.ItemAppearance.Normal.Options.UseTextOptions = true;
		this.showZoomButtonItem1.ItemAppearance.Pressed.Options.UseTextOptions = true;
		this.showZoomButtonItem1.Name = "showZoomButtonItem1";
		this.showZoomButtonItem1.SmallWithTextWidth = 45;
		toolTipItem8.Text = "Zoom level. Click to open the Zoom dialog box.";
		superToolTip8.Items.Add(toolTipItem8);
		this.showZoomButtonItem1.SuperTip = superToolTip8;
		this.spreadsheetCommandBarButtonItem22.CommandName = "InsertPivotTable";
		this.spreadsheetCommandBarButtonItem22.Id = 48;
		this.spreadsheetCommandBarButtonItem22.Name = "spreadsheetCommandBarButtonItem22";
		this.spreadsheetCommandBarButtonItem23.CommandName = "InsertTable";
		this.spreadsheetCommandBarButtonItem23.Id = 49;
		this.spreadsheetCommandBarButtonItem23.Name = "spreadsheetCommandBarButtonItem23";
		this.spreadsheetCommandBarButtonItem24.CommandName = "InsertPicture";
		this.spreadsheetCommandBarButtonItem24.Id = 50;
		this.spreadsheetCommandBarButtonItem24.Name = "spreadsheetCommandBarButtonItem24";
		this.spreadsheetCommandBarButtonGalleryDropDownItem1.CommandName = "InsertChartColumnCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem1.DropDownControl = this.commandBarGalleryDropDown1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem1.Id = 51;
		this.spreadsheetCommandBarButtonGalleryDropDownItem1.Name = "spreadsheetCommandBarButtonGalleryDropDownItem1";
		this.commandBarGalleryDropDown1.Gallery.AllowFilter = false;
		spreadsheetCommandGalleryItemGroup1.CommandName = "InsertChartColumn2DCommandGroup";
		spreadsheetCommandGalleryItem1.CommandName = "InsertChartColumnClustered2D";
		spreadsheetCommandGalleryItem2.CommandName = "InsertChartColumnStacked2D";
		spreadsheetCommandGalleryItem3.CommandName = "InsertChartColumnPercentStacked2D";
		spreadsheetCommandGalleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[3] { spreadsheetCommandGalleryItem1, spreadsheetCommandGalleryItem2, spreadsheetCommandGalleryItem3 });
		spreadsheetCommandGalleryItemGroup2.CommandName = "InsertChartColumn3DCommandGroup";
		spreadsheetCommandGalleryItem4.CommandName = "InsertChartColumnClustered3D";
		spreadsheetCommandGalleryItem5.CommandName = "InsertChartColumnStacked3D";
		spreadsheetCommandGalleryItem6.CommandName = "InsertChartColumnPercentStacked3D";
		spreadsheetCommandGalleryItem7.CommandName = "InsertChartColumn3D";
		spreadsheetCommandGalleryItemGroup2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[4] { spreadsheetCommandGalleryItem4, spreadsheetCommandGalleryItem5, spreadsheetCommandGalleryItem6, spreadsheetCommandGalleryItem7 });
		spreadsheetCommandGalleryItemGroup3.CommandName = "InsertChartCylinderCommandGroup";
		spreadsheetCommandGalleryItem8.CommandName = "InsertChartCylinderClustered";
		spreadsheetCommandGalleryItem9.CommandName = "InsertChartCylinderStacked";
		spreadsheetCommandGalleryItem10.CommandName = "InsertChartCylinderPercentStacked";
		spreadsheetCommandGalleryItem11.CommandName = "InsertChartCylinder";
		spreadsheetCommandGalleryItemGroup3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[4] { spreadsheetCommandGalleryItem8, spreadsheetCommandGalleryItem9, spreadsheetCommandGalleryItem10, spreadsheetCommandGalleryItem11 });
		spreadsheetCommandGalleryItemGroup4.CommandName = "InsertChartConeCommandGroup";
		spreadsheetCommandGalleryItem12.CommandName = "InsertChartConeClustered";
		spreadsheetCommandGalleryItem13.CommandName = "InsertChartConeStacked";
		spreadsheetCommandGalleryItem14.CommandName = "InsertChartConePercentStacked";
		spreadsheetCommandGalleryItem15.CommandName = "InsertChartCone";
		spreadsheetCommandGalleryItemGroup4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[4] { spreadsheetCommandGalleryItem12, spreadsheetCommandGalleryItem13, spreadsheetCommandGalleryItem14, spreadsheetCommandGalleryItem15 });
		spreadsheetCommandGalleryItemGroup5.CommandName = "InsertChartPyramidCommandGroup";
		spreadsheetCommandGalleryItem16.CommandName = "InsertChartPyramidClustered";
		spreadsheetCommandGalleryItem17.CommandName = "InsertChartPyramidStacked";
		spreadsheetCommandGalleryItem18.CommandName = "InsertChartPyramidPercentStacked";
		spreadsheetCommandGalleryItem19.CommandName = "InsertChartPyramid";
		spreadsheetCommandGalleryItemGroup5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[4] { spreadsheetCommandGalleryItem16, spreadsheetCommandGalleryItem17, spreadsheetCommandGalleryItem18, spreadsheetCommandGalleryItem19 });
		this.commandBarGalleryDropDown1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[5] { spreadsheetCommandGalleryItemGroup1, spreadsheetCommandGalleryItemGroup2, spreadsheetCommandGalleryItemGroup3, spreadsheetCommandGalleryItemGroup4, spreadsheetCommandGalleryItemGroup5 });
		this.commandBarGalleryDropDown1.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1";
		this.commandBarGalleryDropDown1.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem2.CommandName = "InsertChartLineCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem2.DropDownControl = this.commandBarGalleryDropDown2;
		this.spreadsheetCommandBarButtonGalleryDropDownItem2.Id = 52;
		this.spreadsheetCommandBarButtonGalleryDropDownItem2.Name = "spreadsheetCommandBarButtonGalleryDropDownItem2";
		this.commandBarGalleryDropDown2.Gallery.AllowFilter = false;
		spreadsheetCommandGalleryItemGroup6.CommandName = "InsertChartLine2DCommandGroup";
		spreadsheetCommandGalleryItem20.CommandName = "InsertChartLine";
		spreadsheetCommandGalleryItem21.CommandName = "InsertChartStackedLine";
		spreadsheetCommandGalleryItem22.CommandName = "InsertChartPercentStackedLine";
		spreadsheetCommandGalleryItem23.CommandName = "InsertChartLineWithMarkers";
		spreadsheetCommandGalleryItem24.CommandName = "InsertChartStackedLineWithMarkers";
		spreadsheetCommandGalleryItem25.CommandName = "InsertChartPercentStackedLineWithMarkers";
		spreadsheetCommandGalleryItemGroup6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[6] { spreadsheetCommandGalleryItem20, spreadsheetCommandGalleryItem21, spreadsheetCommandGalleryItem22, spreadsheetCommandGalleryItem23, spreadsheetCommandGalleryItem24, spreadsheetCommandGalleryItem25 });
		spreadsheetCommandGalleryItemGroup7.CommandName = "InsertChartLine3DCommandGroup";
		spreadsheetCommandGalleryItem26.CommandName = "InsertChartLine3D";
		spreadsheetCommandGalleryItemGroup7.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[1] { spreadsheetCommandGalleryItem26 });
		this.commandBarGalleryDropDown2.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[2] { spreadsheetCommandGalleryItemGroup6, spreadsheetCommandGalleryItemGroup7 });
		this.commandBarGalleryDropDown2.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2";
		this.commandBarGalleryDropDown2.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem3.CommandName = "InsertChartPieCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem3.DropDownControl = this.commandBarGalleryDropDown3;
		this.spreadsheetCommandBarButtonGalleryDropDownItem3.Id = 53;
		this.spreadsheetCommandBarButtonGalleryDropDownItem3.Name = "spreadsheetCommandBarButtonGalleryDropDownItem3";
		this.commandBarGalleryDropDown3.Gallery.AllowFilter = false;
		spreadsheetCommandGalleryItemGroup8.CommandName = "InsertChartPie2DCommandGroup";
		spreadsheetCommandGalleryItem27.CommandName = "InsertChartPie2D";
		spreadsheetCommandGalleryItem28.CommandName = "InsertChartPieExploded2D";
		spreadsheetCommandGalleryItemGroup8.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[2] { spreadsheetCommandGalleryItem27, spreadsheetCommandGalleryItem28 });
		spreadsheetCommandGalleryItemGroup9.CommandName = "InsertChartPie3DCommandGroup";
		spreadsheetCommandGalleryItem29.CommandName = "InsertChartPie3D";
		spreadsheetCommandGalleryItem30.CommandName = "InsertChartPieExploded3D";
		spreadsheetCommandGalleryItemGroup9.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[2] { spreadsheetCommandGalleryItem29, spreadsheetCommandGalleryItem30 });
		spreadsheetCommandGalleryItemGroup10.CommandName = "InsertChartDoughnut2DCommandGroup";
		spreadsheetCommandGalleryItem31.CommandName = "InsertChartDoughnut2D";
		spreadsheetCommandGalleryItem32.CommandName = "InsertChartDoughnutExploded2D";
		spreadsheetCommandGalleryItemGroup10.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[2] { spreadsheetCommandGalleryItem31, spreadsheetCommandGalleryItem32 });
		this.commandBarGalleryDropDown3.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[3] { spreadsheetCommandGalleryItemGroup8, spreadsheetCommandGalleryItemGroup9, spreadsheetCommandGalleryItemGroup10 });
		this.commandBarGalleryDropDown3.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown3.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3";
		this.commandBarGalleryDropDown3.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem4.CommandName = "InsertChartBarCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem4.DropDownControl = this.commandBarGalleryDropDown4;
		this.spreadsheetCommandBarButtonGalleryDropDownItem4.Id = 54;
		this.spreadsheetCommandBarButtonGalleryDropDownItem4.Name = "spreadsheetCommandBarButtonGalleryDropDownItem4";
		this.commandBarGalleryDropDown4.Gallery.AllowFilter = false;
		spreadsheetCommandGalleryItemGroup11.CommandName = "InsertChartBar2DCommandGroup";
		spreadsheetCommandGalleryItem33.CommandName = "InsertChartBarClustered2D";
		spreadsheetCommandGalleryItem34.CommandName = "InsertChartBarStacked2D";
		spreadsheetCommandGalleryItem35.CommandName = "InsertChartBarPercentStacked2D";
		spreadsheetCommandGalleryItemGroup11.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[3] { spreadsheetCommandGalleryItem33, spreadsheetCommandGalleryItem34, spreadsheetCommandGalleryItem35 });
		spreadsheetCommandGalleryItemGroup12.CommandName = "InsertChartBar3DCommandGroup";
		spreadsheetCommandGalleryItem36.CommandName = "InsertChartBarClustered3D";
		spreadsheetCommandGalleryItem37.CommandName = "InsertChartBarStacked3D";
		spreadsheetCommandGalleryItem38.CommandName = "InsertChartBarPercentStacked3D";
		spreadsheetCommandGalleryItemGroup12.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[3] { spreadsheetCommandGalleryItem36, spreadsheetCommandGalleryItem37, spreadsheetCommandGalleryItem38 });
		spreadsheetCommandGalleryItemGroup13.CommandName = "InsertChartHorizontalCylinderCommandGroup";
		spreadsheetCommandGalleryItem39.CommandName = "InsertChartHorizontalCylinderClustered";
		spreadsheetCommandGalleryItem40.CommandName = "InsertChartHorizontalCylinderStacked";
		spreadsheetCommandGalleryItem41.CommandName = "InsertChartHorizontalCylinderPercentStacked";
		spreadsheetCommandGalleryItemGroup13.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[3] { spreadsheetCommandGalleryItem39, spreadsheetCommandGalleryItem40, spreadsheetCommandGalleryItem41 });
		spreadsheetCommandGalleryItemGroup14.CommandName = "InsertChartHorizontalConeCommandGroup";
		spreadsheetCommandGalleryItem42.CommandName = "InsertChartHorizontalConeClustered";
		spreadsheetCommandGalleryItem43.CommandName = "InsertChartHorizontalConeStacked";
		spreadsheetCommandGalleryItem44.CommandName = "InsertChartHorizontalConePercentStacked";
		spreadsheetCommandGalleryItemGroup14.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[3] { spreadsheetCommandGalleryItem42, spreadsheetCommandGalleryItem43, spreadsheetCommandGalleryItem44 });
		spreadsheetCommandGalleryItemGroup15.CommandName = "InsertChartHorizontalPyramidCommandGroup";
		spreadsheetCommandGalleryItem45.CommandName = "InsertChartHorizontalPyramidClustered";
		spreadsheetCommandGalleryItem46.CommandName = "InsertChartHorizontalPyramidStacked";
		spreadsheetCommandGalleryItem47.CommandName = "InsertChartHorizontalPyramidPercentStacked";
		spreadsheetCommandGalleryItemGroup15.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[3] { spreadsheetCommandGalleryItem45, spreadsheetCommandGalleryItem46, spreadsheetCommandGalleryItem47 });
		this.commandBarGalleryDropDown4.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[5] { spreadsheetCommandGalleryItemGroup11, spreadsheetCommandGalleryItemGroup12, spreadsheetCommandGalleryItemGroup13, spreadsheetCommandGalleryItemGroup14, spreadsheetCommandGalleryItemGroup15 });
		this.commandBarGalleryDropDown4.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown4.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4";
		this.commandBarGalleryDropDown4.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem5.CommandName = "InsertChartAreaCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem5.DropDownControl = this.commandBarGalleryDropDown5;
		this.spreadsheetCommandBarButtonGalleryDropDownItem5.Id = 55;
		this.spreadsheetCommandBarButtonGalleryDropDownItem5.Name = "spreadsheetCommandBarButtonGalleryDropDownItem5";
		this.commandBarGalleryDropDown5.Gallery.AllowFilter = false;
		spreadsheetCommandGalleryItemGroup16.CommandName = "InsertChartArea2DCommandGroup";
		spreadsheetCommandGalleryItem48.CommandName = "InsertChartArea";
		spreadsheetCommandGalleryItem49.CommandName = "InsertChartStackedArea";
		spreadsheetCommandGalleryItem50.CommandName = "InsertChartPercentStackedArea";
		spreadsheetCommandGalleryItemGroup16.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[3] { spreadsheetCommandGalleryItem48, spreadsheetCommandGalleryItem49, spreadsheetCommandGalleryItem50 });
		spreadsheetCommandGalleryItemGroup17.CommandName = "InsertChartArea3DCommandGroup";
		spreadsheetCommandGalleryItem51.CommandName = "InsertChartArea3D";
		spreadsheetCommandGalleryItem52.CommandName = "InsertChartStackedArea3D";
		spreadsheetCommandGalleryItem53.CommandName = "InsertChartPercentStackedArea3D";
		spreadsheetCommandGalleryItemGroup17.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[3] { spreadsheetCommandGalleryItem51, spreadsheetCommandGalleryItem52, spreadsheetCommandGalleryItem53 });
		this.commandBarGalleryDropDown5.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[2] { spreadsheetCommandGalleryItemGroup16, spreadsheetCommandGalleryItemGroup17 });
		this.commandBarGalleryDropDown5.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown5.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5";
		this.commandBarGalleryDropDown5.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem6.CommandName = "InsertChartScatterCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem6.DropDownControl = this.commandBarGalleryDropDown6;
		this.spreadsheetCommandBarButtonGalleryDropDownItem6.Id = 56;
		this.spreadsheetCommandBarButtonGalleryDropDownItem6.Name = "spreadsheetCommandBarButtonGalleryDropDownItem6";
		this.commandBarGalleryDropDown6.Gallery.AllowFilter = false;
		spreadsheetCommandGalleryItemGroup18.CommandName = "InsertChartScatterCommandGroup";
		spreadsheetCommandGalleryItem54.CommandName = "InsertChartScatterMarkers";
		spreadsheetCommandGalleryItem55.CommandName = "InsertChartScatterSmoothLinesAndMarkers";
		spreadsheetCommandGalleryItem56.CommandName = "InsertChartScatterSmoothLines";
		spreadsheetCommandGalleryItem57.CommandName = "InsertChartScatterLinesAndMarkers";
		spreadsheetCommandGalleryItem58.CommandName = "InsertChartScatterLines";
		spreadsheetCommandGalleryItemGroup18.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[5] { spreadsheetCommandGalleryItem54, spreadsheetCommandGalleryItem55, spreadsheetCommandGalleryItem56, spreadsheetCommandGalleryItem57, spreadsheetCommandGalleryItem58 });
		spreadsheetCommandGalleryItemGroup19.CommandName = "InsertChartBubbleCommandGroup";
		spreadsheetCommandGalleryItem59.CommandName = "InsertChartBubble";
		spreadsheetCommandGalleryItem60.CommandName = "InsertChartBubble3D";
		spreadsheetCommandGalleryItemGroup19.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[2] { spreadsheetCommandGalleryItem59, spreadsheetCommandGalleryItem60 });
		this.commandBarGalleryDropDown6.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[2] { spreadsheetCommandGalleryItemGroup18, spreadsheetCommandGalleryItemGroup19 });
		this.commandBarGalleryDropDown6.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown6.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown6.Name = "commandBarGalleryDropDown6";
		this.commandBarGalleryDropDown6.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem7.CommandName = "InsertChartOtherCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem7.DropDownControl = this.commandBarGalleryDropDown7;
		this.spreadsheetCommandBarButtonGalleryDropDownItem7.Id = 57;
		this.spreadsheetCommandBarButtonGalleryDropDownItem7.Name = "spreadsheetCommandBarButtonGalleryDropDownItem7";
		this.commandBarGalleryDropDown7.Gallery.AllowFilter = false;
		spreadsheetCommandGalleryItemGroup20.CommandName = "InsertChartStockCommandGroup";
		spreadsheetCommandGalleryItem61.CommandName = "InsertChartStockHighLowClose";
		spreadsheetCommandGalleryItem62.CommandName = "InsertChartStockOpenHighLowClose";
		spreadsheetCommandGalleryItem63.CommandName = "InsertChartStockVolumeHighLowClose";
		spreadsheetCommandGalleryItem64.CommandName = "InsertChartStockVolumeOpenHighLowClose";
		spreadsheetCommandGalleryItemGroup20.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[4] { spreadsheetCommandGalleryItem61, spreadsheetCommandGalleryItem62, spreadsheetCommandGalleryItem63, spreadsheetCommandGalleryItem64 });
		spreadsheetCommandGalleryItemGroup21.CommandName = "InsertChartRadarCommandGroup";
		spreadsheetCommandGalleryItem65.CommandName = "InsertChartRadar";
		spreadsheetCommandGalleryItem66.CommandName = "InsertChartRadarWithMarkers";
		spreadsheetCommandGalleryItem67.CommandName = "InsertChartRadarFilled";
		spreadsheetCommandGalleryItemGroup21.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[3] { spreadsheetCommandGalleryItem65, spreadsheetCommandGalleryItem66, spreadsheetCommandGalleryItem67 });
		this.commandBarGalleryDropDown7.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[2] { spreadsheetCommandGalleryItemGroup20, spreadsheetCommandGalleryItemGroup21 });
		this.commandBarGalleryDropDown7.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown7.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown7.Name = "commandBarGalleryDropDown7";
		this.commandBarGalleryDropDown7.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonItem25.CommandName = "InsertHyperlink";
		this.spreadsheetCommandBarButtonItem25.Id = 58;
		this.spreadsheetCommandBarButtonItem25.Name = "spreadsheetCommandBarButtonItem25";
		this.spreadsheetCommandBarButtonItem26.CommandName = "InsertSymbol";
		this.spreadsheetCommandBarButtonItem26.Id = 59;
		this.spreadsheetCommandBarButtonItem26.Name = "spreadsheetCommandBarButtonItem26";
		this.spreadsheetCommandBarButtonItem27.Caption = "Coller";
		this.spreadsheetCommandBarButtonItem27.CommandName = "PasteSelection";
		this.spreadsheetCommandBarButtonItem27.Id = 70;
		this.spreadsheetCommandBarButtonItem27.Name = "spreadsheetCommandBarButtonItem27";
		this.spreadsheetCommandBarButtonItem27.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem28.Caption = "Couper";
		this.spreadsheetCommandBarButtonItem28.CommandName = "CutSelection";
		this.spreadsheetCommandBarButtonItem28.Id = 71;
		this.spreadsheetCommandBarButtonItem28.Name = "spreadsheetCommandBarButtonItem28";
		this.spreadsheetCommandBarButtonItem28.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarButtonItem29.Caption = "Copier";
		this.spreadsheetCommandBarButtonItem29.CommandName = "CopySelection";
		this.spreadsheetCommandBarButtonItem29.Id = 72;
		this.spreadsheetCommandBarButtonItem29.Name = "spreadsheetCommandBarButtonItem29";
		this.spreadsheetCommandBarButtonItem29.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarButtonItem30.Caption = "Collage spécial";
		this.spreadsheetCommandBarButtonItem30.CommandName = "ShowPasteSpecialForm";
		this.spreadsheetCommandBarButtonItem30.Id = 73;
		this.spreadsheetCommandBarButtonItem30.Name = "spreadsheetCommandBarButtonItem30";
		this.spreadsheetCommandBarButtonItem30.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.barButtonGroup1.Id = 60;
		this.barButtonGroup1.ItemLinks.Add(this.changeFontNameItem1);
		this.barButtonGroup1.ItemLinks.Add(this.changeFontSizeItem1);
		this.barButtonGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem31);
		this.barButtonGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem32);
		this.barButtonGroup1.Name = "barButtonGroup1";
		this.barButtonGroup1.Tag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}";
		this.changeFontNameItem1.Edit = this.repositoryItemFontEdit1;
		this.changeFontNameItem1.Id = 74;
		this.changeFontNameItem1.Name = "changeFontNameItem1";
		this.repositoryItemFontEdit1.AutoHeight = false;
		this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
		this.changeFontSizeItem1.Edit = this.repositoryItemSpreadsheetFontSizeEdit1;
		this.changeFontSizeItem1.Id = 75;
		this.changeFontSizeItem1.Name = "changeFontSizeItem1";
		this.repositoryItemSpreadsheetFontSizeEdit1.AutoHeight = false;
		this.repositoryItemSpreadsheetFontSizeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.repositoryItemSpreadsheetFontSizeEdit1.Control = this.spreadsheetControl1;
		this.repositoryItemSpreadsheetFontSizeEdit1.Name = "repositoryItemSpreadsheetFontSizeEdit1";
		this.spreadsheetCommandBarButtonItem31.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}";
		this.spreadsheetCommandBarButtonItem31.CommandName = "FormatIncreaseFontSize";
		this.spreadsheetCommandBarButtonItem31.Id = 76;
		this.spreadsheetCommandBarButtonItem31.Name = "spreadsheetCommandBarButtonItem31";
		this.spreadsheetCommandBarButtonItem31.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.spreadsheetCommandBarButtonItem32.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}";
		this.spreadsheetCommandBarButtonItem32.CommandName = "FormatDecreaseFontSize";
		this.spreadsheetCommandBarButtonItem32.Id = 77;
		this.spreadsheetCommandBarButtonItem32.Name = "spreadsheetCommandBarButtonItem32";
		this.spreadsheetCommandBarButtonItem32.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.barButtonGroup2.Id = 61;
		this.barButtonGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem4);
		this.barButtonGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem5);
		this.barButtonGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem6);
		this.barButtonGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem7);
		this.barButtonGroup2.Name = "barButtonGroup2";
		this.barButtonGroup2.Tag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
		this.spreadsheetCommandBarCheckItem4.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
		this.spreadsheetCommandBarCheckItem4.CommandName = "FormatFontBold";
		this.spreadsheetCommandBarCheckItem4.Id = 78;
		this.spreadsheetCommandBarCheckItem4.Name = "spreadsheetCommandBarCheckItem4";
		this.spreadsheetCommandBarCheckItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.spreadsheetCommandBarCheckItem5.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
		this.spreadsheetCommandBarCheckItem5.CommandName = "FormatFontItalic";
		this.spreadsheetCommandBarCheckItem5.Id = 79;
		this.spreadsheetCommandBarCheckItem5.Name = "spreadsheetCommandBarCheckItem5";
		this.spreadsheetCommandBarCheckItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.spreadsheetCommandBarCheckItem6.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
		this.spreadsheetCommandBarCheckItem6.CommandName = "FormatFontUnderline";
		this.spreadsheetCommandBarCheckItem6.Id = 80;
		this.spreadsheetCommandBarCheckItem6.Name = "spreadsheetCommandBarCheckItem6";
		this.spreadsheetCommandBarCheckItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.spreadsheetCommandBarCheckItem7.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
		this.spreadsheetCommandBarCheckItem7.CommandName = "FormatFontStrikeout";
		this.spreadsheetCommandBarCheckItem7.Id = 81;
		this.spreadsheetCommandBarCheckItem7.Name = "spreadsheetCommandBarCheckItem7";
		this.spreadsheetCommandBarCheckItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.barButtonGroup3.Id = 62;
		this.barButtonGroup3.ItemLinks.Add(this.spreadsheetCommandBarSubItem4);
		this.barButtonGroup3.Name = "barButtonGroup3";
		this.barButtonGroup3.Tag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}";
		this.spreadsheetCommandBarSubItem4.ButtonGroupTag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}";
		this.spreadsheetCommandBarSubItem4.CommandName = "FormatBordersCommandGroup";
		this.spreadsheetCommandBarSubItem4.Id = 82;
		this.spreadsheetCommandBarSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[15]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem33),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem34),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem35),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem36),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem37),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem38),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem39),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem40),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem41),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem42),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem43),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem44),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem45),
			new DevExpress.XtraBars.LinkPersistInfo(this.changeBorderLineColorItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.changeBorderLineStyleItem1)
		});
		this.spreadsheetCommandBarSubItem4.Name = "spreadsheetCommandBarSubItem4";
		this.spreadsheetCommandBarSubItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.spreadsheetCommandBarButtonItem33.CommandName = "FormatBottomBorder";
		this.spreadsheetCommandBarButtonItem33.Id = 83;
		this.spreadsheetCommandBarButtonItem33.Name = "spreadsheetCommandBarButtonItem33";
		this.spreadsheetCommandBarButtonItem34.CommandName = "FormatTopBorder";
		this.spreadsheetCommandBarButtonItem34.Id = 84;
		this.spreadsheetCommandBarButtonItem34.Name = "spreadsheetCommandBarButtonItem34";
		this.spreadsheetCommandBarButtonItem35.CommandName = "FormatLeftBorder";
		this.spreadsheetCommandBarButtonItem35.Id = 85;
		this.spreadsheetCommandBarButtonItem35.Name = "spreadsheetCommandBarButtonItem35";
		this.spreadsheetCommandBarButtonItem36.CommandName = "FormatRightBorder";
		this.spreadsheetCommandBarButtonItem36.Id = 86;
		this.spreadsheetCommandBarButtonItem36.Name = "spreadsheetCommandBarButtonItem36";
		this.spreadsheetCommandBarButtonItem37.CommandName = "FormatNoBorders";
		this.spreadsheetCommandBarButtonItem37.Id = 87;
		this.spreadsheetCommandBarButtonItem37.Name = "spreadsheetCommandBarButtonItem37";
		this.spreadsheetCommandBarButtonItem38.CommandName = "FormatAllBorders";
		this.spreadsheetCommandBarButtonItem38.Id = 88;
		this.spreadsheetCommandBarButtonItem38.Name = "spreadsheetCommandBarButtonItem38";
		this.spreadsheetCommandBarButtonItem39.CommandName = "FormatOutsideBorders";
		this.spreadsheetCommandBarButtonItem39.Id = 89;
		this.spreadsheetCommandBarButtonItem39.Name = "spreadsheetCommandBarButtonItem39";
		this.spreadsheetCommandBarButtonItem40.CommandName = "FormatThickBorder";
		this.spreadsheetCommandBarButtonItem40.Id = 90;
		this.spreadsheetCommandBarButtonItem40.Name = "spreadsheetCommandBarButtonItem40";
		this.spreadsheetCommandBarButtonItem41.CommandName = "FormatBottomDoubleBorder";
		this.spreadsheetCommandBarButtonItem41.Id = 91;
		this.spreadsheetCommandBarButtonItem41.Name = "spreadsheetCommandBarButtonItem41";
		this.spreadsheetCommandBarButtonItem42.CommandName = "FormatBottomThickBorder";
		this.spreadsheetCommandBarButtonItem42.Id = 92;
		this.spreadsheetCommandBarButtonItem42.Name = "spreadsheetCommandBarButtonItem42";
		this.spreadsheetCommandBarButtonItem43.CommandName = "FormatTopAndBottomBorder";
		this.spreadsheetCommandBarButtonItem43.Id = 93;
		this.spreadsheetCommandBarButtonItem43.Name = "spreadsheetCommandBarButtonItem43";
		this.spreadsheetCommandBarButtonItem44.CommandName = "FormatTopAndThickBottomBorder";
		this.spreadsheetCommandBarButtonItem44.Id = 94;
		this.spreadsheetCommandBarButtonItem44.Name = "spreadsheetCommandBarButtonItem44";
		this.spreadsheetCommandBarButtonItem45.CommandName = "FormatTopAndDoubleBottomBorder";
		this.spreadsheetCommandBarButtonItem45.Id = 95;
		this.spreadsheetCommandBarButtonItem45.Name = "spreadsheetCommandBarButtonItem45";
		this.changeBorderLineColorItem1.ActAsDropDown = true;
		this.changeBorderLineColorItem1.Id = 96;
		this.changeBorderLineColorItem1.Name = "changeBorderLineColorItem1";
		this.changeBorderLineStyleItem1.DropDownControl = this.commandBarGalleryDropDown8;
		this.changeBorderLineStyleItem1.Id = 97;
		this.changeBorderLineStyleItem1.Name = "changeBorderLineStyleItem1";
		this.commandBarGalleryDropDown8.Gallery.AllowFilter = false;
		this.commandBarGalleryDropDown8.Gallery.ColumnCount = 1;
		this.commandBarGalleryDropDown8.Gallery.DrawImageBackground = false;
		this.commandBarGalleryDropDown8.Gallery.ImageSize = new System.Drawing.Size(65, 46);
		this.commandBarGalleryDropDown8.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
		this.commandBarGalleryDropDown8.Gallery.ItemSize = new System.Drawing.Size(136, 26);
		this.commandBarGalleryDropDown8.Gallery.RowCount = 14;
		this.commandBarGalleryDropDown8.Gallery.ShowGroupCaption = false;
		this.commandBarGalleryDropDown8.Gallery.ShowItemText = true;
		this.commandBarGalleryDropDown8.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown8.Name = "commandBarGalleryDropDown8";
		this.commandBarGalleryDropDown8.Ribbon = this.ribbonControl1;
		this.barButtonGroup4.Id = 63;
		this.barButtonGroup4.ItemLinks.Add(this.changeCellFillColorItem1);
		this.barButtonGroup4.ItemLinks.Add(this.changeFontColorItem1);
		this.barButtonGroup4.Name = "barButtonGroup4";
		this.barButtonGroup4.Tag = "{C2275623-04A3-41E8-8D6A-EB5C7F8541D1}";
		this.changeCellFillColorItem1.Id = 98;
		this.changeCellFillColorItem1.Name = "changeCellFillColorItem1";
		this.changeFontColorItem1.Id = 99;
		this.changeFontColorItem1.Name = "changeFontColorItem1";
		this.barButtonGroup5.Id = 64;
		this.barButtonGroup5.ItemLinks.Add(this.spreadsheetCommandBarCheckItem8);
		this.barButtonGroup5.ItemLinks.Add(this.spreadsheetCommandBarCheckItem9);
		this.barButtonGroup5.ItemLinks.Add(this.spreadsheetCommandBarCheckItem10);
		this.barButtonGroup5.Name = "barButtonGroup5";
		this.barButtonGroup5.Tag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
		this.spreadsheetCommandBarCheckItem8.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
		this.spreadsheetCommandBarCheckItem8.CommandName = "FormatAlignmentTop";
		this.spreadsheetCommandBarCheckItem8.Id = 100;
		this.spreadsheetCommandBarCheckItem8.Name = "spreadsheetCommandBarCheckItem8";
		this.spreadsheetCommandBarCheckItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.spreadsheetCommandBarCheckItem9.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
		this.spreadsheetCommandBarCheckItem9.CommandName = "FormatAlignmentMiddle";
		this.spreadsheetCommandBarCheckItem9.Id = 101;
		this.spreadsheetCommandBarCheckItem9.Name = "spreadsheetCommandBarCheckItem9";
		this.spreadsheetCommandBarCheckItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.spreadsheetCommandBarCheckItem10.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
		this.spreadsheetCommandBarCheckItem10.CommandName = "FormatAlignmentBottom";
		this.spreadsheetCommandBarCheckItem10.Id = 102;
		this.spreadsheetCommandBarCheckItem10.Name = "spreadsheetCommandBarCheckItem10";
		this.spreadsheetCommandBarCheckItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.barButtonGroup6.Id = 65;
		this.barButtonGroup6.ItemLinks.Add(this.spreadsheetCommandBarCheckItem11);
		this.barButtonGroup6.ItemLinks.Add(this.spreadsheetCommandBarCheckItem12);
		this.barButtonGroup6.ItemLinks.Add(this.spreadsheetCommandBarCheckItem13);
		this.barButtonGroup6.Name = "barButtonGroup6";
		this.barButtonGroup6.Tag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
		this.spreadsheetCommandBarCheckItem11.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
		this.spreadsheetCommandBarCheckItem11.CommandName = "FormatAlignmentLeft";
		this.spreadsheetCommandBarCheckItem11.Id = 103;
		this.spreadsheetCommandBarCheckItem11.Name = "spreadsheetCommandBarCheckItem11";
		this.spreadsheetCommandBarCheckItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.spreadsheetCommandBarCheckItem12.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
		this.spreadsheetCommandBarCheckItem12.CommandName = "FormatAlignmentCenter";
		this.spreadsheetCommandBarCheckItem12.Id = 104;
		this.spreadsheetCommandBarCheckItem12.Name = "spreadsheetCommandBarCheckItem12";
		this.spreadsheetCommandBarCheckItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.spreadsheetCommandBarCheckItem13.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
		this.spreadsheetCommandBarCheckItem13.CommandName = "FormatAlignmentRight";
		this.spreadsheetCommandBarCheckItem13.Id = 105;
		this.spreadsheetCommandBarCheckItem13.Name = "spreadsheetCommandBarCheckItem13";
		this.spreadsheetCommandBarCheckItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.barButtonGroup7.Id = 66;
		this.barButtonGroup7.ItemLinks.Add(this.spreadsheetCommandBarButtonItem46);
		this.barButtonGroup7.ItemLinks.Add(this.spreadsheetCommandBarButtonItem47);
		this.barButtonGroup7.Name = "barButtonGroup7";
		this.barButtonGroup7.Tag = "{A5E37DED-106E-44FC-8044-CE3824C08225}";
		this.spreadsheetCommandBarButtonItem46.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}";
		this.spreadsheetCommandBarButtonItem46.CommandName = "FormatDecreaseIndent";
		this.spreadsheetCommandBarButtonItem46.Id = 106;
		this.spreadsheetCommandBarButtonItem46.Name = "spreadsheetCommandBarButtonItem46";
		this.spreadsheetCommandBarButtonItem46.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.spreadsheetCommandBarButtonItem47.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}";
		this.spreadsheetCommandBarButtonItem47.CommandName = "FormatIncreaseIndent";
		this.spreadsheetCommandBarButtonItem47.Id = 107;
		this.spreadsheetCommandBarButtonItem47.Name = "spreadsheetCommandBarButtonItem47";
		this.spreadsheetCommandBarButtonItem47.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.spreadsheetCommandBarCheckItem14.Caption = "Habillage du texte";
		this.spreadsheetCommandBarCheckItem14.CommandName = "FormatWrapText";
		this.spreadsheetCommandBarCheckItem14.Id = 108;
		this.spreadsheetCommandBarCheckItem14.Name = "spreadsheetCommandBarCheckItem14";
		this.spreadsheetCommandBarCheckItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarSubItem5.Caption = "Fusionner cellules";
		this.spreadsheetCommandBarSubItem5.CommandName = "EditingMergeCellsCommandGroup";
		this.spreadsheetCommandBarSubItem5.Id = 109;
		this.spreadsheetCommandBarSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[4]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem15),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem48),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem49),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem50)
		});
		this.spreadsheetCommandBarSubItem5.Name = "spreadsheetCommandBarSubItem5";
		this.spreadsheetCommandBarSubItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarCheckItem15.CommandName = "EditingMergeAndCenterCells";
		this.spreadsheetCommandBarCheckItem15.Id = 110;
		this.spreadsheetCommandBarCheckItem15.Name = "spreadsheetCommandBarCheckItem15";
		this.spreadsheetCommandBarButtonItem48.CommandName = "EditingMergeCellsAcross";
		this.spreadsheetCommandBarButtonItem48.Id = 111;
		this.spreadsheetCommandBarButtonItem48.Name = "spreadsheetCommandBarButtonItem48";
		this.spreadsheetCommandBarButtonItem49.CommandName = "EditingMergeCells";
		this.spreadsheetCommandBarButtonItem49.Id = 112;
		this.spreadsheetCommandBarButtonItem49.Name = "spreadsheetCommandBarButtonItem49";
		this.spreadsheetCommandBarButtonItem50.CommandName = "EditingUnmergeCells";
		this.spreadsheetCommandBarButtonItem50.Id = 113;
		this.spreadsheetCommandBarButtonItem50.Name = "spreadsheetCommandBarButtonItem50";
		this.barButtonGroup8.Id = 67;
		this.barButtonGroup8.ItemLinks.Add(this.changeNumberFormatItem1);
		this.barButtonGroup8.Name = "barButtonGroup8";
		this.barButtonGroup8.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}";
		this.changeNumberFormatItem1.Edit = this.repositoryItemPopupGalleryEdit1;
		this.changeNumberFormatItem1.Id = 114;
		this.changeNumberFormatItem1.Name = "changeNumberFormatItem1";
		this.repositoryItemPopupGalleryEdit1.AutoHeight = false;
		this.repositoryItemPopupGalleryEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.repositoryItemPopupGalleryEdit1.Gallery.AllowFilter = false;
		this.repositoryItemPopupGalleryEdit1.Gallery.AutoFitColumns = false;
		this.repositoryItemPopupGalleryEdit1.Gallery.ColumnCount = 1;
		this.repositoryItemPopupGalleryEdit1.Gallery.FixedImageSize = false;
		spreadsheetCommandGalleryItem68.AlwaysUpdateDescription = true;
		spreadsheetCommandGalleryItem68.CaptionAsValue = true;
		spreadsheetCommandGalleryItem68.Checked = true;
		spreadsheetCommandGalleryItem68.CommandName = "FormatNumberGeneral";
		spreadsheetCommandGalleryItem68.IsEmptyHint = true;
		spreadsheetCommandGalleryItem69.AlwaysUpdateDescription = true;
		spreadsheetCommandGalleryItem69.CaptionAsValue = true;
		spreadsheetCommandGalleryItem69.CommandName = "FormatNumberDecimal";
		spreadsheetCommandGalleryItem69.IsEmptyHint = true;
		spreadsheetCommandGalleryItem70.AlwaysUpdateDescription = true;
		spreadsheetCommandGalleryItem70.CaptionAsValue = true;
		spreadsheetCommandGalleryItem70.CommandName = "FormatNumberAccountingCurrency";
		spreadsheetCommandGalleryItem70.IsEmptyHint = true;
		spreadsheetCommandGalleryItem71.AlwaysUpdateDescription = true;
		spreadsheetCommandGalleryItem71.CaptionAsValue = true;
		spreadsheetCommandGalleryItem71.CommandName = "FormatNumberAccountingRegular";
		spreadsheetCommandGalleryItem71.IsEmptyHint = true;
		spreadsheetCommandGalleryItem72.AlwaysUpdateDescription = true;
		spreadsheetCommandGalleryItem72.CaptionAsValue = true;
		spreadsheetCommandGalleryItem72.CommandName = "FormatNumberShortDate";
		spreadsheetCommandGalleryItem72.IsEmptyHint = true;
		spreadsheetCommandGalleryItem73.AlwaysUpdateDescription = true;
		spreadsheetCommandGalleryItem73.CaptionAsValue = true;
		spreadsheetCommandGalleryItem73.CommandName = "FormatNumberLongDate";
		spreadsheetCommandGalleryItem73.IsEmptyHint = true;
		spreadsheetCommandGalleryItem74.AlwaysUpdateDescription = true;
		spreadsheetCommandGalleryItem74.CaptionAsValue = true;
		spreadsheetCommandGalleryItem74.CommandName = "FormatNumberTime";
		spreadsheetCommandGalleryItem74.IsEmptyHint = true;
		spreadsheetCommandGalleryItem75.AlwaysUpdateDescription = true;
		spreadsheetCommandGalleryItem75.CaptionAsValue = true;
		spreadsheetCommandGalleryItem75.CommandName = "FormatNumberPercentage";
		spreadsheetCommandGalleryItem75.IsEmptyHint = true;
		spreadsheetCommandGalleryItem76.AlwaysUpdateDescription = true;
		spreadsheetCommandGalleryItem76.CaptionAsValue = true;
		spreadsheetCommandGalleryItem76.CommandName = "FormatNumberFraction";
		spreadsheetCommandGalleryItem76.IsEmptyHint = true;
		spreadsheetCommandGalleryItem77.AlwaysUpdateDescription = true;
		spreadsheetCommandGalleryItem77.CaptionAsValue = true;
		spreadsheetCommandGalleryItem77.CommandName = "FormatNumberScientific";
		spreadsheetCommandGalleryItem77.IsEmptyHint = true;
		spreadsheetCommandGalleryItem78.AlwaysUpdateDescription = true;
		spreadsheetCommandGalleryItem78.CaptionAsValue = true;
		spreadsheetCommandGalleryItem78.CommandName = "FormatNumberText";
		spreadsheetCommandGalleryItem78.IsEmptyHint = true;
		galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[11]
		{
			spreadsheetCommandGalleryItem68, spreadsheetCommandGalleryItem69, spreadsheetCommandGalleryItem70, spreadsheetCommandGalleryItem71, spreadsheetCommandGalleryItem72, spreadsheetCommandGalleryItem73, spreadsheetCommandGalleryItem74, spreadsheetCommandGalleryItem75, spreadsheetCommandGalleryItem76, spreadsheetCommandGalleryItem77,
			spreadsheetCommandGalleryItem78
		});
		this.repositoryItemPopupGalleryEdit1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { galleryItemGroup1 });
		this.repositoryItemPopupGalleryEdit1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
		this.repositoryItemPopupGalleryEdit1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
		this.repositoryItemPopupGalleryEdit1.Gallery.RowCount = 11;
		this.repositoryItemPopupGalleryEdit1.Gallery.ShowGroupCaption = false;
		this.repositoryItemPopupGalleryEdit1.Gallery.ShowItemText = true;
		this.repositoryItemPopupGalleryEdit1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide;
		this.repositoryItemPopupGalleryEdit1.Gallery.StretchItems = true;
		this.repositoryItemPopupGalleryEdit1.Name = "repositoryItemPopupGalleryEdit1";
		this.repositoryItemPopupGalleryEdit1.ShowButtons = false;
		this.repositoryItemPopupGalleryEdit1.ShowPopupCloseButton = false;
		this.repositoryItemPopupGalleryEdit1.ShowSizeGrip = false;
		this.barButtonGroup9.Id = 68;
		this.barButtonGroup9.ItemLinks.Add(this.spreadsheetCommandBarSubItem6);
		this.barButtonGroup9.ItemLinks.Add(this.spreadsheetCommandBarButtonItem57);
		this.barButtonGroup9.ItemLinks.Add(this.spreadsheetCommandBarButtonItem58);
		this.barButtonGroup9.Name = "barButtonGroup9";
		this.barButtonGroup9.Tag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
		this.spreadsheetCommandBarSubItem6.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
		this.spreadsheetCommandBarSubItem6.CommandName = "FormatNumberAccountingCommandGroup";
		this.spreadsheetCommandBarSubItem6.Id = 115;
		this.spreadsheetCommandBarSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[6]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem51),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem52),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem53),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem54),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem55),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem56)
		});
		this.spreadsheetCommandBarSubItem6.Name = "spreadsheetCommandBarSubItem6";
		this.spreadsheetCommandBarSubItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.spreadsheetCommandBarButtonItem51.CommandName = "FormatNumberAccountingDefault";
		this.spreadsheetCommandBarButtonItem51.Id = 116;
		this.spreadsheetCommandBarButtonItem51.Name = "spreadsheetCommandBarButtonItem51";
		this.spreadsheetCommandBarButtonItem52.CommandName = "FormatNumberAccountingUS";
		this.spreadsheetCommandBarButtonItem52.Id = 117;
		this.spreadsheetCommandBarButtonItem52.Name = "spreadsheetCommandBarButtonItem52";
		this.spreadsheetCommandBarButtonItem53.CommandName = "FormatNumberAccountingUK";
		this.spreadsheetCommandBarButtonItem53.Id = 118;
		this.spreadsheetCommandBarButtonItem53.Name = "spreadsheetCommandBarButtonItem53";
		this.spreadsheetCommandBarButtonItem54.CommandName = "FormatNumberAccountingEuro";
		this.spreadsheetCommandBarButtonItem54.Id = 119;
		this.spreadsheetCommandBarButtonItem54.Name = "spreadsheetCommandBarButtonItem54";
		this.spreadsheetCommandBarButtonItem55.CommandName = "FormatNumberAccountingPRC";
		this.spreadsheetCommandBarButtonItem55.Id = 120;
		this.spreadsheetCommandBarButtonItem55.Name = "spreadsheetCommandBarButtonItem55";
		this.spreadsheetCommandBarButtonItem56.CommandName = "FormatNumberAccountingSwiss";
		this.spreadsheetCommandBarButtonItem56.Id = 121;
		this.spreadsheetCommandBarButtonItem56.Name = "spreadsheetCommandBarButtonItem56";
		this.spreadsheetCommandBarButtonItem57.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
		this.spreadsheetCommandBarButtonItem57.CommandName = "FormatNumberPercent";
		this.spreadsheetCommandBarButtonItem57.Id = 122;
		this.spreadsheetCommandBarButtonItem57.Name = "spreadsheetCommandBarButtonItem57";
		this.spreadsheetCommandBarButtonItem57.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.spreadsheetCommandBarButtonItem58.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
		this.spreadsheetCommandBarButtonItem58.CommandName = "FormatNumberAccounting";
		this.spreadsheetCommandBarButtonItem58.Id = 123;
		this.spreadsheetCommandBarButtonItem58.Name = "spreadsheetCommandBarButtonItem58";
		this.spreadsheetCommandBarButtonItem58.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.barButtonGroup10.Id = 69;
		this.barButtonGroup10.ItemLinks.Add(this.spreadsheetCommandBarButtonItem59);
		this.barButtonGroup10.ItemLinks.Add(this.spreadsheetCommandBarButtonItem60);
		this.barButtonGroup10.Name = "barButtonGroup10";
		this.barButtonGroup10.Tag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}";
		this.spreadsheetCommandBarButtonItem59.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}";
		this.spreadsheetCommandBarButtonItem59.CommandName = "FormatNumberIncreaseDecimal";
		this.spreadsheetCommandBarButtonItem59.Id = 124;
		this.spreadsheetCommandBarButtonItem59.Name = "spreadsheetCommandBarButtonItem59";
		this.spreadsheetCommandBarButtonItem59.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.spreadsheetCommandBarButtonItem60.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}";
		this.spreadsheetCommandBarButtonItem60.CommandName = "FormatNumberDecreaseDecimal";
		this.spreadsheetCommandBarButtonItem60.Id = 125;
		this.spreadsheetCommandBarButtonItem60.Name = "spreadsheetCommandBarButtonItem60";
		this.spreadsheetCommandBarButtonItem60.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
		this.spreadsheetCommandBarSubItem10.CommandName = "ConditionalFormattingCommandGroup";
		this.spreadsheetCommandBarSubItem10.Id = 126;
		this.spreadsheetCommandBarSubItem10.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[8]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarSubItem7),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarSubItem8),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem8),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem9),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem10),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem74),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarSubItem9),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem77)
		});
		this.spreadsheetCommandBarSubItem10.Name = "spreadsheetCommandBarSubItem10";
		this.spreadsheetCommandBarSubItem7.CommandName = "ConditionalFormattingHighlightCellsRuleCommandGroup";
		this.spreadsheetCommandBarSubItem7.Id = 134;
		this.spreadsheetCommandBarSubItem7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[7]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem61),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem62),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem63),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem64),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem65),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem66),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem67)
		});
		this.spreadsheetCommandBarSubItem7.Name = "spreadsheetCommandBarSubItem7";
		this.spreadsheetCommandBarButtonItem61.CommandName = "ConditionalFormattingGreaterThanRuleCommand";
		this.spreadsheetCommandBarButtonItem61.Id = 127;
		this.spreadsheetCommandBarButtonItem61.Name = "spreadsheetCommandBarButtonItem61";
		this.spreadsheetCommandBarButtonItem61.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem62.CommandName = "ConditionalFormattingLessThanRuleCommand";
		this.spreadsheetCommandBarButtonItem62.Id = 128;
		this.spreadsheetCommandBarButtonItem62.Name = "spreadsheetCommandBarButtonItem62";
		this.spreadsheetCommandBarButtonItem62.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem63.CommandName = "ConditionalFormattingBetweenRuleCommand";
		this.spreadsheetCommandBarButtonItem63.Id = 129;
		this.spreadsheetCommandBarButtonItem63.Name = "spreadsheetCommandBarButtonItem63";
		this.spreadsheetCommandBarButtonItem63.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem64.CommandName = "ConditionalFormattingEqualToRuleCommand";
		this.spreadsheetCommandBarButtonItem64.Id = 130;
		this.spreadsheetCommandBarButtonItem64.Name = "spreadsheetCommandBarButtonItem64";
		this.spreadsheetCommandBarButtonItem64.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem65.CommandName = "ConditionalFormattingTextContainsRuleCommand";
		this.spreadsheetCommandBarButtonItem65.Id = 131;
		this.spreadsheetCommandBarButtonItem65.Name = "spreadsheetCommandBarButtonItem65";
		this.spreadsheetCommandBarButtonItem65.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem66.CommandName = "ConditionalFormattingDateOccurringRuleCommand";
		this.spreadsheetCommandBarButtonItem66.Id = 132;
		this.spreadsheetCommandBarButtonItem66.Name = "spreadsheetCommandBarButtonItem66";
		this.spreadsheetCommandBarButtonItem66.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem67.CommandName = "ConditionalFormattingDuplicateValuesRuleCommand";
		this.spreadsheetCommandBarButtonItem67.Id = 133;
		this.spreadsheetCommandBarButtonItem67.Name = "spreadsheetCommandBarButtonItem67";
		this.spreadsheetCommandBarButtonItem67.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarSubItem8.CommandName = "ConditionalFormattingTopBottomRuleCommandGroup";
		this.spreadsheetCommandBarSubItem8.Id = 141;
		this.spreadsheetCommandBarSubItem8.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[6]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem68),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem69),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem70),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem71),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem72),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem73)
		});
		this.spreadsheetCommandBarSubItem8.Name = "spreadsheetCommandBarSubItem8";
		this.spreadsheetCommandBarButtonItem68.CommandName = "ConditionalFormattingTop10RuleCommand";
		this.spreadsheetCommandBarButtonItem68.Id = 135;
		this.spreadsheetCommandBarButtonItem68.Name = "spreadsheetCommandBarButtonItem68";
		this.spreadsheetCommandBarButtonItem68.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem69.CommandName = "ConditionalFormattingTop10PercentRuleCommand";
		this.spreadsheetCommandBarButtonItem69.Id = 136;
		this.spreadsheetCommandBarButtonItem69.Name = "spreadsheetCommandBarButtonItem69";
		this.spreadsheetCommandBarButtonItem69.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem70.CommandName = "ConditionalFormattingBottom10RuleCommand";
		this.spreadsheetCommandBarButtonItem70.Id = 137;
		this.spreadsheetCommandBarButtonItem70.Name = "spreadsheetCommandBarButtonItem70";
		this.spreadsheetCommandBarButtonItem70.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem71.CommandName = "ConditionalFormattingBottom10PercentRuleCommand";
		this.spreadsheetCommandBarButtonItem71.Id = 138;
		this.spreadsheetCommandBarButtonItem71.Name = "spreadsheetCommandBarButtonItem71";
		this.spreadsheetCommandBarButtonItem71.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem72.CommandName = "ConditionalFormattingAboveAverageRuleCommand";
		this.spreadsheetCommandBarButtonItem72.Id = 139;
		this.spreadsheetCommandBarButtonItem72.Name = "spreadsheetCommandBarButtonItem72";
		this.spreadsheetCommandBarButtonItem72.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem73.CommandName = "ConditionalFormattingBelowAverageRuleCommand";
		this.spreadsheetCommandBarButtonItem73.Id = 140;
		this.spreadsheetCommandBarButtonItem73.Name = "spreadsheetCommandBarButtonItem73";
		this.spreadsheetCommandBarButtonItem73.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonGalleryDropDownItem8.CommandName = "ConditionalFormattingDataBarsCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem8.DropDownControl = this.commandBarGalleryDropDown9;
		this.spreadsheetCommandBarButtonGalleryDropDownItem8.Id = 142;
		this.spreadsheetCommandBarButtonGalleryDropDownItem8.Name = "spreadsheetCommandBarButtonGalleryDropDownItem8";
		this.spreadsheetCommandBarButtonGalleryDropDownItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.commandBarGalleryDropDown9.Gallery.AllowFilter = false;
		spreadsheetCommandGalleryItemGroup22.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup";
		spreadsheetCommandGalleryItem79.CommandName = "ConditionalFormattingDataBarGradientBlue";
		spreadsheetCommandGalleryItem80.CommandName = "ConditionalFormattingDataBarGradientGreen";
		spreadsheetCommandGalleryItem81.CommandName = "ConditionalFormattingDataBarGradientRed";
		spreadsheetCommandGalleryItem82.CommandName = "ConditionalFormattingDataBarGradientOrange";
		spreadsheetCommandGalleryItem83.CommandName = "ConditionalFormattingDataBarGradientLightBlue";
		spreadsheetCommandGalleryItem84.CommandName = "ConditionalFormattingDataBarGradientPurple";
		spreadsheetCommandGalleryItemGroup22.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[6] { spreadsheetCommandGalleryItem79, spreadsheetCommandGalleryItem80, spreadsheetCommandGalleryItem81, spreadsheetCommandGalleryItem82, spreadsheetCommandGalleryItem83, spreadsheetCommandGalleryItem84 });
		spreadsheetCommandGalleryItemGroup23.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup";
		spreadsheetCommandGalleryItem85.CommandName = "ConditionalFormattingDataBarSolidBlue";
		spreadsheetCommandGalleryItem86.CommandName = "ConditionalFormattingDataBarSolidGreen";
		spreadsheetCommandGalleryItem87.CommandName = "ConditionalFormattingDataBarSolidRed";
		spreadsheetCommandGalleryItem88.CommandName = "ConditionalFormattingDataBarSolidOrange";
		spreadsheetCommandGalleryItem89.CommandName = "ConditionalFormattingDataBarSolidLightBlue";
		spreadsheetCommandGalleryItem90.CommandName = "ConditionalFormattingDataBarSolidPurple";
		spreadsheetCommandGalleryItemGroup23.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[6] { spreadsheetCommandGalleryItem85, spreadsheetCommandGalleryItem86, spreadsheetCommandGalleryItem87, spreadsheetCommandGalleryItem88, spreadsheetCommandGalleryItem89, spreadsheetCommandGalleryItem90 });
		this.commandBarGalleryDropDown9.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[2] { spreadsheetCommandGalleryItemGroup22, spreadsheetCommandGalleryItemGroup23 });
		this.commandBarGalleryDropDown9.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown9.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown9.Name = "commandBarGalleryDropDown9";
		this.commandBarGalleryDropDown9.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem9.CommandName = "ConditionalFormattingColorScalesCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem9.DropDownControl = this.commandBarGalleryDropDown10;
		this.spreadsheetCommandBarButtonGalleryDropDownItem9.Id = 143;
		this.spreadsheetCommandBarButtonGalleryDropDownItem9.Name = "spreadsheetCommandBarButtonGalleryDropDownItem9";
		this.spreadsheetCommandBarButtonGalleryDropDownItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.commandBarGalleryDropDown10.Gallery.AllowFilter = false;
		spreadsheetCommandGalleryItemGroup24.CommandName = "ConditionalFormattingColorScalesCommandGroup";
		spreadsheetCommandGalleryItem91.CommandName = "ConditionalFormattingColorScaleGreenYellowRed";
		spreadsheetCommandGalleryItem92.CommandName = "ConditionalFormattingColorScaleRedYellowGreen";
		spreadsheetCommandGalleryItem93.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed";
		spreadsheetCommandGalleryItem94.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen";
		spreadsheetCommandGalleryItem95.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed";
		spreadsheetCommandGalleryItem96.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue";
		spreadsheetCommandGalleryItem97.CommandName = "ConditionalFormattingColorScaleWhiteRed";
		spreadsheetCommandGalleryItem98.CommandName = "ConditionalFormattingColorScaleRedWhite";
		spreadsheetCommandGalleryItem99.CommandName = "ConditionalFormattingColorScaleGreenWhite";
		spreadsheetCommandGalleryItem100.CommandName = "ConditionalFormattingColorScaleWhiteGreen";
		spreadsheetCommandGalleryItem101.CommandName = "ConditionalFormattingColorScaleGreenYellow";
		spreadsheetCommandGalleryItem102.CommandName = "ConditionalFormattingColorScaleYellowGreen";
		spreadsheetCommandGalleryItemGroup24.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[12]
		{
			spreadsheetCommandGalleryItem91, spreadsheetCommandGalleryItem92, spreadsheetCommandGalleryItem93, spreadsheetCommandGalleryItem94, spreadsheetCommandGalleryItem95, spreadsheetCommandGalleryItem96, spreadsheetCommandGalleryItem97, spreadsheetCommandGalleryItem98, spreadsheetCommandGalleryItem99, spreadsheetCommandGalleryItem100,
			spreadsheetCommandGalleryItem101, spreadsheetCommandGalleryItem102
		});
		this.commandBarGalleryDropDown10.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { spreadsheetCommandGalleryItemGroup24 });
		this.commandBarGalleryDropDown10.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown10.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown10.Name = "commandBarGalleryDropDown10";
		this.commandBarGalleryDropDown10.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem10.CommandName = "ConditionalFormattingIconSetsCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem10.DropDownControl = this.commandBarGalleryDropDown11;
		this.spreadsheetCommandBarButtonGalleryDropDownItem10.Id = 144;
		this.spreadsheetCommandBarButtonGalleryDropDownItem10.Name = "spreadsheetCommandBarButtonGalleryDropDownItem10";
		this.spreadsheetCommandBarButtonGalleryDropDownItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.commandBarGalleryDropDown11.Gallery.AllowFilter = false;
		spreadsheetCommandGalleryItemGroup25.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup";
		spreadsheetCommandGalleryItem103.CommandName = "ConditionalFormattingIconSetArrows3Colored";
		spreadsheetCommandGalleryItem104.CommandName = "ConditionalFormattingIconSetArrows3Grayed";
		spreadsheetCommandGalleryItem105.CommandName = "ConditionalFormattingIconSetArrows4Colored";
		spreadsheetCommandGalleryItem106.CommandName = "ConditionalFormattingIconSetArrows4Grayed";
		spreadsheetCommandGalleryItem107.CommandName = "ConditionalFormattingIconSetArrows5Colored";
		spreadsheetCommandGalleryItem108.CommandName = "ConditionalFormattingIconSetArrows5Grayed";
		spreadsheetCommandGalleryItem109.CommandName = "ConditionalFormattingIconSetTriangles3";
		spreadsheetCommandGalleryItemGroup25.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[7] { spreadsheetCommandGalleryItem103, spreadsheetCommandGalleryItem104, spreadsheetCommandGalleryItem105, spreadsheetCommandGalleryItem106, spreadsheetCommandGalleryItem107, spreadsheetCommandGalleryItem108, spreadsheetCommandGalleryItem109 });
		spreadsheetCommandGalleryItemGroup26.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup";
		spreadsheetCommandGalleryItem110.CommandName = "ConditionalFormattingIconSetTrafficLights3";
		spreadsheetCommandGalleryItem111.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed";
		spreadsheetCommandGalleryItem112.CommandName = "ConditionalFormattingIconSetTrafficLights4";
		spreadsheetCommandGalleryItem113.CommandName = "ConditionalFormattingIconSetSigns3";
		spreadsheetCommandGalleryItem114.CommandName = "ConditionalFormattingIconSetRedToBlack";
		spreadsheetCommandGalleryItemGroup26.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[5] { spreadsheetCommandGalleryItem110, spreadsheetCommandGalleryItem111, spreadsheetCommandGalleryItem112, spreadsheetCommandGalleryItem113, spreadsheetCommandGalleryItem114 });
		spreadsheetCommandGalleryItemGroup27.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup";
		spreadsheetCommandGalleryItem115.CommandName = "ConditionalFormattingIconSetSymbols3Circled";
		spreadsheetCommandGalleryItem116.CommandName = "ConditionalFormattingIconSetSymbols3";
		spreadsheetCommandGalleryItem117.CommandName = "ConditionalFormattingIconSetFlags3";
		spreadsheetCommandGalleryItemGroup27.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[3] { spreadsheetCommandGalleryItem115, spreadsheetCommandGalleryItem116, spreadsheetCommandGalleryItem117 });
		spreadsheetCommandGalleryItemGroup28.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup";
		spreadsheetCommandGalleryItem118.CommandName = "ConditionalFormattingIconSetStars3";
		spreadsheetCommandGalleryItem119.CommandName = "ConditionalFormattingIconSetRatings4";
		spreadsheetCommandGalleryItem120.CommandName = "ConditionalFormattingIconSetRatings5";
		spreadsheetCommandGalleryItem121.CommandName = "ConditionalFormattingIconSetQuarters5";
		spreadsheetCommandGalleryItem122.CommandName = "ConditionalFormattingIconSetBoxes5";
		spreadsheetCommandGalleryItemGroup28.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[5] { spreadsheetCommandGalleryItem118, spreadsheetCommandGalleryItem119, spreadsheetCommandGalleryItem120, spreadsheetCommandGalleryItem121, spreadsheetCommandGalleryItem122 });
		this.commandBarGalleryDropDown11.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[4] { spreadsheetCommandGalleryItemGroup25, spreadsheetCommandGalleryItemGroup26, spreadsheetCommandGalleryItemGroup27, spreadsheetCommandGalleryItemGroup28 });
		this.commandBarGalleryDropDown11.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown11.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown11.Name = "commandBarGalleryDropDown11";
		this.commandBarGalleryDropDown11.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonItem74.CommandName = "NewConditionalFormattingRule";
		this.spreadsheetCommandBarButtonItem74.Id = 145;
		this.spreadsheetCommandBarButtonItem74.Name = "spreadsheetCommandBarButtonItem74";
		this.spreadsheetCommandBarSubItem9.CommandName = "ConditionalFormattingRemoveCommandGroup";
		this.spreadsheetCommandBarSubItem9.Id = 148;
		this.spreadsheetCommandBarSubItem9.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem75),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem76)
		});
		this.spreadsheetCommandBarSubItem9.Name = "spreadsheetCommandBarSubItem9";
		this.spreadsheetCommandBarButtonItem75.CommandName = "ConditionalFormattingRemoveFromSheet";
		this.spreadsheetCommandBarButtonItem75.Id = 146;
		this.spreadsheetCommandBarButtonItem75.Name = "spreadsheetCommandBarButtonItem75";
		this.spreadsheetCommandBarButtonItem76.CommandName = "ConditionalFormattingRemove";
		this.spreadsheetCommandBarButtonItem76.Id = 147;
		this.spreadsheetCommandBarButtonItem76.Name = "spreadsheetCommandBarButtonItem76";
		this.spreadsheetCommandBarButtonItem77.CommandName = "ConditionalFormattingRulesManager";
		this.spreadsheetCommandBarButtonItem77.Id = 149;
		this.spreadsheetCommandBarButtonItem77.Name = "spreadsheetCommandBarButtonItem77";
		this.galleryFormatAsTableItem1.DropDownControl = this.commandBarGalleryDropDown12;
		this.galleryFormatAsTableItem1.Id = 150;
		this.galleryFormatAsTableItem1.Name = "galleryFormatAsTableItem1";
		this.commandBarGalleryDropDown12.Gallery.AllowFilter = false;
		this.commandBarGalleryDropDown12.Gallery.ColumnCount = 7;
		this.commandBarGalleryDropDown12.Gallery.DrawImageBackground = false;
		this.commandBarGalleryDropDown12.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
		this.commandBarGalleryDropDown12.Gallery.ItemSize = new System.Drawing.Size(73, 58);
		this.commandBarGalleryDropDown12.Gallery.RowCount = 10;
		this.commandBarGalleryDropDown12.Name = "commandBarGalleryDropDown12";
		this.commandBarGalleryDropDown12.Ribbon = this.ribbonControl1;
		this.galleryChangeStyleItem1.Gallery.DrawImageBackground = false;
		this.galleryChangeStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
		this.galleryChangeStyleItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
		this.galleryChangeStyleItem1.Gallery.ItemSize = new System.Drawing.Size(106, 28);
		this.galleryChangeStyleItem1.Gallery.RowCount = 9;
		this.galleryChangeStyleItem1.Gallery.ShowItemText = true;
		this.galleryChangeStyleItem1.Id = 151;
		this.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1";
		this.spreadsheetCommandBarSubItem11.CommandName = "InsertCellsCommandGroup";
		this.spreadsheetCommandBarSubItem11.Id = 152;
		this.spreadsheetCommandBarSubItem11.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[8]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem78),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem79),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem80),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem81),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem82),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem83),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem84),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem85)
		});
		this.spreadsheetCommandBarSubItem11.Name = "spreadsheetCommandBarSubItem11";
		this.spreadsheetCommandBarButtonItem78.CommandName = "InsertCells";
		this.spreadsheetCommandBarButtonItem78.Id = 153;
		this.spreadsheetCommandBarButtonItem78.Name = "spreadsheetCommandBarButtonItem78";
		this.spreadsheetCommandBarButtonItem79.CommandName = "InsertSheetRows";
		this.spreadsheetCommandBarButtonItem79.Id = 154;
		this.spreadsheetCommandBarButtonItem79.Name = "spreadsheetCommandBarButtonItem79";
		this.spreadsheetCommandBarButtonItem80.CommandName = "InsertSheetColumns";
		this.spreadsheetCommandBarButtonItem80.Id = 155;
		this.spreadsheetCommandBarButtonItem80.Name = "spreadsheetCommandBarButtonItem80";
		this.spreadsheetCommandBarButtonItem81.CommandName = "InsertTableRowsAbove";
		this.spreadsheetCommandBarButtonItem81.Id = 156;
		this.spreadsheetCommandBarButtonItem81.Name = "spreadsheetCommandBarButtonItem81";
		this.spreadsheetCommandBarButtonItem82.CommandName = "InsertTableRowBelow";
		this.spreadsheetCommandBarButtonItem82.Id = 157;
		this.spreadsheetCommandBarButtonItem82.Name = "spreadsheetCommandBarButtonItem82";
		this.spreadsheetCommandBarButtonItem83.CommandName = "InsertTableColumnsToTheLeft";
		this.spreadsheetCommandBarButtonItem83.Id = 158;
		this.spreadsheetCommandBarButtonItem83.Name = "spreadsheetCommandBarButtonItem83";
		this.spreadsheetCommandBarButtonItem84.CommandName = "InsertTableColumnToTheRight";
		this.spreadsheetCommandBarButtonItem84.Id = 159;
		this.spreadsheetCommandBarButtonItem84.Name = "spreadsheetCommandBarButtonItem84";
		this.spreadsheetCommandBarButtonItem85.CommandName = "InsertSheet";
		this.spreadsheetCommandBarButtonItem85.Id = 160;
		this.spreadsheetCommandBarButtonItem85.Name = "spreadsheetCommandBarButtonItem85";
		this.spreadsheetCommandBarSubItem12.CommandName = "RemoveCellsCommandGroup";
		this.spreadsheetCommandBarSubItem12.Id = 161;
		this.spreadsheetCommandBarSubItem12.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[6]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem86),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem87),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem88),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem89),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem90),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem91)
		});
		this.spreadsheetCommandBarSubItem12.Name = "spreadsheetCommandBarSubItem12";
		this.spreadsheetCommandBarButtonItem86.CommandName = "RemoveCells";
		this.spreadsheetCommandBarButtonItem86.Id = 162;
		this.spreadsheetCommandBarButtonItem86.Name = "spreadsheetCommandBarButtonItem86";
		this.spreadsheetCommandBarButtonItem87.CommandName = "RemoveSheetRows";
		this.spreadsheetCommandBarButtonItem87.Id = 163;
		this.spreadsheetCommandBarButtonItem87.Name = "spreadsheetCommandBarButtonItem87";
		this.spreadsheetCommandBarButtonItem88.CommandName = "RemoveSheetColumns";
		this.spreadsheetCommandBarButtonItem88.Id = 164;
		this.spreadsheetCommandBarButtonItem88.Name = "spreadsheetCommandBarButtonItem88";
		this.spreadsheetCommandBarButtonItem89.CommandName = "RemoveTableRows";
		this.spreadsheetCommandBarButtonItem89.Id = 165;
		this.spreadsheetCommandBarButtonItem89.Name = "spreadsheetCommandBarButtonItem89";
		this.spreadsheetCommandBarButtonItem90.CommandName = "RemoveTableColumns";
		this.spreadsheetCommandBarButtonItem90.Id = 166;
		this.spreadsheetCommandBarButtonItem90.Name = "spreadsheetCommandBarButtonItem90";
		this.spreadsheetCommandBarButtonItem91.CommandName = "RemoveSheet";
		this.spreadsheetCommandBarButtonItem91.Id = 167;
		this.spreadsheetCommandBarButtonItem91.Name = "spreadsheetCommandBarButtonItem91";
		this.spreadsheetCommandBarSubItem14.CommandName = "FormatCommandGroup";
		this.spreadsheetCommandBarSubItem14.Id = 168;
		this.spreadsheetCommandBarSubItem14.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[12]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem92),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem93),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem94),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem95),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem96),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarSubItem13),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem103),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem104),
			new DevExpress.XtraBars.LinkPersistInfo(this.changeSheetTabColorItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem105),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem16),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem106)
		});
		this.spreadsheetCommandBarSubItem14.Name = "spreadsheetCommandBarSubItem14";
		this.spreadsheetCommandBarButtonItem92.CommandName = "FormatRowHeight";
		this.spreadsheetCommandBarButtonItem92.Id = 169;
		this.spreadsheetCommandBarButtonItem92.Name = "spreadsheetCommandBarButtonItem92";
		this.spreadsheetCommandBarButtonItem93.CommandName = "FormatAutoFitRowHeight";
		this.spreadsheetCommandBarButtonItem93.Id = 170;
		this.spreadsheetCommandBarButtonItem93.Name = "spreadsheetCommandBarButtonItem93";
		this.spreadsheetCommandBarButtonItem94.CommandName = "FormatColumnWidth";
		this.spreadsheetCommandBarButtonItem94.Id = 171;
		this.spreadsheetCommandBarButtonItem94.Name = "spreadsheetCommandBarButtonItem94";
		this.spreadsheetCommandBarButtonItem95.CommandName = "FormatAutoFitColumnWidth";
		this.spreadsheetCommandBarButtonItem95.Id = 172;
		this.spreadsheetCommandBarButtonItem95.Name = "spreadsheetCommandBarButtonItem95";
		this.spreadsheetCommandBarButtonItem96.CommandName = "FormatDefaultColumnWidth";
		this.spreadsheetCommandBarButtonItem96.Id = 173;
		this.spreadsheetCommandBarButtonItem96.Name = "spreadsheetCommandBarButtonItem96";
		this.spreadsheetCommandBarSubItem13.CommandName = "HideAndUnhideCommandGroup";
		this.spreadsheetCommandBarSubItem13.Id = 180;
		this.spreadsheetCommandBarSubItem13.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[6]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem97),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem98),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem99),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem100),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem101),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem102)
		});
		this.spreadsheetCommandBarSubItem13.Name = "spreadsheetCommandBarSubItem13";
		this.spreadsheetCommandBarButtonItem97.CommandName = "HideRows";
		this.spreadsheetCommandBarButtonItem97.Id = 174;
		this.spreadsheetCommandBarButtonItem97.Name = "spreadsheetCommandBarButtonItem97";
		this.spreadsheetCommandBarButtonItem98.CommandName = "HideColumns";
		this.spreadsheetCommandBarButtonItem98.Id = 175;
		this.spreadsheetCommandBarButtonItem98.Name = "spreadsheetCommandBarButtonItem98";
		this.spreadsheetCommandBarButtonItem99.CommandName = "HideSheet";
		this.spreadsheetCommandBarButtonItem99.Id = 176;
		this.spreadsheetCommandBarButtonItem99.Name = "spreadsheetCommandBarButtonItem99";
		this.spreadsheetCommandBarButtonItem100.CommandName = "UnhideRows";
		this.spreadsheetCommandBarButtonItem100.Id = 177;
		this.spreadsheetCommandBarButtonItem100.Name = "spreadsheetCommandBarButtonItem100";
		this.spreadsheetCommandBarButtonItem101.CommandName = "UnhideColumns";
		this.spreadsheetCommandBarButtonItem101.Id = 178;
		this.spreadsheetCommandBarButtonItem101.Name = "spreadsheetCommandBarButtonItem101";
		this.spreadsheetCommandBarButtonItem102.CommandName = "UnhideSheet";
		this.spreadsheetCommandBarButtonItem102.Id = 179;
		this.spreadsheetCommandBarButtonItem102.Name = "spreadsheetCommandBarButtonItem102";
		this.spreadsheetCommandBarButtonItem103.CommandName = "RenameSheet";
		this.spreadsheetCommandBarButtonItem103.Id = 181;
		this.spreadsheetCommandBarButtonItem103.Name = "spreadsheetCommandBarButtonItem103";
		this.spreadsheetCommandBarButtonItem104.CommandName = "MoveOrCopySheet";
		this.spreadsheetCommandBarButtonItem104.Id = 182;
		this.spreadsheetCommandBarButtonItem104.Name = "spreadsheetCommandBarButtonItem104";
		this.changeSheetTabColorItem1.ActAsDropDown = true;
		this.changeSheetTabColorItem1.Id = 183;
		this.changeSheetTabColorItem1.Name = "changeSheetTabColorItem1";
		this.spreadsheetCommandBarButtonItem105.CommandName = "ReviewProtectSheet";
		this.spreadsheetCommandBarButtonItem105.Id = 184;
		this.spreadsheetCommandBarButtonItem105.Name = "spreadsheetCommandBarButtonItem105";
		this.spreadsheetCommandBarCheckItem16.CommandName = "FormatCellLocked";
		this.spreadsheetCommandBarCheckItem16.Id = 185;
		this.spreadsheetCommandBarCheckItem16.Name = "spreadsheetCommandBarCheckItem16";
		this.spreadsheetCommandBarButtonItem106.CommandName = "FormatCellsContextMenuItem";
		this.spreadsheetCommandBarButtonItem106.Id = 186;
		this.spreadsheetCommandBarButtonItem106.Name = "spreadsheetCommandBarButtonItem106";
		this.spreadsheetCommandBarSubItem15.CommandName = "EditingAutoSumCommandGroup";
		this.spreadsheetCommandBarSubItem15.Id = 187;
		this.spreadsheetCommandBarSubItem15.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[5]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem12),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem13),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem14),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem15),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem16)
		});
		this.spreadsheetCommandBarSubItem15.Name = "spreadsheetCommandBarSubItem15";
		this.spreadsheetCommandBarSubItem15.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarSubItem16.CommandName = "EditingFillCommandGroup";
		this.spreadsheetCommandBarSubItem16.Id = 188;
		this.spreadsheetCommandBarSubItem16.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[4]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem107),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem108),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem109),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem110)
		});
		this.spreadsheetCommandBarSubItem16.Name = "spreadsheetCommandBarSubItem16";
		this.spreadsheetCommandBarSubItem16.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarButtonItem107.CommandName = "EditingFillDown";
		this.spreadsheetCommandBarButtonItem107.Id = 189;
		this.spreadsheetCommandBarButtonItem107.Name = "spreadsheetCommandBarButtonItem107";
		this.spreadsheetCommandBarButtonItem108.CommandName = "EditingFillRight";
		this.spreadsheetCommandBarButtonItem108.Id = 190;
		this.spreadsheetCommandBarButtonItem108.Name = "spreadsheetCommandBarButtonItem108";
		this.spreadsheetCommandBarButtonItem109.CommandName = "EditingFillUp";
		this.spreadsheetCommandBarButtonItem109.Id = 191;
		this.spreadsheetCommandBarButtonItem109.Name = "spreadsheetCommandBarButtonItem109";
		this.spreadsheetCommandBarButtonItem110.CommandName = "EditingFillLeft";
		this.spreadsheetCommandBarButtonItem110.Id = 192;
		this.spreadsheetCommandBarButtonItem110.Name = "spreadsheetCommandBarButtonItem110";
		this.spreadsheetCommandBarSubItem17.CommandName = "FormatClearCommandGroup";
		this.spreadsheetCommandBarSubItem17.Id = 193;
		this.spreadsheetCommandBarSubItem17.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[6]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem111),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem112),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem113),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem114),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem115),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem116)
		});
		this.spreadsheetCommandBarSubItem17.Name = "spreadsheetCommandBarSubItem17";
		this.spreadsheetCommandBarSubItem17.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarButtonItem111.CommandName = "FormatClearAll";
		this.spreadsheetCommandBarButtonItem111.Id = 194;
		this.spreadsheetCommandBarButtonItem111.Name = "spreadsheetCommandBarButtonItem111";
		this.spreadsheetCommandBarButtonItem112.CommandName = "FormatClearFormats";
		this.spreadsheetCommandBarButtonItem112.Id = 195;
		this.spreadsheetCommandBarButtonItem112.Name = "spreadsheetCommandBarButtonItem112";
		this.spreadsheetCommandBarButtonItem113.CommandName = "FormatClearContents";
		this.spreadsheetCommandBarButtonItem113.Id = 196;
		this.spreadsheetCommandBarButtonItem113.Name = "spreadsheetCommandBarButtonItem113";
		this.spreadsheetCommandBarButtonItem114.CommandName = "FormatClearComments";
		this.spreadsheetCommandBarButtonItem114.Id = 197;
		this.spreadsheetCommandBarButtonItem114.Name = "spreadsheetCommandBarButtonItem114";
		this.spreadsheetCommandBarButtonItem115.CommandName = "FormatClearHyperlinks";
		this.spreadsheetCommandBarButtonItem115.Id = 198;
		this.spreadsheetCommandBarButtonItem115.Name = "spreadsheetCommandBarButtonItem115";
		this.spreadsheetCommandBarButtonItem116.CommandName = "FormatRemoveHyperlinks";
		this.spreadsheetCommandBarButtonItem116.Id = 199;
		this.spreadsheetCommandBarButtonItem116.Name = "spreadsheetCommandBarButtonItem116";
		this.spreadsheetCommandBarSubItem18.CommandName = "EditingSortAndFilterCommandGroup";
		this.spreadsheetCommandBarSubItem18.Id = 200;
		this.spreadsheetCommandBarSubItem18.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[5]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem117),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem118),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem17),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem119),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem120)
		});
		this.spreadsheetCommandBarSubItem18.Name = "spreadsheetCommandBarSubItem18";
		this.spreadsheetCommandBarButtonItem117.CommandName = "DataSortAscending";
		this.spreadsheetCommandBarButtonItem117.Id = 201;
		this.spreadsheetCommandBarButtonItem117.Name = "spreadsheetCommandBarButtonItem117";
		this.spreadsheetCommandBarButtonItem118.CommandName = "DataSortDescending";
		this.spreadsheetCommandBarButtonItem118.Id = 202;
		this.spreadsheetCommandBarButtonItem118.Name = "spreadsheetCommandBarButtonItem118";
		this.spreadsheetCommandBarCheckItem17.CommandName = "DataFilterToggle";
		this.spreadsheetCommandBarCheckItem17.Id = 203;
		this.spreadsheetCommandBarCheckItem17.Name = "spreadsheetCommandBarCheckItem17";
		this.spreadsheetCommandBarButtonItem119.CommandName = "DataFilterClear";
		this.spreadsheetCommandBarButtonItem119.Id = 204;
		this.spreadsheetCommandBarButtonItem119.Name = "spreadsheetCommandBarButtonItem119";
		this.spreadsheetCommandBarButtonItem120.CommandName = "DataFilterReApply";
		this.spreadsheetCommandBarButtonItem120.Id = 205;
		this.spreadsheetCommandBarButtonItem120.Name = "spreadsheetCommandBarButtonItem120";
		this.spreadsheetCommandBarSubItem19.CommandName = "EditingFindAndSelectCommandGroup";
		this.spreadsheetCommandBarSubItem19.Id = 206;
		this.spreadsheetCommandBarSubItem19.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[7]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem121),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem122),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem123),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem124),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem125),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem126),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem127)
		});
		this.spreadsheetCommandBarSubItem19.Name = "spreadsheetCommandBarSubItem19";
		this.spreadsheetCommandBarButtonItem121.CommandName = "EditingFind";
		this.spreadsheetCommandBarButtonItem121.Id = 207;
		this.spreadsheetCommandBarButtonItem121.Name = "spreadsheetCommandBarButtonItem121";
		this.spreadsheetCommandBarButtonItem122.CommandName = "EditingReplace";
		this.spreadsheetCommandBarButtonItem122.Id = 208;
		this.spreadsheetCommandBarButtonItem122.Name = "spreadsheetCommandBarButtonItem122";
		this.spreadsheetCommandBarButtonItem123.CommandName = "EditingSelectFormulas";
		this.spreadsheetCommandBarButtonItem123.Id = 209;
		this.spreadsheetCommandBarButtonItem123.Name = "spreadsheetCommandBarButtonItem123";
		this.spreadsheetCommandBarButtonItem124.CommandName = "EditingSelectComments";
		this.spreadsheetCommandBarButtonItem124.Id = 210;
		this.spreadsheetCommandBarButtonItem124.Name = "spreadsheetCommandBarButtonItem124";
		this.spreadsheetCommandBarButtonItem125.CommandName = "EditingSelectConditionalFormatting";
		this.spreadsheetCommandBarButtonItem125.Id = 211;
		this.spreadsheetCommandBarButtonItem125.Name = "spreadsheetCommandBarButtonItem125";
		this.spreadsheetCommandBarButtonItem126.CommandName = "EditingSelectConstants";
		this.spreadsheetCommandBarButtonItem126.Id = 212;
		this.spreadsheetCommandBarButtonItem126.Name = "spreadsheetCommandBarButtonItem126";
		this.spreadsheetCommandBarButtonItem127.CommandName = "EditingSelectDataValidation";
		this.spreadsheetCommandBarButtonItem127.Id = 213;
		this.spreadsheetCommandBarButtonItem127.Name = "spreadsheetCommandBarButtonItem127";
		this.barButtonItem1.Caption = "PDF";
		this.barButtonItem1.Id = 214;
		this.barButtonItem1.ImageOptions.Image = compta.Properties.Resources.exporttopdf_16x16;
		this.barButtonItem1.ImageOptions.LargeImage = compta.Properties.Resources.exporttopdf_32x32;
		this.barButtonItem1.Name = "barButtonItem1";
		this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barButtonItem1_ItemClick);
		this.spreadsheetCommandBarCheckItem18.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
		this.spreadsheetCommandBarCheckItem18.CommandName = "ViewShowGridlines";
		this.spreadsheetCommandBarCheckItem18.Id = 215;
		this.spreadsheetCommandBarCheckItem18.Name = "spreadsheetCommandBarCheckItem18";
		this.spreadsheetCommandBarCheckItem19.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
		this.spreadsheetCommandBarCheckItem19.CommandName = "ViewShowHeadings";
		this.spreadsheetCommandBarCheckItem19.Id = 216;
		this.spreadsheetCommandBarCheckItem19.Name = "spreadsheetCommandBarCheckItem19";
		this.spreadsheetCommandBarButtonItem128.CommandName = "ViewZoom";
		this.spreadsheetCommandBarButtonItem128.Id = 217;
		this.spreadsheetCommandBarButtonItem128.Name = "spreadsheetCommandBarButtonItem128";
		this.spreadsheetCommandBarButtonItem129.CommandName = "ViewZoomOut";
		this.spreadsheetCommandBarButtonItem129.Id = 218;
		this.spreadsheetCommandBarButtonItem129.Name = "spreadsheetCommandBarButtonItem129";
		this.spreadsheetCommandBarButtonItem130.CommandName = "ViewZoomIn";
		this.spreadsheetCommandBarButtonItem130.Id = 219;
		this.spreadsheetCommandBarButtonItem130.Name = "spreadsheetCommandBarButtonItem130";
		this.spreadsheetCommandBarButtonItem131.CommandName = "ViewZoom100Percent";
		this.spreadsheetCommandBarButtonItem131.Id = 220;
		this.spreadsheetCommandBarButtonItem131.Name = "spreadsheetCommandBarButtonItem131";
		this.spreadsheetCommandBarSubItem20.CommandName = "ViewFreezePanesCommandGroup";
		this.spreadsheetCommandBarSubItem20.Id = 221;
		this.spreadsheetCommandBarSubItem20.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[4]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem132),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem133),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem134),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem135)
		});
		this.spreadsheetCommandBarSubItem20.Name = "spreadsheetCommandBarSubItem20";
		this.spreadsheetCommandBarButtonItem132.CommandName = "ViewFreezePanes";
		this.spreadsheetCommandBarButtonItem132.Id = 222;
		this.spreadsheetCommandBarButtonItem132.Name = "spreadsheetCommandBarButtonItem132";
		this.spreadsheetCommandBarButtonItem133.CommandName = "ViewUnfreezePanes";
		this.spreadsheetCommandBarButtonItem133.Id = 223;
		this.spreadsheetCommandBarButtonItem133.Name = "spreadsheetCommandBarButtonItem133";
		this.spreadsheetCommandBarButtonItem134.CommandName = "ViewFreezeTopRow";
		this.spreadsheetCommandBarButtonItem134.Id = 224;
		this.spreadsheetCommandBarButtonItem134.Name = "spreadsheetCommandBarButtonItem134";
		this.spreadsheetCommandBarButtonItem135.CommandName = "ViewFreezeFirstColumn";
		this.spreadsheetCommandBarButtonItem135.Id = 225;
		this.spreadsheetCommandBarButtonItem135.Name = "spreadsheetCommandBarButtonItem135";
		this.spreadsheetCommandBarButtonItem136.CommandName = "ReviewInsertComment";
		this.spreadsheetCommandBarButtonItem136.Id = 226;
		this.spreadsheetCommandBarButtonItem136.Name = "spreadsheetCommandBarButtonItem136";
		this.spreadsheetCommandBarButtonItem137.CommandName = "ReviewEditComment";
		this.spreadsheetCommandBarButtonItem137.Id = 227;
		this.spreadsheetCommandBarButtonItem137.Name = "spreadsheetCommandBarButtonItem137";
		this.spreadsheetCommandBarButtonItem138.CommandName = "ReviewDeleteComment";
		this.spreadsheetCommandBarButtonItem138.Id = 228;
		this.spreadsheetCommandBarButtonItem138.Name = "spreadsheetCommandBarButtonItem138";
		this.spreadsheetCommandBarButtonItem139.CommandName = "ReviewShowHideComment";
		this.spreadsheetCommandBarButtonItem139.Id = 229;
		this.spreadsheetCommandBarButtonItem139.Name = "spreadsheetCommandBarButtonItem139";
		this.spreadsheetCommandBarButtonItem139.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarButtonItem140.CommandName = "ReviewUnprotectSheet";
		this.spreadsheetCommandBarButtonItem140.Id = 230;
		this.spreadsheetCommandBarButtonItem140.Name = "spreadsheetCommandBarButtonItem140";
		this.spreadsheetCommandBarButtonItem141.CommandName = "ReviewProtectWorkbook";
		this.spreadsheetCommandBarButtonItem141.Id = 231;
		this.spreadsheetCommandBarButtonItem141.Name = "spreadsheetCommandBarButtonItem141";
		this.spreadsheetCommandBarButtonItem142.CommandName = "ReviewUnprotectWorkbook";
		this.spreadsheetCommandBarButtonItem142.Id = 232;
		this.spreadsheetCommandBarButtonItem142.Name = "spreadsheetCommandBarButtonItem142";
		this.spreadsheetCommandBarButtonItem143.CommandName = "ReviewShowProtectedRangeManager";
		this.spreadsheetCommandBarButtonItem143.Id = 233;
		this.spreadsheetCommandBarButtonItem143.Name = "spreadsheetCommandBarButtonItem143";
		this.spreadsheetCommandBarSubItem21.CommandName = "PageSetupMarginsCommandGroup";
		this.spreadsheetCommandBarSubItem21.Id = 234;
		this.spreadsheetCommandBarSubItem21.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[4]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem20),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem21),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem22),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem144)
		});
		this.spreadsheetCommandBarSubItem21.Name = "spreadsheetCommandBarSubItem21";
		this.spreadsheetCommandBarCheckItem20.CaptionDependOnUnits = true;
		this.spreadsheetCommandBarCheckItem20.CommandName = "PageSetupMarginsNormal";
		this.spreadsheetCommandBarCheckItem20.Id = 235;
		this.spreadsheetCommandBarCheckItem20.Name = "spreadsheetCommandBarCheckItem20";
		this.spreadsheetCommandBarCheckItem21.CaptionDependOnUnits = true;
		this.spreadsheetCommandBarCheckItem21.CommandName = "PageSetupMarginsWide";
		this.spreadsheetCommandBarCheckItem21.Id = 236;
		this.spreadsheetCommandBarCheckItem21.Name = "spreadsheetCommandBarCheckItem21";
		this.spreadsheetCommandBarCheckItem22.CaptionDependOnUnits = true;
		this.spreadsheetCommandBarCheckItem22.CommandName = "PageSetupMarginsNarrow";
		this.spreadsheetCommandBarCheckItem22.Id = 237;
		this.spreadsheetCommandBarCheckItem22.Name = "spreadsheetCommandBarCheckItem22";
		this.spreadsheetCommandBarButtonItem144.CommandName = "PageSetupCustomMargins";
		this.spreadsheetCommandBarButtonItem144.Id = 238;
		this.spreadsheetCommandBarButtonItem144.Name = "spreadsheetCommandBarButtonItem144";
		this.spreadsheetCommandBarSubItem22.CommandName = "PageSetupOrientationCommandGroup";
		this.spreadsheetCommandBarSubItem22.Id = 239;
		this.spreadsheetCommandBarSubItem22.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem23),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem24)
		});
		this.spreadsheetCommandBarSubItem22.Name = "spreadsheetCommandBarSubItem22";
		this.spreadsheetCommandBarCheckItem23.CommandName = "PageSetupOrientationPortrait";
		this.spreadsheetCommandBarCheckItem23.Id = 240;
		this.spreadsheetCommandBarCheckItem23.Name = "spreadsheetCommandBarCheckItem23";
		this.spreadsheetCommandBarCheckItem24.CommandName = "PageSetupOrientationLandscape";
		this.spreadsheetCommandBarCheckItem24.Id = 241;
		this.spreadsheetCommandBarCheckItem24.Name = "spreadsheetCommandBarCheckItem24";
		this.pageSetupPaperKindItem1.Id = 242;
		this.pageSetupPaperKindItem1.Name = "pageSetupPaperKindItem1";
		this.spreadsheetCommandBarSubItem23.CommandName = "PageSetupPrintAreaCommandGroup";
		this.spreadsheetCommandBarSubItem23.Id = 243;
		this.spreadsheetCommandBarSubItem23.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[3]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem145),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem146),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem147)
		});
		this.spreadsheetCommandBarSubItem23.Name = "spreadsheetCommandBarSubItem23";
		this.spreadsheetCommandBarButtonItem145.CommandName = "PageSetupSetPrintArea";
		this.spreadsheetCommandBarButtonItem145.Id = 244;
		this.spreadsheetCommandBarButtonItem145.Name = "spreadsheetCommandBarButtonItem145";
		this.spreadsheetCommandBarButtonItem146.CommandName = "PageSetupClearPrintArea";
		this.spreadsheetCommandBarButtonItem146.Id = 245;
		this.spreadsheetCommandBarButtonItem146.Name = "spreadsheetCommandBarButtonItem146";
		this.spreadsheetCommandBarButtonItem147.CommandName = "PageSetupAddPrintArea";
		this.spreadsheetCommandBarButtonItem147.Id = 246;
		this.spreadsheetCommandBarButtonItem147.Name = "spreadsheetCommandBarButtonItem147";
		this.spreadsheetCommandBarButtonItem148.CommandName = "PageSetupPrintTitles";
		this.spreadsheetCommandBarButtonItem148.Id = 247;
		this.spreadsheetCommandBarButtonItem148.Name = "spreadsheetCommandBarButtonItem148";
		this.spreadsheetCommandBarCheckItem25.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
		this.spreadsheetCommandBarCheckItem25.CommandName = "PageSetupPrintGridlines";
		this.spreadsheetCommandBarCheckItem25.Id = 248;
		this.spreadsheetCommandBarCheckItem25.Name = "spreadsheetCommandBarCheckItem25";
		this.spreadsheetCommandBarCheckItem26.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
		this.spreadsheetCommandBarCheckItem26.CommandName = "PageSetupPrintHeadings";
		this.spreadsheetCommandBarCheckItem26.Id = 249;
		this.spreadsheetCommandBarCheckItem26.Name = "spreadsheetCommandBarCheckItem26";
		this.spreadsheetCommandBarSubItem24.CommandName = "ArrangeBringForwardCommandGroup";
		this.spreadsheetCommandBarSubItem24.Id = 250;
		this.spreadsheetCommandBarSubItem24.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem149),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem150)
		});
		this.spreadsheetCommandBarSubItem24.Name = "spreadsheetCommandBarSubItem24";
		this.spreadsheetCommandBarButtonItem149.CommandName = "ArrangeBringForward";
		this.spreadsheetCommandBarButtonItem149.Id = 251;
		this.spreadsheetCommandBarButtonItem149.Name = "spreadsheetCommandBarButtonItem149";
		this.spreadsheetCommandBarButtonItem150.CommandName = "ArrangeBringToFront";
		this.spreadsheetCommandBarButtonItem150.Id = 252;
		this.spreadsheetCommandBarButtonItem150.Name = "spreadsheetCommandBarButtonItem150";
		this.spreadsheetCommandBarSubItem25.CommandName = "ArrangeSendBackwardCommandGroup";
		this.spreadsheetCommandBarSubItem25.Id = 253;
		this.spreadsheetCommandBarSubItem25.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem151),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem152)
		});
		this.spreadsheetCommandBarSubItem25.Name = "spreadsheetCommandBarSubItem25";
		this.spreadsheetCommandBarButtonItem151.CommandName = "ArrangeSendBackward";
		this.spreadsheetCommandBarButtonItem151.Id = 254;
		this.spreadsheetCommandBarButtonItem151.Name = "spreadsheetCommandBarButtonItem151";
		this.spreadsheetCommandBarButtonItem152.CommandName = "ArrangeSendToBack";
		this.spreadsheetCommandBarButtonItem152.Id = 255;
		this.spreadsheetCommandBarButtonItem152.Name = "spreadsheetCommandBarButtonItem152";
		this.spreadsheetCommandBarSubItem26.CommandName = "DataToolsDataValidationCommandGroup";
		this.spreadsheetCommandBarSubItem26.Id = 256;
		this.spreadsheetCommandBarSubItem26.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[3]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem153),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem154),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem155)
		});
		this.spreadsheetCommandBarSubItem26.Name = "spreadsheetCommandBarSubItem26";
		this.spreadsheetCommandBarButtonItem153.CommandName = "DataToolsDataValidation";
		this.spreadsheetCommandBarButtonItem153.Id = 257;
		this.spreadsheetCommandBarButtonItem153.Name = "spreadsheetCommandBarButtonItem153";
		this.spreadsheetCommandBarButtonItem154.CommandName = "DataToolsCircleInvalidData";
		this.spreadsheetCommandBarButtonItem154.Id = 258;
		this.spreadsheetCommandBarButtonItem154.Name = "spreadsheetCommandBarButtonItem154";
		this.spreadsheetCommandBarButtonItem155.CommandName = "DataToolsClearValidationCircles";
		this.spreadsheetCommandBarButtonItem155.Id = 259;
		this.spreadsheetCommandBarButtonItem155.Name = "spreadsheetCommandBarButtonItem155";
		this.spreadsheetCommandBarSubItem27.CommandName = "OutlineGroupCommandGroup";
		this.spreadsheetCommandBarSubItem27.Id = 260;
		this.spreadsheetCommandBarSubItem27.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem156),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem157)
		});
		this.spreadsheetCommandBarSubItem27.Name = "spreadsheetCommandBarSubItem27";
		this.spreadsheetCommandBarSubItem27.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem156.CommandName = "GroupOutline";
		this.spreadsheetCommandBarButtonItem156.Id = 261;
		this.spreadsheetCommandBarButtonItem156.Name = "spreadsheetCommandBarButtonItem156";
		this.spreadsheetCommandBarButtonItem157.CommandName = "AutoOutline";
		this.spreadsheetCommandBarButtonItem157.Id = 262;
		this.spreadsheetCommandBarButtonItem157.Name = "spreadsheetCommandBarButtonItem157";
		this.spreadsheetCommandBarSubItem28.CommandName = "OutlineUngroupCommandGroup";
		this.spreadsheetCommandBarSubItem28.Id = 263;
		this.spreadsheetCommandBarSubItem28.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem158),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem159)
		});
		this.spreadsheetCommandBarSubItem28.Name = "spreadsheetCommandBarSubItem28";
		this.spreadsheetCommandBarSubItem28.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem158.CommandName = "UngroupOutline";
		this.spreadsheetCommandBarButtonItem158.Id = 264;
		this.spreadsheetCommandBarButtonItem158.Name = "spreadsheetCommandBarButtonItem158";
		this.spreadsheetCommandBarButtonItem159.CommandName = "ClearOutline";
		this.spreadsheetCommandBarButtonItem159.Id = 265;
		this.spreadsheetCommandBarButtonItem159.Name = "spreadsheetCommandBarButtonItem159";
		this.spreadsheetCommandBarButtonItem160.CommandName = "Subtotal";
		this.spreadsheetCommandBarButtonItem160.Id = 266;
		this.spreadsheetCommandBarButtonItem160.Name = "spreadsheetCommandBarButtonItem160";
		this.spreadsheetCommandBarButtonItem160.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem161.CommandName = "ShowDetail";
		this.spreadsheetCommandBarButtonItem161.Id = 267;
		this.spreadsheetCommandBarButtonItem161.Name = "spreadsheetCommandBarButtonItem161";
		this.spreadsheetCommandBarButtonItem161.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarButtonItem162.CommandName = "HideDetail";
		this.spreadsheetCommandBarButtonItem162.Id = 268;
		this.spreadsheetCommandBarButtonItem162.Name = "spreadsheetCommandBarButtonItem162";
		this.spreadsheetCommandBarButtonItem162.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarButtonItem163.CommandName = "ChartChangeType";
		this.spreadsheetCommandBarButtonItem163.Id = 269;
		this.spreadsheetCommandBarButtonItem163.Name = "spreadsheetCommandBarButtonItem163";
		this.spreadsheetCommandBarButtonItem164.CommandName = "ChartSwitchRowColumn";
		this.spreadsheetCommandBarButtonItem164.Id = 270;
		this.spreadsheetCommandBarButtonItem164.Name = "spreadsheetCommandBarButtonItem164";
		this.spreadsheetCommandBarButtonItem165.CommandName = "ChartSelectData";
		this.spreadsheetCommandBarButtonItem165.Id = 271;
		this.spreadsheetCommandBarButtonItem165.Name = "spreadsheetCommandBarButtonItem165";
		this.galleryChartLayoutItem1.Gallery.ColumnCount = 6;
		this.galleryChartLayoutItem1.Gallery.DrawImageBackground = false;
		this.galleryChartLayoutItem1.Gallery.ImageSize = new System.Drawing.Size(48, 48);
		this.galleryChartLayoutItem1.Gallery.RowCount = 2;
		this.galleryChartLayoutItem1.Id = 272;
		this.galleryChartLayoutItem1.Name = "galleryChartLayoutItem1";
		this.galleryChartStyleItem1.Gallery.ColumnCount = 8;
		this.galleryChartStyleItem1.Gallery.DrawImageBackground = false;
		this.galleryChartStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
		this.galleryChartStyleItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
		this.galleryChartStyleItem1.Gallery.ItemSize = new System.Drawing.Size(93, 56);
		this.galleryChartStyleItem1.Gallery.MinimumColumnCount = 4;
		this.galleryChartStyleItem1.Gallery.RowCount = 6;
		this.galleryChartStyleItem1.Id = 273;
		this.galleryChartStyleItem1.Name = "galleryChartStyleItem1";
		this.spreadsheetCommandBarButtonItem166.CommandName = "MoveChart";
		this.spreadsheetCommandBarButtonItem166.Id = 274;
		this.spreadsheetCommandBarButtonItem166.Name = "spreadsheetCommandBarButtonItem166";
		this.spreadsheetCommandBarSubItem29.CommandName = "ChartAxesCommandGroup";
		this.spreadsheetCommandBarSubItem29.Id = 275;
		this.spreadsheetCommandBarSubItem29.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem11),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem12)
		});
		this.spreadsheetCommandBarSubItem29.Name = "spreadsheetCommandBarSubItem29";
		this.spreadsheetCommandBarButtonGalleryDropDownItem11.CommandName = "ChartPrimaryHorizontalAxisCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem11.DropDownControl = this.commandBarGalleryDropDown13;
		this.spreadsheetCommandBarButtonGalleryDropDownItem11.Id = 276;
		this.spreadsheetCommandBarButtonGalleryDropDownItem11.Name = "spreadsheetCommandBarButtonGalleryDropDownItem11";
		this.commandBarGalleryDropDown13.Gallery.AllowFilter = false;
		this.commandBarGalleryDropDown13.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
		spreadsheetCommandGalleryItemGroup29.CommandName = "ChartPrimaryHorizontalAxisCommandGroup";
		spreadsheetCommandGalleryItem123.CommandName = "ChartHidePrimaryHorizontalAxis";
		spreadsheetCommandGalleryItem124.CommandName = "ChartPrimaryHorizontalAxisLeftToRight";
		spreadsheetCommandGalleryItem125.CommandName = "ChartPrimaryHorizontalAxisHideLabels";
		spreadsheetCommandGalleryItem126.CommandName = "ChartPrimaryHorizontalAxisRightToLeft";
		spreadsheetCommandGalleryItem127.CommandName = "ChartPrimaryHorizontalAxisDefault";
		spreadsheetCommandGalleryItem128.CommandName = "ChartPrimaryHorizontalAxisScaleThousands";
		spreadsheetCommandGalleryItem129.CommandName = "ChartPrimaryHorizontalAxisScaleMillions";
		spreadsheetCommandGalleryItem130.CommandName = "ChartPrimaryHorizontalAxisScaleBillions";
		spreadsheetCommandGalleryItem131.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm";
		spreadsheetCommandGalleryItemGroup29.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[9] { spreadsheetCommandGalleryItem123, spreadsheetCommandGalleryItem124, spreadsheetCommandGalleryItem125, spreadsheetCommandGalleryItem126, spreadsheetCommandGalleryItem127, spreadsheetCommandGalleryItem128, spreadsheetCommandGalleryItem129, spreadsheetCommandGalleryItem130, spreadsheetCommandGalleryItem131 });
		this.commandBarGalleryDropDown13.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { spreadsheetCommandGalleryItemGroup29 });
		this.commandBarGalleryDropDown13.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown13.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
		this.commandBarGalleryDropDown13.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
		this.commandBarGalleryDropDown13.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown13.Name = "commandBarGalleryDropDown13";
		this.commandBarGalleryDropDown13.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem12.CommandName = "ChartPrimaryVerticalAxisCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem12.DropDownControl = this.commandBarGalleryDropDown14;
		this.spreadsheetCommandBarButtonGalleryDropDownItem12.Id = 277;
		this.spreadsheetCommandBarButtonGalleryDropDownItem12.Name = "spreadsheetCommandBarButtonGalleryDropDownItem12";
		this.commandBarGalleryDropDown14.Gallery.AllowFilter = false;
		this.commandBarGalleryDropDown14.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
		spreadsheetCommandGalleryItemGroup30.CommandName = "ChartPrimaryVerticalAxisCommandGroup";
		spreadsheetCommandGalleryItem132.CommandName = "ChartHidePrimaryVerticalAxis";
		spreadsheetCommandGalleryItem133.CommandName = "ChartPrimaryVerticalAxisLeftToRight";
		spreadsheetCommandGalleryItem134.CommandName = "ChartPrimaryVerticalAxisHideLabels";
		spreadsheetCommandGalleryItem135.CommandName = "ChartPrimaryVerticalAxisRightToLeft";
		spreadsheetCommandGalleryItem136.CommandName = "ChartPrimaryVerticalAxisDefault";
		spreadsheetCommandGalleryItem137.CommandName = "ChartPrimaryVerticalAxisScaleThousands";
		spreadsheetCommandGalleryItem138.CommandName = "ChartPrimaryVerticalAxisScaleMillions";
		spreadsheetCommandGalleryItem139.CommandName = "ChartPrimaryVerticalAxisScaleBillions";
		spreadsheetCommandGalleryItem140.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm";
		spreadsheetCommandGalleryItemGroup30.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[9] { spreadsheetCommandGalleryItem132, spreadsheetCommandGalleryItem133, spreadsheetCommandGalleryItem134, spreadsheetCommandGalleryItem135, spreadsheetCommandGalleryItem136, spreadsheetCommandGalleryItem137, spreadsheetCommandGalleryItem138, spreadsheetCommandGalleryItem139, spreadsheetCommandGalleryItem140 });
		this.commandBarGalleryDropDown14.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { spreadsheetCommandGalleryItemGroup30 });
		this.commandBarGalleryDropDown14.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown14.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
		this.commandBarGalleryDropDown14.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
		this.commandBarGalleryDropDown14.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown14.Name = "commandBarGalleryDropDown14";
		this.commandBarGalleryDropDown14.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarSubItem30.CommandName = "ChartGridlinesCommandGroup";
		this.spreadsheetCommandBarSubItem30.Id = 278;
		this.spreadsheetCommandBarSubItem30.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem13),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem14)
		});
		this.spreadsheetCommandBarSubItem30.Name = "spreadsheetCommandBarSubItem30";
		this.spreadsheetCommandBarButtonGalleryDropDownItem13.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem13.DropDownControl = this.commandBarGalleryDropDown15;
		this.spreadsheetCommandBarButtonGalleryDropDownItem13.Id = 279;
		this.spreadsheetCommandBarButtonGalleryDropDownItem13.Name = "spreadsheetCommandBarButtonGalleryDropDownItem13";
		this.commandBarGalleryDropDown15.Gallery.AllowFilter = false;
		this.commandBarGalleryDropDown15.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
		spreadsheetCommandGalleryItemGroup31.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup";
		spreadsheetCommandGalleryItem141.CommandName = "ChartPrimaryHorizontalGridlinesNone";
		spreadsheetCommandGalleryItem142.CommandName = "ChartPrimaryHorizontalGridlinesMajor";
		spreadsheetCommandGalleryItem143.CommandName = "ChartPrimaryHorizontalGridlinesMinor";
		spreadsheetCommandGalleryItem144.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor";
		spreadsheetCommandGalleryItemGroup31.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[4] { spreadsheetCommandGalleryItem141, spreadsheetCommandGalleryItem142, spreadsheetCommandGalleryItem143, spreadsheetCommandGalleryItem144 });
		this.commandBarGalleryDropDown15.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { spreadsheetCommandGalleryItemGroup31 });
		this.commandBarGalleryDropDown15.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown15.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
		this.commandBarGalleryDropDown15.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
		this.commandBarGalleryDropDown15.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown15.Name = "commandBarGalleryDropDown15";
		this.commandBarGalleryDropDown15.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem14.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem14.DropDownControl = this.commandBarGalleryDropDown16;
		this.spreadsheetCommandBarButtonGalleryDropDownItem14.Id = 280;
		this.spreadsheetCommandBarButtonGalleryDropDownItem14.Name = "spreadsheetCommandBarButtonGalleryDropDownItem14";
		this.commandBarGalleryDropDown16.Gallery.AllowFilter = false;
		this.commandBarGalleryDropDown16.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
		spreadsheetCommandGalleryItemGroup32.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup";
		spreadsheetCommandGalleryItem145.CommandName = "ChartPrimaryVerticalGridlinesNone";
		spreadsheetCommandGalleryItem146.CommandName = "ChartPrimaryVerticalGridlinesMajor";
		spreadsheetCommandGalleryItem147.CommandName = "ChartPrimaryVerticalGridlinesMinor";
		spreadsheetCommandGalleryItem148.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor";
		spreadsheetCommandGalleryItemGroup32.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[4] { spreadsheetCommandGalleryItem145, spreadsheetCommandGalleryItem146, spreadsheetCommandGalleryItem147, spreadsheetCommandGalleryItem148 });
		this.commandBarGalleryDropDown16.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { spreadsheetCommandGalleryItemGroup32 });
		this.commandBarGalleryDropDown16.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown16.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
		this.commandBarGalleryDropDown16.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
		this.commandBarGalleryDropDown16.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown16.Name = "commandBarGalleryDropDown16";
		this.commandBarGalleryDropDown16.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem15.CommandName = "ChartTitleCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem15.DropDownControl = this.commandBarGalleryDropDown17;
		this.spreadsheetCommandBarButtonGalleryDropDownItem15.Id = 281;
		this.spreadsheetCommandBarButtonGalleryDropDownItem15.Name = "spreadsheetCommandBarButtonGalleryDropDownItem15";
		this.commandBarGalleryDropDown17.Gallery.AllowFilter = false;
		this.commandBarGalleryDropDown17.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
		spreadsheetCommandGalleryItemGroup33.CommandName = "ChartTitleCommandGroup";
		spreadsheetCommandGalleryItem149.CommandName = "ChartTitleNone";
		spreadsheetCommandGalleryItem150.CommandName = "ChartTitleCenteredOverlay";
		spreadsheetCommandGalleryItem151.CommandName = "ChartTitleAbove";
		spreadsheetCommandGalleryItemGroup33.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[3] { spreadsheetCommandGalleryItem149, spreadsheetCommandGalleryItem150, spreadsheetCommandGalleryItem151 });
		this.commandBarGalleryDropDown17.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { spreadsheetCommandGalleryItemGroup33 });
		this.commandBarGalleryDropDown17.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown17.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
		this.commandBarGalleryDropDown17.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
		this.commandBarGalleryDropDown17.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown17.Name = "commandBarGalleryDropDown17";
		this.commandBarGalleryDropDown17.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarSubItem31.CommandName = "ChartAxisTitlesCommandGroup";
		this.spreadsheetCommandBarSubItem31.Id = 282;
		this.spreadsheetCommandBarSubItem31.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem16),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem17)
		});
		this.spreadsheetCommandBarSubItem31.Name = "spreadsheetCommandBarSubItem31";
		this.spreadsheetCommandBarButtonGalleryDropDownItem16.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem16.DropDownControl = this.commandBarGalleryDropDown18;
		this.spreadsheetCommandBarButtonGalleryDropDownItem16.Id = 283;
		this.spreadsheetCommandBarButtonGalleryDropDownItem16.Name = "spreadsheetCommandBarButtonGalleryDropDownItem16";
		this.commandBarGalleryDropDown18.Gallery.AllowFilter = false;
		this.commandBarGalleryDropDown18.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
		spreadsheetCommandGalleryItemGroup34.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup";
		spreadsheetCommandGalleryItem152.CommandName = "ChartPrimaryHorizontalAxisTitleNone";
		spreadsheetCommandGalleryItem153.CommandName = "ChartPrimaryHorizontalAxisTitleBelow";
		spreadsheetCommandGalleryItemGroup34.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[2] { spreadsheetCommandGalleryItem152, spreadsheetCommandGalleryItem153 });
		this.commandBarGalleryDropDown18.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { spreadsheetCommandGalleryItemGroup34 });
		this.commandBarGalleryDropDown18.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown18.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
		this.commandBarGalleryDropDown18.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
		this.commandBarGalleryDropDown18.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown18.Name = "commandBarGalleryDropDown18";
		this.commandBarGalleryDropDown18.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem17.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem17.DropDownControl = this.commandBarGalleryDropDown19;
		this.spreadsheetCommandBarButtonGalleryDropDownItem17.Id = 284;
		this.spreadsheetCommandBarButtonGalleryDropDownItem17.Name = "spreadsheetCommandBarButtonGalleryDropDownItem17";
		this.commandBarGalleryDropDown19.Gallery.AllowFilter = false;
		this.commandBarGalleryDropDown19.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
		spreadsheetCommandGalleryItemGroup35.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup";
		spreadsheetCommandGalleryItem154.CommandName = "ChartPrimaryVerticalAxisTitleNone";
		spreadsheetCommandGalleryItem155.CommandName = "ChartPrimaryVerticalAxisTitleRotated";
		spreadsheetCommandGalleryItem156.CommandName = "ChartPrimaryVerticalAxisTitleVertical";
		spreadsheetCommandGalleryItem157.CommandName = "ChartPrimaryVerticalAxisTitleHorizontal";
		spreadsheetCommandGalleryItemGroup35.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[4] { spreadsheetCommandGalleryItem154, spreadsheetCommandGalleryItem155, spreadsheetCommandGalleryItem156, spreadsheetCommandGalleryItem157 });
		this.commandBarGalleryDropDown19.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { spreadsheetCommandGalleryItemGroup35 });
		this.commandBarGalleryDropDown19.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown19.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
		this.commandBarGalleryDropDown19.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
		this.commandBarGalleryDropDown19.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown19.Name = "commandBarGalleryDropDown19";
		this.commandBarGalleryDropDown19.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem18.CommandName = "ChartLegendCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem18.DropDownControl = this.commandBarGalleryDropDown20;
		this.spreadsheetCommandBarButtonGalleryDropDownItem18.Id = 285;
		this.spreadsheetCommandBarButtonGalleryDropDownItem18.Name = "spreadsheetCommandBarButtonGalleryDropDownItem18";
		this.commandBarGalleryDropDown20.Gallery.AllowFilter = false;
		this.commandBarGalleryDropDown20.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
		spreadsheetCommandGalleryItemGroup36.CommandName = "ChartLegendCommandGroup";
		spreadsheetCommandGalleryItem158.CommandName = "ChartLegendNone";
		spreadsheetCommandGalleryItem159.CommandName = "ChartLegendAtRight";
		spreadsheetCommandGalleryItem160.CommandName = "ChartLegendAtTop";
		spreadsheetCommandGalleryItem161.CommandName = "ChartLegendAtLeft";
		spreadsheetCommandGalleryItem162.CommandName = "ChartLegendAtBottom";
		spreadsheetCommandGalleryItem163.CommandName = "ChartLegendOverlayAtRight";
		spreadsheetCommandGalleryItem164.CommandName = "ChartLegendOverlayAtLeft";
		spreadsheetCommandGalleryItemGroup36.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[7] { spreadsheetCommandGalleryItem158, spreadsheetCommandGalleryItem159, spreadsheetCommandGalleryItem160, spreadsheetCommandGalleryItem161, spreadsheetCommandGalleryItem162, spreadsheetCommandGalleryItem163, spreadsheetCommandGalleryItem164 });
		this.commandBarGalleryDropDown20.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { spreadsheetCommandGalleryItemGroup36 });
		this.commandBarGalleryDropDown20.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown20.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
		this.commandBarGalleryDropDown20.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
		this.commandBarGalleryDropDown20.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown20.Name = "commandBarGalleryDropDown20";
		this.commandBarGalleryDropDown20.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem19.CommandName = "ChartDataLabelsCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem19.DropDownControl = this.commandBarGalleryDropDown21;
		this.spreadsheetCommandBarButtonGalleryDropDownItem19.Id = 286;
		this.spreadsheetCommandBarButtonGalleryDropDownItem19.Name = "spreadsheetCommandBarButtonGalleryDropDownItem19";
		this.commandBarGalleryDropDown21.Gallery.AllowFilter = false;
		this.commandBarGalleryDropDown21.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
		spreadsheetCommandGalleryItemGroup37.CommandName = "ChartDataLabelsCommandGroup";
		spreadsheetCommandGalleryItem165.CommandName = "ChartDataLabelsNone";
		spreadsheetCommandGalleryItem166.CommandName = "ChartDataLabelsDefault";
		spreadsheetCommandGalleryItem167.CommandName = "ChartDataLabelsCenter";
		spreadsheetCommandGalleryItem168.CommandName = "ChartDataLabelsInsideEnd";
		spreadsheetCommandGalleryItem169.CommandName = "ChartDataLabelsInsideBase";
		spreadsheetCommandGalleryItem170.CommandName = "ChartDataLabelsOutsideEnd";
		spreadsheetCommandGalleryItem171.CommandName = "ChartDataLabelsBestFit";
		spreadsheetCommandGalleryItem172.CommandName = "ChartDataLabelsLeft";
		spreadsheetCommandGalleryItem173.CommandName = "ChartDataLabelsRight";
		spreadsheetCommandGalleryItem174.CommandName = "ChartDataLabelsAbove";
		spreadsheetCommandGalleryItem175.CommandName = "ChartDataLabelsBelow";
		spreadsheetCommandGalleryItemGroup37.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[11]
		{
			spreadsheetCommandGalleryItem165, spreadsheetCommandGalleryItem166, spreadsheetCommandGalleryItem167, spreadsheetCommandGalleryItem168, spreadsheetCommandGalleryItem169, spreadsheetCommandGalleryItem170, spreadsheetCommandGalleryItem171, spreadsheetCommandGalleryItem172, spreadsheetCommandGalleryItem173, spreadsheetCommandGalleryItem174,
			spreadsheetCommandGalleryItem175
		});
		this.commandBarGalleryDropDown21.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { spreadsheetCommandGalleryItemGroup37 });
		this.commandBarGalleryDropDown21.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown21.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
		this.commandBarGalleryDropDown21.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
		this.commandBarGalleryDropDown21.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown21.Name = "commandBarGalleryDropDown21";
		this.commandBarGalleryDropDown21.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem20.CommandName = "ChartLinesCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem20.DropDownControl = this.commandBarGalleryDropDown22;
		this.spreadsheetCommandBarButtonGalleryDropDownItem20.Id = 287;
		this.spreadsheetCommandBarButtonGalleryDropDownItem20.Name = "spreadsheetCommandBarButtonGalleryDropDownItem20";
		this.commandBarGalleryDropDown22.Gallery.AllowFilter = false;
		this.commandBarGalleryDropDown22.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
		spreadsheetCommandGalleryItemGroup38.CommandName = "ChartLinesCommandGroup";
		spreadsheetCommandGalleryItem176.CommandName = "ChartLinesNone";
		spreadsheetCommandGalleryItem177.CommandName = "ChartShowDropLines";
		spreadsheetCommandGalleryItem178.CommandName = "ChartShowHighLowLines";
		spreadsheetCommandGalleryItem179.CommandName = "ChartShowDropLinesAndHighLowLines";
		spreadsheetCommandGalleryItem180.CommandName = "ChartShowSeriesLines";
		spreadsheetCommandGalleryItemGroup38.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[5] { spreadsheetCommandGalleryItem176, spreadsheetCommandGalleryItem177, spreadsheetCommandGalleryItem178, spreadsheetCommandGalleryItem179, spreadsheetCommandGalleryItem180 });
		this.commandBarGalleryDropDown22.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { spreadsheetCommandGalleryItemGroup38 });
		this.commandBarGalleryDropDown22.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown22.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
		this.commandBarGalleryDropDown22.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
		this.commandBarGalleryDropDown22.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown22.Name = "commandBarGalleryDropDown22";
		this.commandBarGalleryDropDown22.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem21.CommandName = "ChartUpDownBarsCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem21.DropDownControl = this.commandBarGalleryDropDown23;
		this.spreadsheetCommandBarButtonGalleryDropDownItem21.Id = 288;
		this.spreadsheetCommandBarButtonGalleryDropDownItem21.Name = "spreadsheetCommandBarButtonGalleryDropDownItem21";
		this.commandBarGalleryDropDown23.Gallery.AllowFilter = false;
		this.commandBarGalleryDropDown23.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
		spreadsheetCommandGalleryItemGroup39.CommandName = "ChartUpDownBarsCommandGroup";
		spreadsheetCommandGalleryItem181.CommandName = "ChartHideUpDownBars";
		spreadsheetCommandGalleryItem182.CommandName = "ChartShowUpDownBars";
		spreadsheetCommandGalleryItemGroup39.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[2] { spreadsheetCommandGalleryItem181, spreadsheetCommandGalleryItem182 });
		this.commandBarGalleryDropDown23.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { spreadsheetCommandGalleryItemGroup39 });
		this.commandBarGalleryDropDown23.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown23.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
		this.commandBarGalleryDropDown23.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
		this.commandBarGalleryDropDown23.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown23.Name = "commandBarGalleryDropDown23";
		this.commandBarGalleryDropDown23.Ribbon = this.ribbonControl1;
		this.spreadsheetCommandBarButtonGalleryDropDownItem22.CommandName = "ChartErrorBarsCommandGroup";
		this.spreadsheetCommandBarButtonGalleryDropDownItem22.DropDownControl = this.commandBarGalleryDropDown24;
		this.spreadsheetCommandBarButtonGalleryDropDownItem22.Id = 289;
		this.spreadsheetCommandBarButtonGalleryDropDownItem22.Name = "spreadsheetCommandBarButtonGalleryDropDownItem22";
		this.commandBarGalleryDropDown24.Gallery.AllowFilter = false;
		this.commandBarGalleryDropDown24.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
		spreadsheetCommandGalleryItemGroup40.CommandName = "ChartErrorBarsCommandGroup";
		spreadsheetCommandGalleryItem183.CommandName = "ChartErrorBarsNone";
		spreadsheetCommandGalleryItem184.CommandName = "ChartErrorBarsStandardError";
		spreadsheetCommandGalleryItem185.CommandName = "ChartErrorBarsPercentage";
		spreadsheetCommandGalleryItem186.CommandName = "ChartErrorBarsStandardDeviation";
		spreadsheetCommandGalleryItemGroup40.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[4] { spreadsheetCommandGalleryItem183, spreadsheetCommandGalleryItem184, spreadsheetCommandGalleryItem185, spreadsheetCommandGalleryItem186 });
		this.commandBarGalleryDropDown24.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[1] { spreadsheetCommandGalleryItemGroup40 });
		this.commandBarGalleryDropDown24.Gallery.ImageSize = new System.Drawing.Size(32, 32);
		this.commandBarGalleryDropDown24.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
		this.commandBarGalleryDropDown24.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
		this.commandBarGalleryDropDown24.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
		this.commandBarGalleryDropDown24.Name = "commandBarGalleryDropDown24";
		this.commandBarGalleryDropDown24.Ribbon = this.ribbonControl1;
		this.renameTableItemCaption1.Id = 290;
		this.renameTableItemCaption1.Name = "renameTableItemCaption1";
		this.renameTableItem1.Edit = this.repositoryItemTextEdit1;
		this.renameTableItem1.Id = 291;
		this.renameTableItem1.Name = "renameTableItem1";
		this.repositoryItemTextEdit1.AutoHeight = false;
		this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
		this.spreadsheetCommandBarCheckItem27.CommandName = "TableToolsConvertToRange";
		this.spreadsheetCommandBarCheckItem27.Id = 292;
		this.spreadsheetCommandBarCheckItem27.Name = "spreadsheetCommandBarCheckItem27";
		this.spreadsheetCommandBarCheckItem27.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarCheckItem28.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
		this.spreadsheetCommandBarCheckItem28.CommandName = "TableToolsToggleHeaderRow";
		this.spreadsheetCommandBarCheckItem28.Id = 293;
		this.spreadsheetCommandBarCheckItem28.Name = "spreadsheetCommandBarCheckItem28";
		this.spreadsheetCommandBarCheckItem29.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
		this.spreadsheetCommandBarCheckItem29.CommandName = "TableToolsToggleTotalRow";
		this.spreadsheetCommandBarCheckItem29.Id = 294;
		this.spreadsheetCommandBarCheckItem29.Name = "spreadsheetCommandBarCheckItem29";
		this.spreadsheetCommandBarCheckItem30.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
		this.spreadsheetCommandBarCheckItem30.CommandName = "TableToolsToggleBandedColumns";
		this.spreadsheetCommandBarCheckItem30.Id = 295;
		this.spreadsheetCommandBarCheckItem30.Name = "spreadsheetCommandBarCheckItem30";
		this.spreadsheetCommandBarCheckItem31.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
		this.spreadsheetCommandBarCheckItem31.CommandName = "TableToolsToggleFirstColumn";
		this.spreadsheetCommandBarCheckItem31.Id = 296;
		this.spreadsheetCommandBarCheckItem31.Name = "spreadsheetCommandBarCheckItem31";
		this.spreadsheetCommandBarCheckItem32.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
		this.spreadsheetCommandBarCheckItem32.CommandName = "TableToolsToggleLastColumn";
		this.spreadsheetCommandBarCheckItem32.Id = 297;
		this.spreadsheetCommandBarCheckItem32.Name = "spreadsheetCommandBarCheckItem32";
		this.spreadsheetCommandBarCheckItem33.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
		this.spreadsheetCommandBarCheckItem33.CommandName = "TableToolsToggleBandedRows";
		this.spreadsheetCommandBarCheckItem33.Id = 298;
		this.spreadsheetCommandBarCheckItem33.Name = "spreadsheetCommandBarCheckItem33";
		this.galleryTableStylesItem1.Gallery.ColumnCount = 7;
		this.galleryTableStylesItem1.Gallery.DrawImageBackground = false;
		this.galleryTableStylesItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
		this.galleryTableStylesItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
		this.galleryTableStylesItem1.Gallery.ItemSize = new System.Drawing.Size(73, 58);
		this.galleryTableStylesItem1.Gallery.RowCount = 10;
		this.galleryTableStylesItem1.Id = 299;
		this.galleryTableStylesItem1.Name = "galleryTableStylesItem1";
		this.spreadsheetCommandBarButtonItem167.CommandName = "OptionsPivotTable";
		this.spreadsheetCommandBarButtonItem167.Id = 300;
		this.spreadsheetCommandBarButtonItem167.Name = "spreadsheetCommandBarButtonItem167";
		this.spreadsheetCommandBarButtonItem168.CommandName = "SelectFieldTypePivotTable";
		this.spreadsheetCommandBarButtonItem168.Id = 301;
		this.spreadsheetCommandBarButtonItem168.Name = "spreadsheetCommandBarButtonItem168";
		this.spreadsheetCommandBarButtonItem169.CommandName = "PivotTableExpandField";
		this.spreadsheetCommandBarButtonItem169.Id = 302;
		this.spreadsheetCommandBarButtonItem169.Name = "spreadsheetCommandBarButtonItem169";
		this.spreadsheetCommandBarButtonItem169.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarButtonItem170.CommandName = "PivotTableCollapseField";
		this.spreadsheetCommandBarButtonItem170.Id = 303;
		this.spreadsheetCommandBarButtonItem170.Name = "spreadsheetCommandBarButtonItem170";
		this.spreadsheetCommandBarButtonItem170.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarButtonItem171.CommandName = "PivotTableGroupSelection";
		this.spreadsheetCommandBarButtonItem171.Id = 304;
		this.spreadsheetCommandBarButtonItem171.Name = "spreadsheetCommandBarButtonItem171";
		this.spreadsheetCommandBarButtonItem171.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarButtonItem172.CommandName = "PivotTableUngroup";
		this.spreadsheetCommandBarButtonItem172.Id = 305;
		this.spreadsheetCommandBarButtonItem172.Name = "spreadsheetCommandBarButtonItem172";
		this.spreadsheetCommandBarButtonItem172.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarButtonItem173.CommandName = "PivotTableGroupField";
		this.spreadsheetCommandBarButtonItem173.Id = 306;
		this.spreadsheetCommandBarButtonItem173.Name = "spreadsheetCommandBarButtonItem173";
		this.spreadsheetCommandBarButtonItem173.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
		this.spreadsheetCommandBarSubItem32.CommandName = "PivotTableDataRefreshGroup";
		this.spreadsheetCommandBarSubItem32.Id = 307;
		this.spreadsheetCommandBarSubItem32.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem174),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem175)
		});
		this.spreadsheetCommandBarSubItem32.Name = "spreadsheetCommandBarSubItem32";
		this.spreadsheetCommandBarButtonItem174.CommandName = "RefreshPivotTable";
		this.spreadsheetCommandBarButtonItem174.Id = 308;
		this.spreadsheetCommandBarButtonItem174.Name = "spreadsheetCommandBarButtonItem174";
		this.spreadsheetCommandBarButtonItem175.CommandName = "RefreshAllPivotTable";
		this.spreadsheetCommandBarButtonItem175.Id = 309;
		this.spreadsheetCommandBarButtonItem175.Name = "spreadsheetCommandBarButtonItem175";
		this.spreadsheetCommandBarButtonItem176.CommandName = "ChangeDataSourcePivotTable";
		this.spreadsheetCommandBarButtonItem176.Id = 310;
		this.spreadsheetCommandBarButtonItem176.Name = "spreadsheetCommandBarButtonItem176";
		this.spreadsheetCommandBarSubItem33.CommandName = "PivotTableActionsClearGroup";
		this.spreadsheetCommandBarSubItem33.Id = 311;
		this.spreadsheetCommandBarSubItem33.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem177),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem178)
		});
		this.spreadsheetCommandBarSubItem33.Name = "spreadsheetCommandBarSubItem33";
		this.spreadsheetCommandBarButtonItem177.CommandName = "ClearAllPivotTable";
		this.spreadsheetCommandBarButtonItem177.Id = 312;
		this.spreadsheetCommandBarButtonItem177.Name = "spreadsheetCommandBarButtonItem177";
		this.spreadsheetCommandBarButtonItem178.CommandName = "ClearFiltersPivotTable";
		this.spreadsheetCommandBarButtonItem178.Id = 313;
		this.spreadsheetCommandBarButtonItem178.Name = "spreadsheetCommandBarButtonItem178";
		this.spreadsheetCommandBarSubItem34.CommandName = "PivotTableActionsSelectGroup";
		this.spreadsheetCommandBarSubItem34.Id = 314;
		this.spreadsheetCommandBarSubItem34.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[3]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem179),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem180),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem181)
		});
		this.spreadsheetCommandBarSubItem34.Name = "spreadsheetCommandBarSubItem34";
		this.spreadsheetCommandBarButtonItem179.CommandName = "SelectValuesPivotTable";
		this.spreadsheetCommandBarButtonItem179.Id = 315;
		this.spreadsheetCommandBarButtonItem179.Name = "spreadsheetCommandBarButtonItem179";
		this.spreadsheetCommandBarButtonItem180.CommandName = "SelectLabelsPivotTable";
		this.spreadsheetCommandBarButtonItem180.Id = 316;
		this.spreadsheetCommandBarButtonItem180.Name = "spreadsheetCommandBarButtonItem180";
		this.spreadsheetCommandBarButtonItem181.CommandName = "SelectEntirePivotTable";
		this.spreadsheetCommandBarButtonItem181.Id = 317;
		this.spreadsheetCommandBarButtonItem181.Name = "spreadsheetCommandBarButtonItem181";
		this.spreadsheetCommandBarButtonItem182.CommandName = "MovePivotTable";
		this.spreadsheetCommandBarButtonItem182.Id = 318;
		this.spreadsheetCommandBarButtonItem182.Name = "spreadsheetCommandBarButtonItem182";
		this.spreadsheetCommandBarSubItem35.CommandName = "PivotTableCalculationFieldsItemsSetsGroup";
		this.spreadsheetCommandBarSubItem35.Id = 319;
		this.spreadsheetCommandBarSubItem35.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[4]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem183),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem184),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem185),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem186)
		});
		this.spreadsheetCommandBarSubItem35.Name = "spreadsheetCommandBarSubItem35";
		this.spreadsheetCommandBarButtonItem183.CommandName = "PivotTableCalculatedField";
		this.spreadsheetCommandBarButtonItem183.Id = 320;
		this.spreadsheetCommandBarButtonItem183.Name = "spreadsheetCommandBarButtonItem183";
		this.spreadsheetCommandBarButtonItem184.CommandName = "PivotTableCalculatedItem";
		this.spreadsheetCommandBarButtonItem184.Id = 321;
		this.spreadsheetCommandBarButtonItem184.Name = "spreadsheetCommandBarButtonItem184";
		this.spreadsheetCommandBarButtonItem185.CommandName = "PivotTableCalculatedItemSolveOrder";
		this.spreadsheetCommandBarButtonItem185.Id = 322;
		this.spreadsheetCommandBarButtonItem185.Name = "spreadsheetCommandBarButtonItem185";
		this.spreadsheetCommandBarButtonItem186.CommandName = "PivotTableListFormulas";
		this.spreadsheetCommandBarButtonItem186.Id = 323;
		this.spreadsheetCommandBarButtonItem186.Name = "spreadsheetCommandBarButtonItem186";
		this.spreadsheetCommandBarCheckItem34.CommandName = "FieldListPanelPivotTable";
		this.spreadsheetCommandBarCheckItem34.Id = 324;
		this.spreadsheetCommandBarCheckItem34.Name = "spreadsheetCommandBarCheckItem34";
		this.spreadsheetCommandBarCheckItem35.CommandName = "ShowPivotTableExpandCollapseButtons";
		this.spreadsheetCommandBarCheckItem35.Id = 325;
		this.spreadsheetCommandBarCheckItem35.Name = "spreadsheetCommandBarCheckItem35";
		this.spreadsheetCommandBarCheckItem36.CommandName = "ShowPivotTableFieldHeaders";
		this.spreadsheetCommandBarCheckItem36.Id = 326;
		this.spreadsheetCommandBarCheckItem36.Name = "spreadsheetCommandBarCheckItem36";
		this.spreadsheetCommandBarSubItem36.CommandName = "PivotTableLayoutSubtotalsGroup";
		this.spreadsheetCommandBarSubItem36.Id = 327;
		this.spreadsheetCommandBarSubItem36.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[3]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem187),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem188),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem189)
		});
		this.spreadsheetCommandBarSubItem36.Name = "spreadsheetCommandBarSubItem36";
		this.spreadsheetCommandBarButtonItem187.CommandName = "PivotTableDoNotShowSubtotals";
		this.spreadsheetCommandBarButtonItem187.Id = 328;
		this.spreadsheetCommandBarButtonItem187.Name = "spreadsheetCommandBarButtonItem187";
		this.spreadsheetCommandBarButtonItem187.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem188.CommandName = "PivotTableShowAllSubtotalsAtBottom";
		this.spreadsheetCommandBarButtonItem188.Id = 329;
		this.spreadsheetCommandBarButtonItem188.Name = "spreadsheetCommandBarButtonItem188";
		this.spreadsheetCommandBarButtonItem188.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem189.CommandName = "PivotTableShowAllSubtotalsAtTop";
		this.spreadsheetCommandBarButtonItem189.Id = 330;
		this.spreadsheetCommandBarButtonItem189.Name = "spreadsheetCommandBarButtonItem189";
		this.spreadsheetCommandBarButtonItem189.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarSubItem37.CommandName = "PivotTableLayoutGrandTotalsGroup";
		this.spreadsheetCommandBarSubItem37.Id = 331;
		this.spreadsheetCommandBarSubItem37.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[4]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem190),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem191),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem192),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem193)
		});
		this.spreadsheetCommandBarSubItem37.Name = "spreadsheetCommandBarSubItem37";
		this.spreadsheetCommandBarButtonItem190.CommandName = "PivotTableGrandTotalsOffRowsColumns";
		this.spreadsheetCommandBarButtonItem190.Id = 332;
		this.spreadsheetCommandBarButtonItem190.Name = "spreadsheetCommandBarButtonItem190";
		this.spreadsheetCommandBarButtonItem190.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem191.CommandName = "PivotTableGrandTotalsOnRowsColumns";
		this.spreadsheetCommandBarButtonItem191.Id = 333;
		this.spreadsheetCommandBarButtonItem191.Name = "spreadsheetCommandBarButtonItem191";
		this.spreadsheetCommandBarButtonItem191.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem192.CommandName = "PivotTableGrandTotalsOnRowsOnly";
		this.spreadsheetCommandBarButtonItem192.Id = 334;
		this.spreadsheetCommandBarButtonItem192.Name = "spreadsheetCommandBarButtonItem192";
		this.spreadsheetCommandBarButtonItem192.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem193.CommandName = "PivotTableGrandTotalsOnColumnsOnly";
		this.spreadsheetCommandBarButtonItem193.Id = 335;
		this.spreadsheetCommandBarButtonItem193.Name = "spreadsheetCommandBarButtonItem193";
		this.spreadsheetCommandBarButtonItem193.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarSubItem38.CommandName = "PivotTableLayoutReportLayoutGroup";
		this.spreadsheetCommandBarSubItem38.Id = 336;
		this.spreadsheetCommandBarSubItem38.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[5]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem194),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem195),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem196),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem197),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem198)
		});
		this.spreadsheetCommandBarSubItem38.Name = "spreadsheetCommandBarSubItem38";
		this.spreadsheetCommandBarButtonItem194.CommandName = "PivotTableShowCompactForm";
		this.spreadsheetCommandBarButtonItem194.Id = 337;
		this.spreadsheetCommandBarButtonItem194.Name = "spreadsheetCommandBarButtonItem194";
		this.spreadsheetCommandBarButtonItem194.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem195.CommandName = "PivotTableShowOutlineForm";
		this.spreadsheetCommandBarButtonItem195.Id = 338;
		this.spreadsheetCommandBarButtonItem195.Name = "spreadsheetCommandBarButtonItem195";
		this.spreadsheetCommandBarButtonItem195.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem196.CommandName = "PivotTableShowTabularForm";
		this.spreadsheetCommandBarButtonItem196.Id = 339;
		this.spreadsheetCommandBarButtonItem196.Name = "spreadsheetCommandBarButtonItem196";
		this.spreadsheetCommandBarButtonItem196.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem197.CommandName = "PivotTableRepeatAllItemLabels";
		this.spreadsheetCommandBarButtonItem197.Id = 340;
		this.spreadsheetCommandBarButtonItem197.Name = "spreadsheetCommandBarButtonItem197";
		this.spreadsheetCommandBarButtonItem197.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem198.CommandName = "PivotTableDoNotRepeatItemLabels";
		this.spreadsheetCommandBarButtonItem198.Id = 341;
		this.spreadsheetCommandBarButtonItem198.Name = "spreadsheetCommandBarButtonItem198";
		this.spreadsheetCommandBarButtonItem198.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarSubItem39.CommandName = "PivotTableLayoutBlankRowsGroup";
		this.spreadsheetCommandBarSubItem39.Id = 342;
		this.spreadsheetCommandBarSubItem39.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem199),
			new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem200)
		});
		this.spreadsheetCommandBarSubItem39.Name = "spreadsheetCommandBarSubItem39";
		this.spreadsheetCommandBarButtonItem199.CommandName = "PivotTableInsertBlankLineEachItem";
		this.spreadsheetCommandBarButtonItem199.Id = 343;
		this.spreadsheetCommandBarButtonItem199.Name = "spreadsheetCommandBarButtonItem199";
		this.spreadsheetCommandBarButtonItem199.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarButtonItem200.CommandName = "PivotTableRemoveBlankLineEachItem";
		this.spreadsheetCommandBarButtonItem200.Id = 344;
		this.spreadsheetCommandBarButtonItem200.Name = "spreadsheetCommandBarButtonItem200";
		this.spreadsheetCommandBarButtonItem200.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
		this.spreadsheetCommandBarCheckItem37.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
		this.spreadsheetCommandBarCheckItem37.CommandName = "PivotTableToggleRowHeaders";
		this.spreadsheetCommandBarCheckItem37.Id = 345;
		this.spreadsheetCommandBarCheckItem37.Name = "spreadsheetCommandBarCheckItem37";
		this.spreadsheetCommandBarCheckItem38.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
		this.spreadsheetCommandBarCheckItem38.CommandName = "PivotTableToggleColumnHeaders";
		this.spreadsheetCommandBarCheckItem38.Id = 346;
		this.spreadsheetCommandBarCheckItem38.Name = "spreadsheetCommandBarCheckItem38";
		this.spreadsheetCommandBarCheckItem39.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
		this.spreadsheetCommandBarCheckItem39.CommandName = "PivotTableToggleBandedRows";
		this.spreadsheetCommandBarCheckItem39.Id = 347;
		this.spreadsheetCommandBarCheckItem39.Name = "spreadsheetCommandBarCheckItem39";
		this.spreadsheetCommandBarCheckItem40.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
		this.spreadsheetCommandBarCheckItem40.CommandName = "PivotTableToggleBandedColumns";
		this.spreadsheetCommandBarCheckItem40.Id = 348;
		this.spreadsheetCommandBarCheckItem40.Name = "spreadsheetCommandBarCheckItem40";
		this.galleryPivotStylesItem1.Gallery.ColumnCount = 7;
		this.galleryPivotStylesItem1.Gallery.DrawImageBackground = false;
		this.galleryPivotStylesItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
		this.galleryPivotStylesItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
		this.galleryPivotStylesItem1.Gallery.ItemSize = new System.Drawing.Size(73, 61);
		this.galleryPivotStylesItem1.Gallery.RowCount = 10;
		this.galleryPivotStylesItem1.Id = 349;
		this.galleryPivotStylesItem1.Name = "galleryPivotStylesItem1";
		this.barButtonItem2.Caption = "Sans Formule";
		this.barButtonItem2.Id = 350;
		this.barButtonItem2.ImageOptions.Image = compta.Properties.Resources.inserttableofequations_16x16;
		this.barButtonItem2.ImageOptions.LargeImage = compta.Properties.Resources.inserttableofequations_32x32;
		this.barButtonItem2.Name = "barButtonItem2";
		this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barButtonItem2_ItemClick);
		this.fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[3] { this.commonRibbonPageGroup1, this.infoRibbonPageGroup1, this.ribbonPageGroup1 });
		this.fileRibbonPage1.Name = "fileRibbonPage1";
		this.fileRibbonPage1.Text = "Fichier";
		this.commonRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem1);
		this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem2);
		this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem3);
		this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem4);
		this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem5);
		this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem6);
		this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem7);
		this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem8);
		this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem9);
		this.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1";
		this.infoRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.infoRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem10);
		this.infoRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem11);
		this.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1";
		this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
		this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
		this.ribbonPageGroup1.Name = "ribbonPageGroup1";
		this.ribbonPageGroup1.Text = "Enregistrement";
		this.homeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[7] { this.clipboardRibbonPageGroup1, this.fontRibbonPageGroup1, this.alignmentRibbonPageGroup1, this.numberRibbonPageGroup1, this.stylesRibbonPageGroup1, this.cellsRibbonPageGroup1, this.editingRibbonPageGroup1 });
		this.homeRibbonPage1.Name = "homeRibbonPage1";
		reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable;
		reduceOperation1.GroupName = "stylesRibbonPageGroup1";
		reduceOperation1.ItemLinkIndex = 2;
		reduceOperation1.ItemLinksCount = 0;
		reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery;
		this.homeRibbonPage1.ReduceOperations.Add(reduceOperation1);
		this.homeRibbonPage1.Text = "Format";
		this.clipboardRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.clipboardRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem27);
		this.clipboardRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem28);
		this.clipboardRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem29);
		this.clipboardRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem30);
		this.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1";
		this.clipboardRibbonPageGroup1.Text = "Presse-papiers";
		this.fontRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
		this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup1);
		this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup2);
		this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup3);
		this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup4);
		this.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1";
		this.alignmentRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
		this.alignmentRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup5);
		this.alignmentRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup6);
		this.alignmentRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup7);
		this.alignmentRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem14);
		this.alignmentRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem5);
		this.alignmentRibbonPageGroup1.Name = "alignmentRibbonPageGroup1";
		this.numberRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
		this.numberRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup8);
		this.numberRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup9);
		this.numberRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup10);
		this.numberRibbonPageGroup1.Name = "numberRibbonPageGroup1";
		this.stylesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.stylesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem10);
		this.stylesRibbonPageGroup1.ItemLinks.Add(this.galleryFormatAsTableItem1);
		this.stylesRibbonPageGroup1.ItemLinks.Add(this.galleryChangeStyleItem1);
		this.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1";
		this.cellsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.cellsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem11);
		this.cellsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem12);
		this.cellsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem14);
		this.cellsRibbonPageGroup1.Name = "cellsRibbonPageGroup1";
		this.editingRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.editingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem15);
		this.editingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem16);
		this.editingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem17);
		this.editingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem18);
		this.editingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem19);
		this.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1";
		this.formulasRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[4] { this.functionLibraryRibbonPageGroup1, this.formulaDefinedNamesRibbonPageGroup1, this.formulaAuditingRibbonPageGroup1, this.formulaCalculationRibbonPageGroup1 });
		this.formulasRibbonPage1.Name = "formulasRibbonPage1";
		this.formulasRibbonPage1.Text = "Formules";
		this.functionLibraryRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem1);
		this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsFinancialItem1);
		this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsLogicalItem1);
		this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsTextItem1);
		this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsDateAndTimeItem1);
		this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsLookupAndReferenceItem1);
		this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsMathAndTrigonometryItem1);
		this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem2);
		this.functionLibraryRibbonPageGroup1.Name = "functionLibraryRibbonPageGroup1";
		this.formulaDefinedNamesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem17);
		this.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem18);
		this.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(this.definedNameListItem1);
		this.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem19);
		this.formulaDefinedNamesRibbonPageGroup1.Name = "formulaDefinedNamesRibbonPageGroup1";
		this.formulaAuditingRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.formulaAuditingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem1);
		this.formulaAuditingRibbonPageGroup1.Name = "formulaAuditingRibbonPageGroup1";
		this.formulaCalculationRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.formulaCalculationRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem3);
		this.formulaCalculationRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem20);
		this.formulaCalculationRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem21);
		this.formulaCalculationRibbonPageGroup1.Name = "formulaCalculationRibbonPageGroup1";
		this.insertRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[5] { this.tablesRibbonPageGroup1, this.illustrationsRibbonPageGroup1, this.chartsRibbonPageGroup1, this.linksRibbonPageGroup1, this.symbolsRibbonPageGroup1 });
		this.insertRibbonPage1.Name = "insertRibbonPage1";
		this.tablesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.tablesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem22);
		this.tablesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem23);
		this.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1";
		this.illustrationsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.illustrationsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem24);
		this.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1";
		this.chartsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem1);
		this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem2);
		this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem3);
		this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem4);
		this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem5);
		this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem6);
		this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem7);
		this.chartsRibbonPageGroup1.Name = "chartsRibbonPageGroup1";
		this.linksRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.linksRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem25);
		this.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1";
		this.symbolsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.symbolsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem26);
		this.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1";
		this.viewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[3] { this.showRibbonPageGroup1, this.zoomRibbonPageGroup1, this.windowRibbonPageGroup1 });
		this.viewRibbonPage1.Name = "viewRibbonPage1";
		this.viewRibbonPage1.Text = "Vue";
		this.showRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.showRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem18);
		this.showRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem19);
		this.showRibbonPageGroup1.Name = "showRibbonPageGroup1";
		this.zoomRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.zoomRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem128);
		this.zoomRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem129);
		this.zoomRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem130);
		this.zoomRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem131);
		this.zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1";
		this.windowRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.windowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem20);
		this.windowRibbonPageGroup1.Name = "windowRibbonPageGroup1";
		this.pageLayoutRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[4] { this.pageSetupRibbonPageGroup1, this.pageSetupShowRibbonPageGroup1, this.pageSetupPrintRibbonPageGroup1, this.arrangeRibbonPageGroup1 });
		this.pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1";
		this.pageLayoutRibbonPage1.Text = "Mise en page";
		this.pageSetupRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
		this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem21);
		this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem22);
		this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.pageSetupPaperKindItem1);
		this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem23);
		this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem148);
		this.pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1";
		this.pageSetupShowRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.pageSetupShowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem18);
		this.pageSetupShowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem19);
		this.pageSetupShowRibbonPageGroup1.Name = "pageSetupShowRibbonPageGroup1";
		this.pageSetupPrintRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
		this.pageSetupPrintRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem25);
		this.pageSetupPrintRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem26);
		this.pageSetupPrintRibbonPageGroup1.Name = "pageSetupPrintRibbonPageGroup1";
		this.arrangeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
		this.arrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem24);
		this.arrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem25);
		this.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1";
		this.ribbonStatusBar1.ItemLinks.Add(this.averageInfoStaticItem1);
		this.ribbonStatusBar1.ItemLinks.Add(this.countInfoStaticItem1);
		this.ribbonStatusBar1.ItemLinks.Add(this.numericalCountInfoStaticItem1);
		this.ribbonStatusBar1.ItemLinks.Add(this.minInfoStaticItem1);
		this.ribbonStatusBar1.ItemLinks.Add(this.maxInfoStaticItem1);
		this.ribbonStatusBar1.ItemLinks.Add(this.sumInfoStaticItem1);
		this.ribbonStatusBar1.ItemLinks.Add(this.zoomEditItem1);
		this.ribbonStatusBar1.ItemLinks.Add(this.showZoomButtonItem1);
		this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 498);
		this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(2);
		this.ribbonStatusBar1.Name = "ribbonStatusBar1";
		this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
		this.ribbonStatusBar1.Size = new System.Drawing.Size(1106, 24);
		this.spreadsheetFormulaBar1.Dock = System.Windows.Forms.DockStyle.Top;
		this.spreadsheetFormulaBar1.Location = new System.Drawing.Point(0, 142);
		this.spreadsheetFormulaBar1.MinimumSize = new System.Drawing.Size(0, 17);
		this.spreadsheetFormulaBar1.Name = "spreadsheetFormulaBar1";
		this.spreadsheetFormulaBar1.Size = new System.Drawing.Size(1106, 24);
		this.spreadsheetFormulaBar1.SpreadsheetControl = this.spreadsheetControl1;
		this.spreadsheetFormulaBar1.TabIndex = 2;
		this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
		this.splitterControl1.Location = new System.Drawing.Point(0, 166);
		this.splitterControl1.Margin = new System.Windows.Forms.Padding(2);
		this.splitterControl1.MinSize = 20;
		this.splitterControl1.Name = "splitterControl1";
		this.splitterControl1.Size = new System.Drawing.Size(1106, 6);
		this.splitterControl1.TabIndex = 1;
		this.splitterControl1.TabStop = false;
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem1);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem2);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem3);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem4);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem5);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem6);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem7);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem8);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem9);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem10);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem11);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem12);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem13);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem14);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem15);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem16);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem1);
		this.spreadsheetBarController1.BarItems.Add(this.functionsFinancialItem1);
		this.spreadsheetBarController1.BarItems.Add(this.functionsLogicalItem1);
		this.spreadsheetBarController1.BarItems.Add(this.functionsTextItem1);
		this.spreadsheetBarController1.BarItems.Add(this.functionsDateAndTimeItem1);
		this.spreadsheetBarController1.BarItems.Add(this.functionsLookupAndReferenceItem1);
		this.spreadsheetBarController1.BarItems.Add(this.functionsMathAndTrigonometryItem1);
		this.spreadsheetBarController1.BarItems.Add(this.functionsStatisticalItem1);
		this.spreadsheetBarController1.BarItems.Add(this.functionsEngineeringItem1);
		this.spreadsheetBarController1.BarItems.Add(this.functionsInformationItem1);
		this.spreadsheetBarController1.BarItems.Add(this.functionsCompatibilityItem1);
		this.spreadsheetBarController1.BarItems.Add(this.functionsWebItem1);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem2);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem17);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem18);
		this.spreadsheetBarController1.BarItems.Add(this.definedNameListItem1);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem19);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem1);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem2);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem3);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem3);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem20);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem21);
		this.spreadsheetBarController1.BarItems.Add(this.averageInfoStaticItem1);
		this.spreadsheetBarController1.BarItems.Add(this.countInfoStaticItem1);
		this.spreadsheetBarController1.BarItems.Add(this.numericalCountInfoStaticItem1);
		this.spreadsheetBarController1.BarItems.Add(this.minInfoStaticItem1);
		this.spreadsheetBarController1.BarItems.Add(this.maxInfoStaticItem1);
		this.spreadsheetBarController1.BarItems.Add(this.sumInfoStaticItem1);
		this.spreadsheetBarController1.BarItems.Add(this.zoomEditItem1);
		this.spreadsheetBarController1.BarItems.Add(this.showZoomButtonItem1);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem22);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem23);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem24);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem1);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem2);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem3);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem4);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem5);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem6);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem7);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem25);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem26);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem27);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem28);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem29);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem30);
		this.spreadsheetBarController1.BarItems.Add(this.changeFontNameItem1);
		this.spreadsheetBarController1.BarItems.Add(this.changeFontSizeItem1);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem31);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem32);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem4);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem5);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem6);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem7);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem33);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem34);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem35);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem36);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem37);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem38);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem39);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem40);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem41);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem42);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem43);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem44);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem45);
		this.spreadsheetBarController1.BarItems.Add(this.changeBorderLineColorItem1);
		this.spreadsheetBarController1.BarItems.Add(this.changeBorderLineStyleItem1);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem4);
		this.spreadsheetBarController1.BarItems.Add(this.changeCellFillColorItem1);
		this.spreadsheetBarController1.BarItems.Add(this.changeFontColorItem1);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem8);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem9);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem10);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem11);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem12);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem13);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem46);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem47);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem14);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem15);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem48);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem49);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem50);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem5);
		this.spreadsheetBarController1.BarItems.Add(this.changeNumberFormatItem1);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem51);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem52);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem53);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem54);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem55);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem56);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem6);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem57);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem58);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem59);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem60);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem61);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem62);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem63);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem64);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem65);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem66);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem67);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem7);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem68);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem69);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem70);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem71);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem72);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem73);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem8);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem8);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem9);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem10);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem74);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem75);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem76);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem9);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem77);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem10);
		this.spreadsheetBarController1.BarItems.Add(this.galleryFormatAsTableItem1);
		this.spreadsheetBarController1.BarItems.Add(this.galleryChangeStyleItem1);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem78);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem79);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem80);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem81);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem82);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem83);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem84);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem85);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem11);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem86);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem87);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem88);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem89);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem90);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem91);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem12);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem92);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem93);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem94);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem95);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem96);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem97);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem98);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem99);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem100);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem101);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem102);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem13);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem103);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem104);
		this.spreadsheetBarController1.BarItems.Add(this.changeSheetTabColorItem1);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem105);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem16);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem106);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem14);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem15);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem107);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem108);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem109);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem110);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem16);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem111);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem112);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem113);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem114);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem115);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem116);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem17);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem117);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem118);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem17);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem119);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem120);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem18);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem121);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem122);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem123);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem124);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem125);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem126);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem127);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem19);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem18);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem19);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem128);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem129);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem130);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem131);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem132);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem133);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem134);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem135);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem20);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem136);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem137);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem138);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem139);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem140);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem141);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem142);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem143);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem20);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem21);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem22);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem144);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem21);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem23);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem24);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem22);
		this.spreadsheetBarController1.BarItems.Add(this.pageSetupPaperKindItem1);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem145);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem146);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem147);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem23);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem148);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem25);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem26);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem149);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem150);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem24);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem151);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem152);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem25);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem153);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem154);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem155);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem26);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem156);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem157);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem27);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem158);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem159);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem28);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem160);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem161);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem162);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem163);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem164);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem165);
		this.spreadsheetBarController1.BarItems.Add(this.galleryChartLayoutItem1);
		this.spreadsheetBarController1.BarItems.Add(this.galleryChartStyleItem1);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem166);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem11);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem12);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem29);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem13);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem14);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem30);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem15);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem16);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem17);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem31);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem18);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem19);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem20);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem21);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem22);
		this.spreadsheetBarController1.BarItems.Add(this.renameTableItemCaption1);
		this.spreadsheetBarController1.BarItems.Add(this.renameTableItem1);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem27);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem28);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem29);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem30);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem31);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem32);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem33);
		this.spreadsheetBarController1.BarItems.Add(this.galleryTableStylesItem1);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem167);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem168);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem169);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem170);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem171);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem172);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem173);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem174);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem175);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem32);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem176);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem177);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem178);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem33);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem179);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem180);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem181);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem34);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem182);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem183);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem184);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem185);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem186);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem35);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem34);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem35);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem36);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem187);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem188);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem189);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem36);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem190);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem191);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem192);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem193);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem37);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem194);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem195);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem196);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem197);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem198);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem38);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem199);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem200);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem39);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem37);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem38);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem39);
		this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem40);
		this.spreadsheetBarController1.BarItems.Add(this.galleryPivotStylesItem1);
		this.spreadsheetBarController1.Control = this.spreadsheetControl1;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1106, 522);
		base.Controls.Add(this.spreadsheetControl1);
		base.Controls.Add(this.splitterControl1);
		base.Controls.Add(this.spreadsheetFormulaBar1);
		base.Controls.Add(this.ribbonControl1);
		base.Controls.Add(this.ribbonStatusBar1);
		base.Margin = new System.Windows.Forms.Padding(2);
		base.Name = "frmExcel";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "ETATS DIVERS";
		base.Load += new System.EventHandler(frmExcel_Load);
		((System.ComponentModel.ISupportInitialize)this.ribbonControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemZoomTrackBar1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown7).EndInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemFontEdit1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemSpreadsheetFontSizeEdit1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown8).EndInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemPopupGalleryEdit1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown9).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown10).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown11).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown12).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown13).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown14).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown15).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown16).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown17).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown18).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown19).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown20).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown21).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown22).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown23).EndInit();
		((System.ComponentModel.ISupportInitialize)this.commandBarGalleryDropDown24).EndInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemTextEdit1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.spreadsheetBarController1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
