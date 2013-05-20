/// (C) Johan Astborg, 2013. joastbg@gmail.com

// Main application entry point
namespace Program

    open System
    open System.Drawing
    open System.Windows.Forms

    open GUI
    
    module Main =
        [<STAThread>]
        do
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(false)
            let view = new SampleForm()
            Application.Run(view)