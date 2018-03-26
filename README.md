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

##Result:


![SavableObject in Xamarin Forms save data in Xamarin forms with no sql](https://media.giphy.com/media/23Z4AW80SrG8ZHrbjZ/giphy.gif)

