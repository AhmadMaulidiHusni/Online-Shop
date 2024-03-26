using Online_shop;

class Program 
{
    static void Main(string[] args)
    {
        Elektronik laptop1 = new Elektronik("Lenovo", 1, "Thinkpad", 200000, 1);
        laptop1.InfoElektronik();
        Baju kemeja = new Baju("XL", "Cardinal", 100000, 2);
        Buku novel = new Buku("Andrea Hirata", "Bentang Pustaka", 2005, "Laskar Pelangi", 50000, 1);

        KeranjangBelanja keranjang = new KeranjangBelanja();
        keranjang.Tambahbarang(laptop1);
        keranjang.Tambahbarang(kemeja);
        keranjang.Tambahbarang(novel);

        int totalHarga = keranjang.TotalHarga();
        Console.WriteLine("===========================");
        Console.WriteLine($"Total Harga : Rp.{totalHarga}");
        Console.WriteLine("===========================");

    }   
}


