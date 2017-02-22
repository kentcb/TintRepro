using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TintRepro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.Update();

            this.button.Clicked += (s, e) =>
              {
                  this.Update();
              };
        }

        private void Update()
        {
            tint.A = int.Parse(alpha.Text);
            tint.R = int.Parse(red.Text);
            tint.G = int.Parse(green.Text);
            tint.B = int.Parse(blue.Text);
            this.tintedImage.ReloadImage();
        }
    }
}
