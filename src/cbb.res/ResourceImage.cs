﻿using System.Windows.Media.Imaging;

namespace cbb.res
{
    public static class ResourceImage
    {
        public static BitmapImage GetIcon(string name)
        {
            var stream = ResourceAssembly.GetAssembly().GetManifestResourceStream(ResourceAssembly.GetNamespace() + "Images.Icons." + name);
            
            var image = new BitmapImage();

            image.BeginInit();
            image.StreamSource = stream;
            image.EndInit();

            return image;
        }
    }
}
