# Lern-Bericht

Flamingo

Eisenring, Mileti, Frey, Müller

## Einleitung

In diesem Projekt haben wir einen Vokabeltrainer erstellt, in diesem können sie benutzerdefinierte Wörter eingeben und diese dann anschliessend lernen.

## Was habe ich gelernt?

Wir haben in diesem Projekt gelernt wie und wo wir Foreach Schleifen verwenden müssen.

## Beschreibung

Eine foreach schleife ist eine Schleife, die vorallem bei Listen oder Arraylisten nützlich ist. Im Code-Fetzen sehen Sie, wie eine foreach schleife aufgebaut ist.
Die schleife wird so lange wiederholt, bis es keine "Gegenstände" mehr in der Liste hat. Also zum Beispiel, bis es jeden Namen, die in einer Liste gespeichert sind, ausgegeben hat. 
Man kann die foreach schleife auch genauer spezifiziern, wenn man etwas genauer ausgeben will, oder nur bestimmte teile einer Liste wiederholen will. 
Dazu muss man aber die "Gegenstände" anderst einspeichern.

Dazu ein kleines Beispiel:
Ich habe eine Liste, mit Deutschen Wörterm und deren übersetzung is Englische. Nun gebe ich mit der foreach schleife jedes Deutsche Wort der Liste aus, und frage den Benutzer nach der Englischen Übersetzung. Wenn der Benutzer die Übersetzung korrekt eingibt, speichere ich diese als richtig, wenn der Benutzer die Übersetzung falsch eingibt, speichere ich sie als falsch. Nun kann ich in einem zweiten Schritt mit einer foreach Schleife nur alle Falschen wörter wiederholen.

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





## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflexion zum Arbeitsprozess

👍 Überlegen Sie sich jeweils etwas, was gut an Ihrer Arbeit lief; 

👎 und etwas, was nicht gut lief.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.
