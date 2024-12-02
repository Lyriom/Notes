namespace Notes;

public partial class NotePage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    public NotePage()
    {
        InitializeComponent();
        if (File.Exists(_fileName))
            TextEditor.Text = File.ReadAllText(_fileName);
    }
    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        // Guardar el archivo.
        File.WriteAllText(_fileName, TextEditor.Text);
    }
    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        // Eliminar el archivo.
        if (File.Exists(_fileName))
            File.Delete(_fileName);
        TextEditor.Text = string.Empty;
    }
}