---
title: "Overview"
page-title: "Grids Reference"
order: 1
---
# Overview

Actipro Grids is a product that includes our `PropertyGrid` and custom tree structure (`TreeListBox` and `TreeListView`) controls.

`PropertyGrid` allows for all the properties of one or more objects to be displayed, optionally using categories.  Pre-defined editors for modifying properties are auto-generated based on property type, and custom property/category editors can be easily created, allowing for total customization of the property editing experience.

`PropertyGrid` can also optionally harness our advanced data editing controls found in our [Editors](../editors/index.md) product (sold separately) when appropriate.  Many editing features are driven using standard .NET attributes like `BrowsableAttribute`, `CategoryAttribute`, `DisplayNameAttribute`, etc.  Support for sorting, filtering, collections, read-only display, nested properties, and deep customization are all included.

`TreeListBox` is a single-column tree control similar to the Visual Studio **Solution Explorer** tree control.  `TreeListView` is a multi-column variant of `TreeListBox` that renders similar to a standard `ListView` but has additional features.

## Features

### PropertyGrid Control

- Displays a grid of all accessible properties for one or more objects, with full UI virtualization support.
- Based on `TreeListView`, thereby inheriting all of it and `TreeListBox`'s UI customization features.
- Numerous built-in property editors are provided, and custom property editors can be created to customize the look and/or feel of a given property.
- Property editors can be tied to a property by name, `Type`, or both, which allows for all properties of a specified Type to use the same editor.
- A model-based data factory architecture allows for complete low-level customization of the property item presented.
- Explicitly-defined property models can be used in place of, or in addition to, any property models dynamically-generated by a factory.
@if (winrt) {
- Support for `DisplayAttribute` and several other `ComponentModel` attributes.
}
@if (wpf) {
- Support for `BrowsableAttribute`, `DisplayNameAttribute`, `DescriptionAttribute`, and several other `ComponentModel` attributes.
}
@if (winrt) {
- Properties can be automatically categorized via usage of `DisplayAttribute`, and nested categories can be created with a special syntax.
}
@if (wpf) {
- Properties can be automatically categorized via usage of `CategoryAttribute`, and nested categories can be created with a special syntax.
}
- Built-in and custom filters can be used to exclude items from being displayed.
- Properties can be automatically sorted, and custom sort comparers can be defined.
- Options for determining whether categories and properties are expanded by default.
- Advanced expansion and inline editing (including adding/removing items where appropriate) support for collections, lists and dictionaries.
- Ability to merge multiple objects, which means only properties common to all objects are presented.
- Support for custom category editors, which can be used to provide more complex interfaces for presenting/modifying specified properties.
- Support for expandable properties and lazy loading, which allows for cyclic references and faster load times.
@if (wpf) {
- Full support and integration with the standard platform data validation infrastructure.
}
@if (wpf) {
- Attached properties are supported and can be filtered.
}
- Includes fully customizable and resizable summary area, which shows details about the selected property item.
- Columns can be resized or customized as needed to provide a different appearance, and new columns can even be added.
- Read-only state can be used to prevent changes to items through the UI.
- Customizable built-in context menu.
- Events for property value changes and collection children add/removes.

### TreeListBox Control

- Fully customize the appearance of each node.
- UI virtualization, allowing for hundreds of thousands of nodes to be loaded into a tree very quickly.
- No scrollbar jumpiness as seen in other virtualized tree controls when scrolling vertically.
- Use your own custom data models as the source for the tree, with no dependencies on UI or our interfaces.  An adapter class is used (and can be fully customized to fit your model) to communicate between the UI and the model for things like expansion state, getting children, etc.
- The adapter can be coded with bindings in XAML (convenient yet can be slow in very large trees) or via method overrides (slightly more work but lightning fast).
- Optionally show the root item in the control.
- Fine-grained control over expandability and children query triggers.
- Optional async loading with busy indicator display.
- Events for expansion.
- Events for selection.
- Single or multi-selection, with <kbd>Ctrl</kbd> and <kbd>Shift</kbd>-based selection options.
- Filter selection such as only allowing sibling nodes to be multi-selected, or nodes of the same depth.
- All common tree hotkeys supported including special ones for expanding and collapsing entire branches.
- Select or ensure nodes are visible by path.
- Double-click and <kbd>Enter</kbd> key default action handling.
- Optional checkboxes within the data templates.
- Intelligent text searching so when you start typing while the control has focus, it will auto-focus the item that matches the typed text.
- Inline editing via <kbd>F2</kbd> and single-click on a selected item.
- Per-item context menus that can be constructed dynamically via an event.
- Drag items to external controls, drop data from external controls, or drag/drop items within the control itself.
- Dragged items can highlight above, on, and below drop areas for each item.
- Single and multiple item dragging is supported.
- Optional data virtualization optimization when using virtualized collections.
- Indentation of top-level and other nodes can be set independently.
- Customizable item filtering that supports string, boolean, or predicate-based logic.
- Filtered items can automatically have their ancestors expanded.

### TreeListView Control

- All features found in `TreeListBox`.
- Templates, template selectors, or text property bindings used to specify custom content for each cell.
- Column width can be a specific pixel value, auto (size to header, cells, or both), or star-sized.
- Optional minimum and maximum widths for column auto/star-sizing modes.
- Columns can optionally be resized, reordered, and have visibility toggled by the end user.
- Frozen columns that don't scroll horizontally.
- Set which column renders the indentation and expander buttons.
- Column headers have a built-in context menu, and the headers themselves can be hidden.
- Size columns to fit contents.
- Optional grid line display.
- Numerous events for column resizing, reordering, visibility changes, and header menu requests.

*This product is written in 100% pure C#, and includes detailed documentation and samples.*
