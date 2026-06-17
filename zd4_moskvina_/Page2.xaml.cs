using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd4_moskvina_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void date_DateSelected(object sender, DateChangedEventArgs e)
        {
            int day = e.NewDate.Day;
            int month = e.NewDate.Month;
            double baseUsd = 80.000;
            double baseEur = 86.000;
            double usd = (day % 10) - 5;
            double eur = ((day+month) % 10) - 5;
            double usdRate = baseUsd + usd;
            double eurRate = baseEur + eur;
            usdTxt.Text = usdRate.ToString("F3");
            eurTxt.Text = eurRate.ToString("F3");
        }
    }
}