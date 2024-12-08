using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd7_V4_NikitinSemen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        Tour selectedTour;
        public Page3(Tour selectedTour, int travelers, int day)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            double discount = 0;
            if (Convert.ToInt32(day) >= 25) discount = 0.4;
            else if (Convert.ToInt32(day) >= 15) discount = 0.3;
            else if (Convert.ToInt32(day) >= 10) discount = 0.1;
            this.selectedTour = selectedTour;
            int cost = Convert.ToInt32(selectedTour.Cost) * travelers * day;
            double finalCost = cost * (1 - discount);
            Source.Source = selectedTour.ImageUrl;
            Name.Text = $"Название тура: {selectedTour.Name}";
            Country.Text = $"Страна: {selectedTour.Country}";
            Cost.Text = $"Цена до скидки: {cost}";
            FinalCost.Text = $"Итоговая цена: {finalCost}";
            Traveler.Text = $"Участников тура: {travelers}";
            Day.Text = $"Дней в туре: {day}";
            Discount.Text = $"Скидка {discount * 100}%";

        }

        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2(selectedTour));
        }
        private async void OnCalculateCostClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

    }
}