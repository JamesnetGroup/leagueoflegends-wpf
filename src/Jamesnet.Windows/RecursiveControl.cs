using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace Jamesnet.Windows
{
    public class RecursiveControl : ContentControl
    {
        public RecursiveControl()
        {
            DefaultStyleKey = typeof(RecursiveControl);
        }

        public object ItemsSource
        {
            get => GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(nameof(ItemsSource), typeof(object), typeof(RecursiveControl), new PropertyMetadata(null, OnItemsSourceChanged));

        public string ItemsBindingPath
        {
            get => (string)GetValue(ItemsBindingPathProperty);
            set => SetValue(ItemsBindingPathProperty, value);
        }

        public static readonly DependencyProperty ItemsBindingPathProperty =
            DependencyProperty.Register(nameof(ItemsBindingPath), typeof(string), typeof(RecursiveControl), new PropertyMetadata(null));

        private static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((RecursiveControl)d).GenerateItems();
        }

        public bool IsExpanded
        {
            get => (bool)GetValue(IsExpandedProperty);
            set => SetValue(IsExpandedProperty, value);
        }

        public static readonly DependencyProperty IsExpandedProperty = DependencyProperty.Register(nameof(IsExpanded), typeof(bool), typeof(RecursiveControl), new PropertyMetadata(true, OnIsExpandedChanged));

        private static void OnIsExpandedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((RecursiveControl)d).UpdateChildrenVisibility();
        }

        private Panel _itemsPanel;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            _itemsPanel = GetTemplateChild("PART_ItemsPanel") as Panel;
            UpdateChildrenVisibility();
            SetItemsSourceFromDataContext();
        }

        private void SetItemsSourceFromDataContext()
        {
            if (DataContext == null || string.IsNullOrEmpty(ItemsBindingPath)) return;

            var dataContextType = DataContext.GetType();
            var property = dataContextType.GetProperty(ItemsBindingPath);

            if (property != null && typeof(IEnumerable).IsAssignableFrom(property.PropertyType))
            {
                var value = property.GetValue(DataContext);
                if (value is IEnumerable enumerable)
                {
                    ItemsSource = enumerable;
                }
            }
        }

        private void GenerateItems()
        {
            if (_itemsPanel == null || ItemsSource == null) return;

            _itemsPanel.Children.Clear();

            foreach (var item in ItemsSource as IEnumerable)
            {
                var container = GetContainerForItemOverride();

                if (container is FrameworkElement fe)
                {
                    fe.DataContext = item;
                    _itemsPanel.Children.Add(fe);
                }
            }
        }

        protected virtual DependencyObject GetContainerForItemOverride()
        {
            return new RecursiveControl();
        }

        private void UpdateChildrenVisibility()
        {
            if (_itemsPanel != null)
            {
                _itemsPanel.Visibility = IsExpanded ? Visibility.Visible : Visibility.Collapsed;
            }
        }
    }
}