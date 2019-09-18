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
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace DotNetConf
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			AppCenter.Start("586274fb-38e8-4132-8712-17a5fdf63907",
				   typeof(Analytics), typeof(Crashes));
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Analytics.TrackEvent("Button Clicked");
			int i = 0;
			var foo = 5 / i;
		}
	}
}
