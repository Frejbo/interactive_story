string[] yesWords = {"ja", "visst", "okej", "varför inte", "why not", "kanske det", "oki", "ok", "k", "godkänt", "javisst", "japp", "jadå", "jajamensan"};


Console.WriteLine("Jag har ingen aning vad jag ska skriva här, vill du spela ändå?");
if (yesOrNo() == false) {
    Console.WriteLine("Jag som hade en så bra berättelse... aja hejdå :(");
    System.Threading.Thread.Sleep(2000);
    System.Environment.Exit(0);
}

Console.WriteLine("Okej... men jag har fortfarande inget kul att säga... vill du ha ett virus istället?");
bool hasVirus = false;
if (yesOrNo()) {
    hasVirus = true;
    // try {
    //     System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\crome.exe", "https://youtu.be/dQw4w9WgXcQ");
    // }
    // catch (System.ComponentModel.Win32Exception) {
    // Console.WriteLine("Darn it jag kunde inte hitta din webbläsare... Vart har du gömt den? >:((");
    // Console.WriteLine("Om jag bara kunde...");
    Console.WriteLine("Okej, vänta lite...");
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
System.Threading.Thread.Sleep(1000);

Console.WriteLine("Vad sägs om att köra sten-sax-påse?");
if (yesOrNo()) {
    bool playStenSaxPase = true;
    while (playStenSaxPase) {
        string[] stenSaxPase = {"Sten", "Sax", "Påse"};

        for (int i = 0; i < stenSaxPase.Length; i++) {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(stenSaxPase[i]);
        }
        Console.WriteLine("*tar upp en knytnäve*");
        System.Threading.Thread.Sleep(700);
        Console.WriteLine("Vann jag?");
        if (yesOrNo()) {
            Console.WriteLine("YES LESs GOOOO");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Vill du köra igen?");
            if (!yesOrNo()) { playStenSaxPase = false; }
        } else {
            Console.WriteLine("FAN");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Jag ska hemsöka dig");
            System.Threading.Thread.Sleep(700);
            Console.WriteLine("Vi kör igen.");
        }
    }
} else {
    if (hasVirus) {
        Console.WriteLine($"Varför är du så tråkig? Du vill varken ha virus ELLER köra sten sax påse :(");
    } else {
        Console.WriteLine("Nehe varför är du så tråkig?");
    }
    Console.WriteLine("Har inte några fler ideér då eftersom du är så tråkig...");
    System.Threading.Thread.Sleep(2000);
    System.Environment.Exit(0);
}

Console.WriteLine("Måste ta en promenad med min guldfisk nu, vi ses!");
System.Threading.Thread.Sleep(2000);
System.Environment.Exit(0);


bool yesOrNo() {
    if (yesWords.Contains(Console.ReadLine().ToLower())) {
        return true;
    } else {
        return false;
    }
}


Console.ReadLine();