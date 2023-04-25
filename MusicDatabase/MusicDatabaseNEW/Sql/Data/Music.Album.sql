﻿DECLARE @AlbumStaging TABLE
(
      AlbumID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
      [Name] NVARCHAR(128) NOT NULL,
      ReleaseDate DATETIMEOFFSET NOT NULL
);

/***************************** Modify values here *****************************/

INSERT @AlbumStaging([Name], ReleaseDate)
VALUES
       (N'Chosen',  '2017-12-08'),
     (N'STAY - Single',  '2021-07-09'),
     (N'SOUR',  '2021-05-21'),
     (N'Bad Habits - Single',  '2021-06-25'),
     (N'INDUSTRY BABY S Single',  '2021-07-23'),
     (N'MONTERO (Call Me By Your Name) - Single',  '2021-03-31'),
     (N'Kiss Me More (feat. SZA) - Single',  '2021-04-09'),
     (N'Todo De Ti - Single',  '2021-05-20'),
     (N'Yonaguni - Single',  '2021-06-04'),
     (N'Teatro dlra - Vol. I',  '2021-03-19'),
     (N'Levitating (feat. DaBaby) - Single',  '2020-10-01'),
     (N'Que Mas Pues? - Single',  '2021-05-28'),
     (N'Butter/Permission to Dance - EP',  '2021-07-09'),
     (N'Justice',  '2021-03-19'),
     (N'Save Your Tears (with Ariana Grande) (Remix) - Single',  '2021-04-23'),
     (N'AM Remix - Single',  '2021-06-24'),
     (N'Planet Her',  '2021-06-25'),
     (N'Volando - Remix - Single',  '2021-07-08'),
     (N'Dreamland',  '2020-08-07'),
     (N'After Hours',  '2020-03-20'),
     (N'Pepas - Single',  '2021-06-24'),
     (N'Motley Crew - Single',  '2021-07-09'),
     (N'Friday (feat. Mufasa & Hypeman) - Dopamine Re-Edit - Single',  '2021-01-15'),
     (N'Astronaut In The Ocean - Single',  '2021-01-06'),
     (N'An Evening with Silk Sonic',  '2021-03-05'),
     (N'Dont Go Yet - Single',  '2021-07-23'),
     (N'Pareja Del Ano - Single',  '2021-04-16'),
     (N'Fine Line',  '2019-12-13'),
     (N'F*CK LOVE 3+: OVER YOU',  '2021-07-27'),
     (N'Hall of Fame',  '2021-04-09'),
     (N'911 - Remix - Single',  '2021-07-09'),
     (N'EL ULTIMO TOUR DEL MUNDO',  '2020-11-27'),
     (N'Mienteme - Single',  '2021-04-29'),
     (N'Poblado - Remix - Single',  '2021-06-18'),
     (N'BE',  '2020-11-20'),
     (N'The Business - Single',  '2020-09-16'),
     (N'Heartbreak Anthem (with David Guetta & Little Mix) - Single',  '2021-05-20'),
     (N'El Dorado',  '2021-03-26'),
     (N'Entre Nosotros - Single',  '2021-07-08'),
     (N'Fiel - Remix - Single',  '2021-06-15'),
     (N'Build a Bitch - Single',  '2021-05-14'),
     (N'Nicky Jam: Bzrp Music Sessions, Vol. 41 - Single',  '2021-06-30'),
     (N'Tiroteo - Remix - Single',  '2021-04-01'),
     (N'Happier Then Ever',  '2021-07-30'),
     (N'Rasputin - Single',  '2021-06-25'),
     (N'Leave Before You Love Me (with Jonas Brothers) - Single',  '2021-05-21'),
     (N'Freaks - Single',  '2021-05-15'),
     (N'Meu PedaÃ§o de Pecado - Single',  '2021-06-01'),
     (N'2/Catorce - Single',  '2021-02-14'),
     (N'JORDI',  '2021-06-11'),
     (N'Human',  '2021-05-05'),
     (N'Thot Shit - Single',  '2021-06-11'),
     (N'Your Love (9PM) - Single',  '2021-01-15'),
     (N'Heartbreak Anniversary - Single',  '2020-02-21'),
     (N'Future Nostalgia',  '2020-03-27'),
     (N'Dinero - Single',  '2018-02-02'),
     (N'I Love You.',  '2013-04-19'),
     (N'Sobrio - Single',  '2021-07-08'),
     (N'Divinely Uninspired To A Hellish Extent',  '2019-05-17'),
     (N'Over The Top (feat. Drake) - Single',  '2021-07-23'),
     (N'2055 - Single',  '2021-06-02'),
     (N'2021 Hitazos',  '2021-03-26'),
     (N'La Ultima Promesa',  '2021-05-13'),
     (N'Love Tonight - Single',  '2017-12-14'),
     (N'ZITTI E BUONI - Single',  '2021-03-19'),
     (N'Sin Miedo (del Amor y Otros Demonios)',  '2020-12-04'),
     (N'Botella Tras Botella - Single',  '2021-04-23'),
     (N'Los Legendarios 001',  '2021-02-04'),
     (N'The Kids Are Coming - EP',  '2019-10-17'),
     (N'Scary Hours 2',  '2021-03-05'),
     (N'INSIDE',  '2021-06-10'),
     (N'Goosebumps - Remix - Single',  '2021-01-15'),
     (N'Head & Heart (feat. MNEK) - Single',  '2020-07-03'),
     (N'BED - Single',  '2021-02-26'),
     (N'Iko Iko (My Bestie) - Single',  '2019-06-03'),
     (N'Better Believe - Single',  '2021-07-22'),
     (N'Arcade - Single',  '2019-03-07'),
     (N'Primer Dia de Clases',  '2021-02-05'),
     (N'Positions',  '2020-10-30'),
     (N'Hollywoods Bleeding',  '2019-09-06'),
     (N'Blaues Licht - Single',  '2021-07-16'),
     (N'Ram Pam Pam - Single',  '2021-04-20'),
     (N'JOSE',  '2021-08-12'),
     (N't r a n s p a r e n t s o u l feat. Travis Barker - Single',  '2021-04-27'),
     (N'Were All Alone In This Together',  '2021-07-08'),
     (N'Divinely Uninspired To A Hellish Extent (Extended Edition)',  '2019-11-22'),
     (N'Reckless - Single',  '2021-06-04'),
     (N'No Me Conocen (Remix) [con DUKI, Rei & Tiago PZK] - Single',  '2021-06-16'),
     (N'Evolve',  '2017-06-23'),
     (N'Lemonade (feat. Gunna, Don Toliver & NAV) - Single',  '2020-08-14'),
     (N'Doo-Wops & Hooligans',  '2010-10-05'),
     (N'Roses - Imanbek Remix - Single',  '2020-11-20'),
     (N'42',  '2021-04-15'),
     (N'Fulanito - Single',  '2021-06-03'),
     (N'Pari­s - Single',  '2021-07-09'),
     (N'lovely (with Khalid) - Single',  '2018-04-19'),
     (N'Sunflower - Spider-Man: Into the Spider-Verse - Single',  '2018-12-14'),
     (N'double take - Single',  '2019-05-24'),
     (N'Hot Pink',  '2019-11-07'),
     (N'By Your Side (feat. Tom Grennan) - Single',  '2021-06-04'),
     (N'MORENA - Single',  '2021-06-17'),
     (N'Divide',  '2017-03-03'),
     (N'Senorita - Single',  '2019-06-21'),
     (N'2:50 Remix - Single',  '2021-06-21'),
     (N'BLAME IT ON BABY',  '2020-04-17'),
     (N'Kid Krow',  '2020-03-20'),
     (N'you broke me first - Single',  '2020-04-17'),
     (N'The Days/Nights - EP',  '2014-01-01'),
     (N'Dream Your Life Away (Special Edition)',  '2014-09-09'),
     (N'Nevermind',  '1991-09-26'),
     (N'Wiped Out!',  '2015-10-30'),
     (N'Eu Tenho A Senha!',  '2021-06-01'),
     (N'Miss The Rage (feat. Playboi Carti) - Single',  '2021-05-07'),
     (N'JORDI (Deluxe Edition)',  '2021-06-11'),
     (N'Long Way Down',  '2013-09-17'),
     (N'Broken Memories - EP',  '2021-04-30'),
     (N'Hozier (Bonus Track Version)',  '2014-09-19');


/******************************************************************************/

MERGE Music.Album A
USING @AlbumStaging S ON S.AlbumID = A.AlbumID
WHEN MATCHED AND S.[Name] <> A.[Name] THEN
   UPDATE
   SET [Name] = S.[Name]
WHEN NOT MATCHED THEN
   INSERT([Name], ReleaseDate)
   VALUES(S.[Name], S.ReleaseDate);