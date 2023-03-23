namespace Code8031.HeatingControl;

public class MenuState : IHeatingControlState
{
  public void switchToOptions(HeatingControl heatingControl)
  {
    heatingControl.CurrentPage = HeatingControlPage.OPTIONS;
    heatingControl.HeatingControlState = new OptionsState();
    heatingControl.printOptionPage();
  }

  public void switchToView(HeatingControl heatingControl)
  {
    heatingControl.CurrentPage = HeatingControlPage.VIEW;
    heatingControl.HeatingControlState = new ViewState();
    heatingControl.printViewPage();
  }

  public void swithToMenu(HeatingControl heatingControl)
  {

  }
}