DECLARE @BillboardStaging TABLE
(	
	BillboardID		INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[WeekPosted]	DATETIMEOFFSET NOT NULL,
	[WeekRanking]	INT NOT NULL,
	[AlbumName]		NVARCHAR(256),
	[ArtistName]	NVARCHAR(128)
);

WITH BillboardStagingTest([WeekPosted], [WeekRanking], [AlbumName], [ArtistName])
AS
(
	SELECT 
		V.[WeekPosted], 
		V.[WeekRanking], 
		V.[AlbumName], 
		V.[ArtistName]
	FROM
	OPENROWSET (
		BULK 'C:\Users\campi\OneDrive\Documents\Coding\Python\cis560 data\2020-2021datum.txt',
		FORMATFILE = 'C:\Users\campi\OneDrive\Documents\Coding\Python\cis560 data\billboard200f.fmt'
	) as V([WeekPosted], [WeekRanking], [AlbumName], [ArtistName])
)
INSERT @BillboardStaging([WeekPosted], [WeekRanking], [AlbumName], [ArtistName])
SELECT B.WeekPosted, B.WeekRanking, B.AlbumName, B.ArtistName
FROM BillboardStagingTest B;

MERGE [MusicDatabase].Music.Album T
USING @BillboardStaging S
	ON S.[AlbumName] = T.[Name]
WHEN MATCHED THEN
	UPDATE
	SET
	WeekPosted = S.[WeekPosted]