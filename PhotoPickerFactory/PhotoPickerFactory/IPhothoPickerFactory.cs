using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoPickerFactory
{
   public interface IPhotoPickerFactory
    {
        Func<IPhotoPickerService> Create { get; set; }
    }
}
