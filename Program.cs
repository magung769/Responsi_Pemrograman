using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Responsi
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            bool ulang = true;
            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4:
                        ulang = false;
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Menu Tidak Ada");
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");

        }

        static void TambahProduk()
        {
            Console.Clear();

            Produk produk = new Produk();
            Console.WriteLine("Tambah Data Produk");
            Console.WriteLine();
            Console.Write("Kode Produk: ");
            produk.KodeProduk = Console.ReadLine();
            Console.Write("Nama Produk: ");
            produk.NamaProduk = Console.ReadLine();
            Console.Write("Harga Beli Produk: ");
            produk.HargaBeli = int.Parse(Console.ReadLine());
            Console.Write("Harga Jual Produk: ");
            produk.HargaJual = int.Parse(Console.ReadLine());

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            int nomor = -1, hapus = -1;
            Console.Write("Hapus Data Produk: ");
            Console.Write("Kode Produk: ");
            string code = Console.ReadLine();
            foreach (Produk produk in daftarProduk)
            {
                nomor++;
                if(produk.KodeProduk == code)
                {
                    hapus = nomor;
                }
            }

            if (hapus != -1)
            {
                daftarProduk.RemoveAt(hapus);
                Console.WriteLine("\nData Produk dapat dihapus");
            }

            else
            {
                Console.WriteLine("\nKode Produk dapat dihapus");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            
            int noUrut = 0;
            Console.WriteLine("Data Produk");
            foreach (Produk produk in daftarProduk)
            {
                noUrut++;
                Console.WriteLine("{0}. Kode Produk: {1}, Nama Produk: {2}, Harga Beli Produk: {3:}, Harga Jual Produk: {4}", noUrut, produk.KodeProduk, produk.NamaProduk, produk.HargaBeli, produk.HargaJual);
            }

            if (noUrut < 1)
            {
                Console.WriteLine("Data Produk Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
