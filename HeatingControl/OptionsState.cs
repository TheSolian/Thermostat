namespace Code8031.HeatingControl;

public class OptionsState : IHeatingControlState
{
  public void switchToOptions(HeatingControl heatingControl)
  {

  }

  public void switchToView(HeatingControl heatingControl)
  {
  }

  public void swithToMenu(HeatingControl heatingControl)
  {
    heatingControl.CurrentPage = HeatingControlPage.MENU;
    heatingControl.HeatingControlState = new MenuState();
    heatingControl.printMenuPage(1);
  }
}