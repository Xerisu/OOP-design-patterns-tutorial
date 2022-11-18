using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface ITextBox
    {
        string Content { set; }
        void DrawContent();
    }

    public interface IGrid
    {
        void AddButton(IButton button);
        void AddTextBox(ITextBox textBox);
        IEnumerable<IButton> GetButtons();
        IEnumerable<ITextBox> GetTextBoxes();
    }

    public interface IButton
    {
        string Content { set; }
        void DrawContent();
        void ButtonPressed();
    }

}
