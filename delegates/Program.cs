using System;

namespace delegates
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
        public delegate void PhotoFiltersHandler(Photo photo);
        public void Process(string path, PhotoFiltersHandler filtersHandler)
        {
            var photo = Photo.Load(path);

            filtersHandler(photo);
            photo.Save();


        }
    }

    public class SystemPhotoProcessor
    {
        public void SystemProcess(string path, Action<Photo> filtersHandler)
        {

            var photo = Photo.Load(path);

            filtersHandler(photo);
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

    }



    class Program
    {
        static void Main(string[] args)
        {
            // var processor = new PhotoProcessor();

            // var filters = new PhotoFilters();

            // PhotoProcessor.PhotoFiltersHandler filtersHandler = filters.ApplyBrightness;

            // filtersHandler += filters.ApplyContrast;

            // filtersHandler +=  RemoveRedEyeFilter;

            // processor.Process("Test.jpg", filtersHandler);


            InbuiltDelegateDemo();



        }
        static void RemoveRedEyeFilter(Photo photo)
        {
            System.Console.WriteLine("Remove Red eyes");
        }

        public static void InbuiltDelegateDemo()
        {
            var processor = new SystemPhotoProcessor();

            var filters = new PhotoFilters();

            Action<Photo> filtersHandler = filters.ApplyBrightness;

            filtersHandler += filters.ApplyContrast;

            filtersHandler +=  RemoveRedEyeFilter;

            processor.SystemProcess("Test.jpg", filtersHandler);

        }


    }
}
