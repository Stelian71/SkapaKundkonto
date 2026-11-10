# Skapa kundkonto

Detta projekt är en individuell implementation av funktionaliteten **Skapa kundkonto** för bokningssystemet åt SXX Maskiner och Utrustning AB.

## Funktionalitet

Kunden kan skapa ett kundkonto genom att ange:

- Namn
- Organisationsnummer
- E-post
- Telefonnummer

Systemet validerar kunduppgifterna, kontrollerar om kunden redan finns och skapar därefter kundkontot om uppgifterna är giltiga.

## Teknik

Projektet är utvecklat i:

- C#
- .NET
- Git/GitHub
- PlantUML för aktivitets- och sekvensdiagram

Kunddata lagras tillfälligt i minnet. Ingen databas eller extern tjänst används.

## Köra projektet

Öppna projektmappen i VS Code och kör:

```powershell
dotnet run
```

Följ instruktionerna som visas i terminalen.

## Diagram

Aktivitetsdiagrammet och sekvensdiagrammet finns i mappen `Diagrams`.

## Dokumentation

Den fullständiga dokumentationen för den individuella uppgiften finns i:

`Dokumentation.md`

## GitHub

Projektet finns på GitHub under:

`https://github.com/Stelian71/SkapaKundkonto`