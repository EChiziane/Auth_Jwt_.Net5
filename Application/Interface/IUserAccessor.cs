namespace Application.Interface
{
    public interface IUserAccessor
    {
        string GetCurrentUserEmail();
        string GetCurrentUserName();
    }
}