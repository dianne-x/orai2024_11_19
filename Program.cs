using orai2024_11_19;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;

var berek = new List<Ber>();
using var sr = new StreamReader(@"..\..\..\src/berek2020.txt", Encoding.UTF8);
_ = sr.ReadLine();

while (!sr.EndOfStream)
{
    berek.Add(new Ber(sr.ReadLine()));
}

sr.Close();

//f3
Console.WriteLine($"{berek.Count} db számú dolgozó adata található meg a forrásban.");

//f4
var atlagBer = Math.Round(berek.Average(x => x.ber)/1000,1);
Console.WriteLine($"A dolgozók átlagbére 2020-ban: {atlagBer} ezer forint");

//f5 + f6
Console.WriteLine($"Adjon meg egy részleget!");
var reszlegInput = Console.ReadLine();
var reszleg = berek.Where(x => x.reszleg == reszlegInput).ToList();
if (reszleg.Count == 0)
{
    Console.WriteLine("A megadott részleg nem létezik a cégnél!");
}
else
{
    //legmagasabb fizetesu dolgozo adatai a reszlegen
    var f6 = reszleg.OrderByDescending(x => x.ber).First();
    Console.WriteLine($"{f6.nev} {(f6.nem ? "férfi" : "nő")} {f6.reszleg} {f6.belepes} {f6.ber}");
}

Console.WriteLine($"-----------------------------------------------------------");

//f7
var reszlegek = berek.Select(x => x.reszleg).Distinct().ToList();
foreach (var r in reszlegek)
{
    var dolgozokSzama = berek.Count(x => x.reszleg == r);
    Console.WriteLine($"{r} részlegen {dolgozokSzama} dolgozó dolgozik");
}

//kb 20 perc

Console.ReadKey();