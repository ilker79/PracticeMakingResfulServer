using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Threading.Tasks;


// public class NoteRepository : BaseRepository, IRepository<Note>
public class NoteRepository : BaseRepository
{
    public NoteRepository(IConfiguration configuration) : base(configuration){}
    
    public IEnumerable<Note> GetAll();
    {
        using var connection = CreateConnection();
        return connection.Query<Note>("SELECT * FROM Note");
    }

}
