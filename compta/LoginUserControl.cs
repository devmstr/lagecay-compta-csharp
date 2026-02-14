using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace compta;

public class LoginUserControl : XtraUserControl
{
	public LoginUserControl(string texte)
	{
		LayoutControl lc = new LayoutControl
		{
			Dock = DockStyle.Fill
		};
		LabelControl lab = new LabelControl
		{
			Text = texte
		};
		new SeparatorControl();
		lc.AddItem(string.Empty, lab);
		base.Controls.Add(lc);
		base.Height = 100;
		Dock = DockStyle.Top;
	}
}
