# Taschenrechner Engine
<img style="height:200px; float:right; padding:0 0 10px 10px" src="assets/calculator.webp">

Wir kennen alle Taschenrechner. Wir geben ``1 + 2 * 3`` ein und er gibt ``7`` aus. In dieser Aufgabe soll aber kein funktionsfähiger Taschenrechner gebaut werden, sondern eine Engine, die einen [Baum](https://de.wikipedia.org/wiki/Baum_(Datenstruktur)) aufbaut, der die Rechenoperationen darstellt, die auch beliebig kombiniert werden können und ausrechnet.

Dazu muss erstmal analyisert werden, welche Arten von Rechenoperationen existieren und wie diese aufgebaut sind. Dabei geht es jetzt weniger um die Grundrechenarten, sondern um die abstrakte Struktur der Rechenoperationen. In der Mathematik spricht man auch von Verknüpfungen. Wir werden uns hier auf die [einstelligen-](https://de.wikipedia.org/wiki/Einstellige_Verkn%C3%BCpfung) und [zweistelligen](https://de.wikipedia.org/wiki/Zweistellige_Verkn%C3%BCpfung) Verknüpfungen konzentrieren.

Im ersten Schritt überlege dir, dafür Interfaces als UML-Diagramm. Dafür kann [PlantUML](https://plantuml.com/) hilfreich sein. PlantUML ist ein Tool, das es ermöglicht, UML-Diagramme in Textform zu beschreiben und daraus Bilder zu generieren.

Als Gedankenstütze gebe ich dir folgendes Beispiel vor:

<div align="center">

`` - (1 + 2 * 3)``

![](assets/term.svg)
</div>

