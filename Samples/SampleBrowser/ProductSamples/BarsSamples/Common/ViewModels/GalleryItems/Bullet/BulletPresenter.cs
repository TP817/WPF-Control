﻿using ActiproSoftware.Windows.Extensions;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace ActiproSoftware.ProductSamples.BarsSamples.Common {

	/// <summary>
	/// Represents a control for rendering a bullet preview.
	/// </summary>
	public class BulletPresenter : Decorator {

		#region Dependency Properties

		public static readonly DependencyProperty PaddingProperty = DependencyProperty.Register(nameof(Padding), typeof(Thickness), typeof(BulletPresenter), new FrameworkPropertyMetadata(new Thickness(6.0, 10.0, 6.0, 10.0), FrameworkPropertyMetadataOptions.AffectsMeasure));

		#endregion Dependency Properties

		/////////////////////////////////////////////////////////////////////////////////////////////////////
		// NON-PUBLIC PROCEDURES
		/////////////////////////////////////////////////////////////////////////////////////////////////////

		/// <summary>
		/// Creates <see cref="FormattedText"/> to render text.
		/// </summary>
		/// <param name="text">The text to display.</param>
		/// <returns>The <see cref="FormattedText"/> that was created.</returns>
		private FormattedText CreateFormattedText(string text) {
			var typeface = new Typeface(TextElement.GetFontFamily(this), FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);
			var fontSize = TextElement.GetFontSize(this);
			var foreground = TextElement.GetForeground(this);

			var formattedText = new FormattedText(text, CultureInfo.CurrentCulture, this.FlowDirection, typeface, fontSize, foreground, null, TextOptions.GetTextFormattingMode(this)
				#if NETCOREAPP
				, VisualTreeHelper.GetDpi(this).PixelsPerDip
				#endif
				);

			return formattedText;
		}

		/// <summary>
		/// Gets the view model in the data context.
		/// </summary>
		/// <value>The view model in the data context.</value>
		private BulletBarGalleryItemViewModel ViewModel => (BulletBarGalleryItemViewModel)this.DataContext;

		/////////////////////////////////////////////////////////////////////////////////////////////////////
		// PUBLIC PROCEDURES
		/////////////////////////////////////////////////////////////////////////////////////////////////////

		/// <inheritdoc/>
		protected override void OnRender(DrawingContext drawingContext) {
			var viewModel = this.ViewModel;
			if ((viewModel != null) && (viewModel.Kind != BulletKind.None)) {
				var foreground = TextElement.GetForeground(this);

				var xCenter = Math.Round(this.ActualWidth / 2.0, MidpointRounding.AwayFromZero);
				var yCenter = Math.Round(this.ActualHeight / 2.0, MidpointRounding.AwayFromZero);

				const double Radius = 5.0;

				switch (viewModel.Kind) {
					case BulletKind.Circle:
						drawingContext.DrawEllipse(null, new Pen(foreground, 1.0), new Point(xCenter, yCenter), Radius, Radius);
						break;
					case BulletKind.FilledCircle:
						drawingContext.DrawEllipse(foreground, null, new Point(xCenter, yCenter), Radius, Radius);
						break;
					case BulletKind.FilledSquare:
						drawingContext.DrawRectangle(foreground, null, new Rect(xCenter - Radius, yCenter - Radius, 2 * Radius, 2 * Radius));
						break;
					case BulletKind.Square:
						drawingContext.DrawRectangle(null, new Pen(foreground, 1.0), new Rect(xCenter - Radius + 0.5, yCenter - Radius + 0.5, 2 * Radius - 1.0, 2 * Radius - 1.0));
						break;
				}
			}
			else {
				var formattedText = this.CreateFormattedText("None");
				var location = new Point((this.ActualWidth - formattedText.Width) / 2.0, (this.ActualHeight - formattedText.Height) / 2.0);
				drawingContext.DrawText(formattedText, location, this.FlowDirection);
			}
		}

		/// <summary>
		/// Gets or sets the padding inside the control.
		/// </summary>
		/// <value>
		/// The padding inside the control.
		/// The default value is <c>6,10</c>.
		/// </value>
		public Thickness Padding {
			get => (Thickness)GetValue(PaddingProperty);
			set => SetValue(PaddingProperty, value);
		}

	}

}
