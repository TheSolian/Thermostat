namespace Code8031.HeatingControl;

public interface IHeatingControlState
{
  void switchToOptions(HeatingControl heatingControl);

  void switchToView(HeatingControl heatingControl);

  void swithToMenu(HeatingControl heatingControl);
}