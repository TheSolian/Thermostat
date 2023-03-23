namespace Code8031.Email;

public class UnreadState : IEmailState
{
  public bool canDelete(Email email)
  {
    return false;
  }

  public string read(Email email)
  {
    email.EmailState = new ReadState();
    return email.Text;
  }

  public void setUnread(Email email)
  {
    
  }
}