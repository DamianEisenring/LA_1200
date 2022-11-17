# Projekt

Flamingo

Müller, Mileti, Frey, Eisenring

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   |                                                              |
|       | ...     |                                                              |
| 17.11.2022      | 1.0.0   |Unser Code kann Vokabeln abfragen und speichern, welche falsch und richtig eingegeben wurden. Die Falschen Vokabeln werden erneut abgefragt, bis man alles richtig hatte.                                                             |

## 1 Informieren

### 1.1 Ihr Projekt

Wir programmieren ein Programm in welchem man Vokabeln lernen kann in C#

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |muss |Funktional|Als User möchte ich Wörter eingeben können, dass ich die Wörter die ich Lernen will abfragen kann.|
| 2    |  muss | Funktional | Als User möchte ich meine Wörter abfragen können|
| 3   |  muss | Funktional | Als Computer möchte ich Fehler(Formatfehler) erkennen können, damit ich es anzeigen kann|
| 4    | muss| Funktional  |Als Benutzer möchte ich die falsch eingegebenen Wörter kennen, dass ich sie nochmals lernen kann.|
| 5 |kann |Qualität      | Als Benutzer möchte ich die Wörter mehrmalls lernen können, dass ich mir es besser merken kann.                                |
| 6 |kann|Qualität|Als ein Benutzer möchte ich Wissen wie viele Wörter ich falsch hatte, dass ich weiss wie viel ich noch zu Lernen habe                 |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|1.1|User will die Wörter die er Lernen will eingeben|Gibt alle Wörter ein|Speichert die Wörter und Fragt sie ab. |
|2.1|User will Wörter eingebn|Gibt Wörter ein|Fragt die Wörter ab.|
|3.1|User will wörter eingeben|gibt die ziffer "1" ein|Programm gibt eine Fehlermeldung aus|
|4.1|User ist am Wörter lernen|Gibt ein Wort falsch ein|Programm gibt eine Meldung aus, dass das Wort falsch war und dass das Wort erneut abgefragt wird|
|5.1|User hat alle Wörter bereits durchgelernt|Benutzer gibt ein, dass er die Wörter erneut lernen will|Programm fragt die eingegebenen Wörter erneut ab|
|6.1|User ist am Wörter lernen|Gibt weiterhin Wörter ein |bekommt einen Anzeige, wie viele Wörter er noch lernen muss|

### 1.4 Diagramme
![pap](https://user-images.githubusercontent.com/111043950/201072346-345bd0a3-9232-48e0-a1f2-2c1266d10b3b.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  03.11|   Jan Frey     |Zu lernende Wörter müssen eingegeben werden können.|      45min        |
| 2.A  |  03.11|  Ben Müller         |Wörter sollen abgefragt werden.|     60min |
| 3.A  |  03.11|   Gian-Marco Mileti        |Fehler(Formatfehler) sollen erkannt und angezeigt werden.    |     45min          |
| 4.A  |  10.11|  Damian Eisenring         |Falsch eingegebene Wörter sollen konkret angezeigt werden.            |     90min          |
| 5.A  |  10.11| Jan Frey         |Die Wörter sollen mehrmals gelernt werden können.        |      60min         |
| 6.A  |  10.11|  Damian Eisenring  |Eine Anzeige für die Anzahl falscher Wörter.    |    90min         |

Total: 450 min / 7h 30 min

## 3 Entscheiden

Wir habe uns entschieden alle User Stories zu machen.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  03.11     |   Jan Frey        |    45min        |       60min            |
| 2.A |    03.11   |  Ben Müller         |      60min         |         75min         |
| 3.A | 03.11 | Gian-Marco Mileti | 45min | 45min|
|4.A|10.11|Damian Eisenring|90min|60min|
|5.A|10.11|Jan Frey|60min|45min|
|6.A|10.11|Damian Eisenring|90min|75min|


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.


## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.


