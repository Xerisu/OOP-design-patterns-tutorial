using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class MacButton : IButton
    {
        public string Content { set; get; }

        public MacButton(string content)
        {
            Content = content;
        }

        public void ButtonPressed()
        {
            Console.WriteLine($"MacButton pressed! : {Content}");
        }

        public void DrawContent()
        {
            Console.WriteLine(Content);
        }
    }

    class MacTextbox : ITextBox
    {
        public string Content { get; set; }
        public MacTextbox(string content)
        {
            Content = content;
        }
        public void DrawContent()
        {
            Console.WriteLine(Content); 
        }
    }
    class MacGrid : IGrid
    {
        List<IButton> buttons = new List<IButton>();
        List<ITextBox> textBoxes = new List<ITextBox>();
        public void AddButton(IButton button)
        {
            buttons.Add(button);
        }

        public void AddTextBox(ITextBox textBox)
        {
            textBoxes.Add(textBox);
        }

        public IEnumerable<IButton> GetButtons()
        {
            return buttons;
        }

        public IEnumerable<ITextBox> GetTextBoxes()
        {
            return textBoxes;
        }
    }
}
