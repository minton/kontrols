kontrols
========

Random collection of WinForm controls for .NET

## Controls

|Control|Description|
|-------|-----------|
|`HoverTextButton`|Displays text that changes color when the user places the cursor over the control.|
|`HoverImageButton`|This control displays an image that changes when the user places the cursor over the control.|
|`ToggleImageButton`|Displays an image that changes depending on if the control is toggled or not.|
|`SimpleBorderForm`|A frameless Windows Form with a solid color border that is draggable.|

### Using `HoverTextButton`

To use this control you need to specify which colors should be used for both the hover and non-hover states.

|Property|Type|Description|
|--------|----|-----------|
|`ForeColor`|[`Color`](https://msdn.microsoft.com/en-us/library/system.drawing.color(v=vs.110).aspx)|The foreground color of the text.|
|`HoverForeColor`|[`Color`](https://msdn.microsoft.com/en-us/library/system.drawing.color(v=vs.110).aspx)|The foreground color of the text **when the cursor is over the control**.|



### Using `HoverImageButton` & `ToggleImageButton`

The image-based controls can also display text that can be configured using the same properties as the `HoverTextButton`. To configure the images you'll need to specify which image should be used for both the hover and non-hover states.

|Property|Type|Description|
|--------|----|-----------|
|`Image`|[`Image`](https://msdn.microsoft.com/en-us/library/system.drawing.image(v=vs.110).aspx)|The image displayed when the cursor is **not** over the control.|
|`HoverImage`|[`Image`](https://msdn.microsoft.com/en-us/library/system.drawing.image(v=vs.110).aspx)|The image displayed when the cursor is over the control.|
|`SizeMode`|[`PictureBoxSizeMode`](https://msdn.microsoft.com/en-us/library/system.windows.forms.pictureboxsizemode(v=vs.110).aspx)| This property is borrowed from the standard [`PictureBox`](https://msdn.microsoft.com/en-us/library/System.Windows.Forms.PictureBox(v=vs.110).aspx) control and provides the same behavior.

### Using `SimpleBorderForm`

This is a frameless (i.e., `FormBorderStyle=None`) window with a solid colored border.

### Examples

Included in the `src` folder is an example application that show how to use each of the controls. 
