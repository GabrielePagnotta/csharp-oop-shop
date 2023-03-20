//creazione di un istanza
Prodotti product = new Prodotti(012548120, "Aspirapolvere", "aspirapolvere da 100W", 59.99, 10);
//Oggetto code è di sola lettura:
product.Code = 8257522; //impossibile assegnare un valore ad una propietà perchè è di sola lettura.
//stampa a schermo dei vari dati:
Console.WriteLine("Nome articolo:");
Console.WriteLine(product.name);
Console.WriteLine("Descrizione:");
Console.WriteLine(product.description);
Console.WriteLine("Codice:");
Console.WriteLine(product.Code);
Console.WriteLine("prezzo:");
Console.WriteLine(product.price);
Console.WriteLine("Iva in %");
Console.WriteLine(product.tax);
Console.WriteLine("prezzo totale IVA compresa");
Console.WriteLine($"{product.Fullprice(product.price,product.tax)} euro");


