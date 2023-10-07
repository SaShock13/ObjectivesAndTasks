using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Net.Codecrete.QrCodeGenerator;

namespace ObjectivesAndTasks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddObjectivePage : ContentPage
    {
        Objective localObjective = null;
        public AddObjectivePage()
        {
            InitializeComponent();
            
            var qr = QrCode.EncodeText("Hello, world!", QrCode.Ecc.Medium);

            qr.("hello-world-qr.png", 10, 3);

        }

        private async void btnAcceptAddObjectiveClicked(object sender, EventArgs e)
        {
            //int prior;
            
            if (int.TryParse(entPriority.Text,out int prior)&prior<4&prior>0&!string.IsNullOrEmpty(entName.Text)& !string.IsNullOrEmpty(entDescription.Text)     )
            {
                //MainPage homePage = Application.Current.MainPage as MainPage;

                NavigationPage navPage = (NavigationPage)Application.Current.MainPage;
                IReadOnlyList<Page> navStack = navPage.Navigation.NavigationStack;
                MainPage homePage = navStack[navPage.Navigation.NavigationStack.Count - 1] as MainPage;

                localObjective = new Objective(entName.Text, entDescription.Text, prior);
                
                homePage.AddToList(localObjective);

                Navigation.PopModalAsync();

            }
            
            
        }
    }
}