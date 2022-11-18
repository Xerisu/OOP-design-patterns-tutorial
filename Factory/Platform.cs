using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    interface IPlatform  
    {
        IButton CreateButton(string content);
        IGrid CreateGrid();
        ITextBox CreateTextBox(string content);

    }

    class AndroidPlatform : IPlatform
    {
        public IButton CreateButton(string content)
        {
            return new AndroidButton(content);
        }

        public IGrid CreateGrid()
        {
            return new AndroidGrid();
        }

        public ITextBox CreateTextBox(string content)
        {
            return new AndroidTextbox(content);
        }
    }
    class MacPlatform : IPlatform
    {
        public IButton CreateButton(string content)
        {
            return new MacButton(content);
        }

        public IGrid CreateGrid()
        {
            return new MacGrid();
        }

        public ITextBox CreateTextBox(string content)
        {
            return new MacTextbox(content);
        }
    }
}
