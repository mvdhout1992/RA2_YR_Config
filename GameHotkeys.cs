using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Nyerguds.Ini;

namespace RA2_YR_Config
{
    public class GameHotkeys
    {
        private List<GameHotkeyStruct> LoadedHotkeys = new List<GameHotkeyStruct>();

        public GameHotkeyStruct Get_Hotkey(int Index)
        {
            return LoadedHotkeys[Index];
        }

        // returns how many hotkeys were loaded
        public int Load_Hotkeys(IniFile inifile)
        {
            var hotkeys = inifile.GetSectionKeys("Hotkey");
            if (hotkeys != null)
            {
                for (int i = 0; i < hotkeys.Count; i++)
                {

                    GameHotkeyStruct HK = new GameHotkeyStruct((short)inifile.GetIntValue("Hotkey", hotkeys[i], 0), 
                        hotkeys[i]);

                    LoadedHotkeys.Add(HK);
                }
            }
            else
            {
                return 0;
            }

            return hotkeys.Count;
        }

        public void Save_Hotkeys(IniFile inifile)
        {
            foreach(var HK in LoadedHotkeys)
            {
                short CalculatedKey = 0;
                CalculatedKey += (short)(HK.KeyModifier << 8);
                CalculatedKey += HK.Key;
                
                inifile.SetIntValue("Hotkey", HK.HotkeyName, CalculatedKey);
            }
        }


        public String Hotkey_Display_Value(int HotkeyIndex)
        {
            string str = "";
            if ( (LoadedHotkeys[HotkeyIndex].KeyModifier & (byte)KeyModifiers.CtrlKey) != 0)
            {
                str += "Ctrl+";
            }
            if ((LoadedHotkeys[HotkeyIndex].KeyModifier & (byte)KeyModifiers.AltKey) != 0)
            {
                str += "Alt+";
            }
            if ((LoadedHotkeys[HotkeyIndex].KeyModifier & (byte)KeyModifiers.ShiftKey) != 0)
            {
                str += "Shift+";
            }

           return str += ((System.Windows.Forms.Keys)LoadedHotkeys[HotkeyIndex].Key).ToString();
        }


        public void Set_Hotkey_Value(KeyEventArgs e, int HotkeyIndex)
        {
            var HK = LoadedHotkeys[HotkeyIndex];
            HK.KeyModifier = 0;
            HK.Key = 0;

            if (e.Control) HK.KeyModifier += (byte)KeyModifiers.CtrlKey;
            if (e.Alt) HK.KeyModifier += (byte)KeyModifiers.AltKey;
            if (e.Shift) HK.KeyModifier += (byte)KeyModifiers.ShiftKey;

            HK.Key = (byte)e.KeyCode;
            LoadedHotkeys[HotkeyIndex] = HK;
        }
    }


    public struct GameHotkeyStruct
    {
        public byte Key;
        public byte KeyModifier;
        public string HotkeyName;

        public GameHotkeyStruct(byte Key_, byte KeyModifier_, string HotkeyName_)
        {
            this.Key = Key_;
            this.KeyModifier = KeyModifier_;
            this.HotkeyName = HotkeyName_;
        }

        public GameHotkeyStruct(short EncodedKeyValue, string HotkeyName_)
        {
            this.Key = (byte)(EncodedKeyValue & 255);
            this.KeyModifier = (byte)(EncodedKeyValue >> 8);
            this.HotkeyName = HotkeyName_;
        }

    }

    public enum KeyModifiers
    {
        AltKey = 4,
        CtrlKey = 2,
        ShiftKey = 1,
    }
}

