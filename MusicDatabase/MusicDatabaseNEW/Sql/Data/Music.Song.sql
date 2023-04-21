DECLARE @SongStaging TABLE
(
      SongID INT NOT NULL IDENTITY(1, 1),
      Title NVARCHAR(64) NOT NULL,
      ArtistID INT NOT NULL,
      AlbumID INT NOT NULL,
      GenreID INT NOT NULL,
      SpotifyListens INT NOT NULL,
      

      CONSTRAINT PK_Music_Song_SongID PRIMARY KEY CLUSTERED
      (
         SongID ASC
      ),

      CONSTRAINT FK_Music_Song_Music_Artist FOREIGN KEY(ArtistID)
      REFERENCES Music.Artist(ArtistID),

      CONSTRAINT FK_Music_Song_Music_Album FOREIGN KEY(AlbumID)
      REFERENCES Music.Album(AlbumID),

      CONSTRAINT FK_Music_Song_Music_Genre FOREIGN KEY(GenreID)
      REFERENCES Music.Genre(GenreID)

);

/***************************** Modify values here *****************************/

WITH SourceCTE(Title, ArtistID, AlbumID, GenreID, SpotifyListens) AS
(
    SELECT S.Title, AR.ArtistID, AL.AlbumID, G.GenreID, S.SpotifyListens
    FROM
    (
        VALUES
         (N'Beggin ', N'MÃneskin', N'Chosen',  N'[ indie rock italiano ,  italian pop ]', 48633449),
         (N'STAY (with Justin Bieber)', N'The Kid LAROI', N'STAY - Single',  N'[ australian hip hop ]', 47248719),
         (N'good 4 u', N'Olivia Rodrigo', N'SOUR',  N'[ pop ]', 40162559),
         (N'Bad Habits', N'Ed Sheeran', N'Bad Habits - Single',  N'[ pop ,  uk pop ]', 37799456),
         (N'INDUSTRY BABY (feat. Jack Harlow)', N'Lil Nas X', N'INDUSTRY BABY S Single',  N'[ lgbtq+ hip hop ,  pop rap ]', 33948454),
         (N'MONTERO (Call Me By Your Name)', N'Lil Nas X', N'MONTERO (Call Me By Your Name) - Single',  N'[ lgbtq+ hip hop ,  pop rap ]', 30071134),
         (N'Kiss Me More (feat. SZA)', N'Doja Cat', N'Kiss Me More (feat. SZA) - Single',  N'[ dance pop ,  pop ]', 29356736),
         (N'Todo De Ti', N'Rauw Alejandro', N'Todo De Ti - Single',  N'[ puerto rican pop ,  trap latino ]', 26951613),
         (N'Yonaguni', N'Bad Bunny', N'Yonaguni - Single',  N'[ latin ,  reggaeton ,  trap latino ]', 25030128),
         (N'I WANNA BE YOUR SLAVE', N'MÃneskin', N'Teatro d lra - Vol. I',  N'[ indie rock italiano ,  italian pop ]', 24551591),
         (N'Levitating (feat. DaBaby)', N'Dua Lipa', N'Levitating (feat. DaBaby) - Single',  N'[ dance pop ,  pop ,  uk pop ]', 23518010),
         (N'Que Mas Pues?', N'J Balvin, Maria Becerra', N'Que Mas Pues? - Single',  N'[ latin ,  reggaeton ,  reggaeton colombiano ]', 22405111),
         (N'Permission to Dance', N'BTS', N'Butter/Permission to Dance - EP',  N'[ k-pop ,  k-pop boy group ]', 22062812),
         (N'Peaches (feat. Daniel Caesar & Giveon)', N'Justin Bieber', N'Justice',  N'[ canadian pop ,  pop ,  post-teen pop ]', 20294457),
         (N'Butter', N'BTS', N'Butter/Permission to Dance - EP',  N'[ k-pop ,  k-pop boy group ]', 19985713),
         (N'traitor', N'Olivia Rodrigo', N'SOUR',  N'[ pop ]', 19480679),
         (N'deja vu', N'Olivia Rodrigo', N'SOUR',  N'[ pop ]', 18571755),
         (N'Save Your Tears (with Ariana Grande) (Remix)', N'The Weeknd', N'Save Your Tears (with Ariana Grande) (Remix) - Single',  N'[ canadian contemporary r&b ,  canadian pop ,  pop ]', 18053141),
         (N'AM Remix', N'Nio Garcia, J Balvin, Bad Bunny', N'AM Remix - Single',  N'[ latin ,  reggaeton ,  trap latino ]', 17617965),
         (N'Need To Know', N'Doja Cat', N'Planet Her',  N'[ dance pop ,  pop ]', 16908917),
         (N'Volando - Remix', N'Mora, Bad Bunny, Sech', N'Volando - Remix - Single',  N'[ reggaeton ,  trap latino ]', 16606925),
         (N'Ain t Shit', N'Doja Cat', N'Planet Her',  N'[ dance pop ,  pop ]', 16126897),
         (N'drivers license', N'Olivia Rodrigo', N'SOUR',  N'[ pop ]', 15684978),
         (N'Heat Waves', N'Glass Animals', N'Dreamland',  N'[ gauze pop ,  indietronica ,  shiver pop ]', 15089184),
         (N'Blinding Lights', N'The Weeknd', N'After Hours',  N'[ canadian contemporary r&b ,  canadian pop ,  pop ]', 15011809),
         (N'happier', N'Olivia Rodrigo', N'SOUR',  N'[ pop ]', 14849078),
         (N'Pepas', N'Farruko', N'Pepas - Single',  N'[ latin ,  latin hip hop ,  reggaeton ,  trap latino ]', 14809458),
         (N'Motley Crew', N'Post Malone', N'Motley Crew - Single',  N'[ dfw rap ,  melodic rap ,  rap ]', 14329162),
         (N'Friday (feat. Mufasa & Hypeman) - Dopamine Re-Edit', N'Riton, Nightcrawlers', N'Friday (feat. Mufasa & Hypeman) - Dopamine Re-Edit - Single',  N'[ dance pop ,  house ,  pop dance ,  tropical house ,  uk dance ]', 14273637),
         (N'Astronaut In The Ocean', N'Masked Wolf', N'Astronaut In The Ocean - Single',  N'[ australian hip hop ]', 14174752),
         (N'Leave The Door Open', N'Bruno Mars, Anderson .Paak, Silk Sonic', N'An Evening with Silk Sonic',  N'[ dance pop ,  pop ,  post-teen pop ]', 13963568),
         (N'Don t Go Yet', N'Camila Cabello', N'Don t Go Yet - Single',  N'[ dance pop ,  electropop ,  pop ,  post-teen pop ]', 13205250),
         (N'favorite crime', N'Olivia Rodrigo', N'SOUR',  N'[ pop ]', 12818935),
         (N'Pareja Del Ano', N'Sebastian Yatra, Myke Towers', N'Pareja Del Ano - Single',  N'[ colombian pop ,  latin ,  reggaeton ,  reggaeton colombiano ]', 12572307),
         (N'Watermelon Sugar', N'Harry Styles', N'Fine Line',  N'[ pop ,  post-teen pop ]', 11996689),
         (N'NOT SOBER (feat. Polo G & Stunna Gambino)', N'The Kid LAROI', N'F*CK LOVE 3+: OVER YOU',  N' ', 11869336),
         (N'RAPSTAR', N'Polo G', N'Hall of Fame',  N'[ chicago rap ]', 11683383),
         (N'You Right', N'Doja Cat, The Weeknd', N'Planet Her',  N'[ dance pop ,  pop ]', 11629418),
         (N'911 - Remix', N'Sech, Jhay Cortez', N'911 - Remix - Single',  N'[ latin ,  panamanian pop ,  reggaeton ,  trap latino ]', 11553846),
         (N'DÃKITI', N'Bad Bunny, Jhay Cortez', N'EL ULTIMO TOUR DEL MUNDO',  N'[ latin ,  reggaeton ,  trap latino ]', 11524288),
         (N'Mienteme', N'TINI, Maria Becerra', N'Mienteme - Single',  N'[ latin pop ,  pop argentino ]', 11477024),
         (N'jealousy, jealousy', N'Olivia Rodrigo', N'SOUR',  N'[ pop ]', 11287301),
         (N'Poblado - Remix', N'J Balvin, KAROL G, Nicky Jam, Crissin, Totoy El Frio, Natan & Shander', N'Poblado - Remix - Single',  N'[ latin ,  reggaeton ,  reggaeton colombiano ]', 11283626),
         (N'Dynamite', N'BTS', N'BE',  N'[ k-pop ,  k-pop boy group ]', 11196819),
         (N'The Business', N'Tiesto', N'The Business - Single',  N'[ big room ,  brostep ,  dance pop ,  dutch edm ,  edm ,  electro house ,  house ,  pop dance ,  slap house ,  trance ,  tropical house ]', 10739770),
         (N'Heartbreak Anthem (with David Guetta & Little Mix)', N'Galantis', N'Heartbreak Anthem (with David Guetta & Little Mix) - Single',  N'[ dance pop ,  edm ,  electro house ,  pop ,  pop dance ,  tropical house ]', 10315460),
         (N'Mood (feat. iann dior)', N'24kGoldn', N'El Dorado',  N'[ cali rap ]', 10222056),
         (N'Entre Nosotros', N'Tiago PZK, LIT killah', N'Entre Nosotros - Single',  N'[ trap argentino ]', 10215216),
         (N'Fiel - Remix', N'Wisin, Jhay Cortez, Anuel AA, Los Legendarios, Myke Towers', N'Fiel - Remix - Single',  N'[ latin ,  latin hip hop ,  reggaeton ,  trap latino ]', 10032746),
         (N'Build a Bitch', N'Bella Poarch', N'Build a Bitch - Single',  N'[]', 9841998),
         (N'Nicky Jam: Bzrp Music Sessions, Vol. 41', N'Bizarrap, Nicky Jam', N'Nicky Jam: Bzrp Music Sessions, Vol. 41 - Single',  N'[ argentine hip hop ,  pop venezolano ,  trap argentino ,  trap latino ]', 9799701),  (N'Tiroteo - Remix', N'Marc Segui­, Rauw Alejandro, Pol Granch', N'Tiroteo - Remix - Single',  N'[]', 9781153),
         (N'NDA', N'Billie Eilish', N'Happier Then Ever',  N'[ electropop ,  pop ]', 9635619),
         (N'Rasputin', N'Majestic, Boney M.', N'Rasputin - Single',  N'[ house ,  pop dance ,  uk dance ]', 9600707),
         (N'Leave Before You Love Me (with Jonas Brothers)', N'Marshmello', N'Leave Before You Love Me (with Jonas Brothers) - Single',  N'[ brostep ,  edm ,  pop ,  pop dance ,  progressive electro house ]', 9428494),
         (N'Freaks', N'Surf Curse', N'Freaks - Single',  N'[ dreamo ,  indie surf ,  surf punk ,  vegas indie ]', 9319465),
         (N'Meu Pedaco de Pecado', N'Joao Gomes', N'Meu PedaÃ§o de Pecado - Single',  N'[]', 9206366),
         (N'2/Catorce', N'Rauw Alejandro, Mr. Naisgai', N'2/Catorce - Single',  N'[ puerto rican pop ,  trap latino ]', 9086979),
         (N'Beautiful Mistakes (feat. Megan Thee Stallion)', N'Maroon 5', N'JORDI',  N'[ pop ,  pop rock ]', 9048966),
         (N'Run', N'OneRepublic', N'Human',  N'[ dance pop ,  piano rock ,  pop ,  pop rock ]', 9017356),
         (N'Thot Shit', N'Megan Thee Stallion', N'Thot Shit - Single',  N'[ houston rap ,  pop ,  pop rap ,  trap queen ]', 8977336),
         (N'Your Love (9PM)', N'ATB, Topic, A7S', N'Your Love (9PM) - Single',  N'[ german dance ,  german techno ,  german trance ,  trance ]', 8935418),
         (N'brutal', N'Olivia Rodrigo', N'SOUR',  N'[ pop ]', 8881356),
         (N'Save Your Tears', N'The Weeknd', N'After Hours',  N'[ canadian contemporary r&b ,  canadian pop ,  pop ]', 8843110),
         (N'Heartbreak Anniversary', N'Giveon', N'Heartbreak Anniversary - Single',  N'[ pop ,  r&b ]', 8832945),
         (N'Dont Start Now', N'Dua Lipa', N'Future Nostalgia',  N'[ pop ]', 8821971),
         (N'Dinero', N'Trinidad Cardona', N'Dinero - Single',  N'[ pop ]', 8564775),
         (N'Sweater Weather', N'The Neighbourhood', N'I Love You.',  N'[ modern alternative rock ,  modern rock ,  pop ]', 8564017),
         (N'Sobrio', N'Maluma', N'Sobrio - Single',  N'[ latin ,  reggaeton ,  reggaeton colombiano ]', 8514480),
         (N'Someone You Loved', N'Lewis Capaldi', N'Divinely Uninspired To A Hellish Extent',  N'[ pop ,  uk pop ]', 8490162),
         (N'Over The Top (feat. Drake)', N'Smiley', N'Over The Top (feat. Drake) - Single',  N'[ canadian hip hop ,  toronto rap ]', 8269753),
         (N'2055', N'Sleepy Hallow', N'2055 - Single',  N'[ brooklyn drill ,  nyc rap ]', 8133401),
         (N'EL MAKINON', N'KAROL G, Mariah Angeliq', N'2021 Hitazos',  N'[ latin ,  reggaeton ,  reggaeton colombiano ]', 8102107),
         (N'Loco', N'Justin Quiles, Chimbala, Zion & Lennox', N'La Ultima Promesa',  N'[ latin ,  reggaeton ,  trap latino ]', 8093413),
         (N'Love Tonight - Edit', N'Shouse', N'Love Tonight - Single',  N'[ aussietronica ]', 8006336),
         (N'ZITTI E BUONI', N'MÃneskin', N'ZITTI E BUONI - Single',  N'[ indie rock italiano ,  italian pop ]', 7975148),
         (N'telepatia', N'Kali Uchis', N'Sin Miedo (del Amor y Otros Demonios)',  N'[ colombian pop ,  pop ]', 7912399),
         (N'Botella Tras Botella', N'Gera MX, Christian Nodal', N'Botella Tras Botella - Single',  N'[ mexican hip hop ,  rap conciencia ]', 7735223),
         (N'Fiel', N'Los Legendarios, Wisin, Jhay Cortez', N'Los Legendarios 001',  N'[ reggaeton ,  trap latino ]', 7717211),
         (N'Dance Monkey', N'Tones And I', N'The Kids Are Coming - EP',  N'[ australian pop ,  pop ]', 7687058),
         (N'WITHOUT YOU', N'The Kid LAROI', N'F*CK LOVE 3+: OVER YOU',  N'[ australian hip hop ]', 7642130),
         (N'Wants and Needs (feat. Lil Baby)', N'Drake', N'Scary Hours 2',  N'[ canadian hip hop ,  canadian pop ,  hip hop ,  pop rap ,  rap ,  toronto rap ]', 7637626),
         (N'Bezos I', N'Bo Burnham', N'INSIDE',  N'[ comic ]', 7516291),
         (N'Love Again', N'Dua Lipa', N'Future Nostalgia',  N'[ pop ]', 7465445),
         (N'Goosebumps - Remix', N'Travis Scott, HVME', N'Goosebumps - Remix - Single',  N'[ rap ,  slap house ]', 7452633),
         (N'Head & Heart (feat. MNEK)', N'Joel Corry', N'Head & Heart (feat. MNEK) - Single',  N'[ dance pop ,  edm ,  pop ,  pop dance ,  tropical house ,  uk dance ]', 7434252),
         (N'BED', N'Joel Corry, RAYE, David Guetta', N'BED - Single',  N'[ dance pop ,  edm ,  pop ,  pop dance ,  tropical house ,  uk dance ]', 7383369),
         (N'Iko Iko (My Bestie)', N'Justin Wellington, Small Jam', N'Iko Iko (My Bestie) - Single',  N'[ melanesian pop ,  pacific islands pop ,  png pop ]', 7381585),
         (N'Better Believe', N'Belly, The Weeknd, Young Thug', N'Better Believe - Single',  N'[ canadian hip hop ,  canadian trap ,  pop rap ,  rap ,  southern hip hop ,  trap ,  trap soul ,  underground hip hop ]', 7365053),
         (N'Arcade', N'Duncan Laurence', N'Arcade - Single',  N'[ dutch pop ]', 7353795),
         (N'512', N'Mora, Jhay Cortez', N'Primer Dia de Clases',  N'[ reggaeton ,  trap latino ]', 7336542),
         (N'positions', N'Ariana Grande', N'Positions',  N'[ dance pop ,  pop ,  post-teen pop ]', 7244853),
         (N'Circles', N'Post Malone', N'Hollywood s Bleeding',  N'[ dfw rap ,  melodic rap ,  rap ]', 7156162),
         (N'Blaues Licht', N'RAF Camora, Bonez MC', N'Blaues Licht - Single',  N'[ german hip hop ]', 7084292),
         (N'Ram Pam Pam', N'Natti Natasha, Becky G', N'Ram Pam Pam - Single',  N'[ latin ,  latin pop ,  rap latina ,  reggaeton ,  trap latino ]', 7064003),
         (N'In Da Getto', N'J Balvin, Skrillex', N'JOSE',  N'[ urbano latino ]', 6984262),
         (N'Woman', N'Doja Cat', N'Planet Her',  N'[ dance pop ,  pop ]', 6858466),
         (N't r a n s p a r e n t s o u l feat. Travis Barker', N'WILLOW', N't r a n s p a r e n t s o u l feat. Travis Barker - Single',  N'[ afrofuturism ,  dance pop ,  electropop ,  pop ,  pop rap ,  post-teen pop ]', 6853994),
         (N'Clash (feat. Stormzy)', N'Dave', N'We re All Alone In This Together',  N'[ uk hip hop ]', 6825463),
         (N'Before You Go', N'Lewis Capaldi', N'Divinely Uninspired To A Hellish Extent (Extended Edition)',  N'[ pop ,  uk pop ]', 6813800),
         (N'Levitating', N'Dua Lipa', N'Future Nostalgia',  N'[ dance pop ,  pop ,  uk pop ]', 6799831),
         (N'Reckless', N'Madison Beer', N'Reckless - Single',  N'[ alt z ,  dance pop ,  electropop ,  pop ,  post-teen pop ]', 6711375),
         (N'No Me Conocen (Remix) [con DUKI, Rei & Tiago PZK]', N'BANDIDO', N'No Me Conocen (Remix) [con DUKI, Rei & Tiago PZK] - Single',  N'[]', 6709106),
         (N'Believer', N'Imagine Dragons', N'Evolve',  N'[ modern rock ,  pop ,  rock ]', 6699895),
         (N'Lemonade (feat. Gunna, Don Toliver & NAV)', N'Internet Money', N'Lemonade (feat. Gunna, Don Toliver & NAV) - Single',  N'[ pop rap ,  rap ,  trap ]', 6697067),
         (N'Talking to the Moon', N'Bruno Mars', N'Doo-Wops & Hooligans',  N'[ dance pop ,  pop ,  post-teen pop ]', 6660319),
         (N'Roses - Imanbek Remix', N'SAINt JHN', N'Roses - Imanbek Remix - Single',  N'[ melodic rap ,  pop rap ,  rap ,  slap house ,  trap ]', 6653690),
         (N'Sal y Perrea', N'Sech', N'42',  N'[ latin ,  panamanian pop ,  reggaeton ,  trap latino ]', 6635076),
         (N'Fulanito', N'Becky G, El Alfa', N'Fulanito - Single',  N'[ dance pop ,  latin ,  latin pop ,  latin viral pop ,  pop ,  rap latina ,  reggaeton ,  trap latino ]', 6614072),
         (N'Paris', N'Ingratax', N'Pari­s - Single',  N'[]', 6584896),
         (N'lovely (with Khalid)', N'Billie Eilish', N'lovely (with Khalid) - Single',  N'[ electropop ,  pop ]', 6569547),
         (N'Sunflower - Spider-Man: Into the Spider-Verse', N'Post Malone, Swae Lee', N'Sunflower - Spider-Man: Into the Spider-Verse - Single',  N'[]', 6546948),
         (N'double take', N'dhruv', N'double take - Single',  N'[ chill r&b ,  nyc pop ]', 6539852),
         (N'Streets', N'Doja Cat', N'Hot Pink',  N'[ dance pop ,  pop ]', 6502302),
         (N'By Your Side (feat. Tom Grennan)', N'Calvin Harris', N'By Your Side (feat. Tom Grennan) - Single',  N'[ dance pop ,  edm ,  electro house ,  house ,  pop ,  progressive house ,  uk dance ]', 6488622),
         (N'MORENA', N'Luan Santana', N'MORENA - Single',  N'[ sertanejo ,  sertanejo pop ,  sertanejo universitario ]', 6469500),
         (N'Shape of You', N'Ed Sheeran', N'Divide',  N'[ pop ,  uk pop ]', 6452492),
         (N'Senorita', N'Shawn Mendes, Camila Cabello', N'Senorita - Single',  N'[ canadian pop ,  dance pop ,  pop ,  post-teen pop ,  viral pop ]', 6317487),
         (N'Hold On', N'Justin Bieber', N'Justice',  N'[ pop ]', 6300416),
         (N'Perfect', N'Ed Sheeran', N'Divide',  N'[ pop ,  uk pop ]', 6278765),
         (N'2:50 Remix', N'MYA, TINI, Duki', N'2:50 Remix - Single',  N'[ latin pop ]', 6244011),
         (N'LA NOCHE DE ANOCHE', N'Bad Bunny, ROSALÃA', N'EL ULTIMO TOUR DEL MUNDO',  N'[ latin ,  reggaeton ,  trap latino ]', 6242863),
         (N'ROCKSTAR (feat. Roddy Ricch)', N'DaBaby', N'BLAME IT ON BABY',  N'[ north carolina hip hop ,  rap ]', 6180056),
         (N'Heather', N'Conan Gray', N'Kid Krow',  N'[ alt z ,  bedroom pop ,  electropop ,  indie pop ,  pop ,  post-teen pop ]', 6164795),
         (N'you broke me first', N'Tate McRae', N'you broke me first - Single',  N'[ alt z ,  dance pop ,  pop ,  post-teen pop ]', 6152121),
         (N'The Nights', N'Avicii', N'The Days/Nights - EP',  N'[ dance pop ,  edm ,  pop ,  pop dance ]', 6136340),
         (N'Riptide', N'Vance Joy', N'Dream Your Life Away (Special Edition)',  N'[ folk-pop ,  modern rock ,  pop ,  pop rock ]', 6089242),
         (N'Smells Like Teen Spirit', N'Nirvana', N'Nevermind',  N'[ grunge ,  permanent wave ,  rock ]', 6065267),
         (N'enough for you', N'Olivia Rodrigo', N'SOUR',  N'[ pop ]', 6040918),
         (N'Daddy Issues', N'The Neighbourhood', N'Wiped Out!',  N'[ modern alternative rock ,  modern rock ,  pop ]', 6014443),
         (N'Aquelas Coisas', N'Joao Gomes', N'Eu Tenho A Senha!',  N'[]', 6012839),
         (N'Miss The Rage (feat. Playboi Carti)', N'Trippie Redd', N'Miss The Rage (feat. Playboi Carti) - Single',  N'[ melodic rap ,  rap ,  trap ]', 5952490),
         (N'Memories', N'Maroon 5', N'JORDI (Deluxe Edition)',  N'[ pop ,  pop rock ]', 5928329),
         (N'Another Love', N'Tom Odell', N'Long Way Down',  N'[ pop ]', 5914661),
         (N'Here s Your Perfect', N'Jamie Miller', N'Broken Memories - EP',  N'[ pop soul ]', 5912784),
         (N'Take Me To Church', N'Hozier', N'Hozier (Bonus Track Version)',  N'[ irish singer-songwriter ,  modern rock ,  pop ]', 5907750)
 
    ) S(Title, ArtistName, AlbumName, Genre, SpotifyListens)
        INNER JOIN Music.Artist AR ON AR.[Name] = S.ArtistName
        INNER JOIN Music.Album AL ON AL.[Name] = S.AlbumName
        INNER JOIN Music.Genre G ON G.[Name] = S.Genre
)
MERGE Music.Song S
USING SourceCTE C ON C.SongID = S.SongID
WHEN MATCHED THEN
    UPDATE
    SET
    S.Title = C.Title,
    S.ArtistID = C.ArtistID,
    S.AlbumID = C.AlbumID,
    S.GenreID = C.GenreID,
    S.SpotifyListens = C.SpotifyListens
WHEN NOT MATCHED THEN
    INSERT(Title, ArtistID, AlbumID, GenreID, SpotifyListens)
    VALUES(C.Title, C.ArtistID, C.AlbumID, C.GenreID, C.SpotifyListens);

/******************************************************************************/