using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Reflection;

namespace LazerGame
{
    public static class ExecutingAssembly
    {
        public static Assembly exAss = Assembly.GetExecutingAssembly();
        public static void SetBitmapImageSource(BitmapImage bmp, string embPictPath)
        {
            using (var stream = exAss.GetManifestResourceStream(embPictPath))
            {
                bmp.BeginInit();
                bmp.CacheOption = BitmapCacheOption.OnLoad;
      			bmp.StreamSource = stream;
                bmp.EndInit();
            }
        }
        public static void SetImageRastrSource(Image img, string embPictPath)
        {
            var bmp = new BitmapImage();
            SetBitmapImageSource(bmp, embPictPath);
            img.Source = bmp;
        }
    }
}