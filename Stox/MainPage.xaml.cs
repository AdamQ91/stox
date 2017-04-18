using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Stox
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void currentPrice_Checked(object sender, RoutedEventArgs e)
        {
            /* Current price of stock that was input. 
             * If checked this will display the latest market price. 
             */ 
        }

        private void currentPriceLabel_SelectionChanged(object sender, RoutedEventArgs e)
        {
            
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            /* When user presses "Lookup" button fetch the current price
             * of the ticker symbol, and display it for the user. 
             */ 
            SymbolLookup lookup = new SymbolLookup();
            currentPriceLabel.Text = lookup.currentPrice(tickerSymbol.Text);
        }
    }
}
