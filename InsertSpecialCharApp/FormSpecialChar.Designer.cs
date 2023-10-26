namespace InsertSpecialCharApp
{
	partial class FormSpecialChar
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			_btnInsert=new Button();
			_lblTNS=new Label();
			_lblUser=new Label();
			label1=new Label();
			_txtBoxTNS=new TextBox();
			_txtBoxUser=new TextBox();
			_txtBoxPassword=new TextBox();
			_txtBoxResult=new TextBox();
			_lblInsertedStatement=new Label();
			_btnSelect=new Button();
			_btnCreateTable=new Button();
			_txtBoxSpecialChar=new TextBox();
			_lblSpecialChar=new Label();
			buttonDropTable=new Button();
			SuspendLayout();
			// 
			// _btnInsert
			// 
			_btnInsert.Location=new Point(12, 159);
			_btnInsert.Name="_btnInsert";
			_btnInsert.Size=new Size(75, 23);
			_btnInsert.TabIndex=0;
			_btnInsert.Text="Insert";
			_btnInsert.UseVisualStyleBackColor=true;
			_btnInsert.Click+=buttonInsert_Click;
			// 
			// _lblTNS
			// 
			_lblTNS.AutoSize=true;
			_lblTNS.Location=new Point(12, 23);
			_lblTNS.Name="_lblTNS";
			_lblTNS.Size=new Size(63, 15);
			_lblTNS.TabIndex=1;
			_lblTNS.Text="TNS Name";
			// 
			// _lblUser
			// 
			_lblUser.AutoSize=true;
			_lblUser.Location=new Point(12, 53);
			_lblUser.Name="_lblUser";
			_lblUser.Size=new Size(30, 15);
			_lblUser.TabIndex=2;
			_lblUser.Text="User";
			// 
			// label1
			// 
			label1.AutoSize=true;
			label1.Location=new Point(12, 83);
			label1.Name="label1";
			label1.Size=new Size(57, 15);
			label1.TabIndex=3;
			label1.Text="Password";
			// 
			// _txtBoxTNS
			// 
			_txtBoxTNS.Location=new Point(98, 20);
			_txtBoxTNS.Name="_txtBoxTNS";
			_txtBoxTNS.Size=new Size(189, 23);
			_txtBoxTNS.TabIndex=4;
			// 
			// _txtBoxUser
			// 
			_txtBoxUser.Location=new Point(98, 50);
			_txtBoxUser.Name="_txtBoxUser";
			_txtBoxUser.Size=new Size(189, 23);
			_txtBoxUser.TabIndex=5;
			// 
			// _txtBoxPassword
			// 
			_txtBoxPassword.Location=new Point(98, 80);
			_txtBoxPassword.Name="_txtBoxPassword";
			_txtBoxPassword.Size=new Size(189, 23);
			_txtBoxPassword.TabIndex=6;
			// 
			// _txtBoxResult
			// 
			_txtBoxResult.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
			_txtBoxResult.Location=new Point(98, 188);
			_txtBoxResult.Multiline=true;
			_txtBoxResult.Name="_txtBoxResult";
			_txtBoxResult.Size=new Size(528, 252);
			_txtBoxResult.TabIndex=8;
			// 
			// _lblInsertedStatement
			// 
			_lblInsertedStatement.AutoSize=true;
			_lblInsertedStatement.Location=new Point(98, 159);
			_lblInsertedStatement.Name="_lblInsertedStatement";
			_lblInsertedStatement.Size=new Size(0, 15);
			_lblInsertedStatement.TabIndex=9;
			// 
			// _btnSelect
			// 
			_btnSelect.Location=new Point(12, 188);
			_btnSelect.Name="_btnSelect";
			_btnSelect.Size=new Size(75, 23);
			_btnSelect.TabIndex=10;
			_btnSelect.Text="Select";
			_btnSelect.UseVisualStyleBackColor=true;
			_btnSelect.Click+=_btnSelect_Click;
			// 
			// _btnCreateTable
			// 
			_btnCreateTable.Location=new Point(501, 12);
			_btnCreateTable.Name="_btnCreateTable";
			_btnCreateTable.Size=new Size(125, 23);
			_btnCreateTable.TabIndex=11;
			_btnCreateTable.Text="Create Table";
			_btnCreateTable.UseVisualStyleBackColor=true;
			_btnCreateTable.Click+=_btnCreateTable_Click;
			// 
			// _txtBoxSpecialChar
			// 
			_txtBoxSpecialChar.Location=new Point(98, 126);
			_txtBoxSpecialChar.Name="_txtBoxSpecialChar";
			_txtBoxSpecialChar.Size=new Size(69, 23);
			_txtBoxSpecialChar.TabIndex=13;
			_txtBoxSpecialChar.Text="œ";
			// 
			// _lblSpecialChar
			// 
			_lblSpecialChar.AutoSize=true;
			_lblSpecialChar.Location=new Point(12, 129);
			_lblSpecialChar.Name="_lblSpecialChar";
			_lblSpecialChar.Size=new Size(72, 15);
			_lblSpecialChar.TabIndex=12;
			_lblSpecialChar.Text="Special Char";
			// 
			// buttonDropTable
			// 
			buttonDropTable.Location=new Point(501, 41);
			buttonDropTable.Name="buttonDropTable";
			buttonDropTable.Size=new Size(125, 23);
			buttonDropTable.TabIndex=14;
			buttonDropTable.Text="Drop Table";
			buttonDropTable.UseVisualStyleBackColor=true;
			buttonDropTable.Click+=buttonDropTable_Click;
			// 
			// FormSpecialChar
			// 
			AutoScaleDimensions=new SizeF(7F, 15F);
			AutoScaleMode=AutoScaleMode.Font;
			ClientSize=new Size(638, 452);
			Controls.Add(buttonDropTable);
			Controls.Add(_txtBoxSpecialChar);
			Controls.Add(_lblSpecialChar);
			Controls.Add(_btnCreateTable);
			Controls.Add(_btnSelect);
			Controls.Add(_lblInsertedStatement);
			Controls.Add(_txtBoxResult);
			Controls.Add(_txtBoxPassword);
			Controls.Add(_txtBoxUser);
			Controls.Add(_txtBoxTNS);
			Controls.Add(label1);
			Controls.Add(_lblUser);
			Controls.Add(_lblTNS);
			Controls.Add(_btnInsert);
			Name="FormSpecialChar";
			Text="Oracle Special Character Insert Test";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button _btnInsert;
		private Label _lblTNS;
		private Label _lblUser;
		private Label label1;
		private TextBox _txtBoxTNS;
		private TextBox _txtBoxUser;
		private TextBox _txtBoxPassword;
		private TextBox _txtBoxResult;
		private Label _lblInsertedStatement;
		private Button _btnSelect;
		private Button _btnCreateTable;
		private TextBox _txtBoxSpecialChar;
		private Label _lblSpecialChar;
		private Button buttonDropTable;
	}
}