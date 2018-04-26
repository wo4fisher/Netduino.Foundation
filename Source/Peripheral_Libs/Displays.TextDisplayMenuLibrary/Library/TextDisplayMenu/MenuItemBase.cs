using System;
using System.Collections;
using Microsoft.SPOT;

namespace Netduino.Foundation.Displays.TextDisplayMenu
{
    public class MenuItem : IMenuItem
    {
        public MenuPage SubMenu
        { get; set; } = new MenuPage();

        public string Text { get; set; } = string.Empty;

        public string Command { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public string ItemID { get; set; } = string.Empty;

        public object Value { get; set; }

        public MenuItem(string displayText)
        {
            Text = displayText;
        }

        public MenuItem(string displayText, string command, string id, string type)
        {
            Text = displayText;
            Command = command ?? string.Empty;
            ItemID = id ?? string.Empty;
            Type = type ?? string.Empty;
        }
    }
}
