namespace Szaman
{
    public static class Zapytania
    {
        public const string WszystkieProdukty = @"PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ecommerce: <http://www.example.com/ecommerce#>

SELECT ?produkt ?nazwa ?cena
WHERE {
  ?produkt rdf:type ecommerce:Produkt .
  ?produkt ecommerce:Nazwa ?nazwa .
  ?produkt ecommerce:Cena ?cena .
}";

        public const string ListaZamowien = @"PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ecommerce: <http://www.example.com/ecommerce#>

SELECT ?zamowienie ?metodaPlatnosci ?sposobDostawy
WHERE {
  ?zamowienie rdf:type ecommerce:Zamowienie .
  ?zamowienie ecommerce:oplaconePrzez ?metodaPlatnosci .
  ?zamowienie ecommerce:wyslanePrzez ?sposobDostawy .
}";
        public const string SzczegolyZamowienia = @"PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ecommerce: <http://www.example.com/ecommerce#>

SELECT ?klient ?zamowienie ?produkt ?nazwa ?ilosc
WHERE {
  ?zamowienie ecommerce:zlozonePrzez ?klient .
  ?pozycja ecommerce:znajdujeSieNaZamowieniu ?zamowienie.
  ?pozycja ecommerce:maProduktWPozycji ?produkt .
  ?produkt ecommerce:Nazwa ?nazwa .
  ?pozycja ecommerce:Ilosc ?ilosc .
}";
    }
}