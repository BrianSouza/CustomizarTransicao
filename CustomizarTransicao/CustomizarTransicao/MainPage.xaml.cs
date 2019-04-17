using FormsControls.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomizarTransicao
{
    public partial class MainPage : ContentPage, IAnimationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public IPageAnimation PageAnimation { get; } = new SlidePageAnimation { Duration = AnimationDuration.Long, Subtype = AnimationSubtype.FromTop };
        public void OnAnimationFinished(bool isPopAnimation)
        {
        }

        public void OnAnimationStarted(bool isPopAnimation)
        {
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}
