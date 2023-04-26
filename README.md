# CIS560-Team1
# Music Database

This project is a team collaboration to create a music database for seeing how many Spotify streams a song has and how many Billboard appearances an album has. It is worth noting that the datasets used for this project limited the range of the songs, albums, artists, and Billboard appearances. Some adjustments had to be made and the song and artists only come from Spotify charts in the years 2020-2021. The Billboard info currently only comes from the first two weeks of January 2020. However, data can be added and does not change the functionality of this project.

To use this project, one needs to ensure that the RebuildDatabase Powershell Script is run so that the database is created before attempting to use it. It is located within the MusicDatabase folder. Within Visual Studio, the C# project MusicDatabaseGUI can be run to search, update, and add to the database. Within the MusicDatabase folder, please note that MusicDatabaseNEW is the folder that contains all of the updated SQL scripts and C# classes. MusicDatabase was originally a SQL project and this was changed to be a C# project (MusicDatabaseNEW).

When the GUI is running, one can search the database for a song by its name or for songs by a range of spotify listens. One can also search for albums and its corresponding songs by the album name, album release year, or the exact album release date. Billboard information is returned with the song info based on its associated album. Searches can also be made by the highest number of weeks an album has been on the Billboard. These searches are all meant to be used individually. This means that a search cannot be made for a song by both its name and spotify listens--it must be one or the other.

The general layout for the project is divided into four main folders: DataAccess, MusicDatabaseGUI, MusicDatabaseNEW, and Scripts. 
  - DataAccess contains all of the C# classes for communicating between the SQL scripts and the C# classes used by the user interface. 
  - MusicDatabaseGUI is the Windows Form application that the user sees and uses to interact with the database. 
  - MusicDatacaseNEW contains the majority of the classes and scripts. Within this folder is the C# interfaces for each table in the database along with the subfolders       DataDelegates, Datasets, Models, and SQL.
    -- DataDelegates contains a delegate for each action that can be implemented on the database.
    -- Datasets contains the csv files and API code used for collecting the data.
    -- Models contains the base C# classes for each table in the database.
    -- SQL contains all of the scripts for inserting, updating, and querying the database. It has four folders: Data, Procedures, Schemas, and Tables.
      * Data contains the SQL scripts for the initial insertion of data into the database.
      * Procedures contains the SQL scripts for each action that can be performed on the database (create, fetch, update, etc.)
      * Schemas contains a single SQL file that creates the database schema 'Music'.
      * Tables contains a SQL script for creating each database table and dropping the database tables.
      
 
 
This project was created as part of the requirements for CIS 560 at Kansas State University.
