using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using ActiproSoftware.Windows.Controls.Editors.Interop.DataGrid.Primitives;

namespace ActiproSoftware.Windows.Controls.Editors.Interop.DataGrid {

	/// <summary>
	/// Represents a data-bound column for use in a <c>DataGrid</c> that utilizes the <see cref="CornerRadiusEditBox"/> control.
	/// </summary>
	public class DataGridCornerRadiusColumn : DataGridPartEditBoxColumnBase<CornerRadius?> {
	
		#region Dependency Properties
		
		/// <summary>
		/// Identifies the <see cref="DefaultValue"/> dependency property.  This field is read-only.
		/// </summary>
		/// <value>The identifier for the <see cref="DefaultValue"/> dependency property.</value>
		public static readonly DependencyProperty DefaultValueProperty = DependencyProperty.Register("DefaultValue", typeof(CornerRadius), typeof(DataGridCornerRadiusColumn), new PropertyMetadata(new CornerRadius(0.0), NotifyPropertyChangeForRefreshContent));
		
		/// <summary>
		/// Identifies the <see cref="Format"/> dependency property.  This field is read-only.
		/// </summary>
		/// <value>The identifier for the <see cref="Format"/> dependency property.</value>
		public static readonly DependencyProperty FormatProperty = DependencyProperty.Register("Format", typeof(string), typeof(DataGridCornerRadiusColumn), new PropertyMetadata("G", NotifyPropertyChangeForRefreshContent));
		
		/// <summary>
		/// Identifies the <see cref="IsNaNAllowed"/> dependency property.  This field is read-only.
		/// </summary>
		/// <value>The identifier for the <see cref="IsNaNAllowed"/> dependency property.</value>
		public static readonly DependencyProperty IsNaNAllowedProperty = DependencyProperty.Register("IsNaNAllowed", typeof(bool), typeof(DataGridCornerRadiusColumn), new PropertyMetadata(false, NotifyPropertyChangeForRefreshContent));
		
		/// <summary>
		/// Identifies the <see cref="IsNegativeInfinityAllowed"/> dependency property.  This field is read-only.
		/// </summary>
		/// <value>The identifier for the <see cref="IsNegativeInfinityAllowed"/> dependency property.</value>
		public static readonly DependencyProperty IsNegativeInfinityAllowedProperty = DependencyProperty.Register("IsNegativeInfinityAllowed", typeof(bool), typeof(DataGridCornerRadiusColumn), new PropertyMetadata(false, NotifyPropertyChangeForRefreshContent));
		
		/// <summary>
		/// Identifies the <see cref="IsPositiveInfinityAllowed"/> dependency property.  This field is read-only.
		/// </summary>
		/// <value>The identifier for the <see cref="IsPositiveInfinityAllowed"/> dependency property.</value>
		public static readonly DependencyProperty IsPositiveInfinityAllowedProperty = DependencyProperty.Register("IsPositiveInfinityAllowed", typeof(bool), typeof(DataGridCornerRadiusColumn), new PropertyMetadata(false, NotifyPropertyChangeForRefreshContent));
		
		/// <summary>
		/// Identifies the <see cref="LargeChange"/> dependency property.  This field is read-only.
		/// </summary>
		/// <value>The identifier for the <see cref="LargeChange"/> dependency property.</value>
		public static readonly DependencyProperty LargeChangeProperty = DependencyProperty.Register("LargeChange", typeof(CornerRadius), typeof(DataGridCornerRadiusColumn), new PropertyMetadata(new CornerRadius(5.0), NotifyPropertyChangeForRefreshContent));
		
		/// <summary>
		/// Identifies the <see cref="Maximum"/> dependency property.  This field is read-only.
		/// </summary>
		/// <value>The identifier for the <see cref="Maximum"/> dependency property.</value>
		public static readonly DependencyProperty MaximumProperty = DependencyProperty.Register("Maximum", typeof(CornerRadius), typeof(DataGridCornerRadiusColumn), new PropertyMetadata(new CornerRadius(50.0), NotifyPropertyChangeForRefreshContent));
		
		/// <summary>
		/// Identifies the <see cref="Minimum"/> dependency property.  This field is read-only.
		/// </summary>
		/// <value>The identifier for the <see cref="Minimum"/> dependency property.</value>
		public static readonly DependencyProperty MinimumProperty = DependencyProperty.Register("Minimum", typeof(CornerRadius), typeof(DataGridCornerRadiusColumn), new PropertyMetadata(new CornerRadius(0.0), NotifyPropertyChangeForRefreshContent));
		
		/// <summary>
		/// Identifies the <see cref="RoundingDecimalPlace"/> dependency property.  This field is read-only.
		/// </summary>
		/// <value>The identifier for the <see cref="RoundingDecimalPlace"/> dependency property.</value>
		public static readonly DependencyProperty RoundingDecimalPlaceProperty = DependencyProperty.Register("RoundingDecimalPlace", typeof(int?), typeof(DataGridCornerRadiusColumn), new PropertyMetadata(8, NotifyPropertyChangeForRefreshContent));
		
		/// <summary>
		/// Identifies the <see cref="SmallChange"/> dependency property.  This field is read-only.
		/// </summary>
		/// <value>The identifier for the <see cref="SmallChange"/> dependency property.</value>
		public static readonly DependencyProperty SmallChangeProperty = DependencyProperty.Register("SmallChange", typeof(CornerRadius), typeof(DataGridCornerRadiusColumn), new PropertyMetadata(new CornerRadius(1.0), NotifyPropertyChangeForRefreshContent));
		
		#endregion

		/////////////////////////////////////////////////////////////////////////////////////////////////////
		// OBJECT
		/////////////////////////////////////////////////////////////////////////////////////////////////////
		
		/// <summary>
		/// Initializes an instance of the <see cref="DataGridCornerRadiusColumn"/> class.
		/// </summary>
		public DataGridCornerRadiusColumn() {
			this.HasPopup = false;
			this.SpinnerVisibility = SpinnerVisibility.VisibleWhenActive;
		}
		
		/////////////////////////////////////////////////////////////////////////////////////////////////////
		// PUBLIC PROCEDURES
		/////////////////////////////////////////////////////////////////////////////////////////////////////
		
		/// <summary>
		/// Applies standard values to the specified target element.
		/// </summary>
		/// <param name="targetElement">The target element.</param>
		protected override void ApplyStandardValues(FrameworkElement targetElement) {
			base.ApplyStandardValues(targetElement);
			if (targetElement is CornerRadiusEditBox) {
				this.ApplyValue(DefaultValueProperty, targetElement, CornerRadiusEditBox.DefaultValueProperty);
				this.ApplyValue(FormatProperty, targetElement, CornerRadiusEditBox.FormatProperty);
				this.ApplyValue(IsNaNAllowedProperty, targetElement, CornerRadiusEditBox.IsNaNAllowedProperty);
				this.ApplyValue(IsNegativeInfinityAllowedProperty, targetElement, CornerRadiusEditBox.IsNegativeInfinityAllowedProperty);
				this.ApplyValue(IsPositiveInfinityAllowedProperty, targetElement, CornerRadiusEditBox.IsPositiveInfinityAllowedProperty);
				this.ApplyValue(LargeChangeProperty, targetElement, CornerRadiusEditBox.LargeChangeProperty);
				this.ApplyValue(MaximumProperty, targetElement, CornerRadiusEditBox.MaximumProperty);
				this.ApplyValue(MinimumProperty, targetElement, CornerRadiusEditBox.MinimumProperty);
				this.ApplyValue(RoundingDecimalPlaceProperty, targetElement, CornerRadiusEditBox.RoundingDecimalPlaceProperty);
				this.ApplyValue(SmallChangeProperty, targetElement, CornerRadiusEditBox.SmallChangeProperty);
			}
		}
		
		/// <summary>
		/// Gets or sets the value to set when incrementing/decrementing from a null value.
		/// </summary>
		/// <value>
		/// The value to set when incrementing/decrementing from a null value.
		/// The default value is <c>0</c>.
		/// </value>
		public CornerRadius DefaultValue {
			get {
				return (CornerRadius)this.GetValue(DefaultValueProperty);
			}
			set {
				this.SetValue(DefaultValueProperty, value);
			}
		}
		
		/// <summary>
		/// Gets or sets the number format string.
		/// </summary>
		/// <value>
		/// The number format string.
		/// The default value is <c>"G"</c>.
		/// </value>
		public string Format {
			get {
				return (string)this.GetValue(FormatProperty);
			}
			set {
				this.SetValue(FormatProperty, value);
			}
		}
		
		/// <summary>
		/// Gets the type of the associated <c>PartEditBoxBase</c>-derived control.
		/// </summary>
		/// <returns>The type of the associated <c>PartEditBoxBase</c>-derived control.</returns>
		[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
		protected override Type GetEditBoxType() {
			return typeof(CornerRadiusEditBox);
		}
		
		/// <summary>
		/// Gets or sets whether <see cref="Double.NaN"/> is accepted as a component value.
		/// </summary>
		/// <value>
		/// <c>true</c> if <see cref="Double.NaN"/> is accepted as a component value; otherwise, <c>false</c>.
		/// The default value is <c>false</c>.
		/// </value>
		public bool IsNaNAllowed {
			get {
				return (bool)this.GetValue(IsNaNAllowedProperty);
			}
			set {
				this.SetValue(IsNaNAllowedProperty, value);
			}
		}
		
		/// <summary>
		/// Gets or sets whether <see cref="Double.NegativeInfinity"/> is accepted as a component value.
		/// </summary>
		/// <value>
		/// <c>true</c> if <see cref="Double.NegativeInfinity"/> is accepted as a component value; otherwise, <c>false</c>.
		/// The default value is <c>false</c>.
		/// </value>
		public bool IsNegativeInfinityAllowed {
			get {
				return (bool)this.GetValue(IsNegativeInfinityAllowedProperty);
			}
			set {
				this.SetValue(IsNegativeInfinityAllowedProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets whether <see cref="Double.PositiveInfinity"/> is accepted as a component value.
		/// </summary>
		/// <value>
		/// <c>true</c> if <see cref="Double.PositiveInfinity"/> is accepted as a component value; otherwise, <c>false</c>.
		/// The default value is <c>false</c>.
		/// </value>
		public bool IsPositiveInfinityAllowed {
			get {
				return (bool)this.GetValue(IsPositiveInfinityAllowedProperty);
			}
			set {
				this.SetValue(IsPositiveInfinityAllowedProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the large change value.
		/// </summary>
		/// <value>
		/// The large change value.
		/// The default value is <c>5</c>.
		/// </value>
		public CornerRadius LargeChange {
			get {
				return (CornerRadius)this.GetValue(LargeChangeProperty);
			}
			set {
				this.SetValue(LargeChangeProperty, value);
			}
		}
		
		/// <summary>
		/// Gets or sets the highest possible value.
		/// </summary>
		/// <value>
		/// The highest possible value.
		/// </value>
		public CornerRadius Maximum {
			get {
				return (CornerRadius)this.GetValue(MaximumProperty);
			}
			set {
				this.SetValue(MaximumProperty, value);
			}
		}
		
		/// <summary>
		/// Gets or sets the lowest possible value.
		/// </summary>
		/// <value>
		/// The lowest possible value.
		/// </value>
		public CornerRadius Minimum {
			get {
				return (CornerRadius)this.GetValue(MinimumProperty);
			}
			set {
				this.SetValue(MinimumProperty, value);
			}
		}
		
		/// <summary>
		/// Gets or sets the rounding decimal place.
		/// </summary>
		/// <value>
		/// The rounding decimal place, which is a value between <c>0</c> and <c>15</c>.
		/// Pass a null value to disable rounding.  The default value is <c>8</c>.
		/// </value>
		public int? RoundingDecimalPlace {
			get {
				return (int?)this.GetValue(RoundingDecimalPlaceProperty);
			}
			set {
				this.SetValue(RoundingDecimalPlaceProperty, value);
			}
		}
		
		/// <summary>
		/// Gets or sets the small change value.
		/// </summary>
		/// <value>
		/// The small change value.
		/// The default value is <c>1</c>.
		/// </value>
		public CornerRadius SmallChange {
			get {
				return (CornerRadius)this.GetValue(SmallChangeProperty);
			}
			set {
				this.SetValue(SmallChangeProperty, value);
			}
		}
		
	}

}
