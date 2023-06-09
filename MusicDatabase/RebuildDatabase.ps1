Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "MusicDatabase"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

<#
   If on your local machine, you can drop and re-create the database.
#>
& ".\Scripts\DropDatabase.ps1" -Database $Database
& ".\Scripts\CreateDatabase.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>
#Write-Host "Dropping tables..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Schemas\Music.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Tables\Music.Album.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Tables\Music.Artist.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Tables\Music.Billboard.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Tables\Music.Genre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Tables\Music.Song.sql"

Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.CreateAlbum.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.RetrieveAlbum.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.FetchAlbum.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetAlbum.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.CreateArtist.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.RetrieveArtist.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.FetchArtist.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetArtist.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.CreateSong.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.RetrieveSong.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.FetchSong.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetSong.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.CreateGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.RetrieveGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.FetchGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.CreateBillboard.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.RetrieveBillboard.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.FetchBillboard.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetBillboard.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetAlbumPeakOnBillboard.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetAlbumAppearancesOnBillboard.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetAlbumLongestBillboardAppearance.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetAlbumsByYear.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetSongsByTitle.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetSongsByAlbum.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetSongBySpotifyListens.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetSongByReleaseDate.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetSongsWithMostSpotifyListensPerMonth.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetSongsBySpotifyListensASC.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetSongsBySpotifyListensDESC.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetSongsWithHighestRankAlbumForWeek.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.SaveBillboard.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Procedures\Music.GetSongsByBillboardNumWeeks.sql"

Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Data\Music.Album.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Data\Music.Artist.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Data\Music.Billboard.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Data\Music.Genre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MusicDatabaseNEW\Sql\Data\Music.Song.sql"

Write-Host "Rebuild completed."
Write-Host ""

[Console]::ReadKey()

Set-Location $CurrentDrive
