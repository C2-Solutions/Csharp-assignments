# Cursed Calculator

## Inleiding

Bij deze opdracht laat je zien dat je exception handling kunt implementeren in een C# console applicatie.

## Opdracht

Het doel is om een eenvoudige rekenmachine te maken.
Er kunnen twee getallen, x en y, worden ingevoerd.
De rekenmachine moet de volgende bewerkingen kunnen uitvoeren:

* Optellen: x + y
* Aftrekken: x –y
* Vermenigvuldigen: x * y
* Delen: x / y
* Worteltrekken: sqrt(x), het getal y doet dus niet mee
* Machtsverheffen x^y

Maar het is wel een rare rekenmachine,
want er mag geen negatief antwoord uit komen.

Op verschillende niveaus kunnen exception “ge-throwed” worden:
de C#-operators +, -, /, *, etc. kunnen zelf een exception genereren (bijvoorbeeld bij delen door 0)
en je eigen kan exception genereren (bijvoorbeeld om ervoor te zorgen dat het antwoord niet negatief mag zijn).

Ook kunnen die exceptions op verschillende niveaus worden opgevangen,
bijvoorbeeld in een berekenfunctie of op het hoofdniveau in je Main functie.

Om dit mogelijk te maken gaan jullie zoveel mogelijk alles in aparte functiesonderbrengen.
Bijvoorbeeld een berekenfunctie en een functie ShowResult(double result) die het antwoord naar het scherm schrijft.
Dit lijkt wat overbodig, omdat in zo’n kleine applicatie best alles in gewoon in de Main functie zou kunnen staan.

Maar op deze manier heb je controle over welk stuk code excepties genereert en welke ze opvangt.
Doel van de opdracht is om goed na te denken hoe je je applicatie opknipt in stukjes
en welke stukjes excepties moeten kunnen opvangen en welke ze ook moeten “throwen”.

De userinterface zou er als volgt uit kunnen zien.

## Deliverables

Het resultaat van de opdracht is een C# programma dat:

* compileert en runt (vanzelfsprekend).
* programmacode voldoet aan de C# Coding Conventions,
  zie [deze url](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
* een console applicatie
* de getallen –zowel invoer als uitvoer –moeten floating-points zijn (gebruik type double)
  en het moet mogelijk zijn om negatieve getallen. in te voeren.
* de resultaten van de berekeningencorrect berekent.
  Sommige bewerkingen kunnen niet, zoals delen door nul en worteltrekken uit een negatief getal;
  zorg dat het programma niet crasht.
* maak een methodShowResults die het resultaat naar het scherm schrijft.
* maak een eigen exceptiondie door ShowResult(...) wordt gethrowed wanneer de uitkomst die getoond wordt negatief is.
* gebruik maakt van try-catchom de standaard exceptions en de eigen exception afte vangen.
  Het is de bedoeling om de eigen exception te ‘catchen’in een aanroependemethod.
* geen enkele invoer en geen enkele bewerking mag de calculator doencrashen.

Veel succes
