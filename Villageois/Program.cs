using libVillageois;

Villageois a, b;
string rep;
a = new Villageois("Panoramix", 16, true);
b = new Villageois("Abraracoourcix");
Console.WriteLine(b.getPoids());
b.setPoids(26);
Console.WriteLine(a.ToString());
Console.WriteLine(a.getNom());
Console.WriteLine(a.getPoids());
Console.WriteLine(a.poidsSouleve()+"Kg");
Console.WriteLine(b.getPoids());

a.setDose(3);
Console.WriteLine( $"{a.getNom()} prend {a.} doses");
Console.WriteLine("Apres les doses "+a.plusFort(b));
Console.WriteLine($"{a.getNom()} soulève {a.poidSouleve()} poids");
Console.WriteLine($"{b.getNom()} soulève {b.poidsSouleve()} poids");