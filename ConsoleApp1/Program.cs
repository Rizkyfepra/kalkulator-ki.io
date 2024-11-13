using System;

class Program
{
    // Fungsi untuk menghitung luas jajar genjang
    static double HitungLuas(double alas, double tinggi)
    {
        return alas * tinggi;
    }

    // Fungsi untuk menghitung keliling jajar genjang
    static double HitungKeliling(double sisiA, double sisiB)
    {
        return 2 * (sisiA + sisiB);
    }

    static void Main(string[] args)
    {
        // Input dari pengguna
        Console.Write("Masukkan alas jajar genjang: ");
        double alas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan tinggi jajar genjang: ");
        double tinggi = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan panjang sisi A: ");
        double sisiA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan panjang sisi B: ");
        double sisiB = Convert.ToDouble(Console.ReadLine());

        // Hitung luas dan keliling
        double luas = HitungLuas(alas, tinggi);
        double keliling = HitungKeliling(sisiA, sisiB);

        // Tampilkan hasil
        Console.WriteLine($"Luas jajar genjang: {luas}");
        Console.WriteLine($"Keliling jajar genjang: {keliling}");
    }
}
