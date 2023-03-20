//creazione di un istanza
Prodotti Aspirapolvere = new Prodotti(012548120, "Aspirapolvere", "aspirapolvere da 100W", 59.99, 22);

//Oggetto code è di sola lettura:
//product.Code = 8257522; //impossibile assegnare un valore ad una propietà perchè è di sola lettura.

//stampa a schermo dei vari dati:
Console.WriteLine("Nome articolo:");
Console.WriteLine(Aspirapolvere.name);
Console.WriteLine("Nome completo articolo");
Console.WriteLine(Aspirapolvere.ExtendedName());
Console.WriteLine("Descrizione:");
Console.WriteLine(Aspirapolvere.description);
Console.WriteLine("Codice:");
Console.WriteLine(Aspirapolvere.Code);
Console.WriteLine("prezzo:");
Console.WriteLine(Aspirapolvere.price);
Console.WriteLine("Iva in %");
Console.WriteLine(Aspirapolvere.tax);
Console.WriteLine("prezzo totale IVA compresa");
Console.WriteLine($"{Aspirapolvere.Fullprice(Aspirapolvere.price, Aspirapolvere.tax)} euro");


Prodotti Fotocamera = new Prodotti(47458621, "Fotocamera Canon", "Fotocamera bella", 450, 22);


Console.WriteLine("Nome articolo:");
Console.WriteLine(Fotocamera.name);
Console.WriteLine("Nome completo articolo");
Console.WriteLine(Fotocamera.ExtendedName());
Console.WriteLine("Descrizione:");
Console.WriteLine(Fotocamera.description);
Console.WriteLine("Codice:");
Console.WriteLine(Fotocamera.Code);
Console.WriteLine("prezzo:");
Console.WriteLine(Fotocamera.price);
Console.WriteLine("Iva in %");
Console.WriteLine(Fotocamera.tax);
Console.WriteLine("prezzo totale IVA compresa");
Console.WriteLine($"{Fotocamera.Fullprice(Fotocamera.price, Fotocamera.tax)} euro");
