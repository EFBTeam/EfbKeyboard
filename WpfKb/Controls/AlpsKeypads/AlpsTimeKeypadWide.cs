using System.Collections.ObjectModel;
using WpfKb.Input;
using WpfKb.LogicalKeys;
using System.Windows;


namespace WpfKb.Controls
{
    public class AlpsTimeKeypadWide : UniformOnScreenKeyboard
    {
        public AlpsTimeKeypadWide()
        {
            Keys = new ObservableCollection<OnScreenKey>
                       {
                           new OnScreenKey { GridRow = 0, GridColumn = 0, Key = new VirtualKey(VirtualKeyCode.VK_7, "7") },
                           new OnScreenKey { GridRow = 0, GridColumn = 1, Key = new VirtualKey(VirtualKeyCode.VK_8, "8") },
                           new OnScreenKey { GridRow = 0, GridColumn = 2, Key = new VirtualKey(VirtualKeyCode.VK_9, "9") },
                           
                           new OnScreenKey { GridRow = 1, GridColumn = 0, Key = new VirtualKey(VirtualKeyCode.VK_4, "4") },           
                           new OnScreenKey { GridRow = 1, GridColumn = 1, Key = new VirtualKey(VirtualKeyCode.VK_5, "5") },
                           new OnScreenKey { GridRow = 1, GridColumn = 2, Key = new VirtualKey(VirtualKeyCode.VK_6, "6") },
                           
                           new OnScreenKey { GridRow = 2, GridColumn = 0, Key = new VirtualKey(VirtualKeyCode.VK_1, "1") },
                           new OnScreenKey { GridRow = 2, GridColumn = 1, Key = new VirtualKey(VirtualKeyCode.VK_2, "2") },
                           new OnScreenKey { GridRow = 2, GridColumn = 2, Key = new VirtualKey(VirtualKeyCode.VK_3, "3") },
                           
                           //Column 3  empty
                           //456
                           new OnScreenKey { GridRow = 0, GridColumn = 4, Key = new VirtualKey(VirtualKeyCode.BACK, IconDictionary.Icons["delete"], "") },
                           new OnScreenKey { GridRow = 0, GridColumn = 6, Key = new VirtualKey(VirtualKeyCode.F2, IconDictionary.Icons["plus-circle"], "") },
                           

                           new OnScreenKey { GridRow = 1, GridColumn = 4, Key = new VirtualKey(VirtualKeyCode.F1, IconDictionary.Icons["trash-2"], "") },
                           new OnScreenKey { GridRow = 1, GridColumn = 5, Key = new StringKey("00", "00") },
                           new OnScreenKey { GridRow = 1, GridColumn = 6, Key = new VirtualKey(VirtualKeyCode.F3, IconDictionary.Icons["minus-circle"], "") },

                           new OnScreenKey { GridRow = 2, GridColumn = 4, Key = new StringKey(":", ":") },           
                           new OnScreenKey { GridRow = 2, GridColumn = 5, Key = new VirtualKey(VirtualKeyCode.VK_0, "0") },
                           new OnScreenKey { GridRow = 2, GridColumn = 6, Key = new VirtualKey(VirtualKeyCode.TAB, IconDictionary.Icons["arrow-right-circle"], "") }

                           //new OnScreenKey { GridRow = 0, GridColumn = 3, Key = new EmptyKey(), GridWidth = new GridLength(2.5, GridUnitType.Star) }

                           //new OnScreenKey { GridRow = 0, GridColumn = 10, Key =  new EmptyKey(), GridWidth = new GridLength(0.8, GridUnitType.Star)},
                                                      
                           
                       };
        }
    }
}