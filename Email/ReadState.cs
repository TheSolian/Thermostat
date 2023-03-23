namespace Code8031.Email;

public class ReadState : IEmailState
{
  public bool canDelete(Email email)
  {
    return true;
  }

  public string read(Email email)
  {
    return email.Text;
  }

  public void setUnread(Email email)
  {
    email.EmailState = new UnreadState();
  }
}