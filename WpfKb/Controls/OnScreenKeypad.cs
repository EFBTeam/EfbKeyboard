using System.Collections.ObjectModel;
using WpfKb.Input;
using WpfKb.LogicalKeys;


namespace WpfKb.Controls
{
    public class OnScreenKeypad : UniformOnScreenKeyboard
    {
        public OnScreenKeypad()
        {
            Keys = new ObservableCollection<OnScreenKey>
                       {
                           new OnScreenKey { GridRow = 0, GridColumn = 0, Key = new VirtualKey(VirtualKeyCode.VK_7, "m 17,1 4,4 -4,4 M3 11V9a4 4 0 0 1 4-4h14 M 7,23 3,19 7,15 M21 13v2a4 4 0 0 1-4 4H3", "Rich") },
                           new OnScreenKey { GridRow = 0, GridColumn = 1, Key = new VirtualKey(VirtualKeyCode.VK_8, IconDictionary.RnErrorCodes["arrow-right-circle"], "") },
                           new OnScreenKey { GridRow = 0, GridColumn = 2, Key = new VirtualKey(VirtualKeyCode.VK_9, IconDictionary.RnErrorCodes["minus-circle"], "") },
                           new OnScreenKey { GridRow = 1, GridColumn = 0, Key = new VirtualKey(VirtualKeyCode.VK_4, IconDictionary.RnErrorCodes["plus-circle"], "") },
                           new OnScreenKey { GridRow = 1, GridColumn = 1, Key = new VirtualKey(VirtualKeyCode.VK_5, IconDictionary.RnErrorCodes["delete"], "") },
                           new OnScreenKey { GridRow = 1, GridColumn = 2, Key = new VirtualKey(VirtualKeyCode.VK_6, IconDictionary.RnErrorCodes["trash-2"], "") },
                           new OnScreenKey { GridRow = 2, GridColumn = 0, Key = new VirtualKey(VirtualKeyCode.VK_1, "1") },
                           new OnScreenKey { GridRow = 2, GridColumn = 1, Key = new VirtualKey(VirtualKeyCode.VK_2, "2") },
                           new OnScreenKey { GridRow = 2, GridColumn = 2, Key = new VirtualKey(VirtualKeyCode.VK_3, "3") },
                           new OnScreenKey { GridRow = 3, GridColumn = 0, Key = new VirtualKey(VirtualKeyCode.DELETE, "Clear") },
                           new OnScreenKey { GridRow = 3, GridColumn = 1, Key = new VirtualKey(VirtualKeyCode.VK_0, "0") },
                           new OnScreenKey { GridRow = 3, GridColumn = 2, Key = new VirtualKey(VirtualKeyCode.BACK, "Del") },
                       };
        }
    }
}