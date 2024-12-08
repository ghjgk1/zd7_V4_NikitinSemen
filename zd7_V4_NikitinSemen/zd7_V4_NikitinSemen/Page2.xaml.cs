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
    public partial class Page2 : ContentPage
    {
        Tour selectedTour;
        public Page2(Tour selectedTour)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            this.selectedTour = selectedTour;
            Source.Source = selectedTour.ImageUrl;
            Name.Text = $"Название тура: {selectedTour.Name}";
            Country.Text = $"Страна: {selectedTour.Country}";
            Category.Text = $"Категория тура: {selectedTour.Category}";
            Cost.Text = $"Стоимость: {selectedTour.Cost}";
            Turoperator.Text = $"Туроператор: {selectedTour.Turoperator}";
            Description.Text = $"Описание: {selectedTour.Description}";
        }

        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        async void ShowErrorMessage(string message)
        {
            await Application.Current.MainPage.DisplayAlert("Ошибка", message, "OK");
        }

        private async void OnCalculateCostClicked(object sender, EventArgs e)
        {
            if (Traveler.Text != null && Day.Text != null)
            {
                if (Convert.ToInt32(Traveler.Text) > 0 && Convert.ToInt32(Traveler.Text) < 16)
                {
                    if (Convert.ToInt32(Day.Text) > 0 && Convert.ToInt32(Day.Text) < 31)
                    {
                        await Navigation.PushAsync(new Page3(selectedTour, Convert.ToInt32(Traveler.Text), Convert.ToInt32(Day.Text)));
                    }
                    else
                        ShowErrorMessage("Дней в туре от 1 до 30");
                }
                else
                    ShowErrorMessage("Людей в туре от 1 до 15");
            }
            else
                ShowErrorMessage("Поля не должны быть пустыми");
        }
    }
}