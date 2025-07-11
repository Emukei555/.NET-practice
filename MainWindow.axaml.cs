using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.ObjectModel;

namespace TodoApp
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> _items;

        public MainWindow()
        {
            InitializeComponent();

            _items = new ObservableCollection<string>();
            TodoList.ItemsSource = _items;
        }

        private void OnAddClick(object? sender, RoutedEventArgs e)
        {
            var text = InputBox.Text?.Trim();
            if (!string.IsNullOrWhiteSpace(text))
            {
                _items.Add(text);
                InputBox.Text = "";
            }
        }

        private void OnRemoveClick(object? sender, RoutedEventArgs e)
        {
            if (TodoList.SelectedItem is string selected)
            {
                _items.Remove(selected);
            }
        }

        private void OnClearClick(object? sender, RoutedEventArgs e)
        {
            _items.Clear();
        }
    }
}
