using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.UI.Units;

public class MenuListItem : ContentControl
{
   static MenuListItem()
   {
      DefaultStyleKeyProperty.OverrideMetadata(typeof(MenuListItem), new FrameworkPropertyMetadata(typeof(MenuListItem)));
   }
}