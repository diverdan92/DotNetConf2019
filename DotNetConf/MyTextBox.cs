using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace DotNetConf
{
	internal sealed class MyTextBox : TextBox
	{
		protected override void OnPreviewGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
		{
			e.Handled = true;
			base.OnPreviewGotKeyboardFocus(e);
		}
	}
}
