using Notes_App;
using Microsoft.Extensions.DependencyInjection;
using Notes_App.Services;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var services = new ServiceCollection();

        services.AddSingleton<INoteService>(provider =>
            new NoteService(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Notes")));

        var serviceProvider = services.BuildServiceProvider();
        NotesAppForm mainForm = new NotesAppForm(serviceProvider.GetService<INoteService>());
        Application.Run(mainForm);
    }
}