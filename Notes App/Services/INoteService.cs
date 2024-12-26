using Notes_App.Models;

namespace Notes_App.Services
{
    public interface INoteService
    {
        Task<List<Note>> GetNotesAsync();
        Task CreateNoteAsync(string filename, string content);
        Task<string> GetNoteContentAsync(string filename);
        Task<bool> DeleteNoteAsync(string filename);
    }
}
