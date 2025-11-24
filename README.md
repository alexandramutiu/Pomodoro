# Pomodoro2

A beautifully designed **Pomodoro Timer** built in **C# WinForms**, featuring a modern UI, smooth animation, and a clean code structure.

 **Pomodoro Functionality**

  * 25-minute **Focus mode**
  * 5-minute **Break mode**
  * Start / Stop / Reset controls
  * Animated progress percentage
  * Sound alert when the timer finishes

##  Project Structure

```
PomodoroGUI/
 ├── Form1.cs                // Main logic + gradient + UI behavior
 ├── Form1.Designer.cs       // UI layout
 ├── Form1.resx              // Auto-generated resources
 ├── CircularProgressBar.cs  // Custom round progress control
 ├── PomodoroTimer.cs        // Timer logic (ticks every second)
 └── Program.cs              // App entry point
```

---

##  Technologies Used

* **C# (.NET)**
* **Windows Forms**
* **Visual Studio**
* **GDI+ (for custom drawing)**

---

##  How to Run

1. Clone the repository:

   ```
   git clone https://github.com/your-username/PomodoroTimer.git
   ```
2. Open the solution (`.sln`) in **Visual Studio**
3. Build the project
4. Run the application

---


##  How It Works

* `PomodoroTimer.cs` handles countdown logic using a WinForms timer
* `Form1.cs` updates the UI every second
* `CircularProgressBar.cs` renders the animated circular progress
* Designer file (`Form1.Designer.cs`) builds the fancy layout and styles

---

##  Future Improvements

* Dark mode toggle
* Custom alarm sounds
* Long break mode
* Auto-cycle Pomodoro sessions
* Statistics saved to JSON
* Lofi music background mode



Pull requests and suggestions are welcome!
