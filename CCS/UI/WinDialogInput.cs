﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Hong.Common.SystemWin
{
	public class WinDialogInput
	{
		public static string ShowInput(string Caption, string Hint, string Default)
		{
			Form InputForm = new Form();
			InputForm.MinimizeBox = false;
			InputForm.MaximizeBox = false;
			InputForm.StartPosition = FormStartPosition.CenterScreen;
			InputForm.Width = 220;
			InputForm.Height = 150;

			InputForm.Text = Caption;
			Label lbl = new Label();
			lbl.Text = Hint;
			lbl.Left = 10;
			lbl.Top = 20;
			lbl.Parent = InputForm;
			lbl.AutoSize = true;
			TextBox tb = new TextBox();
			tb.Left = 30;
			tb.Top = 45;
			tb.Width = 160;
			tb.Parent = InputForm;
			tb.Text = Default;
			tb.SelectAll();
			Button btnok = new Button();
			btnok.Left = 30;
			btnok.Top = 80;
			btnok.Parent = InputForm;
			btnok.Text = "确定";
			InputForm.AcceptButton = btnok;//回车响应

			btnok.DialogResult = DialogResult.OK;
			Button btncancal = new Button();
			btncancal.Left = 120;
			btncancal.Top = 80;
			btncancal.Parent = InputForm;
			btncancal.Text = "取消";
			btncancal.DialogResult = DialogResult.Cancel;
			try
			{
				if (InputForm.ShowDialog() == DialogResult.OK)
				{
					return tb.Text;
				}
				else
				{
					return null;
				}
			}
			finally
			{
				InputForm.Dispose();
			}
		}
	}
}
