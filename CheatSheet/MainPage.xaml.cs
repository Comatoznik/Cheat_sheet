using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace CheatSheet
{
    public class Commi
    {
        public string Surname { get; set; }
        public string Years { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        public List<Commi> Commies { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Commies = new List<Commi>
            {
                new Commi {Surname ="Ленин", Years = "1917-1922"},
                   new Commi {Surname ="Сталин", Years = "1922-1953"},
                      new Commi {Surname ="Хрущев", Years = "1953-1964"},
                         new Commi {Surname ="Брежнев", Years = "1964-1982"},
                            new Commi {Surname ="Горбачев", Years = "1982-1991"}
            };
            this.BindingContext = this;
          
        }

        private void CommiesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {   
           
                Page1 page1 = new Page1();
                Navigation.PushAsync(page1);
            page1.content(e.SelectedItemIndex);
               
          
        }
    }
}