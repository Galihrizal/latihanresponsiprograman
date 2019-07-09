using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomponenPC
{
    class Program
    {
        //-------------------------
        //Latihan Responsi Bagian 2
        //Galih Rizal Muhammad
        //-----------------------

        static List<Motherboard> listMobo = new List<Motherboard>();
        static List<Processor> listProc = new List<Processor>();

        static void Main(string[] args)
        {
            string pil;
            
            Console.WriteLine("---------------------------");
            Console.WriteLine("Selamat Datang di RuanganPC");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Menu Yang Tersedia :");
            Console.WriteLine("1. Tambah Data\n2. Edit Data\n3. Hapus Data\n4. Tampil Data\n5. Keluar");
            Console.Write("Masukkan pilihan menu [1..5] : ");
            pil = Console.ReadLine();
            switch (pil)
            {
                case "1": pilihBarang(); break;
                case "2": editData(); break;
                case "3": hapusData(); break;
                case "4": tampilData(); break;
                default: Console.WriteLine("sip"); break;
            }

            if (pil != "5"){               
                Main(args);
            }
        }

        public static void pilihBarang()
        {
            string pilb;

            Console.WriteLine("Silahkan di pilih barangnya");
            Console.WriteLine("1. Motherboard\n2. Processor\n3. VGA\n4. Memory\n5. Hardisk");
            Console.Write("Masukkan pilihan menu [1..5] : ");
            pilb = Console.ReadLine();
            switch (pilb)
            {
                case "1": tambahdataMobo(); break;
                case "2": tambahdataProc(); break;
            }
        }

        static public void tambahdataMobo()
        {
            string id, namabarang, jenis, status;
            int jmlstok;
            Console.Clear();
            Console.Write("1. Id : ");
            id = Console.ReadLine();
            Console.Write("2. Nama Barang : ");
            namabarang = Console.ReadLine();
            Console.Write("3. Jenis Barang : ");
            jenis = Console.ReadLine();
            Console.Write("4. Jumlah Stock : ");
            jmlstok = Convert.ToInt32(Console.ReadLine());
            Console.Write("5. Status : ");
            status = Console.ReadLine();

            Motherboard mobo = new Motherboard();
            mobo.Id = id;
            mobo.namaBarang = namabarang;
            mobo.jenisBarang = jenis;
            mobo.jmlStock = jmlstok;
            mobo.Status = status;
                    
            listMobo.Add(mobo);

            
        }
        public static void tambahdataProc()
        {
            string id, namabarang, jenis, status;
            int jmlstok;
                      
            Console.Write("1. Id : ");
            id = Console.ReadLine();
            Console.Write("2. Nama Barang : ");
            namabarang = Console.ReadLine();
            Console.Write("3. Jenis Barang : ");
            jenis = Console.ReadLine();
            Console.Write("4. Jumlah Stock : ");
            jmlstok = Convert.ToInt32(Console.ReadLine());
            Console.Write("5. Status : ");
            status = Console.ReadLine();

            Processor proc = new Processor();
            proc.Id = id;
            proc.namaBarang = namabarang;
            proc.jenisBarang = jenis;
            proc.jmlStock = jmlstok;
            proc.Status = status;
            
            listProc.Add(proc);
        }

        public static void editData()
        {
            string id, namabarang, jenis, status;
            int jmlstok;

            Console.Clear();
            tampilData();
            Console.Write("Mau Edit yang mana hayooo : ");
            int pilih = Convert.ToInt32(Console.ReadLine());         

            Console.Write("1. Id : ");
            id = Console.ReadLine();
            Console.Write("2. Nama Barang : ");
            namabarang = Console.ReadLine();
            Console.Write("3. Jenis Barang : ");
            jenis = Console.ReadLine();
            Console.Write("4. Jumlah Stock : ");
            jmlstok = Convert.ToInt32(Console.ReadLine());
            Console.Write("5. Status : ");
            status = Console.ReadLine();

            listMobo[pilih - 1].Id = id;
            listMobo[pilih - 1].namaBarang = namabarang;
            listMobo[pilih - 1].jenisBarang = jenis;
            listMobo[pilih - 1].jmlStock = jmlstok;
            listMobo[pilih - 1].Status = status;
        }

        public static void hapusData()
        {
            Console.Clear();
            tampilData();
            Console.Write("Mau hapus yang mana hayooo : ");
            int pilih = Convert.ToInt32(Console.ReadLine());

            listMobo.RemoveAt(pilih - 1);
        }

        public static void tampilData()
        {
            Console.Clear();

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\tNo\tId\tNama Barang\tJenis Barang\tJumlah Stock\tStatus");

            int i = 1;
            foreach (Motherboard data in listMobo)
            {
                Console.WriteLine("\t{0}. \t{1} \t{2} \t{3} \t{4} \t{5}", i, data.Id, data.namaBarang, data.jenisBarang, data.jmlStock, data.Status);
                i++;
            }
        }
    }
}
