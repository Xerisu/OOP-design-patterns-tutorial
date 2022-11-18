// Uw
using Factory;

static IGrid CreateGUI(IPlatform platform)
{
    IGrid grid = platform.CreateGrid();
    IButton button1 = platform.CreateButton("Button 1");
    IButton button2 = platform.CreateButton("Happy button");
    IButton button3 = platform.CreateButton("Nie będziesz mi mówił jak mam żyć.");
    grid.AddButton(button1);
    grid.AddButton(button2);
    grid.AddButton(button3);
    ITextBox textBox1 = platform.CreateTextBox("This is some text.");
    ITextBox textBox2 = platform.CreateTextBox("Yay! And there's more!");
    grid.AddTextBox(textBox2);
    grid.AddTextBox(textBox1);
    return grid;
}
static void PrintGUI(IGrid grid)
{
    Console.WriteLine("Buttons:");
    foreach(var button in grid.GetButtons())
    {
        button.ButtonPressed();
        button.DrawContent();
    } 
    foreach(var textbox in grid.GetTextBoxes())
    {
        textbox.DrawContent();
    }
}

var gui = CreateGUI(new AndroidPlatform ());
PrintGUI(gui);