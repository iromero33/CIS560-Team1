﻿DECLARE @ArtistStaging TABLE
(
     ArtistID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
      /*SongID INT NOT NULL,*/
      [Name] NVARCHAR(128) NOT NULL

);

/*****************************************************************************/

INSERT @ArtistStaging([Name])
VALUES
     (N'MÃneskin'),
 (N'The Kid LAROI'),
 (N'Olivia Rodrigo'),
 (N'Ed Sheeran'),
 (N'Lil Nas X'),
 (N'Doja Cat'),
 (N'Rauw Alejandro'),
 (N'Bad Bunny'),
 (N'Dua Lipa'),
 (N'J Balvin, Maria Becerra'),
 (N'BTS'),
 (N'Justin Bieber'),
 (N'The Weeknd'),
 (N'Nio Garcia, J Balvin, Bad Bunny'),
 (N'Mora, Bad Bunny, Sech'),
 (N'Glass Animals'),
 (N'Farruko'),
 (N'Post Malone'),
 (N'Riton, Nightcrawlers'),
 (N'Masked Wolf'),
 (N'Bruno Mars, Anderson .Paak, Silk Sonic'),
 (N'Camila Cabello'),
 (N'Sebastian Yatra, Myke Towers'),
 (N'Harry Styles'),
 (N'Polo G'),
 (N'Doja Cat, The Weeknd'),
 (N'Sech, Jhay Cortez'),
 (N'Bad Bunny, Jhay Cortez'),
 (N'TINI, Maria Becerra'),
 (N'J Balvin, KAROL G, Nicky Jam, Crissin, Totoy El Frio, Natan & Shander'),
 (N'Tiesto'),
 (N'Galantis'),
 (N'24kGoldn'),
 (N'Tiago PZK, LIT killah'),
 (N'Wisin, Jhay Cortez, Anuel AA, Los Legendarios, Myke Towers'),
 (N'Bella Poarch'),
 (N'Bizarrap, Nicky Jam'),
 (N'Marc Segui­, Rauw Alejandro, Pol Granch'),
 (N'Billie Eilish'),
 (N'Majestic, Boney M.'),
 (N'Marshmello'),
 (N'Surf Curse'),
 (N'Rauw Alejandro, Mr. Naisgai'),
 (N'Maroon 5'),
 (N'OneRepublic'),
 (N'Megan Thee Stallion'),
 (N'ATB, Topic, A7S'),
 (N'Giveon'),
 (N'Trinidad Cardona'),
 (N'The Neighbourhood'),
 (N'Maluma'),
 (N'Lewis Capaldi'),
 (N'Smiley'),
 (N'Sleepy Hallow'),
 (N'KAROL G, Mariah Angeliq'),
 (N'Justin Quiles, Chimbala, Zion & Lennox'),
 (N'Shouse'),
 (N'Kali Uchis'),
 (N'Gera MX, Christian Nodal'),
 (N'Los Legendarios, Wisin, Jhay Cortez'),
 (N'Tones And I'),
 (N'Drake'),
 (N'Bo Burnham'),
 (N'Travis Scott, HVME'),
 (N'Joel Corry'),
 (N'Joel Corry, RAYE, David Guetta'),
 (N'Justin Wellington, Small Jam'),
 (N'Belly, The Weeknd, Young Thug'),
 (N'Duncan Laurence'),
 (N'Mora, Jhay Cortez'),
 (N'Ariana Grande'),
 (N'RAF Camora, Bonez MC'),
 (N'Natti Natasha, Becky G'),
 (N'J Balvin, Skrillex'),
 (N'WILLOW'),
 (N'Dave'),
 (N'Madison Beer'),
 (N'BANDIDO'),
 (N'Imagine Dragons'),
 (N'Internet Money'),
 (N'Bruno Mars'),
 (N'SAINt JHN'),
 (N'Sech'),
 (N'Becky G, El Alfa'),
 (N'Ingratax'),
 (N'Post Malone, Swae Lee'),
 (N'dhruv'),
 (N'Calvin Harris'),
 (N'Luan Santana'),
 (N'Shawn Mendes, Camila Cabello'),
 (N'MYA, TINI, Duki'),
 (N'Bad Bunny, ROSALÃA'),
 (N'DaBaby'),
 (N'Conan Gray'),
 (N'Tate McRae'),
 (N'Avicii'),
 (N'Vance Joy'),
 (N'Nirvana'),
 (N'Joao Gomes'),
 (N'Trippie Redd'),
 (N'Tom Odell'),
 (N'Jamie Miller'),
 (N'Hozier');

 /***************************************************************/
 MERGE Music.Artist A
USING @ArtistStaging S ON S.ArtistID = A.ArtistID
WHEN MATCHED AND S.[Name] <> A.[Name] THEN
   UPDATE
   SET [Name] = S.[Name]
WHEN NOT MATCHED THEN
   INSERT([Name])
   VALUES(S.[Name]);