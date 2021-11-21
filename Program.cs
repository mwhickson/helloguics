using Terminal.Gui;

Application.Init();

var top = Application.Top;

var win = new Window("Hello") {
  X = 0,
  Y = 1,

  Width = Dim.Fill(),
  Height = Dim.Fill()
};

top.Add(win);

var menu = new MenuBar(
  new MenuBarItem[] {
    new MenuBarItem("_File", new MenuItem[] {
        new MenuItem("_Quit", "", () => { if (Quit()) top.Running = false; })
      })
  }
);

top.Add(menu);

static bool Quit() {
  var result = MessageBox.Query(50, 7, "Quit", "Are you sure?", "Yes", "No");
  return (result == 0);
}

Application.Run();
