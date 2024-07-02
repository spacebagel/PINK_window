using System.Windows;
using System.Windows.Input;

namespace PINK_window.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Window;
        public MainWindow()
        {
            InitializeComponent();
            Window = this;
        }

        private void Drag(object sender, RoutedEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed) MainWindow.Window.DragMove();
        }

        private void CloseBtnClick(object sender, MouseButtonEventArgs e) => Application.Current.Shutdown();
        private void MinimizeBtnClick(object sender, MouseButtonEventArgs e) => WindowState = WindowState.Minimized;
        private void MaximizeBtnClick(object sender, MouseButtonEventArgs e) =>
            WindowState = WindowState != WindowState.Maximized ? WindowState.Maximized : WindowState.Normal;
    }
}