namespace FillyFinagler
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			tabPage2 = new TabPage();
			tabPage3 = new TabPage();
			extras = new CheckBox();
			button1 = new Button();
			button2 = new Button();
			label1 = new Label();
			gameMode = new NumericUpDown();
			label2 = new Label();
			stageDropdown = new ComboBox();
			stage = new TextBox();
			lblEntrance = new Label();
			entrance = new TextBox();
			entranceDropdown = new ComboBox();
			label3 = new Label();
			experience = new NumericUpDown();
			difficulty = new NumericUpDown();
			label4 = new Label();
			panel1 = new Panel();
			lvMisc = new ListView();
			columnHeader3 = new ColumnHeader();
			lvGems = new ListView();
			columnHeader1 = new ColumnHeader();
			lvGold = new ListView();
			columnHeader2 = new ColumnHeader();
			lblMisc = new Label();
			lblGems = new Label();
			lblGold = new Label();
			head = new TextBox();
			headDropdown = new ComboBox();
			label5 = new Label();
			legs = new TextBox();
			legsDropdown = new ComboBox();
			label6 = new Label();
			color = new NumericUpDown();
			label7 = new Label();
			button3 = new Button();
			tabControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gameMode).BeginInit();
			((System.ComponentModel.ISupportInitialize)experience).BeginInit();
			((System.ComponentModel.ISupportInitialize)difficulty).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)color).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabPage3);
			tabControl1.Location = new Point(12, 48);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1724, 25);
			tabControl1.TabIndex = 0;
			tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
			// 
			// tabPage1
			// 
			tabPage1.Location = new Point(4, 25);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(1716, 0);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Save 1";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			tabPage2.Location = new Point(4, 25);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(1716, 0);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Save 2";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			tabPage3.Location = new Point(4, 25);
			tabPage3.Name = "tabPage3";
			tabPage3.Size = new Size(1716, 0);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "Save 3";
			tabPage3.UseVisualStyleBackColor = true;
			// 
			// extras
			// 
			extras.AutoSize = true;
			extras.Location = new Point(16, 12);
			extras.Name = "extras";
			extras.Size = new Size(57, 20);
			extras.TabIndex = 1;
			extras.Text = "Extras";
			extras.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button1.AutoSize = true;
			button1.Location = new Point(1050, 10);
			button1.Name = "button1";
			button1.Size = new Size(88, 26);
			button1.TabIndex = 2;
			button1.Text = "Read Registry";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button2.AutoSize = true;
			button2.Location = new Point(969, 10);
			button2.Name = "button2";
			button2.Size = new Size(75, 26);
			button2.TabIndex = 3;
			button2.Text = "Write Save";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(16, 82);
			label1.Name = "label1";
			label1.Size = new Size(68, 16);
			label1.TabIndex = 4;
			label1.Text = "GameMode";
			// 
			// gameMode
			// 
			gameMode.Location = new Point(90, 80);
			gameMode.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
			gameMode.Minimum = new decimal(new int[] { 256, 0, 0, int.MinValue });
			gameMode.Name = "gameMode";
			gameMode.Size = new Size(37, 23);
			gameMode.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(16, 112);
			label2.Name = "label2";
			label2.Size = new Size(36, 16);
			label2.TabIndex = 6;
			label2.Text = "Stage";
			// 
			// stageDropdown
			// 
			stageDropdown.FormattingEnabled = true;
			stageDropdown.Location = new Point(196, 107);
			stageDropdown.Name = "stageDropdown";
			stageDropdown.Size = new Size(121, 24);
			stageDropdown.TabIndex = 7;
			stageDropdown.SelectedIndexChanged += stageDropdown_SelectedIndexChanged;
			// 
			// stage
			// 
			stage.Location = new Point(90, 108);
			stage.Name = "stage";
			stage.Size = new Size(100, 23);
			stage.TabIndex = 8;
			// 
			// lblEntrance
			// 
			lblEntrance.AutoSize = true;
			lblEntrance.Location = new Point(16, 138);
			lblEntrance.Name = "lblEntrance";
			lblEntrance.Size = new Size(53, 16);
			lblEntrance.TabIndex = 9;
			lblEntrance.Text = "Entrance";
			// 
			// entrance
			// 
			entrance.Location = new Point(90, 134);
			entrance.Name = "entrance";
			entrance.Size = new Size(100, 23);
			entrance.TabIndex = 11;
			// 
			// entranceDropdown
			// 
			entranceDropdown.FormattingEnabled = true;
			entranceDropdown.Location = new Point(196, 133);
			entranceDropdown.Name = "entranceDropdown";
			entranceDropdown.Size = new Size(121, 24);
			entranceDropdown.TabIndex = 10;
			entranceDropdown.SelectedIndexChanged += entranceDropdown_SelectedIndexChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(16, 166);
			label3.Name = "label3";
			label3.Size = new Size(64, 16);
			label3.TabIndex = 12;
			label3.Text = "Experience";
			// 
			// experience
			// 
			experience.Location = new Point(90, 163);
			experience.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
			experience.Minimum = new decimal(new int[] { 65534, 0, 0, int.MinValue });
			experience.Name = "experience";
			experience.Size = new Size(100, 23);
			experience.TabIndex = 13;
			// 
			// difficulty
			// 
			difficulty.Location = new Point(90, 192);
			difficulty.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
			difficulty.Minimum = new decimal(new int[] { 256, 0, 0, int.MinValue });
			difficulty.Name = "difficulty";
			difficulty.Size = new Size(37, 23);
			difficulty.TabIndex = 15;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(16, 195);
			label4.Name = "label4";
			label4.Size = new Size(55, 16);
			label4.TabIndex = 14;
			label4.Text = "Difficulty";
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			panel1.BackColor = SystemColors.ControlLight;
			panel1.Controls.Add(lvMisc);
			panel1.Controls.Add(lvGems);
			panel1.Controls.Add(lvGold);
			panel1.Controls.Add(lblMisc);
			panel1.Controls.Add(lblGems);
			panel1.Controls.Add(lblGold);
			panel1.Location = new Point(374, 79);
			panel1.Name = "panel1";
			panel1.Size = new Size(780, 359);
			panel1.TabIndex = 16;
			// 
			// lvMisc
			// 
			lvMisc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			lvMisc.CheckBoxes = true;
			lvMisc.Columns.AddRange(new ColumnHeader[] { columnHeader3 });
			lvMisc.Location = new Point(521, 27);
			lvMisc.Name = "lvMisc";
			lvMisc.Size = new Size(256, 329);
			lvMisc.TabIndex = 5;
			lvMisc.UseCompatibleStateImageBehavior = false;
			lvMisc.View = View.List;
			// 
			// columnHeader3
			// 
			columnHeader3.Width = 256;
			// 
			// lvGems
			// 
			lvGems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			lvGems.CheckBoxes = true;
			lvGems.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
			lvGems.Location = new Point(262, 27);
			lvGems.Margin = new Padding(3, 3, 0, 3);
			lvGems.Name = "lvGems";
			lvGems.Size = new Size(256, 329);
			lvGems.TabIndex = 4;
			lvGems.UseCompatibleStateImageBehavior = false;
			lvGems.View = View.List;
			// 
			// columnHeader1
			// 
			columnHeader1.Width = 256;
			// 
			// lvGold
			// 
			lvGold.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lvGold.CheckBoxes = true;
			lvGold.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
			lvGold.Location = new Point(3, 27);
			lvGold.Margin = new Padding(3, 3, 0, 3);
			lvGold.Name = "lvGold";
			lvGold.Size = new Size(256, 329);
			lvGold.TabIndex = 3;
			lvGold.UseCompatibleStateImageBehavior = false;
			lvGold.View = View.List;
			// 
			// columnHeader2
			// 
			columnHeader2.Width = 256;
			// 
			// lblMisc
			// 
			lblMisc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			lblMisc.Location = new Point(521, 8);
			lblMisc.Name = "lblMisc";
			lblMisc.Size = new Size(256, 16);
			lblMisc.TabIndex = 2;
			lblMisc.Text = "Misc";
			lblMisc.TextAlign = ContentAlignment.TopCenter;
			// 
			// lblGems
			// 
			lblGems.Anchor = AnchorStyles.Top;
			lblGems.Location = new Point(262, 8);
			lblGems.Name = "lblGems";
			lblGems.Size = new Size(256, 16);
			lblGems.TabIndex = 1;
			lblGems.Text = "Gems and Moves";
			lblGems.TextAlign = ContentAlignment.TopCenter;
			lblGems.Click += lblGems_Click;
			// 
			// lblGold
			// 
			lblGold.Location = new Point(3, 8);
			lblGold.Name = "lblGold";
			lblGold.Size = new Size(256, 16);
			lblGold.TabIndex = 0;
			lblGold.Text = "Gold";
			lblGold.TextAlign = ContentAlignment.TopCenter;
			// 
			// head
			// 
			head.Location = new Point(90, 221);
			head.Name = "head";
			head.Size = new Size(100, 23);
			head.TabIndex = 19;
			// 
			// headDropdown
			// 
			headDropdown.FormattingEnabled = true;
			headDropdown.Location = new Point(196, 220);
			headDropdown.Name = "headDropdown";
			headDropdown.Size = new Size(121, 24);
			headDropdown.TabIndex = 18;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(16, 225);
			label5.Name = "label5";
			label5.Size = new Size(35, 16);
			label5.TabIndex = 17;
			label5.Text = "Head";
			// 
			// legs
			// 
			legs.Location = new Point(90, 250);
			legs.Name = "legs";
			legs.Size = new Size(100, 23);
			legs.TabIndex = 22;
			// 
			// legsDropdown
			// 
			legsDropdown.FormattingEnabled = true;
			legsDropdown.Location = new Point(196, 249);
			legsDropdown.Name = "legsDropdown";
			legsDropdown.Size = new Size(121, 24);
			legsDropdown.TabIndex = 21;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(16, 254);
			label6.Name = "label6";
			label6.Size = new Size(37, 16);
			label6.TabIndex = 20;
			label6.Text = "Socks";
			// 
			// color
			// 
			color.Location = new Point(90, 279);
			color.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
			color.Minimum = new decimal(new int[] { 256, 0, 0, int.MinValue });
			color.Name = "color";
			color.Size = new Size(37, 23);
			color.TabIndex = 24;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(16, 282);
			label7.Name = "label7";
			label7.Size = new Size(35, 16);
			label7.TabIndex = 23;
			label7.Text = "Color";
			// 
			// button3
			// 
			button3.AutoSize = true;
			button3.Location = new Point(862, 10);
			button3.Name = "button3";
			button3.Size = new Size(101, 26);
			button3.TabIndex = 25;
			button3.Text = "Backup Registry";
			button3.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 16F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1166, 450);
			Controls.Add(button3);
			Controls.Add(color);
			Controls.Add(label7);
			Controls.Add(legs);
			Controls.Add(legsDropdown);
			Controls.Add(label6);
			Controls.Add(head);
			Controls.Add(headDropdown);
			Controls.Add(label5);
			Controls.Add(panel1);
			Controls.Add(difficulty);
			Controls.Add(label4);
			Controls.Add(experience);
			Controls.Add(label3);
			Controls.Add(entrance);
			Controls.Add(entranceDropdown);
			Controls.Add(lblEntrance);
			Controls.Add(stage);
			Controls.Add(stageDropdown);
			Controls.Add(label2);
			Controls.Add(gameMode);
			Controls.Add(label1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(extras);
			Controls.Add(tabControl1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			Text = "Filly Finagler";
			Load += Form1_Load;
			tabControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gameMode).EndInit();
			((System.ComponentModel.ISupportInitialize)experience).EndInit();
			((System.ComponentModel.ISupportInitialize)difficulty).EndInit();
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)color).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private CheckBox extras;
		private Button button1;
		private Button button2;
		private Label label1;
		private NumericUpDown gameMode;
		private Label label2;
		private ComboBox stageDropdown;
		private TextBox stage;
		private Label lblEntrance;
		private TextBox entrance;
		private ComboBox entranceDropdown;
		private Label label3;
		private NumericUpDown experience;
		private NumericUpDown difficulty;
		private Label label4;
		private Panel panel1;
		private TextBox head;
		private ComboBox headDropdown;
		private Label label5;
		private TextBox legs;
		private ComboBox legsDropdown;
		private Label label6;
		private NumericUpDown color;
		private Label label7;
		private Label lblGold;
		private Label lblGems;
		private Label lblMisc;
		private ListView lvMisc;
		private ListView lvGems;
		private ListView lvGold;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private Button button3;
		private ColumnHeader columnHeader3;
	}
}