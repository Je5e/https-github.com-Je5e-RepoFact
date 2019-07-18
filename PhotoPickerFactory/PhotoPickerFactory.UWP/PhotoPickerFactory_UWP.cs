using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoPickerFactory.UWP
{
   public class PhotoPickerFactory_UWP:IPhotoPickerFactory
    {
        public Func<IPhotoPickerService> Create { get; set; } =
          () => new PhotoPicker_UWP();
    }
}
