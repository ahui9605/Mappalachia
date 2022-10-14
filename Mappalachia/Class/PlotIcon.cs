using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Mappalachia.Class
{
	// A customizable Image used to represent a plot on the map
	public class PlotIcon
	{
		static Dictionary<int, PlotIcon> plotIconCache = new Dictionary<int, PlotIcon>();

		// Pull PlotIcon settings from the currently applied PlotSettings
		readonly int size = SettingsPlotStyle.iconSize;
		readonly int lineWidth = SettingsPlotStyle.lineWidth;
		readonly int iconOpacityPercent = SettingsPlotStyle.iconOpacityPercent;
		readonly int shadowOpacityPercent = SettingsPlotStyle.shadowOpacityPercent;
		readonly float halfSize;
		readonly float quartSize;
		readonly float threeQuartSize;
		readonly Pen pen;
		readonly Brush brush;
		readonly Bitmap bitmap;
		readonly Graphics icon;
		readonly PlotIconShape shape;
		readonly int shadowOffset = 2;

		public Color color;
		Image iconImage;

		public PlotIcon(Color color, PlotIconShape shape)
		{
			this.color = color;
			this.shape = shape;

			// All icon shape coordinates target points on a 4x4 grid
			// This way, icon shapes can be mixed & matched and still look proper
			halfSize = size / 2f;
			quartSize = size / 4f;
			threeQuartSize = quartSize * 3;

			pen = new Pen(Color.White, lineWidth);
			brush = new SolidBrush(Color.White);
			bitmap = new Bitmap(size, size);
			icon = Graphics.FromImage(bitmap);
			icon.SmoothingMode = SmoothingMode.AntiAlias;
		}

		// Gets a PlotIcon for a given legend group. Returns cached version if available
		public static PlotIcon GetIconForGroup(int group)
		{
			int colorTotal = SettingsPlotStyle.paletteColor.Count;
			int shapeTotal = SettingsPlotStyle.paletteShape.Count;

			if (SettingsPlot.IsTopographic())
			{
				colorTotal = 1; // Force a unique shape per group in topography mode, as color becomes indistinguishable
			}

			// Reduce the group number to find repeating icons
			// For example, 3 shapes and 5 colors makes 15 icons. Group 15 is therefore the same as group 0.
			group %= colorTotal * shapeTotal;

			// Return this ploticon if it has already been generated.
			if (plotIconCache.ContainsKey(group))
			{
				return plotIconCache[group];
			}

			// Identify which item from each palette should be used.
			// First iterate through every color, then every palette, and repeat.
			int colorIndex = group % colorTotal;
			int shapeIndex = (group / colorTotal) % shapeTotal;

			// Generate the PlotIcon
			Color color = SettingsPlot.IsTopographic() ? SettingsPlotTopograph.legendColor : SettingsPlotStyle.paletteColor[colorIndex];
			PlotIconShape shape = SettingsPlotStyle.paletteShape[shapeIndex];
			PlotIcon plotIcon = new PlotIcon(color, shape);

			// Register the icon in the cache and return it - Don't cache topography icons as they override the color
			if (!SettingsPlot.IsTopographic())
			{
				plotIconCache.Add(group, plotIcon);
			}

			return plotIcon;
		}

		// Clear the cache - used when plot icon settings are changed
		public static void ResetCache()
		{
			plotIconCache = new Dictionary<int, PlotIcon>();
		}

		// Draw and return the icon image
		public Image GetIconImage()
		{
			// Return the cached image, unless in topography mode, since we tend to update the color
			if (iconImage != null && !SettingsPlot.IsTopographic())
			{
				return iconImage;
			}

			if (shape.crosshairInner)
			{
				icon.DrawLine(pen, halfSize, quartSize, halfSize, threeQuartSize); // Vertical
				icon.DrawLine(pen, quartSize, halfSize, threeQuartSize, halfSize); // Horizontal
			}

			if (shape.crosshairOuter)
			{
				icon.DrawLine(pen, halfSize, size, halfSize, threeQuartSize); // Top
				icon.DrawLine(pen, halfSize, 0, halfSize, quartSize); // Bottom
				icon.DrawLine(pen, 0, halfSize, quartSize, halfSize); // Left
				icon.DrawLine(pen, size, halfSize, threeQuartSize, halfSize); // Right
			}

			if (shape.diamond)
			{
				PointF[] diamondCorners =
				{
					new PointF(halfSize, quartSize), // Top
					new PointF(quartSize, halfSize), // Bottom
					new PointF(halfSize, threeQuartSize), // Left
					new PointF(threeQuartSize, halfSize), // Right
				};

				if (shape.fill)
				{
					icon.FillPolygon(brush, diamondCorners);
				}
				else
				{
					icon.DrawPolygon(pen, diamondCorners);
				}
			}

			if (shape.square || shape.circle)
			{
				Rectangle halfRadiusRect = new Rectangle((int)quartSize, (int)quartSize, (int)halfSize, (int)halfSize);

				if (shape.square)
				{
					if (shape.fill)
					{
						icon.FillRectangle(brush, halfRadiusRect);
					}
					else
					{
						icon.DrawRectangle(pen, halfRadiusRect);
					}
				}

				if (shape.circle)
				{
					if (shape.fill)
					{
						icon.FillEllipse(brush, halfRadiusRect);
					}
					else
					{
						icon.DrawEllipse(pen, halfRadiusRect);
					}
				}
			}

			iconImage = ImageHelper.AdjustARGB(bitmap, Color.FromArgb((int)(iconOpacityPercent / 100f * 255f), color));
			iconImage = ImageHelper.AddDropShadow(iconImage, shadowOffset, (int)(shadowOpacityPercent / 100f * 255f));

			return iconImage;
		}
	}
}
