---
title: "Supporting Controls"
page-title: "Supporting Controls - ZoomContentControl Features"
order: 6
---
# Supporting Controls

There are two controls that support the [ZoomContentControl](xref:@ActiproUIRoot.Controls.Navigation.ZoomContentControl) that can be used independently, as needed. This topic covers these controls and their options.

## PanPad

The [PanPad](xref:@ActiproUIRoot.Controls.Navigation.Primitives.PanPad) control allows continuous and directional scrolling using the mouse. Once the control has been clicked it will continuously raise the [Pan](xref:@ActiproUIRoot.Controls.Navigation.Primitives.PanPad.Pan) event while the mouse button is held down.

The offsets of the [Pan](xref:@ActiproUIRoot.Controls.Navigation.Primitives.PanPad.Pan) event are calculated using the mouse click location and the current mouse location, which includes both a direction and a magnitude. The offsets can be limited using the [MaxOffset](xref:@ActiproUIRoot.Controls.Navigation.Primitives.PanPad.MaxOffset) property.

Finally, the interval at which the [Pan](xref:@ActiproUIRoot.Controls.Navigation.Primitives.PanPad.Pan) event is raised can be customized using the [Interval](xref:@ActiproUIRoot.Controls.Navigation.Primitives.PanPad.Interval) property.

## ZoomDecorator

The [ZoomContentControl](xref:@ActiproUIRoot.Controls.Navigation.ZoomContentControl) uses a [ZoomDecorator](xref:@ActiproUIRoot.Controls.Navigation.ZoomDecorator) in the default control template to display its content.  The [ZoomDecorator](xref:@ActiproUIRoot.Controls.Navigation.ZoomDecorator) can be used to zoom or pan a `UIElement`, much like the [ZoomContentControl](xref:@ActiproUIRoot.Controls.Navigation.ZoomContentControl), but does not offer any built-in user interaction (such as mouse interaction, scrollbars, or the view control pane).  The view can still be programmatically zoomed or panned.

Since [ZoomDecorator](xref:@ActiproUIRoot.Controls.Navigation.ZoomDecorator) implements `IScrollInfo`, it can be wrapped in a `ScrollViewer` if only scrollbars are needed. The only requirement is that `ScrollViewer.CanContentScroll` be set to `true`.
