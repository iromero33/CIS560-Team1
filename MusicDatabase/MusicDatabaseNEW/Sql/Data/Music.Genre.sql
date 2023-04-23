DECLARE @GenreStaging TABLE
(
      GenreID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
      [Name] NVARCHAR(256) NOT NULL UNIQUE

);

/******************************************************************/

INSERT @GenreStaging([Name])
VALUES 
 (N'[ indie rock italiano ,  italian pop ] '),
 (N'[ australian hip hop ] '),
 (N'[ pop ] '),
 (N'[ pop ,  uk pop ] '),
 (N'[ lgbtq+ hip hop ,  pop rap ] '),
 (N'[ dance pop ,  pop ] '),
 (N'[ puerto rican pop ,  trap latino ] '),
 (N'[ latin ,  reggaeton ,  trap latino ] '),
 (N'[ dance pop ,  pop ,  uk pop ] '),
 (N'[ latin ,  reggaeton ,  reggaeton colombiano ] '),
 (N'[ k-pop ,  k-pop boy group ] '),
 (N'[ canadian pop ,  pop ,  post-teen pop ] '),
 (N'[ reggaeton ,  trap latino ] '),
 (N'[ gauze pop ,  indietronica ,  shiver pop ] '),
 (N'[ canadian contemporary r&b ,  canadian pop ,  pop ] '),
 (N'[ latin ,  latin hip hop ,  reggaeton ,  trap latino ] '),
 (N'[ dfw rap ,  melodic rap ,  rap ] '),
 (N'[ dance pop ,  house ,  pop dance ,  tropical house ,  uk dance ] '),
 (N'[ dance pop ,  pop ,  post-teen pop ] '),
 (N'[ dance pop ,  electropop ,  pop ,  post-teen pop ] '),
 (N'[ colombian pop ,  latin ,  reggaeton ,  reggaeton colombiano ] '),
 (N'[ pop ,  post-teen pop ] '),
 (N'[ chicago rap ] '),
 (N'[ latin ,  panamanian pop ,  reggaeton ,  trap latino ] '),
 (N'[ latin pop ,  pop argentino ] '),
 (N'[ big room ,  brostep ,  dance pop ,  dutch edm ,  edm ,  electro house ,  house ,  pop dance ,  slap house ,  trance ,  tropical house ] '),
 (N'[ dance pop ,  edm ,  electro house ,  pop ,  pop dance ,  tropical house ] '),
 (N'[ cali rap ] '),
 (N'[ trap argentino ] '),
 (N'[ argentine hip hop ,  pop venezolano ,  trap argentino ,  trap latino ] '),
 (N'[ electropop ,  pop ] '),
 (N'[ house ,  pop dance ,  uk dance ] '),
 (N'[ brostep ,  edm ,  pop ,  pop dance ,  progressive electro house ] '),
 (N'[ dreamo ,  indie surf ,  surf punk ,  vegas indie ] '),
 (N'[ pop ,  pop rock ] '),
 (N'[ dance pop ,  piano rock ,  pop ,  pop rock ] '),
 (N'[ houston rap ,  pop ,  pop rap ,  trap queen ] '),
 (N'[ german dance ,  german techno ,  german trance ,  trance ] '),
 (N'[ pop ,  r&b ] '),
 (N'[ modern alternative rock ,  modern rock ,  pop ] '),
 (N'[ canadian hip hop ,  toronto rap ] '),
 (N'[ brooklyn drill ,  nyc rap ] '),
 (N'[ aussietronica ] '),
 (N'[ colombian pop ,  pop ] '),
 (N'[ mexican hip hop ,  rap conciencia ] '),
 (N'[ australian pop ,  pop ] '),
 (N'[ canadian hip hop ,  canadian pop ,  hip hop ,  pop rap ,  rap ,  toronto rap ] '),
 (N'[ comic ] '),
 (N'[ rap ,  slap house ] '),
 (N'[ dance pop ,  edm ,  pop ,  pop dance ,  tropical house ,  uk dance ] '),
 (N'[ melanesian pop ,  pacific islands pop ,  png pop ] '),
 (N'[ canadian hip hop ,  canadian trap ,  pop rap ,  rap ,  southern hip hop ,  trap ,  trap soul ,  underground hip hop ] '),
 (N'[ dutch pop ] '),
 (N'[ german hip hop ] '),
 (N'[ latin ,  latin pop ,  rap latina ,  reggaeton ,  trap latino ] '),
 (N'[ urbano latino ] '),
 (N'[ afrofuturism ,  dance pop ,  electropop ,  pop ,  pop rap ,  post-teen pop ] '),
 (N'[ uk hip hop ] '),
 (N'[ alt z ,  dance pop ,  electropop ,  pop ,  post-teen pop ] '),
 (N'[ modern rock ,  pop ,  rock ] '),
 (N'[ pop rap ,  rap ,  trap ] '),
 (N'[ melodic rap ,  pop rap ,  rap ,  slap house ,  trap ] '),
 (N'[ dance pop ,  latin ,  latin pop ,  latin viral pop ,  pop ,  rap latina ,  reggaeton ,  trap latino ] '),
 (N'[ chill r&b ,  nyc pop ] '),
 (N'[ dance pop ,  edm ,  electro house ,  house ,  pop ,  progressive house ,  uk dance ] '),
 (N'[ sertanejo ,  sertanejo pop ,  sertanejo universitario ] '),
 (N'[ canadian pop ,  dance pop ,  pop ,  post-teen pop ,  viral pop ] '),
 (N'[ latin pop ] '),
 (N'[ north carolina hip hop ,  rap ] '),
 (N'[ alt z ,  bedroom pop ,  electropop ,  indie pop ,  pop ,  post-teen pop ] '),
 (N'[ alt z ,  dance pop ,  pop ,  post-teen pop ] '),
 (N'[ dance pop ,  edm ,  pop ,  pop dance ] '),
 (N'[ folk-pop ,  modern rock ,  pop ,  pop rock ] '),
 (N'[ grunge ,  permanent wave ,  rock ] '),
 (N'[ melodic rap ,  rap ,  trap ] '),
 (N'[ pop soul ] '),
 (N'[ irish singer-songwriter ,  modern rock ,  pop ] ');



 /***************************************************************/
 MERGE Music.Genre A
USING @GenreStaging S ON S.GenreID = A.GenreID
WHEN MATCHED AND S.[Name] <> A.[Name] THEN
   UPDATE
   SET [Name] = S.[Name]
WHEN NOT MATCHED THEN
   INSERT([Name])
   VALUES(S.[Name]);