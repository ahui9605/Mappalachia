using System;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Mappalachia
{
	public partial class FormExportToFile : Form
	{
		public FormExportToFile()
		{
			InitializeComponent();
			SettingsFileExport.UpdateRecommendation();
		}

		private void FormExportToFile_Load(object sender, EventArgs e)
		{
			UpdateFormState();
		}

		private void CheckBoxUseRecommended_CheckedChanged(object sender, EventArgs e)
		{
			SettingsFileExport.SetUseRecommended(checkBoxUseRecommended.Checked);
			UpdateFormState();
		}

		private void RadioButtonPNG_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonPNG.Checked)
			{
				SettingsFileExport.fileType = SettingsFileExport.ExtensionType.PNG;
				UpdateFormState();
			}
		}

		private void RadioButtonBA2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonBA2.Checked)
			{
				SettingsFileExport.fileType = SettingsFileExport.ExtensionType.BA2;
				UpdateFormState();
			}
		}

		private void RadioButtonJPEG_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonJPEG.Checked)
			{
				SettingsFileExport.fileType = SettingsFileExport.ExtensionType.JPEG;
				UpdateFormState();
			}
		}

		private void NumericUpDownJPEGQuality_ValueChanged(object sender, EventArgs e)
		{
			SettingsFileExport.jpegQuality = (int)numericUpDownJPEGQuality.Value;
			UpdateFormState();
		}

		private void CheckBoxShowDirectory_CheckedChanged(object sender, EventArgs e)
		{
			SettingsFileExport.openExplorer = checkBoxShowDirectory.Checked;
		}

		// Update the values and enabled states of the form members when something relevant changes
		void UpdateFormState()
		{
			// Assign the values from the Settings Class
			checkBoxUseRecommended.Checked = SettingsFileExport.useRecommended;
			radioButtonPNG.Checked = SettingsFileExport.IsPNG();
			radioButtonJPEG.Checked = SettingsFileExport.IsJPEG();
			radioButtonBA2.Checked = SettingsFileExport.IsBA2();
			numericUpDownJPEGQuality.Value = SettingsFileExport.jpegQuality;
			checkBoxShowDirectory.Checked = SettingsFileExport.openExplorer;

			// Update the form enabled states accordingly
			radioButtonJPEG.Enabled = !checkBoxUseRecommended.Checked;
			radioButtonPNG.Enabled = !checkBoxUseRecommended.Checked;
			radioButtonBA2.Enabled = !checkBoxUseRecommended.Checked; // Enabling/Disabling BA2 option
			numericUpDownJPEGQuality.Enabled = !checkBoxUseRecommended.Checked && radioButtonJPEG.Checked;
			labelJPEGQualityPerc.Enabled = numericUpDownJPEGQuality.Enabled;
		}

		private void ButtonOK_Click(object sender, EventArgs e)
		{
			try // 尝试捕获整个代码块的异常
			{
				string userFileName = IOManager.SanitizeFilename(SettingsMap.title);

				string filter;
				if (radioButtonBA2.Checked)
				{
					filter = "BA2|*.ba2|PNG|*.png|JPEG|*.jpeg";
				}
				else if (radioButtonPNG.Checked)
				{
					filter = "PNG|*.png|JPEG|*.jpeg|BA2|*.ba2";
				}
				else
				{
					filter = "JPEG|*.jpeg|PNG|*.png|BA2|*.ba2";
				}

				using (SaveFileDialog dialog = new SaveFileDialog()) // 使用 using 语句确保资源释放
				{
					dialog.Filter = filter;
					dialog.FileName = string.IsNullOrWhiteSpace(userFileName) ? "MappalachiaMap" : userFileName;

					// 检查选定的文件格式并相应设置文件名
					if (radioButtonBA2.Checked)
					{
						dialog.FileName = "papermap_city_d";
					}
					if (dialog.ShowDialog() == DialogResult.OK)
					{
						string fileName = dialog.FileName;
						ImageFormat imageFormat;

						switch (Path.GetExtension(fileName).ToLower())
						{
							case ".png":
								imageFormat = ImageFormat.Png;
								break;
							case ".jpeg":
								imageFormat = ImageFormat.Jpeg;
								break;
							case ".ba2":
								string jpegPath = Path.ChangeExtension(fileName, ".jpeg");
								IOManager.WriteToFile(jpegPath, Map.GetImage(), ImageFormat.Jpeg, SettingsFileExport.jpegQuality);
								JPEG2BA2.ProcessMapFile(jpegPath);
								Close();
								return;
							default:
								throw new NotSupportedException("Unsupported file format");
						}

						IOManager.WriteToFile(fileName, Map.GetImage(), imageFormat, SettingsFileExport.jpegQuality);

						if (SettingsFileExport.openExplorer)
						{
							IOManager.SelectFile(fileName);
						}

						Close();
					}
				}
			}
			catch (Exception ex) // 捕获任何异常，并进行处理
			{
				MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
