
CREATE TABLE Kategoria (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nimi NVARCHAR(50) NOT NULL,
    Tyyppi NVARCHAR(20) -- 'Meno' (Expense) or 'Tulo' (Income)
);

CREATE TABLE Tapahtuma (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Summa DECIMAL(18, 2) NOT NULL,
    Paivamaara DATETIME NOT NULL,
    Kuvaus NVARCHAR(200),
    KategoriaID INT,
    FOREIGN KEY (KategoriaID) REFERENCES Kategoria(ID)
);


INSERT INTO Kategoria (Nimi, Tyyppi) VALUES ('Ruoka', 'Meno'), ('Palkka', 'Tulo'), ('Vuokra', 'Meno');