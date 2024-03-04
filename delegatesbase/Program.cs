using System;

namespace delegatesbase
{

    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {

        }
    }


    public class PhotoProcessor
    {
        public void Process(string path)
        {
            var photo = Photo.Load(path);

            var fiters = new PhotoFilters();

            fiters.ApplyBrightness(photo);
            fiters.ApplyContrast(photo);
            fiters.Resize(photo);

            photo.Save();


        }
    }

    public class PhotoFilters
    {

        public void ApplyBrightness(Photo photo)
        {
            System.Console.WriteLine("Apply Brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            System.Console.WriteLine("Apply Contrast");
        }

        public void Resize(Photo photo)
        {
            System.Console.WriteLine("Resize");
        }

        public void Maximize(Photo photo)
        {
            System.Console.WriteLine("Maximize");
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            var process = new PhotoProcessor();

            process.Process("Test");
        }
    }
}
