using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class AndroidButton : IButton
    {
        public string Content { set; get; }

        public AndroidButton(string content)
        {
            Content = content;
        }

        public void ButtonPressed()
        {
            Console.WriteLine($"AndroidButton pressed! : {Content}");
        }

        public void DrawContent()
        {
            Console.WriteLine(Content);
        }
    }

    class AndroidTextbox : ITextBox
    {
        private string _content;
        public string Content 
        { 
            get => _content; 
            set
            {
          
                _content = String.Concat(value.Reverse());   

            }
        }
        public AndroidTextbox(string content)
        {
            Content = content;
        }
        public void DrawContent()
        {
            Console.WriteLine(Content);
        }
    }
    class AndroidGrid : IGrid
    {
        List<IButton> buttons = new List<IButton>();
        public void AddButton(IButton button)
        {
            buttons.Add(button);
        }

        public void AddTextBox(ITextBox textBox)
        {
           // :c
        }

        public IEnumerable<IButton> GetButtons()
        {
            return buttons;
        }

        public IEnumerable<ITextBox> GetTextBoxes()
        {
            return new List<ITextBox>();
        }
    }
}
