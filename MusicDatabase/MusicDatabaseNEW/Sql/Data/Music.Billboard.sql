DECLARE @BillboardStaging TABLE
(	
	BillboardID		INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[WeekPosted]	DATETIMEOFFSET NOT NULL,
	[WeekRanking]	INT NOT NULL,
	[AlbumName]		NVARCHAR(256) NOT NULL,
	[ArtistName]	NVARCHAR(128) NOT NULL,
	[ReleaseYear]	NVARCHAR(128)
);

WITH BillboardStagingTest([WeekPosted], [WeekRanking], [AlbumName], [ArtistName])
AS
(
	SELECT 
		V.[WeekPosted], 
		V.[WeekRanking], 
		V.[AlbumName], 
		V.[ArtistName],
		V.[ReleaseYear]
	FROM
	OPENROWSET (
		BULK 'Datasets\2020-2021datum.txt',
		FORMATFILE = 'Datasets\billboard200f.fmt'
	) as V([WeekPosted], [WeekRanking], [AlbumName], [ArtistName])
)
INSERT @BillboardStaging([WeekPosted], [WeekRanking], [AlbumName], [ArtistName])
SELECT B.WeekPosted, B.WeekRanking, B.AlbumName, B.ArtistName
FROM BillboardStagingTest B;

MERGE [MusicDatabase].Music.Album T
USING @BillboardStaging S ON S.[AlbumName] = T.[Name]
WHEN NOT MATCHED THEN
   INSERT([Name], [ReleaseDate])
   VALUES(S.[AlbumName], S.[ReleaseYear]);