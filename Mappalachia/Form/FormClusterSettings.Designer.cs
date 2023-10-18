namespace Mappalachia
{
	partial class FormSetClusterRange
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetClusterRange));
			this.trackBarClusterRange = new System.Windows.Forms.TrackBar();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.checkBoxliveUpdate = new System.Windows.Forms.CheckBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.trackBarMinClusterWeight = new System.Windows.Forms.TrackBar();
			this.labelClusterRange = new System.Windows.Forms.Label();
			this.labelMinClusterWeight = new System.Windows.Forms.Label();
			this.checkBoxDrawClusterWeb = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.trackBarClusterRange)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarMinClusterWeight)).BeginInit();
			this.SuspendLayout();
			// 
			// trackBarClusterRange
			// 
			this.trackBarClusterRange.Location = new System.Drawing.Point(159, 12);
			this.trackBarClusterRange.Maximum = 2000;
			this.trackBarClusterRange.Minimum = 1;
			this.trackBarClusterRange.Name = "trackBarClusterRange";
			this.trackBarClusterRange.Size = new System.Drawing.Size(475, 45);
			this.trackBarClusterRange.TabIndex = 1;
			this.trackBarClusterRange.TickFrequency = 100;
			this.toolTip.SetToolTip(this.trackBarClusterRange, "调整聚类的最大大小。");
			this.trackBarClusterRange.Value = 100;
			this.trackBarClusterRange.ValueChanged += new System.EventHandler(this.TrackBarClusterRange_ValueChanged);
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonOK.Location = new System.Drawing.Point(249, 163);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 8;
			this.buttonOK.Text = "确定";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonCancel.Location = new System.Drawing.Point(330, 163);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 9;
			this.buttonCancel.Text = "取消";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// checkBoxliveUpdate
			// 
			this.checkBoxliveUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxliveUpdate.AutoSize = true;
			this.checkBoxliveUpdate.Location = new System.Drawing.Point(155, 166);
			this.checkBoxliveUpdate.Name = "checkBoxliveUpdate";
			this.checkBoxliveUpdate.Size = new System.Drawing.Size(88, 19);
			this.checkBoxliveUpdate.TabIndex = 7;
			this.checkBoxliveUpdate.Text = "实时更新";
			this.toolTip.SetToolTip(this.checkBoxliveUpdate, "随着更改聚类值而不断重新绘制地图。");
			this.checkBoxliveUpdate.UseVisualStyleBackColor = true;
			this.checkBoxliveUpdate.CheckedChanged += new System.EventHandler(this.CheckBoxliveUpdate_CheckedChanged);
			// 
			// trackBarMinClusterWeight
			// 
			this.trackBarMinClusterWeight.Location = new System.Drawing.Point(159, 63);
			this.trackBarMinClusterWeight.Maximum = 200;
			this.trackBarMinClusterWeight.Minimum = 1;
			this.trackBarMinClusterWeight.Name = "trackBarMinClusterWeight";
			this.trackBarMinClusterWeight.Size = new System.Drawing.Size(475, 45);
			this.trackBarMinClusterWeight.TabIndex = 4;
			this.trackBarMinClusterWeight.TickFrequency = 10;
			this.toolTip.SetToolTip(this.trackBarMinClusterWeight, "调整聚类的最小权重。");
			this.trackBarMinClusterWeight.Value = 3;
			this.trackBarMinClusterWeight.ValueChanged += new System.EventHandler(this.TrackBarMinClusterWeight_ValueChanged);
			// 
			// labelClusterRange
			// 
			this.labelClusterRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelClusterRange.AutoSize = true;
			this.labelClusterRange.Location = new System.Drawing.Point(38, 21);
			this.labelClusterRange.Name = "labelClusterRange";
			this.labelClusterRange.Size = new System.Drawing.Size(115, 15);
			this.labelClusterRange.TabIndex = 0;
			this.labelClusterRange.Text = "聚类范围 (1234)";
			this.toolTip.SetToolTip(this.labelClusterRange, "调整聚类的最大大小。");
			// 
			// labelMinClusterWeight
			// 
			this.labelMinClusterWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelMinClusterWeight.AutoSize = true;
			this.labelMinClusterWeight.Location = new System.Drawing.Point(12, 72);
			this.labelMinClusterWeight.Name = "labelMinClusterWeight";
			this.labelMinClusterWeight.Size = new System.Drawing.Size(141, 15);
			this.labelMinClusterWeight.TabIndex = 3;
			this.labelMinClusterWeight.Text = "最小聚类权重 (123)";
			this.toolTip.SetToolTip(this.labelMinClusterWeight, "调整聚类的最小权重。");
			// 
			// checkBoxDrawClusterWeb
			// 
			this.checkBoxDrawClusterWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxDrawClusterWeb.AutoSize = true;
			this.checkBoxDrawClusterWeb.Location = new System.Drawing.Point(33, 112);
			this.checkBoxDrawClusterWeb.Name = "checkBoxDrawClusterWeb";
			this.checkBoxDrawClusterWeb.Size = new System.Drawing.Size(120, 19);
			this.checkBoxDrawClusterWeb.TabIndex = 6;
			this.checkBoxDrawClusterWeb.Text = "绘制聚类网络";
			this.toolTip.SetToolTip(this.checkBoxDrawClusterWeb, "绘制标识聚类成员实体的 '网络'。");
			this.checkBoxDrawClusterWeb.UseVisualStyleBackColor = true;
			this.checkBoxDrawClusterWeb.CheckedChanged += new System.EventHandler(this.CheckBoxDrawClusterWeb_CheckedChanged);

			// 
			// FormSetClusterRange
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(646, 191);
			this.Controls.Add(this.checkBoxDrawClusterWeb);
			this.Controls.Add(this.labelMinClusterWeight);
			this.Controls.Add(this.labelClusterRange);
			this.Controls.Add(this.trackBarMinClusterWeight);
			this.Controls.Add(this.checkBoxliveUpdate);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.trackBarClusterRange);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormSetClusterRange";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "聚类设置";
			this.Load += new System.EventHandler(this.FormSetClusterRange_Load);
			((System.ComponentModel.ISupportInitialize)(this.trackBarClusterRange)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarMinClusterWeight)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TrackBar trackBarClusterRange;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.CheckBox checkBoxliveUpdate;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.TrackBar trackBarMinClusterWeight;
		private System.Windows.Forms.Label labelClusterRange;
		private System.Windows.Forms.Label labelMinClusterWeight;
		private System.Windows.Forms.CheckBox checkBoxDrawClusterWeb;
	}
}