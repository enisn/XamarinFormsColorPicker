# XamarinFormsColorPicker
Easily pick color in xamarin forms applications. 
You can easily use it like **DisplayAlert()** method 


##Usage 
You can use with default colors:
```csharp
var result = await ColorPicker.GetColorAsync("Primary Color", "Choose a color:");
```

Or You may want to set your custom colors:

```csharp
var result = await ColorPicker.GetColorAsync("Primary Color", "Choose a color:",Color.Cyan, Color.Aqua, Color.Azure, Color.Blue, Color.BlueViolet);
```


