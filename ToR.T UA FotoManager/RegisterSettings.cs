using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using Microsoft.Win32;
//using System.Windows.Forms;

namespace RegConf
{
    class ConfPar
    {
        const string regKeyName = "Software\\ToR.T_UA™\\Foto Manager";
        public class INT
        {
            public int DefaulValue;
            private int _Value;
            public int Value
            {
                get
                {
                    if (loaded) return _Value;
                    _Value = Load();
                    loaded = true;
                    return _Value;
                }
                set { loaded = false; Save(value); }
            }
            private bool loaded = false;
            private string RegitryName;

            public INT(String RegName, int DefVal) // construct
            {
                RegitryName = RegName;
                DefaulValue = DefVal;
            }

            //public dynamic Main() { return Load(); } // try s...

            private bool Save(int SaveValue)
            {
                RegistryKey rk = null;
                try
                {
                    rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                    if (rk == null)
                        return false;
                    rk.SetValue(RegitryName, SaveValue);
                }
                catch (Exception e) { Console.Write("{0} Exception caught while Save: {1}.", e, RegitryName); }
                finally
                {
                    if (rk != null)
                        rk.Close();
                }
                return true;
                /*bool result = false;
                try
                {
                    rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                    if (rk != null)
                        result = Value == rk.GetValue(Param, null);
                }
                finally
                {
                    if (rk != null)
                        rk.Close();
                }
                return result;*/
            }

            private dynamic Load()
            {
                RegistryKey rk = null;
                int Data = DefaulValue;
                try
                {
                    rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                    if (rk != null)
                        Data = (int)rk.GetValue(RegitryName, DefaulValue);
                }
                catch (Exception e) { Console.Write("{0} Exception caught while Load: {1}.", e, RegitryName); }
                finally
                {
                    if (rk != null)
                        rk.Close();
                }
                return Data;
            }
        }
        public class STRING
        {
            public string DefaulValue;
            private string _Value;
            public string Value
            {
                get
                {
                    if (loaded) return _Value;
                    _Value = Load();
                    loaded = true;
                    return _Value;
                }
                set { loaded = false; Save(value); }
            }
            private bool loaded = false;
            private string RegitryName;

            public STRING(String RegName, string DefVal) // construct
            {
                RegitryName = RegName;
                DefaulValue = DefVal;
            }

            //public dynamic Main() { return Load(); } // try s...

            private bool Save(string SaveValue)
            {
                RegistryKey rk = null;
                try
                {
                    rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                    if (rk == null)
                        return false;
                    rk.SetValue(RegitryName, SaveValue);
                }
                catch (Exception e) { Console.Write("{0} Exception caught while Save: {1}.", e, RegitryName); }
                finally
                {
                    if (rk != null)
                        rk.Close();
                }
                return true;
                /*bool result = false;
                try
                {
                    rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                    if (rk != null)
                        result = Value == rk.GetValue(Param, null);
                }
                finally
                {
                    if (rk != null)
                        rk.Close();
                }
                return result;*/
            }

            private dynamic Load()
            {
                RegistryKey rk = null;
                string Data = DefaulValue;
                try
                {
                    rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                    if (rk != null)
                        Data = (string)rk.GetValue(RegitryName, DefaulValue);
                }
                catch (Exception e) { Console.Write("{0} Exception caught while Load: {1}.", e, RegitryName); }
                finally
                {
                    if (rk != null)
                        rk.Close();
                }
                return Data;
            }
        }
        public class BOOL
        {
            public bool DefaulValue;
            private bool _Value;
            public bool Value
            {
                get
                {
                    if (loaded) return _Value;
                    _Value = Load();
                    loaded = true;
                    return _Value;
                }
                set { loaded = false; Save(value); }
            }
            private bool loaded = false;
            private string RegitryName;

            public BOOL(String RegName, bool DefVal) // construct
            {
                RegitryName = RegName;
                DefaulValue = DefVal;
            }

            //public dynamic Main() { return Load(); } // try s...

            private bool Save(bool SaveValue)
            {
                RegistryKey rk = null;
                try
                {
                    rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                    if (rk == null)
                        return false;
                    rk.SetValue(RegitryName, SaveValue);
                }
                catch (Exception e) { Console.Write("{0} Exception caught while Save: {1}.", e, RegitryName); }
                finally
                {
                    if (rk != null)
                        rk.Close();
                }
                return true;
                /*bool result = false;
                try
                {
                    rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                    if (rk != null)
                        result = Value == rk.GetValue(Param, null);
                }
                finally
                {
                    if (rk != null)
                        rk.Close();
                }
                return result;*/
            }

            private dynamic Load()
            {
                RegistryKey rk = null;
                bool Data = DefaulValue;
                try
                {
                    rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                    if (rk != null)
                        Data = (bool)rk.GetValue(RegitryName, DefaulValue);
                }
                catch (Exception e) { Console.Write("{0} Exception caught while Load: {1}.", e, RegitryName); }
                finally
                {
                    if (rk != null)
                        rk.Close();
                }
                return Data;
            }
        }
    }

    class Conf
    {
        //your Register path
       
        public class MainFm
        {
            public static ConfPar.INT PosX = new ConfPar.INT("MainForm_X", -1);
            public static ConfPar.INT PosY = new ConfPar.INT("MainForm_Y", -1);
            public static ConfPar.INT Height = new ConfPar.INT("MainForm_H", -1);
            public static ConfPar.BOOL ShowAsTiles = new ConfPar.BOOL("ShowImagesAsTiles", false);
        }
        public class ConfFm
        {
            public static ConfPar.INT PosX = new ConfPar.INT("ConfForm_X", -1);
            public static ConfPar.INT PosY = new ConfPar.INT("ConfForm_Y", -1);
            public static ConfPar.STRING PhotoPath = new ConfPar.STRING("MainPhotoFolder", "");
            public static ConfPar.INT StartYear = new ConfPar.INT("StartYearFrom", 2016);
            public static ConfPar.BOOL NumberToMonth = new ConfPar.BOOL("AddNumericMonth", true);
            public static ConfPar.BOOL ShowDayImagesCount = new ConfPar.BOOL("ShowDayImagesCount", true);            
        }
        public class LookAtMe
        {
            public static ConfPar.INT PosX = new ConfPar.INT("LookAtMe_X", -1);
            public static ConfPar.INT PosY = new ConfPar.INT("LookAtMe_Y", -1);
            public static ConfPar.INT Height = new ConfPar.INT("LookAtMe_H", 400);
            public static ConfPar.INT Width = new ConfPar.INT("LookAtMe_W", 400);
        }
    }
}
