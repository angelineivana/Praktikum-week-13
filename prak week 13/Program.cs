using System;

namespace prak_week_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Berapa data = ");
            int jumlah = Convert.ToInt16(Console.ReadLine());

            string[] nim = new string[100];
            string[] nama = new string[100];
            string[] jenisKelamin = new string[100];
            int[] tahun = new int[100];
            string[] programStudi = new string[100];
            string[] kelas = new string[100];
 
            for (int i = 1; i <= jumlah; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"data ke - {i}");
                Console.Write("NIM              : ");
                nim[i] = Console.ReadLine();
                if (i > 1)
                {
                    for (int x = 1; x < i; x++)
                    {
                        while (nim[i].Contains(nim[x]) == true)
                        {
                            Console.WriteLine("NIM SUDAH ADA, MASUKKAN NIM LAIN !!!");
                            Console.Write("NIM              : ");
                            nim[i] = Console.ReadLine();
                        }
                    }
                }
                Console.Write("NAMA             : ");
                nama[i] = Console.ReadLine();
                Console.Write("JENIS KELAMIN    : ");
                jenisKelamin[i] = Console.ReadLine();
                Console.Write("TAHUN MASUK      : ");
                tahun[i] = Convert.ToInt16(Console.ReadLine());
                Console.Write("PROGRAM STUDI    : ");
                programStudi[i] = Console.ReadLine();
                Console.Write("KELAS            : ");
                kelas[i] = Console.ReadLine();
            }
            Console.Write("PRINT HASIL? (y/n) ... ");
            string print = Console.ReadLine();
            int jumlahTambah = 0;
            while (print == "y")
            {
                var sb = new System.Text.StringBuilder();
                sb.Append(String.Format("{0, -4} {1, -7} {2, -22} {3, -18} {4, -14} {5, -18} {6, -5}", "NO", "NIM", "NAMA", "JENIS KELAMIN", "TAHUN MASUK", "PROGRAM STUDI", "KELAS\n"));
                for (int i = 1; i <= jumlah + jumlahTambah; i++)
                {
                    sb.Append(String.Format("{0, -4} {1, -7} {2, -22} {3, -18} {4, -14} {5, -18} {6, -5}\n", (i), nim[i], nama[i].ToUpper(), jenisKelamin[i].ToUpper(), tahun[i], programStudi[i].ToUpper(), kelas[i].ToUpper()));
                    Console.WriteLine("");
                }
                Console.Write(sb);
                Console.Write("\nTambah Data? (y/n) ... ");
                string tambah = Console.ReadLine();

                if (tambah == "y")
                {
                    Console.Write("\nBerapa data = ");
                    jumlahTambah = Convert.ToInt16(Console.ReadLine());

                    for (int i = 1; i <= jumlahTambah; i++)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"data ke - {jumlah + i}");
                        Console.Write("NIM              : ");
                        nim[jumlah + i] = Console.ReadLine();

                        for (int x = 1; x < jumlah + i; x++)
                        {
                            while (nim[jumlah + i].Contains(nim[x]) == true)
                            {
                                Console.WriteLine("NIM SUDAH ADA, MASUKKAN NIM LAIN !!!");
                                Console.Write("NIM              : ");
                                nim[jumlah + i] = Console.ReadLine();
                            }
                        }
                        Console.Write("NAMA             : ");
                        nama[jumlah + i] = Console.ReadLine();
                        Console.Write("JENIS KELAMIN    : ");
                        jenisKelamin[jumlah + i] = Console.ReadLine();
                        Console.Write("TAHUN MASUK      : ");
                        tahun[jumlah + i] = Convert.ToInt16(Console.ReadLine());
                        Console.Write("PROGRAM STUDI    : ");
                        programStudi[jumlah + i] = Console.ReadLine();
                        Console.Write("KELAS            : ");
                        kelas[jumlah + i] = Console.ReadLine();
                    }
                    Console.Write("PRINT HASIL? (y/n) ... ");
                    print = Console.ReadLine();
                }
                else
                {
                    print = "";
                }
            }
        }
    }
}
