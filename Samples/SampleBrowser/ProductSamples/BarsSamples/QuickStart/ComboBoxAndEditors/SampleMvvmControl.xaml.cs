﻿using ActiproSoftware.Windows.Controls.Bars;
using ActiproSoftware.Windows.Controls.Bars.Mvvm;
using System;
using System.Windows;
using System.Windows.Media;

namespace ActiproSoftware.ProductSamples.BarsSamples.QuickStart.ComboBoxAndEditors {

	/// <summary>
	/// Provides the user control for this sample that uses an MVVM-based ribbon configuration.
	/// </summary>
	public partial class SampleMvvmControl : SampleControlBase {

		private BarTextBoxViewModel textBoxViewModel;

		/////////////////////////////////////////////////////////////////////////////////////////////////////
		// OBJECT
		/////////////////////////////////////////////////////////////////////////////////////////////////////

		/// <summary>
		/// Initializes a new instance of the <see cref="SampleMvvmControl"/> class.
		/// </summary>
		public SampleMvvmControl() {
			InitializeComponent();

			// Initialize the Ribbon view models (used by MVVM samples only)
			InitializeRibbonViewModels();

			// Configure this code-behind to be the view model for this sample
			this.DataContext = this;
		}

		/////////////////////////////////////////////////////////////////////////////////////////////////////
		// NON-PUBLIC PROCEDURES
		/////////////////////////////////////////////////////////////////////////////////////////////////////

		/// <summary>
		/// Initializes the view models for the MVVM-based ribbon.
		/// </summary>
		private void InitializeRibbonViewModels() {
			//
			// Configure Individual Controls
			//

			// Textbox
			textBoxViewModel = new BarTextBoxViewModel("Textbox") {
				Command = this.TextBoxCommitCommand,
				Description = "A textbox control that commits changed text on Enter or focus loss.",
				RequestedWidth = 120,
				Text = "A text value",
			};

			//
			// Configure Ribbon
			//

			Ribbon = new RibbonViewModel() {
				IsApplicationButtonVisible = false,
				QuickAccessToolBarMode = RibbonQuickAccessToolBarMode.Hidden,
				Tabs = {
					new RibbonTabViewModel("MvvmSamples", "MVVM Samples") {
						Groups = {

							new RibbonGroupViewModel("BasicSamples") {
								Items = {
									new RibbonControlGroupViewModel() {
										ItemVariantBehavior = ItemVariantBehavior.AlwaysMedium,
										Items = {

											// Editable
											new BarComboBoxViewModel("Editable") {
												Description = "A basic, editable combobox sample.",
												IsEditable = true,
												TextPath = nameof(SimpleComboBoxGalleryItem.Label),
												UnmatchedTextCommand = this.ComboBoxUnmatchedTextCommand,
												MenuItems = {
													new BarGalleryViewModel("EditableGallery", this.ComboBoxGalleryCommand, this.ComboBoxPersonItems) {
														ItemTemplate = (DataTemplate)FindResource(LocalResourceKeys.PersonComboBoxGalleryItemTemplate),
														UseMenuItemAppearance = true,
													}
												}
											},

											// Read-Only
											new BarComboBoxViewModel("ReadOnly") {
												Description = "A basic, editable and read-only combobox sample.",
												IsEditable = true,
												IsReadOnly = true,
												TextPath = nameof(SimpleComboBoxGalleryItem.Label),
												UnmatchedTextCommand = this.ComboBoxUnmatchedTextCommand,
												MenuItems = {
													new BarGalleryViewModel("EditableGallery", this.ComboBoxGalleryCommand, this.ComboBoxPersonItems) {
														ItemTemplate = (DataTemplate)FindResource(LocalResourceKeys.PersonComboBoxGalleryItemTemplate),
														UseMenuItemAppearance = true,
													}
												}
											},

											// Non-Editable
											new BarComboBoxViewModel("NonEditable", "Non-Editable") {
												Description = "A basic, non-editable combobox sample.",
												TextPath = nameof(SimpleComboBoxGalleryItem.Label),
												UnmatchedTextCommand = this.ComboBoxUnmatchedTextCommand,
												MenuItems = {
													new BarGalleryViewModel("NonEditableGallery", this.ComboBoxGalleryCommand, this.ComboBoxPersonItems) {
														ItemTemplate = (DataTemplate)FindResource(LocalResourceKeys.PersonComboBoxGalleryItemTemplate),
														UseMenuItemAppearance = true,
													}
												}
											},

										}
									}
								}
							},

							new RibbonGroupViewModel("CategorizedSamples") {
								Items = {
									new RibbonControlGroupViewModel() {
										ItemVariantBehavior = ItemVariantBehavior.AlwaysMedium,
										Items = {

											// Categorized items in a single column
											new BarComboBoxViewModel("CategorizedSingleColumn", "Single-Column") {
												Description = "A combobox with items categorized and displayed in a single column.",
												IsEditable = true,
												TextPath = nameof(SimpleComboBoxGalleryItem.Label),
												UnmatchedTextCommand = this.ComboBoxUnmatchedTextCommand,
												MenuItems = {
													new BarGalleryViewModel("CategorizedSingleColumnGallery", this.ComboBoxGalleryCommand, this.ComboBoxPersonItems) {
														CanCategorize = true,
														MaxMenuColumnCount = 1,
														ItemTemplate = (DataTemplate)FindResource(LocalResourceKeys.PersonComboBoxGalleryItemTemplate),
														UseMenuItemAppearance = true,
													}
												}
											},

											// Categorized items in multiple columns
											new BarComboBoxViewModel("CategorizedMultiColumn", "Multi-Column") {
												Description = "A combobox with items categorized and displayed using multiple columns.",
												IsEditable = true,
												TextPath = nameof(SimpleComboBoxGalleryItem.Label),
												UnmatchedTextCommand = this.ComboBoxUnmatchedNumberTextCommand,
												MenuItems = {
													new BarGalleryViewModel("CategorizedMultiColumnGallery", this.ComboBoxGalleryCommand, this.ComboBoxNumberItems) {
														CanCategorize = true,
														MinMenuColumnCount = 5,
														MaxMenuColumnCount = 5,
														ItemTemplate = (DataTemplate)FindResource(LocalResourceKeys.NumberComboBoxGalleryItemTemplate),
														UseMenuItemAppearance = true,
													}
												}
											},

											// Categorized/Filtered items with menu item appearance consistent with large menu items
											new BarComboBoxViewModel("MenuStyle") {
												Description = "A combobox using a menu-like appearance for items, filtering, and an additional menu item below the list of combobox items.",
												IsEditable = true,
												TextPath = nameof(SimpleComboBoxGalleryItem.Label),
												UnmatchedTextCommand = this.ComboBoxUnmatchedTextCommand,
												MenuItems = {
													new BarGalleryViewModel("MenuStyleGallery", this.ComboBoxGalleryCommand, this.ComboBoxColorItems) {
														CanCategorize = true,
														CanFilter = true,
														MaxMenuColumnCount = 1,
														ItemTemplate = (DataTemplate)FindResource(LocalResourceKeys.LargeMenuComboBoxGalleryItemTemplate),
														UseMenuItemAppearance = true,
													},
													new BarButtonViewModel("MoreColors", "More colors...") {
														Command = this.NotImplementedCommand,
													}
												}
											},

										}
									}
								}
							},

							new RibbonGroupViewModel("FontSamples") {
								Items = {
									new RibbonControlGroupViewModel() {
										ItemVariantBehavior = ItemVariantBehavior.AlwaysMedium,
										Items = {

											// Font family
											new BarComboBoxViewModel("FontFamily") {
												Description = "A combobox with system fonts and a category for recently-used fonts.",
												IsEditable = true,
												IsUnmatchedTextAllowed = false,
												RequestedWidth = 120,
												TextPath = nameof(FontFamilyBarGalleryItemViewModel.Label),
												MenuItems = {
													new BarGalleryViewModel("FontFamilyGallery", this.ComboBoxGalleryCommand, this.ComboBoxFontFamilyItems) {
														CanCategorize = true,
														ItemTemplateSelector = new BarGalleryItemTemplateSelector(),
														MaxMenuColumnCount = 1,
														MenuResizeMode = Windows.Controls.ControlResizeMode.Vertical,
														UseMenuItemAppearance = true,
													}
												}
											},

											// Font size
											new BarComboBoxViewModel("FontSize") {
												Description = "A combobox with common font sizes.",
												IsEditable = true,
												IsTextCompletionEnabled = false,
												RequestedWidth = 45,
												TextPath = nameof(FontSizeBarGalleryItemViewModel.Label),
												UnmatchedTextCommand = this.ComboBoxUnmatchedNumberTextCommand,
												MenuItems = {
													new BarGalleryViewModel("FontSizeGallery", this.ComboBoxGalleryCommand, this.ComboBoxFontSizeItems) {
														ItemTemplateSelector = new BarGalleryItemTemplateSelector(),
														MaxMenuColumnCount = 1,
														MenuResizeMode = Windows.Controls.ControlResizeMode.Vertical,
														UseMenuItemAppearance = true,
													}
												}
											},

										}
									}
								}
							},

							new RibbonGroupViewModel("OtherSamples") {
								Items = {
									new RibbonControlGroupViewModel() {
										ItemVariantBehavior = ItemVariantBehavior.AlwaysMedium,
										Items = {

											// Textbox (using previously created view model)
											textBoxViewModel,

											new ColorEditBoxViewModel("Color") {
												Description = "An editbox from Actipro Editors for selecting a Color.",
												RequestedWidth = 100,
												Value = Colors.LightSeaGreen
											},

											new DateEditBoxViewModel("Date") {
												Description = "An editbox from Actipro Editors for selecting a date.",
												RequestedWidth = 100,
												Value = DateTime.Today
											},

											new Int32EditBoxViewModel("Number") {
												Description = "An editbox from Actipro Editors for selecting an Int32.",
												RequestedWidth = 60,
												Value = 10
											}

										}
									}
								}
							},
						},
					},
				},
			};
		}

		/////////////////////////////////////////////////////////////////////////////////////////////////////
		// PUBLIC PROCEDURES
		/////////////////////////////////////////////////////////////////////////////////////////////////////

		/// <inheritdoc/>
		protected override string GetTextBoxCommitCommandText(object commandParameter) {
			// In the MVVM sample the text is accessed directly from the BarTextBoxViewModel
			// associated with the command since a single command would not typically be
			// associated with more than one BarTextBoxViewModel
			return textBoxViewModel?.Text;
		}


		/// <summary>
		/// Gets the view model for the Ribbon control.
		/// </summary>
		/// <value>A <see cref="RibbonViewModel"/>.</value>
		public RibbonViewModel Ribbon { get; private set; }

	}

}