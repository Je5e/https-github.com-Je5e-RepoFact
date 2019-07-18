using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PhotoPickerFactory
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, EventArgs e)
        {
            IPhotoPickerService photoPicker = App.Factory.Create();

            Stream stream = await photoPicker.GetImageStreamAsync();
            if (stream!=null)
            {
                imgPhoto.Source = ImageSource.FromStream(() => stream);
            }
          
        }
    }
}
