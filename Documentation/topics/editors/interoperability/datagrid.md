---
title: "DataGrid"
page-title: "DataGrid - Editors Interoperability"
order: 4
---
# DataGrid

The controls provided by the Editors product can be easily integrated into Microsoft's WPF `DataGrid`, through the use of custom `DataGridColumn` objects.  An Interop assembly is provided that ties the two products together.  This topic covers the various aspects of the Interop assembly.

![Screenshot](../images/datagrid-with-editors.png)

*DataGrid with Editors integrated using the Interop assembly*

## Interop Assembly

The Interop functionality is provided through a separate assembly, which is called *ActiproSoftware.Editors.Interop.DataGrid.Wpf.dll*.  Therefore, a reference to this assembly must be added in order to leverage the custom `DataGridColumn` objects it provides.  This assembly should have been installed in the GAC during the control installation process.  However, they also will be located in the appropriate *Program Files* folders.  See the product's Readme for details on those locations.

## Columns

The `DataGrid` allows the columns to be statically defined in XAML via the `Columns` property.  The Interop assembly provides several `DataGridColumn`-derived classes that leverage Editors' controls.

> [!NOTE]
> The Editors' controls can be used in a `DataGridTemplateColumn` as well, but the columns provided by the Interop assembly are typically more convenient.

The Interop assembly provides a set of classes that derive from `DataGridBoundColumn`, which derives from `DataGridColumn`.  These classes include:

| Class | Description |
|-----|-----|
| [DataGridBrushColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridBrushColumn) | Represents a property editor that uses a [BrushEditBox](xref:@ActiproUIRoot.Controls.Editors.BrushEditBox) for editing `Brush` property values. |
| [DataGridByteColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridByteColumn) | Represents a property editor that uses a [ByteEditBox](xref:@ActiproUIRoot.Controls.Editors.ByteEditBox) for editing `Byte` property values. |
| [DataGridColorColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridColorColumn) | Represents a property editor that uses a [ColorEditBox](xref:@ActiproUIRoot.Controls.Editors.ColorEditBox) for editing `Color` property values. |
| [DataGridCornerRadiusColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridCornerRadiusColumn) | Represents a property editor that uses a [CornerRadiusEditBox](xref:@ActiproUIRoot.Controls.Editors.CornerRadiusEditBox) for editing `CornerRadius` property values. |
| [DataGridDateColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridDateColumn) | Represents a property editor that uses a [DateEditBox](xref:@ActiproUIRoot.Controls.Editors.DateEditBox) for editing `DateTime` (date-only) property values. |
| [DataGridDateTimeColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridDateTimeColumn) | Represents a property editor that uses a [DateTimeEditBox](xref:@ActiproUIRoot.Controls.Editors.DateTimeEditBox) for editing `DateTime` property values. |
| [DataGridDoubleColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridDoubleColumn) | Represents a property editor that uses a [DoubleEditBox](xref:@ActiproUIRoot.Controls.Editors.DoubleEditBox) for editing `Double` property values. |
| [DataGridEnumColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridEnumColumn) | Represents a property editor that uses a [EnumEditBox](xref:@ActiproUIRoot.Controls.Editors.EnumEditBox) for editing `Enum` property values. |
| [DataGridGuidColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridGuidColumn) | Represents a property editor that uses a [GuidEditBox](xref:@ActiproUIRoot.Controls.Editors.GuidEditBox) for editing `Guid` property values. |
| [DataGridInt16Column](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridInt16Column) | Represents a property editor that uses a [Int16EditBox](xref:@ActiproUIRoot.Controls.Editors.Int16EditBox) for editing `Int16` property values. |
| [DataGridInt32Column](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridInt32Column) | Represents a property editor that uses a [Int32EditBox](xref:@ActiproUIRoot.Controls.Editors.Int32EditBox) for editing `Int32` property values. |
| [DataGridInt32RectColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridInt32RectColumn) | Represents a property editor that uses a [Int32RectEditBox](xref:@ActiproUIRoot.Controls.Editors.Int32RectEditBox) for editing `Int32Rect` property values. |
| [DataGridInt64Column](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridInt64Column) | Represents a property editor that uses a [Int64EditBox](xref:@ActiproUIRoot.Controls.Editors.Int64EditBox) for editing `Int64` property values. |
| [DataGridMaskedStringColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridMaskedStringColumn) | Represents a property editor that uses a [MaskedTextBox](xref:@ActiproUIRoot.Controls.Editors.MaskedTextBox) for editing `String` property values. |
| [DataGridPointColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridPointColumn) | Represents a property editor that uses a [PointEditBox](xref:@ActiproUIRoot.Controls.Editors.PointEditBox) for editing `Point` property values. |
| [DataGridRectColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridRectColumn) | Represents a property editor that uses a [RectEditBox](xref:@ActiproUIRoot.Controls.Editors.RectEditBox) for editing `Rect` property values. |
| [DataGridSingleColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridSingleColumn) | Represents a property editor that uses a [SingleEditBox](xref:@ActiproUIRoot.Controls.Editors.SingleEditBox) for editing `Single` property values. |
| [DataGridSizeColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridSizeColumn) | Represents a property editor that uses a [SizeEditBox](xref:@ActiproUIRoot.Controls.Editors.SizeEditBox) for editing `Size` property values. |
| [DataGridThicknessColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridThicknessColumn) | Represents a property editor that uses a [ThicknessEditBox](xref:@ActiproUIRoot.Controls.Editors.ThicknessEditBox) for editing `Thickness` property values. |
| [DataGridTimeColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridTimeColumn) | Represents a property editor that uses a [TimeEditBox](xref:@ActiproUIRoot.Controls.Editors.TimeEditBox) for editing `DateTime` (time-only) property values. |
| [DataGridTimeSpanColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridTimeSpanColumn) | Represents a property editor that uses a [TimeSpanEditBox](xref:@ActiproUIRoot.Controls.Editors.TimeSpanEditBox) for editing `TimeSpan` property values. |
| [DataGridVectorColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridVectorColumn) | Represents a property editor that uses a [VectorEditBox](xref:@ActiproUIRoot.Controls.Editors.VectorEditBox) for editing `Vector` property values. |

Each column exposes some of the more common settings available on their associated control.  For example, the [DataGridMaskedStringColumn](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridMaskedStringColumn) has a [Mask](xref:@ActiproUIRoot.Controls.Editors.Interop.DataGrid.DataGridMaskedStringColumn.Mask) property that allows you to set the associated [Mask](xref:@ActiproUIRoot.Controls.Editors.MaskedTextBox.Mask) on the underlying [MaskedTextBox](xref:@ActiproUIRoot.Controls.Editors.MaskedTextBox).

## Adding to DataGrid

The Interop columns can be defined on a single instance of the `DataGrid` control using the `Columns` collection.

This code shows how add the Interop column definitions to a single `DataGrid`:

```xaml
xmlns:datagrideditors="http://schemas.actiprosoftware.com/winfx/xaml/datagrideditors"
xmlns:toolkit="http://schemas.microsoft.com/wpf/2008/toolkit"


<toolkit:DataGrid AutoGenerateColumns="False" ItemsSource="...">
	<toolkit:DataGrid.Columns>
		<datagrideditors:DataGridBrushColumn Binding="{Binding BrushValue}" Header="Brush" />
		<datagrideditors:DataGridByteColumn Binding="{Binding ByteValue}" Header="Byte" />
		<datagrideditors:DataGridColorColumn Binding="{Binding ColorValue}" Header="Color" />
		<datagrideditors:DataGridCornerRadiusColumn Binding="{Binding CornerRadiusValue}" Header="CornerRadius" />
		<datagrideditors:DataGridDateColumn Binding="{Binding DateValue}" Header="Date" />
		<datagrideditors:DataGridDateTimeColumn Binding="{Binding DateTimeValue}" Header="DateTime" />
		<datagrideditors:DataGridDoubleColumn Binding="{Binding DoubleValue}" Header="Double" />
		<datagrideditors:DataGridEnumColumn Binding="{Binding EnumValue}" Header="Enum" />
		<datagrideditors:DataGridGuidColumn Binding="{Binding GuidValue}" Header="Guid" />
		<datagrideditors:DataGridInt16Column Binding="{Binding Int16Value}" Header="Int16" />
		<datagrideditors:DataGridInt32Column Binding="{Binding Int32Value}" Header="Int32" />
		<datagrideditors:DataGridInt32RectColumn Binding="{Binding Int32RectValue}" Header="Int32Rect" />
		<datagrideditors:DataGridInt64Column Binding="{Binding Int64Value}" Header="Int64" />
		<datagrideditors:DataGridMaskedStringColumn Binding="{Binding StringValue}" Header="String" />
		<datagrideditors:DataGridPointColumn Binding="{Binding PointValue}" Header="Point" />
		<datagrideditors:DataGridRectColumn Binding="{Binding RectValue}" Header="Rect" />
		<datagrideditors:DataGridSingleColumn Binding="{Binding SingleValue}" Header="Single" />
		<datagrideditors:DataGridSizeColumn Binding="{Binding SizeValue}" Header="Size" />
		<datagrideditors:DataGridThicknessColumn Binding="{Binding ThicknessValue}" Header="Thickness" />
		<datagrideditors:DataGridTimeColumn Binding="{Binding TimeValue}" Header="Time" />
		<datagrideditors:DataGridTimeSpanColumn Binding="{Binding TimeSpanValue}" Header="TimeSpan" />
		<datagrideditors:DataGridVectorColumn Binding="{Binding VectorValue}" Header="Vector" />
	</toolkit:DataGrid.Columns>
</toolkit:DataGrid>
```
