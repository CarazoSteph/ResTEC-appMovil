using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ResTEC_appMovil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            //added this to bindind text button
            //BindingContext = new ViewModelDemo();

            //username entry
            var username = new Entry { Placeholder = "Username" };
            var text1 = username.Text;
            
            //password
            var password  = new Entry { IsPassword = true , Placeholder = "Password" };
            var text2 = password.Text;
            
        }

        //this has been created to make a button work
        private void PressMeButton_Clicked(object sender, EventArgs e)
        {
            //the button change the text to: logging in
            (sender as Button).Text = "logging in";
            //throw new NotImplementedException();
        }
        
        //new button (does not work or idk)
        //public ICommand IncrementLabelCommand { get; private set; }

        //new button (does not work or idk)
        // void IncrementLabel()
        // {
        //     int modelUpdateCount = 0;
        //     modelUpdateCount++;
        // }
        //
        // public void ViewModelDemo()
        // {
        //     IncrementLabelCommand = new Command(IncrementLabel);
        // }
    }

    
    //new button action needed (does not work or idk)
    // public class ViewModelDemo
    // {
    // }
    
}