// recEngine_SpeechRecognized IF version

public void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
{
    if (e.Result.Text == "Hello Bob")
    {
        responces.helloBob();    
    }

    if (e.Result.Text == "I'm good")
    {
        responces.imGood();
    }

    if (e.Result.Text == "How are you")
    {
        responces.howAreYou();
    }

    if (e.Result.Text == "Ok Bob")
    {
        responces.okBob();
    }

    if (e.Result.Text == "Why is dad so annoying")
    {
        responces.whyIsDadSoAnnoying();
    }

    if (e.Result.Text == "What is Jak")
    {
        responces.whatIsJak();
    }

    if (e.Result.Text == "What's my name")
    {
        responces.whatsMyName();
    }

    if (e.Result.Text == "What are you")
    {
        responces.whatAreYou();
    }

    if (e.Result.Text == "What's the time")
    {
        responces.whatsTheTime();
    }

    if (e.Result.Text == "Open Application")
    {
        
    }
}