namespace Code8031.HeatingControl;

public class HeatingControl
{
  private int _targetTemperature;
  private HeatingControlPage _currentPage = HeatingControlPage.VIEW;
  private IHeatingControlState _heatingControlState;

  public int TargetTemperature
  {
    get => _targetTemperature;
    set => _targetTemperature = value;
  }

  public IHeatingControlState HeatingControlState
  {
    set => _heatingControlState = value;
  }

  public HeatingControlPage CurrentPage
  {
    get => _currentPage;
    set => _currentPage = value;
  }

  public HeatingControl(int temperature)
  {
    _targetTemperature = temperature;
    _heatingControlState = new ViewState();
    printViewPage();
  }

  public void printViewPage()
  {
    Console.Clear();
    System.Console.WriteLine("############################");
    System.Console.WriteLine("Temperature:");
    System.Console.WriteLine($"  {_targetTemperature}° C");
    System.Console.WriteLine("############################");

    while (Console.ReadKey().Key != ConsoleKey.DownArrow) { }
    _heatingControlState.swithToMenu(this);
  }

  public void printMenuPage(int option)
  {
    Console.Clear();
    if (option == 1)
    {
      System.Console.WriteLine("############################");
      System.Console.WriteLine("Menu");
      System.Console.WriteLine("* Settings");
      System.Console.WriteLine("  View");
      System.Console.WriteLine("############################");

      var pressedKey = Console.ReadKey();

      if (pressedKey.Key == ConsoleKey.DownArrow)
      {
        printMenuPage(2);
      }
      else if (pressedKey.Key == ConsoleKey.Enter)
      {
        _heatingControlState.switchToOptions(this);
      }
    }
    else if (option == 2)
    {
      System.Console.WriteLine("############################");
      System.Console.WriteLine("Menu");
      System.Console.WriteLine("  Settings");
      System.Console.WriteLine("* View");
      System.Console.WriteLine("############################");

      var pressedKey = Console.ReadKey();

      if (pressedKey.Key == ConsoleKey.UpArrow)
      {
        printMenuPage(1);
      }
      else if (pressedKey.Key == ConsoleKey.Enter)
      {
        _heatingControlState.switchToView(this);
      }
    }
  }

  public void printOptionPage()
  {
    Console.Clear();
    System.Console.WriteLine("############################");
    System.Console.WriteLine("Settings");
    System.Console.WriteLine($"  Target temperature: {_targetTemperature}° C (+/-)");
    System.Console.WriteLine("############################");

    var pressedKey = Console.ReadKey();

    if (pressedKey.Key == ConsoleKey.UpArrow)
    {
      TargetTemperature = _targetTemperature + 1;
      printOptionPage();
    }
    else if (pressedKey.Key == ConsoleKey.DownArrow)
    {
      TargetTemperature = _targetTemperature - 1;
      printOptionPage();
    }
    else if (pressedKey.Key == ConsoleKey.Enter)
    {
      _heatingControlState.swithToMenu(this);
    }
  }
}