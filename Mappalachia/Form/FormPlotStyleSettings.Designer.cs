namespace Mappalachia
{
	partial class FormPlotStyleSettings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlotStyleSettings));
			this.checkBoxCrosshairOuter = new System.Windows.Forms.CheckBox();
			this.checkBoxCircle = new System.Windows.Forms.CheckBox();
			this.checkBoxCrosshairInner = new System.Windows.Forms.CheckBox();
			this.checkBoxSquare = new System.Windows.Forms.CheckBox();
			this.checkBoxDiamond = new System.Windows.Forms.CheckBox();
			this.buttonApply = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBoxColorPalette = new System.Windows.Forms.GroupBox();
			this.buttonRemoveColor = new System.Windows.Forms.Button();
			this.labelLoadPalette = new System.Windows.Forms.Label();
			this.comboBoxPalette = new System.Windows.Forms.ComboBox();
			this.buttonAddColor = new System.Windows.Forms.Button();
			this.listViewColorPalette = new System.Windows.Forms.ListView();
			this.labelOpacityShadow = new System.Windows.Forms.Label();
			this.labelOpacity = new System.Windows.Forms.Label();
			this.trackBarIconWidth = new System.Windows.Forms.TrackBar();
			this.labelIconWidth = new System.Windows.Forms.Label();
			this.trackBarIconSize = new System.Windows.Forms.TrackBar();
			this.labelIconSize = new System.Windows.Forms.Label();
			this.toolTipControls = new System.Windows.Forms.ToolTip(this.components);
			this.listViewShapePalette = new System.Windows.Forms.ListView();
			this.trackBarIconOpacity = new System.Windows.Forms.TrackBar();
			this.trackBarShadowOpacity = new System.Windows.Forms.TrackBar();
			this.buttonRemoveShape = new System.Windows.Forms.Button();
			this.buttonAddShape = new System.Windows.Forms.Button();
			this.buttonReset = new System.Windows.Forms.Button();
			this.checkBoxFill = new System.Windows.Forms.CheckBox();
			this.checkBoxMarker = new System.Windows.Forms.CheckBox();
			this.checkBoxFrame = new System.Windows.Forms.CheckBox();
			this.colorDialogPalette = new System.Windows.Forms.ColorDialog();
			this.groupBoxIconSettings = new System.Windows.Forms.GroupBox();
			this.groupBoxIconPalette = new System.Windows.Forms.GroupBox();
			this.groupBoxColorPalette.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarIconWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarIconSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarIconOpacity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarShadowOpacity)).BeginInit();
			this.groupBoxIconSettings.SuspendLayout();
			this.groupBoxIconPalette.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkBoxCrosshairOuter
			// 
			this.checkBoxCrosshairOuter.AutoSize = true;
			this.checkBoxCrosshairOuter.Location = new System.Drawing.Point(93, 114);
			this.checkBoxCrosshairOuter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.checkBoxCrosshairOuter.Name = "checkBoxCrosshairOuter";
			this.checkBoxCrosshairOuter.Size = new System.Drawing.Size(108, 19);
			this.checkBoxCrosshairOuter.TabIndex = 5;
			this.checkBoxCrosshairOuter.Text = "外部十字架";
			this.toolTipControls.SetToolTip(this.checkBoxCrosshairOuter, "从绘图图标中添加一个外部十字架");
			this.checkBoxCrosshairOuter.UseVisualStyleBackColor = true;
			// 
			// checkBoxCircle
			// 
			this.checkBoxCircle.AutoSize = true;
			this.checkBoxCircle.Location = new System.Drawing.Point(7, 139);
			this.checkBoxCircle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.checkBoxCircle.Name = "checkBoxCircle";
			this.checkBoxCircle.Size = new System.Drawing.Size(56, 19);
			this.checkBoxCircle.TabIndex = 3;
			this.checkBoxCircle.Text = "圆形";
			this.toolTipControls.SetToolTip(this.checkBoxCircle, "在绘图图标中添加一个圆形形状");
			this.checkBoxCircle.UseVisualStyleBackColor = true;
			// 
			// checkBoxCrosshairInner
			// 
			this.checkBoxCrosshairInner.AutoSize = true;
			this.checkBoxCrosshairInner.Location = new System.Drawing.Point(93, 89);
			this.checkBoxCrosshairInner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.checkBoxCrosshairInner.Name = "checkBoxCrosshairInner";
			this.checkBoxCrosshairInner.Size = new System.Drawing.Size(105, 19);
			this.checkBoxCrosshairInner.TabIndex = 4;
			this.checkBoxCrosshairInner.Text = "内部十字架";
			this.toolTipControls.SetToolTip(this.checkBoxCrosshairInner, "在绘图图标内部添加一个十字架");
			this.checkBoxCrosshairInner.UseVisualStyleBackColor = true;
			// 
			// checkBoxSquare
			// 
			this.checkBoxSquare.AutoSize = true;
			this.checkBoxSquare.Location = new System.Drawing.Point(7, 114);
			this.checkBoxSquare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.checkBoxSquare.Name = "checkBoxSquare";
			this.checkBoxSquare.Size = new System.Drawing.Size(62, 19);
			this.checkBoxSquare.TabIndex = 2;
			this.checkBoxSquare.Text = "方形";
			this.toolTipControls.SetToolTip(this.checkBoxSquare, "在绘图图标中添加一个方形形状");
			this.checkBoxSquare.UseVisualStyleBackColor = true;
			// 
			// checkBoxDiamond
			// 
			this.checkBoxDiamond.AutoSize = true;
			this.checkBoxDiamond.Location = new System.Drawing.Point(7, 89);
			this.checkBoxDiamond.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.checkBoxDiamond.Name = "checkBoxDiamond";
			this.checkBoxDiamond.Size = new System.Drawing.Size(75, 19);
			this.checkBoxDiamond.TabIndex = 1;
			this.checkBoxDiamond.Text = "菱形";
			this.toolTipControls.SetToolTip(this.checkBoxDiamond, "在绘图图标中添加一个菱形形状");
			this.checkBoxDiamond.UseVisualStyleBackColor = true;
			// 
			// buttonApply
			// 
			this.buttonApply.Location = new System.Drawing.Point(312, 396);
			this.buttonApply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(88, 27);
			this.buttonApply.TabIndex = 3;
			this.buttonApply.Text = "应用";
			this.toolTipControls.SetToolTip(this.buttonApply, "确认并应用这些设置");
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.ButtonApply_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(406, 396);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 27);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "取消";
			this.toolTipControls.SetToolTip(this.buttonCancel, "放弃任何更改");
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// groupBoxColorPalette
			// 
			this.groupBoxColorPalette.Controls.Add(this.buttonRemoveColor);
			this.groupBoxColorPalette.Controls.Add(this.labelLoadPalette);
			this.groupBoxColorPalette.Controls.Add(this.comboBoxPalette);
			this.groupBoxColorPalette.Controls.Add(this.buttonAddColor);
			this.groupBoxColorPalette.Controls.Add(this.listViewColorPalette);
			this.groupBoxColorPalette.Location = new System.Drawing.Point(14, 163);
			this.groupBoxColorPalette.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBoxColorPalette.Name = "groupBoxColorPalette";
			this.groupBoxColorPalette.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBoxColorPalette.Size = new System.Drawing.Size(244, 226);
			this.groupBoxColorPalette.TabIndex = 1;
			this.groupBoxColorPalette.TabStop = false;
			this.groupBoxColorPalette.Text = "颜色调色板";
			this.toolTipControls.SetToolTip(this.groupBoxColorPalette, "用于绘制不同项目的颜色集合");
			// 
			// buttonRemoveColor
			// 
			this.buttonRemoveColor.Location = new System.Drawing.Point(113, 189);
			this.buttonRemoveColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonRemoveColor.Name = "buttonRemoveColor";
			this.buttonRemoveColor.Size = new System.Drawing.Size(122, 27);
			this.buttonRemoveColor.TabIndex = 3;
			this.buttonRemoveColor.Text = "移除选定颜色";
			this.toolTipControls.SetToolTip(this.buttonRemoveColor, "从调色板中移除选定的颜色。");
			this.buttonRemoveColor.UseVisualStyleBackColor = true;
			this.buttonRemoveColor.Click += new System.EventHandler(this.ButtonRemoveColor_Click);
			// 
			// labelLoadPalette
			// 
			this.labelLoadPalette.AutoSize = true;
			this.labelLoadPalette.Location = new System.Drawing.Point(7, 18);
			this.labelLoadPalette.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelLoadPalette.Name = "labelLoadPalette";
			this.labelLoadPalette.Size = new System.Drawing.Size(68, 15);
			this.labelLoadPalette.TabIndex = 3;
			this.labelLoadPalette.Text = "加载预设";
			this.toolTipControls.SetToolTip(this.labelLoadPalette, "选择预制的颜色调色板。");
			// 
			// comboBoxPalette
			// 
			this.comboBoxPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPalette.FormattingEnabled = true;
			this.comboBoxPalette.Items.AddRange(new object[] {
			"默认",
			"色盲 (IBM)",
			"色盲 (Wong)",
			"色盲 (Tol)"});
			this.comboBoxPalette.Location = new System.Drawing.Point(7, 37);
			this.comboBoxPalette.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.comboBoxPalette.Name = "comboBoxPalette";
			this.comboBoxPalette.Size = new System.Drawing.Size(229, 23);
			this.comboBoxPalette.TabIndex = 0;
			this.toolTipControls.SetToolTip(this.comboBoxPalette, "选择预制的颜色调色板。");
			this.comboBoxPalette.SelectedIndexChanged += new System.EventHandler(this.ComboBoxColorPalette_SelectedIndexChanged);
			// 
			// buttonAddColor
			// 
			this.buttonAddColor.Location = new System.Drawing.Point(7, 189);
			this.buttonAddColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonAddColor.Name = "buttonAddColor";
			this.buttonAddColor.Size = new System.Drawing.Size(99, 27);
			this.buttonAddColor.TabIndex = 2;
			this.buttonAddColor.Text = "添加颜色";
			this.toolTipControls.SetToolTip(this.buttonAddColor, "选择要添加到调色板的新颜色。");
			this.buttonAddColor.UseVisualStyleBackColor = true;
			this.buttonAddColor.Click += new System.EventHandler(this.ButtonAddColor_Click);
			// 
			// listViewColorPalette
			// 
			this.listViewColorPalette.LabelWrap = false;
			this.listViewColorPalette.Location = new System.Drawing.Point(7, 68);
			this.listViewColorPalette.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.listViewColorPalette.Name = "listViewColorPalette";
			this.listViewColorPalette.Size = new System.Drawing.Size(229, 114);
			this.listViewColorPalette.TabIndex = 1;
			this.toolTipControls.SetToolTip(this.listViewColorPalette, "用于绘制不同项目的颜色集合。");
			this.listViewColorPalette.UseCompatibleStateImageBehavior = false;
			this.listViewColorPalette.View = System.Windows.Forms.View.SmallIcon;
			// 
			// labelOpacityShadow
			// 
			this.labelOpacityShadow.AutoSize = true;
			this.labelOpacityShadow.Location = new System.Drawing.Point(245, 81);
			this.labelOpacityShadow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelOpacityShadow.Name = "labelOpacityShadow";
			this.labelOpacityShadow.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelOpacityShadow.Size = new System.Drawing.Size(93, 15);
			this.labelOpacityShadow.TabIndex = 6;
			this.labelOpacityShadow.Text = "阴影透明度";
			this.toolTipControls.SetToolTip(this.labelOpacityShadow, "投射阴影的透明度（视觉上的暗度）。");
			// 
			// labelOpacity
			// 
			this.labelOpacity.AutoSize = true;
			this.labelOpacity.Location = new System.Drawing.Point(266, 22);
			this.labelOpacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelOpacity.Name = "labelOpacity";
			this.labelOpacity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelOpacity.Size = new System.Drawing.Size(74, 15);
			this.labelOpacity.TabIndex = 4;
			this.labelOpacity.Text = "图标透明度";
			this.toolTipControls.SetToolTip(this.labelOpacity, "图标的透明度。");
			// 
			// trackBarIconWidth
			// 
			this.trackBarIconWidth.LargeChange = 1;
			this.trackBarIconWidth.Location = new System.Drawing.Point(83, 81);
			this.trackBarIconWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.trackBarIconWidth.Name = "trackBarIconWidth";
			this.trackBarIconWidth.Size = new System.Drawing.Size(121, 45);
			this.trackBarIconWidth.TabIndex = 1;
			this.toolTipControls.SetToolTip(this.trackBarIconWidth, "形成绘图图标的线条（和阴影）的宽度。");
			this.trackBarIconWidth.Value = 1;
			// 
			// labelIconWidth
			// 
			this.labelIconWidth.AutoSize = true;
			this.labelIconWidth.Location = new System.Drawing.Point(7, 81);
			this.labelIconWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelIconWidth.Name = "labelIconWidth";
			this.labelIconWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelIconWidth.Size = new System.Drawing.Size(65, 15);
			this.labelIconWidth.TabIndex = 10;
			this.labelIconWidth.Text = "图标宽度";
			this.toolTipControls.SetToolTip(this.labelIconWidth, "形成绘图图标的线条（和阴影）的宽度。");
			// 
			// trackBarIconSize
			// 
			this.trackBarIconSize.LargeChange = 3;
			this.trackBarIconSize.Location = new System.Drawing.Point(83, 22);
			this.trackBarIconSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.trackBarIconSize.Name = "trackBarIconSize";
			this.trackBarIconSize.Size = new System.Drawing.Size(121, 45);
			this.trackBarIconSize.TabIndex = 0;
			this.toolTipControls.SetToolTip(this.trackBarIconSize, "绘图图标的最大直径。");
			this.trackBarIconSize.Value = 1;
			// 
			// labelIconSize
			// 
			this.labelIconSize.AutoSize = true;
			this.labelIconSize.Location = new System.Drawing.Point(16, 22);
			this.labelIconSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelIconSize.Name = "labelIconSize";
			this.labelIconSize.Size = new System.Drawing.Size(53, 15);
			this.labelIconSize.TabIndex = 10;
			this.labelIconSize.Text = "图标大小";
			this.toolTipControls.SetToolTip(this.labelIconSize, "绘图图标的最大直径。");
			// 
			// listViewShapePalette
			// 
			this.listViewShapePalette.LabelWrap = false;
			this.listViewShapePalette.Location = new System.Drawing.Point(7, 22);
			this.listViewShapePalette.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.listViewShapePalette.MultiSelect = false;
			this.listViewShapePalette.Name = "listViewShapePalette";
			this.listViewShapePalette.Size = new System.Drawing.Size(214, 61);
			this.listViewShapePalette.TabIndex = 0;
			this.toolTipControls.SetToolTip(this.listViewShapePalette, "将用于绘制不同项目的形状集合。");
			this.listViewShapePalette.UseCompatibleStateImageBehavior = false;
			this.listViewShapePalette.View = System.Windows.Forms.View.SmallIcon;
			this.listViewShapePalette.SelectedIndexChanged += new System.EventHandler(this.ListViewShapePalette_SelectedIndexChanged);
			// 
			// trackBarIconOpacity
			// 
			this.trackBarIconOpacity.LargeChange = 3;
			this.trackBarIconOpacity.Location = new System.Drawing.Point(351, 22);
			this.trackBarIconOpacity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.trackBarIconOpacity.Name = "trackBarIconOpacity";
			this.trackBarIconOpacity.Size = new System.Drawing.Size(121, 45);
			this.trackBarIconOpacity.TabIndex = 2;
			this.toolTipControls.SetToolTip(this.trackBarIconOpacity, "图标的透明度。");
			this.trackBarIconOpacity.Value = 1;
			// 
			// trackBarShadowOpacity
			// 
			this.trackBarShadowOpacity.LargeChange = 3;
			this.trackBarShadowOpacity.Location = new System.Drawing.Point(351, 81);
			this.trackBarShadowOpacity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.trackBarShadowOpacity.Name = "trackBarShadowOpacity";
			this.trackBarShadowOpacity.Size = new System.Drawing.Size(121, 45);
			this.trackBarShadowOpacity.TabIndex = 5;
			this.toolTipControls.SetToolTip(this.trackBarShadowOpacity, "投影阴影的透明度（表现为暗度）。");
			// 
			// buttonRemoveShape
			// 
			this.buttonRemoveShape.Location = new System.Drawing.Point(94, 189);
			this.buttonRemoveShape.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonRemoveShape.Name = "buttonRemoveShape";
			this.buttonRemoveShape.Size = new System.Drawing.Size(119, 27);
			this.buttonRemoveShape.TabIndex = 7;
			this.buttonRemoveShape.Text = "移除所选";
			this.toolTipControls.SetToolTip(this.buttonRemoveShape, "从调色板中移除当前所选的形状。");
			this.buttonRemoveShape.UseVisualStyleBackColor = true;
			this.buttonRemoveShape.Click += new System.EventHandler(this.ButtonRemoveShape_Click);
			// 
			// buttonAddShape
			// 
			this.buttonAddShape.Location = new System.Drawing.Point(7, 189);
			this.buttonAddShape.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonAddShape.Name = "buttonAddShape";
			this.buttonAddShape.Size = new System.Drawing.Size(80, 27);
			this.buttonAddShape.TabIndex = 6;
			this.buttonAddShape.Text = "添加形状";
			this.toolTipControls.SetToolTip(this.buttonAddShape, "向调色板中添加新形状。");
			this.buttonAddShape.UseVisualStyleBackColor = true;
			this.buttonAddShape.Click += new System.EventHandler(this.ButtonAddShape_Click);
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(14, 396);
			this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(113, 27);
			this.buttonReset.TabIndex = 5;
			this.buttonReset.Text = "重置为默认值";
			this.toolTipControls.SetToolTip(this.buttonReset, "将此表单上的所有绘图设置重置为默认值。");
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
			// 
			// checkBoxFill
			// 
			this.checkBoxFill.AutoSize = true;
			this.checkBoxFill.Location = new System.Drawing.Point(93, 164);
			this.checkBoxFill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.checkBoxFill.Name = "checkBoxFill";
			this.checkBoxFill.Size = new System.Drawing.Size(76, 19);
			this.checkBoxFill.TabIndex = 8;
			this.checkBoxFill.Text = "填充形状";
			this.toolTipControls.SetToolTip(this.checkBoxFill, "用纯色填充空心形状。");
			this.checkBoxFill.UseVisualStyleBackColor = true;
			// 
			// checkBoxMarker
			// 
			this.checkBoxMarker.AutoSize = true;
			this.checkBoxMarker.Location = new System.Drawing.Point(93, 139);
			this.checkBoxMarker.Name = "checkBoxMarker";
			this.checkBoxMarker.Size = new System.Drawing.Size(63, 19);
			this.checkBoxMarker.TabIndex = 10;
			this.checkBoxMarker.Text = "标记";
			this.toolTipControls.SetToolTip(this.checkBoxMarker, "指向项目的等腰三角形标记。");
			this.checkBoxMarker.UseVisualStyleBackColor = true;
			// 
			// checkBoxFrame
			// 
			this.checkBoxFrame.AutoSize = true;
			this.checkBoxFrame.Location = new System.Drawing.Point(7, 164);
			this.checkBoxFrame.Name = "checkBoxFrame";
			this.checkBoxFrame.Size = new System.Drawing.Size(59, 19);
			this.checkBoxFrame.TabIndex = 9;
			this.checkBoxFrame.Text = "边框";
			this.toolTipControls.SetToolTip(this.checkBoxFrame, "仅有角的边框，模拟游戏中的地图光标。");
			this.checkBoxFrame.UseVisualStyleBackColor = true;
			// 
			// groupBoxIconSettings
			// 
			this.groupBoxIconSettings.Controls.Add(this.trackBarShadowOpacity);
			this.groupBoxIconSettings.Controls.Add(this.labelOpacityShadow);
			this.groupBoxIconSettings.Controls.Add(this.trackBarIconOpacity);
			this.groupBoxIconSettings.Controls.Add(this.labelIconWidth);
			this.groupBoxIconSettings.Controls.Add(this.trackBarIconWidth);
			this.groupBoxIconSettings.Controls.Add(this.labelOpacity);
			this.groupBoxIconSettings.Controls.Add(this.trackBarIconSize);
			this.groupBoxIconSettings.Controls.Add(this.labelIconSize);
			this.groupBoxIconSettings.Location = new System.Drawing.Point(14, 14);
			this.groupBoxIconSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBoxIconSettings.Name = "groupBoxIconSettings";
			this.groupBoxIconSettings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBoxIconSettings.Size = new System.Drawing.Size(479, 142);
			this.groupBoxIconSettings.TabIndex = 0;
			this.groupBoxIconSettings.TabStop = false;
			this.groupBoxIconSettings.Text = "图标设置";
			// 
			// groupBoxIconPalette
			// 
			this.groupBoxIconPalette.Controls.Add(this.checkBoxMarker);
			this.groupBoxIconPalette.Controls.Add(this.checkBoxFrame);
			this.groupBoxIconPalette.Controls.Add(this.checkBoxFill);
			this.groupBoxIconPalette.Controls.Add(this.listViewShapePalette);
			this.groupBoxIconPalette.Controls.Add(this.checkBoxCrosshairOuter);
			this.groupBoxIconPalette.Controls.Add(this.buttonRemoveShape);
			this.groupBoxIconPalette.Controls.Add(this.buttonAddShape);
			this.groupBoxIconPalette.Controls.Add(this.checkBoxCircle);
			this.groupBoxIconPalette.Controls.Add(this.checkBoxDiamond);
			this.groupBoxIconPalette.Controls.Add(this.checkBoxCrosshairInner);
			this.groupBoxIconPalette.Controls.Add(this.checkBoxSquare);
			this.groupBoxIconPalette.Location = new System.Drawing.Point(265, 163);
			this.groupBoxIconPalette.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBoxIconPalette.Name = "groupBoxIconPalette";
			this.groupBoxIconPalette.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBoxIconPalette.Size = new System.Drawing.Size(229, 226);
			this.groupBoxIconPalette.TabIndex = 2;
			this.groupBoxIconPalette.TabStop = false;
			this.groupBoxIconPalette.Text = "图标形状调色板";
			// 
			// FormPlotStyleSettings
			// 
			this.AcceptButton = this.buttonApply;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(506, 435);
			this.Controls.Add(this.groupBoxIconSettings);
			this.Controls.Add(this.buttonReset);
			this.Controls.Add(this.groupBoxColorPalette);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.groupBoxIconPalette);
			this.Controls.Add(this.buttonApply);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormPlotStyleSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "绘图样式设置";
			this.groupBoxColorPalette.ResumeLayout(false);
			this.groupBoxColorPalette.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarIconWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarIconSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarIconOpacity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarShadowOpacity)).EndInit();
			this.groupBoxIconSettings.ResumeLayout(false);
			this.groupBoxIconSettings.PerformLayout();
			this.groupBoxIconPalette.ResumeLayout(false);
			this.groupBoxIconPalette.PerformLayout();
			this.ResumeLayout(false);
		}

		#endregion
		private System.Windows.Forms.CheckBox checkBoxCircle;
		private System.Windows.Forms.CheckBox checkBoxSquare;
		private System.Windows.Forms.CheckBox checkBoxDiamond;
		private System.Windows.Forms.CheckBox checkBoxCrosshairOuter;
		private System.Windows.Forms.CheckBox checkBoxCrosshairInner;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelOpacity;
		private System.Windows.Forms.GroupBox groupBoxColorPalette;
		private System.Windows.Forms.Label labelOpacityShadow;
		private System.Windows.Forms.TrackBar trackBarIconWidth;
		private System.Windows.Forms.Label labelIconWidth;
		private System.Windows.Forms.TrackBar trackBarIconSize;
		private System.Windows.Forms.Label labelIconSize;
		private System.Windows.Forms.ToolTip toolTipControls;
		private System.Windows.Forms.ColorDialog colorDialogPalette;
		private System.Windows.Forms.Button buttonAddColor;
		private System.Windows.Forms.GroupBox groupBoxIconSettings;
		private System.Windows.Forms.Label labelLoadPalette;
		private System.Windows.Forms.ComboBox comboBoxPalette;
		private System.Windows.Forms.Button buttonRemoveColor;
		private System.Windows.Forms.GroupBox groupBoxIconPalette;
		private System.Windows.Forms.Button buttonRemoveShape;
		private System.Windows.Forms.Button buttonAddShape;
		private System.Windows.Forms.ListView listViewColorPalette;
		private System.Windows.Forms.ListView listViewShapePalette;
		private System.Windows.Forms.TrackBar trackBarIconOpacity;
		private System.Windows.Forms.TrackBar trackBarShadowOpacity;
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.CheckBox checkBoxFill;
		private System.Windows.Forms.CheckBox checkBoxMarker;
		private System.Windows.Forms.CheckBox checkBoxFrame;
	}
}