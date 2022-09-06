string[] yesWords = {"ja", "visst", "okej", "varför inte", "why not", "kanske det", "oki", "ok", "k", "godkänt", "javisst", "japp", "jadå", "jajamensan"};


Console.WriteLine("Jag har ingen aning vad jag ska skriva här, vill du spela ändå?");
if (yesOrNo() == false) {
    Console.WriteLine("Jag som hade en så bra berättelse... aja hejdå :(");
    System.Environment.Exit(0);
}

Console.WriteLine("Okej... men jag har fortfarande inget kul att säga... vill du ha ett virus istället?");
if (yesOrNo()) {
    // try {
    //     System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\crome.exe", "https://youtu.be/dQw4w9WgXcQ");
    // }
    // catch (System.ComponentModel.Win32Exception) {
    Console.WriteLine("Darn it jag kunde inte hitta din webbläsare... Vart har du gömt den? >:((");
    Console.WriteLine("Om jag bara kunde...");
    for (int i = 0; i <= 100; i++) {
        System.IO.File.Copy("rick-astley.jpg", Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"/"+"Rick"+i+".jpg");
    }
    Console.WriteLine("Så... titta på ditt skrivbort >:)");
    // }
    System.Threading.Thread.Sleep(5000);
    Console.WriteLine("Okej det där kanske var lite taskigt...");
}
else {
    Console.WriteLine("Nehe hur tråkig får man vara? Alla vill ha virus! Vad är meningen med att inte ha ett virus på sin dator?");
}
Console.WriteLine("Nåja... vill du göra något annat istället?");
System.Threading.Thread.Sleep(300);

Console.WriteLine("Vad sägs om att köra sten-sax-påse?");
if (yesOrNo()) {
    Console.WriteLine("JAAA");    
}

bool yesOrNo() {
    if (yesWords.Contains(Console.ReadLine().ToLower())) {
        return true;
    } else {
        return false;
    }
}


Console.ReadLine();