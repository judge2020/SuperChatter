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
using Google.Apis.YouTube.v3.Data;
using SuperChatter.Core;

namespace SuperChatter
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			CoreService.Instance.Startup();

			var coreLoop = CoreLoop.Instance;
			coreLoop.NewSuperChat += CoreLoopOnNewSuperChat;
		}

		private void CoreLoopOnNewSuperChat(SuperChatEventSnippet snippet)
		{
			Block.Text = snippet.CommentText;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var eventtt = new SuperChatEventSnippet()
			{
				CommentText = "LUL xd"
			};
			CoreLoopOnNewSuperChat(eventtt);
		}
	}
}
