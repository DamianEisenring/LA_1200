# de ben und de jan hend sich ganz fest gern

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

Flamingo

Müller, Mileti, Frey, Eisenring

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

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
|7.1|User hat alle wörter gelernt|keine|Zeigt alle Wörter an, die er in dem durchlauf falsch hatte|


### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  03.11|           |Zu lernende Wörter müssen eingegeben werden können.|               |
| 2.A  |  03.11|           |Wörter sollen abgefragt werden.|               |
| 3.A  |  03.11|           |Fehler(Formatfehler) sollen erkannt und angezeigt werden.    |               |
| 4.A  |  10.11|           |Falsch eingegebene Wörter sollen konkret angezeigt werden.            |               |
| 5.A  |  10.11|           |Die Wörter sollen mehrmals gelernt werden können.        |               |
| 6.A  |  10.11|           |Eine Anzeige für  die Anzahl falscher Wörter.    |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
