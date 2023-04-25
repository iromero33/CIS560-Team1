DECLARE @BillboardStaging TABLE
(	
	BillboardID		INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[WeekPosted]	DATETIMEOFFSET NOT NULL,
	[WeekRanking]	INT NOT NULL,
	[AlbumName]		NVARCHAR(128) NOT NULL,
	[ArtistName]	NVARCHAR(64) NOT NULL,
	[ReleaseYear]	INT
);

WITH BillboardStagingTest([WeekPosted], [WeekRanking], [AlbumName], [ArtistName], [ReleaseYear])
AS
(
	SELECT 
		V.[WeekPosted], 
		V.[WeekRanking], 
		V.[AlbumName], 
		V.[ArtistName],
		V.[ReleaseYear]
	FROM (
		VALUES
		('2020-01-04',1,N'Fine Line',N'Harry Styles',2019),
		('2020-01-04',2,N'Christmas (Deluxe Special Edition)',N'Michael Bubl�',2012),
		('2020-01-04',3,N'Please Excuse Me for Being Antisocial',N'Roddy Ricch',2019),
		('2020-01-04',4,N'Merry Christmas',N'Mariah Carey',1994),
		('2020-01-04',5,N'WHEN WE ALL FALL ASLEEP, WHERE DO WE GO?',N'Billie Eilish',2019),
		('2020-01-04',6,N'Hollywood''s Bleeding',N'Post Malone',2019),
		('2020-01-04',7,N'The Best Of Pentatonix Christmas',N'Pentatonix',2019),
		('2020-01-04',8,N'The Christmas Song (Expanded Edition)',N'Nat King Cole',1962),
		('2020-01-04',9,N'Frozen II',N'Soundtrack',NULL),
		('2020-01-04',10,N'So Much Fun',N'Young Thug',2019),
		('2020-01-04',11,N'Lover',N'Taylor Swift',2019),
		('2020-01-04',12,N'Ultimate Christmas',N'Frank Sinatra',2017),
		('2020-01-04',13,N'A Charlie Brown Christmas (Soundtrack)',N'Vince Guaraldi Trio',NULL),
		('2020-01-04',14,N'20th Century Masters: The Millennium Collection: Best Of Bing Crosby',N'Bing Crosby',1999),
		('2020-01-04',15,N'A Christmas Gift For You From Phil Spector',N'Various Artists',1963),
		('2020-01-04',16,N'Rudolph The Red-Nosed Reindeer',N'Burl Ives',1965),
		('2020-01-04',17,N'Rockin'' Around The Christmas Tree/The Decca Christmas Recordings',N'Brenda Lee',1999),
		('2020-01-04',18,N'The Classic Christmas Album',N'Perry Como',2014),
		('2020-01-04',19,N'What You See Is What You Get',N'Luke Combs',2019),
		('2020-01-04',20,N'KIRK',N'DaBaby',2019),
		('2020-01-04',21,N'Rudolph The Red Nosed Reindeer And Other Christmas Classics',N'Gene Autry',1947),
		('2020-01-04',22,N'A Legendary Christmas',N'John Legend',2019),
		('2020-01-04',23,N'The Classic Christmas Album',N'Andy Williams',2013),
		('2020-01-04',24,N'Fully Loaded: God''s Country',N'Blake Shelton',2019),
		('2020-01-04',25,N'It''s Christmas Time',N'Elvis Presley',NULL),
		('2020-01-04',26,N'Cuz I Love You',N'Lizzo',2019),
		('2020-01-04',27,N'The Best Of Bobby Helms',N'Bobby Helms',1983),
		('2020-01-04',28,N'Over It',N'Summer Walker',2019),
		('2020-01-04',29,N'Abbey Road (Remastered)',N'The Beatles',1969),
		('2020-01-04',30,N'A Love Letter To You 4',N'Trippie Redd',2019),
		('2020-01-04',31,N'Bing Crosby - Christmas Classics',N'Bing Crosby',2006),
		('2020-01-04',32,N'dont smile at me',N'Billie Eilish',2017),
		('2020-01-04',33,N'AI YoungBoy 2',N'YoungBoy Never Broke Again',2019),
		('2020-01-04',34,N'Goodbye & Good Riddance',N'Juice WRLD',2018),
		('2020-01-04',35,N'Romance',N'Camila Cabello',2019),
		('2020-01-04',36,N'Wrapped In Red',N'Kelly Clarkson',2013),
		('2020-01-04',37,N'Greatest Hits II',N'Queen',1991),
		('2020-01-04',38,N'The Dean Martin Christmas Album',N'Dean Martin',1966),
		('2020-01-04',39,N'Death Race For Love (Bonus Track Version)',N'Juice WRLD',2019),
		('2020-01-04',40,N'The Andy Williams Christmas Album',N'Andy Williams',1963),
		('2020-01-04',41,N'Ghetto Gospel',N'Rod Wave',2019),
		('2020-01-04',42,N'Star Wars: The Rise Of Skywalker',N'Soundtrack',NULL),
		('2020-01-04',43,N'George Michael & Wham! Last Christmas: The Original Motion Picture Soundtrack',N'George Michael',2019),
		('2020-01-04',44,N'Divinely Uninspired To A Hellish Extent',N'Lewis Capaldi',2019),
		('2020-01-04',45,N'beerbongs & bentleys',N'Post Malone',2018),
		('2020-01-04',46,N'Diamonds (Deluxe)',N'Elton John',2017),
		('2020-01-04',47,N'No.6 Collaborations Project',N'Ed Sheeran',2019),
		('2020-01-04',48,N'Melly vs. Melvin',N'YNW Melly',2019),
		('2020-01-04',49,N'thank u, next',N'Ariana Grande',2019),
		('2020-01-04',50,N'This One''s for You Too (Deluxe Edition)',N'Luke Combs',2018),
		('2020-01-04',51,N'ASTROWORLD',N'Travis Scott',2018),
		('2020-01-04',52,N'Indigo (Extended)',N'Chris Brown',2019),
		('2020-01-04',53,N'The Jackson 5 Christmas Album',N'Jackson 5',NULL),
		('2020-01-04',54,N'Feliz Navidad',N'Jos� Feliciano',2002),
		('2020-01-04',55,N'No�l',N'Josh Groban',2007),
		('2020-01-04',56,N'Christmas Portrait (Special Edition/Reissue)',N'Carpenters',1978),
		('2020-01-04',57,N'Cottonwood 2',N'NLE Choppa',2023),
		('2020-01-04',58,N'Hamilton: An American Musical',N'Original Broadway Cast',NULL),
		('2020-01-04',59,N'Free Spirit',N'Khalid',2019),
		('2020-01-04',60,N'Scorpion',N'Drake',2018),
		('2020-01-04',61,N'A Winter Romance',N'Dean Martin',1959),
		('2020-01-04',62,N'9',N'Jason Aldean',2019),
		('2020-01-04',63,N'Rumours (Super Deluxe)',N'Fleetwood Mac',1977),
		('2020-01-04',64,N'7 EP',N'Lil Nas X',2019),
		('2020-01-04',65,N'Perfect Ten',N'Mustard',2019),
		('2020-01-04',66,N'Legend - The Best Of Bob Marley And The Wailers',N'Bob Marley & The Wailers',2002),
		('2020-01-04',67,N'Stoney (Deluxe)',N'Post Malone',2016),
		('2020-01-04',68,N'East Atlanta Santa 3',N'Gucci Mane',2019),
		('2020-01-04',69,N'Chronicle The 20 Greatest Hits',N'Creedence Clearwater Revival',NULL),
		('2020-01-04',70,N'Under The Mistletoe (Deluxe Edition)',N'Justin Bieber',2011),
		('2020-01-04',71,N'Guardians Of The Galaxy: Awesome Mix Vol. 1',N'Soundtrack',NULL),
		('2020-01-04',72,N'We Love You Tecca',N'Lil Tecca',2019),
		('2020-01-04',73,N'The Search',N'NF',2019),
		('2020-01-04',74,N'American Teen',N'Khalid',2017),
		('2020-01-04',75,N'BLAME IT ON BABY',N'DaBaby',2020),
		('2020-01-04',76,N'Bad Vibes Forever',N'XXXTENTACION',2019),
		('2020-01-04',77,N'True 2 Myself',N'Lil Tjay',2019),
		('2020-01-04',78,N'17',N'XXXTENTACION',2017),
		('2020-01-04',79,N'How The Grinch Stole Christmas (Soundtrack)',N'Boris Karloff / Thurl Ravenscroft',NULL),
		('2020-01-04',80,N'Thriller 25 Super Deluxe Edition',N'Michael Jackson',2008),
		('2020-01-04',81,N'The Kids Are Coming (EP)',N'Tones And I',NULL),
		('2020-01-04',82,N'Berry Christmas (EP)',N'Chuck Berry',NULL),
		('2020-01-04',83,N'Chixtape 5',N'Tory Lanez',2019),
		('2020-01-04',84,N'Traveller',N'Chris Stapleton',2015),
		('2020-01-04',85,N'20th Century Masters - The Best of Stevie Wonder: The Christmas Collection',N'Stevie Wonder',2004),
		('2020-01-04',86,N'Fear Inoculum',N'TOOL',2019),
		('2020-01-04',87,N'Power To The People: The Hits',N'John Lennon',NULL),
		('2020-01-04',88,N'Merry Christmas From The Beach Boys',N'The Beach Boys',NULL),
		('2020-01-04',89,N'The Greatest Showman Solo Piano',N'Instrumental Movie Soundtrack Guys',2020),
		('2020-01-04',90,N'Back In Black',N'AC/DC',1980),
		('2020-01-04',91,N'The Very Best of the Eagles (2013 Remaster)',N'Eagles',2003),
		('2020-01-04',92,N'Look Up Child',N'Lauren Daigle',2018),
		('2020-01-04',93,N'Shawn Mendes',N'Shawn Mendes',2018),
		('2020-01-04',94,N'A Pentatonix Christmas Deluxe',N'Pentatonix',2017),
		('2020-01-04',95,N'Journey''s Greatest Hits',N'Journey',NULL),
		('2020-01-04',96,N'Bohemian Rhapsody (The Original Soundtrack)',N'Queen',2018),
		('2020-01-04',97,N'k bye for now (swt live)',N'Ariana Grande',2019),
		('2020-01-04',98,N'� (Deluxe)',N'Ed Sheeran',2017),
		('2020-01-04',99,N'IGOR',N'Tyler, The Creator',2019),
		('2020-01-04',100,N'Happiness Begins',N'Jonas Brothers',2019),
		('2020-01-04',101,N'Ultimate Sinatra',N'Frank Sinatra',2015),
		('2020-01-04',102,N'The Dark Side of the Moon',N'Pink Floyd',1973),
		('2020-01-04',103,N'Christmas Eve and Other Stories',N'Trans-Siberian Orchestra',1996),
		('2020-01-04',104,N'Old Dominion',N'Old Dominion',2019),
		('2020-01-04',105,N'Quality Control: Control The Streets, Volume 2',N'Various Artists',NULL),
		('2020-01-04',106,N'Hoodie SZN',N'A Boogie Wit da Hoodie',2018),
		('2020-01-04',107,N'2014 Forest Hills Drive',N'J. Cole',2014),
		('2020-01-04',108,N'Summertime Shootout 3: Coldest Summer Ever',N'Fabolous',2019),
		('2020-01-04',109,N'1 (Remastered)',N'The Beatles',2000),
		('2020-01-04',110,N'Dreamville & J. Cole: Revenge Of The Dreamers III',N'Various Artists',NULL),
		('2020-01-04',111,N'Ella Wishes You A Swinging Christmas (Expanded Edition)',N'Ella Fitzgerald',1960),
		('2020-01-04',112,N'Norman Fucking Rockwell!',N'Lana Del Rey',2019),
		('2020-01-04',113,N'Hot Pink',N'Doja Cat',2019),
		('2020-01-04',114,N'Invasion of Privacy',N'Cardi B',2018),
		('2020-01-04',115,N'Greatest Hits',N'Tom Petty and the Heartbreakers',2008),
		('2020-01-04',116,N'Swimming',N'Mac Miller',2018),
		('2020-01-04',117,N'Born To Die - The Paradise Edition',N'Lana Del Rey',2012),
		('2020-01-04',118,N'JESUS IS KING (Soundtrack)',N'Kanye West',NULL),
		('2020-01-04',119,N'Pray for the Wicked',N'Panic! At The Disco',2018),
		('2020-01-04',120,N'Take Care (Deluxe)',N'Drake',2011),
		('2020-01-04',121,N'If I Know Me',N'Morgan Wallen',2018),
		('2020-01-04',122,N'Coconut Oil (EP)',N'Lizzo',NULL),
		('2020-01-04',123,N'DAMN.',N'Kendrick Lamar',2017),
		('2020-01-04',124,N'Golden Hour',N'Kacey Musgraves',2018),
		('2020-01-04',125,N'You Make It Feel Like Christmas',N'Gwen Stefani',2017),
		('2020-01-04',126,N'Sgt. Pepper''s Lonely Hearts Club Band (Remastered)',N'The Beatles',1967),
		('2020-01-04',127,N'Homesick (EP)',N'Trevor Daniel',NULL),
		('2020-01-04',128,N'Frozen: The Songs',N'Soundtrack',NULL),
		('2020-01-04',129,N'Dan + Shay',N'Dan + Shay',2018),
		('2020-01-04',130,N'Nevermind (Remastered)',N'Nirvana',1991),
		('2020-01-04',131,N'Luv Is Rage 2',N'Lil Uzi Vert',2017),
		('2020-01-04',132,N'That''s Christmas To Me (Deluxe Edition)',N'Pentatonix',2015),
		('2020-01-04',133,N'A Star Is Born Soundtrack',N'Lady Gaga',2018),
		('2020-01-04',134,N'I''m Him',N'Kevin Gates',NULL),
		('2020-01-04',135,N'Snowflakes',N'Toni Braxton',2001),
		('2020-01-04',136,N'Wildcard',N'Miranda Lambert',2019),
		('2020-01-04',137,N'White Christmas',N'Bing Crosby',1945),
		('2020-01-04',138,N'Christmas: A Season Of Love',N'Idina Menzel',2019),
		('2020-01-04',139,N'The Very Best Of The Beach Boys: Sounds Of Summer',N'The Beach Boys',2003),
		('2020-01-04',140,N'good kid, m.A.A.d city (Deluxe)',N'Kendrick Lamar',2012),
		('2020-01-04',141,N'Blurryface',N'Twenty One Pilots',2015),
		('2020-01-04',142,N'These are Special Times',N'C�line Dion',1998),
		('2020-01-04',143,N'Championships',N'Meek Mill',2018),
		('2020-01-04',144,N'McCartney III Imagined',N'Paul McCartney',2021),
		('2020-01-04',145,N'21',N'Adele',2011),
		('2020-01-04',146,N'Christmas Is Here!',N'Pentatonix',2018),
		('2020-01-04',147,N'Metallica (Remastered)',N'Metallica',1991),
		('2020-01-04',148,N'We Wish You A Merry Christmas',N'The Ray Conniff Singers',1962),
		('2020-01-04',149,N'Everyday Is Christmas (Deluxe Edition)',N'Sia',2018),
		('2020-01-04',150,N'Warmer In The Winter (Deluxe Edition)',N'Lindsey Stirling',2018),
		('2020-01-04',151,N'Experiment Extended',N'Kane Brown',2019),
		('2020-01-04',152,N'Evolve',N'Imagine Dragons',2017),
		('2020-01-04',153,N'K-12 (Soundtrack)',N'Melanie Martinez',NULL),
		('2020-01-04',154,N'X 100PRE',N'Bad Bunny',2018),
		('2020-01-04',155,N'MTV Unplugged In New York',N'Nirvana',1994),
		('2020-01-04',156,N'Glittery (feat. Troye Sivan) [From The Kacey Musgraves Christmas Show Soundtrack]',N'Kacey Musgraves',2020),
		('2020-01-04',157,N'Appetite For Destruction',N'Guns N'' Roses',1987),
		('2020-01-04',158,N'40 Christmas Classics',N'Andy Williams',2014),
		('2020-01-04',159,N'Die A Legend',N'Polo G',2019),
		('2020-01-04',160,N'Pure Southern Soul',N'Otis Redding',2007),
		('2020-01-04',161,N'Purple Rain (Soundtrack)',N'Prince And The Revolution',NULL),
		('2020-01-04',162,N'Curtain Call: The Hits (Deluxe Edition)',N'Eminem',2005),
		('2020-01-04',163,N'Greatest Hits',N'Fleetwood Mac',1988),
		('2020-01-04',164,N'Everyday Life',N'Coldplay',2019),
		('2020-01-04',165,N'Back To Black (Deluxe Edition)',N'Amy Winehouse',2006),
		('2020-01-04',166,N'Glow',N'Brett Eldredge',2016),
		('2020-01-04',167,N'Ocean',N'Lady A',2019),
		('2020-01-04',168,N'Christmas Songs by Sinatra',N'Frank Sinatra',1994),
		('2020-01-04',169,N'The Wall',N'Pink Floyd',1979),
		('2020-01-04',170,N'Their Greatest Hits 1971-1975 (2013 Remaster)',N'Eagles',1976),
		('2020-01-04',171,N'The Essential Elvis Presley',N'Elvis Presley',2007),
		('2020-01-04',172,N'Greatest Hits',N'Bob Seger',1994),
		('2020-01-04',173,N'Views',N'Drake',2016),
		('2020-01-04',174,N'1989',N'Taylor Swift',2014),
		('2020-01-04',175,N'Greatest Hits',N'2Pac',1998),
		('2020-01-04',176,N'The Beatles (Remastered)',N'The Beatles',1968),
		('2020-01-04',177,N'GIRL',N'Maren Morris',2019),
		('2020-01-04',178,N'MAP OF THE SOUL : PERSONA',N'BTS',2019),
		('2020-01-04',179,N'Drip Harder',N'Lil Baby & Gunna',NULL),
		('2020-01-04',180,N'Purple Haze 2',N'Cam�ron',2019),
		('2020-01-04',181,N'Love Yourself ? ''Answer''',N'BTS',2018),
		('2020-01-04',182,N'17',N'XXXTENTACION',2017),
		('2020-01-04',183,N'Starboy',N'The Weeknd',2016),
		('2020-01-04',184,N'The Christmas Attic',N'Trans-Siberian Orchestra',1998),
		('2020-01-04',185,N'Sweetener',N'Ariana Grande',2018),
		('2020-01-04',186,N'KIDZ BOP 40',N'Kidz Bop Kids',2019),
		('2020-01-04',187,N'Home For Christmas',N'*NSYNC',1998),
		('2020-01-04',188,N'MONTANA',N'French Montana',2019),
		('2020-01-04',189,N'Beauty Behind The Madness',N'The Weeknd',2015),
		('2020-01-04',190,N'The Classic Christmas Album',N'Tony Bennett',2011),
		('2020-01-04',191,N'Perception',N'NF',2017),
		('2020-01-04',192,N'The Classic Christmas Album',N'Kenny G',2012),
		('2020-01-04',193,N'A Donny Hathaway Collection',N'Donny Hathaway',1990),
		('2020-01-04',194,N'Who''s Next (Deluxe Edition)',N'The Who',1971),
		('2020-01-04',195,N'Trench',N'Twenty One Pilots',2018),
		('2020-01-04',196,N'Ctrl',N'SZA',2017),
		('2020-01-04',197,N'Home Alone II',N'Original Soundtrack',1992),
		('2020-01-04',198,N'Christmas Celebration',N'Mannheim Steamroller',2004),
		('2020-01-04',199,N'Kane Brown (Deluxe Edition)',N'Kane Brown',2017),
		('2020-01-04',200,N'III',N'The Lumineers',2019),
		('2020-01-11',1,N'JACKBOYS',N'JACKBOYS',2019),
		('2020-01-11',2,N'Please Excuse Me for Being Antisocial',N'Roddy Ricch',2019),
		('2020-01-11',3,N'Hollywood''s Bleeding',N'Post Malone',2019),
		('2020-01-11',4,N'Fine Line',N'Harry Styles',2019),
		('2020-01-11',5,N'Frozen II',N'Soundtrack',NULL),
		('2020-01-11',6,N'WHEN WE ALL FALL ASLEEP, WHERE DO WE GO?',N'Billie Eilish',2019),
		('2020-01-11',7,N'So Much Fun',N'Young Thug',2019),
		('2020-01-11',8,N'KIRK',N'DaBaby',2019),
		('2020-01-11',9,N'Lover',N'Taylor Swift',2019),
		('2020-01-11',10,N'Over It',N'Summer Walker',2019),
		('2020-01-11',11,N'A Love Letter To You 4',N'Trippie Redd',2019),
		('2020-01-11',12,N'What You See Is What You Get',N'Luke Combs',2019),
		('2020-01-11',13,N'AI YoungBoy 2',N'YoungBoy Never Broke Again',2019),
		('2020-01-11',14,N'Romance',N'Camila Cabello',2019),
		('2020-01-11',15,N'Goodbye & Good Riddance',N'Juice WRLD',2018),
		('2020-01-11',16,N'Cuz I Love You',N'Lizzo',2019),
		('2020-01-11',17,N'Ghetto Gospel',N'Rod Wave',2019),
		('2020-01-11',18,N'dont smile at me',N'Billie Eilish',2017),
		('2020-01-11',19,N'beerbongs & bentleys',N'Post Malone',2018),
		('2020-01-11',20,N'Divinely Uninspired To A Hellish Extent',N'Lewis Capaldi',2019),
		('2020-01-11',21,N'Death Race For Love (Bonus Track Version)',N'Juice WRLD',2019),
		('2020-01-11',22,N'No.6 Collaborations Project',N'Ed Sheeran',2019),
		('2020-01-11',23,N'Greatest Hits II',N'Queen',1991),
		('2020-01-11',24,N'ASTROWORLD',N'Travis Scott',2018),
		('2020-01-11',25,N'Scorpion',N'Drake',2018),
		('2020-01-11',26,N'Indigo (Extended)',N'Chris Brown',2019),
		('2020-01-11',27,N'Melly vs. Melvin',N'YNW Melly',2019),
		('2020-01-11',28,N'This One''s for You Too (Deluxe Edition)',N'Luke Combs',2018),
		('2020-01-11',29,N'7 EP',N'Lil Nas X',2019),
		('2020-01-11',30,N'thank u, next',N'Ariana Grande',2019),
		('2020-01-11',31,N'Fully Loaded: God''s Country',N'Blake Shelton',2019),
		('2020-01-11',32,N'Perfect Ten',N'Mustard',2019),
		('2020-01-11',33,N'The Kids Are Coming (EP)',N'Tones And I',NULL),
		('2020-01-11',34,N'Free Spirit',N'Khalid',2019),
		('2020-01-11',35,N'Stoney (Deluxe)',N'Post Malone',2016),
		('2020-01-11',36,N'Abbey Road (Remastered)',N'The Beatles',1969),
		('2020-01-11',37,N'BLAME IT ON BABY',N'DaBaby',2020),
		('2020-01-11',38,N'Diamonds (Deluxe)',N'Elton John',2017),
		('2020-01-11',39,N'We Love You Tecca',N'Lil Tecca',2019),
		('2020-01-11',40,N'Hamilton: An American Musical',N'Original Broadway Cast',NULL),
		('2020-01-11',41,N'Shawn Mendes',N'Shawn Mendes',2018),
		('2020-01-11',42,N'True 2 Myself',N'Lil Tjay',2019),
		('2020-01-11',43,N'The Search',N'NF',2019),
		('2020-01-11',44,N'Happiness Begins',N'Jonas Brothers',2019),
		('2020-01-11',45,N'17',N'XXXTENTACION',2017),
		('2020-01-11',46,N'� (Deluxe)',N'Ed Sheeran',2017),
		('2020-01-11',47,N'Chixtape 5',N'Tory Lanez',2019),
		('2020-01-11',48,N'American Teen',N'Khalid',2017),
		('2020-01-11',49,N'Hot Pink',N'Doja Cat',2019),
		('2020-01-11',50,N'Quality Control: Control The Streets, Volume 2',N'Various Artists',NULL),
		('2020-01-11',51,N'If I Know Me',N'Morgan Wallen',2018),
		('2020-01-11',52,N'Dreamville & J. Cole: Revenge Of The Dreamers III',N'Various Artists',NULL),
		('2020-01-11',53,N'Hoodie SZN',N'A Boogie Wit da Hoodie',2018),
		('2020-01-11',54,N'Chronicle The 20 Greatest Hits',N'Creedence Clearwater Revival',NULL),
		('2020-01-11',55,N'Old Dominion',N'Old Dominion',2019),
		('2020-01-11',56,N'Invasion of Privacy',N'Cardi B',2018),
		('2020-01-11',57,N'Frozen 2 Solo Piano',N'Instrumental Movie Soundtrack Guys',2020),
		('2020-01-11',58,N'Dan + Shay',N'Dan + Shay',2018),
		('2020-01-11',59,N'Coconut Oil (EP)',N'Lizzo',NULL),
		('2020-01-11',60,N'Cottonwood 2',N'NLE Choppa',2023),
		('2020-01-11',61,N'Traveller',N'Chris Stapleton',2015),
		('2020-01-11',62,N'The Greatest Showman Solo Piano',N'Instrumental Movie Soundtrack Guys',2020),
		('2020-01-11',63,N'1 (Remastered)',N'The Beatles',2000),
		('2020-01-11',64,N'Homesick (EP)',N'Trevor Daniel',NULL),
		('2020-01-11',65,N'Legend - The Best Of Bob Marley And The Wailers',N'Bob Marley & The Wailers',2002),
		('2020-01-11',66,N'Rumours (Super Deluxe)',N'Fleetwood Mac',1977),
		('2020-01-11',67,N'Take Care (Deluxe)',N'Drake',2011),
		('2020-01-11',68,N'Luv Is Rage 2',N'Lil Uzi Vert',2017),
		('2020-01-11',69,N'DAMN.',N'Kendrick Lamar',2017),
		('2020-01-11',70,N'Journey''s Greatest Hits',N'Journey',NULL),
		('2020-01-11',71,N'9',N'Jason Aldean',2019),
		('2020-01-11',72,N'JESUS IS KING (Soundtrack)',N'Kanye West',NULL),
		('2020-01-11',73,N'Jesus Is Born',N'Sunday Service Choir',2019),
		('2020-01-11',74,N'Championships',N'Meek Mill',2018),
		('2020-01-11',75,N'GIRL',N'Maren Morris',2019),
		('2020-01-11',76,N'I''m Him',N'Kevin Gates',NULL),
		('2020-01-11',77,N'Summertime Shootout 3: Coldest Summer Ever',N'Fabolous',2019),
		('2020-01-11',78,N'Views',N'Drake',2016),
		('2020-01-11',79,N'Experiment Extended',N'Kane Brown',2019),
		('2020-01-11',80,N'X 100PRE',N'Bad Bunny',2018),
		('2020-01-11',81,N'IGOR',N'Tyler, The Creator',2019),
		('2020-01-11',82,N'Die A Legend',N'Polo G',2019),
		('2020-01-11',83,N'Look Up Child',N'Lauren Daigle',2018),
		('2020-01-11',84,N'2014 Forest Hills Drive',N'J. Cole',2014),
		('2020-01-11',85,N'Evolve',N'Imagine Dragons',2017),
		('2020-01-11',86,N'Greatest Hits',N'Tom Petty and the Heartbreakers',2008),
		('2020-01-11',87,N'MONTANA',N'French Montana',2019),
		('2020-01-11',88,N'A Star Is Born Soundtrack',N'Lady Gaga',2018),
		('2020-01-11',89,N'World War Joy',N'The Chainsmokers',2019),
		('2020-01-11',90,N'Pray for the Wicked',N'Panic! At The Disco',2018),
		('2020-01-11',91,N'good kid, m.A.A.d city (Deluxe)',N'Kendrick Lamar',2012),
		('2020-01-11',92,N'Drip Harder',N'Lil Baby & Gunna',NULL),
		('2020-01-11',93,N'Starboy',N'The Weeknd',2016),
		('2020-01-11',94,N'Curtain Call: The Hits (Deluxe Edition)',N'Eminem',2005),
		('2020-01-11',95,N'Back In Black',N'AC/DC',1980),
		('2020-01-11',96,N'Bad Vibes Forever',N'XXXTENTACION',2019),
		('2020-01-11',97,N'Beauty Behind The Madness',N'The Weeknd',2015),
		('2020-01-11',98,N'Norman Fucking Rockwell!',N'Lana Del Rey',2019),
		('2020-01-11',99,N'1989',N'Taylor Swift',2014),
		('2020-01-11',100,N'Sessions',N'G Herbo',2019),
		('2020-01-11',101,N'Ultimate Sinatra',N'Frank Sinatra',2015),
		('2020-01-11',102,N'17',N'XXXTENTACION',2017),
		('2020-01-11',103,N'Thriller 25 Super Deluxe Edition',N'Michael Jackson',2008),
		('2020-01-11',104,N'Believers Never Die, Volume Two: Greatest Hits',N'Fall Out Boy',NULL),
		('2020-01-11',105,N'Star Wars: The Rise Of Skywalker',N'Soundtrack',NULL),
		('2020-01-11',106,N'Moana',N'Soundtrack',NULL),
		('2020-01-11',107,N'Greatest Hits',N'2Pac',1998),
		('2020-01-11',108,N'Born To Die - The Paradise Edition',N'Lana Del Rey',2012),
		('2020-01-11',109,N'Sweetener',N'Ariana Grande',2018),
		('2020-01-11',110,N'Blurryface',N'Twenty One Pilots',2015),
		('2020-01-11',111,N'Birds In The Trap Sing McKnight',N'Travis Scott',2016),
		('2020-01-11',112,N'21',N'Adele',2011),
		('2020-01-11',113,N'More Life',N'Drake',2017),
		('2020-01-11',114,N'Swimming',N'Mac Miller',2018),
		('2020-01-11',115,N'Perception',N'NF',2017),
		('2020-01-11',116,N'The Best Of Pentatonix Christmas',N'Pentatonix',2019),
		('2020-01-11',117,N'Center Point Road',N'Thomas Rhett',2019),
		('2020-01-11',118,N'k bye for now (swt live)',N'Ariana Grande',2019),
		('2020-01-11',119,N'i am > i was',N'21 Savage',2018),
		('2020-01-11',120,N'Golden Hour',N'Kacey Musgraves',2018),
		('2020-01-11',121,N'Ocean',N'Lady A',2019),
		('2020-01-11',122,N'Their Greatest Hits 1971-1975 (2013 Remaster)',N'Eagles',1976),
		('2020-01-11',123,N'The Essential Elvis Presley',N'Elvis Presley',2007),
		('2020-01-11',124,N'Appetite For Destruction',N'Guns N'' Roses',1987),
		('2020-01-11',125,N'Fever',N'Megan Thee Stallion',2019),
		('2020-01-11',126,N'Ctrl',N'SZA',2017),
		('2020-01-11',127,N'Certified Hitmaker',N'Lil Mosey',2020),
		('2020-01-11',128,N'Ella Mai',N'Ella Mai',2018),
		('2020-01-11',129,N'Nevermind (Remastered)',N'Nirvana',1991),
		('2020-01-11',130,N'K-12 (Soundtrack)',N'Melanie Martinez',NULL),
		('2020-01-11',131,N'Kane Brown (Deluxe Edition)',N'Kane Brown',2017),
		('2020-01-11',132,N'reputation',N'Taylor Swift',2017),
		('2020-01-11',133,N'Victory Lap',N'Nipsey Hussle',2018),
		('2020-01-11',134,N'Nothing Was The Same',N'Drake',2013),
		('2020-01-11',135,N'Doo-Wops & Hooligans',N'Bruno Mars',2010),
		('2020-01-11',136,N'Night Visions',N'Imagine Dragons',2012),
		('2020-01-11',137,N'Metallica (Remastered)',N'Metallica',1991),
		('2020-01-11',138,N'The Final Album (EP)',N'LIL PHAG',NULL),
		('2020-01-11',139,N'Blonde',N'Frank Ocean',2016),
		('2020-01-11',140,N'Greatest Hits',N'Bob Seger',1994),
		('2020-01-11',141,N'x (Deluxe Edition)',N'Ed Sheeran',2014),
		('2020-01-11',142,N'H.E.R.',N'H.E.R.',2017),
		('2020-01-11',143,N'A Charlie Brown Christmas (Soundtrack)',N'Vince Guaraldi Trio',NULL),
		('2020-01-11',144,N'Harder Than Ever',N'Lil Baby',2018),
		('2020-01-11',145,N'COSMIC',N'Bazzi',2018),
		('2020-01-11',146,N'Wow... That''s Crazy',N'Wale',2019),
		('2020-01-11',147,N'Currents',N'Tame Impala',2015),
		('2020-01-11',148,N'MAP OF THE SOUL : PERSONA',N'BTS',2019),
		('2020-01-11',149,N'Christmas (Deluxe Special Edition)',N'Michael Bubl�',2012),
		('2020-01-11',150,N'The Very Best Of The Beach Boys: Sounds Of Summer',N'The Beach Boys',2003),
		('2020-01-11',151,N'Greatest Hits',N'The Notorious B.I.G.',2007),
		('2020-01-11',152,N'ANTI (Deluxe)',N'Rihanna',2016),
		('2020-01-11',153,N'Tha Carter V',N'Lil Wayne',2018),
		('2020-01-11',154,N'Fear Inoculum',N'TOOL',2019),
		('2020-01-11',155,N'T R A P S O U L',N'Bryson Tiller',2015),
		('2020-01-11',156,N'Merry Christmas',N'Mariah Carey',1994),
		('2020-01-11',157,N'Feed Tha Streets II',N'Roddy Ricch',2018),
		('2020-01-11',158,N'My Beautiful Dark Twisted Fantasy',N'Kanye West',2010),
		('2020-01-11',159,N'Oasis',N'J Balvin & Bad Bunny',NULL),
		('2020-01-11',160,N'Greatest Hits',N'Fleetwood Mac',1988),
		('2020-01-11',161,N'Greatest Hits 1974-78',N'The Steve Miller Band',NULL),
		('2020-01-11',162,N'In The Lonely Hour',N'Sam Smith',2014),
		('2020-01-11',163,N'The Beatles (Remastered)',N'The Beatles',1968),
		('2020-01-11',164,N'BALLADS 1',N'Joji',2018),
		('2020-01-11',165,N'The Essential Billy Joel',N'Billy Joel',2001),
		('2020-01-11',166,N'Bohemian Rhapsody (The Original Soundtrack)',N'Queen',2018),
		('2020-01-11',167,N'24K Magic',N'Bruno Mars',2016),
		('2020-01-11',168,N'Dying to Live',N'Kodak Black',2018),
		('2020-01-11',169,N'The Dark Side of the Moon',N'Pink Floyd',1973),
		('2020-01-11',170,N'Wildcard',N'Miranda Lambert',2019),
		('2020-01-11',171,N'Flower Boy',N'Tyler, The Creator',2017),
		('2020-01-11',172,N'Drip or Drown 2',N'Gunna',2019),
		('2020-01-11',173,N'I AM YOU',N'YNW Melly',2018),
		('2020-01-11',174,N'LIFE''S A TRIP',N'Trippie Redd',2018),
		('2020-01-11',175,N'Culture II',N'Migos',2018),
		('2020-01-11',176,N'Melt (Deluxe)',N'SHAED',2019),
		('2020-01-11',177,N'Greatest Hits So Far...',N'Zac Brown Band',2014),
		('2020-01-11',178,N'Kamikaze',N'Eminem',2018),
		('2020-01-11',179,N'Nibiru',N'Ozuna',2019),
		('2020-01-11',180,N'The Big Day',N'Chance the Rapper',2019),
		('2020-01-11',181,N'Trench',N'Twenty One Pilots',2018),
		('2020-01-11',182,N'Rearview Town',N'Jason Aldean',2018),
		('2020-01-11',183,N'SuperM: The 1st Mini Album (EP)',N'SuperM',NULL),
		('2020-01-11',184,N'GINGER',N'BROCKHAMPTON',2019),
		('2020-01-11',185,N'A Decade of Destruction, Vol.2',N'Five Finger Death Punch',2020),
		('2020-01-11',186,N'Marshmello: Fortnite Extended Set',N'Marshmello',NULL),
		('2020-01-11',187,N'Hozier (Expanded Edition)',N'Hozier',2014),
		('2020-01-11',188,N'Red Pill Blues (Deluxe)',N'Maroon 5',2018),
		('2020-01-11',189,N'Sgt. Pepper''s Lonely Hearts Club Band (Remastered)',N'The Beatles',1967),
		('2020-01-11',190,N'Die Lit',N'Playboi Carti',2018),
		('2020-01-11',191,N'Future & Juice WRLD Present... WRLD ON DRUGS',N'Future',2018),
		('2020-01-11',192,N'The Christmas Song (Expanded Edition)',N'Nat King Cole',1962),
		('2020-01-11',193,N'Origins (Deluxe)',N'Imagine Dragons',2018),
		('2020-01-11',194,N'Guardians Of The Galaxy: Awesome Mix Vol. 1',N'Soundtrack',NULL),
		('2020-01-11',195,N'Love Yourself ? ''Answer''',N'BTS',2018),
		('2020-01-11',196,N'A Love Letter To You 3',N'Trippie Redd',2018),
		('2020-01-11',197,N'KIDZ BOP 40',N'Kidz Bop Kids',2019),
		('2020-01-11',198,N'25',N'Adele',2015),
		('2020-01-11',199,N'Purpose (Deluxe)',N'Justin Bieber',2015),
		('2020-01-11',200,N'The Very Best of Daryl Hall / John Oates',N'Daryl Hall & John Oates',2001)
		) as V([WeekPosted], [WeekRanking], [AlbumName], [ArtistName], [ReleaseYear])
)
INSERT @BillboardStaging([WeekPosted], [WeekRanking], [AlbumName], [ArtistName])
SELECT B.WeekPosted, B.WeekRanking, B.AlbumName, B.ArtistName
FROM BillboardStagingTest B;

MERGE [MusicDatabase].Music.Album T
USING @BillboardStaging S ON S.[AlbumName] = T.[Name]
WHEN NOT MATCHED THEN
   INSERT([Name], [ReleaseDate])
   VALUES(S.[AlbumName], S.[ReleaseYear]);

INSERT INTO [MusicDatabase].Music.Billboard
SELECT
	S.[WeekPosted],
	S.[WeekRanking],
	A.AlbumID
FROM @BillboardStaging S
	INNER JOIN [MusicDatabase].Music.Album A ON A.[Name] = S.[AlbumName]
