namespace NoteApp;

public partial class Note : ContentPage
{
	string _filename = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
	public Note()
	{
		InitializeComponent();

		if (File.Exists(_filename))
		{
			TextEditor.Text = File.ReadAllText(_filename);
		}
	}

	private void Save_Clicked(object sender, EventArgs e)
	{
		File.WriteAllText(_filename, TextEditor.Text);
	}


	private void Cancel_Clicked(object sender, EventArgs e)
    {
        if (File.Exists(_filename))
        {
            File.Delete(_filename);
        }

		TextEditor.Text = String.Empty;
    }

}