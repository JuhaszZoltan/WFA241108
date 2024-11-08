-- CREATE DATABASE elso_adatbazis;
-- USE elso_adatbazis;

CREATE TABLE diakok (
id INT PRIMARY KEY IDENTITY,
nev VARCHAR(64) NOT NULL,
szul DATE,
jogsi BIT NULL);

INSERT INTO diakok VALUES
('Juhász Zoltán', '1990-07-11', 0),
('Lapos Elemér', '1981-02-10', 1),
('Para Zita', '1998-04-14', 0),
('Füty Imre', '2001-01-30', 1),
('Végh Béla', '2010-12-24', 0),
('Viz Elek', '2011-03-15', 0),
('Alap Alfonz', '1999-05-10', 1);
