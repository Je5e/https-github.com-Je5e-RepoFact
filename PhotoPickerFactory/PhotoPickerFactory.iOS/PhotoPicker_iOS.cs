using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using UIKit;

namespace PhotoPickerFactory.iOS
{
    public class PhotoPicker_iOS : IPhotoPickerService
    {
        public Task<Stream> GetImageStreamAsync()
        {
            throw new NotImplementedException();
        }
    }
}