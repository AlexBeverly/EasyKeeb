﻿using System;
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
        Dictionary<string, int> keycodes = new Dictionary<string, int>();
        Dictionary<string, byte> keys = new Dictionary<string, byte>();

        byte[] keymap = new byte[116];
        string curBtn = "", export = "", import = "";

        /*public string ExportString(byte[] keymap)
        {

        }
*/
        public Form1()
        {
            InitializeComponent();

            //fill keycode dictionary - assigns key strings to their keycodes
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
            //keycodes.Add("NON_US_NUM", 50);   NON_US_NUM key is not applicable and is only here for reference
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
            keycodes.Add("Print Sc", 70);
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
            //keycodes.Add("NON_US", 100);  //NON_US key is not applicable and is only here for reference
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

            //fill keys dictionary - assigns an ID number to button name strings (btn.Name)
            keys.Add("btnLCtrl",    0);
            keys.Add("btnLSh",      1);
            keys.Add("btnLAlt",     2);
            keys.Add("btnLGUI",     3);
            keys.Add("btnA",        4);
            keys.Add("btnB",        5);
            keys.Add("btnC",        6);
            keys.Add("btnD",        7);
            keys.Add("btnE",        8);
            keys.Add("btnF",        9);
            keys.Add("btnG",        10);
            keys.Add("btnH",        11);
            keys.Add("btnI",        12);
            keys.Add("btnJ",        13);
            keys.Add("btnK",        14);
            keys.Add("btnL",        15);
            keys.Add("btnM",        16);
            keys.Add("btnN",        17);
            keys.Add("btnO",        18);
            keys.Add("btnP",        19);
            keys.Add("btnQ",        20);
            keys.Add("btnR",        21);
            keys.Add("btnS",        22);
            keys.Add("btnT",        23);
            keys.Add("btnU",        24);
            keys.Add("btnV",        25);
            keys.Add("btnW",        26);
            keys.Add("btnX",        27);
            keys.Add("btnY",        28);
            keys.Add("btnZ",        29);
            keys.Add("btn1",        30);
            keys.Add("btn2",        31);
            keys.Add("btn3",        32);
            keys.Add("btn4",        33);
            keys.Add("btn5",        34);
            keys.Add("btn6",        35);
            keys.Add("btn7",        36);
            keys.Add("btn8",        37);
            keys.Add("btn9",        38);
            keys.Add("btn0",        39);
            keys.Add("btnEnt",      40);
            keys.Add("btnEsc",      41);
            keys.Add("btnBsp",      42);
            keys.Add("btnTab",      43);
            keys.Add("btnSpc",      44);
            keys.Add("btnMin",      45);
            keys.Add("btnEql",      46);
            keys.Add("btnLbr",      47);
            keys.Add("btnRbr",      48);
            keys.Add("btnBsl",      49);
            keys.Add("btnScl",      50);
            keys.Add("btnQuot",     51);
            keys.Add("btnGrv",      52);
            keys.Add("btnCom",      53);
            keys.Add("btnPer",      54);
            keys.Add("btnSlsh",     55);
            keys.Add("btnCap",      56);
            keys.Add("btnF1",       57);
            keys.Add("btnF2",       58);
            keys.Add("btnF3",       59);
            keys.Add("btnF4",       60);
            keys.Add("btnF5",       61);
            keys.Add("btnF6",       62);
            keys.Add("btnF7",       63);
            keys.Add("btnF8",       64);
            keys.Add("btnF9",       65);
            keys.Add("btnF10",      66);
            keys.Add("btnF11",      67);
            keys.Add("btnF12",      68);
            keys.Add("btnPrnt",     69);
            keys.Add("btnScrLk",    70);
            keys.Add("btnPause",    71);
            keys.Add("btnIns",      72);
            keys.Add("btnHm",       73);
            keys.Add("btnPgUp",     74);
            keys.Add("btnDel",      75);
            keys.Add("btnEnd",      76);
            keys.Add("btnPgDn",     77);
            keys.Add("btnRight",    78);
            keys.Add("btnLeft",     79);
            keys.Add("btnDn",       80);
            keys.Add("btnUp",       81);
            keys.Add("btnNumLk",    82);
            keys.Add("btnNumSlsh",  83);
            keys.Add("btnNumStr",   84);
            keys.Add("btnNumMin",   85);
            keys.Add("btnNumPlus",  86);
            keys.Add("btnNumEnt",   87);
            keys.Add("btnNum1",     88);
            keys.Add("btnNum2",     89);
            keys.Add("btnNum3",     90);
            keys.Add("btnNum4",     91);
            keys.Add("btnNum5",     92);
            keys.Add("btnNum6",     93);
            keys.Add("btnNum7",     94);
            keys.Add("btnNum8",     95);
            keys.Add("btnNum9",     96);
            keys.Add("btnNum0",     97);
            keys.Add("btnNumPer",   98);
            keys.Add("btnMenu",     99);
            keys.Add("btnRCtrl",    100);
            keys.Add("btnRSh",      101);
            keys.Add("btnRAlt",     102);
            keys.Add("btnRGUI",     103);
            keys.Add("btnEx0",      104);
            keys.Add("btnEx1",      105);
            keys.Add("btnEx2",      106);
            keys.Add("btnEx3",      107);
            keys.Add("btnEx4",      108);
            keys.Add("btnEx5",      109);
            keys.Add("btnEx6",      110);
            keys.Add("btnEx7",      111);
            keys.Add("btnEx8",      112);
            keys.Add("btnEx9",      113);

            cboKey.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach(KeyValuePair<string,int> p in keycodes)
            {
                cboKey.Items.Add(p.Key);
            }

            foreach (Control c in pnlKeys.Controls)
            {
                c.MouseClick += new MouseEventHandler(
                    delegate (object sender, MouseEventArgs e)
                    {
                        Button btn = (Button)sender;
                        curBtn = btn.Name;
                        if (!cboKey.Enabled) cboKey.Enabled = true;
                        cboKey.SelectedIndex = keys[curBtn];
                    });
            }
        }

        private void cboKey_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.Name == curBtn) c.Text = cboKey.Text;
            }
        }
    }
}