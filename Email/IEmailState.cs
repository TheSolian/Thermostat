namespace Code8031.Email;

public interface IEmailState {
  string read(Email email);

  void setUnread(Email email);

  bool canDelete(Email email);
}