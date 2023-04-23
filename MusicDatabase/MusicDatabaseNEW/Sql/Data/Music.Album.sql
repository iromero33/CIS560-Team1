﻿DECLARE @AlbumStaging TABLE
(
      AlbumID INT NOT NULL PRIMARY KEY,
      [Name] NVARCHAR(64) NOT NULL,
      ReleaseDate DATETIMEOFFSET NOT NULL
);

/***************************** Modify values here *****************************/

INSERT @AlbumStaging([Name], ReleaseDate)
VALUES
     (N'Chosen', '43077'),
     (N'STAY - Single', '44386'),
     (N'SOUR', '44337'),
     (N'Bad Habits - Single', '44372'),
     (N'INDUSTRY BABY S Single', '44400'),
     (N'MONTERO (Call Me By Your Name) - Single', '44286'),
     (N'Kiss Me More (feat. SZA) - Single', '44295'),
     (N'Todo De Ti - Single', '44336'),
     (N'Yonaguni - Single', '44351'),
     (N'Teatro dlra - Vol. I', '44274'),
     (N'Levitating (feat. DaBaby) - Single', '44105'),
     (N'Que Mas Pues? - Single', '44344'),
     (N'Butter/Permission to Dance - EP', '44386'),
     (N'Justice', '44274'),
     (N'Save Your Tears (with Ariana Grande) (Remix) - Single', '44309'),
     (N'AM Remix - Single', '44371'),
     (N'Planet Her', '44372'),
     (N'Volando - Remix - Single', '44385'),
     (N'Dreamland', '44050'),
     (N'After Hours', '43910'),
     (N'Pepas - Single', '44371'),
     (N'Motley Crew - Single', '44386'),
     (N'Friday (feat. Mufasa & Hypeman) - Dopamine Re-Edit - Single', '44211'),
     (N'Astronaut In The Ocean - Single', '44202'),
     (N'An Evening with Silk Sonic', '44260'),
     (N'Dont Go Yet - Single', '44400'),
     (N'Pareja Del Ano - Single', '44302'),
     (N'Fine Line', '43812'),
     (N'F*CK LOVE 3+: OVER YOU', '44404'),
     (N'Hall of Fame', '44295'),
     (N'911 - Remix - Single', '44386'),
     (N'EL ULTIMO TOUR DEL MUNDO', '44162'),
     (N'Mienteme - Single', '44315'),
     (N'Poblado - Remix - Single', '44365'),
     (N'BE', '44155'),
     (N'The Business - Single', '44090'),
     (N'Heartbreak Anthem (with David Guetta & Little Mix) - Single', '44336'),
     (N'El Dorado', '44281'),
     (N'Entre Nosotros - Single', '44385'),
     (N'Fiel - Remix - Single', '44362'),
     (N'Build a Bitch - Single', '44330'),
     (N'Nicky Jam: Bzrp Music Sessions, Vol. 41 - Single', '44377'),
     (N'Tiroteo - Remix - Single', '44287'),
     (N'Happier Then Ever', '44407'),
     (N'Rasputin - Single', '44372'),
     (N'Leave Before You Love Me (with Jonas Brothers) - Single', '44337'),
     (N'Freaks - Single', '44331'),
     (N'Meu PedaÃ§o de Pecado - Single', '44348'),
     (N'2/Catorce - Single', '44241'),
     (N'JORDI', '44358'),
     (N'Human', '44321'),
     (N'Thot Shit - Single', '44358'),
     (N'Your Love (9PM) - Single', '44211'),
     (N'Heartbreak Anniversary - Single', '43882'),
     (N'Future Nostalgia', '43917'),
     (N'Dinero - Single', '43133'),
     (N'I Love You.', '41383'),
     (N'Sobrio - Single', '44385'),
     (N'Divinely Uninspired To A Hellish Extent', '43602'),
     (N'Over The Top (feat. Drake) - Single', '44400'),
     (N'2055 - Single', '44349'),
     (N'2021 Hitazos', '44281'),
     (N'La Ultima Promesa', '44329'),
     (N'Love Tonight - Single', '43083'),
     (N'ZITTI E BUONI - Single', '44274'),
     (N'Sin Miedo (del Amor y Otros Demonios)', '44169'),
     (N'Botella Tras Botella - Single', '44309'),
     (N'Los Legendarios 001', '44231'),
     (N'The Kids Are Coming - EP', '43755'),
     (N'Scary Hours 2', '44260'),
     (N'INSIDE', '44357'),
     (N'Goosebumps - Remix - Single', '44211'),
     (N'Head & Heart (feat. MNEK) - Single', '44015'),
     (N'BED - Single', '44253'),
     (N'Iko Iko (My Bestie) - Single', '43619'),
     (N'Better Believe - Single', '44399'),
     (N'Arcade - Single', '43531'),
     (N'Primer Dia de Clases', '44232'),
     (N'Positions', '44134'),
     (N'Hollywoods Bleeding', '43714'),
     (N'Blaues Licht - Single', '44393'),
     (N'Ram Pam Pam - Single', '44306'),
     (N'JOSE', '44420'),
     (N't r a n s p a r e n t s o u l feat. Travis Barker - Single', '44313'),
     (N'Were All Alone In This Together', '44385'),
     (N'Divinely Uninspired To A Hellish Extent (Extended Edition)', '43791'),
     (N'Reckless - Single', '44351'),
     (N'No Me Conocen (Remix) [con DUKI, Rei & Tiago PZK] - Single', '44363'),
     (N'Evolve', '42909'),
     (N'Lemonade (feat. Gunna, Don Toliver & NAV) - Single', '44057'),
     (N'Doo-Wops & Hooligans', '40456'),
     (N'Roses - Imanbek Remix - Single', '44155'),
     (N'42', '44301'),
     (N'Fulanito - Single', '44350'),
     (N'Pari­s - Single', '44386'),
     (N'lovely (with Khalid) - Single', '43209'),
     (N'Sunflower - Spider-Man: Into the Spider-Verse - Single', '43448'),
     (N'double take - Single', '43609'),
     (N'Hot Pink', '43776'),
     (N'By Your Side (feat. Tom Grennan) - Single', '44351'),
     (N'MORENA - Single', '44364'),
     (N'Divide', '42797'),
     (N'Senorita - Single', '43637'),
     (N'2:50 Remix - Single', '44368'),
     (N'BLAME IT ON BABY', '43938'),
     (N'Kid Krow', '43910'),
     (N'you broke me first - Single', '43938'),
     (N'The Days/Nights - EP', '41640'),
     (N'Dream Your Life Away (Special Edition)', '41891'),
     (N'Nevermind', '33507'),
     (N'Wiped Out!', '42307'),
     (N'Eu Tenho A Senha!', '44348'),
     (N'Miss The Rage (feat. Playboi Carti) - Single', '44323'),
     (N'JORDI (Deluxe Edition)', '44358'),
     (N'Long Way Down', '41534'),
     (N'Broken Memories - EP', '44316'),
     (N'Hozier (Bonus Track Version)', '41901');

/******************************************************************************/

MERGE Music.Ablum A
USING @AlbumStaging S ON S.AblumID = A.AlbumID
WHEN MATCHED AND S.[Name] <> A.[Name] THEN
   UPDATE
   SET [Name] = S.[Name]
WHEN NOT MATCHED THEN
   INSERT([Name], ReleaseDate)
   VALUES(S.[Name], S.ReleaseDate);