namespace Deffining_Classes_2.Point3D
{
    class TestPoint3D
    {
        public static void TestPoint3DMain()
        {
            Point3D A = new Point3D(12.3, 123.4, 44);
            Point3D B = new Point3D(15, 16.1, 2);
            Point3D C = new Point3D(16.3, 13.4, 21);

            System.Console.WriteLine(A.ToString() + " " + B.ToString() + " " + C.ToString());
            System.Console.WriteLine("Distance between point A and point B is: " + CalcDistance.Distance(A, B));

            Path ABC = new Path();
            ABC.AddPoint(A);
            ABC.AddPoint(A);
            ABC.AddPoint(B);
            ABC.AddPoint(C);

            System.Console.WriteLine(ABC.ToString());
            System.Console.WriteLine("Deleting point at index 1.");
            ABC.DeletePoint(1);
            System.Console.WriteLine(ABC.ToString());

            Path BEER = new Path();
            BEER.AddPoint(B);
            BEER.AddPoint(new Point3D(12, 16, 13));
            BEER.AddPoint(new Point3D(3, 20, 17));
            BEER.AddPoint(new Point3D(6, 7, 4));

            PathStorage.AddPath(ABC);
            PathStorage.AddPath(BEER);

            System.Console.WriteLine("Print Path Storage:");
            PathStorage.PrintPathStorage();

            System.Console.WriteLine("Remove first path(ABC).");
            PathStorage.RemovePath(ABC);

            System.Console.WriteLine("Print Path Storage:");
            PathStorage.PrintPathStorage();

            System.Console.WriteLine("Save paths to the file.");
            PathStorage.SavePaths();

            System.Console.WriteLine("Load paths from file. Print them.");
            PathStorage.LoadPaths();
            PathStorage.PrintPathStorage();
        }
    }
}
