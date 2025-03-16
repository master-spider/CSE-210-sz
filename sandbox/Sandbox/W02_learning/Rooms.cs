

// Creating a variable of Window named bathroom
Window bathroom = new Window();
bathroom._width = 60;
bathroom._height = 48;
bathroom._color = "white";
// Creating a variable of double named area
double bathroomArea = bathroom.GetArea();
// Creating a variable of Window named bedroom
Window bedroom = new Window();
bedroom._width = 120;
bedroom._height = 58;
bedroom._color = "mellow yellow";
// Creating a variable of double named area
double bedroomArea = bedroom.GetArea();
// 
Console.WriteLine($"Area of the bathroom window is {bathroomArea} cm2");
// 
Console.WriteLine($"Area of the bedroom window is {bedroomArea} cm2");