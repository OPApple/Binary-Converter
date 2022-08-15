using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Binary_Converter.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        public void convert()
        {
            string num = numEntry.Text;
            long result = 0;
            for (int i = 0; i < num.Length; i++)
            { 
                if (num[num.Length - 1 - i] == '1')
                {
                    result += Convert.ToInt64(Math.Pow(2, i));
                }

            }
            Converted.Text = result.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            convert();
        }
    }
}