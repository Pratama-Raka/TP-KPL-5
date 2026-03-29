using System;

class DataGeneric<T>
{
    public T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Isi data input
        string nim = "103022400077";
        // Membuat objek DataGeneric
        DataGeneric<string> data = new DataGeneric<string>(nim);
        // Memanggil method PrintData
        data.PrintData();
    }
}
