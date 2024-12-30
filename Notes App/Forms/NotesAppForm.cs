using Notes_App.Services;

namespace Notes_App
{
    public partial class NotesAppForm : Form
    {
        private readonly INoteService _noteService;
        private bool IsDarkMode { get; set; } = false;

        public NotesAppForm(INoteService noteService)
        {
            InitializeComponent();
            _noteService = noteService;
            InitializeUI();
        }

        private async void InitializeUI()
        {
            await UpdateNoteList();
        }

        private async Task UpdateNoteList()
        {
            try
            {
                var notes = await _noteService.GetNotesAsync();
                lst_ListNotes.Items.Clear();
                foreach (var note in notes.OrderByDescending(n => n.LastModified))
                {
                    lst_ListNotes.Items.Add(new ListViewItem(note.FileName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update note list: {ex.Message}", "Error");
            }
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = txtFilename.Text.Trim();
                string content = txtNote.Text.Trim();

                if (string.IsNullOrEmpty(filename))
                {
                    ShowErrorMessage("Please enter a filename.");
                    return;
                }

                if (string.IsNullOrEmpty(content))
                {
                    ShowErrorMessage("Please enter some content.");
                    return;
                }

                await _noteService.CreateNoteAsync(filename, content);
                ShowSuccessMessage($"Note '{filename}' created successfully.");
                ClearAll();
                await UpdateNoteList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to create note: {ex.Message}", "Error");
            }
        }

        private async void ClearAll()
        {
            txtFilename.Clear();
            txtNote.Clear();
            await UpdateNoteList();
        }

        private async void Lst_ListNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_ListNotes.SelectedItems.Count > 0)
            {
                string filename = lst_ListNotes.SelectedItems[0].Text;
                try
                {
                    string content = await _noteService.GetNoteContentAsync(filename);
                    txtFilename.Text = filename;
                    txtNote.Text = content;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load note '{filename}': {ex.Message}", "Error");
                }
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private async void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (lst_ListNotes.SelectedItems.Count > 0)
            {
                string filename = lst_ListNotes.SelectedItems[0].Text;

                // Show confirmation dialog
                DialogResult confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete '{filename}'?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    bool deletionSuccessful = await _noteService.DeleteNoteAsync(filename);

                    if (deletionSuccessful)
                    {
                        ShowSuccessMessage($"Note '{filename}' deleted successfully.");
                        await UpdateNoteList();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to delete note '{filename}'.", "Error");
                    }
                }
            }
            else
            {
                ShowErrorMessage("Please select a note to delete.");
            }
        }

        private void ToggleDarkMode()
        {
            bool success = false;
            UpdateUIVisibility(success);

            if (IsDarkMode)
            {
                success = ApplyLightTheme();
            }
            else
            {
                success = ApplyDarkTheme();
            }

            UpdateUIVisibility(success);
        }

        private void UpdateUIVisibility(bool status)
        {
            lbl_Title.Visible = status;
            lbl_filename.Visible = status;
            txtFilename.Visible = status; 
            picbox_swModes.Visible = status;
        }

        private bool ApplyDarkTheme()
        {
            lbl_Title.ForeColor = Color.WhiteSmoke;
            lbl_filename.ForeColor = Color.WhiteSmoke;
            txtFilename.BackColor = Color.DimGray;
            txtFilename.ForeColor = Color.WhiteSmoke;

            this.BackgroundImage = Properties.Resources.background_dark;
            picbox_swModes.BackgroundImage = Properties.Resources.swmode_dark;

            IsDarkMode = true;
            return true;
        }

        private bool ApplyLightTheme()
        {
            lbl_Title.ForeColor = Color.DimGray;
            lbl_filename.ForeColor = Color.DimGray;
            txtFilename.BackColor = Color.WhiteSmoke;
            txtFilename.ForeColor = Color.DimGray;

            this.BackgroundImage = Properties.Resources.background_light;
            picbox_swModes.BackgroundImage = Properties.Resources.swmode_light;

            IsDarkMode = false; 
            return true;

        }
        private void Picbox_swModes_Click(object sender, EventArgs e)
        {
            ToggleDarkMode();
        }

        private static void ShowSuccessMessage(string message) => MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private static void ShowErrorMessage(string message) => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}