using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhotoPickerFactory;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PhotoPickerFactory.Droid
{
    public class PhotoPickerFactory_Android : IPhotoPickerFactory
    {
        public Func<IPhotoPickerService> Create { get; set; } =
            () => new PhotoPicker_Android();
    }
}