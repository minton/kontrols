kontrols
========

Random collection of WinForm controls for .NET

## Installing

kontrols is listed on NuGet here: https://www.nuget.org/packages/kontrols/ and can be installed from the NuGet Package manager: 

```
Install-Package kontrols -Version 0.2.5
```

## Controls

Control|Description
-------|-----------
`DesktopIcon`|A control which mimicks the behavior of a Windows desktop icon.
`HoverImageButton`|This control displays an image that changes when the user places the cursor over the control.
`HoverTextButton`|Displays text that changes color when the user places the cursor over the control.
`SimpleBorderForm`|A frameless Windows Form with a solid color border that is draggable.
`RoundedBorderForm`|A frameless Windows Form with a rounded border that is draggable and resizable.
`ToggleImageButton`|Displays an image that changes depending on if the control is toggled or not.
`ZoomMenu`|An animated menu consisting of one or more `ZoomItem`. This is similiar to the Dock in macOS.

### Using `DesktopIcon`

This control attemps to mimmick the icons on the Windows desktop. 

![](https://github.com/minton/kontrols/raw/master/DesktopIcon.PNG)

Property|Type|Description
--------|----|-----------
`ForeColor`|[`Color`](https://msdn.microsoft.com/en-us/library/system.drawing.color(v=vs.110).aspx)|The foreground color of the text.
`GrayScaleWhenDisabled`|[`bool`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/bool)|Determines if the control is drawn in grayscale when disabled
`HoverColor`|[`Color`](https://msdn.microsoft.com/en-us/library/system.drawing.color(v=vs.110).aspx)|The color used to indicate the mouse is over the icon.
`HoverImage`|[`Image`](https://msdn.microsoft.com/en-us/library/system.drawing.image(v=vs.110).aspx)|The image displayed when the cursor is over the control.`HoverForeColor`|[`Color`](https://msdn.microsoft.com/en-us/library/system.drawing.color(v=vs.110).aspx)|The foreground color of the text **when the cursor is over the control**.
`IconSquare`|[`IconSize`](https://github.com/minton/kontrols/blob/master/src/kontrols/DesktopIcon.cs#L22)|The icon will be fit into this square while the text string will account for the rest of the space
`Image`|[`Image`](https://msdn.microsoft.com/en-us/library/system.drawing.image(v=vs.110).aspx)|The image displayed when the cursor is **not** over the control.

### Using `HoverImageButton` & `ToggleImageButton`

The image-based controls can also display text that can be configured using the same properties as the `HoverTextButton`. To configure the images you'll need to specify which image should be used for both the hover and non-hover states.

Property|Type|Description
--------|----|-----------
`GrayScaleWhenDisabled`|[`bool`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/bool)|Determines if the control is drawn in grayscale when disabled
`HoverBackColor`|[`Color`](https://msdn.microsoft.com/en-us/library/system.drawing.color(v=vs.110).aspx)|The background color **when the cursor is over the control**.
`HoverImage`|[`Image`](https://msdn.microsoft.com/en-us/library/system.drawing.image(v=vs.110).aspx)|The image displayed when the cursor is over the control.
`Image`|[`Image`](https://msdn.microsoft.com/en-us/library/system.drawing.image(v=vs.110).aspx)|The image displayed when the cursor is **not** over the control.
`SizeMode`|[`PictureBoxSizeMode`](https://msdn.microsoft.com/en-us/library/system.windows.forms.pictureboxsizemode(v=vs.110).aspx)| This property is borrowed from the standard [`PictureBox`](https://msdn.microsoft.com/en-us/library/System.Windows.Forms.PictureBox(v=vs.110).aspx) control and provides the same behavior.

### Using `HoverTextButton`

To use this control you need to specify which colors should be used for both the hover and non-hover states.

Property|Type|Description
--------|----|-----------
`ForeColor`|[`Color`](https://msdn.microsoft.com/en-us/library/system.drawing.color(v=vs.110).aspx)|The foreground color of the text.
`GrayScaleWhenDisabled`|[`bool`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/bool)|Determines if the control is drawn in grayscale when disabled
`HoverForeColor`|[`Color`](https://msdn.microsoft.com/en-us/library/system.drawing.color(v=vs.110).aspx)|The foreground color of the text **when the cursor is over the control**.


### Using `SimpleBorderForm`

Property|Type|Description
--------|----|-----------
`ControlBox`|[`bool`](https://msdn.microsoft.com/en-us/library/api/system.windows.forms.form.controlbox(v=vs.110).aspx)|This property is borrowed from the standard [`Form`](https://msdn.microsoft.com/en-us/library/System.Windows.Forms.Form(v=vs.110).aspx) control and provides the same behavior.

This is a frameless (i.e., `FormBorderStyle=None`) window with a solid colored border.

1. Add a new Windows Form to your application. For this example, the form was named `MyNewForm`.
1. View the code for `MyNewForm.cs` and change it to inherit from `SimpleBorderForm` instead of `Form` like so:

```c#
public partial class MyNewForm : SimpleBorderForm
```
Now set the `BorderColor` property to any color and design the form like normal.

![](https://github.com/minton/kontrols/raw/master/SimpleBorderForm.png)

#### Moving the form around

By default the user can click any part of the form and drag it around. If you'd like the user to be able to move the form using a control you've added to it (i.e., a `Label` acting as the title) you can make that control draggable via the `AddDraggableControl()` method.

### Using `RoundedBorderForm`

This is a frameless (i.e., `FormBorderStyle=None`) window with a rounded border. It is resizable.

1. Add a new Windows Form to your application. For this example, the form was named `MyNewForm`.
1. View the code for `MyNewForm.cs` and change it to inherit from `RoundedBorderForm` instead of `Form` like so:

```c#
public partial class MyNewForm : RoundedBorderForm
```
Now set the `CornerRadius` property and the `BackgroundColor` property and then design the form like normal.

![](https://github.com/minton/kontrols/raw/master/RoundedBorderForm.png)

#### Moving the form around

By default, the user can click the title area (top center) to drag the form around. 

### Resizing the form

The user can resize the form using any of the four sides or corners excluding directly above the title area.

### Using `ZoomMenu`

![](https://github.com/minton/kontrols/raw/master/ZoomMenu.gif)

Each icon on the ZoomMenu is represented by a `ZoomItem`. To add new `ZoomItems` you can call the `Add` method passing an `Image` and `string` for the icon's image and text respectively.

```c#
zoomMenu.Add(myImage, "My Icon");
```

You can respond to icon clicks by subscribing to the `ZoomItemClicked` event:

```c#
zoomMenu.ZoomItemClicked += item => MessageBox.Show($"You clicked {item.Text}");
```

### Examples

Included in the `src` folder is an example application that show how to use each of the controls. 

![](https://github.com/minton/kontrols/raw/master/SampleApp.PNG)
