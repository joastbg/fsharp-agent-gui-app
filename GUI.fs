
namespace GUI

    open System
    open System.Drawing
    open System.Windows.Forms
    open Agents

    // User interface form
    type public SampleForm() as form =
        inherit Form()

        let valueLabel = new Label(Location=new Point(25,15))
        let startButton = new Button(Location=new Point(25,50))
        let sendButton = new Button(Location=new Point(25,75))
        let agent = MaxAgent.sampleAgent

        let initControls =
            valueLabel.Text <- "Sample Text"
            startButton.Text <- "Start"
            sendButton.Text <- "Send value to agent"
        do
            initControls

            form.Controls.Add(valueLabel)
            form.Controls.Add(startButton)

            form.Text <- "SampleApp F#"

            startButton.Click.AddHandler(new System.EventHandler
                (fun sender e -> form.eventStartButton_Click(sender, e)))

        // Event handlers
        member form.eventStartButton_Click(sender:obj, e:EventArgs) =
            let random = Helpers.genRandomNumber 5
            Console.WriteLine("Sending value to agent: " + random.ToString())
            agent.Post(Update random)
            ()