using System.Windows;
using System.Windows.Controls;
using TaskManagerCourse.Common.Models;

namespace TaskManagerCourse.Client.Models
{
    public class ListBoxCustom : ListBox
    {
        public ListBoxCustom()
        {
            SelectionChanged += ListBoxCustom_SelectionChanged;
        }

        void ListBoxCustom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MineSelectedItem = (UserModel)SelectedItem;
        }

        public UserModel MineSelectedItem
        {
            get { return (UserModel)GetValue(MineSelectedItemProperty); }
            set { SetValue(MineSelectedItemProperty, value); }
        }

        public static readonly DependencyProperty MineSelectedItemProperty =
           DependencyProperty.Register(nameof(MineSelectedItem), typeof(UserModel), typeof(ListBoxCustom), new PropertyMetadata(null));

    }
}
