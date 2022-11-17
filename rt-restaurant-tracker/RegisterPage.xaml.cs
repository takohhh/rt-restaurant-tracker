using rt_restaurant_tracker.Models;

namespace rt_restaurant_tracker;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    void ChangePageBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        AppShell.Current.GoToAsync("..");
    }

    private static void AddUser(string username, string password)
    {
        UserInfo newUser = new UserInfo();
        newUser.UserName = username;
        newUser.Password = password;
        App.UserRepository.Add(newUser);
    }

    void RegisterBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        string errorMessage = "";
        string uname = RegisterUsernameEntry.Text;
        string pword = RegisterPasswordEntry.Text;
        string confirmPword = RegisterConfirmPasswordEntry.Text;
        if (uname != "" && pword != "")
        {
            if (pword == confirmPword)
            {
                if (App.UserRepository.GetUserByUsername(uname) == null)
                {
                    AddUser(uname, pword);
                    AppShell.Current.GoToAsync("..");
                }
                else
                {
                    errorMessage = "User with username already exists.";
                }

            }
            else
            {
                errorMessage = "Passwords do not match.";
            }

        }
        else
        {
            errorMessage = "Fill in all fields.";
        }

        ErrorMessage.Text = errorMessage;
    }
}
