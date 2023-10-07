using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ObjectivesAndTasks
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Objective> Objectives { get; set; }
        public MainPage()
        {
            InitializeComponent();
            
            Objectives = new ObservableCollection<Objective>();
            FillList(50);
            lvList.ItemsSource = Objectives;
            var dblTapRecognizer = new TapGestureRecognizer();
            dblTapRecognizer.NumberOfTapsRequired = 2;
            dblTapRecognizer.Tapped += (s, e) => {
                DisplayAlert("Уведомление", (s as Objective).Name, "ОK"); ;
            };
            lvList.GestureRecognizers.Add(dblTapRecognizer);
            
        }

        void FillList(int count)
        {
            Random random = new Random();
            string loremIpsum = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit.";


            for (int i = 1; i < count+1; i++)
            {
                
                Objectives.Add(new Objective($"Цель {i}", loremIpsum , random.Next(1, 4)));
            }
            
        }
        public void LvlDblTaped(object sender, CheckedChangedEventArgs e)
        {

        }

        private void CheckedOrNot(object sender, CheckedChangedEventArgs e)
        {
            
        }

        private void Tapped(object sender, ItemTappedEventArgs e)
        {
            
            ObjectiveDetailsPage objectiveDetailsPage = new ObjectiveDetailsPage(lvList.SelectedItem as Objective);
            objectiveDetailsPage.BindingContext = lvList.SelectedItem as Objective;

            Navigation.PushAsync(objectiveDetailsPage);
            
        }
        

        private void btnDeleteClicked(object sender, EventArgs e)
        {
            if ((lvList.SelectedItem as Objective)!=null)
            {

                Objectives.Remove(lvList.SelectedItem as Objective);
            }
            
        }

        private void btnAddClicked(object sender, EventArgs e)
        {
            Objective newObjective=null;
             Navigation.PushModalAsync(new AddObjectivePage());
           
        }
        public void AddToList(Objective o)
        {
            Objectives.Add(o);
        }

       
    }
    
}
