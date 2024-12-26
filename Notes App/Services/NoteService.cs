using Notes_App.Models;
using System.Xml;

namespace Notes_App.Services
{
    public class NoteService : INoteService
    {
        private readonly string _noteDirectory;

        public NoteService(string noteDirectory)
        {
            _noteDirectory = noteDirectory;
        }

        public async Task<List<Note>> GetNotesAsync()
        {
            await EnsureDirectoryExists();

            var notes = new List<Note>();
            try
            {
                var files = Directory.GetFiles(_noteDirectory, "*.xml");

                foreach (var file in files)
                {
                    var fileInfo = new FileInfo(file);
                    notes.Add(new Note
                    {
                        FileName = Path.GetFileName(file),
                        LastModified = fileInfo.LastWriteTime
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving notes: {ex.Message}");
            }

            return notes.OrderByDescending(n => n.LastModified).ToList();
        }

        public async Task CreateNoteAsync(string filename, string content)
        {
            await EnsureDirectoryExists();

            string path = Path.Combine(_noteDirectory, filename);
            if (!path.EndsWith(".xml"))
            {
                path += ".xml";
            }

            try
            {
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    CheckCharacters = false,
                    ConformanceLevel = ConformanceLevel.Auto,
                    Indent = true
                };

                using (XmlWriter writer = XmlWriter.Create(path, settings))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Note");
                    writer.WriteElementString("body", content);
                    writer.WriteEndElement();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating note: {ex.Message}");
                throw;
            }
        }

        public async Task<string> GetNoteContentAsync(string filename)
        {
            await EnsureDirectoryExists();

            string path = Path.Combine(_noteDirectory, filename);
            if (!path.EndsWith(".xml"))
            {
                path += ".xml";
            }

            string content = string.Empty;
            try
            {
                if (File.Exists(path))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(path);
                    content = doc.SelectSingleNode("//body").InnerText;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading note: {ex.Message}");
            }

            return content;
        }

        public async Task<bool> DeleteNoteAsync(string filename)
        {
            await EnsureDirectoryExists();

            string path = Path.Combine(_noteDirectory, filename);
            if (!path.EndsWith(".xml"))
            {
                path += ".xml";
            }

            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting note: {ex.Message}");
                return false;
            }
        }

        private async Task EnsureDirectoryExists()
        {
            if (!Directory.Exists(_noteDirectory))
            {
                await Task.Run(() => Directory.CreateDirectory(_noteDirectory));
            }
        }
    }
}