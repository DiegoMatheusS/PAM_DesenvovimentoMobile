namespace Notes;

public partial class NotePage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt"); //cria o diretorio para android


    //metodo construtor quando a classe virar realidade torna-se executavel
    public NotePage()
    {
        InitializeComponent();
        if (File.Exists(_fileName))
            TextEditor.Text = File.ReadAllText(_fileName);
    }
    private async void SaveButton_Clicked(object sender, EventArgs e) //é uma assinatura so dele
    {
        // Save the file.
        File.WriteAllText(_fileName, TextEditor.Text); //salva o que foi escrito no TextEditor 
        await DisplayAlert("Salved","Arquivo Salvo com Sucesso","Fechar");
    }
    private async void DeleteButton_Clicked(object sender, EventArgs e)
    {
        // Delete the file.
        if (File.Exists(_fileName))
            { 
                await DisplayAlert("Cuidado!","Parece que você não tem arquivo aqui","Fechar");
            }

        if (File.Exists(_fileName))
            File.Delete(_fileName);
        {
            await DisplayAlert("Boa", "Arquivo Deletado com Sucesso!!", "Fechar");
        }
        TextEditor.Text = string.Empty;

    

    }
}