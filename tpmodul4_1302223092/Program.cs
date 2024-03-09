using System;

public class KodePos
{
    public string GetKodePos(string kelurahan)
    {
        switch (kelurahan)
        {
            case "Batununggal":
                return "40266";
            case "Kujangsari":
                return "40287";
            case "Mengger":
                return "40267";
            case "Wates":
                return "40256";
            case "Cijaura":
                return "40287";
            case "Jatisari":
                return "40286";
            case "Margasari":
                return "40286";
            case "Sekejati":
                return "40286";
            case "Kebonwaru":
                return "40272";
            case "Maleer":
                return "40274";
            case "Samoja":
                return "40273";
            default:
                return "Kode pos tidak ditemukan";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();

        string kelurahan = "Batununggal";
        string kodePosKelurahan = kodePos.GetKodePos(kelurahan);
        Console.WriteLine("Kode pos untuk kelurahan " + kelurahan + " adalah: " + kodePosKelurahan);
    }
}
