using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Online_shop
{
    class Produk
    {
        public string nama;
        public int harga;
        public int jumlah;
        public int hargaTotal;

        public Produk(string nama, int harga, int jumlah)
        {
            this.nama = nama;
            this.harga = harga;
            this.jumlah = jumlah;
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Nama     : {nama}");
            Console.WriteLine($"Harga    : {harga}");
        }

        public virtual int HargaTotal() 
        {
            return hargaTotal; 
        }

        
    }

    class Elektronik : Produk
    {
        public string merk;
        public int berat;
        public double ongkir;

        public Elektronik(string merk, int berat, string nama, int harga, int jumlah) : base(nama, harga, jumlah)
        {
            this.merk = merk;
            this.berat = berat;
            Console.WriteLine($"Merk     : {merk}");

        }
        public override int HargaTotal() 
        {
            int total = 0;
            int ongkir = 0;
            if (berat <= 5)
            {
                ongkir = 3000;
                total = harga + ongkir;
            }

            else if (berat <= 10)
            {
                ongkir = 6000;
                total = harga + ongkir;
            }

            else
            {
                ongkir = 12000;
                total = harga + ongkir;
            }
            return total;
        }

        public void InfoElektronik()
        {
            Console.WriteLine($"Jumlah   : {jumlah}");
            Console.WriteLine($"Berat    : {berat} Kg");
            Console.WriteLine($"Ongkir   : Rp. {(berat <= 5 ? 3000 :(berat <= 10 ? 6000 : 12000))}");
        }
        
    }

    class Baju : Produk 
    {
        public string ukuran;

        public Baju( string ukuran, string nama, int harga, int jumlah) : base(nama, harga, jumlah) 
        {
            this.ukuran = ukuran;
            this.harga = harga;
            this.jumlah = jumlah;
            Console.WriteLine($"Ukuran   : {ukuran}");
            Console.WriteLine($"Jumlah   : {jumlah}");
            Console.WriteLine($"Ongkir   : Rp.5000");
        }
        public override int HargaTotal() 
        {
            return (harga * jumlah) + 5000;
        }
    }

    class Buku : Produk 
    {
        public string pengarang;
        public string penerbit;
        public int tahunterbit;

        public Buku(string pengarang, string penerbit, int tahunterbit, string nama, int harga, int jumlah) : base(nama, harga, jumlah)
        {
            this.pengarang = pengarang;
            this.penerbit = penerbit;
            this.tahunterbit = tahunterbit;
            this.harga = harga;
            this.jumlah = jumlah;
            Console.WriteLine($"Karangan : {pengarang}");
            Console.WriteLine($"Penerbit : {penerbit}");
            Console.WriteLine($"Tahun    : {tahunterbit}");
            Console.WriteLine($"Jumlah   : {jumlah}");
            Console.WriteLine($"Ongkir   : Rp6000");
        }
        public override int HargaTotal() 
        {
            return (harga * jumlah) + 6000;
        }
    }

    class KeranjangBelanja
    {
        public List<Produk> barang2 { get; set; }

        public KeranjangBelanja()
        {
            barang2 = new List<Produk>();
        }

        public void Tambahbarang(Produk barang)
        {
            barang2.Add(barang);
        }

        public int Jumlahbarang()
        {
            return barang2.Count;
        }

        public int TotalHarga()
        {
            int total = 0;
            foreach (Produk barang in barang2)
            {
                total += barang.HargaTotal();
            }
            return total;
        }

    }
}
