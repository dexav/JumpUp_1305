# Projekt-Dokumentation

Nursiwat & Grigioni

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 03/05/2024      | 0.0.1  |  Informieren gemacht                                                            |
| 17/05/2024      | 0.0.2   | Planen, Entscheiden und einbisschen Realisieren(movement und Animation erstellt) |
| 24/05/2024      | 0.0.3  | weiter Realisiert                                                       |
| 07/06/2024      | 0.1.0   |Realiseren knapp fertig. Nur noch Start- und Pausebildschirm            |
| 14/06/2024      | 1.0.0   |  Kontrollieren und Auswerten fertig. Start- und Pausebildschirm noch gemacht.|


## 1 Informieren

### 1.1 Ihr Projekt

Ein 2D Plattformer Game, wo man Vertikal, so weit wie möglich, nach oben kommen musss, indem man auf einzelne Plattformen springen muss.


Es ist ein Spiel, welches auf das Spiel Doodle Jump angelehnt ist. Wir wollen so ein Spiel machen, weil wir wieder mal ein Game entwickeln möchten. Dabei wollen wir lernen wie man mit Unity umgeht und wollen unser Wissen über Gamedevelopment erweitern.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | muss               |  Funktional    | Als ein Spieler möchte ich meinen Charakter bewegen, damit ich auf Plattformen springen kann. |
| 2  |  Muss               |Funktional      | Als ein Spieler möchte ich, dass der Bildschirm nach oben scrollt, damit ich sehen kann, wohin ich springen muss.|
| 3 | Muss                |  Funktional    |Als ein Spieler möchte ich Punkte sammeln, damit ich meinen Fortschritt im Spiel verfolgen kann.|
| 4  | Muss                | Funktional     |Als ein Spieler möchte ich, dass mein Charakter fällt, wenn ich eine Plattform verpasse, damit das Spiel eine Herausforderung bietet.|
| 5 | Muss               | Qualität     | Als ein Spieler möchte ich reibungslose und flüssige Animationen, damit das Spielerlebnis angenehm ist.|
| 6  | Muss                |Funktional      |Als ein Spieler möchte ich Power-Ups einsammeln können, damit ich temporäre Vorteile im Spiel habe.|
| 7  | Muss                |Qualität      |Als ein Spieler möchte ich visuelle und akustische Rückmeldungen bei jedem Sprung, damit das Spiel interaktiver und spannender ist.|
| 8  |  Muss               | Funktional     | Als Spieler möchte ich dass die Kamera den Spieler folgt, damit ich mich orientieren kann wo ich gerade bin.|
| 9  |  Muss               | Funktional     |  Als ein Spieler möchte ich verschiedene Charaktere auswählen können, damit ich eine personalisierte Spielerfahrung habe. |
| 10  |  Muss               |Qualität      |Als ein Spieler möchte ich ein ansprechendes und intuitives Benutzerinterface, damit ich das Spiel leicht navigieren kann.|
| 11 | Muss                |Rand	      | Als ein Entwickler möchte ich den Fortschritt des Spiels speichern können, damit Spieler ihre Sitzungen fortsetzen können. |
| 12  | Muss             | Funktional        | Als ein Spieler möchte ich Hindernissen ausweichen müssen, damit das Spiel herausfordernder und spannender ist. |
| 13  | Muss            | Funktional        |	Als ein Spieler möchte ich, dass die Plattformen zufällig generiert werden, damit das Spiel jedes Mal anders ist.                   |
| 14  |   Muss           | Qualität      | Als ein Spieler möchte ich ein Tutorial oder eine Anleitung, damit ich schnell lerne, wie man das Spiel spielt.                    |
| 15  |  kann           | Qualität        |Als ein Spieler möchte ich verschiedene Hintergrundmusik und Soundeffekte, damit das Spiel akustisch ansprechend ist.                   |


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |Das Spiel ist gestartet, der Charakter ist sichtbar.	              |Pfeiltasten         | Der Charakter bewegt sich nach links oder rechts.                  |
| 2.1  |Der Charakter steht auf einer Plattform.	              |Sprungtaste drücken.	         |Der Charakter springt nach oben.|
| 3.1  |Der Charakter springt auf eine Plattform über der aktuellen Bildschirmposition.	              |         |Der Bildschirm scrollt nach oben und zeigt den neuen Bereich.|
| 4.1  |Der Charakter springt auf eine Plattform oder sammelt einen Punkt ein.	              |         | Die Punktzahl erhöht sich um einen Punkt.|
| 5.1  |Der Charakter verfehlt eine Plattform und fällt.	              |         |  Die Animationen sind flüssig und ohne Ruckeln.|
| 6.1  |Ein Power-Up ist auf der Plattform.	              | Der Charakter berührt das Power-Up.	        |  Der Charakter erhält temporäre Vorteile wie höhere Sprünge .|
| 7.1  | Der Charakter springt oder landet auf einer Plattform.	             |         | Ein visueller Effekt und ein Ton werden abgespielt.|
| 8.1  | Das Spiel ist gestartet           |WASD        | Die Kamera verfolgt den Spieler|
| 9.1  |Das Spiel ist gestartet.	              | Auswahlmenü für Charaktere öffnen.	        | Der Spieler kann verschiedene Charaktere sehen und auswählen.|
| 10.1  | Das Spiel ist gestartet.	             |Benutzerinterface verwenden.	         |Das Interface ist intuitiv bedienbar, Schaltflächen und Menüs reagieren korrekt.|
| 11.1  |Der Spieler hat Fortschritte im Spiel gemacht.	              |Spiel speichern.	         |Der aktuelle Fortschritt wird gespeichert und kann beim nächsten Start fortgesetzt werden.|
| 12.1  | Der Charakter bewegt sich nach oben.	             | Hindernis erscheint auf dem Bildschirm.	        |Der Spieler muss dem Hindernis ausweichen, um weiter zu kommen.|
| 13.1  | Das Spiel ist gestartet.	             |Neue Plattformen generieren.	         |Plattformen erscheinen zufällig, jedes Spiel ist anders.|
| 14.1  |Das Spiel ist gestartet.	              | Tutorial oder Anleitung starten.	        |Das Tutorial erklärt die grundlegenden Spielmechaniken klar und verständlich.|
| 15.1  |Das Spiel ist gestartet.	              | Hintergrundmusik und Soundeffekte einschalten.	        | Unterschiedliche Musikstücke und Soundeffekte werden abgespielt und verbessern das Spielerlebnis. |



### 1.4 Diagramme

![JumpUp](https://github.com/dexav/JumpUp_1305/assets/110892637/e1576a86-6d79-4571-a96b-4cd6cd71b2ce)


## 2 Planen

| AP-№ | Frist    | Zuständig | Beschreibung                                      | geplante Zeit |
|-------|----------|-----------|---------------------------------------------------|---------------|
| 1.A   |24.05.2024 | Xavier Nursiwat          | Implementierung der Charakterbewegung             | 45'           |
| 1.B   | 24.05.2024 | Xavier Nursiwat           | Implementierung der Sprungmechanik                | 45'           |
| 2.A   | 24.05.2024 | Xavier Nursiwat           | Implementierung des Bildschirm-Scrollings         | 45'           |
| 3.A   | 31.05.2024 |Leonardo Grigioni           | Hinzufügen der Punktesammelfunktion               | 45'           |
| 4.A   | 31.05.2024 |Leonardo Grigioni              | Implementierung des Fallens bei Plattformverlust  | 45'           |
| 5.A   | 31.05.2024 | Xavier Nursiwat           | Optimierung der Animationen                       | 45'           |
| 6.A   | 31.05.2024 |Leonardo Grigioni              | Hinzufügen von Power-Ups                          | 45'           |
| 7.A   | 31.05.2024 |Leonardo Grigioni              | Implementierung visueller Rückmeldungen           | 45'           |
| 7.B   | 31.05.2024 |Leonardo Grigioni              | Implementierung akustischer Rückmeldungen         | 45'           |
| 8.A   | 31.05.2024 | Xavier Nursiwat           | Implementierung Kameraverfolgung                  | 45'           |
| 9.A   | 07.06.2024 | Xavier Nursiwat           | Implementierung der Charakterauswahl              | 45'           |
| 10.A  | 07.06.2024 | Xavier Nursiwat           | Design des Benutzerinterfaces                     | 45'           |
| 10.B  | 07.06.2024 | Xavier Nursiwat           | Implementierung des Benutzerinterfaces            | 45'           |
| 11.A  | 07.06.2024 |  Xavier Nursiwat          | Implementierung der Speicherfunktion              | 45'           |
| 12.A  | 07.06.2024 |Leonardo Grigioni              | Hinzufügen von Hindernissen                       | 45'           |
| 13.A  | 24.05.2024 | Xavier Nursiwat           | Implementierung der zufälligen Plattform-Generierung | 45'       |
| 14.A  |07.06.2024|  Leonardo Grigioni            | Erstellung des Tutorials                          | 45'           |
| 15.A  |07.06.2024 | Leonardo Grigioni             | Auswahl und Hinzufügen von Hintergrundmusik       | 45'           |
| 15.B  | 07.06.2024 | Xavier Nursiwat           | Auswahl und Hinzufügen von Soundeffekten          | 45'           |



Total: 1080min / 18h



## 3 Entscheiden


Wir haben uns etnschieden das SPiel mit einem Tutorial zu machen. Das Design wollen so viel wie möglich selbst erstellen. Dazu wird warscheinlich die Nutzung von KI dazukommen.

Tutorial: https://youtube.com/playlist?list=PLgOEwFbvGm5o8hayFB6skAfa8Z-mw4dPV&si=fguIKwhLjXNgty5P
Design: https://craftpix.net/freebies/page/3/

## 4 Realisieren

| AP -№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| -------| ----------| -----------| ---------------------------------------------------| ---------------|
| 1.A | 24.05.2024 | Xavier Nursiwat           |         | 45'           |
| 1.B   | 24.05.2024 | Xavier Nursiwat           |  | 45'           |
| 2.A   | 24.05.2024 | Xavier Nursiwat           |  | 45'           |
| 3.A   | 31.05.2024 | Leonardo Grigioni             |  | 45'           |
| 4.A   | 31.05.2024 | Leonardo Grigioni             |  | 45'           |
| 5.A   | 31.05.2024 |Xavier Nursiwat            |  | 45'           |
| 6.A   | 31.05.2024 | Leonardo Grigioni             |  | 45'           |
| 7.A   | 31.05.2024 | Leonardo Grigioni             |  | 45'           |
| 7.B   | 31.05.2024 | Leonardo Grigioni             |  | 45'           |
| 8.A   | 31.05.2024 |Xavier Nursiwat           | 50 | 45'           |
| 9.A   | 07.06.2024 | Xavier Nursiwat           |  | 45'           |
| 10.A  | 07.06.2024 |Xavier Nursiwat            |  | 45'           |
| 10.B  | 07.06.2024 |Xavier Nursiwat            |  | 45'           |
| 11.A  | 07.06.2024 |Xavier Nursiwat            |  | 45'           |
| 12.A  | 07.06.2024 |  Leonardo Grigioni            |  | 45'           |
| 13.A  | 24.05.2024 |Xavier Nursiwat           || 45'       |
| 14.A  |07.06.2024|  Leonardo Grigioni            | | 45'           |
| 15.A  |07.06.2024 |  Leonardo Grigioni            | | 45'           |
| 15.B  | 07.06.2024 |Xavier Nursiwat           |  | 45'           |




## 5 Kontrollieren

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
