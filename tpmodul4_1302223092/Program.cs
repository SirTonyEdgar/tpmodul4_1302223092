using System;

class KodePos
{
    private string[,] data = {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    public string GetKodePos(string kelurahan)
    {
        for (int i = 0; i < data.GetLength(0); i++)
        {
            if (data[i, 0] == kelurahan)
            {
                return data[i, 1];
            }
        }
        return "Kode pos tidak ditemukan";
    }
}

class DoorMachine
{
    enum State { Terkunci, Terbuka }

    private State currentState = State.Terkunci;

    public void ChangeState()
    {
        currentState = (currentState == State.Terkunci) ? State.Terbuka : State.Terkunci;
    }

    public void PrintDoorState()
    {
        string doorState = (currentState == State.Terkunci) ? "Pintu terkunci" : "Pintu tidak terkunci";
        Console.WriteLine(doorState);
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();
        string kelurahan = "Kujangsari";
        Console.WriteLine($"Kode pos untuk kelurahan {kelurahan}: {kodePos.GetKodePos(kelurahan)}");

        DoorMachine doorMachine = new DoorMachine();
        Console.WriteLine("Mengubah state pintu:");
        doorMachine.PrintDoorState();
        doorMachine.ChangeState();
        doorMachine.PrintDoorState();
    }
}
