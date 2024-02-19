using System.Collections.ObjectModel;
using WpfKb.Input;
using WpfKb.LogicalKeys;


namespace WpfKb.Controls
{
    public class AlpsComboBoxKeypad : UniformOnScreenKeyboard
    {
        public AlpsComboBoxKeypad()
        {
            Keys = new ObservableCollection<OnScreenKey>
                       {
                           new OnScreenKey { GridRow = 0, GridColumn = 0, Key = new VirtualKey(VirtualKeyCode.UP,IconDictionary.Icons["arrow-up-circle"], "") },
                           
                           new OnScreenKey { GridRow = 1, GridColumn = 0, Key = new VirtualKey(VirtualKeyCode.DOWN, IconDictionary.Icons["arrow-down-circle"], "") },           
                           
                           new OnScreenKey { GridRow = 2, GridColumn = 0, Key = new VirtualKey(VirtualKeyCode.TAB, IconDictionary.Icons["arrow-right-circle"], "") },
                           
                       };
        }
    }
}