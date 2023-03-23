namespace Code8031.Email;

public class Email {
  private readonly string _text;
  public string Text => _text;

  private IEmailState _emailState;
  public IEmailState EmailState {
    set {
    _emailState = value;
    }
  }

  public Email(string text) {
    _text = text;
    _emailState = new UnreadState();
  }

  public String read() {
    return _emailState.read(this);
  }

  public void setUnread() {
    _emailState.setUnread(this);
  }

  public bool canDelete() {
    return _emailState.canDelete(this);
  }
}