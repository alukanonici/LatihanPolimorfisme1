using System.Security.Cryptography.X509Certificates;



class ImageProcessor
{
    public void Resize(int persen)
    {
        if (persen <= 0)
        {
            Console.WriteLine("Error! Persentase tidak boleh nol atau negatif!");
        }
        else if (persen < 100)
        {
            Console.WriteLine($"Mengecilkan gambar sebesar {persen}%");
        }
        else if (persen > 100)
        {
            Console.WriteLine($"Membesarkan gambar sebesar {persen}%");
        }
        else
        {
            Console.WriteLine("Ukuran tetap! (100%) Tidak adak perubahan");
        }
    }

    public void Resize(int lebar, int tinggi)
    {
        if (lebar <= 0 || tinggi <= 0)
        {
            Console.WriteLine("Error! ukuran tidak boleh nol atau negatif!");
        }
        else if (lebar < 100 && tinggi < 100)
        {
            Console.WriteLine($"Mengecilkan gambar sebesar {lebar}px x {tinggi}px");
        }
        else if (lebar > 100 && tinggi > 100)
        {
            Console.WriteLine($"Membesarkan gambar sebesar {lebar}px x {tinggi}px");
        }
        else
        {
            Console.WriteLine("Ukuran tetap! Tidak adak perubahan");
        }
    }

    public void Resize(string UkuranKertas)
    {
        Console.WriteLine($"Mengubah menjadi ukuran kertas {UkuranKertas}");
    }
}