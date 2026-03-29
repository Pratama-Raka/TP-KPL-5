using System;

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}
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
        // Membuat objek dari class HaloGeneric
        HaloGeneric halo = new HaloGeneric();
        // input user
        string nama = "Raka";
        // Memanggil method SapaUser
        halo.SapaUser<string>(nama);

        // Isi data input
        string nim = "103022400077";
        // Membuat objek DataGeneric
        DataGeneric<string> data = new DataGeneric<string>(nim);
        // Memanggil method PrintData
        data.PrintData();
    }
}
