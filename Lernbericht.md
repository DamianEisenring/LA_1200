# Lern-Bericht

Flamingo

Eisenring, Mileti, Frey, Müller

## Einleitung

In diesem Projekt haben wir einen Vokabeltrainer erstellt, in diesem können sie benutzerdefinierte Wörter eingeben und diese dann anschliessend lernen.

## Was habe ich gelernt?

Wir haben in diesem Projekt gelernt, wie und wo wir Foreach Schleifen verwenden müssen.

## Beschreibung

Eine foreach Schleife ist eine Schleife, die vor allem bei Listen oder Arraylisten nützlich ist. Im Code-Fetzen sehen Sie, wie eine foreach Schleife aufgebaut ist.
Die Schleife wird so lange wiederholt, bis es keine "Gegenstände" mehr in der Liste hat. Also zum Beispiel, bis es jeden Namen, die in einer Liste gespeichert sind, ausgegeben hat. 
Man kann die foreach schleife auch genauer spezifizieren, wenn man etwas genauer ausgeben will, oder nur bestimmte teile einer Liste wiederholen will. 
Dazu muss man aber die "Gegenstände" anders einspeichern.

Dazu ein kleines Beispiel:
Ich habe eine Liste, mit Deutschen Wörtern und deren Übersetzung ins Englische. Nun gebe ich mit der foreach schleife jedes Deutsche Wort der Liste aus, und frage den Benutzer nach der englischen Übersetzung. Wenn der Benutzer die Übersetzung korrekt eingibt, speichere ich diese als richtig, wenn der Benutzer die Übersetzung falsch eingibt, speichere ich sie als falsch. Jetzt kann ich in einem zweiten Schritt mit einer foreach Schleife nur alle falschen Wörter wiederholen.

```Csharp
  static void Main(string[] args)
        {
            List<string> Name = new List<string>();
            Name.Add("Gian-Marco Mileti");
            Name.Add("Jan Frey");

            foreach(var nameItem in Name)
            {
                Console.WriteLine(nameItem);
            }
        }
```

![ezgif com-gif-maker](https://user-images.githubusercontent.com/111045919/202412732-4cae6b4e-b9ea-4411-8658-94bcae59a71f.gif)




## Verifikation

Wir haben einem Laien erklärt, was eine Foreach Schleife ist und wie und wann sie verwendet wird.

# Reflexion zum Arbeitsprozess

#### Was lief gut?
In der Schule war es immer einfacher einander zu organisieren, somit waren wir dann auch immer produktiver und konnten somit auch mehr bereits in der Schule erreichen.

#### Was lief nicht gut?

Im Homeschooling waren wir schlecht vorbereitet und hatten somit viel Zeit verloren uns zu organisieren, somit verloren wir viel Zeit in der Realisierenphase.

**VBV**:

Nächstes mal müssen wir uns vor dem Homeschooling besser organisieren, dass wir auch pünktlich alle im gleichem Anruf sind und beginnen können zu arbeiten.
