using System;

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
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
    }
}
