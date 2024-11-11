namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new Array([1, 2, 3, 4, 5]);
            arr.Show();
            arr.Show("Additonal info.");

            arr.Add(1, 3);
            arr.Delete(0);
            arr.Push(15);
            arr.Show();

            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Avg());
            arr.SortAsc();
            arr.Show("Ascendent");
            arr.SortDesc();
            arr.Show("Descendent");
            arr.SortByParam(true);
            arr.Show("Ascendent");

        }




    }


}
