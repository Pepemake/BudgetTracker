CREATE TABLE Kategoria (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nimi NVARCHAR(50) NOT NULL, 
    Tyyppi NVARCHAR(20) CHECK (Tyyppi IN ('Tulo', 'Meno'))
);


CREATE TABLE Tapahtuma (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TapahtumaNimi NVARCHAR(100) NOT NULL, 
    Paivamaara DATETIME NOT NULL,
    Summa DECIMAL(18, 2) NOT NULL,
    Kuvaus NVARCHAR(MAX),
    KategoriaID INT FOREIGN KEY REFERENCES Kategoria(ID)
);

INSERT INTO Kategoria (Nimi, Tyyppi) VALUES ('Tulo', 'Tulo'), ('Meno', 'Meno');


INSERT INTO Tapahtuma (TapahtumaNimi, Paivamaara, Summa, KategoriaID, Kuvaus) VALUES 
('Palkka Helmikuu', '2026-02-01', 2900.00, (SELECT ID FROM Kategoria WHERE Nimi='Tulo'), 'Kuukauden pääpalkka'),
('Vuokran maksu', '2026-02-02', 850.00, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Helmikuun vuokra'),
('S-Market haku', '2026-02-03', 64.20, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Viikon ruokaostokset'),
('Bensat: Neste', '2026-02-04', 70.00, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Tankkaus'),
('Netflix', '2026-02-05', 15.99, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Kuukausitilaus'),
('Lidl ostokset', '2026-02-06', 42.15, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Iltapala-tarvikkeet'),
('Kuntosali', '2026-02-07', 39.00, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Jäsenmaksu'),
('Sähkölasku', '2026-02-08', 52.40, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Tammikuun sähköt'),
('Lounas: Subway', '2026-02-09', 12.50, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Työlounas'),
('Palkkio', '2026-02-10', 150.00, (SELECT ID FROM Kategoria WHERE Nimi='Tulo'), 'Sivutyöprojekti'),
('HSL matkakortti', '2026-02-11', 65.00, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Kausilippu'),
('Prisma Olari', '2026-02-12', 110.30, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Isompi kauppareissu'),
('Vesimaksu', '2026-02-13', 20.00, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Vesiennakko'),
('Leffailta', '2026-02-14', 18.00, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Lippu ja popparit'),
('Spotify Family', '2026-02-15', 19.90, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Musiikki'),
('K-Citymarket', '2026-02-16', 55.60, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Päivittäisostokset'),
('Apteekki', '2026-02-17', 25.00, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Vitamiinit'),
('Parkkimaksu', '2026-02-18', 4.50, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'EasyPark'),
('Pizzaperjantai', '2026-02-19', 14.00, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Kotiinkuljetus'),
('Internet-lasku', '2026-02-20', 29.90, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Valokuitu');
GO

SELECT t.TapahtumaNimi, t.Summa, k.Nimi AS Tyyppi
FROM Tapahtuma t
JOIN Kategoria k ON t.KategoriaID = k.ID;

CREATE TABLE Profiili (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nimi NVARCHAR(50) UNIQUE NOT NULL,
    Salasana NVARCHAR(100) NOT NULL 
);


ALTER TABLE Tapahtuma ADD ProfiiliID INT FOREIGN KEY REFERENCES Profiili(ID);