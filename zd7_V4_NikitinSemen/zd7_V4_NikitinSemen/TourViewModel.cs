using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using zd7_V4_NikitinSemen;

namespace zd7_V4_NikitinSemen
{
    public class TourViewModel
    {
        public ObservableCollection<Tour> Tours { get; set; }

        public TourViewModel()
        {
            Tours = new ObservableCollection<Tour>
            {
                new Tour { Name = "Тур 1", ImageUrl = "France.jpg", Country = "Франция", Category = "Приключения", Cost = "1000", Turoperator = "Туроператор A", Description = "Захватывающее приключение во Францию." },
                new Tour { Name = "Тур 2", ImageUrl = "Italy.jpg", Country = "Италия", Category = "Культура", Cost = "1200", Turoperator = "Туроператор B", Description = "Захватывающее приключение в Италию." },
                new Tour { Name = "Тур 3", ImageUrl = "Spain.jpg", Country = "Испания", Category = "Приключения", Cost = "1100", Turoperator = "Туроператор C", Description = "Захватывающее приключение в Испанию." },
                new Tour { Name = "Тур 4", ImageUrl = "Switherland.jpg", Country = "Швейцария", Category = "Культура", Cost = "1200", Turoperator = "Туроператор D", Description = "Захватывающее приключение в Швейцарию." }
            };
        }
    }
}
