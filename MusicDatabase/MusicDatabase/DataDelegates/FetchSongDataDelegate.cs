using System;
using System.Data.SqlClient;
using DataAccess;
using MusicDatabase.Models;

namespace MusicDatabase.DataDelegates
{
    internal class FetchSongDataDelegates
    {

        private readonly int personId;

        public FetchSongDataDelegates(int personId)
           : base("Person.FetchPerson")
        {
            this.personId = personId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PersonId", personId);
        }

        public override Person Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(personId.ToString());

            return new Person(personId,
               reader.GetString("FirstName"),
               reader.GetString("LastName"),
               reader.GetString("Email"));
        }

    }
}