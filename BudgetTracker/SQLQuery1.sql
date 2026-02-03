INSERT INTO Kategoria (Nimi, Tyyppi) VALUES ('Tulo', 'Tulo'), ('Meno', 'Meno');


INSERT INTO Tapahtuma (TapahtumaNimi, Paivamaara, Summa, KategoriaID, Kuvaus)
VALUES 
('Tammikuun palkka', '2026-01-31', 2850.00, (SELECT ID FROM Kategoria WHERE Nimi='Tulo'), 'Päätyö'),
('S-Market haku', '2026-02-01', 54.20, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Ruokaostokset'),
('Vuokra', '2026-02-01', 750.00, (SELECT ID FROM Kategoria WHERE Nimi='Meno'), 'Helmikuu');