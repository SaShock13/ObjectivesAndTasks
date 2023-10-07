using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ObjectivesAndTasks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObjectiveDetailsPage : ContentPage
    {
        public ObjectiveDetailsPage(Objective localObjective)
        {
            
              
            
            InitializeComponent();
            //if (localObjective.Priority == 1)
            //{ frDetails.BackgroundColor = Color.Blue; }
            //else if (localObjective.Priority == 2)
            //{ frDetails.BackgroundColor = Color.Yellow; }
            //else if(localObjective.Priority == 3)
            //{ frDetails.BackgroundColor = Color.Red; }
            


        }
    }
}