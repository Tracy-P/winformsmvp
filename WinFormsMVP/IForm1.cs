namespace WinFormsMVP
{
    public interface IForm1
    {
        void LoadData(ModelTwo model);
        event EventHandler<string>? JohnButton;
        event EventHandler<string>? PaulButton;
        event EventHandler<string>? JaneButton;
    }
}