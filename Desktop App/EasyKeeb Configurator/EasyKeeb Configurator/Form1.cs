using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyKeeb_Configurator
{
    public partial class Form1 : Form
    {
        Dictionary<string, uint> keycodes = new Dictionary<string, uint>();



        public Form1()
        {
            InitializeComponent();

            keycodes.Add("Left Ctrl", 106);
            keycodes.Add("Left Shift", 1);
            keycodes.Add("Left Alt", 2);
            keycodes.Add("Left Windows Key", 3);
            keycodes.Add("A", 4);
            keycodes.Add("B", 5);
            keycodes.Add("C", 6);
            keycodes.Add("D", 7);
            keycodes.Add("E", 8);
            keycodes.Add("F", 9);
            keycodes.Add("G", 10);
            keycodes.Add("H", 11);
            keycodes.Add("I", 12);
            keycodes.Add("J", 13);
            keycodes.Add("K", 14);
            keycodes.Add("L", 15);
            keycodes.Add("M", 16);
            keycodes.Add("N", 17);
            keycodes.Add("O", 18);
            keycodes.Add("P", 19);
            keycodes.Add("Q", 20);
            keycodes.Add("R", 21);
            keycodes.Add("S", 22);
            keycodes.Add("T", 23);
            keycodes.Add("U", 24);
            keycodes.Add("V", 25);
            keycodes.Add("W", 26);
            keycodes.Add("X", 27);
            keycodes.Add("Y", 28);
            keycodes.Add("Z", 29);
            keycodes.Add("1", 30);
            keycodes.Add("2", 31);
            keycodes.Add("3", 32);
            keycodes.Add("4", 33);
            keycodes.Add("5", 34);
            keycodes.Add("6", 35);
            keycodes.Add("7", 36);
            keycodes.Add("8", 37);
            keycodes.Add("9", 38);
            keycodes.Add("0", 39);
            keycodes.Add("Enter", 40);
            keycodes.Add("Esc", 41);
            keycodes.Add("Backspace", 42);
            keycodes.Add("Tab", 43);
            keycodes.Add("Space", 44);
            keycodes.Add("-", 45);
            keycodes.Add("=", 46);
            keycodes.Add("[", 47);
            keycodes.Add("]", 48);
            keycodes.Add("\\", 49);
            //keycodes.Ad, "NON_US_NUM", d();
            keycodes.Add(";", 51);
            keycodes.Add("'", 52);
            keycodes.Add("~", 53);
            keycodes.Add(",", 54);
            keycodes.Add(".", 55);
            keycodes.Add("/", 56);
            keycodes.Add("Caps Lock", 57);
            keycodes.Add("F1", 58);
            keycodes.Add("F2", 59);
            keycodes.Add("F3", 60);
            keycodes.Add("F4", 61);
            keycodes.Add("F5", 62);
            keycodes.Add("F6", 63);
            keycodes.Add("F7", 64);
            keycodes.Add("F8", 65);
            keycodes.Add("F9", 66);
            keycodes.Add("F10", 67);
            keycodes.Add("F11", 68);
            keycodes.Add("F12", 69);
            keycodes.Add("Print", 70);
            keycodes.Add("Scroll Lock", 71);
            keycodes.Add("Pause/Break", 72);
            keycodes.Add("Insert", 73);
            keycodes.Add("Home", 74);
            keycodes.Add("Page Up", 75);
            keycodes.Add("Delete", 76);
            keycodes.Add("End", 77);
            keycodes.Add("Page Down", 78);
            keycodes.Add("→", 79);
            keycodes.Add("←", 80);
            keycodes.Add("↓", 81);
            keycodes.Add("↑", 82);
            keycodes.Add("Num Lock", 83);
            keycodes.Add("Keypad /", 84);
            keycodes.Add("Keypad *", 85);
            keycodes.Add("Keypad -", 86);
            keycodes.Add("Keypad +", 87);
            keycodes.Add("Keypad Enter", 88);
            keycodes.Add("Keypad 1", 89);
            keycodes.Add("Keypad 2", 90);
            keycodes.Add("Keypad 3", 91);
            keycodes.Add("Keypad 4", 92);
            keycodes.Add("Keypad 5", 93);
            keycodes.Add("Keypad 6", 94);
            keycodes.Add("Keypad 7", 95);
            keycodes.Add("Keypad 8", 96);
            keycodes.Add("Keypad 9", 97);
            keycodes.Add("Keypad 0", 98);
            keycodes.Add("Keypad .", 99);
            //keycodes.Add("NON_US", 100);
            keycodes.Add("Menu", 101);
            keycodes.Add("Right Ctrl", 102);
            keycodes.Add("Right Shift", 103);
            keycodes.Add("Right Alt", 104);
            keycodes.Add("Right Windows Key", 105);
            keycodes.Add("Layer 0", 200);
            keycodes.Add("Layer 1", 201);
            keycodes.Add("Layer 2", 202);
            keycodes.Add("Layer 3", 203);
            keycodes.Add("Layer 4", 204);
            keycodes.Add("Layer 5", 205);
            keycodes.Add("Layer 6", 206);
            keycodes.Add("Layer 7", 207);
            keycodes.Add("Layer 8", 208);
            keycodes.Add("Layer 9", 209);
            keycodes.Add("Toggle Layer 0", 210);
            keycodes.Add("Toggle Layer 1", 211);
            keycodes.Add("Toggle Layer 2", 212);
            keycodes.Add("Toggle Layer 3", 213);
            keycodes.Add("Toggle Layer 4", 214);
            keycodes.Add("Toggle Layer 5", 215);
            keycodes.Add("Toggle Layer 6", 216);
            keycodes.Add("Toggle Layer 7", 217);
            keycodes.Add("Toggle Layer 8", 218);
            keycodes.Add("Toggle Layer 9", 219);

            cboKey.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach(KeyValuePair<string,uint> p in keycodes)
            {
                cboKey.Items.Add(p.Key);
            }

        }


    }
}
