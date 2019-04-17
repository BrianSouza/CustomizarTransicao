using FormsControls.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomizarTransicao
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage, IAnimationPage
    {
		public Page1 ()
		{
			InitializeComponent ();
		}

        public IPageAnimation PageAnimation { get; } = new SlidePageAnimation { Duration = AnimationDuration.Long, Subtype = AnimationSubtype.FromTop };


        public void OnAnimationFinished(bool isPopAnimation)
        {
        }

        public void OnAnimationStarted(bool isPopAnimation)
        {
        }
    }
}