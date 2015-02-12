using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ChemCalc
{
    public partial class About : PhoneApplicationPage
    {
        public About()
        {
            InitializeComponent();
            Loaded += OnPageLoaded;
        }

        private static StackPanel TextToXaml(string filename)
        {
            var panel = new StackPanel();
            var resourceStream = Application.GetResourceStream(new Uri(filename, UriKind.RelativeOrAbsolute));
            if (resourceStream != null)
            {
                using (var reader = new System.IO.StreamReader(resourceStream.Stream))
                {
                    string line;
                    do
                    {
                        line = reader.ReadLine();
                        if (string.IsNullOrEmpty(line))
                        {
                            panel.Children.Add(new Rectangle { Height = 20.0 });
                        }
                        else
                        {
                            var textBlock = new TextBlock
                            {
                                TextWrapping = TextWrapping.Wrap,
                                Text = line,
                                Style = (Style)Application.Current.Resources["PhoneTextNormalStyle"],
                                FontSize = 22,
                                Foreground = new SolidColorBrush(Colors.Black),
                            };
                            panel.Children.Add(textBlock);
                        }
                    } while (line != null);
                }
            }
            return panel;
        }

        private void OnPageLoaded(object sender, RoutedEventArgs e)
        {
            aboutInfo.Content = TextToXaml("about.txt");
        }
    }
}