using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            // This code creates a button that has multiple texts inside, pretty similar than the commented
            // line in the MainWindow.xaml
            InitializeComponent();
            Grid grid = new Grid();
            this.Content = grid;
            Button btn = new Button();
            btn.FontSize = 26;

            WrapPanel wrapPanel = new WrapPanel();
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Multi";
            textBlock.Foreground = Brushes.White;
            wrapPanel.Children.Add( textBlock );

            textBlock = new TextBlock();
            textBlock.Text = "Text";
            textBlock.Foreground = Brushes.BlueViolet;
            wrapPanel.Children.Add(textBlock);

            textBlock = new TextBlock();
            textBlock.Text = "Button";
            textBlock.Foreground = Brushes.Chocolate;
            wrapPanel.Children.Add(textBlock);

            btn.Content = wrapPanel;
            grid.Children.Add( btn );
        }
    }
}
