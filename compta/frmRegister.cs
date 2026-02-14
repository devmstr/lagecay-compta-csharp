using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace compta;

public class frmRegister : XtraForm
{
	private string fic = "";

	private IContainer components;

	private TextEdit votreID;

	private ButtonEdit textEdit2;

	private LabelControl labelControl1;

	private LabelControl labelControl2;

	private SimpleButton simpleButton2;

	private SimpleButton simpleButton1;

	private LabelControl txtmsg;

	private PictureBox pictureBox1;

	public frmRegister()
	{
		InitializeComponent();
	}

	public frmRegister(string ID, string msg = "")
	{
		InitializeComponent();
		votreID.Text = ID;
		txtmsg.Text = msg;
	}

	private void textEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
	{
		OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
		OpenFileDialog1.ShowDialog(this);
		if (OpenFileDialog1.FileName != "")
		{
			textEdit2.Text = OpenFileDialog1.FileName;
			fic = OpenFileDialog1.FileName;
		}
	}

	private void simpleButton1_Click(object sender, EventArgs e)
	{
		if (fic != "")
		{
			try
			{
				File.Copy(fic, AppDomain.CurrentDomain.BaseDirectory + "\\license.license", overwrite: true);
				monModule.gRestart = true;
			}
			catch (IOException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		Close();
	}

	private void simpleButton2_Click(object sender, EventArgs e)
	{
		Close();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compta.frmRegister));
		this.votreID = new DevExpress.XtraEditors.TextEdit();
		this.textEdit2 = new DevExpress.XtraEditors.ButtonEdit();
		this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
		this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
		this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
		this.txtmsg = new DevExpress.XtraEditors.LabelControl();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.votreID.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit2.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.votreID.Location = new System.Drawing.Point(5, 59);
		this.votreID.Margin = new System.Windows.Forms.Padding(2);
		this.votreID.Name = "votreID";
		this.votreID.Properties.Appearance.Options.UseTextOptions = true;
		this.votreID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.votreID.Size = new System.Drawing.Size(256, 20);
		this.votreID.TabIndex = 6;
		this.textEdit2.Location = new System.Drawing.Point(5, 82);
		this.textEdit2.Margin = new System.Windows.Forms.Padding(2);
		this.textEdit2.Name = "textEdit2";
		this.textEdit2.Properties.Appearance.Options.UseTextOptions = true;
		this.textEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.textEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton()
		});
		this.textEdit2.Size = new System.Drawing.Size(256, 20);
		this.textEdit2.TabIndex = 7;
		this.textEdit2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(textEdit2_ButtonClick);
		this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
		this.labelControl1.Appearance.Options.UseForeColor = true;
		this.labelControl1.Location = new System.Drawing.Point(5, 61);
		this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
		this.labelControl1.Name = "labelControl1";
		this.labelControl1.Size = new System.Drawing.Size(43, 13);
		this.labelControl1.TabIndex = 11;
		this.labelControl1.Text = "Votre ID ";
		this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
		this.labelControl2.Appearance.Options.UseForeColor = true;
		this.labelControl2.Location = new System.Drawing.Point(5, 84);
		this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
		this.labelControl2.Name = "labelControl2";
		this.labelControl2.Size = new System.Drawing.Size(35, 13);
		this.labelControl2.TabIndex = 12;
		this.labelControl2.Text = "Licence";
		this.simpleButton2.Location = new System.Drawing.Point(5, 104);
		this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
		this.simpleButton2.Name = "simpleButton2";
		this.simpleButton2.Size = new System.Drawing.Size(100, 17);
		this.simpleButton2.TabIndex = 13;
		this.simpleButton2.Text = "Continuer";
		this.simpleButton2.Click += new System.EventHandler(simpleButton2_Click);
		this.simpleButton1.Location = new System.Drawing.Point(161, 104);
		this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
		this.simpleButton1.Name = "simpleButton1";
		this.simpleButton1.Size = new System.Drawing.Size(100, 17);
		this.simpleButton1.TabIndex = 14;
		this.simpleButton1.Text = "Enregistrer";
		this.simpleButton1.Click += new System.EventHandler(simpleButton1_Click);
		this.txtmsg.Appearance.Options.UseTextOptions = true;
		this.txtmsg.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.txtmsg.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
		this.txtmsg.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
		this.txtmsg.Location = new System.Drawing.Point(56, 9);
		this.txtmsg.Margin = new System.Windows.Forms.Padding(2);
		this.txtmsg.MaximumSize = new System.Drawing.Size(195, 43);
		this.txtmsg.MinimumSize = new System.Drawing.Size(150, 43);
		this.txtmsg.Name = "txtmsg";
		this.txtmsg.Size = new System.Drawing.Size(195, 43);
		this.txtmsg.TabIndex = 15;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(-2, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(50, 54);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 16;
		this.pictureBox1.TabStop = false;
		base.Appearance.BackColor = System.Drawing.SystemColors.Control;
		base.Appearance.Options.UseBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(267, 130);
		base.Controls.Add(this.pictureBox1);
		base.Controls.Add(this.txtmsg);
		base.Controls.Add(this.simpleButton1);
		base.Controls.Add(this.simpleButton2);
		base.Controls.Add(this.labelControl2);
		base.Controls.Add(this.labelControl1);
		base.Controls.Add(this.votreID);
		base.Controls.Add(this.textEdit2);
		base.Margin = new System.Windows.Forms.Padding(2);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmRegister";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "EldjawdaCompta Enregistrement ";
		((System.ComponentModel.ISupportInitialize)this.votreID.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit2.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
