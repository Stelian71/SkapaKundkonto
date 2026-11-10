# Individuell uppgift – Skapa kundkonto

## 1. Val av funktionalitet

Jag har valt att arbeta med user story **"Skapa kundkonto"**, som ingår i **UC04 – Hantera kundkonto**.

### User story

**Som kund vill jag kunna skapa ett kundkonto genom att registrera mina kunduppgifter, så att jag kan få tillgång till bokningssystemet och senare kunna boka utrustning.**

I den individuella uppgiften avgränsas arbetet till själva skapandet av kundkontot. Inloggning, bokning och övriga funktioner i bokningssystemet ingår inte i implementationen.

Kundunderlaget anger att kunden ska kunna skapa ett konto med namn, organisationsnummer, e-postadress och telefonnummer.

---

## 2. Avgränsning

### Ingår

Funktionen omfattar:

- visa registreringsformulär
- registrera namn
- registrera organisationsnummer
- registrera e-postadress
- registrera telefonnummer
- validera kunduppgifter
- kontrollera om kunden redan finns
- skapa ett Customer-objekt
- spara kunduppgifterna
- visa bekräftelse när kundkontot har skapats
- visa felmeddelande vid ogiltiga uppgifter
- visa felmeddelande om kunden redan finns

### Ingår inte

Följande funktioner ingår inte i denna implementation:

- inloggning
- utloggning
- ändring av kunduppgifter
- borttagning av kundkonto
- bokning av utrustning
- betalning
- databas
- extern autentisering
- grafiskt användargränssnitt

Data sparas i minnet under programmets körning. Någon databas eller extern tjänst används därför inte.

---

## 3. Acceptance Criteria

**AC01** Registreringsformuläret innehåller fält för namn, organisationsnummer, e-postadress och telefonnummer.

**AC02** Kunden kan skicka in registreringen när alla obligatoriska uppgifter är ifyllda.

**AC03** Systemet validerar kunduppgifterna innan kundkontot skapas.

**AC04** Systemet kontrollerar om kunden redan finns och förhindrar att ett befintligt kundkonto skapas på nytt.

**AC05** Systemet sparar kundkontot när registreringen har godkänts och kunden inte redan finns.

**AC06** Systemet visar en bekräftelse när kundkontot har skapats.

---

## 4. Huvudflöde

1. Kunden väljer **"Skapa kundkonto"**.
2. Systemet visar registreringsformuläret.
3. Kunden anger namn, organisationsnummer, e-postadress och telefonnummer.
4. Systemet validerar kunduppgifterna.
5. Systemet kontrollerar om kunden redan finns.
6. Systemet skapar ett nytt kundkonto.
7. Kunduppgifterna sparas.
8. Systemet visar en bekräftelse.
9. Registreringen är klar.

---

## 5. Alternativa flöden

### 5.1 Ogiltiga kunduppgifter

1. Kunden anger kunduppgifter.
2. Systemet validerar uppgifterna.
3. Uppgifterna är inte giltiga.
4. Systemet visar ett valideringsfel.
5. Kunden korrigerar uppgifterna.
6. Kunden försöker igen.

Kundkontot skapas inte innan valideringen är godkänd.

### 5.2 Kunden finns redan

1. Kunden anger kunduppgifter.
2. Systemet validerar uppgifterna.
3. Uppgifterna är giltiga.
4. Systemet kontrollerar om kunden redan finns.
5. Kunden finns redan.
6. Systemet visar meddelandet **"Kundkonto finns redan."**
7. Kunden kan korrigera uppgifterna eller försöka igen.

---

## 6. Aktivitetsdiagram

Aktivitetsdiagrammet beskriver arbetsflödet för att skapa ett kundkonto.

Diagrammet börjar med att kunden väljer **"Skapa kundkonto"** och systemet visar registreringsformuläret.

Därefter anger kunden sina uppgifter och systemet validerar dem.

Det första beslutet är:

**Är kunduppgifterna giltiga?**

Om svaret är nej visas ett valideringsfel och kunden får korrigera uppgifterna.

Om svaret är ja kontrollerar systemet:

**Finns kunden redan?**

Om kunden redan finns visas meddelandet **"Kundkonto finns redan"** och kunden får försöka igen.

Om kunden inte finns skapas kundkontot, uppgifterna sparas och systemet visar en bekräftelse.

Aktivitetsdiagrammet finns i projektet:

`Diagrams/aktivitetsdiagram.puml`

---

## 7. Sekvensdiagram

Sekvensdiagrammet visar hur systemets olika delar samarbetar när ett kundkonto skapas.

Följande deltagare används:

- **Kund**
- **UI**
- **CustomerService**
- **CustomerRepository**
- **Customer**

### Ansvarsfördelning

**Kund**

Kunden startar registreringen och anger eller korrigerar sina kunduppgifter.

**UI**

UI ansvarar för kommunikationen med kunden och visar formulär, felmeddelanden och bekräftelser.

**CustomerService**

CustomerService innehåller logiken för att skapa kundkonto. Den validerar uppgifter och kontrollerar om kunden redan finns.

**CustomerRepository**

CustomerRepository ansvarar för att söka efter och spara kundobjekt.

I implementationen används en lista i minnet i stället för en databas.

**Customer**

Customer representerar själva kundobjektet och innehåller kundens uppgifter.

Sekvensdiagrammet finns i projektet:

`Diagrams/sekvensdiagram.puml`

---

## 8. Implementation i C#

Funktionen har implementerats i C#/.NET som en enkel konsolapplikation.

### Projektstruktur

```text
SkapaKundkonto/
├── Diagrams/
│   ├── aktivitetsdiagram.puml
│   └── sekvensdiagram.puml
├── Models/
│   └── Customer.cs
├── Repositories/
│   └── CustomerRepository.cs
├── Services/
│   └── CustomerService.cs
├── Program.cs
├── SkapaKundkonto.csproj
├── .gitignore
└── Dokumentation.md